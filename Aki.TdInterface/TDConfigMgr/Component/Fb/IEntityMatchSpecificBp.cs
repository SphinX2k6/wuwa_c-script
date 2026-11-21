using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E34 RID: 3636
	public class IEntityMatchSpecificBp : IEntityMatchConfig
	{
		// Token: 0x06005256 RID: 21078 RVA: 0x000CB9FD File Offset: 0x000C9BFD
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

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06005257 RID: 21079 RVA: 0x000CBA1C File Offset: 0x000C9C1C
		public override EEntityMatchType Type
		{
			get
			{
				return (EEntityMatchType)this.Instance.Type;
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06005258 RID: 21080 RVA: 0x000CBA2C File Offset: 0x000C9C2C
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

		// Token: 0x04002F05 RID: 12037
		private IEntityMatchSpecificBp Instance;

		// Token: 0x04002F06 RID: 12038
		private List<string> _SpecificBpListCache;

		// Token: 0x04002F07 RID: 12039
		private bool _SpecificBpListInited;
	}
}
