using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200251E RID: 9502
	public class ICaptionParam
	{
		// Token: 0x0600D3EF RID: 54255 RVA: 0x001F6541 File Offset: 0x001F4741
		[NullableContext(1)]
		public static ICaptionParam Create(ICaptionParam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICaptionParam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x0600D3F0 RID: 54256 RVA: 0x001F6560 File Offset: 0x001F4760
		public virtual float? StartTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StartTime);
			}
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x0600D3F1 RID: 54257 RVA: 0x001F6598 File Offset: 0x001F4798
		public virtual float? TotalTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.TotalTime);
			}
		}

		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x0600D3F2 RID: 54258 RVA: 0x001F65D0 File Offset: 0x001F47D0
		public virtual float? IntervalTime
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.IntervalTime);
			}
		}

		// Token: 0x04007424 RID: 29732
		private ICaptionParam Instance;
	}
}
