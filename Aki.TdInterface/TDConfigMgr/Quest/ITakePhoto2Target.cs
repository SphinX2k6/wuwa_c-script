using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001176 RID: 4470
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2Target
	{
		// Token: 0x0600658C RID: 25996 RVA: 0x000F3AD4 File Offset: 0x000F1CD4
		private ITakePhoto2Target_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2Target 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2Target_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2Target_SetValue());
			}
			return result;
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x000F3B0C File Offset: 0x000F1D0C
		public static ITakePhoto2Target Create([Nullable(2)] ITakePhoto2Target instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2Target
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x000F3B1F File Offset: 0x000F1D1F
		public static ITakePhoto2Target CreateFromSetValue([Nullable(2)] ITakePhoto2Target_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2Target
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x000F3B32 File Offset: 0x000F1D32
		public ITakePhoto2Target_SetValue ToSetValue()
		{
			return new ITakePhoto2Target_SetValue
			{
				Type = this.Type,
				IsOptionalTarget = this.IsOptionalTarget,
				TargetCameraDistanceCondition = this.TargetCameraDistanceCondition
			};
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06006590 RID: 26000 RVA: 0x000F3B5D File Offset: 0x000F1D5D
		// (set) Token: 0x06006591 RID: 26001 RVA: 0x000F3B88 File Offset: 0x000F1D88
		public virtual ETakePhoto2TargetType Type
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

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06006592 RID: 26002 RVA: 0x000F3B98 File Offset: 0x000F1D98
		// (set) Token: 0x06006593 RID: 26003 RVA: 0x000F3BD2 File Offset: 0x000F1DD2
		public virtual bool? IsOptionalTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOptionalTarget;
				}
				ITakePhoto2Target_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06006594 RID: 26004 RVA: 0x000F3BE0 File Offset: 0x000F1DE0
		// (set) Token: 0x06006595 RID: 26005 RVA: 0x000F3C41 File Offset: 0x000F1E41
		[Nullable(2)]
		public virtual ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition
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
					ITakePhoto2Target_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003CF3 RID: 15603
		[Nullable(2)]
		protected ITakePhoto2Target FbInstance;

		// Token: 0x04003CF4 RID: 15604
		[Nullable(2)]
		protected ITakePhoto2Target_SetValue PocoInterface;

		// Token: 0x04003CF5 RID: 15605
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x04003CF6 RID: 15606
		private bool _TargetCameraDistanceConditionInited;
	}
}
