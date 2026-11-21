using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF8 RID: 11000
	public class ISceneItemMoveMotionType
	{
		// Token: 0x0600F213 RID: 61971 RVA: 0x002360AB File Offset: 0x002342AB
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

		// Token: 0x170048D1 RID: 18641
		// (get) Token: 0x0600F214 RID: 61972 RVA: 0x002360CA File Offset: 0x002342CA
		public virtual EMoveMotion Type
		{
			get
			{
				return (EMoveMotion)this.Instance.Type;
			}
		}

		// Token: 0x040084DE RID: 34014
		private ISceneItemMoveMotionType Instance;
	}
}
