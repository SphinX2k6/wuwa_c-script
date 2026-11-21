using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B2C RID: 11052
	public class ISignalBreakGameplay : IUiGame
	{
		// Token: 0x0600F320 RID: 62240 RVA: 0x00237EAF File Offset: 0x002360AF
		public static ISignalBreakGameplay Create(ISignalBreakGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISignalBreakGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004976 RID: 18806
		// (get) Token: 0x0600F321 RID: 62241 RVA: 0x00237ECE File Offset: 0x002360CE
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004977 RID: 18807
		// (get) Token: 0x0600F322 RID: 62242 RVA: 0x00237EDB File Offset: 0x002360DB
		public virtual string SignalBreakId
		{
			get
			{
				return this.Instance.SignalBreakId;
			}
		}

		// Token: 0x0400856A RID: 34154
		private ISignalBreakGameplay Instance;
	}
}
