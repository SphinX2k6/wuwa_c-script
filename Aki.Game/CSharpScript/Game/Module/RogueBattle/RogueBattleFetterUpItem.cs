using System;
using System.Collections.Generic;
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
	// Token: 0x02003E26 RID: 15910
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleFetterUpItem : GridProxyAbstract<IRogueBattleRoleBondUpdateInfo>
	{
		// Token: 0x06028946 RID: 166214 RVA: 0x00B62E30 File Offset: 0x00B61030
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

		// Token: 0x06028947 RID: 166215 RVA: 0x00B62F31 File Offset: 0x00B61131
		protected override void OnStart()
		{
			this.StarLvLayout = new GenericLayout<MapRogueFetterStarLvItem, IFetterStarLvData>(base.GetHorizontalLayout(7), new Func<MapRogueFetterStarLvItem>(this.OnCreateItem), null, false, true);
		}

		// Token: 0x06028948 RID: 166216 RVA: 0x00B62F54 File Offset: 0x00B61154
		[NullableContext(1)]
		private MapRogueFetterStarLvItem OnCreateItem()
		{
			return new MapRogueFetterStarLvItem();
		}

		// Token: 0x06028949 RID: 166217 RVA: 0x00B62F5C File Offset: 0x00B6115C
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
			}
			else
			{
				this.StarLvLayout.SetActive(false);
			}
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0602894A RID: 166218 RVA: 0x00B631A0 File Offset: 0x00B613A0
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleFetterUpItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleFetterUpItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602894B RID: 166219 RVA: 0x00B631E3 File Offset: 0x00B613E3
		protected override void OnBeforeHide()
		{
			this.RemoveTimer();
		}

		// Token: 0x0602894C RID: 166220 RVA: 0x00B631EB File Offset: 0x00B613EB
		public void PlayExpAnimation()
		{
			IRogueBattleRoleBondUpdateInfo data = this.Data;
			if (data != null && data.OldRoleBondInfo.TargetStar == 0)
			{
				return;
			}
			this.RemoveTimer();
		}

		// Token: 0x0602894D RID: 166221 RVA: 0x00B63210 File Offset: 0x00B61410
		protected void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0602894E RID: 166222 RVA: 0x00B63234 File Offset: 0x00B61434
		private void OnBtnDetail()
		{
			IRogueBattleRoleBondUpdateInfo data = this.Data;
			int? fetterId = (data != null) ? new int?(data.OldRoleBondInfo.ConfigId) : null;
			MapRogueController.Instance.OpenRogueFetterView(fetterId);
		}

		// Token: 0x0401606C RID: 90220
		private TimerHandle TimerHandle;

		// Token: 0x0401606D RID: 90221
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401606E RID: 90222
		private IRogueBattleRoleBondUpdateInfo Data;

		// Token: 0x0401606F RID: 90223
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapRogueFetterStarLvItem, IFetterStarLvData> StarLvLayout;
	}
}
