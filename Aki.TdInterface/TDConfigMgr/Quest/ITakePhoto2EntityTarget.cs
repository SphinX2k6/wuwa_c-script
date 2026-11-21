using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A0 RID: 4768
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2EntityTarget : ITakePhoto2Target
	{
		// Token: 0x06006B63 RID: 27491 RVA: 0x001005EC File Offset: 0x000FE7EC
		[NullableContext(0)]
		private ITakePhoto2EntityTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2EntityTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2EntityTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2EntityTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x00100624 File Offset: 0x000FE824
		[NullableContext(0)]
		public static ITakePhoto2EntityTarget Create([Nullable(2)] ITakePhoto2EntityTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2EntityTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x00100637 File Offset: 0x000FE837
		[NullableContext(0)]
		public static ITakePhoto2EntityTarget CreateFromSetValue([Nullable(2)] ITakePhoto2EntityTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2EntityTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006B66 RID: 27494 RVA: 0x0010064C File Offset: 0x000FE84C
		[NullableContext(0)]
		public new ITakePhoto2EntityTarget_SetValue ToSetValue()
		{
			return new ITakePhoto2EntityTarget_SetValue
			{
				Type = this.Type,
				IsOptionalTarget = this.IsOptionalTarget,
				TargetCameraDistanceCondition = this.TargetCameraDistanceCondition,
				EntityId = this.EntityId,
				TargetPosCondition = this.TargetPosCondition,
				TargetPlayMontageCondition = this.TargetPlayMontageCondition,
				TargetAnsTagCondition = this.TargetAnsTagCondition,
				TargetPartCondition = this.TargetPartCondition
			};
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x06006B67 RID: 27495 RVA: 0x001006BE File Offset: 0x000FE8BE
		// (set) Token: 0x06006B68 RID: 27496 RVA: 0x001006E9 File Offset: 0x000FE8E9
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

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x06006B69 RID: 27497 RVA: 0x001006F8 File Offset: 0x000FE8F8
		// (set) Token: 0x06006B6A RID: 27498 RVA: 0x00100732 File Offset: 0x000FE932
		public override bool? IsOptionalTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOptionalTarget;
				}
				ITakePhoto2EntityTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x06006B6B RID: 27499 RVA: 0x00100740 File Offset: 0x000FE940
		// (set) Token: 0x06006B6C RID: 27500 RVA: 0x001007A1 File Offset: 0x000FE9A1
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
					ITakePhoto2EntityTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x001007B6 File Offset: 0x000FE9B6
		// (set) Token: 0x06006B6E RID: 27502 RVA: 0x001007E1 File Offset: 0x000FE9E1
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

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x06006B6F RID: 27503 RVA: 0x001007F0 File Offset: 0x000FE9F0
		// (set) Token: 0x06006B70 RID: 27504 RVA: 0x00100851 File Offset: 0x000FEA51
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
					ITakePhoto2EntityTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x06006B71 RID: 27505 RVA: 0x00100868 File Offset: 0x000FEA68
		// (set) Token: 0x06006B72 RID: 27506 RVA: 0x001008C9 File Offset: 0x000FEAC9
		public virtual ITakePhoto2TargetPlayMontageCondition TargetPlayMontageCondition
		{
			get
			{
				if (this._TargetPlayMontageConditionInited)
				{
					return this._TargetPlayMontageConditionCache;
				}
				this._TargetPlayMontageConditionInited = true;
				if (this.FbInstance != null)
				{
					this._TargetPlayMontageConditionCache = ITakePhoto2TargetPlayMontageCondition.Create(this.FbInstance.TargetPlayMontageCondition);
				}
				else
				{
					ITakePhoto2EntityTarget_SetValue pocoInterface = this.PocoInterface;
					this._TargetPlayMontageConditionCache = ((pocoInterface != null) ? pocoInterface.TargetPlayMontageCondition : null);
				}
				return this._TargetPlayMontageConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetPlayMontageCondition = value;
				this._TargetPlayMontageConditionInited = false;
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x06006B73 RID: 27507 RVA: 0x001008E0 File Offset: 0x000FEAE0
		// (set) Token: 0x06006B74 RID: 27508 RVA: 0x00100941 File Offset: 0x000FEB41
		public virtual ITakePhoto2TargetAnsTagCondition TargetAnsTagCondition
		{
			get
			{
				if (this._TargetAnsTagConditionInited)
				{
					return this._TargetAnsTagConditionCache;
				}
				this._TargetAnsTagConditionInited = true;
				if (this.FbInstance != null)
				{
					this._TargetAnsTagConditionCache = ITakePhoto2TargetAnsTagCondition.Create(this.FbInstance.TargetAnsTagCondition);
				}
				else
				{
					ITakePhoto2EntityTarget_SetValue pocoInterface = this.PocoInterface;
					this._TargetAnsTagConditionCache = ((pocoInterface != null) ? pocoInterface.TargetAnsTagCondition : null);
				}
				return this._TargetAnsTagConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetAnsTagCondition = value;
				this._TargetAnsTagConditionInited = false;
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x06006B75 RID: 27509 RVA: 0x00100958 File Offset: 0x000FEB58
		// (set) Token: 0x06006B76 RID: 27510 RVA: 0x001009B9 File Offset: 0x000FEBB9
		public virtual ITakePhoto2TargetPartCondition TargetPartCondition
		{
			get
			{
				if (this._TargetPartConditionInited)
				{
					return this._TargetPartConditionCache;
				}
				this._TargetPartConditionInited = true;
				if (this.FbInstance != null)
				{
					this._TargetPartConditionCache = ITakePhoto2TargetPartCondition.Create(this.FbInstance.TargetPartCondition);
				}
				else
				{
					ITakePhoto2EntityTarget_SetValue pocoInterface = this.PocoInterface;
					this._TargetPartConditionCache = ((pocoInterface != null) ? pocoInterface.TargetPartCondition : null);
				}
				return this._TargetPartConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetPartCondition = value;
				this._TargetPartConditionInited = false;
			}
		}

		// Token: 0x04004021 RID: 16417
		protected new ITakePhoto2EntityTarget FbInstance;

		// Token: 0x04004022 RID: 16418
		protected new ITakePhoto2EntityTarget_SetValue PocoInterface;

		// Token: 0x04004023 RID: 16419
		[Nullable(0)]
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x04004024 RID: 16420
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x04004025 RID: 16421
		[Nullable(0)]
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x04004026 RID: 16422
		private bool _TargetPosConditionInited;

		// Token: 0x04004027 RID: 16423
		[Nullable(0)]
		private ITakePhoto2TargetPlayMontageCondition _TargetPlayMontageConditionCache;

		// Token: 0x04004028 RID: 16424
		private bool _TargetPlayMontageConditionInited;

		// Token: 0x04004029 RID: 16425
		[Nullable(0)]
		private ITakePhoto2TargetAnsTagCondition _TargetAnsTagConditionCache;

		// Token: 0x0400402A RID: 16426
		private bool _TargetAnsTagConditionInited;

		// Token: 0x0400402B RID: 16427
		[Nullable(0)]
		private ITakePhoto2TargetPartCondition _TargetPartConditionCache;

		// Token: 0x0400402C RID: 16428
		private bool _TargetPartConditionInited;
	}
}
