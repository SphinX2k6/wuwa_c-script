using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA8 RID: 7080
	[NullableContext(1)]
	[Nullable(0)]
	public class ILongPressInteractStyleCoreFix : ILongPressInteractStyleConfig
	{
		// Token: 0x060097A1 RID: 38817 RVA: 0x0015DB8C File Offset: 0x0015BD8C
		private ILongPressInteractStyleCoreFix_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressInteractStyleCoreFix 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressInteractStyleCoreFix_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressInteractStyleCoreFix_SetValue());
			}
			return result;
		}

		// Token: 0x060097A2 RID: 38818 RVA: 0x0015DBC4 File Offset: 0x0015BDC4
		public static ILongPressInteractStyleCoreFix Create([Nullable(2)] ILongPressInteractStyleCoreFix instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleCoreFix
			{
				FbInstance = instance
			};
		}

		// Token: 0x060097A3 RID: 38819 RVA: 0x0015DBD7 File Offset: 0x0015BDD7
		public static ILongPressInteractStyleCoreFix CreateFromSetValue([Nullable(2)] ILongPressInteractStyleCoreFix_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressInteractStyleCoreFix
			{
				PocoInterface = value
			};
		}

		// Token: 0x060097A4 RID: 38820 RVA: 0x0015DBEA File Offset: 0x0015BDEA
		public new ILongPressInteractStyleCoreFix_SetValue ToSetValue()
		{
			return new ILongPressInteractStyleCoreFix_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x060097A5 RID: 38821 RVA: 0x0015DBFD File Offset: 0x0015BDFD
		// (set) Token: 0x060097A6 RID: 38822 RVA: 0x0015DC28 File Offset: 0x0015BE28
		public override ELongPressInteractStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELongPressInteractStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C8C RID: 23692
		[Nullable(2)]
		protected new ILongPressInteractStyleCoreFix FbInstance;

		// Token: 0x04005C8D RID: 23693
		[Nullable(2)]
		protected new ILongPressInteractStyleCoreFix_SetValue PocoInterface;
	}
}
