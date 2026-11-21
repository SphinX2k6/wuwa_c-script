using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200531E RID: 21278
	public class MultiMotorSettlementPlayerChampionItem : MultiMotorSettlementPlayerItem
	{
		// Token: 0x06034F11 RID: 216849 RVA: 0x00ECE8C0 File Offset: 0x00ECCAC0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickAddFriendBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034F12 RID: 216850 RVA: 0x00ECEA74 File Offset: 0x00ECCC74
		protected override void RefreshTime(int time, bool isFinish)
		{
			if (time <= 0 || !isFinish)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "MultiMotorNotFinished", Array.Empty<object>());
				return;
			}
			string remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat5((double)time * TimeUtil.Instance.Millisecond);
			base.GetText(3).SetText(remainTimeDataFormat, true);
		}

		// Token: 0x06034F13 RID: 216851 RVA: 0x00ECEACC File Offset: 0x00ECCCCC
		protected override void RefreshRoleTexture(int skinId)
		{
			MotorOnlineRoleSkin? motorOnlineRoleSkinBySkinId = MultiMotorConfig.Instance.GetMotorOnlineRoleSkinBySkinId(skinId);
			if (motorOnlineRoleSkinBySkinId == null)
			{
				return;
			}
			base.SetTextureByPath(motorOnlineRoleSkinBySkinId.Value.RoleStand, base.GetTexture(0), null, null);
		}

		// Token: 0x06034F14 RID: 216852 RVA: 0x00ECEB15 File Offset: 0x00ECCD15
		[NullableContext(1)]
		protected override void RefreshChampionInfo(OnlineMotorSettleInfo data)
		{
			this.RefreshChampionCount(data.ChampionExtra.FirstCount);
		}

		// Token: 0x06034F15 RID: 216853 RVA: 0x00ECEB28 File Offset: 0x00ECCD28
		private void RefreshChampionCount(int count)
		{
			base.GetText(9).SetText(count.ToString(), true);
		}

		// Token: 0x0200AFA4 RID: 44964
		private class EChampionComponents
		{
			// Token: 0x0403649C RID: 222364
			public const int RoleTexture = 0;

			// Token: 0x0403649D RID: 222365
			public const int TagText = 1;

			// Token: 0x0403649E RID: 222366
			public const int Tag2Text = 2;

			// Token: 0x0403649F RID: 222367
			public const int TimeText = 3;

			// Token: 0x040364A0 RID: 222368
			public const int OnlineNumberSprite = 4;

			// Token: 0x040364A1 RID: 222369
			public const int PlayerNameText = 5;

			// Token: 0x040364A2 RID: 222370
			public const int AddFriendBtn = 6;

			// Token: 0x040364A3 RID: 222371
			public const int HaveApplyItem = 7;

			// Token: 0x040364A4 RID: 222372
			public const int TagTextItem = 8;

			// Token: 0x040364A5 RID: 222373
			public const int ChampionCountText = 9;
		}
	}
}
