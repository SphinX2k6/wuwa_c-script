using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200116E RID: 4462
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2PhotoTargetEntityTarget : ITakePhoto2Target
	{
		// Token: 0x0600655A RID: 25946 RVA: 0x000F3448 File Offset: 0x000F1648
		[NullableContext(1)]
		private ITakePhoto2PhotoTargetEntityTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2PhotoTargetEntityTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2PhotoTargetEntityTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2PhotoTargetEntityTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x000F3480 File Offset: 0x000F1680
		[NullableContext(1)]
		public static ITakePhoto2PhotoTargetEntityTarget Create([Nullable(2)] ITakePhoto2PhotoTargetEntityTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2PhotoTargetEntityTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x000F3493 File Offset: 0x000F1693
		[NullableContext(1)]
		public static ITakePhoto2PhotoTargetEntityTarget CreateFromSetValue([Nullable(2)] ITakePhoto2PhotoTargetEntityTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2PhotoTargetEntityTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x000F34A8 File Offset: 0x000F16A8
		[NullableContext(1)]
		public new ITakePhoto2PhotoTargetEntityTarget_SetValue ToSetValue()
		{
			return new ITakePhoto2PhotoTargetEntityTarget_SetValue
			{
				Type = this.Type,
				IsOptionalTarget = this.IsOptionalTarget,
				TargetCameraDistanceCondition = this.TargetCameraDistanceCondition,
				EntityId = this.EntityId,
				TargetPosCondition = this.TargetPosCondition
			};
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x0600655E RID: 25950 RVA: 0x000F34F6 File Offset: 0x000F16F6
		// (set) Token: 0x0600655F RID: 25951 RVA: 0x000F3521 File Offset: 0x000F1721
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

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06006560 RID: 25952 RVA: 0x000F3530 File Offset: 0x000F1730
		// (set) Token: 0x06006561 RID: 25953 RVA: 0x000F356A File Offset: 0x000F176A
		public override bool? IsOptionalTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOptionalTarget;
				}
				ITakePhoto2PhotoTargetEntityTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06006562 RID: 25954 RVA: 0x000F3578 File Offset: 0x000F1778
		// (set) Token: 0x06006563 RID: 25955 RVA: 0x000F35D9 File Offset: 0x000F17D9
		public override ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition
		{
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
					ITakePhoto2PhotoTargetEntityTarget_SetValue pocoInterface = this.PocoInterface;
					this._TargetCameraDistanceConditionCache = ((pocoInterface != null) ? pocoInterface.TargetCameraDistanceCondition : null);
				}
				return this._TargetCameraDistanceConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetCameraDistanceCondition = value;
				this._TargetCameraDistanceConditionInited = false;
			}
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x06006564 RID: 25956 RVA: 0x000F35EE File Offset: 0x000F17EE
		// (set) Token: 0x06006565 RID: 25957 RVA: 0x000F3619 File Offset: 0x000F1819
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x06006566 RID: 25958 RVA: 0x000F3628 File Offset: 0x000F1828
		// (set) Token: 0x06006567 RID: 25959 RVA: 0x000F3689 File Offset: 0x000F1889
		public virtual ITakePhoto2TargetPosByRangeCondition TargetPosCondition
		{
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
					ITakePhoto2PhotoTargetEntityTarget_SetValue pocoInterface = this.PocoInterface;
					this._TargetPosConditionCache = ((pocoInterface != null) ? pocoInterface.TargetPosCondition : null);
				}
				return this._TargetPosConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetPosCondition = value;
				this._TargetPosConditionInited = false;
			}
		}

		// Token: 0x04003CD6 RID: 15574
		protected new ITakePhoto2PhotoTargetEntityTarget FbInstance;

		// Token: 0x04003CD7 RID: 15575
		protected new ITakePhoto2PhotoTargetEntityTarget_SetValue PocoInterface;

		// Token: 0x04003CD8 RID: 15576
		[Nullable(1)]
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x04003CD9 RID: 15577
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x04003CDA RID: 15578
		[Nullable(1)]
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x04003CDB RID: 15579
		private bool _TargetPosConditionInited;
	}
}
