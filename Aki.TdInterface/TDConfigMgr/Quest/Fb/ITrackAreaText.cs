using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200144A RID: 5194
	public class ITrackAreaText
	{
		// Token: 0x0600756C RID: 30060 RVA: 0x00119F1E File Offset: 0x0011811E
		public static ITrackAreaText Create(ITrackAreaText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackAreaText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x0600756D RID: 30061 RVA: 0x00119F3D File Offset: 0x0011813D
		public virtual bool Show
		{
			get
			{
				return this.Instance.Show;
			}
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x0600756E RID: 30062 RVA: 0x00119F4A File Offset: 0x0011814A
		public virtual string Tid
		{
			get
			{
				return this.Instance.Tid;
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x0600756F RID: 30063 RVA: 0x00119F57 File Offset: 0x00118157
		[Nullable(2)]
		public virtual string EdTid
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04004302 RID: 17154
		private ITrackAreaText Instance;
	}
}
