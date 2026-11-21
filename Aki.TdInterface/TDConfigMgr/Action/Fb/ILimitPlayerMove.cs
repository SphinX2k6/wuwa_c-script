using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9D RID: 10909
	public class ILimitPlayerMove : ILimitPlayerOption
	{
		// Token: 0x0600F0A0 RID: 61600 RVA: 0x00234058 File Offset: 0x00232258
		public static ILimitPlayerMove Create(ILimitPlayerMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004814 RID: 18452
		// (get) Token: 0x0600F0A1 RID: 61601 RVA: 0x00234077 File Offset: 0x00232277
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x17004815 RID: 18453
		// (get) Token: 0x0600F0A2 RID: 61602 RVA: 0x00234084 File Offset: 0x00232284
		public virtual bool? IsOnlyForward
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOnlyForward);
			}
		}

		// Token: 0x04008453 RID: 33875
		private ILimitPlayerMove Instance;
	}
}
