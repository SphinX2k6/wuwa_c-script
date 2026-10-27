using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025DA RID: 9690
	[NullableContext(1)]
	[Nullable(0)]
	public class IMp4UiReplaceMaterial : IProgramSpecialConfigBase
	{
		// Token: 0x0600D9D1 RID: 55761 RVA: 0x00207B2B File Offset: 0x00205D2B
		public static IMp4UiReplaceMaterial Create(IMp4UiReplaceMaterial? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4UiReplaceMaterial
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FDF RID: 16351
		// (get) Token: 0x0600D9D2 RID: 55762 RVA: 0x00207B4A File Offset: 0x00205D4A
		public override EPlayMovieProgramSpecialConfigType Type
		{
			get
			{
				return (EPlayMovieProgramSpecialConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x0600D9D3 RID: 55763 RVA: 0x00207B57 File Offset: 0x00205D57
		public virtual string Mp4UiReplaceMaterial
		{
			get
			{
				return this.Instance.Mp4UiReplaceMaterial;
			}
		}

		// Token: 0x040078F6 RID: 30966
		private IMp4UiReplaceMaterial Instance;
	}
}
