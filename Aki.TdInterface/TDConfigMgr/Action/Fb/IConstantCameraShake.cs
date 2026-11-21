using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BF0 RID: 11248
	public class IConstantCameraShake : ICameraShakeConfig
	{
		// Token: 0x0600F7BE RID: 63422 RVA: 0x00240C5D File Offset: 0x0023EE5D
		public static IConstantCameraShake Create(IConstantCameraShake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConstantCameraShake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C8C RID: 19596
		// (get) Token: 0x0600F7BF RID: 63423 RVA: 0x00240C7C File Offset: 0x0023EE7C
		public override ECameraShakeType Type
		{
			get
			{
				return (ECameraShakeType)this.Instance.Type;
			}
		}

		// Token: 0x040087A6 RID: 34726
		private IConstantCameraShake Instance;
	}
}
