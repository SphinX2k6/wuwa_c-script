using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012AE RID: 4782
	public class ITakePhoto2TaggedActorTarget : ITakePhoto2Target
	{
		// Token: 0x06006BB1 RID: 27569 RVA: 0x00100FF4 File Offset: 0x000FF1F4
		private ITakePhoto2TaggedActorTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2TaggedActorTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2TaggedActorTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2TaggedActorTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x0010102C File Offset: 0x000FF22C
		public static ITakePhoto2TaggedActorTarget Create([Nullable(2)] ITakePhoto2TaggedActorTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TaggedActorTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x0010103F File Offset: 0x000FF23F
		public static ITakePhoto2TaggedActorTarget CreateFromSetValue([Nullable(2)] ITakePhoto2TaggedActorTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2TaggedActorTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006BB4 RID: 27572 RVA: 0x00101054 File Offset: 0x000FF254
		public new ITakePhoto2TaggedActorTarget_SetValue ToSetValue()
		{
			return new ITakePhoto2TaggedActorTarget_SetValue
			{
				Type = this.Type,
				IsOptionalTarget = this.IsOptionalTarget,
				TargetCameraDistanceCondition = this.TargetCameraDistanceCondition,
				Tag = this.Tag,
				TargetPosCondition = this.TargetPosCondition,
				TargetSatisfiedCount = this.TargetSatisfiedCount
			};
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x06006BB5 RID: 27573 RVA: 0x001010AE File Offset: 0x000FF2AE
		// (set) Token: 0x06006BB6 RID: 27574 RVA: 0x001010D9 File Offset: 0x000FF2D9
		public override ETakePhoto2TargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETakePhoto2TargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x06006BB7 RID: 27575 RVA: 0x001010E8 File Offset: 0x000FF2E8
		// (set) Token: 0x06006BB8 RID: 27576 RVA: 0x00101122 File Offset: 0x000FF322
		public override bool? IsOptionalTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOptionalTarget;
				}
				ITakePhoto2TaggedActorTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOptionalTarget;
			}
			set
			{
				this.GetOrCreatePoco().IsOptionalTarget = value;
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x06006BB9 RID: 27577 RVA: 0x00101130 File Offset: 0x000FF330
		// (set) Token: 0x06006BBA RID: 27578 RVA: 0x00101191 File Offset: 0x000FF391
		[Nullable(2)]
		public override ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition
		{
			[NullableContext(2)]
			get
			{
				if (this._TargetCameraDistanceConditionInited)
				{
					return this._TargetCameraDistanceConditionCache;
				}
				this._TargetCameraDistanceConditionInited = true;
				if (this.FbInstance != null)
				{
					this._TargetCameraDistanceConditionCache = ITakePhoto2TargetCameraDistanceCondition.Create(this.FbInstance.TargetCameraDistanceCondition);
				}
				else
				{
					ITakePhoto2TaggedActorTarget_SetValue pocoInterface = this.PocoInterface;
					this._TargetCameraDistanceConditionCache = ((pocoInterface != null) ? pocoInterface.TargetCameraDistanceCondition : null);
				}
				return this._TargetCameraDistanceConditionCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TargetCameraDistanceCondition = value;
				this._TargetCameraDistanceConditionInited = false;
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x06006BBB RID: 27579 RVA: 0x001011A6 File Offset: 0x000FF3A6
		// (set) Token: 0x06006BBC RID: 27580 RVA: 0x001011D1 File Offset: 0x000FF3D1
		public virtual string Tag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Tag;
			}
			set
			{
				this.GetOrCreatePoco().Tag = value;
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x06006BBD RID: 27581 RVA: 0x001011E0 File Offset: 0x000FF3E0
		// (set) Token: 0x06006BBE RID: 27582 RVA: 0x00101241 File Offset: 0x000FF441
		[Nullable(2)]
		public virtual ITakePhoto2TargetPosByRangeCondition TargetPosCondition
		{
			[NullableContext(2)]
			get
			{
				if (this._TargetPosConditionInited)
				{
					return this._TargetPosConditionCache;
				}
				this._TargetPosConditionInited = true;
				if (this.FbInstance != null)
				{
					this._TargetPosConditionCache = ITakePhoto2TargetPosByRangeCondition.Create(this.FbInstance.TargetPosCondition);
				}
				else
				{
					ITakePhoto2TaggedActorTarget_SetValue pocoInterface = this.PocoInterface;
					this._TargetPosConditionCache = ((pocoInterface != null) ? pocoInterface.TargetPosCondition : null);
				}
				return this._TargetPosConditionCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TargetPosCondition = value;
				this._TargetPosConditionInited = false;
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x06006BBF RID: 27583 RVA: 0x00101256 File Offset: 0x000FF456
		// (set) Token: 0x06006BC0 RID: 27584 RVA: 0x00101281 File Offset: 0x000FF481
		public virtual int TargetSatisfiedCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetSatisfiedCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetSatisfiedCount;
			}
			set
			{
				this.GetOrCreatePoco().TargetSatisfiedCount = value;
			}
		}

		// Token: 0x0400404F RID: 16463
		[Nullable(2)]
		protected new ITakePhoto2TaggedActorTarget FbInstance;

		// Token: 0x04004050 RID: 16464
		[Nullable(2)]
		protected new ITakePhoto2TaggedActorTarget_SetValue PocoInterface;

		// Token: 0x04004051 RID: 16465
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x04004052 RID: 16466
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x04004053 RID: 16467
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x04004054 RID: 16468
		private bool _TargetPosConditionInited;
	}
}
