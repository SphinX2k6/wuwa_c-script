using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EF2 RID: 3826
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckPlayerInputBase
	{
		// Token: 0x0600546C RID: 21612 RVA: 0x000CF49C File Offset: 0x000CD69C
		private ICheckPlayerInputBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckPlayerInputBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckPlayerInputBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckPlayerInputBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x000CF4D4 File Offset: 0x000CD6D4
		public static ICheckPlayerInputBase Create([Nullable(2)] ICheckPlayerInputBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckPlayerInputBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x000CF4E7 File Offset: 0x000CD6E7
		public static ICheckPlayerInputBase CreateFromSetValue([Nullable(2)] ICheckPlayerInputBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckPlayerInputBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x000CF4FA File Offset: 0x000CD6FA
		public ICheckPlayerInputBase_SetValue ToSetValue()
		{
			return new ICheckPlayerInputBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06005470 RID: 21616 RVA: 0x000CF50D File Offset: 0x000CD70D
		// (set) Token: 0x06005471 RID: 21617 RVA: 0x000CF538 File Offset: 0x000CD738
		public virtual ECheckPlayerInputType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECheckPlayerInputType.PressButton;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003325 RID: 13093
		[Nullable(2)]
		protected ICheckPlayerInputBase FbInstance;

		// Token: 0x04003326 RID: 13094
		[Nullable(2)]
		protected ICheckPlayerInputBase_SetValue PocoInterface;
	}
}
