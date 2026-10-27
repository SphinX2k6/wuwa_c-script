using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200250C RID: 9484
	public class ITalkOptionFirstSelect : ITalkOptionPreConditionBase
	{
		// Token: 0x0600D394 RID: 54164 RVA: 0x001F5B00 File Offset: 0x001F3D00
		[NullableContext(1)]
		public static ITalkOptionFirstSelect Create(ITalkOptionFirstSelect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionFirstSelect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x0600D395 RID: 54165 RVA: 0x001F5B1F File Offset: 0x001F3D1F
		public override ETalkOptionPreConditionType Type
		{
			get
			{
				return (ETalkOptionPreConditionType)this.Instance.Type;
			}
		}

		// Token: 0x040073FC RID: 29692
		private ITalkOptionFirstSelect Instance;
	}
}
