using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291C RID: 10524
	[NullableContext(2)]
	[Nullable(0)]
	public class IUiAnimConfig
	{
		// Token: 0x0600E9EC RID: 59884 RVA: 0x002288D2 File Offset: 0x00226AD2
		[NullableContext(0)]
		public static IUiAnimConfig Create(IUiAnimConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiAnimConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004462 RID: 17506
		// (get) Token: 0x0600E9ED RID: 59885 RVA: 0x002288F1 File Offset: 0x00226AF1
		public virtual string UiStartAnimName
		{
			get
			{
				return this.Instance.UiStartAnimName;
			}
		}

		// Token: 0x17004463 RID: 17507
		// (get) Token: 0x0600E9EE RID: 59886 RVA: 0x002288FE File Offset: 0x00226AFE
		public virtual string UiEndAnimName
		{
			get
			{
				return this.Instance.UiEndAnimName;
			}
		}

		// Token: 0x040080F6 RID: 33014
		private IUiAnimConfig Instance;
	}
}
