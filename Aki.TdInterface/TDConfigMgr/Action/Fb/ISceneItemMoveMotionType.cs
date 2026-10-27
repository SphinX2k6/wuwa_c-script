using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002825 RID: 10277
	public class ISceneItemMoveMotionType
	{
		// Token: 0x0600E3EE RID: 58350 RVA: 0x00219247 File Offset: 0x00217447
		[NullableContext(1)]
		public static ISceneItemMoveMotionType Create(ISceneItemMoveMotionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemMoveMotionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004566 RID: 17766
		// (get) Token: 0x0600E3EF RID: 58351 RVA: 0x00219266 File Offset: 0x00217466
		public virtual EMoveMotion Type
		{
			get
			{
				return (EMoveMotion)this.Instance.Type;
			}
		}

		// Token: 0x04007E21 RID: 32289
		private ISceneItemMoveMotionType Instance;
	}
}
