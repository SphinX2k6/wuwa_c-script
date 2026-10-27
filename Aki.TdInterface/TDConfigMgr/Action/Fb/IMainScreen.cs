using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A1 RID: 10145
	public class IMainScreen : IScreenType
	{
		// Token: 0x0600E1C0 RID: 57792 RVA: 0x00215A61 File Offset: 0x00213C61
		[NullableContext(1)]
		public static IMainScreen Create(IMainScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMainScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004440 RID: 17472
		// (get) Token: 0x0600E1C1 RID: 57793 RVA: 0x00215A80 File Offset: 0x00213C80
		public override EScreenType Type
		{
			get
			{
				return (EScreenType)this.Instance.Type;
			}
		}

		// Token: 0x04007D2D RID: 32045
		private IMainScreen Instance;
	}
}
