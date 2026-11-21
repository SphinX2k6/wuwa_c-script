using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010ED RID: 4333
	public class IInformationViewConfig
	{
		// Token: 0x06005FC6 RID: 24518 RVA: 0x000E7874 File Offset: 0x000E5A74
		private IInformationViewConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInformationViewConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInformationViewConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInformationViewConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x000E78AC File Offset: 0x000E5AAC
		public static IInformationViewConfig Create([Nullable(2)] IInformationViewConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationViewConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x000E78BF File Offset: 0x000E5ABF
		public static IInformationViewConfig CreateFromSetValue([Nullable(2)] IInformationViewConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInformationViewConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x000E78D2 File Offset: 0x000E5AD2
		public IInformationViewConfig_SetValue ToSetValue()
		{
			return new IInformationViewConfig_SetValue
			{
				InformationView = this.InformationView
			};
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06005FCA RID: 24522 RVA: 0x000E78E5 File Offset: 0x000E5AE5
		// (set) Token: 0x06005FCB RID: 24523 RVA: 0x000E790C File Offset: 0x000E5B0C
		[Nullable(2)]
		public virtual IInformationViewType InformationView
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InformationView;
				}
				IInformationViewConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InformationView;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().InformationView = value;
			}
		}

		// Token: 0x04003970 RID: 14704
		[Nullable(2)]
		protected IInformationViewConfig FbInstance;

		// Token: 0x04003971 RID: 14705
		[Nullable(2)]
		protected IInformationViewConfig_SetValue PocoInterface;
	}
}
