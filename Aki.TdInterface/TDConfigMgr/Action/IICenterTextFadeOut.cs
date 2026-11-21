using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CD0 RID: 7376
	public class IICenterTextFadeOut : ICenterTextShowType
	{
		// Token: 0x06009C9A RID: 40090 RVA: 0x00168F34 File Offset: 0x00167134
		private IICenterTextFadeOut_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IICenterTextFadeOut 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IICenterTextFadeOut_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IICenterTextFadeOut_SetValue());
			}
			return result;
		}

		// Token: 0x06009C9B RID: 40091 RVA: 0x00168F6C File Offset: 0x0016716C
		public static IICenterTextFadeOut Create([Nullable(2)] IICenterTextFadeOut instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextFadeOut
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C9C RID: 40092 RVA: 0x00168F7F File Offset: 0x0016717F
		public static IICenterTextFadeOut CreateFromSetValue([Nullable(2)] IICenterTextFadeOut_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IICenterTextFadeOut
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C9D RID: 40093 RVA: 0x00168F92 File Offset: 0x00167192
		public new IICenterTextFadeOut_SetValue ToSetValue()
		{
			return new IICenterTextFadeOut_SetValue
			{
				Type = this.Type,
				FadeInTime = this.FadeInTime,
				FadeOutTime = this.FadeOutTime
			};
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x06009C9E RID: 40094 RVA: 0x00168FBD File Offset: 0x001671BD
		// (set) Token: 0x06009C9F RID: 40095 RVA: 0x00168FE8 File Offset: 0x001671E8
		public override ECenterTextShowAnim Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x06009CA0 RID: 40096 RVA: 0x00168FF6 File Offset: 0x001671F6
		// (set) Token: 0x06009CA1 RID: 40097 RVA: 0x00169025 File Offset: 0x00167225
		public virtual float FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x06009CA2 RID: 40098 RVA: 0x00169033 File Offset: 0x00167233
		// (set) Token: 0x06009CA3 RID: 40099 RVA: 0x00169062 File Offset: 0x00167262
		public virtual float FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x04005FB9 RID: 24505
		[Nullable(2)]
		protected new IICenterTextFadeOut FbInstance;

		// Token: 0x04005FBA RID: 24506
		[Nullable(2)]
		protected new IICenterTextFadeOut_SetValue PocoInterface;
	}
}
