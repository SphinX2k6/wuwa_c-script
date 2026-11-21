using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200111B RID: 4379
	public class ILevelPlayInformation
	{
		// Token: 0x060060A2 RID: 24738 RVA: 0x000E90FC File Offset: 0x000E72FC
		private ILevelPlayInformation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelPlayInformation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelPlayInformation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelPlayInformation_SetValue());
			}
			return result;
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x000E9134 File Offset: 0x000E7334
		public static ILevelPlayInformation Create([Nullable(2)] ILevelPlayInformation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayInformation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x000E9147 File Offset: 0x000E7347
		public static ILevelPlayInformation CreateFromSetValue([Nullable(2)] ILevelPlayInformation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelPlayInformation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x000E915A File Offset: 0x000E735A
		public ILevelPlayInformation_SetValue ToSetValue()
		{
			return new ILevelPlayInformation_SetValue
			{
				TidMainTitle = this.TidMainTitle,
				SubTitles = this.SubTitles,
				EdTidMainTitle = this.EdTidMainTitle
			};
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x060060A6 RID: 24742 RVA: 0x000E9185 File Offset: 0x000E7385
		// (set) Token: 0x060060A7 RID: 24743 RVA: 0x000E91B0 File Offset: 0x000E73B0
		public virtual string TidMainTitle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidMainTitle;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidMainTitle;
			}
			set
			{
				this.GetOrCreatePoco().TidMainTitle = value;
			}
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x060060A8 RID: 24744 RVA: 0x000E91C0 File Offset: 0x000E73C0
		// (set) Token: 0x060060A9 RID: 24745 RVA: 0x000E9253 File Offset: 0x000E7453
		public virtual List<IInformationSubTitle> SubTitles
		{
			get
			{
				if (this._SubTitlesInited)
				{
					return this._SubTitlesCache;
				}
				this._SubTitlesInited = true;
				if (this.FbInstance != null)
				{
					List<IInformationSubTitle> subTitles = this.FbInstance.SubTitles;
					if (subTitles != null)
					{
						this._SubTitlesCache = new List<IInformationSubTitle>(subTitles.Count);
						for (int i = 0; i < subTitles.Count; i++)
						{
							this._SubTitlesCache.Add(IInformationSubTitle.Create(subTitles[i]));
						}
					}
				}
				else
				{
					ILevelPlayInformation_SetValue pocoInterface = this.PocoInterface;
					this._SubTitlesCache = ((pocoInterface != null) ? pocoInterface.SubTitles : null);
				}
				return this._SubTitlesCache;
			}
			set
			{
				this.GetOrCreatePoco().SubTitles = value;
				this._SubTitlesInited = false;
			}
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x060060AA RID: 24746 RVA: 0x000E9268 File Offset: 0x000E7468
		// (set) Token: 0x060060AB RID: 24747 RVA: 0x000E927F File Offset: 0x000E747F
		[Nullable(2)]
		public virtual string EdTidMainTitle
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidMainTitle;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidMainTitle = value;
			}
		}

		// Token: 0x040039D7 RID: 14807
		[Nullable(2)]
		protected ILevelPlayInformation FbInstance;

		// Token: 0x040039D8 RID: 14808
		[Nullable(2)]
		protected ILevelPlayInformation_SetValue PocoInterface;

		// Token: 0x040039D9 RID: 14809
		private List<IInformationSubTitle> _SubTitlesCache;

		// Token: 0x040039DA RID: 14810
		private bool _SubTitlesInited;
	}
}
