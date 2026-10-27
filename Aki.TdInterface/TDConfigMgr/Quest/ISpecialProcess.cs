using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001146 RID: 4422
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpecialProcess
	{
		// Token: 0x06006462 RID: 25698 RVA: 0x000F15A4 File Offset: 0x000EF7A4
		private ISpecialProcess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpecialProcess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpecialProcess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpecialProcess_SetValue());
			}
			return result;
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x000F15DC File Offset: 0x000EF7DC
		public static ISpecialProcess Create([Nullable(2)] ISpecialProcess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialProcess
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x000F15EF File Offset: 0x000EF7EF
		public static ISpecialProcess CreateFromSetValue([Nullable(2)] ISpecialProcess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpecialProcess
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x000F1602 File Offset: 0x000EF802
		public ISpecialProcess_SetValue ToSetValue()
		{
			return new ISpecialProcess_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06006466 RID: 25702 RVA: 0x000F1615 File Offset: 0x000EF815
		// (set) Token: 0x06006467 RID: 25703 RVA: 0x000F1640 File Offset: 0x000EF840
		public virtual ESpecialProcess Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialProcess.LowMemorySceneSwitch;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003C50 RID: 15440
		[Nullable(2)]
		protected ISpecialProcess FbInstance;

		// Token: 0x04003C51 RID: 15441
		[Nullable(2)]
		protected ISpecialProcess_SetValue PocoInterface;
	}
}
