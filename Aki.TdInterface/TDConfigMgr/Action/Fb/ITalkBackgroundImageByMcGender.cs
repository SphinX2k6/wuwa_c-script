using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C9 RID: 10185
	public class ITalkBackgroundImageByMcGender : ITalkBackground
	{
		// Token: 0x0600E15E RID: 57694 RVA: 0x00212117 File Offset: 0x00210317
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

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x0600E15F RID: 57695 RVA: 0x00212136 File Offset: 0x00210336
		public override ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x0600E160 RID: 57696 RVA: 0x00212143 File Offset: 0x00210343
		public virtual string ImageAssetMale
		{
			get
			{
				return this.Instance.ImageAssetMale;
			}
		}

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x0600E161 RID: 57697 RVA: 0x00212150 File Offset: 0x00210350
		public virtual string ImageAssetFemale
		{
			get
			{
				return this.Instance.ImageAssetFemale;
			}
		}

		// Token: 0x04007A7D RID: 31357
		private ITalkBackgroundImageByMcGender Instance;
	}
}
