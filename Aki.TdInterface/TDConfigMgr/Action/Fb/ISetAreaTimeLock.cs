using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024F8 RID: 9464
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetAreaTimeLock : ISetAreaTimeBase
	{
		// Token: 0x0600D34B RID: 54091 RVA: 0x001F5439 File Offset: 0x001F3639
		public static ISetAreaTimeLock Create(ISetAreaTimeLock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAreaTimeLock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x0600D34C RID: 54092 RVA: 0x001F5458 File Offset: 0x001F3658
		public override ESetAreaTime Type
		{
			get
			{
				return (ESetAreaTime)this.Instance.Type;
			}
		}

		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x0600D34D RID: 54093 RVA: 0x001F5468 File Offset: 0x001F3668
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

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x0600D34E RID: 54094 RVA: 0x001F54CC File Offset: 0x001F36CC
		public virtual IFixedTime LockTime
		{
			get
			{
				if (this._LockTimeInited)
				{
					return this._LockTimeCache;
				}
				this._LockTimeInited = true;
				this._LockTimeCache = IFixedTime.Create(this.Instance.LockTime);
				return this._LockTimeCache;
			}
		}

		// Token: 0x040073D6 RID: 29654
		private ISetAreaTimeLock Instance;

		// Token: 0x040073D7 RID: 29655
		private List<int> _AreaIdsCache;

		// Token: 0x040073D8 RID: 29656
		private bool _AreaIdsInited;

		// Token: 0x040073D9 RID: 29657
		[Nullable(2)]
		private IFixedTime _LockTimeCache;

		// Token: 0x040073DA RID: 29658
		private bool _LockTimeInited;
	}
}
