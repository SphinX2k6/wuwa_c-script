using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF9 RID: 11001
	public class IUniformMotion : ISceneItemMoveMotionType
	{
		// Token: 0x0600F216 RID: 61974 RVA: 0x002360DF File Offset: 0x002342DF
		public static IUniformMotion Create(IUniformMotion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUniformMotion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048D2 RID: 18642
		// (get) Token: 0x0600F217 RID: 61975 RVA: 0x002360FE File Offset: 0x002342FE
		public override EMoveMotion Type
		{
			get
			{
				return (EMoveMotion)this.Instance.Type;
			}
		}

		// Token: 0x170048D3 RID: 18643
		// (get) Token: 0x0600F218 RID: 61976 RVA: 0x0023610B File Offset: 0x0023430B
		public virtual float Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x040084DF RID: 34015
		private IUniformMotion Instance;
	}
}
