using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049AA RID: 18858
	[NullableContext(2)]
	[Nullable(0)]
	public class EntityPhotoBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F3C1 RID: 193473 RVA: 0x00D2BE8D File Offset: 0x00D2A08D
		public EntityPhotoBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F3C2 RID: 193474 RVA: 0x00D2BEA1 File Offset: 0x00D2A0A1
		public bool IsOverrideConfig()
		{
			return this.OverrideConfig != null;
		}

		// Token: 0x17005F67 RID: 24423
		// (get) Token: 0x0602F3C3 RID: 193475 RVA: 0x00D2BEAC File Offset: 0x00D2A0AC
		public unsafe int RangeEntity
		{
			get
			{
				ITakePhoto2Condition overrideConfig = this.OverrideConfig;
				int? num;
				if (overrideConfig == null)
				{
					num = null;
				}
				else
				{
					ITakePhoto2PosCondition posCondition = overrideConfig.PosCondition;
					num = ((posCondition != null) ? new int?(posCondition.RangeEntity) : null);
				}
				int? num2 = num;
				int? num3;
				if (num2 == null)
				{
					ITakePhotoPosCondition takePlace = this.TakePlace;
					num3 = ((takePlace != null) ? new int?(takePlace.RangeEntity) : null);
				}
				else
				{
					num3 = num2;
				}
				int? num4 = num3;
				if (num4 == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Photo;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "拍照节点未配置坐标";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TreeId", this.InnerTreeConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NodeId", this.InnerNodeId);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return 0;
				}
				return num4.Value;
			}
		}

		// Token: 0x0602F3C4 RID: 193476 RVA: 0x00D2BF98 File Offset: 0x00D2A198
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			ITakePhotoCondition takePhotoCondition = childQuestBtNode.Condition as ITakePhotoCondition;
			if (takePhotoCondition != null)
			{
				this.TakeTime = takePhotoCondition.TimeCondition;
				this.TakePlace = takePhotoCondition.PosCondition;
				this.TakeTargetArray = takePhotoCondition.PhotoTargets;
				return true;
			}
			ITakePhoto2Condition takePhoto2Condition = childQuestBtNode.Condition as ITakePhoto2Condition;
			if (takePhoto2Condition != null)
			{
				this.OverrideConfig = takePhoto2Condition;
				return true;
			}
			return false;
		}

		// Token: 0x0602F3C5 RID: 193477 RVA: 0x00D2C00A File Offset: 0x00D2A20A
		public void UseSubmitNode()
		{
			this.SubmitNode(null);
		}

		// Token: 0x0602F3C6 RID: 193478 RVA: 0x00D2C014 File Offset: 0x00D2A214
		public int? GetDungeonId()
		{
			Blackboard blackboard = this.Blackboard;
			if (blackboard == null)
			{
				return null;
			}
			return new int?(blackboard.DungeonId);
		}

		// Token: 0x040190D4 RID: 102612
		public ITakePhotoPosCondition TakePlace;

		// Token: 0x040190D5 RID: 102613
		public ITakePhotoTimeCondition TakeTime;

		// Token: 0x040190D6 RID: 102614
		[Nullable(1)]
		public List<IPhotoTarget> TakeTargetArray = new List<IPhotoTarget>();

		// Token: 0x040190D7 RID: 102615
		public ITakePhoto2Condition OverrideConfig;
	}
}
