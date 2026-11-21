using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A36 RID: 10806
	public class ICommonTip2PrepareCountdown : ICommonTip2Type
	{
		// Token: 0x0600EEC1 RID: 61121 RVA: 0x0023018A File Offset: 0x0022E38A
		public static ICommonTip2PrepareCountdown Create(ICommonTip2PrepareCountdown? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTip2PrepareCountdown
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004703 RID: 18179
		// (get) Token: 0x0600EEC2 RID: 61122 RVA: 0x002301A9 File Offset: 0x0022E3A9
		public override ECommonTip2Type Type
		{
			get
			{
				return (ECommonTip2Type)this.Instance.Type;
			}
		}

		// Token: 0x17004704 RID: 18180
		// (get) Token: 0x0600EEC3 RID: 61123 RVA: 0x002301B6 File Offset: 0x0022E3B6
		public virtual int CountDownNum
		{
			get
			{
				return this.Instance.CountDownNum;
			}
		}

		// Token: 0x17004705 RID: 18181
		// (get) Token: 0x0600EEC4 RID: 61124 RVA: 0x002301C3 File Offset: 0x0022E3C3
		public virtual string TidCountDownTxt
		{
			get
			{
				return this.Instance.TidCountDownTxt;
			}
		}

		// Token: 0x17004706 RID: 18182
		// (get) Token: 0x0600EEC5 RID: 61125 RVA: 0x002301D0 File Offset: 0x0022E3D0
		public virtual ECountDownUiStyle? UiStyle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new ECountDownUiStyle?((ECountDownUiStyle)this.Instance.UiStyle);
			}
		}

		// Token: 0x17004707 RID: 18183
		// (get) Token: 0x0600EEC6 RID: 61126 RVA: 0x00230208 File Offset: 0x0022E408
		public virtual bool? IsBlockPlayer
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsBlockPlayer);
			}
		}

		// Token: 0x17004708 RID: 18184
		// (get) Token: 0x0600EEC7 RID: 61127 RVA: 0x0023023E File Offset: 0x0022E43E
		[Nullable(2)]
		public virtual string EdTidCountDownTxt
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x0400831E RID: 33566
		private ICommonTip2PrepareCountdown Instance;
	}
}
