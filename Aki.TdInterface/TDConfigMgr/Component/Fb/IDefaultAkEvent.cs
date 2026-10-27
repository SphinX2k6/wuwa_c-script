using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ADC RID: 2780
	public class IDefaultAkEvent : IAkEventTypeConfig
	{
		// Token: 0x06004008 RID: 16392 RVA: 0x000A3A04 File Offset: 0x000A1C04
		[NullableContext(1)]
		public static IDefaultAkEvent Create(IDefaultAkEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDefaultAkEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x000A3A23 File Offset: 0x000A1C23
		public override EAkEventType Type
		{
			get
			{
				return (EAkEventType)this.Instance.Type;
			}
		}

		// Token: 0x040023A3 RID: 9123
		private IDefaultAkEvent Instance;
	}
}
