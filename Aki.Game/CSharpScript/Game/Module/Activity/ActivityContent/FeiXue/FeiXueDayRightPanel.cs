using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x020055BF RID: 21951
	public class FeiXueDayRightPanel : UiPanelBase
	{
		// Token: 0x06036673 RID: 222835 RVA: 0x00F30384 File Offset: 0x00F2E584
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06036674 RID: 222836 RVA: 0x00F303F4 File Offset: 0x00F2E5F4
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06036675 RID: 222837 RVA: 0x00F30408 File Offset: 0x00F2E608
		public UniTask PlaySearchInSequence()
		{
			FeiXueDayRightPanel.<PlaySearchInSequence>d__3 <PlaySearchInSequence>d__;
			<PlaySearchInSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySearchInSequence>d__.<>4__this = this;
			<PlaySearchInSequence>d__.<>1__state = -1;
			<PlaySearchInSequence>d__.<>t__builder.Start<FeiXueDayRightPanel.<PlaySearchInSequence>d__3>(ref <PlaySearchInSequence>d__);
			return <PlaySearchInSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06036676 RID: 222838 RVA: 0x00F3044C File Offset: 0x00F2E64C
		public UniTask PlayDoneSequence()
		{
			FeiXueDayRightPanel.<PlayDoneSequence>d__4 <PlayDoneSequence>d__;
			<PlayDoneSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDoneSequence>d__.<>4__this = this;
			<PlayDoneSequence>d__.<>1__state = -1;
			<PlayDoneSequence>d__.<>t__builder.Start<FeiXueDayRightPanel.<PlayDoneSequence>d__4>(ref <PlayDoneSequence>d__);
			return <PlayDoneSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06036677 RID: 222839 RVA: 0x00F30490 File Offset: 0x00F2E690
		public UniTask PlaySearchingLoopSequence()
		{
			FeiXueDayRightPanel.<PlaySearchingLoopSequence>d__5 <PlaySearchingLoopSequence>d__;
			<PlaySearchingLoopSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySearchingLoopSequence>d__.<>4__this = this;
			<PlaySearchingLoopSequence>d__.<>1__state = -1;
			<PlaySearchingLoopSequence>d__.<>t__builder.Start<FeiXueDayRightPanel.<PlaySearchingLoopSequence>d__5>(ref <PlaySearchingLoopSequence>d__);
			return <PlaySearchingLoopSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06036678 RID: 222840 RVA: 0x00F304D4 File Offset: 0x00F2E6D4
		public void SetPanelItemActive(EFeiXueQuestState state)
		{
			switch (state)
			{
			case EFeiXueQuestState.Lock:
			{
				UUIItem item = base.GetItem(0);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(1);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUISprite sprite = base.GetSprite(2);
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				UUIItem item3 = base.GetItem(3);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(false);
				return;
			}
			case EFeiXueQuestState.IsDoing:
			{
				UUIItem item4 = base.GetItem(0);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				UUIItem item5 = base.GetItem(1);
				if (item5 != null)
				{
					item5.SetUIActive(false);
				}
				UUISprite sprite2 = base.GetSprite(2);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(false);
				}
				UUIItem item6 = base.GetItem(3);
				if (item6 == null)
				{
					return;
				}
				item6.SetUIActive(true);
				return;
			}
			case EFeiXueQuestState.Finish:
			{
				UUIItem item7 = base.GetItem(0);
				if (item7 != null)
				{
					item7.SetUIActive(false);
				}
				UUIItem item8 = base.GetItem(1);
				if (item8 == null)
				{
					return;
				}
				item8.SetUIActive(true);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0401CB50 RID: 117584
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
