using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002888 RID: 10376
	public class ISceneUiSubtitleTextFlow : ISceneUiSubtitleTextBase
	{
		// Token: 0x0600E73E RID: 59198 RVA: 0x002235AB File Offset: 0x002217AB
		public static ISceneUiSubtitleTextFlow Create(ISceneUiSubtitleTextFlow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleTextFlow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042DC RID: 17116
		// (get) Token: 0x0600E73F RID: 59199 RVA: 0x002235CA File Offset: 0x002217CA
		public override ESceneUiSubtitleTextType Type
		{
			get
			{
				return (ESceneUiSubtitleTextType)this.Instance.Type;
			}
		}

		// Token: 0x170042DD RID: 17117
		// (get) Token: 0x0600E740 RID: 59200 RVA: 0x002235D7 File Offset: 0x002217D7
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = PlayFlow.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x04007F56 RID: 32598
		private ISceneUiSubtitleTextFlow Instance;

		// Token: 0x04007F57 RID: 32599
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04007F58 RID: 32600
		private bool _FlowInited;
	}
}
