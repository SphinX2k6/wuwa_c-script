using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044D2 RID: 17618
	[NullableContext(1)]
	[Nullable(0)]
	public class TreasureBoxMarkItem : ServerMarkItem
	{
		// Token: 0x17005936 RID: 22838
		// (get) Token: 0x0602C845 RID: 182341 RVA: 0x00C80D83 File Offset: 0x00C7EF83
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.TreasureBox;
			}
		}

		// Token: 0x17005937 RID: 22839
		// (get) Token: 0x0602C846 RID: 182342 RVA: 0x00C80D87 File Offset: 0x00C7EF87
		public bool IsNewCustomMarkItem
		{
			get
			{
				return this.IsNew;
			}
		}

		// Token: 0x0602C847 RID: 182343 RVA: 0x00C80D8F File Offset: 0x00C7EF8F
		public TreasureBoxMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x0602C848 RID: 182344 RVA: 0x00C80D9C File Offset: 0x00C7EF9C
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			this.SetConfigId(base.ConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C849 RID: 182345 RVA: 0x00C80DD4 File Offset: 0x00C7EFD4
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.TreasureBoxMarkItemView;
		}

		// Token: 0x0602C84A RID: 182346 RVA: 0x00C80DD8 File Offset: 0x00C7EFD8
		[PreserveBaseOverrides]
		protected new virtual TreasureBoxMarkItemView CreateView()
		{
			return new TreasureBoxMarkItemView(this);
		}

		// Token: 0x0602C84B RID: 182347 RVA: 0x00C80DE0 File Offset: 0x00C7EFE0
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x0602C84C RID: 182348 RVA: 0x00C80DF8 File Offset: 0x00C7EFF8
		public void OnSetConfigId(int configId)
		{
			TreasureBoxMark? treasureBoxMarkConfig = MapConfig.Instance.GetTreasureBoxMarkConfig(configId);
			this.OnAfterSetConfigId(new MarkItemData
			{
				MarkPic = treasureBoxMarkConfig.Value.MarkPic,
				Scale = new float?(treasureBoxMarkConfig.Value.Scale),
				ShowPriority = new int?(treasureBoxMarkConfig.Value.ShowPriority),
				ShowRange = treasureBoxMarkConfig.Value.ShowRange()
			});
		}

		// Token: 0x0602C84D RID: 182349 RVA: 0x00C80E7A File Offset: 0x00C7F07A
		public void SetIsNew(bool isNew)
		{
			this.IsNew = isNew;
		}

		// Token: 0x0602C84E RID: 182350 RVA: 0x00C80E84 File Offset: 0x00C7F084
		[NullableContext(2)]
		public override string GetTitleText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTreasureBoxMarkConfig(base.ConfigId).Value.MarkTitle, null);
		}

		// Token: 0x0602C84F RID: 182351 RVA: 0x00C80EB8 File Offset: 0x00C7F0B8
		[NullableContext(2)]
		public string GetDescText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTreasureBoxMarkConfig(base.ConfigId).Value.MarkDesc, null);
		}

		// Token: 0x0602C850 RID: 182352 RVA: 0x00C80EEB File Offset: 0x00C7F0EB
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x04017E88 RID: 97928
		public int DetectorId;

		// Token: 0x04017E89 RID: 97929
		private bool IsNew;
	}
}
