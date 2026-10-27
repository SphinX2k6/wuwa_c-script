using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200299A RID: 10650
	public class IOpenSystemBoardWithReturnType
	{
		// Token: 0x0600EBB9 RID: 60345 RVA: 0x002276B4 File Offset: 0x002258B4
		[NullableContext(1)]
		public static IOpenSystemBoardWithReturnType Create(IOpenSystemBoardWithReturnType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSystemBoardWithReturnType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A47 RID: 19015
		// (get) Token: 0x0600EBBA RID: 60346 RVA: 0x002276D3 File Offset: 0x002258D3
		public virtual ESystemType Type
		{
			get
			{
				return (ESystemType)this.Instance.Type;
			}
		}

		// Token: 0x040081CE RID: 33230
		private IOpenSystemBoardWithReturnType Instance;
	}
}
