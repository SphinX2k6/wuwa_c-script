using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AF2 RID: 15090
	internal class TowerDefenseInBattlePanel : BattleChildView
	{
		// Token: 0x06026C25 RID: 158757 RVA: 0x00AD7260 File Offset: 0x00AD5460
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026C26 RID: 158758 RVA: 0x00AD7350 File Offset: 0x00AD5550
		protected override void OnStart()
		{
			this.SeqPlayer = new UiSequencePlayer(this.RootItem);
			this.ContentLayout = new GenericLayout<TowerDefenseInBattleInfoItem, ITowerDefensePhantomSkillItemInBattleData>(base.GetVerticalLayout(4), new Func<TowerDefenseInBattleInfoItem>(TowerDefenseController.Instance.BuildPhantomSkillInBattleItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06026C27 RID: 158759 RVA: 0x00AD73A3 File Offset: 0x00AD55A3
		protected override void OnAfterShow()
		{
			UiSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.LiteStop();
			}
			UiSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 == null)
			{
				return;
			}
			seqPlayer2.LitePlayAsync("Start", false, false);
		}

		// Token: 0x06026C28 RID: 158760 RVA: 0x00AD73D0 File Offset: 0x00AD55D0
		protected override UniTask OnBeforeHideAsync()
		{
			TowerDefenseInBattlePanel.<OnBeforeHideAsync>d__6 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<TowerDefenseInBattlePanel.<OnBeforeHideAsync>d__6>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026C29 RID: 158761 RVA: 0x00AD7413 File Offset: 0x00AD5613
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.LiteExit();
			}
			this.SeqPlayer = null;
		}

		// Token: 0x06026C2A RID: 158762 RVA: 0x00AD7430 File Offset: 0x00AD5630
		[NullableContext(1)]
		public UniTask GetOrCreateAsync(UUIItem parent, string resourceId)
		{
			TowerDefenseInBattlePanel.<GetOrCreateAsync>d__8 <GetOrCreateAsync>d__;
			<GetOrCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GetOrCreateAsync>d__.<>4__this = this;
			<GetOrCreateAsync>d__.parent = parent;
			<GetOrCreateAsync>d__.resourceId = resourceId;
			<GetOrCreateAsync>d__.<>1__state = -1;
			<GetOrCreateAsync>d__.<>t__builder.Start<TowerDefenseInBattlePanel.<GetOrCreateAsync>d__8>(ref <GetOrCreateAsync>d__);
			return <GetOrCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026C2B RID: 158763 RVA: 0x00AD7484 File Offset: 0x00AD5684
		public void Refresh()
		{
			int currentPhantomItemIdInBattle = TowerDefenseController.Instance.GetCurrentPhantomItemIdInBattle();
			base.SetItemIcon(base.GetTexture(0), currentPhantomItemIdInBattle, null, null);
			string currentPhantomQualitySpritePathInBattle = TowerDefenseController.Instance.GetCurrentPhantomQualitySpritePathInBattle();
			base.TrySetSpriteByPath((currentPhantomQualitySpritePathInBattle == "") ? null : currentPhantomQualitySpritePathInBattle, base.GetSprite(1), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), TowerDefenseController.Instance.BuildCurrentPhantomNameTextIdInBattle(), Array.Empty<object>());
			UUIText text = base.GetText(3);
			bool flag = TowerDefenseController.Instance.CheckInBossRushInstance();
			text.SetUIActive(flag);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(text, TowerDefenseController.Instance.GetNextLevelUnlockDescriptionInBattle() ?? "", Array.Empty<object>());
			}
			List<ITowerDefensePhantomSkillItemInBattleData> data = TowerDefenseController.Instance.BuildPhantomSkillInBattleLayoutData();
			GenericLayout<TowerDefenseInBattleInfoItem, ITowerDefensePhantomSkillItemInBattleData> contentLayout = this.ContentLayout;
			if (contentLayout == null)
			{
				return;
			}
			contentLayout.RefreshByData(data, null, false);
		}

		// Token: 0x04015339 RID: 86841
		private bool Created;

		// Token: 0x0401533A RID: 86842
		[Nullable(2)]
		private UiSequencePlayer SeqPlayer;

		// Token: 0x0401533B RID: 86843
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<TowerDefenseInBattleInfoItem, ITowerDefensePhantomSkillItemInBattleData> ContentLayout;

		// Token: 0x020096E6 RID: 38630
		private class EPanelComponent
		{
			// Token: 0x0402F187 RID: 192903
			public const int IconTex = 0;

			// Token: 0x0402F188 RID: 192904
			public const int QualitySprite = 1;

			// Token: 0x0402F189 RID: 192905
			public const int NameTxt = 2;

			// Token: 0x0402F18A RID: 192906
			public const int DescTxt = 3;

			// Token: 0x0402F18B RID: 192907
			public const int InfoLayout = 4;

			// Token: 0x0402F18C RID: 192908
			public const int InfoItem = 5;
		}
	}
}
