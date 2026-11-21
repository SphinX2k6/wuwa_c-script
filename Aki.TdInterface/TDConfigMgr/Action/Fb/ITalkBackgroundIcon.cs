using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CB RID: 10187
	public class ITalkBackgroundIcon : ITalkBackground
	{
		// Token: 0x0600E168 RID: 57704 RVA: 0x002121DE File Offset: 0x002103DE
		public static ITalkBackgroundIcon Create(ITalkBackgroundIcon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundIcon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x0600E169 RID: 57705 RVA: 0x002121FD File Offset: 0x002103FD
		public override ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x0600E16A RID: 57706 RVA: 0x0021220A File Offset: 0x0021040A
		public virtual string ImageAsset
		{
			get
			{
				return this.Instance.ImageAsset;
			}
		}

		// Token: 0x04007A7F RID: 31359
		private ITalkBackgroundIcon Instance;
	}
}
