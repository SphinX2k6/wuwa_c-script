using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D6C RID: 3436
	public class IDirectionFill : IFillType
	{
		// Token: 0x06004E20 RID: 20000 RVA: 0x000C2BCE File Offset: 0x000C0DCE
		public static IDirectionFill Create(IDirectionFill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDirectionFill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06004E21 RID: 20001 RVA: 0x000C2BED File Offset: 0x000C0DED
		public override EFillType Type
		{
			get
			{
				return (EFillType)this.Instance.Type;
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x000C2BFA File Offset: 0x000C0DFA
		public virtual bool W
		{
			get
			{
				return this.Instance.W;
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06004E23 RID: 20003 RVA: 0x000C2C07 File Offset: 0x000C0E07
		public virtual bool S
		{
			get
			{
				return this.Instance.S;
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x000C2C14 File Offset: 0x000C0E14
		public virtual bool A
		{
			get
			{
				return this.Instance.A;
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06004E25 RID: 20005 RVA: 0x000C2C21 File Offset: 0x000C0E21
		public virtual bool D
		{
			get
			{
				return this.Instance.D;
			}
		}

		// Token: 0x04002C5F RID: 11359
		private IDirectionFill Instance;
	}
}
