using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002572 RID: 9586
	public class IVisualNovelRoleConfig
	{
		// Token: 0x0600D71D RID: 55069 RVA: 0x00200BF0 File Offset: 0x001FEDF0
		[NullableContext(1)]
		public static IVisualNovelRoleConfig Create(IVisualNovelRoleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelRoleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x0600D71E RID: 55070 RVA: 0x00200C10 File Offset: 0x001FEE10
		public virtual int? Expression
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Expression);
			}
		}

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x0600D71F RID: 55071 RVA: 0x00200C48 File Offset: 0x001FEE48
		public virtual EAvgVisualEffect? VisualEffect
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EAvgVisualEffect?((EAvgVisualEffect)this.Instance.VisualEffect);
			}
		}

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x0600D720 RID: 55072 RVA: 0x00200C80 File Offset: 0x001FEE80
		public virtual bool? HideAvatar
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HideAvatar);
			}
		}

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x0600D721 RID: 55073 RVA: 0x00200CB8 File Offset: 0x001FEEB8
		public virtual bool? HidePortrait
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HidePortrait);
			}
		}

		// Token: 0x04007714 RID: 30484
		private IVisualNovelRoleConfig Instance;
	}
}
