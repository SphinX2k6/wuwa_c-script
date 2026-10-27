using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060D3 RID: 24787
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public abstract class SolarSpeedRolePanelBase : GridProxyAbstract<ISolarSpeedRolePanelData>
	{
		// Token: 0x0603EA95 RID: 256661 RVA: 0x00F223D2 File Offset: 0x00F205D2
		protected void HandleOnClickFunction()
		{
			ISolarSpeedRolePanelData dataCache = this.DataCache;
			bool flag;
			if (dataCache == null)
			{
				flag = false;
			}
			else
			{
				int playerId = dataCache.PlayerId;
				flag = true;
			}
			if (flag)
			{
				ActivitySolarSpeedController.Instance.HandleClickPlayerInResultView(this.DataCache.PlayerId);
			}
		}

		// Token: 0x0603EA96 RID: 256662 RVA: 0x00F22400 File Offset: 0x00F20600
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUINiagara)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUITexture)),
				new ValueTuple<int, Type>(15, typeof(UUITexture)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.HandleOnClickFunction))
			};
		}

		// Token: 0x0603EA97 RID: 256663 RVA: 0x00F225E8 File Offset: 0x00F207E8
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedRolePanelBase.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedRolePanelBase.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA98 RID: 256664 RVA: 0x00F2262C File Offset: 0x00F2082C
		[NullableContext(2)]
		private void SetMedalTexture(string path)
		{
			UUITexture texture = base.GetTexture(8);
			if (path != null && !StringUtils.IsBlank(path))
			{
				texture.SetUIActive(true);
				base.SetTextureByPath(path, texture, null, null);
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x0603EA99 RID: 256665 RVA: 0x00F22670 File Offset: 0x00F20870
		public override void Refresh(ISolarSpeedRolePanelData data, bool isSelected, int gridIndex)
		{
			this.DataCache = data;
			this.RoleItem.Refresh(data.IconData);
			UUIButtonComponent button = base.GetButton(7);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(data.IsAddButtonAvailable);
			}
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			FColor color = FColor.FromHex(data.MedalColorHex);
			UUITexture texture = base.GetTexture(0);
			if (texture != null)
			{
				texture.SetColor(color);
			}
			FColor color2 = FColor.FromHex(data.FxColorHex);
			UUINiagara uiNiagara = base.GetUiNiagara(9);
			if (uiNiagara != null)
			{
				uiNiagara.SetColor(color2);
			}
			base.SetTextureByPath(data.BgPath, base.GetTexture(1), null, null);
			this.SetMedalTexture(data.MedalTexturePath);
			base.TrySetSpriteByPath(data.PlayerIndexIconPath, base.GetSprite(3), false, null, null);
			UUIText text = base.GetText(6);
			if (text != null)
			{
				text.SetText(data.NameText, true);
			}
			this.OnRefresh(data);
		}

		// Token: 0x0603EA9A RID: 256666 RVA: 0x00F22774 File Offset: 0x00F20974
		public void RefreshAddFriendByPlayerIdExternal(int playerId)
		{
			ISolarSpeedRolePanelData dataCache = this.DataCache;
			if (dataCache == null)
			{
				return;
			}
			if (playerId == dataCache.PlayerId && dataCache.IsAddButtonAvailable)
			{
				UUIItem item = base.GetItem(10);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIButtonComponent button = base.GetButton(7);
				if (button == null)
				{
					return;
				}
				button.RootUIComp.Get().SetUIActive(false);
			}
		}

		// Token: 0x0603EA9B RID: 256667 RVA: 0x00F227D0 File Offset: 0x00F209D0
		protected void SetFriendItemState(bool isShow)
		{
			UUIItem item = base.GetItem(17);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x0603EA9C RID: 256668 RVA: 0x00F227E5 File Offset: 0x00F209E5
		protected virtual void OnRefresh(ISolarSpeedRolePanelData data)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), data.DescTextId, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), data.TitleTextId, Array.Empty<object>());
		}

		// Token: 0x04020C2E RID: 134190
		[Nullable(2)]
		protected ISolarSpeedRolePanelData DataCache;

		// Token: 0x04020C2F RID: 134191
		protected SolarSpeedRoleIconPanel RoleItem;
	}
}
