using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057FE RID: 22526
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RewardExploreFriendItem : GridProxyAbstract<IRewardExploreFriendData>
	{
		// Token: 0x06039455 RID: 234581 RVA: 0x00D94CB0 File Offset: 0x00D92EB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickAddButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039456 RID: 234582 RVA: 0x00D94DFB File Offset: 0x00D92FFB
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			EventSystem.Instance.Add<int>(EEventName.ApplicationSent, new Action<int>(this.ApplicationSent));
		}

		// Token: 0x06039457 RID: 234583 RVA: 0x00D94E1F File Offset: 0x00D9301F
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			EventSystem.Instance.Remove(EEventName.ApplicationSent, new Action<int>(this.ApplicationSent));
		}

		// Token: 0x06039458 RID: 234584 RVA: 0x00D94E44 File Offset: 0x00D93044
		[NullableContext(1)]
		public override void Refresh(IRewardExploreFriendData data, bool isSelected, int gridIndex)
		{
			this.DataCache = data;
			bool isMyFriend = data.IsMyFriend;
			base.GetSprite(5).SetUIActive(isMyFriend);
			base.GetTexture(6).SetUIActive(isMyFriend);
			base.SetButtonUiActive(4, !isMyFriend);
			base.SetTextureByPath(data.PlayerIconPath, base.GetTexture(0), null, null);
			base.SetTextureByPath(data.PlayerIndexPath, base.GetTexture(1), null, null);
			base.GetText(2).SetText(data.PlayerName, true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "TowerDefence_Rolename", new <>z__ReadOnlySingleElementList<object>(data.PlayerLevel));
		}

		// Token: 0x06039459 RID: 234585 RVA: 0x00D94EF8 File Offset: 0x00D930F8
		private void OnClickAddButton()
		{
			int playerId = this.DataCache.PlayerId;
			base.GetSprite(5).SetUIActive(true);
			base.GetTexture(6).SetUIActive(true);
			base.SetButtonUiActive(4, false);
			if (!this.DataCache.IsMyFriend)
			{
				this.DataCache.OnClickCallback(playerId);
			}
		}

		// Token: 0x0603945A RID: 234586 RVA: 0x00D94F51 File Offset: 0x00D93151
		private void ApplicationSent(int playerId)
		{
			if (playerId == this.DataCache.PlayerId)
			{
				base.SetButtonUiActive(4, false);
			}
		}

		// Token: 0x0401DF3C RID: 122684
		[Nullable(2)]
		private IRewardExploreFriendData DataCache;

		// Token: 0x0200B9F4 RID: 47604
		private class EComponent
		{
			// Token: 0x04038376 RID: 230262
			public const int PlayerIconTexture = 0;

			// Token: 0x04038377 RID: 230263
			public const int PlayerIndexTexture = 1;

			// Token: 0x04038378 RID: 230264
			public const int PlayerNameText = 2;

			// Token: 0x04038379 RID: 230265
			public const int PlayerDescText = 3;

			// Token: 0x0403837A RID: 230266
			public const int AddButton = 4;

			// Token: 0x0403837B RID: 230267
			public const int DoneSprite = 5;

			// Token: 0x0403837C RID: 230268
			public const int DoneMaskTexture = 6;
		}
	}
}
