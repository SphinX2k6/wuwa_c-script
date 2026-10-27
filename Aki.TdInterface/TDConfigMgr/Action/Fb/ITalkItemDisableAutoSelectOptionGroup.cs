using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200252C RID: 9516
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemDisableAutoSelectOptionGroup
	{
		// Token: 0x0600D427 RID: 54311 RVA: 0x001F6A16 File Offset: 0x001F4C16
		[NullableContext(1)]
		public static ITalkItemDisableAutoSelectOptionGroup Create(ITalkItemDisableAutoSelectOptionGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemDisableAutoSelectOptionGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x0600D428 RID: 54312 RVA: 0x001F6A35 File Offset: 0x001F4C35
		public virtual string TextKey
		{
			get
			{
				return this.Instance.TextKey;
			}
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x0600D429 RID: 54313 RVA: 0x001F6A44 File Offset: 0x001F4C44
		public virtual int? IconId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.IconId);
			}
		}

		// Token: 0x04007436 RID: 29750
		private ITalkItemDisableAutoSelectOptionGroup Instance;
	}
}
