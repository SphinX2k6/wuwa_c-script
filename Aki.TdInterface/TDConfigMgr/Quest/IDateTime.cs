using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F38 RID: 3896
	[NullableContext(1)]
	[Nullable(0)]
	public class IDateTime
	{
		// Token: 0x0600568E RID: 22158 RVA: 0x000D40E8 File Offset: 0x000D22E8
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

		// Token: 0x0600568F RID: 22159 RVA: 0x000D4120 File Offset: 0x000D2320
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

		// Token: 0x06005690 RID: 22160 RVA: 0x000D4133 File Offset: 0x000D2333
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

		// Token: 0x06005691 RID: 22161 RVA: 0x000D4146 File Offset: 0x000D2346
		public IDateTime_SetValue ToSetValue()
		{
			return new IDateTime_SetValue
			{
				Hours = this.Hours,
				Minutes = this.Minutes,
				Days = this.Days
			};
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06005692 RID: 22162 RVA: 0x000D4171 File Offset: 0x000D2371
		// (set) Token: 0x06005693 RID: 22163 RVA: 0x000D419C File Offset: 0x000D239C
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

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06005694 RID: 22164 RVA: 0x000D41AA File Offset: 0x000D23AA
		// (set) Token: 0x06005695 RID: 22165 RVA: 0x000D41D5 File Offset: 0x000D23D5
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

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x06005696 RID: 22166 RVA: 0x000D41E4 File Offset: 0x000D23E4
		// (set) Token: 0x06005697 RID: 22167 RVA: 0x000D421E File Offset: 0x000D241E
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

		// Token: 0x04003475 RID: 13429
		[Nullable(2)]
		protected IDateTime FbInstance;

		// Token: 0x04003476 RID: 13430
		[Nullable(2)]
		protected IDateTime_SetValue PocoInterface;
	}
}
