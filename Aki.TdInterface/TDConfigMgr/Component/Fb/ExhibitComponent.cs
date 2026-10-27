using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DD8 RID: 3544
	[NullableContext(1)]
	[Nullable(0)]
	public class ExhibitComponent : IComponentBase
	{
		// Token: 0x06005066 RID: 20582 RVA: 0x000C69F4 File Offset: 0x000C4BF4
		public static ExhibitComponent Create(IExhibitComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExhibitComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06005067 RID: 20583 RVA: 0x000C6A14 File Offset: 0x000C4C14
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

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x000C6A4C File Offset: 0x000C4C4C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06005069 RID: 20585 RVA: 0x000C6A62 File Offset: 0x000C4C62
		public virtual IExhibitItemType ExhibitConfig
		{
			get
			{
				if (this._ExhibitConfigInited)
				{
					return this._ExhibitConfigCache;
				}
				this._ExhibitConfigInited = true;
				this._ExhibitConfigCache = ComponentReadHelper.ReadExhibitComponent_ExhibitConfig(this.Instance);
				return this._ExhibitConfigCache;
			}
		}

		// Token: 0x04002E27 RID: 11815
		private IExhibitComponent Instance;

		// Token: 0x04002E28 RID: 11816
		private IExhibitItemType _ExhibitConfigCache;

		// Token: 0x04002E29 RID: 11817
		private bool _ExhibitConfigInited;
	}
}
