using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D5D RID: 3421
	[NullableContext(1)]
	[Nullable(0)]
	public class IInhalationMatching
	{
		// Token: 0x06004DF4 RID: 19956 RVA: 0x000C1B7D File Offset: 0x000BFD7D
		public static IInhalationMatching Create(IInhalationMatching? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhalationMatching
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06004DF5 RID: 19957 RVA: 0x000C1B9C File Offset: 0x000BFD9C
		public virtual int InhalationStrength
		{
			get
			{
				return this.Instance.InhalationStrength;
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x000C1BA9 File Offset: 0x000BFDA9
		public virtual ICategoryMatchingCondition EntityMatch
		{
			get
			{
				if (this._EntityMatchInited)
				{
					return this._EntityMatchCache;
				}
				this._EntityMatchInited = true;
				this._EntityMatchCache = ICategoryMatchingCondition.Create(this.Instance.EntityMatch);
				return this._EntityMatchCache;
			}
		}

		// Token: 0x04002CB0 RID: 11440
		private IInhalationMatching Instance;

		// Token: 0x04002CB1 RID: 11441
		[Nullable(2)]
		private ICategoryMatchingCondition _EntityMatchCache;

		// Token: 0x04002CB2 RID: 11442
		private bool _EntityMatchInited;
	}
}
