using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF8 RID: 3320
	public class IMidViewDistance : IViewDistanceMode
	{
		// Token: 0x06004BD5 RID: 19413 RVA: 0x000BD3F0 File Offset: 0x000BB5F0
		[NullableContext(1)]
		public static IMidViewDistance Create(IMidViewDistance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMidViewDistance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x000BD40F File Offset: 0x000BB60F
		public override EViewDistanceType Type
		{
			get
			{
				return (EViewDistanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002B5B RID: 11099
		private IMidViewDistance Instance;
	}
}
