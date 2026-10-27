using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A41 RID: 10817
	public class IClientEventPianoEvent
	{
		// Token: 0x0600EE2A RID: 60970 RVA: 0x0022AFC9 File Offset: 0x002291C9
		[NullableContext(1)]
		public static IClientEventPianoEvent Create(IClientEventPianoEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventPianoEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B6A RID: 19306
		// (get) Token: 0x0600EE2B RID: 60971 RVA: 0x0022AFE8 File Offset: 0x002291E8
		public virtual EClientEventPianoEventType Type
		{
			get
			{
				return (EClientEventPianoEventType)this.Instance.Type;
			}
		}

		// Token: 0x0400830F RID: 33551
		private IClientEventPianoEvent Instance;
	}
}
