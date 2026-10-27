using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002998 RID: 10648
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomJson : ActionParams
	{
		// Token: 0x0600EBB2 RID: 60338 RVA: 0x0022763F File Offset: 0x0022583F
		public static CustomJson Create(ICustomJson? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CustomJson
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A44 RID: 19012
		// (get) Token: 0x0600EBB3 RID: 60339 RVA: 0x0022765E File Offset: 0x0022585E
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004A45 RID: 19013
		// (get) Token: 0x0600EBB4 RID: 60340 RVA: 0x0022766B File Offset: 0x0022586B
		public virtual string JsonString
		{
			get
			{
				return this.Instance.JsonString;
			}
		}

		// Token: 0x040081CC RID: 33228
		private ICustomJson Instance;
	}
}
