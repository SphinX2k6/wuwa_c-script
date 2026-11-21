using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200038C RID: 908
	public class IExhibitItemType
	{
		// Token: 0x060011C0 RID: 4544 RVA: 0x0003C2D4 File Offset: 0x0003A4D4
		private IExhibitItemType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExhibitItemType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExhibitItemType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExhibitItemType_SetValue());
			}
			return result;
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0003C30C File Offset: 0x0003A50C
		public static IExhibitItemType Create([Nullable(2)] IExhibitItemType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExhibitItemType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0003C31F File Offset: 0x0003A51F
		public static IExhibitItemType CreateFromSetValue([Nullable(2)] IExhibitItemType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExhibitItemType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0003C332 File Offset: 0x0003A532
		public IExhibitItemType_SetValue ToSetValue()
		{
			return new IExhibitItemType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0003C345 File Offset: 0x0003A545
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x0003C370 File Offset: 0x0003A570
		public virtual EExhibitItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExhibitItemType.Phantom;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000ECE RID: 3790
		[Nullable(2)]
		protected IExhibitItemType FbInstance;

		// Token: 0x04000ECF RID: 3791
		[Nullable(2)]
		protected IExhibitItemType_SetValue PocoInterface;
	}
}
