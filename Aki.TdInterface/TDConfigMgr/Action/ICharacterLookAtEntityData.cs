using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A0F RID: 6671
	public class ICharacterLookAtEntityData : ICharacterLookAtData
	{
		// Token: 0x06008DF9 RID: 36345 RVA: 0x0014F80C File Offset: 0x0014DA0C
		private ICharacterLookAtEntityData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterLookAtEntityData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterLookAtEntityData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterLookAtEntityData_SetValue());
			}
			return result;
		}

		// Token: 0x06008DFA RID: 36346 RVA: 0x0014F844 File Offset: 0x0014DA44
		public static ICharacterLookAtEntityData Create([Nullable(2)] ICharacterLookAtEntityData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtEntityData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DFB RID: 36347 RVA: 0x0014F857 File Offset: 0x0014DA57
		public static ICharacterLookAtEntityData CreateFromSetValue([Nullable(2)] ICharacterLookAtEntityData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterLookAtEntityData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DFC RID: 36348 RVA: 0x0014F86A File Offset: 0x0014DA6A
		public new ICharacterLookAtEntityData_SetValue ToSetValue()
		{
			return new ICharacterLookAtEntityData_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x06008DFD RID: 36349 RVA: 0x0014F889 File Offset: 0x0014DA89
		// (set) Token: 0x06008DFE RID: 36350 RVA: 0x0014F8B4 File Offset: 0x0014DAB4
		public override ECharacterLookAt Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECharacterLookAt.Empty;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x06008DFF RID: 36351 RVA: 0x0014F8C2 File Offset: 0x0014DAC2
		// (set) Token: 0x06008E00 RID: 36352 RVA: 0x0014F8ED File Offset: 0x0014DAED
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

		// Token: 0x04005941 RID: 22849
		[Nullable(2)]
		protected new ICharacterLookAtEntityData FbInstance;

		// Token: 0x04005942 RID: 22850
		[Nullable(2)]
		protected new ICharacterLookAtEntityData_SetValue PocoInterface;
	}
}
