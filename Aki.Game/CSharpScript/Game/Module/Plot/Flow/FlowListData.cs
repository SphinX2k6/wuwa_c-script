using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02005095 RID: 20629
	public class FlowListData : IStaticVariableResetter
	{
		// Token: 0x06034DCA RID: 216522 RVA: 0x00C82341 File Offset: 0x00C80541
		static FlowListData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlowListData.CreateStaticDefaultValue), new Action(FlowListData.ResetStaticDefaultValue));
		}

		// Token: 0x06034DCB RID: 216523 RVA: 0x00C82360 File Offset: 0x00C80560
		[NullableContext(1)]
		public void Init(IFlowListInfo flowList)
		{
			this.IdsMap = new Dictionary<int, IFlowInfo>();
			if (flowList.Flows != null)
			{
				foreach (IFlowInfo flowInfo in flowList.Flows)
				{
					foreach (IStateInfo stateInfo in flowInfo.States)
					{
						foreach (ActionInfo actionInfo in stateInfo.Actions)
						{
							if (actionInfo.Name == EAction.ShowTalk)
							{
								ShowTalk showTalk = actionInfo.Params as ShowTalk;
								if (((showTalk != null) ? showTalk.TalkItems : null) != null)
								{
									foreach (ITalkItem talkItem in showTalk.TalkItems)
									{
										if (FlowListData.AudioCache.Contains(talkItem.TidTalk))
										{
											talkItem.PlayVoice = new bool?(true);
										}
									}
								}
							}
						}
					}
					this.IdsMap[flowInfo.Id] = flowInfo;
				}
			}
		}

		// Token: 0x06034DCC RID: 216524 RVA: 0x00C82514 File Offset: 0x00C80714
		[NullableContext(2)]
		public IFlowInfo GetFlowInfo(int key)
		{
			if (this.IdsMap == null)
			{
				return null;
			}
			IFlowInfo result;
			this.IdsMap.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x06034DCD RID: 216525 RVA: 0x00C8253B File Offset: 0x00C8073B
		public void UpdateTime()
		{
		}

		// Token: 0x06034DCE RID: 216526 RVA: 0x00C8253D File Offset: 0x00C8073D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034DCF RID: 216527 RVA: 0x00C8253F File Offset: 0x00C8073F
		public static void ResetStaticDefaultValue()
		{
			FlowListData.AudioCache = null;
		}

		// Token: 0x0401C286 RID: 115334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, IFlowInfo> IdsMap;

		// Token: 0x0401C287 RID: 115335
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static HashSet<string> AudioCache;
	}
}
