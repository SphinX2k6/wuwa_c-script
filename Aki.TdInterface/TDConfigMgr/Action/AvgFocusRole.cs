using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014A1 RID: 5281
	[NullableContext(1)]
	[Nullable(0)]
	public class AvgFocusRole : ActionParams
	{
		// Token: 0x06007842 RID: 30786 RVA: 0x00120694 File Offset: 0x0011E894
		private AvgFocusRole_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AvgFocusRole 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AvgFocusRole_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AvgFocusRole_SetValue());
			}
			return result;
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x001206CC File Offset: 0x0011E8CC
		public static AvgFocusRole Create([Nullable(2)] AvgFocusRole instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgFocusRole
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x001206DF File Offset: 0x0011E8DF
		public static AvgFocusRole CreateFromSetValue([Nullable(2)] AvgFocusRole_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AvgFocusRole
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x001206F2 File Offset: 0x0011E8F2
		public AvgFocusRole_SetValue ToSetValue()
		{
			return new AvgFocusRole_SetValue
			{
				IsFocus = this.IsFocus
			};
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x06007846 RID: 30790 RVA: 0x00120705 File Offset: 0x0011E905
		// (set) Token: 0x06007847 RID: 30791 RVA: 0x00120730 File Offset: 0x0011E930
		public virtual bool IsFocus
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFocus;
				}
				return this.PocoInterface != null && this.PocoInterface.IsFocus;
			}
			set
			{
				this.GetOrCreatePoco().IsFocus = value;
			}
		}

		// Token: 0x040045E7 RID: 17895
		[Nullable(2)]
		protected new AvgFocusRole FbInstance;

		// Token: 0x040045E8 RID: 17896
		[Nullable(2)]
		protected AvgFocusRole_SetValue PocoInterface;
	}
}
