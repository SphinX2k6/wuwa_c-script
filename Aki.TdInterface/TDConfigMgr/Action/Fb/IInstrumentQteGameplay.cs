using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B44 RID: 11076
	public class IInstrumentQteGameplay : IUiGame
	{
		// Token: 0x0600F389 RID: 62345 RVA: 0x002388B6 File Offset: 0x00236AB6
		public static IInstrumentQteGameplay Create(IInstrumentQteGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentQteGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049AF RID: 18863
		// (get) Token: 0x0600F38A RID: 62346 RVA: 0x002388D5 File Offset: 0x00236AD5
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049B0 RID: 18864
		// (get) Token: 0x0600F38B RID: 62347 RVA: 0x002388E2 File Offset: 0x00236AE2
		public virtual EInstrumentType InstrumentType
		{
			get
			{
				return (EInstrumentType)this.Instance.InstrumentType;
			}
		}

		// Token: 0x170049B1 RID: 18865
		// (get) Token: 0x0600F38C RID: 62348 RVA: 0x002388EF File Offset: 0x00236AEF
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008594 RID: 34196
		private IInstrumentQteGameplay Instance;
	}
}
