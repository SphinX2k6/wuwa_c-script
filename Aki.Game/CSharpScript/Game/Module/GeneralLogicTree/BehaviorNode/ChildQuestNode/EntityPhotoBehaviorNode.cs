using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059D1 RID: 22993
	[NullableContext(2)]
	[Nullable(0)]
	public class EntityPhotoBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A49A RID: 238746 RVA: 0x00DDC6AD File Offset: 0x00DDA8AD
		public EntityPhotoBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A49B RID: 238747 RVA: 0x00DDC6C1 File Offset: 0x00DDA8C1
		public bool IsOverrideConfig()
		{
			return this.OverrideConfig != null;
		}

		// Token: 0x17008B9A RID: 35738
		// (get) Token: 0x0603A49C RID: 238748 RVA: 0x00DDC6CC File Offset: 0x00DDA8CC
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

		// Token: 0x0603A49D RID: 238749 RVA: 0x00DDC7B8 File Offset: 0x00DDA9B8
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

		// Token: 0x0603A49E RID: 238750 RVA: 0x00DDC82A File Offset: 0x00DDAA2A
		public void UseSubmitNode()
		{
			this.SubmitNode(null);
		}

		// Token: 0x0603A49F RID: 238751 RVA: 0x00DDC834 File Offset: 0x00DDAA34
		public int? GetDungeonId()
		{
			Blackboard blackboard = this.Blackboard;
			if (blackboard == null)
			{
				return null;
			}
			return new int?(blackboard.DungeonId);
		}

		// Token: 0x0401E635 RID: 124469
		public ITakePhotoPosCondition TakePlace;

		// Token: 0x0401E636 RID: 124470
		public ITakePhotoTimeCondition TakeTime;

		// Token: 0x0401E637 RID: 124471
		[Nullable(1)]
		public List<IPhotoTarget> TakeTargetArray = new List<IPhotoTarget>();

		// Token: 0x0401E638 RID: 124472
		public ITakePhoto2Condition OverrideConfig;
	}
}
