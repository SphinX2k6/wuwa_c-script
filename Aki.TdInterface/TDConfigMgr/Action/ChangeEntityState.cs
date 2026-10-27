using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014D0 RID: 5328
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeEntityState : ActionParams
	{
		// Token: 0x0600794E RID: 31054 RVA: 0x001226A4 File Offset: 0x001208A4
		private ChangeEntityState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeEntityState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeEntityState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeEntityState_SetValue());
			}
			return result;
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x001226DC File Offset: 0x001208DC
		public static ChangeEntityState Create([Nullable(2)] ChangeEntityState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeEntityState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x001226EF File Offset: 0x001208EF
		public static ChangeEntityState CreateFromSetValue([Nullable(2)] ChangeEntityState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeEntityState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x00122702 File Offset: 0x00120902
		public ChangeEntityState_SetValue ToSetValue()
		{
			return new ChangeEntityState_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x06007952 RID: 31058 RVA: 0x00122721 File Offset: 0x00120921
		// (set) Token: 0x06007953 RID: 31059 RVA: 0x0012274C File Offset: 0x0012094C
		public virtual EChangeEntityState Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeEntityState.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x06007954 RID: 31060 RVA: 0x0012275A File Offset: 0x0012095A
		// (set) Token: 0x06007955 RID: 31061 RVA: 0x00122785 File Offset: 0x00120985
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

		// Token: 0x04004668 RID: 18024
		[Nullable(2)]
		protected new ChangeEntityState FbInstance;

		// Token: 0x04004669 RID: 18025
		[Nullable(2)]
		protected ChangeEntityState_SetValue PocoInterface;
	}
}
