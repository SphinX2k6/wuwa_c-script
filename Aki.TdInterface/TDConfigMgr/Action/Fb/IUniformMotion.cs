using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002826 RID: 10278
	public class IUniformMotion : ISceneItemMoveMotionType
	{
		// Token: 0x0600E3F1 RID: 58353 RVA: 0x0021927B File Offset: 0x0021747B
		[NullableContext(1)]
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

		// Token: 0x17004567 RID: 17767
		// (get) Token: 0x0600E3F2 RID: 58354 RVA: 0x0021929A File Offset: 0x0021749A
		public override EMoveMotion Type
		{
			get
			{
				return (EMoveMotion)this.Instance.Type;
			}
		}

		// Token: 0x17004568 RID: 17768
		// (get) Token: 0x0600E3F3 RID: 58355 RVA: 0x002192A7 File Offset: 0x002174A7
		public virtual float Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x04007E22 RID: 32290
		private IUniformMotion Instance;
	}
}
