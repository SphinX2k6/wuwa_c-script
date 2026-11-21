using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002770 RID: 10096
	public class IToolEditorActionContext : IActionContextType
	{
		// Token: 0x0600DFC1 RID: 57281 RVA: 0x0020F19E File Offset: 0x0020D39E
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

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x0600DFC2 RID: 57282 RVA: 0x0020F1BD File Offset: 0x0020D3BD
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x040079C0 RID: 31168
		private IToolEditorActionContext Instance;
	}
}
