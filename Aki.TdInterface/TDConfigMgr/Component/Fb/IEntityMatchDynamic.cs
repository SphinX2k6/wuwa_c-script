using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E33 RID: 3635
	public class IEntityMatchDynamic : IEntityMatchConfig
	{
		// Token: 0x06005252 RID: 21074 RVA: 0x000CB95E File Offset: 0x000C9B5E
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

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06005253 RID: 21075 RVA: 0x000CB97D File Offset: 0x000C9B7D
		public override EEntityMatchType Type
		{
			get
			{
				return (EEntityMatchType)this.Instance.Type;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x06005254 RID: 21076 RVA: 0x000CB98C File Offset: 0x000C9B8C
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

		// Token: 0x04002F02 RID: 12034
		private IEntityMatchDynamic Instance;

		// Token: 0x04002F03 RID: 12035
		private List<IDynamicEntityMatch> _MatchEntityCache;

		// Token: 0x04002F04 RID: 12036
		private bool _MatchEntityInited;
	}
}
