using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners
{
	// Token: 0x02005C5F RID: 23647
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelListenerBase
	{
		// Token: 0x17006E80 RID: 28288
		// (get) Token: 0x0603A102 RID: 237826 RVA: 0x010566D6 File Offset: 0x010548D6
		public bool IsListening
		{
			get
			{
				return this.IsListeningInternal;
			}
		}

		// Token: 0x0603A103 RID: 237827 RVA: 0x010566DE File Offset: 0x010548DE
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

		// Token: 0x0603A104 RID: 237828 RVA: 0x01056710 File Offset: 0x01054910
		[NullableContext(1)]
		protected virtual void OnListen(object listeningInfo, TListenerCallbackFunc callback, [Nullable(2)] GeneralContext context = null, params object[] otherParams)
		{
		}

		// Token: 0x0603A105 RID: 237829 RVA: 0x01056712 File Offset: 0x01054912
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

		// Token: 0x0603A106 RID: 237830 RVA: 0x0105673F File Offset: 0x0105493F
		protected virtual void OnUnListen()
		{
		}

		// Token: 0x0401EB11 RID: 125713
		protected object ListeningInfo;

		// Token: 0x0401EB12 RID: 125714
		protected TListenerCallbackFunc Callback;

		// Token: 0x0401EB13 RID: 125715
		protected GeneralContext Context;

		// Token: 0x0401EB14 RID: 125716
		protected bool IsListeningInternal;
	}
}
