using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200274E RID: 10062
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlashAndTowerTip : ICommonTipType
	{
		// Token: 0x0600E031 RID: 57393 RVA: 0x00212CB1 File Offset: 0x00210EB1
		public static ISlashAndTowerTip Create(ISlashAndTowerTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlashAndTowerTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004357 RID: 17239
		// (get) Token: 0x0600E032 RID: 57394 RVA: 0x00212CD0 File Offset: 0x00210ED0
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004358 RID: 17240
		// (get) Token: 0x0600E033 RID: 57395 RVA: 0x00212CDD File Offset: 0x00210EDD
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x04007C4C RID: 31820
		private ISlashAndTowerTip Instance;
	}
}
