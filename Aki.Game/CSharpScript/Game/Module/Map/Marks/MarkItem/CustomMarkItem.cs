using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054DB RID: 21723
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomMarkItem : ServerMarkItem
	{
		// Token: 0x17008528 RID: 34088
		// (get) Token: 0x06037772 RID: 227186 RVA: 0x00D2CC6A File Offset: 0x00D2AE6A
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.Custom;
			}
		}

		// Token: 0x17008529 RID: 34089
		// (get) Token: 0x06037773 RID: 227187 RVA: 0x00D2CC6E File Offset: 0x00D2AE6E
		public bool IsNewCustomMarkItem
		{
			get
			{
				return this.IsNew;
			}
		}

		// Token: 0x1700852A RID: 34090
		// (get) Token: 0x06037774 RID: 227188 RVA: 0x00D2CC76 File Offset: 0x00D2AE76
		public override bool PermanentUpdate
		{
			get
			{
				return base.PermanentUpdate || this.IsNewCustomMarkItem;
			}
		}

		// Token: 0x06037775 RID: 227189 RVA: 0x00D2CC88 File Offset: 0x00D2AE88
		public override bool IsMultiMap()
		{
			return false;
		}

		// Token: 0x06037776 RID: 227190 RVA: 0x00D2CC8B File Offset: 0x00D2AE8B
		public CustomMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x06037777 RID: 227191 RVA: 0x00D2CC98 File Offset: 0x00D2AE98
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			TTrackTarget_Vector ttrackTarget_Vector = serverMarkInfo.TrackTarget as TTrackTarget_Vector;
			if (ttrackTarget_Vector != null)
			{
				global::Vector vector = global::Vector.Create(ttrackTarget_Vector.Value.X, -ttrackTarget_Vector.Value.Y, ttrackTarget_Vector.Value.Z);
				global::Vector value = MapUtil.UiPosition2WorldPosition(vector, vector);
				base.SetTrackData(new TTrackTarget_Vector(value));
			}
			else
			{
				TTrackTarget_Vector2D ttrackTarget_Vector2D = serverMarkInfo.TrackTarget as TTrackTarget_Vector2D;
				if (ttrackTarget_Vector2D != null)
				{
					global::Vector vector2 = global::Vector.Create(ttrackTarget_Vector2D.Value.X, ttrackTarget_Vector2D.Value.Y, 0.0);
					global::Vector vector3 = MapUtil.UiPosition2WorldPosition(vector2, vector2);
					base.SetTrackData(new TTrackTarget_Vector2D(new Vector2D(vector3.X, vector3.Y)));
				}
				else
				{
					Log.Instance.Error(ELogModule.Map, ELogAuthor.LK, "未定义的类型", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			base.MarkItemEntity.ViewLifeCircle.EnableVerticalPointer = false;
			this.SetConfigId(base.ConfigId);
			CustomMark? config = ConfigCustomMarkByMarkId.GetConfig(base.ConfigId, true);
			base.ShowPriority = ((config != null) ? config.GetValueOrDefault().ShowPriority : 0);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x06037778 RID: 227192 RVA: 0x00D2CDCB File Offset: 0x00D2AFCB
		[PreserveBaseOverrides]
		protected new virtual CustomMarkItemView CreateView()
		{
			return new CustomMarkItemView(this);
		}

		// Token: 0x06037779 RID: 227193 RVA: 0x00D2CDD3 File Offset: 0x00D2AFD3
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.CustomMarkItemView;
		}

		// Token: 0x0603777A RID: 227194 RVA: 0x00D2CDD6 File Offset: 0x00D2AFD6
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x0603777B RID: 227195 RVA: 0x00D2CDEC File Offset: 0x00D2AFEC
		public void OnSetConfigId(int configId)
		{
			CustomMark? customMarkConfig = MapConfig.Instance.GetCustomMarkConfig(configId);
			this.OnAfterSetConfigId(new MarkItemData
			{
				ShowRange = customMarkConfig.Value.ShowRange(),
				MarkPic = customMarkConfig.Value.MarkPic,
				ShowPriority = new int?(customMarkConfig.Value.ShowPriority),
				Scale = new float?(customMarkConfig.Value.Scale)
			});
		}

		// Token: 0x0603777C RID: 227196 RVA: 0x00D2CE6E File Offset: 0x00D2B06E
		public void SetIsNew(bool isNew)
		{
			this.IsNew = isNew;
		}

		// Token: 0x0603777D RID: 227197 RVA: 0x00D2CE77 File Offset: 0x00D2B077
		[NullableContext(2)]
		public override string GetTitleText()
		{
			return TextConfig.Instance.GetTextById("CustomMarkName");
		}

		// Token: 0x0603777E RID: 227198 RVA: 0x00D2CE88 File Offset: 0x00D2B088
		public override bool CheckCanShowView()
		{
			if (base.MapType == EMapType.MiniMap)
			{
				return WorldMapModel.Instance.CustomMarksIsShow;
			}
			return WorldMapModel.Instance.CustomMarksIsShow && base.CheckCanShowView();
		}

		// Token: 0x0603777F RID: 227199 RVA: 0x00D2CEB2 File Offset: 0x00D2B0B2
		protected override bool CheckCanShowInBoxArea()
		{
			return base.MapType != EMapType.WorldMap || !WorldMapModel.Instance.IsCustomMarkDisabled;
		}

		// Token: 0x06037780 RID: 227200 RVA: 0x00D2CECC File Offset: 0x00D2B0CC
		public override bool GetInteractiveFlag()
		{
			return !this.IsNewCustomMarkItem && base.GetInteractiveFlag();
		}

		// Token: 0x06037781 RID: 227201 RVA: 0x00D2CEDE File Offset: 0x00D2B0DE
		public override ESecondaryPanel GetSecondaryUiType()
		{
			return ESecondaryPanel.CustomMarkPanel;
		}

		// Token: 0x0401D396 RID: 119702
		public bool IsCreated;

		// Token: 0x0401D397 RID: 119703
		private bool IsNew;
	}
}
