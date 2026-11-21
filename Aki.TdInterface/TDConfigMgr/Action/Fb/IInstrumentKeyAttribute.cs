using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B09 RID: 11017
	[NullableContext(2)]
	[Nullable(0)]
	public class IInstrumentKeyAttribute
	{
		// Token: 0x0600F265 RID: 62053 RVA: 0x00236905 File Offset: 0x00234B05
		[NullableContext(0)]
		public static IInstrumentKeyAttribute Create(IInstrumentKeyAttribute? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentKeyAttribute
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004901 RID: 18689
		// (get) Token: 0x0600F266 RID: 62054 RVA: 0x00236924 File Offset: 0x00234B24
		public virtual string FundamentalToneAssetPath
		{
			get
			{
				return this.Instance.FundamentalToneAssetPath;
			}
		}

		// Token: 0x17004902 RID: 18690
		// (get) Token: 0x0600F267 RID: 62055 RVA: 0x00236931 File Offset: 0x00234B31
		public virtual string OverToneAssetPath
		{
			get
			{
				return this.Instance.OverToneAssetPath;
			}
		}

		// Token: 0x17004903 RID: 18691
		// (get) Token: 0x0600F268 RID: 62056 RVA: 0x0023693E File Offset: 0x00234B3E
		public virtual string TextureAssetPath
		{
			get
			{
				return this.Instance.TextureAssetPath;
			}
		}

		// Token: 0x04008507 RID: 34055
		private IInstrumentKeyAttribute Instance;
	}
}
