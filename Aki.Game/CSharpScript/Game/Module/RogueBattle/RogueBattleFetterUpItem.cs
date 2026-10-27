using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E5D RID: 20061
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleFetterUpItem : GridProxyAbstract<IRogueBattleRoleBondUpdateInfo>
	{
		// Token: 0x06033ADB RID: 211675 RVA: 0x00C19908 File Offset: 0x00C17B08
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action(this.OnBtnDetail))
			};
		}

		// Token: 0x06033ADC RID: 211676 RVA: 0x00C19A09 File Offset: 0x00C17C09
		protected override void OnStart()
		{
			this.StarLvLayout = new GenericLayout<MapRogueFetterStarLvItem, IFetterStarLvData>(base.GetHorizontalLayout(7), new Func<MapRogueFetterStarLvItem>(this.OnCreateItem), null, false, true);
		}

		// Token: 0x06033ADD RID: 211677 RVA: 0x00C19A2C File Offset: 0x00C17C2C
		[NullableContext(1)]
		private MapRogueFetterStarLvItem OnCreateItem()
		{
			return new MapRogueFetterStarLvItem();
		}

		// Token: 0x06033ADE RID: 211678 RVA: 0x00C19A34 File Offset: 0x00C17C34
		[NullableContext(1)]
		public override void Refresh(IRogueBattleRoleBondUpdateInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RoleBondInfo newRoleBondInfo = data.NewRoleBondInfo;
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(newRoleBondInfo.ConfigId);
			RogueResBondLv? bondLvConfigByLv = RogueBattleConfig.Instance.GetBondLvConfigByLv(newRoleBondInfo.Level);
			if (rogueResBond == null || bondLvConfigByLv == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(1);
			base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, texture, null);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = newRoleBondInfo.Level == 0;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			UUISprite sprite = base.GetSprite(0);
			FColor color = FColor.FromHex(bondLvConfigByLv.Value.LvColor);
			sprite.SetColor(color);
			sprite.SetUIActive(newRoleBondInfo.Level > 0);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueResBond.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "RogueRes_FightFormation_RoleLevel", new <>z__ReadOnlySingleElementList<object>(newRoleBondInfo.Level));
			base.GetText(5).SetText(newRoleBondInfo.CurStar.ToString(), true);
			List<IFetterStarLvData> list = new List<IFetterStarLvData>();
			List<DicIntInt> list2 = rogueResBond.Value.StarMapIter().ToList<DicIntInt>();
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
			}
			else
			{
				this.StarLvLayout.SetActive(false);
			}
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x06033ADF RID: 211679 RVA: 0x00C19C78 File Offset: 0x00C17E78
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleFetterUpItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleFetterUpItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033AE0 RID: 211680 RVA: 0x00C19CBB File Offset: 0x00C17EBB
		protected override void OnBeforeHide()
		{
			this.RemoveTimer();
		}

		// Token: 0x06033AE1 RID: 211681 RVA: 0x00C19CC3 File Offset: 0x00C17EC3
		public void PlayExpAnimation()
		{
			IRogueBattleRoleBondUpdateInfo data = this.Data;
			if (data != null && data.OldRoleBondInfo.TargetStar == 0)
			{
				return;
			}
			this.RemoveTimer();
		}

		// Token: 0x06033AE2 RID: 211682 RVA: 0x00C19CE8 File Offset: 0x00C17EE8
		protected void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06033AE3 RID: 211683 RVA: 0x00C19D0C File Offset: 0x00C17F0C
		private void OnBtnDetail()
		{
			IRogueBattleRoleBondUpdateInfo data = this.Data;
			int? fetterId = (data != null) ? new int?(data.OldRoleBondInfo.ConfigId) : null;
			MapRogueController.Instance.OpenRogueFetterView(fetterId);
		}

		// Token: 0x0401B699 RID: 112281
		private TimerHandle TimerHandle;

		// Token: 0x0401B69A RID: 112282
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B69B RID: 112283
		private IRogueBattleRoleBondUpdateInfo Data;

		// Token: 0x0401B69C RID: 112284
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapRogueFetterStarLvItem, IFetterStarLvData> StarLvLayout;
	}
}
