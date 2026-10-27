using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277C RID: 10108
	[NullableContext(2)]
	[Nullable(0)]
	public class CloseFlowTemplate : ActionParams
	{
		// Token: 0x0600E10C RID: 57612 RVA: 0x00214031 File Offset: 0x00212231
		[NullableContext(1)]
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

		// Token: 0x170043D6 RID: 17366
		// (get) Token: 0x0600E10D RID: 57613 RVA: 0x00214050 File Offset: 0x00212250
		public virtual bool IsResetPosition
		{
			get
			{
				return this.Instance.IsResetPosition;
			}
		}

		// Token: 0x170043D7 RID: 17367
		// (get) Token: 0x0600E10E RID: 57614 RVA: 0x0021405D File Offset: 0x0021225D
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

		// Token: 0x170043D8 RID: 17368
		// (get) Token: 0x0600E10F RID: 57615 RVA: 0x00214094 File Offset: 0x00212294
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

		// Token: 0x04007CA4 RID: 31908
		private ICloseFlowTemplate Instance;

		// Token: 0x04007CA5 RID: 31909
		private IEndState _EndStateCache;

		// Token: 0x04007CA6 RID: 31910
		private bool _EndStateInited;
	}
}
