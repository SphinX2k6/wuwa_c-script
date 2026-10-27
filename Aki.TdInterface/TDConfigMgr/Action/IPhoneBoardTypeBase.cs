using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CDC RID: 7388
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhoneBoardTypeBase
	{
		// Token: 0x06009E9D RID: 40605 RVA: 0x0016AB40 File Offset: 0x00168D40
		private IPhoneBoardTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhoneBoardTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhoneBoardTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhoneBoardTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x0016AB78 File Offset: 0x00168D78
		public static IPhoneBoardTypeBase Create([Nullable(2)] IPhoneBoardTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneBoardTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x0016AB8B File Offset: 0x00168D8B
		public static IPhoneBoardTypeBase CreateFromSetValue([Nullable(2)] IPhoneBoardTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhoneBoardTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x0016AB9E File Offset: 0x00168D9E
		public IPhoneBoardTypeBase_SetValue ToSetValue()
		{
			return new IPhoneBoardTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x06009EA1 RID: 40609 RVA: 0x0016ABB1 File Offset: 0x00168DB1
		// (set) Token: 0x06009EA2 RID: 40610 RVA: 0x0016ABDC File Offset: 0x00168DDC
		public virtual EPhoneBoardType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneBoardType.MessageBoard;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005FD6 RID: 24534
		[Nullable(2)]
		protected IPhoneBoardTypeBase FbInstance;

		// Token: 0x04005FD7 RID: 24535
		[Nullable(2)]
		protected IPhoneBoardTypeBase_SetValue PocoInterface;
	}
}
