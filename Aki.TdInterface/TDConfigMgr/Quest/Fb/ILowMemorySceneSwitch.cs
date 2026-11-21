using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001526 RID: 5414
	public class ILowMemorySceneSwitch : ISpecialProcess
	{
		// Token: 0x06007A84 RID: 31364 RVA: 0x001243A6 File Offset: 0x001225A6
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

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x06007A85 RID: 31365 RVA: 0x001243C5 File Offset: 0x001225C5
		public override ESpecialProcess Type
		{
			get
			{
				return (ESpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x06007A86 RID: 31366 RVA: 0x001243D2 File Offset: 0x001225D2
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

		// Token: 0x04004694 RID: 18068
		private ILowMemorySceneSwitch Instance;

		// Token: 0x04004695 RID: 18069
		private List<IOperation> _OperationsCache;

		// Token: 0x04004696 RID: 18070
		private bool _OperationsInited;
	}
}
