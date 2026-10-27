using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024F9 RID: 9465
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetAreaTimeUnLock : ISetAreaTimeBase
	{
		// Token: 0x0600D350 RID: 54096 RVA: 0x001F5508 File Offset: 0x001F3708
		public static ISetAreaTimeUnLock Create(ISetAreaTimeUnLock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAreaTimeUnLock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x0600D351 RID: 54097 RVA: 0x001F5527 File Offset: 0x001F3727
		public override ESetAreaTime Type
		{
			get
			{
				return (ESetAreaTime)this.Instance.Type;
			}
		}

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x0600D352 RID: 54098 RVA: 0x001F5534 File Offset: 0x001F3734
		public virtual List<int> AreaIds
		{
			get
			{
				if (this._AreaIdsInited)
				{
					return this._AreaIdsCache;
				}
				this._AreaIdsInited = true;
				int areaIdsLength = this.Instance.AreaIdsLength;
				this._AreaIdsCache = new List<int>(areaIdsLength);
				for (int i = 0; i < areaIdsLength; i++)
				{
					this._AreaIdsCache.Add(this.Instance.AreaIds(i));
				}
				return this._AreaIdsCache;
			}
		}

		// Token: 0x040073DB RID: 29659
		private ISetAreaTimeUnLock Instance;

		// Token: 0x040073DC RID: 29660
		private List<int> _AreaIdsCache;

		// Token: 0x040073DD RID: 29661
		private bool _AreaIdsInited;
	}
}
