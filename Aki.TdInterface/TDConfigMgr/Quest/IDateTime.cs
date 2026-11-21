using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001062 RID: 4194
	public class IDateTime
	{
		// Token: 0x06005C5E RID: 23646 RVA: 0x000E0AAC File Offset: 0x000DECAC
		private IDateTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDateTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDateTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDateTime_SetValue());
			}
			return result;
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x000E0AE4 File Offset: 0x000DECE4
		public static IDateTime Create([Nullable(2)] IDateTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDateTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x000E0AF7 File Offset: 0x000DECF7
		public static IDateTime CreateFromSetValue([Nullable(2)] IDateTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDateTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x000E0B0A File Offset: 0x000DED0A
		public IDateTime_SetValue ToSetValue()
		{
			return new IDateTime_SetValue
			{
				Hours = this.Hours,
				Minutes = this.Minutes,
				Days = this.Days
			};
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x06005C62 RID: 23650 RVA: 0x000E0B35 File Offset: 0x000DED35
		// (set) Token: 0x06005C63 RID: 23651 RVA: 0x000E0B60 File Offset: 0x000DED60
		public virtual int Hours
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Hours;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Hours;
			}
			set
			{
				this.GetOrCreatePoco().Hours = value;
			}
		}

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x06005C64 RID: 23652 RVA: 0x000E0B6E File Offset: 0x000DED6E
		// (set) Token: 0x06005C65 RID: 23653 RVA: 0x000E0B99 File Offset: 0x000DED99
		public virtual int Minutes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Minutes;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Minutes;
			}
			set
			{
				this.GetOrCreatePoco().Minutes = value;
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x06005C66 RID: 23654 RVA: 0x000E0BA8 File Offset: 0x000DEDA8
		// (set) Token: 0x06005C67 RID: 23655 RVA: 0x000E0BE2 File Offset: 0x000DEDE2
		public virtual int? Days
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Days;
				}
				IDateTime_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Days;
			}
			set
			{
				this.GetOrCreatePoco().Days = value;
			}
		}

		// Token: 0x040037A4 RID: 14244
		[Nullable(2)]
		protected IDateTime FbInstance;

		// Token: 0x040037A5 RID: 14245
		[Nullable(2)]
		protected IDateTime_SetValue PocoInterface;
	}
}
