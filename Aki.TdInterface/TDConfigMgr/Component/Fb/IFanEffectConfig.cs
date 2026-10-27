using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CCB RID: 3275
	[NullableContext(1)]
	[Nullable(0)]
	public class IFanEffectConfig
	{
		// Token: 0x06004AE4 RID: 19172 RVA: 0x000BB685 File Offset: 0x000B9885
		public static IFanEffectConfig Create(IFanEffectConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanEffectConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06004AE5 RID: 19173 RVA: 0x000BB6A4 File Offset: 0x000B98A4
		public virtual string EffectPath
		{
			get
			{
				return this.Instance.EffectPath;
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06004AE6 RID: 19174 RVA: 0x000BB6B1 File Offset: 0x000B98B1
		public virtual float DefaultEffectLength
		{
			get
			{
				return this.Instance.DefaultEffectLength;
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x000BB6BE File Offset: 0x000B98BE
		[Nullable(2)]
		public virtual string HitEffectPath
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.HitEffectPath;
			}
		}

		// Token: 0x04002AE0 RID: 10976
		private IFanEffectConfig Instance;
	}
}
