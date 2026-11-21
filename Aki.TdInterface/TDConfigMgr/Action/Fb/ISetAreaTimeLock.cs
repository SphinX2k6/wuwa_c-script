using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279E RID: 10142
	public class ISetAreaTimeLock : ISetAreaTimeBase
	{
		// Token: 0x0600E0A7 RID: 57511 RVA: 0x00210E31 File Offset: 0x0020F031
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

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x0600E0A8 RID: 57512 RVA: 0x00210E50 File Offset: 0x0020F050
		public override ESetAreaTime Type
		{
			get
			{
				return (ESetAreaTime)this.Instance.Type;
			}
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x0600E0A9 RID: 57513 RVA: 0x00210E60 File Offset: 0x0020F060
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

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x0600E0AA RID: 57514 RVA: 0x00210EC4 File Offset: 0x0020F0C4
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

		// Token: 0x04007A28 RID: 31272
		private ISetAreaTimeLock Instance;

		// Token: 0x04007A29 RID: 31273
		private List<int> _AreaIdsCache;

		// Token: 0x04007A2A RID: 31274
		private bool _AreaIdsInited;

		// Token: 0x04007A2B RID: 31275
		[Nullable(2)]
		private IFixedTime _LockTimeCache;

		// Token: 0x04007A2C RID: 31276
		private bool _LockTimeInited;
	}
}
