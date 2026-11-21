using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002017 RID: 8215
	public class ISceneUiSubtitleTextBase
	{
		// Token: 0x0600AE77 RID: 44663 RVA: 0x001896BC File Offset: 0x001878BC
		private ISceneUiSubtitleTextBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitleTextBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitleTextBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitleTextBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE78 RID: 44664 RVA: 0x001896F4 File Offset: 0x001878F4
		public static ISceneUiSubtitleTextBase Create([Nullable(2)] ISceneUiSubtitleTextBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleTextBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE79 RID: 44665 RVA: 0x00189707 File Offset: 0x00187907
		public static ISceneUiSubtitleTextBase CreateFromSetValue([Nullable(2)] ISceneUiSubtitleTextBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitleTextBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE7A RID: 44666 RVA: 0x0018971A File Offset: 0x0018791A
		public ISceneUiSubtitleTextBase_SetValue ToSetValue()
		{
			return new ISceneUiSubtitleTextBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0600AE7B RID: 44667 RVA: 0x0018972D File Offset: 0x0018792D
		// (set) Token: 0x0600AE7C RID: 44668 RVA: 0x00189758 File Offset: 0x00187958
		public virtual ESceneUiSubtitleTextType Type
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

		// Token: 0x04006802 RID: 26626
		[Nullable(2)]
		protected ISceneUiSubtitleTextBase FbInstance;

		// Token: 0x04006803 RID: 26627
		[Nullable(2)]
		protected ISceneUiSubtitleTextBase_SetValue PocoInterface;
	}
}
