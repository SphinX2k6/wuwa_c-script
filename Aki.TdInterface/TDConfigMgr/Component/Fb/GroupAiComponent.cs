using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D5C RID: 3420
	[NullableContext(1)]
	[Nullable(0)]
	public class GroupAiComponent : IComponentBase
	{
		// Token: 0x06004DED RID: 19949 RVA: 0x000C19FD File Offset: 0x000BFBFD
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

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06004DEE RID: 19950 RVA: 0x000C1A1C File Offset: 0x000BFC1C
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

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06004DEF RID: 19951 RVA: 0x000C1A54 File Offset: 0x000BFC54
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x06004DF0 RID: 19952 RVA: 0x000C1A6C File Offset: 0x000BFC6C
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

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x06004DF1 RID: 19953 RVA: 0x000C1AD0 File Offset: 0x000BFCD0
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

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x06004DF2 RID: 19954 RVA: 0x000C1B00 File Offset: 0x000BFD00
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> SyncTags
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002CA9 RID: 11433
		private IGroupAiComponent Instance;

		// Token: 0x04002CAA RID: 11434
		private List<int> _EntitiesCache;

		// Token: 0x04002CAB RID: 11435
		private bool _EntitiesInited;

		// Token: 0x04002CAC RID: 11436
		private IGroupAiMode _OptionCache;

		// Token: 0x04002CAD RID: 11437
		private bool _OptionInited;

		// Token: 0x04002CAE RID: 11438
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _SyncTagsCache;

		// Token: 0x04002CAF RID: 11439
		private bool _SyncTagsInited;
	}
}
