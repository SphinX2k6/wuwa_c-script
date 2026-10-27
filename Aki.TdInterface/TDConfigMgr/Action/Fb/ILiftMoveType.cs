using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282E RID: 10286
	public class ILiftMoveType
	{
		// Token: 0x0600E41B RID: 58395 RVA: 0x00219762 File Offset: 0x00217962
		[NullableContext(1)]
		public static ILiftMoveType Create(ILiftMoveType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004581 RID: 17793
		// (get) Token: 0x0600E41C RID: 58396 RVA: 0x00219781 File Offset: 0x00217981
		public virtual ELiftMoveType Type
		{
			get
			{
				return (ELiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04007E3C RID: 32316
		private ILiftMoveType Instance;
	}
}
