using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DEC RID: 3564
	public class ITimeStopTarget
	{
		// Token: 0x060050D2 RID: 20690 RVA: 0x000C8732 File Offset: 0x000C6932
		public static ITimeStopTarget Create(ITimeStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x060050D3 RID: 20691 RVA: 0x000C8754 File Offset: 0x000C6954
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x060050D4 RID: 20692 RVA: 0x000C87B8 File Offset: 0x000C69B8
		[Nullable(2)]
		public virtual IDynamicEntityMatch EntityMatch
		{
			[NullableContext(2)]
			get
			{
				if (this._EntityMatchInited)
				{
					return this._EntityMatchCache;
				}
				this._EntityMatchInited = true;
				this._EntityMatchCache = IDynamicEntityMatch.Create(this.Instance.EntityMatch);
				return this._EntityMatchCache;
			}
		}

		// Token: 0x04002E0B RID: 11787
		private ITimeStopTarget Instance;

		// Token: 0x04002E0C RID: 11788
		private List<int> _EntityIdsCache;

		// Token: 0x04002E0D RID: 11789
		private bool _EntityIdsInited;

		// Token: 0x04002E0E RID: 11790
		[Nullable(2)]
		private IDynamicEntityMatch _EntityMatchCache;

		// Token: 0x04002E0F RID: 11791
		private bool _EntityMatchInited;
	}
}
