using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FC2 RID: 8130
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeLimitOptionGroupBaseStyle
	{
		// Token: 0x0600B2DA RID: 45786 RVA: 0x001A0AD4 File Offset: 0x0019ECD4
		private ITimeLimitOptionGroupBaseStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeLimitOptionGroupBaseStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeLimitOptionGroupBaseStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeLimitOptionGroupBaseStyle_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2DB RID: 45787 RVA: 0x001A0B0C File Offset: 0x0019ED0C
		public static ITimeLimitOptionGroupBaseStyle Create([Nullable(2)] ITimeLimitOptionGroupBaseStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroupBaseStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2DC RID: 45788 RVA: 0x001A0B1F File Offset: 0x0019ED1F
		public static ITimeLimitOptionGroupBaseStyle CreateFromSetValue([Nullable(2)] ITimeLimitOptionGroupBaseStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroupBaseStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2DD RID: 45789 RVA: 0x001A0B32 File Offset: 0x0019ED32
		public ITimeLimitOptionGroupBaseStyle_SetValue ToSetValue()
		{
			return new ITimeLimitOptionGroupBaseStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x0600B2DE RID: 45790 RVA: 0x001A0B45 File Offset: 0x0019ED45
		// (set) Token: 0x0600B2DF RID: 45791 RVA: 0x001A0B70 File Offset: 0x0019ED70
		public virtual ETimeLimitOptionGroupStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeLimitOptionGroupStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006BFB RID: 27643
		[Nullable(2)]
		protected ITimeLimitOptionGroupBaseStyle FbInstance;

		// Token: 0x04006BFC RID: 27644
		[Nullable(2)]
		protected ITimeLimitOptionGroupBaseStyle_SetValue PocoInterface;
	}
}
