using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BAA RID: 7082
	[NullableContext(1)]
	[Nullable(0)]
	public class ILongPressInteractStyleSwordRider : ILongPressInteractStyleConfig
	{
		// Token: 0x060097A9 RID: 38825 RVA: 0x0015DC48 File Offset: 0x0015BE48
		private ILongPressInteractStyleSwordRider_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressInteractStyleSwordRider 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressInteractStyleSwordRider_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressInteractStyleSwordRider_SetValue());
			}
			return result;
		}

		// Token: 0x060097AA RID: 38826 RVA: 0x0015DC80 File Offset: 0x0015BE80
		public static ILongPressInteractStyleSwordRider Create([Nullable(2)] ILongPressInteractStyleSwordRider instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleSwordRider
			{
				FbInstance = instance
			};
		}

		// Token: 0x060097AB RID: 38827 RVA: 0x0015DC93 File Offset: 0x0015BE93
		public static ILongPressInteractStyleSwordRider CreateFromSetValue([Nullable(2)] ILongPressInteractStyleSwordRider_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressInteractStyleSwordRider
			{
				PocoInterface = value
			};
		}

		// Token: 0x060097AC RID: 38828 RVA: 0x0015DCA6 File Offset: 0x0015BEA6
		public new ILongPressInteractStyleSwordRider_SetValue ToSetValue()
		{
			return new ILongPressInteractStyleSwordRider_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x060097AD RID: 38829 RVA: 0x0015DCB9 File Offset: 0x0015BEB9
		// (set) Token: 0x060097AE RID: 38830 RVA: 0x0015DCE4 File Offset: 0x0015BEE4
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

		// Token: 0x04005C8F RID: 23695
		[Nullable(2)]
		protected new ILongPressInteractStyleSwordRider FbInstance;

		// Token: 0x04005C90 RID: 23696
		[Nullable(2)]
		protected new ILongPressInteractStyleSwordRider_SetValue PocoInterface;
	}
}
