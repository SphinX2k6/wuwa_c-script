using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A6 RID: 4774
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2PhotoTargetEntityTarget : ITakePhoto2Target
	{
		// Token: 0x06006B89 RID: 27529 RVA: 0x00100B58 File Offset: 0x000FED58
		[NullableContext(0)]
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

		// Token: 0x06006B8A RID: 27530 RVA: 0x00100B90 File Offset: 0x000FED90
		[NullableContext(0)]
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

		// Token: 0x06006B8B RID: 27531 RVA: 0x00100BA3 File Offset: 0x000FEDA3
		[NullableContext(0)]
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

		// Token: 0x06006B8C RID: 27532 RVA: 0x00100BB8 File Offset: 0x000FEDB8
		[NullableContext(0)]
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

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x06006B8D RID: 27533 RVA: 0x00100C06 File Offset: 0x000FEE06
		// (set) Token: 0x06006B8E RID: 27534 RVA: 0x00100C31 File Offset: 0x000FEE31
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

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x06006B8F RID: 27535 RVA: 0x00100C40 File Offset: 0x000FEE40
		// (set) Token: 0x06006B90 RID: 27536 RVA: 0x00100C7A File Offset: 0x000FEE7A
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

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x06006B91 RID: 27537 RVA: 0x00100C88 File Offset: 0x000FEE88
		// (set) Token: 0x06006B92 RID: 27538 RVA: 0x00100CE9 File Offset: 0x000FEEE9
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

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x06006B93 RID: 27539 RVA: 0x00100CFE File Offset: 0x000FEEFE
		// (set) Token: 0x06006B94 RID: 27540 RVA: 0x00100D29 File Offset: 0x000FEF29
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

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x06006B95 RID: 27541 RVA: 0x00100D38 File Offset: 0x000FEF38
		// (set) Token: 0x06006B96 RID: 27542 RVA: 0x00100D99 File Offset: 0x000FEF99
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

		// Token: 0x0400403B RID: 16443
		protected new ITakePhoto2PhotoTargetEntityTarget FbInstance;

		// Token: 0x0400403C RID: 16444
		protected new ITakePhoto2PhotoTargetEntityTarget_SetValue PocoInterface;

		// Token: 0x0400403D RID: 16445
		[Nullable(0)]
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x0400403E RID: 16446
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x0400403F RID: 16447
		[Nullable(0)]
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x04004040 RID: 16448
		private bool _TargetPosConditionInited;
	}
}
