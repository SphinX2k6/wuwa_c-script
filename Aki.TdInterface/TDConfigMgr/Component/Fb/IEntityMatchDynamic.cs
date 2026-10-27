using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D39 RID: 3385
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityMatchDynamic : IEntityMatchConfig
	{
		// Token: 0x06004D36 RID: 19766 RVA: 0x000C021A File Offset: 0x000BE41A
		public static IEntityMatchDynamic Create(IEntityMatchDynamic? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchDynamic
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06004D37 RID: 19767 RVA: 0x000C0239 File Offset: 0x000BE439
		public override EEntityMatchType Type
		{
			get
			{
				return (EEntityMatchType)this.Instance.Type;
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06004D38 RID: 19768 RVA: 0x000C0248 File Offset: 0x000BE448
		public virtual List<IDynamicEntityMatch> MatchEntity
		{
			get
			{
				if (this._MatchEntityInited)
				{
					return this._MatchEntityCache;
				}
				this._MatchEntityInited = true;
				int matchEntityLength = this.Instance.MatchEntityLength;
				this._MatchEntityCache = new List<IDynamicEntityMatch>(matchEntityLength);
				for (int i = 0; i < matchEntityLength; i++)
				{
					this._MatchEntityCache.Add(IDynamicEntityMatch.Create(this.Instance.MatchEntity(i)));
				}
				return this._MatchEntityCache;
			}
		}

		// Token: 0x04002C42 RID: 11330
		private IEntityMatchDynamic Instance;

		// Token: 0x04002C43 RID: 11331
		private List<IDynamicEntityMatch> _MatchEntityCache;

		// Token: 0x04002C44 RID: 11332
		private bool _MatchEntityInited;
	}
}
