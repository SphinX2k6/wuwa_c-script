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
	// Token: 0x020044AE RID: 17582
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomMarkItem : ServerMarkItem
	{
		// Token: 0x170058B2 RID: 22706
		// (get) Token: 0x0602C628 RID: 181800 RVA: 0x00C7AD16 File Offset: 0x00C78F16
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.Custom;
			}
		}

		// Token: 0x170058B3 RID: 22707
		// (get) Token: 0x0602C629 RID: 181801 RVA: 0x00C7AD1A File Offset: 0x00C78F1A
		public bool IsNewCustomMarkItem
		{
			get
			{
				return this.IsNew;
			}
		}

		// Token: 0x170058B4 RID: 22708
		// (get) Token: 0x0602C62A RID: 181802 RVA: 0x00C7AD22 File Offset: 0x00C78F22
		public override bool PermanentUpdate
		{
			get
			{
				return base.PermanentUpdate || this.IsNewCustomMarkItem;
			}
		}

		// Token: 0x170058B5 RID: 22709
		// (get) Token: 0x0602C62B RID: 181803 RVA: 0x00C7AD34 File Offset: 0x00C78F34
		public override bool EnableVerticalPointer
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602C62C RID: 181804 RVA: 0x00C7AD37 File Offset: 0x00C78F37
		public override bool IsMultiMap()
		{
			return false;
		}

		// Token: 0x0602C62D RID: 181805 RVA: 0x00C7AD3A File Offset: 0x00C78F3A
		public CustomMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x0602C62E RID: 181806 RVA: 0x00C7AD48 File Offset: 0x00C78F48
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
			this.SetConfigId(base.ConfigId);
			CustomMark? config = ConfigCustomMarkByMarkId.GetConfig(base.ConfigId, true);
			base.ShowPriority = ((config != null) ? config.GetValueOrDefault().ShowPriority : 0);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C62F RID: 181807 RVA: 0x00C7AE6A File Offset: 0x00C7906A
		[PreserveBaseOverrides]
		protected new virtual CustomMarkItemView CreateView()
		{
			return new CustomMarkItemView(this);
		}

		// Token: 0x0602C630 RID: 181808 RVA: 0x00C7AE72 File Offset: 0x00C79072
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.CustomMarkItemView;
		}

		// Token: 0x0602C631 RID: 181809 RVA: 0x00C7AE75 File Offset: 0x00C79075
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x0602C632 RID: 181810 RVA: 0x00C7AE8C File Offset: 0x00C7908C
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

		// Token: 0x0602C633 RID: 181811 RVA: 0x00C7AF0E File Offset: 0x00C7910E
		public void SetIsNew(bool isNew)
		{
			this.IsNew = isNew;
		}

		// Token: 0x0602C634 RID: 181812 RVA: 0x00C7AF17 File Offset: 0x00C79117
		[NullableContext(2)]
		public override string GetTitleText()
		{
			return TextConfig.Instance.GetTextById("CustomMarkName");
		}

		// Token: 0x0602C635 RID: 181813 RVA: 0x00C7AF28 File Offset: 0x00C79128
		public override bool CheckCanShowView()
		{
			if (base.MapType == EMapType.MiniMap)
			{
				return WorldMapModel.Instance.CustomMarksIsShow;
			}
			return WorldMapModel.Instance.CustomMarksIsShow && base.CheckCanShowView();
		}

		// Token: 0x0602C636 RID: 181814 RVA: 0x00C7AF52 File Offset: 0x00C79152
		protected override bool CheckCanShowInBoxArea()
		{
			return base.MapType != EMapType.WorldMap || !WorldMapModel.Instance.IsCustomMarkDisabled;
		}

		// Token: 0x0602C637 RID: 181815 RVA: 0x00C7AF6C File Offset: 0x00C7916C
		public override bool GetInteractiveFlag()
		{
			return !this.IsNewCustomMarkItem && base.GetInteractiveFlag();
		}

		// Token: 0x0602C638 RID: 181816 RVA: 0x00C7AF7E File Offset: 0x00C7917E
		public override ESecondaryPanel GetSecondaryUiType()
		{
			return ESecondaryPanel.CustomMarkPanel;
		}

		// Token: 0x04017E11 RID: 97809
		public bool IsCreated;

		// Token: 0x04017E12 RID: 97810
		private bool IsNew;
	}
}
