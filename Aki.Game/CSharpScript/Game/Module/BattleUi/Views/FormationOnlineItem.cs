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
	// Token: 0x02004D0A RID: 19722
	[NullableContext(1)]
	[Nullable(0)]
	public class FormationOnlineItem : UiPanelBase
	{
		// Token: 0x060316E3 RID: 202467 RVA: 0x00DD1CC4 File Offset: 0x00DCFEC4
		public FormationOnlineItem(UUIItem rootUiItem)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_FigthRoleHeadOnline", rootUiItem, false).Forget();
		}

		// Token: 0x060316E4 RID: 202468 RVA: 0x00DD1CE0 File Offset: 0x00DCFEE0
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

		// Token: 0x060316E5 RID: 202469 RVA: 0x00DD1DCD File Offset: 0x00DCFFCD
		protected override void OnStart()
		{
			this.DisconnectSequencePlayer = new LevelSequencePlayer(base.GetItem(1));
			this.ClearAllHandle();
		}

		// Token: 0x060316E6 RID: 202470 RVA: 0x00DD1DE7 File Offset: 0x00DCFFE7
		protected override void OnBeforeDestroy()
		{
			this.DisconnectSequencePlayer.Clear();
			this.DisconnectSequencePlayer = null;
		}

		// Token: 0x060316E7 RID: 202471 RVA: 0x00DD1DFB File Offset: 0x00DCFFFB
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

		// Token: 0x060316E8 RID: 202472 RVA: 0x00DD1E20 File Offset: 0x00DD0020
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

		// Token: 0x060316E9 RID: 202473 RVA: 0x00DD1E6C File Offset: 0x00DD006C
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

		// Token: 0x060316EA RID: 202474 RVA: 0x00DD1EF8 File Offset: 0x00DD00F8
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

		// Token: 0x060316EB RID: 202475 RVA: 0x00DD1F4F File Offset: 0x00DD014F
		public void SetNetWeak(bool isWeak)
		{
			if (base.InAsyncLoading())
			{
				this.IsWeak = isWeak;
				return;
			}
			base.GetItem(0).SetUIActive(isWeak);
		}

		// Token: 0x060316EC RID: 202476 RVA: 0x00DD1F70 File Offset: 0x00DD0170
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

		// Token: 0x060316ED RID: 202477 RVA: 0x00DD1FC0 File Offset: 0x00DD01C0
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

		// Token: 0x060316EE RID: 202478 RVA: 0x00DD2010 File Offset: 0x00DD0210
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

		// Token: 0x060316EF RID: 202479 RVA: 0x00DD205B File Offset: 0x00DD025B
		public void SetNetDisconnect(bool isDisconnect)
		{
			if (base.InAsyncLoading())
			{
				this.IsDisconnect = isDisconnect;
				return;
			}
			this.SetDisconnectStatus(isDisconnect);
		}

		// Token: 0x060316F0 RID: 202480 RVA: 0x00DD2074 File Offset: 0x00DD0274
		private void SetDisconnectStatus(bool isDisconnect)
		{
			base.GetItem(1).SetUIActive(isDisconnect);
			this.DisconnectSequencePlayer.StopCurrentSequence(false, false);
			if (isDisconnect)
			{
				this.DisconnectSequencePlayer.PlayLevelSequenceByName("AutoLoop", false, null, false);
			}
		}

		// Token: 0x060316F1 RID: 202481 RVA: 0x00DD20BC File Offset: 0x00DD02BC
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

		// Token: 0x0401A2DD RID: 107229
		[Nullable(2)]
		private string NameHandle;

		// Token: 0x0401A2DE RID: 107230
		private int? OnlineNumberHandle;

		// Token: 0x0401A2DF RID: 107231
		[Nullable(2)]
		private string CurrentThirdPartyAccountId;

		// Token: 0x0401A2E0 RID: 107232
		private bool IsGrayByOtherControl;

		// Token: 0x0401A2E1 RID: 107233
		private bool IsWeak;

		// Token: 0x0401A2E2 RID: 107234
		private bool IsDisconnect;

		// Token: 0x0401A2E3 RID: 107235
		[Nullable(2)]
		private LevelSequencePlayer DisconnectSequencePlayer;

		// Token: 0x0200A9B9 RID: 43449
		[NullableContext(0)]
		private enum EFormationOnlineItem
		{
			// Token: 0x0403471C RID: 214812
			NetWeakItem,
			// Token: 0x0403471D RID: 214813
			PanelDisconnect,
			// Token: 0x0403471E RID: 214814
			OnlineNumberTexture,
			// Token: 0x0403471F RID: 214815
			NameText,
			// Token: 0x04034720 RID: 214816
			ThirdPartyTexture,
			// Token: 0x04034721 RID: 214817
			PcItem
		}
	}
}
