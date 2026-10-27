using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A0 RID: 10144
	public class IScreenType
	{
		// Token: 0x0600E1BD RID: 57789 RVA: 0x00215A2D File Offset: 0x00213C2D
		[NullableContext(1)]
		public static IScreenType Create(IScreenType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScreenType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700443F RID: 17471
		// (get) Token: 0x0600E1BE RID: 57790 RVA: 0x00215A4C File Offset: 0x00213C4C
		public virtual EScreenType Type
		{
			get
			{
				return (EScreenType)this.Instance.Type;
			}
		}

		// Token: 0x04007D2C RID: 32044
		private IScreenType Instance;
	}
}
