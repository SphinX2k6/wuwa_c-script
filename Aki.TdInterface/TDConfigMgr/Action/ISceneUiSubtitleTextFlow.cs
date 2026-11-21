using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002019 RID: 8217
	public class ISceneUiSubtitleTextFlow : ISceneUiSubtitleTextBase
	{
		// Token: 0x0600AE7F RID: 44671 RVA: 0x00189778 File Offset: 0x00187978
		private ISceneUiSubtitleTextFlow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitleTextFlow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitleTextFlow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitleTextFlow_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE80 RID: 44672 RVA: 0x001897B0 File Offset: 0x001879B0
		public static ISceneUiSubtitleTextFlow Create([Nullable(2)] ISceneUiSubtitleTextFlow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleTextFlow
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE81 RID: 44673 RVA: 0x001897C3 File Offset: 0x001879C3
		public static ISceneUiSubtitleTextFlow CreateFromSetValue([Nullable(2)] ISceneUiSubtitleTextFlow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitleTextFlow
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE82 RID: 44674 RVA: 0x001897D6 File Offset: 0x001879D6
		public new ISceneUiSubtitleTextFlow_SetValue ToSetValue()
		{
			return new ISceneUiSubtitleTextFlow_SetValue
			{
				Type = this.Type,
				Flow = this.Flow
			};
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0600AE83 RID: 44675 RVA: 0x001897F5 File Offset: 0x001879F5
		// (set) Token: 0x0600AE84 RID: 44676 RVA: 0x00189820 File Offset: 0x00187A20
		public override ESceneUiSubtitleTextType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneUiSubtitleTextType.Flow;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0600AE85 RID: 44677 RVA: 0x00189830 File Offset: 0x00187A30
		// (set) Token: 0x0600AE86 RID: 44678 RVA: 0x00189891 File Offset: 0x00187A91
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = PlayFlow.Create(this.FbInstance.Flow);
				}
				else
				{
					ISceneUiSubtitleTextFlow_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x04006805 RID: 26629
		[Nullable(2)]
		protected new ISceneUiSubtitleTextFlow FbInstance;

		// Token: 0x04006806 RID: 26630
		[Nullable(2)]
		protected new ISceneUiSubtitleTextFlow_SetValue PocoInterface;

		// Token: 0x04006807 RID: 26631
		private PlayFlow _FlowCache;

		// Token: 0x04006808 RID: 26632
		private bool _FlowInited;
	}
}
