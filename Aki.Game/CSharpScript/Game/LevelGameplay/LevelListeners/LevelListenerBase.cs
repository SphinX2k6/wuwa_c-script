using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners
{
	// Token: 0x02006AE7 RID: 27367
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelListenerBase
	{
		// Token: 0x1700997D RID: 39293
		// (get) Token: 0x06043FB0 RID: 278448 RVA: 0x010ACE5A File Offset: 0x010AB05A
		public bool IsListening
		{
			get
			{
				return this.IsListeningInternal;
			}
		}

		// Token: 0x06043FB1 RID: 278449 RVA: 0x010ACE62 File Offset: 0x010AB062
		[NullableContext(1)]
		public void Listen(object listeningInfo, TListenerCallbackFunc callback, GeneralContext context, params object[] otherParams)
		{
			if (this.IsListeningInternal)
			{
				return;
			}
			this.IsListeningInternal = true;
			this.ListeningInfo = listeningInfo;
			this.Callback = callback;
			this.Context = context;
			this.OnListen(listeningInfo, callback, context, otherParams);
		}

		// Token: 0x06043FB2 RID: 278450 RVA: 0x010ACE94 File Offset: 0x010AB094
		[NullableContext(1)]
		protected virtual void OnListen(object listeningInfo, TListenerCallbackFunc callback, [Nullable(2)] GeneralContext context = null, params object[] otherParams)
		{
		}

		// Token: 0x06043FB3 RID: 278451 RVA: 0x010ACE96 File Offset: 0x010AB096
		public void UnListen()
		{
			if (!this.IsListeningInternal)
			{
				return;
			}
			this.OnUnListen();
			this.IsListeningInternal = false;
			this.ListeningInfo = null;
			this.Callback = null;
			this.Context = null;
		}

		// Token: 0x06043FB4 RID: 278452 RVA: 0x010ACEC3 File Offset: 0x010AB0C3
		protected virtual void OnUnListen()
		{
		}

		// Token: 0x0402386F RID: 145519
		protected object ListeningInfo;

		// Token: 0x04023870 RID: 145520
		protected TListenerCallbackFunc Callback;

		// Token: 0x04023871 RID: 145521
		protected GeneralContext Context;

		// Token: 0x04023872 RID: 145522
		protected bool IsListeningInternal;
	}
}
