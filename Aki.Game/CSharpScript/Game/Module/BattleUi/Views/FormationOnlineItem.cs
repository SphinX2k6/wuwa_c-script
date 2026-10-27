using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D28 RID: 23848
	[NullableContext(1)]
	[Nullable(0)]
	public class FormationOnlineItem : UiPanelBase
	{
		// Token: 0x0603C78A RID: 247690 RVA: 0x00E81524 File Offset: 0x00E7F724
		public FormationOnlineItem(UUIItem rootUiItem)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_FigthRoleHeadOnline", rootUiItem, false).Forget();
		}

		// Token: 0x0603C78B RID: 247691 RVA: 0x00E81540 File Offset: 0x00E7F740
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C78C RID: 247692 RVA: 0x00E8162D File Offset: 0x00E7F82D
		protected override void OnStart()
		{
			this.DisconnectSequencePlayer = new LevelSequencePlayer(base.GetItem(1));
			this.ClearAllHandle();
		}

		// Token: 0x0603C78D RID: 247693 RVA: 0x00E81647 File Offset: 0x00E7F847
		protected override void OnBeforeDestroy()
		{
			this.DisconnectSequencePlayer.Clear();
			this.DisconnectSequencePlayer = null;
		}

		// Token: 0x0603C78E RID: 247694 RVA: 0x00E8165B File Offset: 0x00E7F85B
		public void SetNameText(string name)
		{
			if (base.InAsyncLoading())
			{
				this.NameHandle = name;
				return;
			}
			this.NameHandle = name;
			this.SetNameTextAsync(name).Forget();
		}

		// Token: 0x0603C78F RID: 247695 RVA: 0x00E81680 File Offset: 0x00E7F880
		private UniTask SetNameTextAsync(string name)
		{
			FormationOnlineItem.<SetNameTextAsync>d__13 <SetNameTextAsync>d__;
			<SetNameTextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetNameTextAsync>d__.<>4__this = this;
			<SetNameTextAsync>d__.name = name;
			<SetNameTextAsync>d__.<>1__state = -1;
			<SetNameTextAsync>d__.<>t__builder.Start<FormationOnlineItem.<SetNameTextAsync>d__13>(ref <SetNameTextAsync>d__);
			return <SetNameTextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C790 RID: 247696 RVA: 0x00E816CC File Offset: 0x00E7F8CC
		public void SetOnlineNumber(int onlineNumber)
		{
			if (base.InAsyncLoading())
			{
				this.OnlineNumberHandle = new int?(onlineNumber);
				return;
			}
			UUITexture texture = base.GetTexture(2);
			if (onlineNumber < 0)
			{
				texture.SetUIActive(false);
				return;
			}
			texture.SetUIActive(true);
			UiResourceConfig instance = UiResourceConfig.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("FormationOnline");
			defaultInterpolatedStringHandler.AppendFormatted<int>(onlineNumber);
			defaultInterpolatedStringHandler.AppendLiteral("PIcon");
			string resourcePath = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x0603C791 RID: 247697 RVA: 0x00E81758 File Offset: 0x00E7F958
		public void SetIsGrayByOtherControl(bool isGray)
		{
			if (base.InAsyncLoading())
			{
				this.IsGrayByOtherControl = isGray;
				return;
			}
			UUITexture texture = base.GetTexture(2);
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isGray, fcolor);
			UUIText text = base.GetText(3);
			UUIItem uuiitem2 = text;
			fcolor = new FColor?(text.changeColor);
			uuiitem2.SetChangeColor(isGray, fcolor);
		}

		// Token: 0x0603C792 RID: 247698 RVA: 0x00E817AF File Offset: 0x00E7F9AF
		public void SetNetWeak(bool isWeak)
		{
			if (base.InAsyncLoading())
			{
				this.IsWeak = isWeak;
				return;
			}
			base.GetItem(0).SetUIActive(isWeak);
		}

		// Token: 0x0603C793 RID: 247699 RVA: 0x00E817D0 File Offset: 0x00E7F9D0
		public void RefreshThirdPartyItem(string thirdPartyAccountId)
		{
			if (base.InAsyncLoading())
			{
				this.CurrentThirdPartyAccountId = thirdPartyAccountId;
				return;
			}
			this.CurrentThirdPartyAccountId = thirdPartyAccountId;
			this.RefreshThirdPartyItemAsync(thirdPartyAccountId).Forget();
			this.RefreshPcItem(thirdPartyAccountId);
			if (this.NameHandle != null)
			{
				this.SetNameTextAsync(this.NameHandle).Forget();
			}
		}

		// Token: 0x0603C794 RID: 247700 RVA: 0x00E81820 File Offset: 0x00E7FA20
		private void RefreshPcItem(string thirdPartyAccountId)
		{
			if (KuroSdkController.Instance.NeedShowThirdPartyId())
			{
				bool flag = thirdPartyAccountId != string.Empty;
				UUIItem item = base.GetItem(5);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(!flag);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(5);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0603C795 RID: 247701 RVA: 0x00E81870 File Offset: 0x00E7FA70
		private UniTask RefreshThirdPartyItemAsync(string thirdPartyAccountId)
		{
			FormationOnlineItem.<RefreshThirdPartyItemAsync>d__19 <RefreshThirdPartyItemAsync>d__;
			<RefreshThirdPartyItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshThirdPartyItemAsync>d__.<>4__this = this;
			<RefreshThirdPartyItemAsync>d__.thirdPartyAccountId = thirdPartyAccountId;
			<RefreshThirdPartyItemAsync>d__.<>1__state = -1;
			<RefreshThirdPartyItemAsync>d__.<>t__builder.Start<FormationOnlineItem.<RefreshThirdPartyItemAsync>d__19>(ref <RefreshThirdPartyItemAsync>d__);
			return <RefreshThirdPartyItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C796 RID: 247702 RVA: 0x00E818BB File Offset: 0x00E7FABB
		public void SetNetDisconnect(bool isDisconnect)
		{
			if (base.InAsyncLoading())
			{
				this.IsDisconnect = isDisconnect;
				return;
			}
			this.SetDisconnectStatus(isDisconnect);
		}

		// Token: 0x0603C797 RID: 247703 RVA: 0x00E818D4 File Offset: 0x00E7FAD4
		private void SetDisconnectStatus(bool isDisconnect)
		{
			base.GetItem(1).SetUIActive(isDisconnect);
			this.DisconnectSequencePlayer.StopCurrentSequence(false, false);
			if (isDisconnect)
			{
				this.DisconnectSequencePlayer.PlayLevelSequenceByName("AutoLoop", false, null, false);
			}
		}

		// Token: 0x0603C798 RID: 247704 RVA: 0x00E8191C File Offset: 0x00E7FB1C
		private void ClearAllHandle()
		{
			if (this.NameHandle != null)
			{
				this.SetNameText(this.NameHandle);
				this.NameHandle = null;
			}
			if (this.OnlineNumberHandle != null)
			{
				this.SetOnlineNumber(this.OnlineNumberHandle.Value);
				this.OnlineNumberHandle = null;
			}
			if (this.CurrentThirdPartyAccountId != null)
			{
				this.RefreshThirdPartyItem(this.CurrentThirdPartyAccountId);
				this.CurrentThirdPartyAccountId = null;
			}
			base.GetItem(0).SetUIActive(this.IsWeak);
			this.SetDisconnectStatus(this.IsDisconnect);
			this.SetIsGrayByOtherControl(this.IsGrayByOtherControl);
		}

		// Token: 0x0401F824 RID: 129060
		[Nullable(2)]
		private string NameHandle;

		// Token: 0x0401F825 RID: 129061
		private int? OnlineNumberHandle;

		// Token: 0x0401F826 RID: 129062
		[Nullable(2)]
		private string CurrentThirdPartyAccountId;

		// Token: 0x0401F827 RID: 129063
		private bool IsGrayByOtherControl;

		// Token: 0x0401F828 RID: 129064
		private bool IsWeak;

		// Token: 0x0401F829 RID: 129065
		private bool IsDisconnect;

		// Token: 0x0401F82A RID: 129066
		[Nullable(2)]
		private LevelSequencePlayer DisconnectSequencePlayer;

		// Token: 0x0200BFB3 RID: 49075
		[NullableContext(0)]
		private enum EFormationOnlineItem
		{
			// Token: 0x04039D5A RID: 236890
			NetWeakItem,
			// Token: 0x04039D5B RID: 236891
			PanelDisconnect,
			// Token: 0x04039D5C RID: 236892
			OnlineNumberTexture,
			// Token: 0x04039D5D RID: 236893
			NameText,
			// Token: 0x04039D5E RID: 236894
			ThirdPartyTexture,
			// Token: 0x04039D5F RID: 236895
			PcItem
		}
	}
}
