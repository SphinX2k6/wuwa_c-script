using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FC RID: 10236
	public class IQiuyuanQinggongHovering : ILeisureInteractType
	{
		// Token: 0x0600E33E RID: 58174 RVA: 0x0021827E File Offset: 0x0021647E
		[NullableContext(1)]
		public static IQiuyuanQinggongHovering Create(IQiuyuanQinggongHovering? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongHovering
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004508 RID: 17672
		// (get) Token: 0x0600E33F RID: 58175 RVA: 0x0021829D File Offset: 0x0021649D
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DE0 RID: 32224
		private IQiuyuanQinggongHovering Instance;
	}
}
