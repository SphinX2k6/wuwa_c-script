using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002195 RID: 8597
	public class ITalkItemStyleSceneUiSubtitle : ITalkItemStyle
	{
		// Token: 0x0600B9A8 RID: 47528 RVA: 0x001A94AC File Offset: 0x001A76AC
		private ITalkItemStyleSceneUiSubtitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemStyleSceneUiSubtitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemStyleSceneUiSubtitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemStyleSceneUiSubtitle_SetValue());
			}
			return result;
		}

		// Token: 0x0600B9A9 RID: 47529 RVA: 0x001A94E4 File Offset: 0x001A76E4
		public static ITalkItemStyleSceneUiSubtitle Create([Nullable(2)] ITalkItemStyleSceneUiSubtitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStyleSceneUiSubtitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B9AA RID: 47530 RVA: 0x001A94F7 File Offset: 0x001A76F7
		public static ITalkItemStyleSceneUiSubtitle CreateFromSetValue([Nullable(2)] ITalkItemStyleSceneUiSubtitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemStyleSceneUiSubtitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B9AB RID: 47531 RVA: 0x001A950A File Offset: 0x001A770A
		public new ITalkItemStyleSceneUiSubtitle_SetValue ToSetValue()
		{
			return new ITalkItemStyleSceneUiSubtitle_SetValue
			{
				Type = this.Type,
				Style = this.Style
			};
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600B9AC RID: 47532 RVA: 0x001A9529 File Offset: 0x001A7729
		// (set) Token: 0x0600B9AD RID: 47533 RVA: 0x001A9554 File Offset: 0x001A7754
		public override ETalkItemStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0600B9AE RID: 47534 RVA: 0x001A9562 File Offset: 0x001A7762
		// (set) Token: 0x0600B9AF RID: 47535 RVA: 0x001A9589 File Offset: 0x001A7789
		public virtual ISceneUiSubtitleStyleBase Style
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Style;
				}
				ITalkItemStyleSceneUiSubtitle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Style;
			}
			set
			{
				this.GetOrCreatePoco().Style = value;
			}
		}

		// Token: 0x04006F19 RID: 28441
		[Nullable(2)]
		protected new ITalkItemStyleSceneUiSubtitle FbInstance;

		// Token: 0x04006F1A RID: 28442
		[Nullable(2)]
		protected new ITalkItemStyleSceneUiSubtitle_SetValue PocoInterface;
	}
}
