using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B29 RID: 2857
	public class ResetSelfPosComponent : IComponentBase
	{
		// Token: 0x060041F7 RID: 16887 RVA: 0x000A932C File Offset: 0x000A752C
		[NullableContext(1)]
		public static ResetSelfPosComponent Create(IResetSelfPosComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetSelfPosComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x060041F8 RID: 16888 RVA: 0x000A934C File Offset: 0x000A754C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x060041F9 RID: 16889 RVA: 0x000A9384 File Offset: 0x000A7584
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x060041FA RID: 16890 RVA: 0x000A939A File Offset: 0x000A759A
		public virtual float ResetRadius
		{
			get
			{
				return this.Instance.ResetRadius;
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x060041FB RID: 16891 RVA: 0x000A93A8 File Offset: 0x000A75A8
		public virtual bool? IsDisableResetPosAfterThrow
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDisableResetPosAfterThrow);
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x060041FC RID: 16892 RVA: 0x000A93E0 File Offset: 0x000A75E0
		public virtual bool? IsResetPosAfterThrow
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsResetPosAfterThrow);
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x000A9418 File Offset: 0x000A7618
		public virtual float? ResetPosDelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ResetPosDelayTime);
			}
		}

		// Token: 0x04002540 RID: 9536
		private IResetSelfPosComponent Instance;
	}
}
