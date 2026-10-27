using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002504 RID: 9476
	public class IHeadStyleVoiceOnly : IHeadStyle
	{
		// Token: 0x0600D377 RID: 54135 RVA: 0x001F587D File Offset: 0x001F3A7D
		[NullableContext(1)]
		public static IHeadStyleVoiceOnly Create(IHeadStyleVoiceOnly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleVoiceOnly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x0600D378 RID: 54136 RVA: 0x001F589C File Offset: 0x001F3A9C
		public override EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x0600D379 RID: 54137 RVA: 0x001F58A9 File Offset: 0x001F3AA9
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x040073EE RID: 29678
		private IHeadStyleVoiceOnly Instance;
	}
}
