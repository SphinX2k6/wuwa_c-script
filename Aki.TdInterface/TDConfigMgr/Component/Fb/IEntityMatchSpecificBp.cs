using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D3A RID: 3386
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityMatchSpecificBp : IEntityMatchConfig
	{
		// Token: 0x06004D3A RID: 19770 RVA: 0x000C02B9 File Offset: 0x000BE4B9
		public static IEntityMatchSpecificBp Create(IEntityMatchSpecificBp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchSpecificBp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06004D3B RID: 19771 RVA: 0x000C02D8 File Offset: 0x000BE4D8
		public override EEntityMatchType Type
		{
			get
			{
				return (EEntityMatchType)this.Instance.Type;
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06004D3C RID: 19772 RVA: 0x000C02E8 File Offset: 0x000BE4E8
		public virtual List<string> SpecificBpList
		{
			get
			{
				if (this._SpecificBpListInited)
				{
					return this._SpecificBpListCache;
				}
				this._SpecificBpListInited = true;
				int specificBpListLength = this.Instance.SpecificBpListLength;
				this._SpecificBpListCache = new List<string>(specificBpListLength);
				for (int i = 0; i < specificBpListLength; i++)
				{
					this._SpecificBpListCache.Add(this.Instance.SpecificBpList(i));
				}
				return this._SpecificBpListCache;
			}
		}

		// Token: 0x04002C45 RID: 11333
		private IEntityMatchSpecificBp Instance;

		// Token: 0x04002C46 RID: 11334
		private List<string> _SpecificBpListCache;

		// Token: 0x04002C47 RID: 11335
		private bool _SpecificBpListInited;
	}
}
