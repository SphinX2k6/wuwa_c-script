using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200116C RID: 4460
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2EntityTarget : ITakePhoto2Target
	{
		// Token: 0x06006544 RID: 25924 RVA: 0x000F3054 File Offset: 0x000F1254
		[NullableContext(1)]
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

		// Token: 0x06006545 RID: 25925 RVA: 0x000F308C File Offset: 0x000F128C
		[NullableContext(1)]
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

		// Token: 0x06006546 RID: 25926 RVA: 0x000F309F File Offset: 0x000F129F
		[NullableContext(1)]
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

		// Token: 0x06006547 RID: 25927 RVA: 0x000F30B4 File Offset: 0x000F12B4
		[NullableContext(1)]
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

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06006548 RID: 25928 RVA: 0x000F3126 File Offset: 0x000F1326
		// (set) Token: 0x06006549 RID: 25929 RVA: 0x000F3151 File Offset: 0x000F1351
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

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x0600654A RID: 25930 RVA: 0x000F3160 File Offset: 0x000F1360
		// (set) Token: 0x0600654B RID: 25931 RVA: 0x000F319A File Offset: 0x000F139A
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

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x0600654C RID: 25932 RVA: 0x000F31A8 File Offset: 0x000F13A8
		// (set) Token: 0x0600654D RID: 25933 RVA: 0x000F3209 File Offset: 0x000F1409
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

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x0600654E RID: 25934 RVA: 0x000F321E File Offset: 0x000F141E
		// (set) Token: 0x0600654F RID: 25935 RVA: 0x000F3249 File Offset: 0x000F1449
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

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06006550 RID: 25936 RVA: 0x000F3258 File Offset: 0x000F1458
		// (set) Token: 0x06006551 RID: 25937 RVA: 0x000F32B9 File Offset: 0x000F14B9
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

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06006552 RID: 25938 RVA: 0x000F32D0 File Offset: 0x000F14D0
		// (set) Token: 0x06006553 RID: 25939 RVA: 0x000F3331 File Offset: 0x000F1531
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

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06006554 RID: 25940 RVA: 0x000F3348 File Offset: 0x000F1548
		// (set) Token: 0x06006555 RID: 25941 RVA: 0x000F33A9 File Offset: 0x000F15A9
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

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06006556 RID: 25942 RVA: 0x000F33C0 File Offset: 0x000F15C0
		// (set) Token: 0x06006557 RID: 25943 RVA: 0x000F3421 File Offset: 0x000F1621
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

		// Token: 0x04003CC2 RID: 15554
		protected new ITakePhoto2EntityTarget FbInstance;

		// Token: 0x04003CC3 RID: 15555
		protected new ITakePhoto2EntityTarget_SetValue PocoInterface;

		// Token: 0x04003CC4 RID: 15556
		[Nullable(1)]
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x04003CC5 RID: 15557
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x04003CC6 RID: 15558
		[Nullable(1)]
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x04003CC7 RID: 15559
		private bool _TargetPosConditionInited;

		// Token: 0x04003CC8 RID: 15560
		[Nullable(1)]
		private ITakePhoto2TargetPlayMontageCondition _TargetPlayMontageConditionCache;

		// Token: 0x04003CC9 RID: 15561
		private bool _TargetPlayMontageConditionInited;

		// Token: 0x04003CCA RID: 15562
		[Nullable(1)]
		private ITakePhoto2TargetAnsTagCondition _TargetAnsTagConditionCache;

		// Token: 0x04003CCB RID: 15563
		private bool _TargetAnsTagConditionInited;

		// Token: 0x04003CCC RID: 15564
		[Nullable(1)]
		private ITakePhoto2TargetPartCondition _TargetPartConditionCache;

		// Token: 0x04003CCD RID: 15565
		private bool _TargetPartConditionInited;
	}
}
