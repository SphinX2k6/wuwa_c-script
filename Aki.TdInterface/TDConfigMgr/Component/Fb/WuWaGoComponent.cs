using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E14 RID: 3604
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoComponent : IComponentBase
	{
		// Token: 0x06005183 RID: 20867 RVA: 0x000C9050 File Offset: 0x000C7250
		public static WuWaGoComponent Create(IWuWaGoComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WuWaGoComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x000C9070 File Offset: 0x000C7270
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

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06005185 RID: 20869 RVA: 0x000C90A8 File Offset: 0x000C72A8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06005186 RID: 20870 RVA: 0x000C90BE File Offset: 0x000C72BE
		public virtual IWuWaGoEntityBase WuWaGoEntity
		{
			get
			{
				if (this._WuWaGoEntityInited)
				{
					return this._WuWaGoEntityCache;
				}
				this._WuWaGoEntityInited = true;
				this._WuWaGoEntityCache = ComponentReadHelper.ReadWuWaGoComponent_WuWaGoEntity(this.Instance);
				return this._WuWaGoEntityCache;
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06005187 RID: 20871 RVA: 0x000C90F0 File Offset: 0x000C72F0
		[Nullable(2)]
		public virtual List<int> OpenAddClientTags
		{
			[NullableContext(2)]
			get
			{
				if (this._OpenAddClientTagsInited)
				{
					return this._OpenAddClientTagsCache;
				}
				this._OpenAddClientTagsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int openAddClientTagsLength = this.Instance.OpenAddClientTagsLength;
				this._OpenAddClientTagsCache = new List<int>(openAddClientTagsLength);
				for (int i = 0; i < openAddClientTagsLength; i++)
				{
					this._OpenAddClientTagsCache.Add(this.Instance.OpenAddClientTags(i));
				}
				return this._OpenAddClientTagsCache;
			}
		}

		// Token: 0x04002EF5 RID: 12021
		private IWuWaGoComponent Instance;

		// Token: 0x04002EF6 RID: 12022
		private IWuWaGoEntityBase _WuWaGoEntityCache;

		// Token: 0x04002EF7 RID: 12023
		private bool _WuWaGoEntityInited;

		// Token: 0x04002EF8 RID: 12024
		[Nullable(2)]
		private List<int> _OpenAddClientTagsCache;

		// Token: 0x04002EF9 RID: 12025
		private bool _OpenAddClientTagsInited;
	}
}
