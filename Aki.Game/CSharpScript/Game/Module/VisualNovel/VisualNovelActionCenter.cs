using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.VisualNovel.Action;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x0200379B RID: 14235
	[NullableContext(1)]
	[Nullable(0)]
	public class VisualNovelActionCenter
	{
		// Token: 0x06025057 RID: 151639 RVA: 0x00A7486E File Offset: 0x00A72A6E
		public VisualNovelActionCenter()
		{
			this.InitPerformances();
		}

		// Token: 0x06025058 RID: 151640 RVA: 0x00A74888 File Offset: 0x00A72A88
		private void InitPerformances()
		{
			this.InitPerformance(EVisualNovelPerformanceType.Enter, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelCharacterEnterAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.Exit, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelCharacterExitAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.Move, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelCharacterMoveAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.ModifyRole, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelModifyCharacterAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.PortraitEffect, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelCharacterPortraitEffectAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.BackgroundMove, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelBackgroundMoveAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.CgMove, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelCgMoveAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.EnterBlackScreen, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelEnterBlackScreenAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.LeaveBlackScreen, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelLeaveBlackScreenAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.RoleIntroduction, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelCharacterIntroductionAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.SendAudioEvent, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelSendAudioEventAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.SwitchAudioState, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelSwitchAudioStateAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.PlayScreenEffect, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelPlayScreenEffectAction(context, performance));
			this.InitPerformance(EVisualNovelPerformanceType.StopScreenEffect, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new VisualNovelStopScreenEffectAction(context, performance));
		}

		// Token: 0x06025059 RID: 151641 RVA: 0x00A74AB0 File Offset: 0x00A72CB0
		[return: Nullable(2)]
		public virtual VisualNovelAction Create(VisualNovelContext context, VisualNovelItem item)
		{
			if (context.IsReady)
			{
				context.Scene.ResetCharacterCustomLayers();
			}
			VisualNovelAction result;
			switch (item.Type)
			{
			case ETalkItemType.VisualNovelTalk:
				result = new VisualNovelTextAction(context, item);
				break;
			case ETalkItemType.VisualNovelNoTextItem:
				result = new VisualNovelNoTextAction(context, item);
				break;
			case ETalkItemType.VisualNovelNarration:
				result = new VisualNovelTextAction(context, item);
				break;
			case ETalkItemType.VisualNovelOption:
				result = new VisualNovelOptionAction(context, item);
				break;
			case ETalkItemType.VisualNovelCenterText:
				result = new VisualNovelTextAction(context, item);
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0602505A RID: 151642 RVA: 0x00A74B2C File Offset: 0x00A72D2C
		public VisualNovelAction Create(VisualNovelContext context, VisualNovelItem item, bool isStart)
		{
			IReadOnlyList<IVisualNovelPerformanceBase> performances = isStart ? item.StartPerformances : item.EndPerformances;
			List<VisualNovelAction> list = this.CreatePerformanceActions(context, performances);
			if (isStart && item.BackgroundConfig != null)
			{
				list.Insert(0, new VisualNovelBackgroundAction(context, item.BackgroundConfig));
			}
			return new VisualNovelParallelAction(context, list);
		}

		// Token: 0x0602505B RID: 151643 RVA: 0x00A74B7C File Offset: 0x00A72D7C
		public VisualNovelAction Create(VisualNovelContext context, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<IVisualNovelPerformanceBase> performances)
		{
			List<VisualNovelAction> actions = this.CreatePerformanceActions(context, performances);
			return new VisualNovelParallelAction(context, actions);
		}

		// Token: 0x0602505C RID: 151644 RVA: 0x00A74B9C File Offset: 0x00A72D9C
		private List<VisualNovelAction> CreatePerformanceActions(VisualNovelContext context, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<IVisualNovelPerformanceBase> performances)
		{
			List<VisualNovelAction> list = new List<VisualNovelAction>((performances != null) ? performances.Count : 0);
			if (performances != null)
			{
				foreach (IVisualNovelPerformanceBase visualNovelPerformanceBase in performances)
				{
					if (visualNovelPerformanceBase != null)
					{
						VisualNovelAction visualNovelAction = this.CreatePerformance(context, visualNovelPerformanceBase);
						if (visualNovelAction == null)
						{
							global::Log instance = global::Log.Instance;
							ELogModule module = ELogModule.VisualNovel;
							ELogAuthor author = ELogAuthor.LZK;
							string message = "视觉小说遇到不支持的表现配置";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", visualNovelPerformanceBase.GetType().Name);
							instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
						else
						{
							list.Add(VisualNovelActionCenter.AddStartDelay(context, visualNovelPerformanceBase, visualNovelAction));
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0602505D RID: 151645 RVA: 0x00A74C48 File Offset: 0x00A72E48
		protected void InitPerformance(EVisualNovelPerformanceType type, Func<VisualNovelContext, IVisualNovelPerformanceBase, VisualNovelAction> actionFactory)
		{
			if (this.ActionMap.ContainsKey(type))
			{
				return;
			}
			this.ActionMap.Add(type, actionFactory);
		}

		// Token: 0x0602505E RID: 151646 RVA: 0x00A74C66 File Offset: 0x00A72E66
		[return: Nullable(2)]
		private VisualNovelAction CreatePerformance(VisualNovelContext context, IVisualNovelPerformanceBase performance)
		{
			Func<VisualNovelContext, IVisualNovelPerformanceBase, VisualNovelAction> valueOrDefault = this.ActionMap.GetValueOrDefault(performance.Type);
			if (valueOrDefault == null)
			{
				return null;
			}
			return valueOrDefault(context, performance);
		}

		// Token: 0x0602505F RID: 151647 RVA: 0x00A74C88 File Offset: 0x00A72E88
		private static VisualNovelAction AddStartDelay(VisualNovelContext context, IVisualNovelPerformanceBase performance, VisualNovelAction action)
		{
			if (!(performance.StartTime > 0f))
			{
				return action;
			}
			return new VisualNovelSequenceAction(context, new VisualNovelAction[]
			{
				new VisualNovelDelayAction(context, performance.StartTime.Value),
				action
			});
		}

		// Token: 0x040147A8 RID: 83880
		private readonly Dictionary<EVisualNovelPerformanceType, Func<VisualNovelContext, IVisualNovelPerformanceBase, VisualNovelAction>> ActionMap = new Dictionary<EVisualNovelPerformanceType, Func<VisualNovelContext, IVisualNovelPerformanceBase, VisualNovelAction>>();
	}
}
