using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.MingSu;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044C2 RID: 17602
	[NullableContext(1)]
	[Nullable(0)]
	public class MingSuNpcMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C775 RID: 182133 RVA: 0x00C7DDC1 File Offset: 0x00C7BFC1
		public MingSuNpcMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C776 RID: 182134 RVA: 0x00C7DDD7 File Offset: 0x00C7BFD7
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.MingSuNpcMarkItemView;
		}

		// Token: 0x0602C777 RID: 182135 RVA: 0x00C7DDDB File Offset: 0x00C7BFDB
		[PreserveBaseOverrides]
		protected new virtual MingSuNpcMarkItemView CreateView()
		{
			return new MingSuNpcMarkItemView(this);
		}

		// Token: 0x17005908 RID: 22792
		// (get) Token: 0x0602C778 RID: 182136 RVA: 0x00C7DDE3 File Offset: 0x00C7BFE3
		public bool IsTowerEntrance
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsTowerEntrance(base.MarkConfigId);
			}
		}

		// Token: 0x0602C779 RID: 182137 RVA: 0x00C7DDF8 File Offset: 0x00C7BFF8
		protected override bool IsGamePlayFinish()
		{
			MapMark value = base.MarkConfig.Value;
			if (value.RelativeType == 1 && base.MarkConfig.Value.RelativeSubType == 5)
			{
				int relativeId = value.RelativeId;
				return MingSuModel.Instance.GetDarkCoastDeliveryDataByLevelPlayId(relativeId).GetDarkCoastDeliveryGuardState() == MingSuDefine.EDarkCoastDeliveryLevelDataState.Received;
			}
			return false;
		}

		// Token: 0x0602C77A RID: 182138 RVA: 0x00C7DE54 File Offset: 0x00C7C054
		protected override void InitIcon()
		{
			this.UpdateIconPath();
		}

		// Token: 0x0602C77B RID: 182139 RVA: 0x00C7DE5C File Offset: 0x00C7C05C
		public override void UpdateIconPath()
		{
			if (base.MarkConfig.Value.RelativeSubType != 11)
			{
				this.IconPath = base.MarkConfig.Value.LockMarkPic;
				return;
			}
			if (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male)
			{
				this.IconPath = UiResourceConfig.Instance.GetResourcePath("SP_IconMapNpc009");
				return;
			}
			this.IconPath = UiResourceConfig.Instance.GetResourcePath("SP_IconMapNpc010");
		}
	}
}
