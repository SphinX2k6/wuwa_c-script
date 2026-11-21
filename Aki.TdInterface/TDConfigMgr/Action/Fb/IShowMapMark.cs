using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C45 RID: 11333
	public class IShowMapMark : ToggleMapMarkState
	{
		// Token: 0x0600F949 RID: 63817 RVA: 0x00243810 File Offset: 0x00241A10
		public static IShowMapMark Create(IShowMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D6D RID: 19821
		// (get) Token: 0x0600F94A RID: 63818 RVA: 0x0024382F File Offset: 0x00241A2F
		public override EMapMarkState Type
		{
			get
			{
				return (EMapMarkState)this.Instance.Type;
			}
		}

		// Token: 0x17004D6E RID: 19822
		// (get) Token: 0x0600F94B RID: 63819 RVA: 0x0024383C File Offset: 0x00241A3C
		public virtual int MarkId
		{
			get
			{
				return this.Instance.MarkId;
			}
		}

		// Token: 0x17004D6F RID: 19823
		// (get) Token: 0x0600F94C RID: 63820 RVA: 0x0024384C File Offset: 0x00241A4C
		public virtual bool? IsFocusOnFirstShow
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFocusOnFirstShow);
			}
		}

		// Token: 0x04008849 RID: 34889
		private IShowMapMark Instance;
	}
}
