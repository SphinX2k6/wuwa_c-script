using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F7B RID: 8059
	public class IQiuyuanLongPressQinggong : ILeisureInteractType
	{
		// Token: 0x0600AB65 RID: 43877 RVA: 0x001840F8 File Offset: 0x001822F8
		private IQiuyuanLongPressQinggong_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanLongPressQinggong 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanLongPressQinggong_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanLongPressQinggong_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB66 RID: 43878 RVA: 0x00184130 File Offset: 0x00182330
		public static IQiuyuanLongPressQinggong Create([Nullable(2)] IQiuyuanLongPressQinggong instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanLongPressQinggong
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB67 RID: 43879 RVA: 0x00184143 File Offset: 0x00182343
		public static IQiuyuanLongPressQinggong CreateFromSetValue([Nullable(2)] IQiuyuanLongPressQinggong_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanLongPressQinggong
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB68 RID: 43880 RVA: 0x00184156 File Offset: 0x00182356
		public new IQiuyuanLongPressQinggong_SetValue ToSetValue()
		{
			return new IQiuyuanLongPressQinggong_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600AB69 RID: 43881 RVA: 0x00184169 File Offset: 0x00182369
		// (set) Token: 0x0600AB6A RID: 43882 RVA: 0x00184194 File Offset: 0x00182394
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040066A3 RID: 26275
		[Nullable(2)]
		protected new IQiuyuanLongPressQinggong FbInstance;

		// Token: 0x040066A4 RID: 26276
		[Nullable(2)]
		protected new IQiuyuanLongPressQinggong_SetValue PocoInterface;
	}
}
