using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional
{
	// Token: 0x020052D0 RID: 21200
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaAreaMonsterItem : PhantomArenaAreaItemBase
	{
		// Token: 0x060363EC RID: 222188 RVA: 0x00CD5510 File Offset: 0x00CD3710
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

		// Token: 0x060363ED RID: 222189 RVA: 0x00CD5580 File Offset: 0x00CD3780
		public override void Refresh(PhantomArenaCard card)
		{
		}

		// Token: 0x060363EE RID: 222190 RVA: 0x00CD5582 File Offset: 0x00CD3782
		public override void SetHoverStateActive(bool value)
		{
			base.GetItem(2).SetUIActive(value);
		}

		// Token: 0x060363EF RID: 222191 RVA: 0x00CD5591 File Offset: 0x00CD3791
		public override void SetCanUseStateActive(bool value)
		{
			base.GetItem(0).SetUIActive(value);
		}

		// Token: 0x060363F0 RID: 222192 RVA: 0x00CD55A0 File Offset: 0x00CD37A0
		public UUIItem GetCardRootItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x060363F1 RID: 222193 RVA: 0x00CD55AC File Offset: 0x00CD37AC
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

		// Token: 0x060363F2 RID: 222194 RVA: 0x00CD55F8 File Offset: 0x00CD37F8
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

		// Token: 0x060363F3 RID: 222195 RVA: 0x00CD5644 File Offset: 0x00CD3844
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

		// Token: 0x060363F4 RID: 222196 RVA: 0x00CD5690 File Offset: 0x00CD3890
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

		// Token: 0x0401CADB RID: 117467
		private PhantomArenaCardComponentLogic UseSkill;

		// Token: 0x0401CADC RID: 117468
		private PhantomArenaCardComponentLogic BuffUp;

		// Token: 0x0401CADD RID: 117469
		private PhantomArenaCardComponentLogic BuffDown;

		// Token: 0x0401CADE RID: 117470
		private PhantomArenaCardComponentLogic Evolve;

		// Token: 0x0200B556 RID: 46422
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04036F1B RID: 225051
			public const int UseItem = 0;

			// Token: 0x04036F1C RID: 225052
			public const int CardRootItem = 1;

			// Token: 0x04036F1D RID: 225053
			public const int BgTexture = 2;

			// Token: 0x04036F1E RID: 225054
			public const int ContentItem = 3;
		}
	}
}
