using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002827 RID: 10279
	public class IVariableMotion : ISceneItemMoveMotionType
	{
		// Token: 0x0600E3F5 RID: 58357 RVA: 0x002192BC File Offset: 0x002174BC
		[NullableContext(1)]
		public static IVariableMotion Create(IVariableMotion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVariableMotion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004569 RID: 17769
		// (get) Token: 0x0600E3F6 RID: 58358 RVA: 0x002192DB File Offset: 0x002174DB
		public override EMoveMotion Type
		{
			get
			{
				return (EMoveMotion)this.Instance.Type;
			}
		}

		// Token: 0x1700456A RID: 17770
		// (get) Token: 0x0600E3F7 RID: 58359 RVA: 0x002192E8 File Offset: 0x002174E8
		public virtual float Acceleration
		{
			get
			{
				return this.Instance.Acceleration;
			}
		}

		// Token: 0x1700456B RID: 17771
		// (get) Token: 0x0600E3F8 RID: 58360 RVA: 0x002192F5 File Offset: 0x002174F5
		public virtual float MaxSpeed
		{
			get
			{
				return this.Instance.MaxSpeed;
			}
		}

		// Token: 0x04007E23 RID: 32291
		private IVariableMotion Instance;
	}
}
