using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D91 RID: 7569
	public class ILongPressInteractStyleSwordRider : ILongPressInteractStyleConfig
	{
		// Token: 0x0600A0AD RID: 41133 RVA: 0x00170708 File Offset: 0x0016E908
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

		// Token: 0x0600A0AE RID: 41134 RVA: 0x00170740 File Offset: 0x0016E940
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

		// Token: 0x0600A0AF RID: 41135 RVA: 0x00170753 File Offset: 0x0016E953
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

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x00170766 File Offset: 0x0016E966
		public new ILongPressInteractStyleSwordRider_SetValue ToSetValue()
		{
			return new ILongPressInteractStyleSwordRider_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600A0B1 RID: 41137 RVA: 0x00170779 File Offset: 0x0016E979
		// (set) Token: 0x0600A0B2 RID: 41138 RVA: 0x001707A4 File Offset: 0x0016E9A4
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

		// Token: 0x040061A4 RID: 24996
		[Nullable(2)]
		protected new ILongPressInteractStyleSwordRider FbInstance;

		// Token: 0x040061A5 RID: 24997
		[Nullable(2)]
		protected new ILongPressInteractStyleSwordRider_SetValue PocoInterface;
	}
}
