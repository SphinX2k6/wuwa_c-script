using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044D1 RID: 17617
	[NullableContext(1)]
	[Nullable(0)]
	public class TreasureBoxDetectorMarkItem : ServerMarkItem
	{
		// Token: 0x0602C838 RID: 182328 RVA: 0x00C80C19 File Offset: 0x00C7EE19
		public TreasureBoxDetectorMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x17005933 RID: 22835
		// (get) Token: 0x0602C839 RID: 182329 RVA: 0x00C80C26 File Offset: 0x00C7EE26
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.TreasureBoxDetector;
			}
		}

		// Token: 0x17005934 RID: 22836
		// (get) Token: 0x0602C83A RID: 182330 RVA: 0x00C80C2A File Offset: 0x00C7EE2A
		// (set) Token: 0x0602C83B RID: 182331 RVA: 0x00C80C32 File Offset: 0x00C7EE32
		public bool IsNewCustomMarkItem { get; private set; }

		// Token: 0x17005935 RID: 22837
		// (get) Token: 0x0602C83C RID: 182332 RVA: 0x00C80C3B File Offset: 0x00C7EE3B
		public override bool EnableVerticalPointer
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602C83D RID: 182333 RVA: 0x00C80C40 File Offset: 0x00C7EE40
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			this.SetConfigId(base.ConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C83E RID: 182334 RVA: 0x00C80C78 File Offset: 0x00C7EE78
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.TreasureBoxDetectorMarkItemView;
		}

		// Token: 0x0602C83F RID: 182335 RVA: 0x00C80C7C File Offset: 0x00C7EE7C
		[PreserveBaseOverrides]
		protected new virtual TreasureBoxDetectorMarkItemView CreateView()
		{
			return new TreasureBoxDetectorMarkItemView(this);
		}

		// Token: 0x0602C840 RID: 182336 RVA: 0x00C80C84 File Offset: 0x00C7EE84
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x0602C841 RID: 182337 RVA: 0x00C80C9C File Offset: 0x00C7EE9C
		public void OnSetConfigId(int configId)
		{
			TreasureBoxDetectorMark value = MapConfig.Instance.GetTreasureBoxDetectorMarkConfig(configId).Value;
			this.Config = new TreasureBoxDetectorMarkConfig(value);
			this.OnAfterSetConfigId(new MarkItemData
			{
				MarkPic = value.MarkPic,
				Scale = new float?(value.Scale),
				ShowPriority = new int?(value.ShowPriority),
				ShowRange = value.ShowRange()
			});
		}

		// Token: 0x0602C842 RID: 182338 RVA: 0x00C80D12 File Offset: 0x00C7EF12
		public void SetIsNew(bool isNew)
		{
			this.IsNewCustomMarkItem = isNew;
		}

		// Token: 0x0602C843 RID: 182339 RVA: 0x00C80D1C File Offset: 0x00C7EF1C
		[NullableContext(2)]
		public override string GetTitleText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTreasureBoxDetectorMarkConfig(base.ConfigId).Value.MarkTitle, null);
		}

		// Token: 0x0602C844 RID: 182340 RVA: 0x00C80D50 File Offset: 0x00C7EF50
		[NullableContext(2)]
		public string GetDescText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTreasureBoxDetectorMarkConfig(base.ConfigId).Value.MarkDesc, null);
		}

		// Token: 0x04017E86 RID: 97926
		public int TeleportId;
	}
}
