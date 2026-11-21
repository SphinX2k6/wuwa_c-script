using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E7 RID: 4327
	public class IInformationSubTitle
	{
		// Token: 0x06005FA2 RID: 24482 RVA: 0x000E748C File Offset: 0x000E568C
		private IInformationSubTitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInformationSubTitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInformationSubTitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInformationSubTitle_SetValue());
			}
			return result;
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x000E74C4 File Offset: 0x000E56C4
		public static IInformationSubTitle Create([Nullable(2)] IInformationSubTitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationSubTitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x000E74D7 File Offset: 0x000E56D7
		public static IInformationSubTitle CreateFromSetValue([Nullable(2)] IInformationSubTitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInformationSubTitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x000E74EA File Offset: 0x000E56EA
		public IInformationSubTitle_SetValue ToSetValue()
		{
			return new IInformationSubTitle_SetValue
			{
				TidTitle = this.TidTitle,
				TidContent = this.TidContent,
				EdTidTitle = this.EdTidTitle,
				EdTidContent = this.EdTidContent
			};
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06005FA6 RID: 24486 RVA: 0x000E7521 File Offset: 0x000E5721
		// (set) Token: 0x06005FA7 RID: 24487 RVA: 0x000E754C File Offset: 0x000E574C
		public virtual string TidTitle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTitle;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidTitle;
			}
			set
			{
				this.GetOrCreatePoco().TidTitle = value;
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06005FA8 RID: 24488 RVA: 0x000E755A File Offset: 0x000E575A
		// (set) Token: 0x06005FA9 RID: 24489 RVA: 0x000E7585 File Offset: 0x000E5785
		public virtual string TidContent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidContent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidContent;
			}
			set
			{
				this.GetOrCreatePoco().TidContent = value;
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06005FAA RID: 24490 RVA: 0x000E7593 File Offset: 0x000E5793
		// (set) Token: 0x06005FAB RID: 24491 RVA: 0x000E75AA File Offset: 0x000E57AA
		[Nullable(2)]
		public virtual string EdTidTitle
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTitle;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidTitle = value;
			}
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x000E75B8 File Offset: 0x000E57B8
		// (set) Token: 0x06005FAD RID: 24493 RVA: 0x000E75CF File Offset: 0x000E57CF
		[Nullable(2)]
		public virtual string EdTidContent
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidContent;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidContent = value;
			}
		}

		// Token: 0x0400395F RID: 14687
		[Nullable(2)]
		protected IInformationSubTitle FbInstance;

		// Token: 0x04003960 RID: 14688
		[Nullable(2)]
		protected IInformationSubTitle_SetValue PocoInterface;
	}
}
