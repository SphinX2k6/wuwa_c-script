using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A6 RID: 10406
	public class IPlayScreenEffect : PlayEffect2
	{
		// Token: 0x0600E7D9 RID: 59353 RVA: 0x002248E6 File Offset: 0x00222AE6
		public static IPlayScreenEffect Create(IPlayScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700433B RID: 17211
		// (get) Token: 0x0600E7DA RID: 59354 RVA: 0x00224905 File Offset: 0x00222B05
		public override EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700433C RID: 17212
		// (get) Token: 0x0600E7DB RID: 59355 RVA: 0x00224912 File Offset: 0x00222B12
		public override string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x1700433D RID: 17213
		// (get) Token: 0x0600E7DC RID: 59356 RVA: 0x00224920 File Offset: 0x00222B20
		public virtual float? DestroyTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DestroyTime);
			}
		}

		// Token: 0x1700433E RID: 17214
		// (get) Token: 0x0600E7DD RID: 59357 RVA: 0x00224956 File Offset: 0x00222B56
		[Nullable(2)]
		public virtual string BindSubScreenKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.BindSubScreenKey;
			}
		}

		// Token: 0x04007FB2 RID: 32690
		private IPlayScreenEffect Instance;
	}
}
