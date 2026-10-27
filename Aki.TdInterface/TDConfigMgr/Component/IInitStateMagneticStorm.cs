using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200046C RID: 1132
	[NullableContext(1)]
	[Nullable(0)]
	public class IInitStateMagneticStorm : IInitState
	{
		// Token: 0x060016D1 RID: 5841 RVA: 0x00045DCC File Offset: 0x00043FCC
		private IInitStateMagneticStorm_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitStateMagneticStorm 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitStateMagneticStorm_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitStateMagneticStorm_SetValue());
			}
			return result;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00045E04 File Offset: 0x00044004
		public static IInitStateMagneticStorm Create([Nullable(2)] IInitStateMagneticStorm instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateMagneticStorm
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00045E17 File Offset: 0x00044017
		public static IInitStateMagneticStorm CreateFromSetValue([Nullable(2)] IInitStateMagneticStorm_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitStateMagneticStorm
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00045E2A File Offset: 0x0004402A
		public new IInitStateMagneticStorm_SetValue ToSetValue()
		{
			return new IInitStateMagneticStorm_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00045E3D File Offset: 0x0004403D
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x00045E68 File Offset: 0x00044068
		public override EInitStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInitStateType.Birth;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001147 RID: 4423
		[Nullable(2)]
		protected new IInitStateMagneticStorm FbInstance;

		// Token: 0x04001148 RID: 4424
		[Nullable(2)]
		protected new IInitStateMagneticStorm_SetValue PocoInterface;
	}
}
