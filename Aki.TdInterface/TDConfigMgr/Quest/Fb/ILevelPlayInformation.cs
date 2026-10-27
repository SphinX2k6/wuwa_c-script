using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012CD RID: 4813
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayInformation
	{
		// Token: 0x06006E1C RID: 28188 RVA: 0x0010A615 File Offset: 0x00108815
		public static ILevelPlayInformation Create(ILevelPlayInformation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayInformation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x06006E1D RID: 28189 RVA: 0x0010A634 File Offset: 0x00108834
		public virtual string TidMainTitle
		{
			get
			{
				return this.Instance.TidMainTitle;
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x06006E1E RID: 28190 RVA: 0x0010A644 File Offset: 0x00108844
		public virtual List<IInformationSubTitle> SubTitles
		{
			get
			{
				if (this._SubTitlesInited)
				{
					return this._SubTitlesCache;
				}
				this._SubTitlesInited = true;
				int subTitlesLength = this.Instance.SubTitlesLength;
				this._SubTitlesCache = new List<IInformationSubTitle>(subTitlesLength);
				for (int i = 0; i < subTitlesLength; i++)
				{
					this._SubTitlesCache.Add(IInformationSubTitle.Create(this.Instance.SubTitles(i)));
				}
				return this._SubTitlesCache;
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x06006E1F RID: 28191 RVA: 0x0010A6AD File Offset: 0x001088AD
		[Nullable(2)]
		public virtual string EdTidMainTitle
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04003F1B RID: 16155
		private ILevelPlayInformation Instance;

		// Token: 0x04003F1C RID: 16156
		private List<IInformationSubTitle> _SubTitlesCache;

		// Token: 0x04003F1D RID: 16157
		private bool _SubTitlesInited;
	}
}
