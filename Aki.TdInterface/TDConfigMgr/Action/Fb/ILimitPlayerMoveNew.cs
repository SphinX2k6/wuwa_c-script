using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CE RID: 10190
	public class ILimitPlayerMoveNew : ILimitPlayerOption
	{
		// Token: 0x0600E28B RID: 57995 RVA: 0x0021738A File Offset: 0x0021558A
		[NullableContext(1)]
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

		// Token: 0x170044B1 RID: 17585
		// (get) Token: 0x0600E28C RID: 57996 RVA: 0x002173A9 File Offset: 0x002155A9
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x170044B2 RID: 17586
		// (get) Token: 0x0600E28D RID: 57997 RVA: 0x002173B6 File Offset: 0x002155B6
		public virtual bool Forward
		{
			get
			{
				return this.Instance.Forward;
			}
		}

		// Token: 0x170044B3 RID: 17587
		// (get) Token: 0x0600E28E RID: 57998 RVA: 0x002173C3 File Offset: 0x002155C3
		public virtual bool Back
		{
			get
			{
				return this.Instance.Back;
			}
		}

		// Token: 0x170044B4 RID: 17588
		// (get) Token: 0x0600E28F RID: 57999 RVA: 0x002173D0 File Offset: 0x002155D0
		public virtual bool Left
		{
			get
			{
				return this.Instance.Left;
			}
		}

		// Token: 0x170044B5 RID: 17589
		// (get) Token: 0x0600E290 RID: 58000 RVA: 0x002173DD File Offset: 0x002155DD
		public virtual bool Right
		{
			get
			{
				return this.Instance.Right;
			}
		}

		// Token: 0x04007DA0 RID: 32160
		private ILimitPlayerMoveNew Instance;
	}
}
