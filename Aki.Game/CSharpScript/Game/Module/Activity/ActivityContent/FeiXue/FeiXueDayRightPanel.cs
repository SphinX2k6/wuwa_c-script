using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x02006641 RID: 26177
	public class FeiXueDayRightPanel : UiPanelBase
	{
		// Token: 0x060419AE RID: 268718 RVA: 0x00FE92CC File Offset: 0x00FE74CC
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

		// Token: 0x060419AF RID: 268719 RVA: 0x00FE933C File Offset: 0x00FE753C
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x060419B0 RID: 268720 RVA: 0x00FE9350 File Offset: 0x00FE7550
		public UniTask PlaySearchInSequence()
		{
			FeiXueDayRightPanel.<PlaySearchInSequence>d__3 <PlaySearchInSequence>d__;
			<PlaySearchInSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySearchInSequence>d__.<>4__this = this;
			<PlaySearchInSequence>d__.<>1__state = -1;
			<PlaySearchInSequence>d__.<>t__builder.Start<FeiXueDayRightPanel.<PlaySearchInSequence>d__3>(ref <PlaySearchInSequence>d__);
			return <PlaySearchInSequence>d__.<>t__builder.Task;
		}

		// Token: 0x060419B1 RID: 268721 RVA: 0x00FE9394 File Offset: 0x00FE7594
		public UniTask PlayDoneSequence()
		{
			FeiXueDayRightPanel.<PlayDoneSequence>d__4 <PlayDoneSequence>d__;
			<PlayDoneSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDoneSequence>d__.<>4__this = this;
			<PlayDoneSequence>d__.<>1__state = -1;
			<PlayDoneSequence>d__.<>t__builder.Start<FeiXueDayRightPanel.<PlayDoneSequence>d__4>(ref <PlayDoneSequence>d__);
			return <PlayDoneSequence>d__.<>t__builder.Task;
		}

		// Token: 0x060419B2 RID: 268722 RVA: 0x00FE93D8 File Offset: 0x00FE75D8
		public UniTask PlaySearchingLoopSequence()
		{
			FeiXueDayRightPanel.<PlaySearchingLoopSequence>d__5 <PlaySearchingLoopSequence>d__;
			<PlaySearchingLoopSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySearchingLoopSequence>d__.<>4__this = this;
			<PlaySearchingLoopSequence>d__.<>1__state = -1;
			<PlaySearchingLoopSequence>d__.<>t__builder.Start<FeiXueDayRightPanel.<PlaySearchingLoopSequence>d__5>(ref <PlaySearchingLoopSequence>d__);
			return <PlaySearchingLoopSequence>d__.<>t__builder.Task;
		}

		// Token: 0x060419B3 RID: 268723 RVA: 0x00FE941C File Offset: 0x00FE761C
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

		// Token: 0x0402221F RID: 139807
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
