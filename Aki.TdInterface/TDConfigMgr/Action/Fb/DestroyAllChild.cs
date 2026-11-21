using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028DF RID: 10463
	public class DestroyAllChild : ActionParams
	{
		// Token: 0x0600E8E8 RID: 59624 RVA: 0x002269AA File Offset: 0x00224BAA
		public static DestroyAllChild Create(IDestroyAllChild? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyAllChild
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008059 RID: 32857
		private IDestroyAllChild Instance;
	}
}
