using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F5 RID: 10229
	public class IQiuyuanLongPressQinggong : ILeisureInteractType
	{
		// Token: 0x0600E329 RID: 58153 RVA: 0x00218112 File Offset: 0x00216312
		[NullableContext(1)]
		public static IQiuyuanLongPressQinggong Create(IQiuyuanLongPressQinggong? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanLongPressQinggong
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004501 RID: 17665
		// (get) Token: 0x0600E32A RID: 58154 RVA: 0x00218131 File Offset: 0x00216331
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DD9 RID: 32217
		private IQiuyuanLongPressQinggong Instance;
	}
}
