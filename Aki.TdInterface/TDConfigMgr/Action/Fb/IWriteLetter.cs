using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B41 RID: 11073
	public class IWriteLetter : IUiGame
	{
		// Token: 0x0600F37A RID: 62330 RVA: 0x002386F2 File Offset: 0x002368F2
		public static IWriteLetter Create(IWriteLetter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWriteLetter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A6 RID: 18854
		// (get) Token: 0x0600F37B RID: 62331 RVA: 0x00238711 File Offset: 0x00236911
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049A7 RID: 18855
		// (get) Token: 0x0600F37C RID: 62332 RVA: 0x0023871E File Offset: 0x0023691E
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x0400858D RID: 34189
		private IWriteLetter Instance;
	}
}
