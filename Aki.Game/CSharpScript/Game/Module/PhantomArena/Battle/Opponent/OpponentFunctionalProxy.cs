using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Opponent
{
	// Token: 0x0200425E RID: 16990
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentFunctionalProxy : OpponentFunctionAreaProxy
	{
		// Token: 0x17005640 RID: 22080
		// (get) Token: 0x0602AF8A RID: 176010 RVA: 0x00C1714A File Offset: 0x00C1534A
		// (set) Token: 0x0602AF8B RID: 176011 RVA: 0x00C17157 File Offset: 0x00C15357
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

		// Token: 0x17005641 RID: 22081
		// (get) Token: 0x0602AF8C RID: 176012 RVA: 0x00C17160 File Offset: 0x00C15360
		public override bool IsMonster
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17005642 RID: 22082
		// (get) Token: 0x0602AF8D RID: 176013 RVA: 0x00C17163 File Offset: 0x00C15363
		public override bool IsNeedPreload
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602AF8E RID: 176014 RVA: 0x00C17166 File Offset: 0x00C15366
		public OpponentFunctionalProxy(int index, OpponentFunctionArea area) : base(index, area)
		{
		}

		// Token: 0x0602AF8F RID: 176015 RVA: 0x00C17170 File Offset: 0x00C15370
		protected override UUIItem GetCardAttachItem()
		{
			return this.AreaItem.GetRootItem();
		}

		// Token: 0x0602AF90 RID: 176016 RVA: 0x00C17180 File Offset: 0x00C15380
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
