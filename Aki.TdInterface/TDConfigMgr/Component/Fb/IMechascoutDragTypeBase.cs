using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB6 RID: 3254
	public class IMechascoutDragTypeBase
	{
		// Token: 0x06004A71 RID: 19057 RVA: 0x000BA4F1 File Offset: 0x000B86F1
		[NullableContext(1)]
		public static IMechascoutDragTypeBase Create(IMechascoutDragTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutDragTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x000BA510 File Offset: 0x000B8710
		public virtual EMechascoutDragType Type
		{
			get
			{
				return (EMechascoutDragType)this.Instance.Type;
			}
		}

		// Token: 0x04002A7B RID: 10875
		private IMechascoutDragTypeBase Instance;
	}
}
