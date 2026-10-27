using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054FE RID: 21758
	[NullableContext(1)]
	[Nullable(0)]
	public class TreasureBoxDetectorMarkItem : ServerMarkItem
	{
		// Token: 0x17008598 RID: 34200
		// (get) Token: 0x06037969 RID: 227689 RVA: 0x00D32C51 File Offset: 0x00D30E51
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.TreasureBoxDetector;
			}
		}

		// Token: 0x17008599 RID: 34201
		// (get) Token: 0x0603796A RID: 227690 RVA: 0x00D32C55 File Offset: 0x00D30E55
		public bool IsNewCustomMarkItem
		{
			get
			{
				return this.IsNew;
			}
		}

		// Token: 0x0603796B RID: 227691 RVA: 0x00D32C5D File Offset: 0x00D30E5D
		public TreasureBoxDetectorMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x0603796C RID: 227692 RVA: 0x00D32C6C File Offset: 0x00D30E6C
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			this.SetConfigId(base.ConfigId);
			base.MarkItemEntity.ViewLifeCircle.EnableVerticalPointer = false;
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0603796D RID: 227693 RVA: 0x00D32CB5 File Offset: 0x00D30EB5
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.TreasureBoxDetectorMarkItemView;
		}

		// Token: 0x0603796E RID: 227694 RVA: 0x00D32CB9 File Offset: 0x00D30EB9
		[PreserveBaseOverrides]
		protected new virtual TreasureBoxDetectorMarkItemView CreateView()
		{
			return new TreasureBoxDetectorMarkItemView(this);
		}

		// Token: 0x0603796F RID: 227695 RVA: 0x00D32CC1 File Offset: 0x00D30EC1
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x06037970 RID: 227696 RVA: 0x00D32CD8 File Offset: 0x00D30ED8
		public void OnSetConfigId(int configId)
		{
			TreasureBoxDetectorMark value = MapConfig.Instance.GetTreasureBoxDetectorMarkConfig(configId).Value;
			base.MarkItemEntity.GetOrAddComponent<MarkConfigComponent>(EMapComponent.MarkConfig).Config = value;
			this.OnAfterSetConfigId(new MarkItemData
			{
				MarkPic = value.MarkPic,
				Scale = new float?(value.Scale),
				ShowPriority = new int?(value.ShowPriority),
				ShowRange = value.ShowRange()
			});
		}

		// Token: 0x06037971 RID: 227697 RVA: 0x00D32D5A File Offset: 0x00D30F5A
		public void SetIsNew(bool isNew)
		{
			this.IsNew = isNew;
		}

		// Token: 0x06037972 RID: 227698 RVA: 0x00D32D64 File Offset: 0x00D30F64
		[NullableContext(2)]
		public override string GetTitleText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTreasureBoxDetectorMarkConfig(base.ConfigId).Value.MarkTitle, null);
		}

		// Token: 0x06037973 RID: 227699 RVA: 0x00D32D98 File Offset: 0x00D30F98
		[NullableContext(2)]
		public string GetDescText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTreasureBoxDetectorMarkConfig(base.ConfigId).Value.MarkDesc, null);
		}

		// Token: 0x0401D400 RID: 119808
		public int TeleportId;

		// Token: 0x0401D401 RID: 119809
		private bool IsNew;
	}
}
