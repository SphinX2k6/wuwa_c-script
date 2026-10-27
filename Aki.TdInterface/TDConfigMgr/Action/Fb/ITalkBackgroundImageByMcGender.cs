using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002522 RID: 9506
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkBackgroundImageByMcGender : ITalkBackground
	{
		// Token: 0x0600D3FE RID: 54270 RVA: 0x001F66B7 File Offset: 0x001F48B7
		public static ITalkBackgroundImageByMcGender Create(ITalkBackgroundImageByMcGender? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundImageByMcGender
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x0600D3FF RID: 54271 RVA: 0x001F66D6 File Offset: 0x001F48D6
		public override ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x0600D400 RID: 54272 RVA: 0x001F66E3 File Offset: 0x001F48E3
		public virtual string ImageAssetMale
		{
			get
			{
				return this.Instance.ImageAssetMale;
			}
		}

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x0600D401 RID: 54273 RVA: 0x001F66F0 File Offset: 0x001F48F0
		public virtual string ImageAssetFemale
		{
			get
			{
				return this.Instance.ImageAssetFemale;
			}
		}

		// Token: 0x04007428 RID: 29736
		private ITalkBackgroundImageByMcGender Instance;
	}
}
