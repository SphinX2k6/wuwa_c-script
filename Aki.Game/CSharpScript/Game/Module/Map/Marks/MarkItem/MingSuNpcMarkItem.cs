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
	// Token: 0x020054EF RID: 21743
	[NullableContext(1)]
	[Nullable(0)]
	public class MingSuNpcMarkItem : ConfigMarkItem
	{
		// Token: 0x060378AA RID: 227498 RVA: 0x00D2FDD5 File Offset: 0x00D2DFD5
		public MingSuNpcMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x060378AB RID: 227499 RVA: 0x00D2FDEB File Offset: 0x00D2DFEB
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.MingSuNpcMarkItemView;
		}

		// Token: 0x060378AC RID: 227500 RVA: 0x00D2FDEF File Offset: 0x00D2DFEF
		[PreserveBaseOverrides]
		protected new virtual MingSuNpcMarkItemView CreateView()
		{
			return new MingSuNpcMarkItemView(this);
		}

		// Token: 0x1700856F RID: 34159
		// (get) Token: 0x060378AD RID: 227501 RVA: 0x00D2FDF7 File Offset: 0x00D2DFF7
		public bool IsTowerEntrance
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsTowerEntrance(base.MarkConfigId);
			}
		}

		// Token: 0x060378AE RID: 227502 RVA: 0x00D2FE0C File Offset: 0x00D2E00C
		protected override bool GamePlayIsFinish()
		{
			MapMark value = this.MarkConfig.Value;
			if (value.RelativeType == 1 && this.MarkConfig.Value.RelativeSubType == 5)
			{
				int relativeId = value.RelativeId;
				return MingSuModel.Instance.GetDarkCoastDeliveryDataByLevelPlayId(relativeId).GetDarkCoastDeliveryGuardState() == MingSuDefine.EDarkCoastDeliveryLevelDataState.Received;
			}
			return false;
		}

		// Token: 0x060378AF RID: 227503 RVA: 0x00D2FE62 File Offset: 0x00D2E062
		protected override void InitIcon()
		{
			this.UpdateIconPath();
		}

		// Token: 0x060378B0 RID: 227504 RVA: 0x00D2FE6C File Offset: 0x00D2E06C
		public override void UpdateIconPath()
		{
			if (this.MarkConfig.Value.RelativeSubType != 11)
			{
				this.IconPath = this.MarkConfig.Value.LockMarkPic;
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
