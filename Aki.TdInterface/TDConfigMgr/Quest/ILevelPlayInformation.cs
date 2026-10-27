using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FEF RID: 4079
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayInformation
	{
		// Token: 0x06005AC2 RID: 23234 RVA: 0x000DC4BC File Offset: 0x000DA6BC
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

		// Token: 0x06005AC3 RID: 23235 RVA: 0x000DC4F4 File Offset: 0x000DA6F4
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

		// Token: 0x06005AC4 RID: 23236 RVA: 0x000DC507 File Offset: 0x000DA707
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

		// Token: 0x06005AC5 RID: 23237 RVA: 0x000DC51A File Offset: 0x000DA71A
		public ILevelPlayInformation_SetValue ToSetValue()
		{
			return new ILevelPlayInformation_SetValue
			{
				TidMainTitle = this.TidMainTitle,
				SubTitles = this.SubTitles,
				EdTidMainTitle = this.EdTidMainTitle
			};
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06005AC6 RID: 23238 RVA: 0x000DC545 File Offset: 0x000DA745
		// (set) Token: 0x06005AC7 RID: 23239 RVA: 0x000DC570 File Offset: 0x000DA770
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

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x06005AC8 RID: 23240 RVA: 0x000DC580 File Offset: 0x000DA780
		// (set) Token: 0x06005AC9 RID: 23241 RVA: 0x000DC613 File Offset: 0x000DA813
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

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x06005ACA RID: 23242 RVA: 0x000DC628 File Offset: 0x000DA828
		// (set) Token: 0x06005ACB RID: 23243 RVA: 0x000DC63F File Offset: 0x000DA83F
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

		// Token: 0x0400369F RID: 13983
		[Nullable(2)]
		protected ILevelPlayInformation FbInstance;

		// Token: 0x040036A0 RID: 13984
		[Nullable(2)]
		protected ILevelPlayInformation_SetValue PocoInterface;

		// Token: 0x040036A1 RID: 13985
		private List<IInformationSubTitle> _SubTitlesCache;

		// Token: 0x040036A2 RID: 13986
		private bool _SubTitlesInited;
	}
}
