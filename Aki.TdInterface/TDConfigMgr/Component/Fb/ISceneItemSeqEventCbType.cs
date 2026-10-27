using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA6 RID: 3494
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemSeqEventCbType
	{
		// Token: 0x06004F66 RID: 20326 RVA: 0x000C4B35 File Offset: 0x000C2D35
		public static ISceneItemSeqEventCbType Create(ISceneItemSeqEventCbType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemSeqEventCbType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06004F67 RID: 20327 RVA: 0x000C4B54 File Offset: 0x000C2D54
		public virtual ESceneItemSeqEventCbType Type
		{
			get
			{
				return (ESceneItemSeqEventCbType)this.Instance.Type;
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06004F68 RID: 20328 RVA: 0x000C4B61 File Offset: 0x000C2D61
		public virtual string EventName
		{
			get
			{
				return this.Instance.EventName;
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06004F69 RID: 20329 RVA: 0x000C4B6E File Offset: 0x000C2D6E
		public virtual ActionInfo Action
		{
			get
			{
				if (this._ActionInited)
				{
					return this._ActionCache;
				}
				this._ActionInited = true;
				this._ActionCache = ActionInfo.Create(this.Instance.Action);
				return this._ActionCache;
			}
		}

		// Token: 0x04002D8F RID: 11663
		private ISceneItemSeqEventCbType Instance;

		// Token: 0x04002D90 RID: 11664
		[Nullable(2)]
		private ActionInfo _ActionCache;

		// Token: 0x04002D91 RID: 11665
		private bool _ActionInited;
	}
}
