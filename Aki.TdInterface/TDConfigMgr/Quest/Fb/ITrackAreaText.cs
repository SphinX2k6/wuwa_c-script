using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012FA RID: 4858
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackAreaText
	{
		// Token: 0x06006ECC RID: 28364 RVA: 0x0010B9B2 File Offset: 0x00109BB2
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

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x06006ECD RID: 28365 RVA: 0x0010B9D1 File Offset: 0x00109BD1
		public virtual bool Show
		{
			get
			{
				return this.Instance.Show;
			}
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x06006ECE RID: 28366 RVA: 0x0010B9DE File Offset: 0x00109BDE
		public virtual string Tid
		{
			get
			{
				return this.Instance.Tid;
			}
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06006ECF RID: 28367 RVA: 0x0010B9EB File Offset: 0x00109BEB
		public virtual string EdTid
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04003F86 RID: 16262
		private ITrackAreaText Instance;
	}
}
