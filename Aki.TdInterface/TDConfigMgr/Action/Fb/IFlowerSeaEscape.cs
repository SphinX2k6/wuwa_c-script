using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B38 RID: 11064
	public class IFlowerSeaEscape : IUiGame
	{
		// Token: 0x0600F354 RID: 62292 RVA: 0x0023843A File Offset: 0x0023663A
		public static IFlowerSeaEscape Create(IFlowerSeaEscape? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowerSeaEscape
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004992 RID: 18834
		// (get) Token: 0x0600F355 RID: 62293 RVA: 0x00238459 File Offset: 0x00236659
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004993 RID: 18835
		// (get) Token: 0x0600F356 RID: 62294 RVA: 0x00238466 File Offset: 0x00236666
		public virtual int EndAreaEntityId
		{
			get
			{
				return this.Instance.EndAreaEntityId;
			}
		}

		// Token: 0x17004994 RID: 18836
		// (get) Token: 0x0600F357 RID: 62295 RVA: 0x00238473 File Offset: 0x00236673
		public virtual string ConfigDa
		{
			get
			{
				return this.Instance.ConfigDa;
			}
		}

		// Token: 0x17004995 RID: 18837
		// (get) Token: 0x0600F358 RID: 62296 RVA: 0x00238480 File Offset: 0x00236680
		public virtual string SpreadingState
		{
			get
			{
				return this.Instance.SpreadingState;
			}
		}

		// Token: 0x17004996 RID: 18838
		// (get) Token: 0x0600F359 RID: 62297 RVA: 0x0023848D File Offset: 0x0023668D
		public virtual string PausedState
		{
			get
			{
				return this.Instance.PausedState;
			}
		}

		// Token: 0x17004997 RID: 18839
		// (get) Token: 0x0600F35A RID: 62298 RVA: 0x0023849A File Offset: 0x0023669A
		public virtual string ResetState
		{
			get
			{
				return this.Instance.ResetState;
			}
		}

		// Token: 0x04008584 RID: 34180
		private IFlowerSeaEscape Instance;
	}
}
