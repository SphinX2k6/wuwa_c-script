using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CDF RID: 7391
public class RoleTowerPauseTokenItem : UiPanelBase
{
	// Token: 0x060124AF RID: 74927 RVA: 0x00564F48 File Offset: 0x00563148
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(8, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUIItem)));
		}
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x060124B0 RID: 74928 RVA: 0x0056505E File Offset: 0x0056325E
	protected override void OnStart()
	{
		this.Refresh();
		if (this.CdTickHandle == null)
		{
			this.CdTickHandle = TimerSystem.RealTimeInstance.Forever(delegate(float _)
			{
				this.RefreshCdDisplay();
			}, 100f, 1f, null, null, true);
		}
	}

	// Token: 0x060124B1 RID: 74929 RVA: 0x00565097 File Offset: 0x00563297
	protected override void OnBeforeShow()
	{
		this.Refresh();
	}

	// Token: 0x060124B2 RID: 74930 RVA: 0x0056509F File Offset: 0x0056329F
	protected override void OnBeforeDestroy()
	{
		if (this.CdTickHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.CdTickHandle);
			this.CdTickHandle = null;
		}
	}

	// Token: 0x060124B3 RID: 74931 RVA: 0x005650C4 File Offset: 0x005632C4
	public void Refresh()
	{
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(9);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		int equipTokenId = RoleTowerModel.Instance.GetEquipTokenId();
		RoleTowerToken? roleTowerToken = (equipTokenId > 0) ? RoleTowerModel.Instance.GetTokenCfg(equipTokenId) : null;
		int num = (roleTowerToken != null) ? RoleTowerModel.Instance.GetItemCount(roleTowerToken.Value.ItemId) : 0;
		bool flag = equipTokenId > 0 && roleTowerToken != null;
		UUIItem item3 = base.GetItem(6);
		if (item3 != null)
		{
			item3.SetUIActive(equipTokenId > 0);
		}
		if (flag)
		{
			UUIItem item4 = base.GetItem(7);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
			UUITexture texture = base.GetTexture(1);
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(roleTowerToken.Value.ItemId);
			if (texture != null && itemConfigData != null)
			{
				texture.SetUIActive(true);
				base.SetTextureByPath(itemConfigData.IconMiddle ?? string.Empty, texture, null, null);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(num.ToString(), true);
			}
			this.RefreshCdDisplay();
			return;
		}
		UUIItem item5 = base.GetItem(7);
		if (item5 != null)
		{
			item5.SetUIActive(true);
		}
		UUITexture texture2 = base.GetTexture(1);
		if (texture2 != null)
		{
			texture2.SetUIActive(false);
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetText("0", true);
		}
		UUIItem item6 = base.GetItem(3);
		if (item6 != null)
		{
			item6.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(4);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x060124B4 RID: 74932 RVA: 0x00565258 File Offset: 0x00563458
	private double GetCurTokenCdMs()
	{
		int equipTokenId = RoleTowerModel.Instance.GetEquipTokenId();
		RoleTowerToken? roleTowerToken = (equipTokenId > 0) ? RoleTowerModel.Instance.GetTokenCfg(equipTokenId) : null;
		if (roleTowerToken == null)
		{
			return 0.0;
		}
		return (double)roleTowerToken.Value.UseCd * 1000.0;
	}

	// Token: 0x060124B5 RID: 74933 RVA: 0x005652B8 File Offset: 0x005634B8
	private void RefreshCdDisplay()
	{
		double serverCombatStopTime = Time.Instance.ServerCombatStopTime;
		bool flag = RoleTowerModel.Instance.GetTokenCdEndTime() > serverCombatStopTime;
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUISprite sprite = base.GetSprite(4);
		if (sprite != null)
		{
			sprite.SetUIActive(flag);
		}
		if (!flag)
		{
			return;
		}
		double num = RoleTowerModel.Instance.GetTokenCdEndTime() - serverCombatStopTime;
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(((int)Math.Ceiling(num / 1000.0)).ToString(), true);
		}
		double curTokenCdMs = this.GetCurTokenCdMs();
		float value = (curTokenCdMs > 0.0) ? ((float)(num / curTokenCdMs)) : 0f;
		if (sprite != null)
		{
			sprite.SetFillAmount(Math.Clamp(value, 0f, 1f));
		}
	}

	// Token: 0x04009FA4 RID: 40868
	private const float CdTickIntervalMs = 100f;

	// Token: 0x04009FA5 RID: 40869
	[Nullable(2)]
	private TimerHandle CdTickHandle;

	// Token: 0x02007FDB RID: 32731
	private static class EChildType
	{
		// Token: 0x040295C8 RID: 169416
		public const int Btn = 0;

		// Token: 0x040295C9 RID: 169417
		public const int TexIcon = 1;

		// Token: 0x040295CA RID: 169418
		public const int TxtCount = 2;

		// Token: 0x040295CB RID: 169419
		public const int PnlCdMask = 3;

		// Token: 0x040295CC RID: 169420
		public const int SprBgFill = 4;

		// Token: 0x040295CD RID: 169421
		public const int TxtCd = 5;

		// Token: 0x040295CE RID: 169422
		public const int PnlCount = 6;

		// Token: 0x040295CF RID: 169423
		public const int PnlEmpty = 7;

		// Token: 0x040295D0 RID: 169424
		public const int TouchMax = 8;

		// Token: 0x040295D1 RID: 169425
		public const int KeyItemLeft = 8;

		// Token: 0x040295D2 RID: 169426
		public const int KeyItemRight = 9;
	}
}
