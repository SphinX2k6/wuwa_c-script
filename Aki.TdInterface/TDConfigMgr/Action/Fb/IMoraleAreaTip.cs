using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A20 RID: 10784
	public class IMoraleAreaTip : ICommonTipType
	{
		// Token: 0x0600EE4B RID: 61003 RVA: 0x0022F9B2 File Offset: 0x0022DBB2
		public static IMoraleAreaTip Create(IMoraleAreaTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoraleAreaTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046B9 RID: 18105
		// (get) Token: 0x0600EE4C RID: 61004 RVA: 0x0022F9D1 File Offset: 0x0022DBD1
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046BA RID: 18106
		// (get) Token: 0x0600EE4D RID: 61005 RVA: 0x0022F9DE File Offset: 0x0022DBDE
		public virtual string TidAreaNameText
		{
			get
			{
				return this.Instance.TidAreaNameText;
			}
		}

		// Token: 0x170046BB RID: 18107
		// (get) Token: 0x0600EE4E RID: 61006 RVA: 0x0022F9EB File Offset: 0x0022DBEB
		public virtual string TidRecommendText
		{
			get
			{
				return this.Instance.TidRecommendText;
			}
		}

		// Token: 0x170046BC RID: 18108
		// (get) Token: 0x0600EE4F RID: 61007 RVA: 0x0022F9F8 File Offset: 0x0022DBF8
		public virtual EMoraleAreaType AreaType
		{
			get
			{
				return (EMoraleAreaType)this.Instance.AreaType;
			}
		}

		// Token: 0x170046BD RID: 18109
		// (get) Token: 0x0600EE50 RID: 61008 RVA: 0x0022FA08 File Offset: 0x0022DC08
		public virtual EMoraleUiType? UiType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EMoraleUiType?((EMoraleUiType)this.Instance.UiType);
			}
		}

		// Token: 0x170046BE RID: 18110
		// (get) Token: 0x0600EE51 RID: 61009 RVA: 0x0022FA3E File Offset: 0x0022DC3E
		[Nullable(2)]
		public virtual string EdTidAreaNameText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170046BF RID: 18111
		// (get) Token: 0x0600EE52 RID: 61010 RVA: 0x0022FA41 File Offset: 0x0022DC41
		[Nullable(2)]
		public virtual string EdTidRecommendText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04008300 RID: 33536
		private IMoraleAreaTip Instance;
	}
}
