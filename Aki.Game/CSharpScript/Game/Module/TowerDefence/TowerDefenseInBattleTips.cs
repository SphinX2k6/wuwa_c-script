using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B48 RID: 19272
	public class TowerDefenseInBattleTips : UiTickViewBase
	{
		// Token: 0x06031E7A RID: 204410 RVA: 0x00B92B02 File Offset: 0x00B90D02
		[NullableContext(1)]
		public TowerDefenseInBattleTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031E7B RID: 204411 RVA: 0x00B92B14 File Offset: 0x00B90D14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031E7C RID: 204412 RVA: 0x00B92BC0 File Offset: 0x00B90DC0
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseInBattleTips.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseInBattleTips.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031E7D RID: 204413 RVA: 0x00B92C03 File Offset: 0x00B90E03
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x06031E7E RID: 204414 RVA: 0x00B92C0B File Offset: 0x00B90E0B
		protected override void OnAfterDestroy()
		{
			TowerDefenseController.Instance.TryReopenInBattleTip();
		}

		// Token: 0x06031E7F RID: 204415 RVA: 0x00B92C18 File Offset: 0x00B90E18
		private void Refresh()
		{
			this.ShowingLevel = TowerDefenseModel.Instance.GetCurrentPhantomLevelInBattle();
			PhantomSmallItemGrid parameters = TowerDefenseController.Instance.BuildPhantomIconInBattleData();
			SmallItemGrid iconItem = this.IconItem;
			if (iconItem != null)
			{
				iconItem.Apply<PhantomSmallItemGrid>(parameters);
			}
			ITowerDefenseTipsContentInBattle towerDefenseTipsContentInBattle = TowerDefenseController.Instance.BuildPhantomTipsInBattleData();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), towerDefenseTipsContentInBattle.TitleTextId, Array.Empty<object>());
			if (towerDefenseTipsContentInBattle.DescArgs != null && towerDefenseTipsContentInBattle.DescArgs.Count > 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), towerDefenseTipsContentInBattle.DescTextId, towerDefenseTipsContentInBattle.DescArgs);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), towerDefenseTipsContentInBattle.DescTextId, Array.Empty<object>());
		}

		// Token: 0x06031E80 RID: 204416 RVA: 0x00B92CC9 File Offset: 0x00B90EC9
		protected override void OnAfterPlayStartSequence()
		{
			this.PlaySequenceStream().ContinueWith(delegate()
			{
				TowerDefenseController.Instance.ResetCurrentPhantomLevelUpFlag(this.ShowingLevel);
				base.CloseMe(null);
			});
		}

		// Token: 0x06031E81 RID: 204417 RVA: 0x00B92CE4 File Offset: 0x00B90EE4
		private UniTask PlaySequenceStream()
		{
			TowerDefenseInBattleTips.<PlaySequenceStream>d__10 <PlaySequenceStream>d__;
			<PlaySequenceStream>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceStream>d__.<>1__state = -1;
			<PlaySequenceStream>d__.<>t__builder.Start<TowerDefenseInBattleTips.<PlaySequenceStream>d__10>(ref <PlaySequenceStream>d__);
			return <PlaySequenceStream>d__.<>t__builder.Task;
		}

		// Token: 0x0401A9E1 RID: 109025
		private const int WAITING_TO_CLOSE = 2000;

		// Token: 0x0401A9E2 RID: 109026
		[Nullable(2)]
		private SmallItemGrid IconItem;

		// Token: 0x0401A9E3 RID: 109027
		private int ShowingLevel = 1;

		// Token: 0x0200ACC0 RID: 44224
		private class EComponent
		{
			// Token: 0x040347BF RID: 214975
			public const int IconItem = 0;

			// Token: 0x040347C0 RID: 214976
			public const int StateSprite = 1;

			// Token: 0x040347C1 RID: 214977
			public const int TitleText = 2;

			// Token: 0x040347C2 RID: 214978
			public const int DescText = 3;
		}
	}
}
