using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002510 RID: 9488
	[NullableContext(2)]
	[Nullable(0)]
	public class IOptionLockTip
	{
		// Token: 0x0600D3A5 RID: 54181 RVA: 0x001F5C8F File Offset: 0x001F3E8F
		[NullableContext(1)]
		public static IOptionLockTip Create(IOptionLockTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOptionLockTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x0600D3A6 RID: 54182 RVA: 0x001F5CAE File Offset: 0x001F3EAE
		public virtual string TidAppendText
		{
			get
			{
				return this.Instance.TidAppendText;
			}
		}

		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x0600D3A7 RID: 54183 RVA: 0x001F5CBB File Offset: 0x001F3EBB
		public virtual string TidHintText
		{
			get
			{
				return this.Instance.TidHintText;
			}
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x0600D3A8 RID: 54184 RVA: 0x001F5CC8 File Offset: 0x001F3EC8
		public virtual int? AppendTextId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AppendTextId);
			}
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x0600D3A9 RID: 54185 RVA: 0x001F5D00 File Offset: 0x001F3F00
		public virtual int? HintTextId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.HintTextId);
			}
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x0600D3AA RID: 54186 RVA: 0x001F5D36 File Offset: 0x001F3F36
		public virtual string EdTidAppendText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x0600D3AB RID: 54187 RVA: 0x001F5D39 File Offset: 0x001F3F39
		public virtual string EdTidHintText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007402 RID: 29698
		private IOptionLockTip Instance;
	}
}
