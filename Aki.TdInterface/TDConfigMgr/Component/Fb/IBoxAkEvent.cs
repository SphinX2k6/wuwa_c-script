using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ADB RID: 2779
	public class IBoxAkEvent : IAkEventTypeConfig
	{
		// Token: 0x06004003 RID: 16387 RVA: 0x000A39B6 File Offset: 0x000A1BB6
		[NullableContext(1)]
		public static IBoxAkEvent Create(IBoxAkEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBoxAkEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x000A39D5 File Offset: 0x000A1BD5
		public override EAkEventType Type
		{
			get
			{
				return (EAkEventType)this.Instance.Type;
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06004005 RID: 16389 RVA: 0x000A39E2 File Offset: 0x000A1BE2
		public virtual EAudioType AudioType
		{
			get
			{
				return (EAudioType)this.Instance.AudioType;
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06004006 RID: 16390 RVA: 0x000A39EF File Offset: 0x000A1BEF
		public virtual int Priority
		{
			get
			{
				return this.Instance.Priority;
			}
		}

		// Token: 0x040023A2 RID: 9122
		private IBoxAkEvent Instance;
	}
}
