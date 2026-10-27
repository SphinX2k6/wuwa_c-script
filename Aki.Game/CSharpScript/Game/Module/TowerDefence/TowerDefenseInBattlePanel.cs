using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004B4A RID: 19274
	internal class TowerDefenseInBattlePanel : BattleChildView
	{
		// Token: 0x06031E95 RID: 204437 RVA: 0x00B931FC File Offset: 0x00B913FC
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

		// Token: 0x06031E96 RID: 204438 RVA: 0x00B932EC File Offset: 0x00B914EC
		protected override void OnStart()
		{
			this.SeqPlayer = new UiSequencePlayer(this.RootItem);
			this.ContentLayout = new GenericLayout<TowerDefenseInBattleInfoItem, ITowerDefensePhantomSkillItemInBattleData>(base.GetVerticalLayout(4), new Func<TowerDefenseInBattleInfoItem>(TowerDefenseController.Instance.BuildPhantomSkillInBattleItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06031E97 RID: 204439 RVA: 0x00B9333F File Offset: 0x00B9153F
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

		// Token: 0x06031E98 RID: 204440 RVA: 0x00B9336C File Offset: 0x00B9156C
		protected override UniTask OnBeforeHideAsync()
		{
			TowerDefenseInBattlePanel.<OnBeforeHideAsync>d__6 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<TowerDefenseInBattlePanel.<OnBeforeHideAsync>d__6>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031E99 RID: 204441 RVA: 0x00B933AF File Offset: 0x00B915AF
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.LiteExit();
			}
			this.SeqPlayer = null;
		}

		// Token: 0x06031E9A RID: 204442 RVA: 0x00B933CC File Offset: 0x00B915CC
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

		// Token: 0x06031E9B RID: 204443 RVA: 0x00B93420 File Offset: 0x00B91620
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
			List<ITowerDefensePhantomSkillItemInBattleData> source = TowerDefenseController.Instance.BuildPhantomSkillInBattleLayoutData();
			GenericLayout<TowerDefenseInBattleInfoItem, ITowerDefensePhantomSkillItemInBattleData> contentLayout = this.ContentLayout;
			if (contentLayout == null)
			{
				return;
			}
			contentLayout.RefreshByData(source.ToList<ITowerDefensePhantomSkillItemInBattleData>(), null, false);
		}

		// Token: 0x0401A9E7 RID: 109031
		private bool Created;

		// Token: 0x0401A9E8 RID: 109032
		[Nullable(2)]
		private UiSequencePlayer SeqPlayer;

		// Token: 0x0401A9E9 RID: 109033
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<TowerDefenseInBattleInfoItem, ITowerDefensePhantomSkillItemInBattleData> ContentLayout;

		// Token: 0x0200ACC6 RID: 44230
		private class EPanelComponent
		{
			// Token: 0x040347D6 RID: 214998
			public const int IconTex = 0;

			// Token: 0x040347D7 RID: 214999
			public const int QualitySprite = 1;

			// Token: 0x040347D8 RID: 215000
			public const int NameTxt = 2;

			// Token: 0x040347D9 RID: 215001
			public const int DescTxt = 3;

			// Token: 0x040347DA RID: 215002
			public const int InfoLayout = 4;

			// Token: 0x040347DB RID: 215003
			public const int InfoItem = 5;
		}
	}
}
