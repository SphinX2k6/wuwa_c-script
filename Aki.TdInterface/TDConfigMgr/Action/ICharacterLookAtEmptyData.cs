using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001882 RID: 6274
	[NullableContext(1)]
	[Nullable(0)]
	public class ICharacterLookAtEmptyData : ICharacterLookAtData
	{
		// Token: 0x060086C9 RID: 34505 RVA: 0x0013FF1C File Offset: 0x0013E11C
		private ICharacterLookAtEmptyData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterLookAtEmptyData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterLookAtEmptyData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterLookAtEmptyData_SetValue());
			}
			return result;
		}

		// Token: 0x060086CA RID: 34506 RVA: 0x0013FF54 File Offset: 0x0013E154
		public static ICharacterLookAtEmptyData Create([Nullable(2)] ICharacterLookAtEmptyData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtEmptyData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060086CB RID: 34507 RVA: 0x0013FF67 File Offset: 0x0013E167
		public static ICharacterLookAtEmptyData CreateFromSetValue([Nullable(2)] ICharacterLookAtEmptyData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterLookAtEmptyData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060086CC RID: 34508 RVA: 0x0013FF7A File Offset: 0x0013E17A
		public new ICharacterLookAtEmptyData_SetValue ToSetValue()
		{
			return new ICharacterLookAtEmptyData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x060086CD RID: 34509 RVA: 0x0013FF8D File Offset: 0x0013E18D
		// (set) Token: 0x060086CE RID: 34510 RVA: 0x0013FFB8 File Offset: 0x0013E1B8
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

		// Token: 0x040054F1 RID: 21745
		[Nullable(2)]
		protected new ICharacterLookAtEmptyData FbInstance;

		// Token: 0x040054F2 RID: 21746
		[Nullable(2)]
		protected new ICharacterLookAtEmptyData_SetValue PocoInterface;
	}
}
