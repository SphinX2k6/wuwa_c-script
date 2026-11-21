using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D4 RID: 724
	public class ICreateBulletDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x06000D5D RID: 3421 RVA: 0x00032A78 File Offset: 0x00030C78
		private ICreateBulletDestroyCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICreateBulletDestroyCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICreateBulletDestroyCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICreateBulletDestroyCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00032AB0 File Offset: 0x00030CB0
		public static ICreateBulletDestroyCondition Create([Nullable(2)] ICreateBulletDestroyCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreateBulletDestroyCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00032AC3 File Offset: 0x00030CC3
		public static ICreateBulletDestroyCondition CreateFromSetValue([Nullable(2)] ICreateBulletDestroyCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICreateBulletDestroyCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00032AD6 File Offset: 0x00030CD6
		public new ICreateBulletDestroyCondition_SetValue ToSetValue()
		{
			return new ICreateBulletDestroyCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x00032AE9 File Offset: 0x00030CE9
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x00032B14 File Offset: 0x00030D14
		public override ETeleControlDestroyCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleControlDestroyCondition.LetGo;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000C77 RID: 3191
		[Nullable(2)]
		protected new ICreateBulletDestroyCondition FbInstance;

		// Token: 0x04000C78 RID: 3192
		[Nullable(2)]
		protected new ICreateBulletDestroyCondition_SetValue PocoInterface;
	}
}
