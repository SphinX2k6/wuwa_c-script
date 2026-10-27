using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C5 RID: 8645
	[NullableContext(1)]
	[Nullable(0)]
	public class SetMoveSpeed : ActionParams
	{
		// Token: 0x0600BDDA RID: 48602 RVA: 0x001B5340 File Offset: 0x001B3540
		private SetMoveSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetMoveSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetMoveSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetMoveSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDDB RID: 48603 RVA: 0x001B5378 File Offset: 0x001B3578
		public static SetMoveSpeed Create([Nullable(2)] SetMoveSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetMoveSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDDC RID: 48604 RVA: 0x001B538B File Offset: 0x001B358B
		public static SetMoveSpeed CreateFromSetValue([Nullable(2)] SetMoveSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetMoveSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDDD RID: 48605 RVA: 0x001B539E File Offset: 0x001B359E
		public SetMoveSpeed_SetValue ToSetValue()
		{
			return new SetMoveSpeed_SetValue
			{
				Speed = this.Speed
			};
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x0600BDDE RID: 48606 RVA: 0x001B53B1 File Offset: 0x001B35B1
		// (set) Token: 0x0600BDDF RID: 48607 RVA: 0x001B53E0 File Offset: 0x001B35E0
		public virtual float Speed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Speed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Speed;
			}
			set
			{
				this.GetOrCreatePoco().Speed = value;
			}
		}

		// Token: 0x04007151 RID: 29009
		[Nullable(2)]
		protected new SetMoveSpeed FbInstance;

		// Token: 0x04007152 RID: 29010
		[Nullable(2)]
		protected SetMoveSpeed_SetValue PocoInterface;
	}
}
