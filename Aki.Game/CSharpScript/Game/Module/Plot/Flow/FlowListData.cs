using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02004065 RID: 16485
	public class FlowListData : IStaticVariableResetter
	{
		// Token: 0x06029CC3 RID: 171203 RVA: 0x00BCF561 File Offset: 0x00BCD761
		static FlowListData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlowListData.CreateStaticDefaultValue), new Action(FlowListData.ResetStaticDefaultValue));
		}

		// Token: 0x06029CC4 RID: 171204 RVA: 0x00BCF580 File Offset: 0x00BCD780
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

		// Token: 0x06029CC5 RID: 171205 RVA: 0x00BCF734 File Offset: 0x00BCD934
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

		// Token: 0x06029CC6 RID: 171206 RVA: 0x00BCF75B File Offset: 0x00BCD95B
		public void UpdateTime()
		{
		}

		// Token: 0x06029CC7 RID: 171207 RVA: 0x00BCF75D File Offset: 0x00BCD95D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029CC8 RID: 171208 RVA: 0x00BCF75F File Offset: 0x00BCD95F
		public static void ResetStaticDefaultValue()
		{
			FlowListData.AudioCache = null;
		}

		// Token: 0x04016CB5 RID: 93365
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, IFlowInfo> IdsMap;

		// Token: 0x04016CB6 RID: 93366
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static HashSet<string> AudioCache;
	}
}
