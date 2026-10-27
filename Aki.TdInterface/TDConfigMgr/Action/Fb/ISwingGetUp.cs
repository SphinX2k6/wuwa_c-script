using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F3 RID: 10227
	public class ISwingGetUp : ILeisureInteractType
	{
		// Token: 0x0600E321 RID: 58145 RVA: 0x00218065 File Offset: 0x00216265
		[NullableContext(1)]
		public static ISwingGetUp Create(ISwingGetUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwingGetUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044FD RID: 17661
		// (get) Token: 0x0600E322 RID: 58146 RVA: 0x00218084 File Offset: 0x00216284
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DD7 RID: 32215
		private ISwingGetUp Instance;
	}
}
