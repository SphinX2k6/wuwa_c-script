using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FBB RID: 4027
	[NullableContext(1)]
	[Nullable(0)]
	public class IInformationSubTitle
	{
		// Token: 0x060059C4 RID: 22980 RVA: 0x000DA900 File Offset: 0x000D8B00
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

		// Token: 0x060059C5 RID: 22981 RVA: 0x000DA938 File Offset: 0x000D8B38
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

		// Token: 0x060059C6 RID: 22982 RVA: 0x000DA94B File Offset: 0x000D8B4B
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

		// Token: 0x060059C7 RID: 22983 RVA: 0x000DA95E File Offset: 0x000D8B5E
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

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x060059C8 RID: 22984 RVA: 0x000DA995 File Offset: 0x000D8B95
		// (set) Token: 0x060059C9 RID: 22985 RVA: 0x000DA9C0 File Offset: 0x000D8BC0
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

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x060059CA RID: 22986 RVA: 0x000DA9CE File Offset: 0x000D8BCE
		// (set) Token: 0x060059CB RID: 22987 RVA: 0x000DA9F9 File Offset: 0x000D8BF9
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

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x060059CC RID: 22988 RVA: 0x000DAA07 File Offset: 0x000D8C07
		// (set) Token: 0x060059CD RID: 22989 RVA: 0x000DAA1E File Offset: 0x000D8C1E
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

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x060059CE RID: 22990 RVA: 0x000DAA2C File Offset: 0x000D8C2C
		// (set) Token: 0x060059CF RID: 22991 RVA: 0x000DAA43 File Offset: 0x000D8C43
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

		// Token: 0x0400362A RID: 13866
		[Nullable(2)]
		protected IInformationSubTitle FbInstance;

		// Token: 0x0400362B RID: 13867
		[Nullable(2)]
		protected IInformationSubTitle_SetValue PocoInterface;
	}
}
