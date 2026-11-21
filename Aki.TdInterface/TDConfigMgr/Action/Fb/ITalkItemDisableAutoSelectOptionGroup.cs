using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D3 RID: 10195
	public class ITalkItemDisableAutoSelectOptionGroup
	{
		// Token: 0x0600E187 RID: 57735 RVA: 0x00212476 File Offset: 0x00210676
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

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x0600E188 RID: 57736 RVA: 0x00212495 File Offset: 0x00210695
		[Nullable(2)]
		public virtual string TextKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.TextKey;
			}
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x0600E189 RID: 57737 RVA: 0x002124A4 File Offset: 0x002106A4
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

		// Token: 0x04007A8B RID: 31371
		private ITalkItemDisableAutoSelectOptionGroup Instance;
	}
}
