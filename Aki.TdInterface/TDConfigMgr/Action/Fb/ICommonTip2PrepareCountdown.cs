using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002764 RID: 10084
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTip2PrepareCountdown : ICommonTip2Type
	{
		// Token: 0x0600E0A3 RID: 57507 RVA: 0x002133F6 File Offset: 0x002115F6
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

		// Token: 0x1700439D RID: 17309
		// (get) Token: 0x0600E0A4 RID: 57508 RVA: 0x00213415 File Offset: 0x00211615
		public override ECommonTip2Type Type
		{
			get
			{
				return (ECommonTip2Type)this.Instance.Type;
			}
		}

		// Token: 0x1700439E RID: 17310
		// (get) Token: 0x0600E0A5 RID: 57509 RVA: 0x00213422 File Offset: 0x00211622
		public virtual int CountDownNum
		{
			get
			{
				return this.Instance.CountDownNum;
			}
		}

		// Token: 0x1700439F RID: 17311
		// (get) Token: 0x0600E0A6 RID: 57510 RVA: 0x0021342F File Offset: 0x0021162F
		public virtual string TidCountDownTxt
		{
			get
			{
				return this.Instance.TidCountDownTxt;
			}
		}

		// Token: 0x170043A0 RID: 17312
		// (get) Token: 0x0600E0A7 RID: 57511 RVA: 0x0021343C File Offset: 0x0021163C
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

		// Token: 0x170043A1 RID: 17313
		// (get) Token: 0x0600E0A8 RID: 57512 RVA: 0x00213474 File Offset: 0x00211674
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

		// Token: 0x170043A2 RID: 17314
		// (get) Token: 0x0600E0A9 RID: 57513 RVA: 0x002134AA File Offset: 0x002116AA
		[Nullable(2)]
		public virtual string EdTidCountDownTxt
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C68 RID: 31848
		private ICommonTip2PrepareCountdown Instance;
	}
}
