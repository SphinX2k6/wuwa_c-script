using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AED RID: 6893
	[NullableContext(1)]
	[Nullable(0)]
	public class IHeadStyle
	{
		// Token: 0x060093AC RID: 37804 RVA: 0x00156854 File Offset: 0x00154A54
		private IHeadStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyle_SetValue());
			}
			return result;
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x0015688C File Offset: 0x00154A8C
		public static IHeadStyle Create([Nullable(2)] IHeadStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x0015689F File Offset: 0x00154A9F
		public static IHeadStyle CreateFromSetValue([Nullable(2)] IHeadStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x001568B2 File Offset: 0x00154AB2
		public IHeadStyle_SetValue ToSetValue()
		{
			return new IHeadStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x060093B0 RID: 37808 RVA: 0x001568C5 File Offset: 0x00154AC5
		// (set) Token: 0x060093B1 RID: 37809 RVA: 0x001568F0 File Offset: 0x00154AF0
		public virtual EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005AB3 RID: 23219
		[Nullable(2)]
		protected IHeadStyle FbInstance;

		// Token: 0x04005AB4 RID: 23220
		[Nullable(2)]
		protected IHeadStyle_SetValue PocoInterface;
	}
}
