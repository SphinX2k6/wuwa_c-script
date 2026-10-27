using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Opponent
{
	// Token: 0x0200528E RID: 21134
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentFunctionalProxy : OpponentFunctionAreaProxy
	{
		// Token: 0x17008280 RID: 33408
		// (get) Token: 0x0603608F RID: 221327 RVA: 0x00CC9A46 File Offset: 0x00CC7C46
		// (set) Token: 0x06036090 RID: 221328 RVA: 0x00CC9A53 File Offset: 0x00CC7C53
		public new PhantomArenaAreaFunctionalItem AreaItem
		{
			get
			{
				return base.AreaItem as PhantomArenaAreaFunctionalItem;
			}
			set
			{
				base.AreaItem = value;
			}
		}

		// Token: 0x17008281 RID: 33409
		// (get) Token: 0x06036091 RID: 221329 RVA: 0x00CC9A5C File Offset: 0x00CC7C5C
		public override bool IsMonster
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17008282 RID: 33410
		// (get) Token: 0x06036092 RID: 221330 RVA: 0x00CC9A5F File Offset: 0x00CC7C5F
		public override bool IsNeedPreload
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06036093 RID: 221331 RVA: 0x00CC9A62 File Offset: 0x00CC7C62
		public OpponentFunctionalProxy(int index, OpponentFunctionArea area) : base(index, area)
		{
		}

		// Token: 0x06036094 RID: 221332 RVA: 0x00CC9A6C File Offset: 0x00CC7C6C
		protected override UUIItem GetCardAttachItem()
		{
			return this.AreaItem.GetRootItem();
		}

		// Token: 0x06036095 RID: 221333 RVA: 0x00CC9A7C File Offset: 0x00CC7C7C
		public UniTask UseCardSkill(PhantomCardData cardData)
		{
			OpponentFunctionalProxy.<UseCardSkill>d__9 <UseCardSkill>d__;
			<UseCardSkill>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UseCardSkill>d__.<>4__this = this;
			<UseCardSkill>d__.cardData = cardData;
			<UseCardSkill>d__.<>1__state = -1;
			<UseCardSkill>d__.<>t__builder.Start<OpponentFunctionalProxy.<UseCardSkill>d__9>(ref <UseCardSkill>d__);
			return <UseCardSkill>d__.<>t__builder.Task;
		}
	}
}
