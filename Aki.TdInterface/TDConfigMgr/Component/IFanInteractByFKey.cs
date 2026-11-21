using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003BD RID: 957
	public class IFanInteractByFKey : IFanInteractType
	{
		// Token: 0x060012D3 RID: 4819 RVA: 0x0003E56C File Offset: 0x0003C76C
		private IFanInteractByFKey_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFanInteractByFKey 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFanInteractByFKey_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFanInteractByFKey_SetValue());
			}
			return result;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0003E5A4 File Offset: 0x0003C7A4
		public static IFanInteractByFKey Create([Nullable(2)] IFanInteractByFKey instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanInteractByFKey
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0003E5B7 File Offset: 0x0003C7B7
		public static IFanInteractByFKey CreateFromSetValue([Nullable(2)] IFanInteractByFKey_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFanInteractByFKey
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0003E5CA File Offset: 0x0003C7CA
		public new IFanInteractByFKey_SetValue ToSetValue()
		{
			return new IFanInteractByFKey_SetValue
			{
				Type = this.Type,
				TidInteractOptionText = this.TidInteractOptionText,
				EdTidInteractOptionText = this.EdTidInteractOptionText
			};
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x0003E5F5 File Offset: 0x0003C7F5
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x0003E620 File Offset: 0x0003C820
		public override EFanInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFanInteractType.Hit;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x0003E62E File Offset: 0x0003C82E
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x0003E659 File Offset: 0x0003C859
		public virtual string TidInteractOptionText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidInteractOptionText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidInteractOptionText;
			}
			set
			{
				this.GetOrCreatePoco().TidInteractOptionText = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x0003E667 File Offset: 0x0003C867
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x0003E67E File Offset: 0x0003C87E
		[Nullable(2)]
		public virtual string EdTidInteractOptionText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidInteractOptionText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidInteractOptionText = value;
			}
		}

		// Token: 0x04000F5B RID: 3931
		[Nullable(2)]
		protected new IFanInteractByFKey FbInstance;

		// Token: 0x04000F5C RID: 3932
		[Nullable(2)]
		protected new IFanInteractByFKey_SetValue PocoInterface;
	}
}
