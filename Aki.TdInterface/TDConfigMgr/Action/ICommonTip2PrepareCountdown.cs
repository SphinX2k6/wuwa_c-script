using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200190C RID: 6412
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTip2PrepareCountdown : ICommonTip2Type
	{
		// Token: 0x06008965 RID: 35173 RVA: 0x001445E4 File Offset: 0x001427E4
		private ICommonTip2PrepareCountdown_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTip2PrepareCountdown 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTip2PrepareCountdown_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTip2PrepareCountdown_SetValue());
			}
			return result;
		}

		// Token: 0x06008966 RID: 35174 RVA: 0x0014461C File Offset: 0x0014281C
		public static ICommonTip2PrepareCountdown Create([Nullable(2)] ICommonTip2PrepareCountdown instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTip2PrepareCountdown
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008967 RID: 35175 RVA: 0x0014462F File Offset: 0x0014282F
		public static ICommonTip2PrepareCountdown CreateFromSetValue([Nullable(2)] ICommonTip2PrepareCountdown_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTip2PrepareCountdown
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x00144644 File Offset: 0x00142844
		public new ICommonTip2PrepareCountdown_SetValue ToSetValue()
		{
			return new ICommonTip2PrepareCountdown_SetValue
			{
				Type = this.Type,
				CountDownNum = this.CountDownNum,
				TidCountDownTxt = this.TidCountDownTxt,
				UiStyle = this.UiStyle,
				IsBlockPlayer = this.IsBlockPlayer,
				EdTidCountDownTxt = this.EdTidCountDownTxt
			};
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x06008969 RID: 35177 RVA: 0x0014469E File Offset: 0x0014289E
		// (set) Token: 0x0600896A RID: 35178 RVA: 0x001446C9 File Offset: 0x001428C9
		public override ECommonTip2Type Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTip2Type.PrepareCountdown;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x0600896B RID: 35179 RVA: 0x001446D7 File Offset: 0x001428D7
		// (set) Token: 0x0600896C RID: 35180 RVA: 0x00144702 File Offset: 0x00142902
		public virtual int CountDownNum
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CountDownNum;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CountDownNum;
			}
			set
			{
				this.GetOrCreatePoco().CountDownNum = value;
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x0600896D RID: 35181 RVA: 0x00144710 File Offset: 0x00142910
		// (set) Token: 0x0600896E RID: 35182 RVA: 0x0014473B File Offset: 0x0014293B
		public virtual string TidCountDownTxt
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidCountDownTxt;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidCountDownTxt;
			}
			set
			{
				this.GetOrCreatePoco().TidCountDownTxt = value;
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x0600896F RID: 35183 RVA: 0x0014474C File Offset: 0x0014294C
		// (set) Token: 0x06008970 RID: 35184 RVA: 0x00144786 File Offset: 0x00142986
		public virtual ECountDownUiStyle? UiStyle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiStyle;
				}
				ICommonTip2PrepareCountdown_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiStyle;
			}
			set
			{
				this.GetOrCreatePoco().UiStyle = value;
			}
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x06008971 RID: 35185 RVA: 0x00144794 File Offset: 0x00142994
		// (set) Token: 0x06008972 RID: 35186 RVA: 0x001447CE File Offset: 0x001429CE
		public virtual bool? IsBlockPlayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsBlockPlayer;
				}
				ICommonTip2PrepareCountdown_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsBlockPlayer;
			}
			set
			{
				this.GetOrCreatePoco().IsBlockPlayer = value;
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x06008973 RID: 35187 RVA: 0x001447DC File Offset: 0x001429DC
		// (set) Token: 0x06008974 RID: 35188 RVA: 0x001447F3 File Offset: 0x001429F3
		[Nullable(2)]
		public virtual string EdTidCountDownTxt
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidCountDownTxt;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidCountDownTxt = value;
			}
		}

		// Token: 0x04005618 RID: 22040
		[Nullable(2)]
		protected new ICommonTip2PrepareCountdown FbInstance;

		// Token: 0x04005619 RID: 22041
		[Nullable(2)]
		protected new ICommonTip2PrepareCountdown_SetValue PocoInterface;
	}
}
