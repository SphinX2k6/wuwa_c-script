using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3E RID: 3646
	public class IGraph3dEdgeBase
	{
		// Token: 0x06005264 RID: 21092 RVA: 0x000CAE11 File Offset: 0x000C9011
		[NullableContext(1)]
		public static IGraph3dEdgeBase Create(IGraph3dEdgeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dEdgeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x000CAE30 File Offset: 0x000C9030
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06005266 RID: 21094 RVA: 0x000CAE3D File Offset: 0x000C903D
		public virtual int From
		{
			get
			{
				return this.Instance.From;
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06005267 RID: 21095 RVA: 0x000CAE4A File Offset: 0x000C904A
		public virtual int To
		{
			get
			{
				return this.Instance.To;
			}
		}

		// Token: 0x04002F7D RID: 12157
		private IGraph3dEdgeBase Instance;
	}
}
