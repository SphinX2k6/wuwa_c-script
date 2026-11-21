using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200162F RID: 5679
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeInteractOptionText : ActionParams
	{
		// Token: 0x0600803B RID: 32827 RVA: 0x001316BC File Offset: 0x0012F8BC
		[NullableContext(0)]
		private ChangeInteractOptionText_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeInteractOptionText 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeInteractOptionText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeInteractOptionText_SetValue());
			}
			return result;
		}

		// Token: 0x0600803C RID: 32828 RVA: 0x001316F4 File Offset: 0x0012F8F4
		[NullableContext(0)]
		public static ChangeInteractOptionText Create([Nullable(2)] ChangeInteractOptionText instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeInteractOptionText
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600803D RID: 32829 RVA: 0x00131707 File Offset: 0x0012F907
		[NullableContext(0)]
		public static ChangeInteractOptionText CreateFromSetValue([Nullable(2)] ChangeInteractOptionText_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeInteractOptionText
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x0013171A File Offset: 0x0012F91A
		[NullableContext(0)]
		public ChangeInteractOptionText_SetValue ToSetValue()
		{
			return new ChangeInteractOptionText_SetValue
			{
				TidContent = this.TidContent,
				EdTidContent = this.EdTidContent
			};
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x0600803F RID: 32831 RVA: 0x00131739 File Offset: 0x0012F939
		// (set) Token: 0x06008040 RID: 32832 RVA: 0x00131760 File Offset: 0x0012F960
		public virtual string TidContent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidContent;
				}
				ChangeInteractOptionText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidContent;
			}
			set
			{
				this.GetOrCreatePoco().TidContent = value;
			}
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x06008041 RID: 32833 RVA: 0x0013176E File Offset: 0x0012F96E
		// (set) Token: 0x06008042 RID: 32834 RVA: 0x00131785 File Offset: 0x0012F985
		public virtual string EdTidContent
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidContent;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidContent = value;
			}
		}

		// Token: 0x04004A14 RID: 18964
		protected new ChangeInteractOptionText FbInstance;

		// Token: 0x04004A15 RID: 18965
		protected ChangeInteractOptionText_SetValue PocoInterface;
	}
}
