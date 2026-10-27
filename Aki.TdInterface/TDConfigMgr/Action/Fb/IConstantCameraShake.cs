using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002914 RID: 10516
	public class IConstantCameraShake : ICameraShakeConfig
	{
		// Token: 0x0600E96C RID: 59756 RVA: 0x00223905 File Offset: 0x00221B05
		[NullableContext(1)]
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

		// Token: 0x17004906 RID: 18694
		// (get) Token: 0x0600E96D RID: 59757 RVA: 0x00223924 File Offset: 0x00221B24
		public override ECameraShakeType Type
		{
			get
			{
				return (ECameraShakeType)this.Instance.Type;
			}
		}

		// Token: 0x040080D8 RID: 32984
		private IConstantCameraShake Instance;
	}
}
