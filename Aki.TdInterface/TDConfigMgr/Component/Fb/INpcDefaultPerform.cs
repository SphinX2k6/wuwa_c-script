using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BCF RID: 3023
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcDefaultPerform
	{
		// Token: 0x0600457B RID: 17787 RVA: 0x000AFEE5 File Offset: 0x000AE0E5
		[NullableContext(1)]
		public static INpcDefaultPerform Create(INpcDefaultPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcDefaultPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x000AFF04 File Offset: 0x000AE104
		public virtual List<int> BuffEffectIds
		{
			get
			{
				if (this._BuffEffectIdsInited)
				{
					return this._BuffEffectIdsCache;
				}
				this._BuffEffectIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int buffEffectIdsLength = this.Instance.BuffEffectIdsLength;
				this._BuffEffectIdsCache = new List<int>(buffEffectIdsLength);
				for (int i = 0; i < buffEffectIdsLength; i++)
				{
					this._BuffEffectIdsCache.Add(this.Instance.BuffEffectIds(i));
				}
				return this._BuffEffectIdsCache;
			}
		}

		// Token: 0x04002786 RID: 10118
		private INpcDefaultPerform Instance;

		// Token: 0x04002787 RID: 10119
		private List<int> _BuffEffectIdsCache;

		// Token: 0x04002788 RID: 10120
		private bool _BuffEffectIdsInited;
	}
}
