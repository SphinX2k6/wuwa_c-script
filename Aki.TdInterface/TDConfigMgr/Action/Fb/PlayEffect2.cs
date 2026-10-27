using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025E5 RID: 9701
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayEffect2 : ActionParams
	{
		// Token: 0x0600DA05 RID: 55813 RVA: 0x002080DA File Offset: 0x002062DA
		public static PlayEffect2 Create(IPlayEffect2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayEffect2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x0600DA06 RID: 55814 RVA: 0x002080F9 File Offset: 0x002062F9
		public virtual EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x0600DA07 RID: 55815 RVA: 0x00208106 File Offset: 0x00206306
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04007917 RID: 30999
		private IPlayEffect2 Instance;
	}
}
