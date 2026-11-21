using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047D5 RID: 18389
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RewardExploreFriendItem : GridProxyAbstract<IRewardExploreFriendData>
	{
		// Token: 0x0602E369 RID: 189289 RVA: 0x00CE3AFC File Offset: 0x00CE1CFC
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

		// Token: 0x0602E36A RID: 189290 RVA: 0x00CE3C47 File Offset: 0x00CE1E47
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			EventSystem.Instance.Add<int>(EEventName.ApplicationSent, new Action<int>(this.ApplicationSent));
		}

		// Token: 0x0602E36B RID: 189291 RVA: 0x00CE3C6B File Offset: 0x00CE1E6B
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			EventSystem.Instance.Remove(EEventName.ApplicationSent, new Action<int>(this.ApplicationSent));
		}

		// Token: 0x0602E36C RID: 189292 RVA: 0x00CE3C90 File Offset: 0x00CE1E90
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

		// Token: 0x0602E36D RID: 189293 RVA: 0x00CE3D44 File Offset: 0x00CE1F44
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

		// Token: 0x0602E36E RID: 189294 RVA: 0x00CE3D9D File Offset: 0x00CE1F9D
		private void ApplicationSent(int playerId)
		{
			if (playerId == this.DataCache.PlayerId)
			{
				base.SetButtonUiActive(4, false);
			}
		}

		// Token: 0x040189D3 RID: 100819
		[Nullable(2)]
		private IRewardExploreFriendData DataCache;

		// Token: 0x0200A40A RID: 41994
		private class EComponent
		{
			// Token: 0x04032D63 RID: 208227
			public const int PlayerIconTexture = 0;

			// Token: 0x04032D64 RID: 208228
			public const int PlayerIndexTexture = 1;

			// Token: 0x04032D65 RID: 208229
			public const int PlayerNameText = 2;

			// Token: 0x04032D66 RID: 208230
			public const int PlayerDescText = 3;

			// Token: 0x04032D67 RID: 208231
			public const int AddButton = 4;

			// Token: 0x04032D68 RID: 208232
			public const int DoneSprite = 5;

			// Token: 0x04032D69 RID: 208233
			public const int DoneMaskTexture = 6;
		}
	}
}
