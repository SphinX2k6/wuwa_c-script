using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045B9 RID: 17849
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FetterItem : GridProxyAbstract<IRogueBattleRoleBondUpdateInfo>
	{
		// Token: 0x0602CF29 RID: 184105 RVA: 0x00C91E94 File Offset: 0x00C90094
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnFetterClick))
			};
		}

		// Token: 0x0602CF2A RID: 184106 RVA: 0x00C91F69 File Offset: 0x00C90169
		protected override void OnStart()
		{
			this.StarLvLayout = new GenericLayout<MapRogueFetterStarLvItem, IFetterStarLvData>(base.GetHorizontalLayout(4), new Func<MapRogueFetterStarLvItem>(this.OnCreateItem), null, false, true);
		}

		// Token: 0x0602CF2B RID: 184107 RVA: 0x00C91F8C File Offset: 0x00C9018C
		public override void Refresh(IRogueBattleRoleBondUpdateInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RoleBondInfo newRoleBondInfo = data.NewRoleBondInfo;
			UUITexture texture = base.GetTexture(2);
			UUIText text = base.GetText(6);
			UUIText text2 = base.GetText(3);
			UUISprite sprite = base.GetSprite(1);
			if (newRoleBondInfo.ConfigId == 0)
			{
				texture.SetUIActive(false);
				text.SetUIActive(false);
				return;
			}
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(newRoleBondInfo.ConfigId);
			RogueResBondLv? bondLvConfigByLv = RogueBattleConfig.Instance.GetBondLvConfigByLv(newRoleBondInfo.Level);
			if (rogueResBond == null || bondLvConfigByLv == null)
			{
				return;
			}
			base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, texture, null);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = newRoleBondInfo.Level == 0;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			FColor color = FColor.FromHex(bondLvConfigByLv.Value.LvColor);
			sprite.SetColor(color);
			sprite.SetUIActive(newRoleBondInfo.Level > 0);
			UUIItem uuiitem2 = text2;
			bool bUseChangeColor2 = newRoleBondInfo.Level == 0;
			fcolor = new FColor?(text2.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			LguiUtil.Instance.SetLocalTextNew(text2, rogueResBond.Value.Name, Array.Empty<object>());
			text.SetText(newRoleBondInfo.CurStar.ToString(), true);
			text.SetUIActive(true);
			List<IFetterStarLvData> list = new List<IFetterStarLvData>();
			List<DicIntInt> list2 = new List<DicIntInt>(rogueResBond.Value.StarMapIter());
			list2.Sort((DicIntInt a, DicIntInt b) => a.Key - b.Key);
			if (list2.Count > 0)
			{
				int key = list2[list2.Count - 1].Key;
				foreach (DicIntInt dicIntInt in list2)
				{
					int key2 = dicIntInt.Key;
					int value = dicIntInt.Value;
					FetterStarLvData item = new FetterStarLvData
					{
						StageLv = key2,
						StageStarLv = value,
						CurrentLv = newRoleBondInfo.Level,
						MaxLv = key
					};
					list.Add(item);
				}
				this.StarLvLayout.RefreshByData(list, null, true);
				return;
			}
			this.StarLvLayout.SetActive(false);
		}

		// Token: 0x0602CF2C RID: 184108 RVA: 0x00C921E4 File Offset: 0x00C903E4
		private MapRogueFetterStarLvItem OnCreateItem()
		{
			return new MapRogueFetterStarLvItem();
		}

		// Token: 0x0602CF2D RID: 184109 RVA: 0x00C921EB File Offset: 0x00C903EB
		public void SetButtonActive(bool bActive)
		{
			base.GetButton(0).SetSelfInteractive(bActive);
		}

		// Token: 0x0602CF2E RID: 184110 RVA: 0x00C921FA File Offset: 0x00C903FA
		private void OnBtnFetterClick()
		{
			Action<IRogueBattleRoleBondUpdateInfo> openMenuFunc = this.OpenMenuFunc;
			if (openMenuFunc == null)
			{
				return;
			}
			openMenuFunc(this.Data);
		}

		// Token: 0x0401815F RID: 98655
		protected IRogueBattleRoleBondUpdateInfo Data;

		// Token: 0x04018160 RID: 98656
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<MapRogueFetterStarLvItem, IFetterStarLvData> StarLvLayout;

		// Token: 0x04018161 RID: 98657
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IRogueBattleRoleBondUpdateInfo> OpenMenuFunc;
	}
}
