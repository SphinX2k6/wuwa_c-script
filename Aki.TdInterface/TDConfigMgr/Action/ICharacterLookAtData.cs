using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001880 RID: 6272
	[NullableContext(1)]
	[Nullable(0)]
	public class ICharacterLookAtData
	{
		// Token: 0x060086C1 RID: 34497 RVA: 0x0013FE60 File Offset: 0x0013E060
		private ICharacterLookAtData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterLookAtData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterLookAtData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterLookAtData_SetValue());
			}
			return result;
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x0013FE98 File Offset: 0x0013E098
		public static ICharacterLookAtData Create([Nullable(2)] ICharacterLookAtData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x0013FEAB File Offset: 0x0013E0AB
		public static ICharacterLookAtData CreateFromSetValue([Nullable(2)] ICharacterLookAtData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterLookAtData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x0013FEBE File Offset: 0x0013E0BE
		public ICharacterLookAtData_SetValue ToSetValue()
		{
			return new ICharacterLookAtData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x060086C5 RID: 34501 RVA: 0x0013FED1 File Offset: 0x0013E0D1
		// (set) Token: 0x060086C6 RID: 34502 RVA: 0x0013FEFC File Offset: 0x0013E0FC
		public virtual ECharacterLookAt Type
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

		// Token: 0x040054EE RID: 21742
		[Nullable(2)]
		protected ICharacterLookAtData FbInstance;

		// Token: 0x040054EF RID: 21743
		[Nullable(2)]
		protected ICharacterLookAtData_SetValue PocoInterface;
	}
}
