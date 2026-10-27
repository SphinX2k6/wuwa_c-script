using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x020063A0 RID: 25504
	public class MultiMotorSettlementPlayerChampionItem : MultiMotorSettlementPlayerItem
	{
		// Token: 0x06040250 RID: 262736 RVA: 0x00F87988 File Offset: 0x00F85B88
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

		// Token: 0x06040251 RID: 262737 RVA: 0x00F87B3C File Offset: 0x00F85D3C
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

		// Token: 0x06040252 RID: 262738 RVA: 0x00F87B94 File Offset: 0x00F85D94
		protected override void RefreshRoleTexture(int skinId)
		{
			MotorOnlineRoleSkin? motorOnlineRoleSkinBySkinId = MultiMotorConfig.Instance.GetMotorOnlineRoleSkinBySkinId(skinId);
			if (motorOnlineRoleSkinBySkinId == null)
			{
				return;
			}
			base.SetTextureByPath(motorOnlineRoleSkinBySkinId.Value.RoleStand, base.GetTexture(0), null, null);
		}

		// Token: 0x06040253 RID: 262739 RVA: 0x00F87BDD File Offset: 0x00F85DDD
		[NullableContext(1)]
		protected override void RefreshChampionInfo(OnlineMotorSettleInfo data)
		{
			this.RefreshChampionCount(data.ChampionExtra.FirstCount);
		}

		// Token: 0x06040254 RID: 262740 RVA: 0x00F87BF0 File Offset: 0x00F85DF0
		private void RefreshChampionCount(int count)
		{
			base.GetText(9).SetText(count.ToString(), true);
		}

		// Token: 0x0200C5BD RID: 50621
		private class EChampionComponents
		{
			// Token: 0x0403BB3D RID: 244541
			public const int RoleTexture = 0;

			// Token: 0x0403BB3E RID: 244542
			public const int TagText = 1;

			// Token: 0x0403BB3F RID: 244543
			public const int Tag2Text = 2;

			// Token: 0x0403BB40 RID: 244544
			public const int TimeText = 3;

			// Token: 0x0403BB41 RID: 244545
			public const int OnlineNumberSprite = 4;

			// Token: 0x0403BB42 RID: 244546
			public const int PlayerNameText = 5;

			// Token: 0x0403BB43 RID: 244547
			public const int AddFriendBtn = 6;

			// Token: 0x0403BB44 RID: 244548
			public const int HaveApplyItem = 7;

			// Token: 0x0403BB45 RID: 244549
			public const int TagTextItem = 8;

			// Token: 0x0403BB46 RID: 244550
			public const int ChampionCountText = 9;
		}
	}
}
