using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional
{
	// Token: 0x020042A0 RID: 17056
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaAreaMonsterItem : PhantomArenaAreaItemBase
	{
		// Token: 0x0602B2E7 RID: 176871 RVA: 0x00C22C38 File Offset: 0x00C20E38
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x0602B2E8 RID: 176872 RVA: 0x00C22CA8 File Offset: 0x00C20EA8
		public override void Refresh(PhantomArenaCard card)
		{
		}

		// Token: 0x0602B2E9 RID: 176873 RVA: 0x00C22CAA File Offset: 0x00C20EAA
		public override void SetHoverStateActive(bool value)
		{
			base.GetItem(2).SetUIActive(value);
		}

		// Token: 0x0602B2EA RID: 176874 RVA: 0x00C22CB9 File Offset: 0x00C20EB9
		public override void SetCanUseStateActive(bool value)
		{
			base.GetItem(0).SetUIActive(value);
		}

		// Token: 0x0602B2EB RID: 176875 RVA: 0x00C22CC8 File Offset: 0x00C20EC8
		public UUIItem GetCardRootItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x0602B2EC RID: 176876 RVA: 0x00C22CD4 File Offset: 0x00C20ED4
		public UniTask SetBuffUpActive(bool isActive)
		{
			PhantomArenaAreaMonsterItem.<SetBuffUpActive>d__10 <SetBuffUpActive>d__;
			<SetBuffUpActive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetBuffUpActive>d__.<>4__this = this;
			<SetBuffUpActive>d__.isActive = isActive;
			<SetBuffUpActive>d__.<>1__state = -1;
			<SetBuffUpActive>d__.<>t__builder.Start<PhantomArenaAreaMonsterItem.<SetBuffUpActive>d__10>(ref <SetBuffUpActive>d__);
			return <SetBuffUpActive>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2ED RID: 176877 RVA: 0x00C22D20 File Offset: 0x00C20F20
		public UniTask SetBuffDownActive(bool isActive)
		{
			PhantomArenaAreaMonsterItem.<SetBuffDownActive>d__11 <SetBuffDownActive>d__;
			<SetBuffDownActive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetBuffDownActive>d__.<>4__this = this;
			<SetBuffDownActive>d__.isActive = isActive;
			<SetBuffDownActive>d__.<>1__state = -1;
			<SetBuffDownActive>d__.<>t__builder.Start<PhantomArenaAreaMonsterItem.<SetBuffDownActive>d__11>(ref <SetBuffDownActive>d__);
			return <SetBuffDownActive>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2EE RID: 176878 RVA: 0x00C22D6C File Offset: 0x00C20F6C
		public UniTask SetEvolveActive(bool isActive)
		{
			PhantomArenaAreaMonsterItem.<SetEvolveActive>d__12 <SetEvolveActive>d__;
			<SetEvolveActive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetEvolveActive>d__.<>4__this = this;
			<SetEvolveActive>d__.isActive = isActive;
			<SetEvolveActive>d__.<>1__state = -1;
			<SetEvolveActive>d__.<>t__builder.Start<PhantomArenaAreaMonsterItem.<SetEvolveActive>d__12>(ref <SetEvolveActive>d__);
			return <SetEvolveActive>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2EF RID: 176879 RVA: 0x00C22DB8 File Offset: 0x00C20FB8
		public UniTask SetIncreaseActive(bool isActive)
		{
			PhantomArenaAreaMonsterItem.<SetIncreaseActive>d__13 <SetIncreaseActive>d__;
			<SetIncreaseActive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetIncreaseActive>d__.<>4__this = this;
			<SetIncreaseActive>d__.isActive = isActive;
			<SetIncreaseActive>d__.<>1__state = -1;
			<SetIncreaseActive>d__.<>t__builder.Start<PhantomArenaAreaMonsterItem.<SetIncreaseActive>d__13>(ref <SetIncreaseActive>d__);
			return <SetIncreaseActive>d__.<>t__builder.Task;
		}

		// Token: 0x04017510 RID: 95504
		private PhantomArenaCardComponentLogic UseSkill;

		// Token: 0x04017511 RID: 95505
		private PhantomArenaCardComponentLogic BuffUp;

		// Token: 0x04017512 RID: 95506
		private PhantomArenaCardComponentLogic BuffDown;

		// Token: 0x04017513 RID: 95507
		private PhantomArenaCardComponentLogic Evolve;

		// Token: 0x02009F8E RID: 40846
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x0403196E RID: 203118
			public const int UseItem = 0;

			// Token: 0x0403196F RID: 203119
			public const int CardRootItem = 1;

			// Token: 0x04031970 RID: 203120
			public const int BgTexture = 2;

			// Token: 0x04031971 RID: 203121
			public const int ContentItem = 3;
		}
	}
}
