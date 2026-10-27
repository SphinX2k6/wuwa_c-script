using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E4E RID: 3662
	[NullableContext(1)]
	[Nullable(0)]
	public class TComponentData
	{
		// Token: 0x060052AE RID: 21166 RVA: 0x000CB76D File Offset: 0x000C996D
		public static TComponentData Create(TComponentData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TComponentData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x060052AF RID: 21167 RVA: 0x000CB78C File Offset: 0x000C998C
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x060052B0 RID: 21168 RVA: 0x000CB799 File Offset: 0x000C9999
		public virtual IComponentBase Value
		{
			get
			{
				if (this._ValueInited)
				{
					return this._ValueCache;
				}
				this._ValueInited = true;
				this._ValueCache = ComponentReadHelper.ReadTComponentData_Value(this.Instance);
				return this._ValueCache;
			}
		}

		// Token: 0x04002FAB RID: 12203
		private TComponentData Instance;

		// Token: 0x04002FAC RID: 12204
		private IComponentBase _ValueCache;

		// Token: 0x04002FAD RID: 12205
		private bool _ValueInited;
	}
}
