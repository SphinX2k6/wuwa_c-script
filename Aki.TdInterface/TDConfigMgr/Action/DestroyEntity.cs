using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016BC RID: 5820
	public class DestroyEntity : ActionParams
	{
		// Token: 0x0600826F RID: 33391 RVA: 0x00138B7C File Offset: 0x00136D7C
		private DestroyEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DestroyEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DestroyEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DestroyEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06008270 RID: 33392 RVA: 0x00138BB4 File Offset: 0x00136DB4
		public static DestroyEntity Create([Nullable(2)] DestroyEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008271 RID: 33393 RVA: 0x00138BC7 File Offset: 0x00136DC7
		public static DestroyEntity CreateFromSetValue([Nullable(2)] DestroyEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DestroyEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008272 RID: 33394 RVA: 0x00138BDA File Offset: 0x00136DDA
		public DestroyEntity_SetValue ToSetValue()
		{
			return new DestroyEntity_SetValue
			{
				EntityIds = this.EntityIds,
				DelayDestroy = this.DelayDestroy
			};
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x06008273 RID: 33395 RVA: 0x00138BF9 File Offset: 0x00136DF9
		// (set) Token: 0x06008274 RID: 33396 RVA: 0x00138C20 File Offset: 0x00136E20
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				DestroyEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x06008275 RID: 33397 RVA: 0x00138C30 File Offset: 0x00136E30
		// (set) Token: 0x06008276 RID: 33398 RVA: 0x00138C6A File Offset: 0x00136E6A
		public virtual bool? DelayDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayDestroy;
				}
				DestroyEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayDestroy;
			}
			set
			{
				this.GetOrCreatePoco().DelayDestroy = value;
			}
		}

		// Token: 0x04004ACA RID: 19146
		[Nullable(2)]
		protected new DestroyEntity FbInstance;

		// Token: 0x04004ACB RID: 19147
		[Nullable(2)]
		protected DestroyEntity_SetValue PocoInterface;
	}
}
