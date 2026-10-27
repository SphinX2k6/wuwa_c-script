using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express
{
	// Token: 0x020059EF RID: 23023
	[NullableContext(1)]
	[Nullable(0)]
	public class CheckPointEffectController
	{
		// Token: 0x0603A5A0 RID: 239008 RVA: 0x00DE231A File Offset: 0x00DE051A
		public CheckPointEffectController(Blackboard Blackboard)
		{
		}

		// Token: 0x0603A5A1 RID: 239009 RVA: 0x00DE2340 File Offset: 0x00DE0540
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

		// Token: 0x0603A5A2 RID: 239010 RVA: 0x00DE23B4 File Offset: 0x00DE05B4
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

		// Token: 0x0603A5A3 RID: 239011 RVA: 0x00DE2418 File Offset: 0x00DE0618
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

		// Token: 0x0603A5A4 RID: 239012 RVA: 0x00DE2464 File Offset: 0x00DE0664
		private void OnNodeEnd(int nodeId)
		{
			this.EffectSpawnInfos.Remove(nodeId);
			this.StopEffect(nodeId);
		}

		// Token: 0x0603A5A5 RID: 239013 RVA: 0x00DE247A File Offset: 0x00DE067A
		public void OnBtApplyExpressionOccupation(bool bSelf)
		{
			if (bSelf)
			{
				return;
			}
			this.EnableAllEffects(true);
		}

		// Token: 0x0603A5A6 RID: 239014 RVA: 0x00DE2487 File Offset: 0x00DE0687
		public void OnBtReleaseExpressionOccupation(bool bSelf)
		{
			if (bSelf)
			{
				return;
			}
			this.EnableAllEffects(false);
		}

		// Token: 0x0603A5A7 RID: 239015 RVA: 0x00DE2494 File Offset: 0x00DE0694
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

		// Token: 0x0603A5A8 RID: 239016 RVA: 0x00DE252C File Offset: 0x00DE072C
		public void StopEffect(int nodeId)
		{
			int num;
			if (this.EffectHandles.Remove(nodeId, out num) && EffectSystem.Instance.IsValid(num))
			{
				EffectSystem.Instance.StopEffectById(num, "[CheckPointEffectController.End]", true, null);
			}
		}

		// Token: 0x0401E6B8 RID: 124600
		[CompilerGenerated]
		private Blackboard <Blackboard>P = Blackboard;

		// Token: 0x0401E6B9 RID: 124601
		private readonly Dictionary<int, CheckPointEffectController.CheckPointEffectInfo> EffectSpawnInfos = new Dictionary<int, CheckPointEffectController.CheckPointEffectInfo>();

		// Token: 0x0401E6BA RID: 124602
		private readonly Dictionary<int, int> EffectHandles = new Dictionary<int, int>();

		// Token: 0x0200BC3F RID: 48191
		[Nullable(0)]
		private class CheckPointEffectInfo
		{
			// Token: 0x04038CC1 RID: 232641
			public string EffectPathKey = "";

			// Token: 0x04038CC2 RID: 232642
			public Vector EffectSpawnPosition = Vector.ZeroVectorProxy;
		}
	}
}
