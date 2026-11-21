using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E56 RID: 3670
	public class GroupAiComponent : IComponentBase
	{
		// Token: 0x06005309 RID: 21257 RVA: 0x000CD141 File Offset: 0x000CB341
		public static GroupAiComponent Create(IGroupAiComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GroupAiComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x0600530A RID: 21258 RVA: 0x000CD160 File Offset: 0x000CB360
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x0600530B RID: 21259 RVA: 0x000CD198 File Offset: 0x000CB398
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x0600530C RID: 21260 RVA: 0x000CD1B0 File Offset: 0x000CB3B0
		public virtual List<int> Entities
		{
			get
			{
				if (this._EntitiesInited)
				{
					return this._EntitiesCache;
				}
				this._EntitiesInited = true;
				int entitiesLength = this.Instance.EntitiesLength;
				this._EntitiesCache = new List<int>(entitiesLength);
				for (int i = 0; i < entitiesLength; i++)
				{
					this._EntitiesCache.Add(this.Instance.Entities(i));
				}
				return this._EntitiesCache;
			}
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x0600530D RID: 21261 RVA: 0x000CD214 File Offset: 0x000CB414
		public virtual IGroupAiMode Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = ComponentReadHelper.ReadGroupAiComponent_Option(this.Instance);
				return this._OptionCache;
			}
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x0600530E RID: 21262 RVA: 0x000CD244 File Offset: 0x000CB444
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> SyncTags
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._SyncTagsInited)
				{
					return this._SyncTagsCache;
				}
				this._SyncTagsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int syncTagsLength = this.Instance.SyncTagsLength;
				this._SyncTagsCache = new List<string>(syncTagsLength);
				for (int i = 0; i < syncTagsLength; i++)
				{
					this._SyncTagsCache.Add(this.Instance.SyncTags(i));
				}
				return this._SyncTagsCache;
			}
		}

		// Token: 0x04002F69 RID: 12137
		private IGroupAiComponent Instance;

		// Token: 0x04002F6A RID: 12138
		private List<int> _EntitiesCache;

		// Token: 0x04002F6B RID: 12139
		private bool _EntitiesInited;

		// Token: 0x04002F6C RID: 12140
		private IGroupAiMode _OptionCache;

		// Token: 0x04002F6D RID: 12141
		private bool _OptionInited;

		// Token: 0x04002F6E RID: 12142
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _SyncTagsCache;

		// Token: 0x04002F6F RID: 12143
		private bool _SyncTagsInited;
	}
}
