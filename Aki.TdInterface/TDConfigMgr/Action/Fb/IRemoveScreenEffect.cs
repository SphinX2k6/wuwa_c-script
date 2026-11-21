using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B1 RID: 10417
	public class IRemoveScreenEffect : IRemoveEffectBase
	{
		// Token: 0x0600E810 RID: 59408 RVA: 0x00224E7A File Offset: 0x0022307A
		public static IRemoveScreenEffect Create(IRemoveScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700435C RID: 17244
		// (get) Token: 0x0600E811 RID: 59409 RVA: 0x00224E99 File Offset: 0x00223099
		public override EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700435D RID: 17245
		// (get) Token: 0x0600E812 RID: 59410 RVA: 0x00224EA6 File Offset: 0x002230A6
		public override string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04007FCB RID: 32715
		private IRemoveScreenEffect Instance;
	}
}
