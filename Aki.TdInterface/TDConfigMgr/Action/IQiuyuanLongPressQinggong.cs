using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D6A RID: 7530
	[NullableContext(1)]
	[Nullable(0)]
	public class IQiuyuanLongPressQinggong : ILeisureInteractType
	{
		// Token: 0x0600A179 RID: 41337 RVA: 0x0016FCD4 File Offset: 0x0016DED4
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

		// Token: 0x0600A17A RID: 41338 RVA: 0x0016FD0C File Offset: 0x0016DF0C
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

		// Token: 0x0600A17B RID: 41339 RVA: 0x0016FD1F File Offset: 0x0016DF1F
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

		// Token: 0x0600A17C RID: 41340 RVA: 0x0016FD32 File Offset: 0x0016DF32
		public new IQiuyuanLongPressQinggong_SetValue ToSetValue()
		{
			return new IQiuyuanLongPressQinggong_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600A17D RID: 41341 RVA: 0x0016FD45 File Offset: 0x0016DF45
		// (set) Token: 0x0600A17E RID: 41342 RVA: 0x0016FD70 File Offset: 0x0016DF70
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

		// Token: 0x04006127 RID: 24871
		[Nullable(2)]
		protected new IQiuyuanLongPressQinggong FbInstance;

		// Token: 0x04006128 RID: 24872
		[Nullable(2)]
		protected new IQiuyuanLongPressQinggong_SetValue PocoInterface;
	}
}
