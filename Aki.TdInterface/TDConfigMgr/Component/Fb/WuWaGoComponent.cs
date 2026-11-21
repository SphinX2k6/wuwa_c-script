using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F10 RID: 3856
	public class WuWaGoComponent : IComponentBase
	{
		// Token: 0x060056AA RID: 22186 RVA: 0x000D4918 File Offset: 0x000D2B18
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

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x060056AB RID: 22187 RVA: 0x000D4938 File Offset: 0x000D2B38
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

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x060056AC RID: 22188 RVA: 0x000D4970 File Offset: 0x000D2B70
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x060056AD RID: 22189 RVA: 0x000D4986 File Offset: 0x000D2B86
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

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x060056AE RID: 22190 RVA: 0x000D49B8 File Offset: 0x000D2BB8
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

		// Token: 0x040031BD RID: 12733
		private IWuWaGoComponent Instance;

		// Token: 0x040031BE RID: 12734
		private IWuWaGoEntityBase _WuWaGoEntityCache;

		// Token: 0x040031BF RID: 12735
		private bool _WuWaGoEntityInited;

		// Token: 0x040031C0 RID: 12736
		[Nullable(2)]
		private List<int> _OpenAddClientTagsCache;

		// Token: 0x040031C1 RID: 12737
		private bool _OpenAddClientTagsInited;
	}
}
