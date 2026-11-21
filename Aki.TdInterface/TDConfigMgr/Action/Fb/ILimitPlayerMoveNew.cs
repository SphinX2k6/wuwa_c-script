using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA1 RID: 10913
	public class ILimitPlayerMoveNew : ILimitPlayerOption
	{
		// Token: 0x0600F0AD RID: 61613 RVA: 0x0023415E File Offset: 0x0023235E
		public static ILimitPlayerMoveNew Create(ILimitPlayerMoveNew? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMoveNew
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x0600F0AE RID: 61614 RVA: 0x0023417D File Offset: 0x0023237D
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x0600F0AF RID: 61615 RVA: 0x0023418A File Offset: 0x0023238A
		public virtual bool Forward
		{
			get
			{
				return this.Instance.Forward;
			}
		}

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x0600F0B0 RID: 61616 RVA: 0x00234197 File Offset: 0x00232397
		public virtual bool Back
		{
			get
			{
				return this.Instance.Back;
			}
		}

		// Token: 0x1700481C RID: 18460
		// (get) Token: 0x0600F0B1 RID: 61617 RVA: 0x002341A4 File Offset: 0x002323A4
		public virtual bool Left
		{
			get
			{
				return this.Instance.Left;
			}
		}

		// Token: 0x1700481D RID: 18461
		// (get) Token: 0x0600F0B2 RID: 61618 RVA: 0x002341B1 File Offset: 0x002323B1
		public virtual bool Right
		{
			get
			{
				return this.Instance.Right;
			}
		}

		// Token: 0x04008457 RID: 33879
		private ILimitPlayerMoveNew Instance;
	}
}
