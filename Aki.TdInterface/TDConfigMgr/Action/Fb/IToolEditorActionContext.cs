using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024CB RID: 9419
	[NullableContext(1)]
	[Nullable(0)]
	public class IToolEditorActionContext : IActionContextType
	{
		// Token: 0x0600D26C RID: 53868 RVA: 0x001F3942 File Offset: 0x001F1B42
		public static IToolEditorActionContext Create(IToolEditorActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToolEditorActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x0600D26D RID: 53869 RVA: 0x001F3961 File Offset: 0x001F1B61
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x04007373 RID: 29555
		private IToolEditorActionContext Instance;
	}
}
