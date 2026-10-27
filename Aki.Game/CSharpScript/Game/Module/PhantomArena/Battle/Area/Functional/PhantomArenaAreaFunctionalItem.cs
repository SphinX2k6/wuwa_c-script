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
	// Token: 0x020052CD RID: 21197
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaAreaFunctionalItem : PhantomArenaAreaItemBase
	{
		// Token: 0x060363C7 RID: 222151 RVA: 0x00CD4F14 File Offset: 0x00CD3114
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x060363C8 RID: 222152 RVA: 0x00CD4F6E File Offset: 0x00CD316E
		protected override void OnStartImplement()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		}

		// Token: 0x060363C9 RID: 222153 RVA: 0x00CD4F98 File Offset: 0x00CD3198
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x060363CA RID: 222154 RVA: 0x00CD4FA5 File Offset: 0x00CD31A5
		private void OnEndSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Close".ToString())
			{
				base.GetSprite(0).SetUIActive(false);
			}
		}

		// Token: 0x060363CB RID: 222155 RVA: 0x00CD4FC6 File Offset: 0x00CD31C6
		public override void Refresh(PhantomArenaCard card)
		{
		}

		// Token: 0x060363CC RID: 222156 RVA: 0x00CD4FC8 File Offset: 0x00CD31C8
		public override void SetHoverStateActive(bool value)
		{
		}

		// Token: 0x060363CD RID: 222157 RVA: 0x00CD4FCC File Offset: 0x00CD31CC
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

		// Token: 0x060363CE RID: 222158 RVA: 0x00CD502C File Offset: 0x00CD322C
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

		// Token: 0x060363CF RID: 222159 RVA: 0x00CD5077 File Offset: 0x00CD3277
		public UUIItem GetCardRootItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x0401CAD6 RID: 117462
		private PhantomArenaCardComponentLogic UseSkill;

		// Token: 0x0401CAD7 RID: 117463
		protected UiSequencePlayer Sequence;

		// Token: 0x0200B551 RID: 46417
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04036F04 RID: 225028
			public const int BgTexture = 0;

			// Token: 0x04036F05 RID: 225029
			public const int CardRootItem = 1;

			// Token: 0x04036F06 RID: 225030
			public const int ContentItem = 2;
		}
	}
}
