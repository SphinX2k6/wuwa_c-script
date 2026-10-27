using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001174 RID: 4468
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2TaggedActorTarget : ITakePhoto2Target
	{
		// Token: 0x0600657A RID: 25978 RVA: 0x000F3828 File Offset: 0x000F1A28
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

		// Token: 0x0600657B RID: 25979 RVA: 0x000F3860 File Offset: 0x000F1A60
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

		// Token: 0x0600657C RID: 25980 RVA: 0x000F3873 File Offset: 0x000F1A73
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

		// Token: 0x0600657D RID: 25981 RVA: 0x000F3888 File Offset: 0x000F1A88
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

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x0600657E RID: 25982 RVA: 0x000F38E2 File Offset: 0x000F1AE2
		// (set) Token: 0x0600657F RID: 25983 RVA: 0x000F390D File Offset: 0x000F1B0D
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

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06006580 RID: 25984 RVA: 0x000F391C File Offset: 0x000F1B1C
		// (set) Token: 0x06006581 RID: 25985 RVA: 0x000F3956 File Offset: 0x000F1B56
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

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06006582 RID: 25986 RVA: 0x000F3964 File Offset: 0x000F1B64
		// (set) Token: 0x06006583 RID: 25987 RVA: 0x000F39C5 File Offset: 0x000F1BC5
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

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06006584 RID: 25988 RVA: 0x000F39DA File Offset: 0x000F1BDA
		// (set) Token: 0x06006585 RID: 25989 RVA: 0x000F3A05 File Offset: 0x000F1C05
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

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06006586 RID: 25990 RVA: 0x000F3A14 File Offset: 0x000F1C14
		// (set) Token: 0x06006587 RID: 25991 RVA: 0x000F3A75 File Offset: 0x000F1C75
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

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06006588 RID: 25992 RVA: 0x000F3A8A File Offset: 0x000F1C8A
		// (set) Token: 0x06006589 RID: 25993 RVA: 0x000F3AB5 File Offset: 0x000F1CB5
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

		// Token: 0x04003CE7 RID: 15591
		[Nullable(2)]
		protected new ITakePhoto2TaggedActorTarget FbInstance;

		// Token: 0x04003CE8 RID: 15592
		[Nullable(2)]
		protected new ITakePhoto2TaggedActorTarget_SetValue PocoInterface;

		// Token: 0x04003CE9 RID: 15593
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x04003CEA RID: 15594
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x04003CEB RID: 15595
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x04003CEC RID: 15596
		private bool _TargetPosConditionInited;
	}
}
