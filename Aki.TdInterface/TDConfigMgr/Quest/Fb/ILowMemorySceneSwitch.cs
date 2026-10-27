using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013CF RID: 5071
	[NullableContext(1)]
	[Nullable(0)]
	public class ILowMemorySceneSwitch : ISpecialProcess
	{
		// Token: 0x060073C3 RID: 29635 RVA: 0x001159C2 File Offset: 0x00113BC2
		public static ILowMemorySceneSwitch Create(ILowMemorySceneSwitch? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILowMemorySceneSwitch
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x060073C4 RID: 29636 RVA: 0x001159E1 File Offset: 0x00113BE1
		public override ESpecialProcess Type
		{
			get
			{
				return (ESpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x060073C5 RID: 29637 RVA: 0x001159EE File Offset: 0x00113BEE
		public virtual List<IOperation> Operations
		{
			get
			{
				if (this._OperationsInited)
				{
					return this._OperationsCache;
				}
				this._OperationsInited = true;
				this._OperationsCache = QuestReadHelper.ReadILowMemorySceneSwitch_Operations(this.Instance);
				return this._OperationsCache;
			}
		}

		// Token: 0x04004303 RID: 17155
		private ILowMemorySceneSwitch Instance;

		// Token: 0x04004304 RID: 17156
		private List<IOperation> _OperationsCache;

		// Token: 0x04004305 RID: 17157
		private bool _OperationsInited;
	}
}
