using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB3 RID: 7603
	public class IMechExecute : IExecClientBattleActionType
	{
		// Token: 0x0600A17F RID: 41343 RVA: 0x00172218 File Offset: 0x00170418
		private IMechExecute_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechExecute 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechExecute_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechExecute_SetValue());
			}
			return result;
		}

		// Token: 0x0600A180 RID: 41344 RVA: 0x00172250 File Offset: 0x00170450
		public static IMechExecute Create([Nullable(2)] IMechExecute instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechExecute
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A181 RID: 41345 RVA: 0x00172263 File Offset: 0x00170463
		public static IMechExecute CreateFromSetValue([Nullable(2)] IMechExecute_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechExecute
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A182 RID: 41346 RVA: 0x00172276 File Offset: 0x00170476
		public new IMechExecute_SetValue ToSetValue()
		{
			return new IMechExecute_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600A183 RID: 41347 RVA: 0x00172295 File Offset: 0x00170495
		// (set) Token: 0x0600A184 RID: 41348 RVA: 0x001722C0 File Offset: 0x001704C0
		public override EExecClientBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600A185 RID: 41349 RVA: 0x001722CE File Offset: 0x001704CE
		// (set) Token: 0x0600A186 RID: 41350 RVA: 0x001722F9 File Offset: 0x001704F9
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

		// Token: 0x04006214 RID: 25108
		[Nullable(2)]
		protected new IMechExecute FbInstance;

		// Token: 0x04006215 RID: 25109
		[Nullable(2)]
		protected new IMechExecute_SetValue PocoInterface;
	}
}
