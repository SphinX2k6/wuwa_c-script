using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200271B RID: 10011
	public class ISplineMoveTargetType
	{
		// Token: 0x0600DF4F RID: 57167 RVA: 0x002118BD File Offset: 0x0020FABD
		[NullableContext(1)]
		public static ISplineMoveTargetType Create(ISplineMoveTargetType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveTargetType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042DB RID: 17115
		// (get) Token: 0x0600DF50 RID: 57168 RVA: 0x002118DC File Offset: 0x0020FADC
		public virtual ESplineMoveTargetType Type
		{
			get
			{
				return (ESplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04007BEF RID: 31727
		private ISplineMoveTargetType Instance;
	}
}
