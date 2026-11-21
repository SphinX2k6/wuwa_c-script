using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058F4 RID: 22772
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolEndingFlowGraph
	{
		// Token: 0x17006BB9 RID: 27577
		// (get) Token: 0x0603824E RID: 229966 RVA: 0x00FB1BF2 File Offset: 0x00FAFDF2
		public int ActivityId { get; }

		// Token: 0x17006BBA RID: 27578
		// (get) Token: 0x0603824F RID: 229967 RVA: 0x00FB1BFA File Offset: 0x00FAFDFA
		public int StartNodeId { get; }

		// Token: 0x06038250 RID: 229968 RVA: 0x00FB1C02 File Offset: 0x00FAFE02
		private SolarSchoolEndingFlowGraph(int activityId, int startNodeId, Dictionary<int, SolarSchoolEndingFlow> nodes)
		{
			this.ActivityId = activityId;
			this.StartNodeId = startNodeId;
			this.Nodes = nodes;
		}

		// Token: 0x06038251 RID: 229969 RVA: 0x00FB1C1F File Offset: 0x00FAFE1F
		public SolarSchoolEndingFlow GetNode(int nodeId)
		{
			return this.Nodes[nodeId];
		}

		// Token: 0x06038252 RID: 229970 RVA: 0x00FB1C30 File Offset: 0x00FAFE30
		public int GetNextNodeId(SolarSchoolEndingFlow node, bool conditionResult)
		{
			int result;
			switch (node.NodeType)
			{
			case 1:
				result = node.NextId;
				break;
			case 2:
				result = (conditionResult ? node.TrueNextId : node.FalseNextId);
				break;
			case 3:
				result = 0;
				break;
			case 4:
				result = 0;
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}

		// Token: 0x06038253 RID: 229971 RVA: 0x00FB1C8C File Offset: 0x00FAFE8C
		public static SolarSchoolEndingFlowGraph Create(int activityId, IReadOnlyList<SolarSchoolEndingFlow> source)
		{
			Dictionary<int, SolarSchoolEndingFlow> dictionary = new Dictionary<int, SolarSchoolEndingFlow>(source.Count);
			int startNodeId = 0;
			foreach (SolarSchoolEndingFlow value in source)
			{
				dictionary[value.Id] = value;
				if (value.IsStart)
				{
					startNodeId = value.Id;
				}
			}
			return new SolarSchoolEndingFlowGraph(activityId, startNodeId, dictionary);
		}

		// Token: 0x0401D915 RID: 121109
		private readonly Dictionary<int, SolarSchoolEndingFlow> Nodes;
	}
}
