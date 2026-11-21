using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional
{
	// Token: 0x0200429D RID: 17053
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaAreaFunctionalItem : PhantomArenaAreaItemBase
	{
		// Token: 0x0602B2C2 RID: 176834 RVA: 0x00C2263C File Offset: 0x00C2083C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602B2C3 RID: 176835 RVA: 0x00C22696 File Offset: 0x00C20896
		protected override void OnStartImplement()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		}

		// Token: 0x0602B2C4 RID: 176836 RVA: 0x00C226C0 File Offset: 0x00C208C0
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602B2C5 RID: 176837 RVA: 0x00C226CD File Offset: 0x00C208CD
		private void OnEndSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Close".ToString())
			{
				base.GetSprite(0).SetUIActive(false);
			}
		}

		// Token: 0x0602B2C6 RID: 176838 RVA: 0x00C226EE File Offset: 0x00C208EE
		public override void Refresh(PhantomArenaCard card)
		{
		}

		// Token: 0x0602B2C7 RID: 176839 RVA: 0x00C226F0 File Offset: 0x00C208F0
		public override void SetHoverStateActive(bool value)
		{
		}

		// Token: 0x0602B2C8 RID: 176840 RVA: 0x00C226F4 File Offset: 0x00C208F4
		public override void SetCanUseStateActive(bool value)
		{
			this.Sequence.StopPrevSequence(false, true);
			if (value)
			{
				base.GetSprite(0).SetUIActive(true);
				this.Sequence.PlaySequence("Start", false, null);
				return;
			}
			this.Sequence.PlaySequence("Close", false, null);
		}

		// Token: 0x0602B2C9 RID: 176841 RVA: 0x00C22754 File Offset: 0x00C20954
		public UniTask SetIncreaseActive(bool isActive)
		{
			PhantomArenaAreaFunctionalItem.<SetIncreaseActive>d__10 <SetIncreaseActive>d__;
			<SetIncreaseActive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetIncreaseActive>d__.<>4__this = this;
			<SetIncreaseActive>d__.isActive = isActive;
			<SetIncreaseActive>d__.<>1__state = -1;
			<SetIncreaseActive>d__.<>t__builder.Start<PhantomArenaAreaFunctionalItem.<SetIncreaseActive>d__10>(ref <SetIncreaseActive>d__);
			return <SetIncreaseActive>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2CA RID: 176842 RVA: 0x00C2279F File Offset: 0x00C2099F
		public UUIItem GetCardRootItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x0401750B RID: 95499
		private PhantomArenaCardComponentLogic UseSkill;

		// Token: 0x0401750C RID: 95500
		protected UiSequencePlayer Sequence;

		// Token: 0x02009F89 RID: 40841
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04031957 RID: 203095
			public const int BgTexture = 0;

			// Token: 0x04031958 RID: 203096
			public const int CardRootItem = 1;

			// Token: 0x04031959 RID: 203097
			public const int ContentItem = 2;
		}
	}
}
