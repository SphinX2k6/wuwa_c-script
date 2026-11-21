using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200233A RID: 9018
	public class ModifySceneUiSubtitle : ActionParams
	{
		// Token: 0x0600C44E RID: 50254 RVA: 0x001C2638 File Offset: 0x001C0838
		private ModifySceneUiSubtitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ModifySceneUiSubtitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ModifySceneUiSubtitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ModifySceneUiSubtitle_SetValue());
			}
			return result;
		}

		// Token: 0x0600C44F RID: 50255 RVA: 0x001C2670 File Offset: 0x001C0870
		public static ModifySceneUiSubtitle Create([Nullable(2)] ModifySceneUiSubtitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ModifySceneUiSubtitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C450 RID: 50256 RVA: 0x001C2683 File Offset: 0x001C0883
		public static ModifySceneUiSubtitle CreateFromSetValue([Nullable(2)] ModifySceneUiSubtitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ModifySceneUiSubtitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C451 RID: 50257 RVA: 0x001C2696 File Offset: 0x001C0896
		public ModifySceneUiSubtitle_SetValue ToSetValue()
		{
			return new ModifySceneUiSubtitle_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x0600C452 RID: 50258 RVA: 0x001C26A9 File Offset: 0x001C08A9
		// (set) Token: 0x0600C453 RID: 50259 RVA: 0x001C26D0 File Offset: 0x001C08D0
		public virtual ISceneUiSubtitleOperationBase Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ModifySceneUiSubtitle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x040074E1 RID: 29921
		[Nullable(2)]
		protected new ModifySceneUiSubtitle FbInstance;

		// Token: 0x040074E2 RID: 29922
		[Nullable(2)]
		protected ModifySceneUiSubtitle_SetValue PocoInterface;
	}
}
