using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002521 RID: 9505
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkBackgroundImage : ITalkBackground
	{
		// Token: 0x0600D3FA RID: 54266 RVA: 0x001F6676 File Offset: 0x001F4876
		public static ITalkBackgroundImage Create(ITalkBackgroundImage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundImage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x0600D3FB RID: 54267 RVA: 0x001F6695 File Offset: 0x001F4895
		public override ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x0600D3FC RID: 54268 RVA: 0x001F66A2 File Offset: 0x001F48A2
		public virtual string ImageAsset
		{
			get
			{
				return this.Instance.ImageAsset;
			}
		}

		// Token: 0x04007427 RID: 29735
		private ITalkBackgroundImage Instance;
	}
}
