using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FF RID: 10239
	public class ILandSlideEndInteract : ILeisureInteractType
	{
		// Token: 0x0600E347 RID: 58183 RVA: 0x0021831A File Offset: 0x0021651A
		[NullableContext(1)]
		public static ILandSlideEndInteract Create(ILandSlideEndInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILandSlideEndInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700450B RID: 17675
		// (get) Token: 0x0600E348 RID: 58184 RVA: 0x00218339 File Offset: 0x00216539
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DE3 RID: 32227
		private ILandSlideEndInteract Instance;
	}
}
