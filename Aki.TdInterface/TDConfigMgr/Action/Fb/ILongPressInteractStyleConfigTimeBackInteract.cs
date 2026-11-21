using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D4 RID: 10452
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressInteractStyleConfigTimeBackInteract : ILongPressInteractStyleConfig
	{
		// Token: 0x0600E8A2 RID: 59554 RVA: 0x00225F51 File Offset: 0x00224151
		[NullableContext(0)]
		public static ILongPressInteractStyleConfigTimeBackInteract Create(ILongPressInteractStyleConfigTimeBackInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigTimeBackInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043A8 RID: 17320
		// (get) Token: 0x0600E8A3 RID: 59555 RVA: 0x00225F70 File Offset: 0x00224170
		public override ELongPressInteractStyle Type
		{
			get
			{
				return (ELongPressInteractStyle)this.Instance.Type;
			}
		}

		// Token: 0x170043A9 RID: 17321
		// (get) Token: 0x0600E8A4 RID: 59556 RVA: 0x00225F7D File Offset: 0x0022417D
		public virtual string TidContent
		{
			get
			{
				return this.Instance.TidContent;
			}
		}

		// Token: 0x170043AA RID: 17322
		// (get) Token: 0x0600E8A5 RID: 59557 RVA: 0x00225F8C File Offset: 0x0022418C
		public virtual float? StartProgress
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StartProgress);
			}
		}

		// Token: 0x170043AB RID: 17323
		// (get) Token: 0x0600E8A6 RID: 59558 RVA: 0x00225FC2 File Offset: 0x002241C2
		public virtual string EdTidContent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04008024 RID: 32804
		private ILongPressInteractStyleConfigTimeBackInteract Instance;
	}
}
