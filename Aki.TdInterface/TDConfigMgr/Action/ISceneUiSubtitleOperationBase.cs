using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200200B RID: 8203
	public class ISceneUiSubtitleOperationBase
	{
		// Token: 0x0600AE33 RID: 44595 RVA: 0x00188E9C File Offset: 0x0018709C
		private ISceneUiSubtitleOperationBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitleOperationBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitleOperationBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitleOperationBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE34 RID: 44596 RVA: 0x00188ED4 File Offset: 0x001870D4
		public static ISceneUiSubtitleOperationBase Create([Nullable(2)] ISceneUiSubtitleOperationBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleOperationBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE35 RID: 44597 RVA: 0x00188EE7 File Offset: 0x001870E7
		public static ISceneUiSubtitleOperationBase CreateFromSetValue([Nullable(2)] ISceneUiSubtitleOperationBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitleOperationBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE36 RID: 44598 RVA: 0x00188EFA File Offset: 0x001870FA
		public ISceneUiSubtitleOperationBase_SetValue ToSetValue()
		{
			return new ISceneUiSubtitleOperationBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0600AE37 RID: 44599 RVA: 0x00188F0D File Offset: 0x0018710D
		// (set) Token: 0x0600AE38 RID: 44600 RVA: 0x00188F38 File Offset: 0x00187138
		public virtual ESceneUiSubtitleOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneUiSubtitleOperationType.Spawn;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040067E0 RID: 26592
		[Nullable(2)]
		protected ISceneUiSubtitleOperationBase FbInstance;

		// Token: 0x040067E1 RID: 26593
		[Nullable(2)]
		protected ISceneUiSubtitleOperationBase_SetValue PocoInterface;
	}
}
