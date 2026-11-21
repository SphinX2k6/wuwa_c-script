using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CA RID: 10186
	public class ITalkBackgroundSpineImage : ITalkBackground
	{
		// Token: 0x0600E163 RID: 57699 RVA: 0x00212165 File Offset: 0x00210365
		public static ITalkBackgroundSpineImage Create(ITalkBackgroundSpineImage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundSpineImage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x0600E164 RID: 57700 RVA: 0x00212184 File Offset: 0x00210384
		public override ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x0600E165 RID: 57701 RVA: 0x00212191 File Offset: 0x00210391
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x0600E166 RID: 57702 RVA: 0x002121A0 File Offset: 0x002103A0
		public virtual bool? IsLoop
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLoop);
			}
		}

		// Token: 0x04007A7E RID: 31358
		private ITalkBackgroundSpineImage Instance;
	}
}
