using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4E RID: 10830
	[NullableContext(2)]
	[Nullable(0)]
	public class CloseFlowTemplate : ActionParams
	{
		// Token: 0x0600EF2A RID: 61226 RVA: 0x00230DC5 File Offset: 0x0022EFC5
		[NullableContext(0)]
		public static CloseFlowTemplate Create(ICloseFlowTemplate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CloseFlowTemplate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700473C RID: 18236
		// (get) Token: 0x0600EF2B RID: 61227 RVA: 0x00230DE4 File Offset: 0x0022EFE4
		public virtual bool IsResetPosition
		{
			get
			{
				return this.Instance.IsResetPosition;
			}
		}

		// Token: 0x1700473D RID: 18237
		// (get) Token: 0x0600EF2C RID: 61228 RVA: 0x00230DF1 File Offset: 0x0022EFF1
		public virtual IEndState EndState
		{
			get
			{
				if (this._EndStateInited)
				{
					return this._EndStateCache;
				}
				this._EndStateInited = true;
				this._EndStateCache = IEndState.Create(this.Instance.EndState);
				return this._EndStateCache;
			}
		}

		// Token: 0x1700473E RID: 18238
		// (get) Token: 0x0600EF2D RID: 61229 RVA: 0x00230E28 File Offset: 0x0022F028
		public virtual bool? ExitFilmAspectRatio
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ExitFilmAspectRatio);
			}
		}

		// Token: 0x0400835A RID: 33626
		private ICloseFlowTemplate Instance;

		// Token: 0x0400835B RID: 33627
		private IEndState _EndStateCache;

		// Token: 0x0400835C RID: 33628
		private bool _EndStateInited;
	}
}
