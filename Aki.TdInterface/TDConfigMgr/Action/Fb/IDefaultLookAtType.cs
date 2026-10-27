using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A67 RID: 10855
	public class IDefaultLookAtType
	{
		// Token: 0x0600EEC1 RID: 61121 RVA: 0x0022BD0E File Offset: 0x00229F0E
		[NullableContext(1)]
		public static IDefaultLookAtType Create(IDefaultLookAtType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDefaultLookAtType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BB5 RID: 19381
		// (get) Token: 0x0600EEC2 RID: 61122 RVA: 0x0022BD2D File Offset: 0x00229F2D
		public virtual EDefaultLookAtType Type
		{
			get
			{
				return (EDefaultLookAtType)this.Instance.Type;
			}
		}

		// Token: 0x04008357 RID: 33623
		private IDefaultLookAtType Instance;
	}
}
