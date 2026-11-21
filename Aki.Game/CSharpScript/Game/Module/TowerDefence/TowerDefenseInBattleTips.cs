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
	// Token: 0x02003AF0 RID: 15088
	public class TowerDefenseInBattleTips : UiTickViewBase
	{
		// Token: 0x06026C0A RID: 158730 RVA: 0x00AD6B66 File Offset: 0x00AD4D66
		[NullableContext(1)]
		public TowerDefenseInBattleTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06026C0B RID: 158731 RVA: 0x00AD6B78 File Offset: 0x00AD4D78
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

		// Token: 0x06026C0C RID: 158732 RVA: 0x00AD6C24 File Offset: 0x00AD4E24
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseInBattleTips.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseInBattleTips.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026C0D RID: 158733 RVA: 0x00AD6C67 File Offset: 0x00AD4E67
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x06026C0E RID: 158734 RVA: 0x00AD6C6F File Offset: 0x00AD4E6F
		protected override void OnAfterDestroy()
		{
			TowerDefenseController.Instance.TryReopenInBattleTip();
		}

		// Token: 0x06026C0F RID: 158735 RVA: 0x00AD6C7C File Offset: 0x00AD4E7C
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

		// Token: 0x06026C10 RID: 158736 RVA: 0x00AD6D2D File Offset: 0x00AD4F2D
		protected override void OnAfterPlayStartSequence()
		{
			this.PlaySequenceStream().ContinueWith(delegate()
			{
				TowerDefenseController.Instance.ResetCurrentPhantomLevelUpFlag(this.ShowingLevel);
				base.CloseMe(null);
			});
		}

		// Token: 0x06026C11 RID: 158737 RVA: 0x00AD6D48 File Offset: 0x00AD4F48
		private UniTask PlaySequenceStream()
		{
			TowerDefenseInBattleTips.<PlaySequenceStream>d__10 <PlaySequenceStream>d__;
			<PlaySequenceStream>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceStream>d__.<>1__state = -1;
			<PlaySequenceStream>d__.<>t__builder.Start<TowerDefenseInBattleTips.<PlaySequenceStream>d__10>(ref <PlaySequenceStream>d__);
			return <PlaySequenceStream>d__.<>t__builder.Task;
		}

		// Token: 0x04015333 RID: 86835
		private const int WAITING_TO_CLOSE = 2000;

		// Token: 0x04015334 RID: 86836
		[Nullable(2)]
		private SmallItemGrid IconItem;

		// Token: 0x04015335 RID: 86837
		private int ShowingLevel = 1;

		// Token: 0x020096E0 RID: 38624
		private class EComponent
		{
			// Token: 0x0402F170 RID: 192880
			public const int IconItem = 0;

			// Token: 0x0402F171 RID: 192881
			public const int StateSprite = 1;

			// Token: 0x0402F172 RID: 192882
			public const int TitleText = 2;

			// Token: 0x0402F173 RID: 192883
			public const int DescText = 3;
		}
	}
}
