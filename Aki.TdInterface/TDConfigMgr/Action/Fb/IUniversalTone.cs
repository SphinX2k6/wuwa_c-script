using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285C RID: 10332
	public class IUniversalTone
	{
		// Token: 0x0600E674 RID: 58996 RVA: 0x00221D8D File Offset: 0x0021FF8D
		public static IUniversalTone Create(IUniversalTone? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUniversalTone
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700426A RID: 17002
		// (get) Token: 0x0600E675 RID: 58997 RVA: 0x00221DAC File Offset: 0x0021FFAC
		public virtual int UniversalToneId
		{
			get
			{
				return this.Instance.UniversalToneId;
			}
		}

		// Token: 0x1700426B RID: 17003
		// (get) Token: 0x0600E676 RID: 58998 RVA: 0x00221DBC File Offset: 0x0021FFBC
		public virtual int? TimberId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TimberId);
			}
		}

		// Token: 0x04007EF2 RID: 32498
		private IUniversalTone Instance;
	}
}
