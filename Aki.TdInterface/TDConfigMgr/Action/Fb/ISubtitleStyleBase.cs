using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025C4 RID: 9668
	public class ISubtitleStyleBase
	{
		// Token: 0x0600D962 RID: 55650 RVA: 0x00206C6C File Offset: 0x00204E6C
		[NullableContext(1)]
		public static ISubtitleStyleBase Create(ISubtitleStyleBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F9C RID: 16284
		// (get) Token: 0x0600D963 RID: 55651 RVA: 0x00206C8B File Offset: 0x00204E8B
		public virtual ESubtitleStyle Type
		{
			get
			{
				return (ESubtitleStyle)this.Instance.Type;
			}
		}

		// Token: 0x040078BC RID: 30908
		private ISubtitleStyleBase Instance;
	}
}
