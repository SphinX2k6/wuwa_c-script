using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005051 RID: 20561
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public abstract class SolarSpeedRolePanelBase : GridProxyAbstract<ISolarSpeedRolePanelData>
	{
		// Token: 0x06033759 RID: 210777 RVA: 0x00E6919A File Offset: 0x00E6739A
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

		// Token: 0x0603375A RID: 210778 RVA: 0x00E691C8 File Offset: 0x00E673C8
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

		// Token: 0x0603375B RID: 210779 RVA: 0x00E693B0 File Offset: 0x00E675B0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedRolePanelBase.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedRolePanelBase.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603375C RID: 210780 RVA: 0x00E693F4 File Offset: 0x00E675F4
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

		// Token: 0x0603375D RID: 210781 RVA: 0x00E69438 File Offset: 0x00E67638
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

		// Token: 0x0603375E RID: 210782 RVA: 0x00E6953C File Offset: 0x00E6773C
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

		// Token: 0x0603375F RID: 210783 RVA: 0x00E69598 File Offset: 0x00E67798
		protected void SetFriendItemState(bool isShow)
		{
			UUIItem item = base.GetItem(17);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x06033760 RID: 210784 RVA: 0x00E695AD File Offset: 0x00E677AD
		protected virtual void OnRefresh(ISolarSpeedRolePanelData data)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), data.DescTextId, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), data.TitleTextId, Array.Empty<object>());
		}

		// Token: 0x0401B55B RID: 111963
		[Nullable(2)]
		protected ISolarSpeedRolePanelData DataCache;

		// Token: 0x0401B55C RID: 111964
		protected SolarSpeedRoleIconPanel RoleItem;
	}
}
