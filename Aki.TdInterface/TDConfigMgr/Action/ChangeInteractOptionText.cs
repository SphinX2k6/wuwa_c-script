using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014D6 RID: 5334
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeInteractOptionText : ActionParams
	{
		// Token: 0x0600796E RID: 31086 RVA: 0x00122A70 File Offset: 0x00120C70
		[NullableContext(1)]
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

		// Token: 0x0600796F RID: 31087 RVA: 0x00122AA8 File Offset: 0x00120CA8
		[NullableContext(1)]
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

		// Token: 0x06007970 RID: 31088 RVA: 0x00122ABB File Offset: 0x00120CBB
		[NullableContext(1)]
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

		// Token: 0x06007971 RID: 31089 RVA: 0x00122ACE File Offset: 0x00120CCE
		[NullableContext(1)]
		public ChangeInteractOptionText_SetValue ToSetValue()
		{
			return new ChangeInteractOptionText_SetValue
			{
				TidContent = this.TidContent,
				EdTidContent = this.EdTidContent
			};
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x06007972 RID: 31090 RVA: 0x00122AED File Offset: 0x00120CED
		// (set) Token: 0x06007973 RID: 31091 RVA: 0x00122B14 File Offset: 0x00120D14
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

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x06007974 RID: 31092 RVA: 0x00122B22 File Offset: 0x00120D22
		// (set) Token: 0x06007975 RID: 31093 RVA: 0x00122B39 File Offset: 0x00120D39
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

		// Token: 0x04004679 RID: 18041
		protected new ChangeInteractOptionText FbInstance;

		// Token: 0x0400467A RID: 18042
		protected ChangeInteractOptionText_SetValue PocoInterface;
	}
}
