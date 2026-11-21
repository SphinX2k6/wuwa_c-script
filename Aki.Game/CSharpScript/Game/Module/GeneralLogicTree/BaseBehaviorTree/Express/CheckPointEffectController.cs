using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express
{
	// Token: 0x020049C8 RID: 18888
	[NullableContext(1)]
	[Nullable(0)]
	public class CheckPointEffectController
	{
		// Token: 0x0602F4C7 RID: 193735 RVA: 0x00D31B86 File Offset: 0x00D2FD86
		public CheckPointEffectController(Blackboard Blackboard)
		{
		}

		// Token: 0x0602F4C8 RID: 193736 RVA: 0x00D31BAC File Offset: 0x00D2FDAC
		public void EnableAllEffects(bool value)
		{
			foreach (KeyValuePair<int, CheckPointEffectController.CheckPointEffectInfo> keyValuePair in this.EffectSpawnInfos)
			{
				int num;
				CheckPointEffectController.CheckPointEffectInfo checkPointEffectInfo;
				keyValuePair.Deconstruct(out num, out checkPointEffectInfo);
				int nodeId = num;
				CheckPointEffectController.CheckPointEffectInfo info = checkPointEffectInfo;
				if (value)
				{
					this.SpawnEffect(nodeId, info);
				}
				else
				{
					this.StopEffect(nodeId);
				}
			}
		}

		// Token: 0x0602F4C9 RID: 193737 RVA: 0x00D31C20 File Offset: 0x00D2FE20
		public void UpdateOnChildQuestNodeStatusChange(ChildQuestNodeBase node, bool bStart, bool bEnd)
		{
			if (node.TrackTarget != null)
			{
				ReachAreaBehaviorNode reachAreaBehaviorNode = node as ReachAreaBehaviorNode;
				if (reachAreaBehaviorNode != null)
				{
					if (bStart)
					{
						bool isOccupied = this.<Blackboard>P.IsOccupied;
						if (!string.IsNullOrEmpty(reachAreaBehaviorNode.EffectPathKey))
						{
							this.OnNodeStart(node.NodeId, reachAreaBehaviorNode.EffectPathKey, reachAreaBehaviorNode.GetTargetPosition(), isOccupied);
						}
					}
					if (bEnd)
					{
						this.OnNodeEnd(node.NodeId);
					}
					return;
				}
			}
		}

		// Token: 0x0602F4CA RID: 193738 RVA: 0x00D31C84 File Offset: 0x00D2FE84
		private void OnNodeStart(int nodeId, string effectPathKey, Vector effectSpawnPosition, bool bOccupied)
		{
			CheckPointEffectController.CheckPointEffectInfo checkPointEffectInfo;
			if (this.EffectSpawnInfos.TryGetValue(nodeId, out checkPointEffectInfo))
			{
				return;
			}
			checkPointEffectInfo = new CheckPointEffectController.CheckPointEffectInfo
			{
				EffectPathKey = effectPathKey,
				EffectSpawnPosition = effectSpawnPosition
			};
			this.EffectSpawnInfos[nodeId] = checkPointEffectInfo;
			if (bOccupied)
			{
				return;
			}
			this.SpawnEffect(nodeId, checkPointEffectInfo);
		}

		// Token: 0x0602F4CB RID: 193739 RVA: 0x00D31CD0 File Offset: 0x00D2FED0
		private void OnNodeEnd(int nodeId)
		{
			this.EffectSpawnInfos.Remove(nodeId);
			this.StopEffect(nodeId);
		}

		// Token: 0x0602F4CC RID: 193740 RVA: 0x00D31CE6 File Offset: 0x00D2FEE6
		public void OnBtApplyExpressionOccupation(bool bSelf)
		{
			if (bSelf)
			{
				return;
			}
			this.EnableAllEffects(true);
		}

		// Token: 0x0602F4CD RID: 193741 RVA: 0x00D31CF3 File Offset: 0x00D2FEF3
		public void OnBtReleaseExpressionOccupation(bool bSelf)
		{
			if (bSelf)
			{
				return;
			}
			this.EnableAllEffects(false);
		}

		// Token: 0x0602F4CE RID: 193742 RVA: 0x00D31D00 File Offset: 0x00D2FF00
		private void SpawnEffect(int nodeId, CheckPointEffectController.CheckPointEffectInfo info)
		{
			string effectPath = EffectUtil.GetEffectPath((!string.IsNullOrEmpty(info.EffectPathKey)) ? info.EffectPathKey : "DA_Fx_Group_Sl3_Cishi_10idle");
			if (StringUtils.IsBlank(effectPath))
			{
				return;
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FVectorDouble fvectorDouble = info.EffectSpawnPosition.ToUeVector(false);
			FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref Rotator.ZeroRotator, ref fvectorDouble, ref Vector.OneVector));
			Func<int, bool> <>9__1;
			instance.SpawnEffect(world, ftransformDouble, effectPath, "[CheckPointEffectController.CreateTrackEffect]", null, EEffectType.Scene, null, delegate(ELoadEffectResult result, int handle)
			{
				if (result != ELoadEffectResult.Success)
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.GeneralLogicTree;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "GeneralLogicTree:CheckPointEffectController.SpawnEffect 错误";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", result);
					instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				if (handle == 0)
				{
					return;
				}
				if (this.EffectHandles.ContainsKey(nodeId))
				{
					this.StopEffect(nodeId);
				}
				this.EffectHandles[nodeId] = handle;
				EffectSystem instance3 = EffectSystem.Instance;
				Func<int, bool> func;
				if ((func = <>9__1) == null)
				{
					func = (<>9__1 = ((int _) => this.EffectHandles.ContainsKey(nodeId)));
				}
				instance3.RegisterCustomCheckOwnerFunc(handle, func);
			}, null, false, false);
		}

		// Token: 0x0602F4CF RID: 193743 RVA: 0x00D31D98 File Offset: 0x00D2FF98
		public void StopEffect(int nodeId)
		{
			int num;
			if (this.EffectHandles.Remove(nodeId, out num) && EffectSystem.Instance.IsValid(num))
			{
				EffectSystem.Instance.StopEffectById(num, "[CheckPointEffectController.End]", true, null);
			}
		}

		// Token: 0x04019157 RID: 102743
		[CompilerGenerated]
		private Blackboard <Blackboard>P = Blackboard;

		// Token: 0x04019158 RID: 102744
		private readonly Dictionary<int, CheckPointEffectController.CheckPointEffectInfo> EffectSpawnInfos = new Dictionary<int, CheckPointEffectController.CheckPointEffectInfo>();

		// Token: 0x04019159 RID: 102745
		private readonly Dictionary<int, int> EffectHandles = new Dictionary<int, int>();

		// Token: 0x0200A649 RID: 42569
		[Nullable(0)]
		private class CheckPointEffectInfo
		{
			// Token: 0x0403368E RID: 210574
			public string EffectPathKey = "";

			// Token: 0x0403368F RID: 210575
			public Vector EffectSpawnPosition = Vector.ZeroVectorProxy;
		}
	}
}
