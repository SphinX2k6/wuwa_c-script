using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002264 RID: 8804
	public class IUniversalTone
	{
		// Token: 0x0600BFDE RID: 49118 RVA: 0x001BA924 File Offset: 0x001B8B24
		private IUniversalTone_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUniversalTone 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUniversalTone_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUniversalTone_SetValue());
			}
			return result;
		}

		// Token: 0x0600BFDF RID: 49119 RVA: 0x001BA95C File Offset: 0x001B8B5C
		public static IUniversalTone Create([Nullable(2)] IUniversalTone instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUniversalTone
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BFE0 RID: 49120 RVA: 0x001BA96F File Offset: 0x001B8B6F
		public static IUniversalTone CreateFromSetValue([Nullable(2)] IUniversalTone_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUniversalTone
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BFE1 RID: 49121 RVA: 0x001BA982 File Offset: 0x001B8B82
		public IUniversalTone_SetValue ToSetValue()
		{
			return new IUniversalTone_SetValue
			{
				UniversalToneId = this.UniversalToneId,
				TimberId = this.TimberId
			};
		}

		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x0600BFE2 RID: 49122 RVA: 0x001BA9A1 File Offset: 0x001B8BA1
		// (set) Token: 0x0600BFE3 RID: 49123 RVA: 0x001BA9CC File Offset: 0x001B8BCC
		public virtual int UniversalToneId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UniversalToneId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.UniversalToneId;
			}
			set
			{
				this.GetOrCreatePoco().UniversalToneId = value;
			}
		}

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x0600BFE4 RID: 49124 RVA: 0x001BA9DC File Offset: 0x001B8BDC
		// (set) Token: 0x0600BFE5 RID: 49125 RVA: 0x001BAA16 File Offset: 0x001B8C16
		public virtual int? TimberId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimberId;
				}
				IUniversalTone_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TimberId;
			}
			set
			{
				this.GetOrCreatePoco().TimberId = value;
			}
		}

		// Token: 0x040072E8 RID: 29416
		[Nullable(2)]
		protected IUniversalTone FbInstance;

		// Token: 0x040072E9 RID: 29417
		[Nullable(2)]
		protected IUniversalTone_SetValue PocoInterface;
	}
}
