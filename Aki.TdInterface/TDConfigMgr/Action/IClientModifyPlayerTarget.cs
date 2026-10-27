using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018C0 RID: 6336
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientModifyPlayerTarget : IClientModifyTarget
	{
		// Token: 0x060087F1 RID: 34801 RVA: 0x00141E80 File Offset: 0x00140080
		private IClientModifyPlayerTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientModifyPlayerTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientModifyPlayerTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientModifyPlayerTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x00141EB8 File Offset: 0x001400B8
		public static IClientModifyPlayerTarget Create([Nullable(2)] IClientModifyPlayerTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifyPlayerTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x00141ECB File Offset: 0x001400CB
		public static IClientModifyPlayerTarget CreateFromSetValue([Nullable(2)] IClientModifyPlayerTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientModifyPlayerTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060087F4 RID: 34804 RVA: 0x00141EDE File Offset: 0x001400DE
		public new IClientModifyPlayerTarget_SetValue ToSetValue()
		{
			return new IClientModifyPlayerTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x060087F5 RID: 34805 RVA: 0x00141EF1 File Offset: 0x001400F1
		// (set) Token: 0x060087F6 RID: 34806 RVA: 0x00141F1C File Offset: 0x0014011C
		public override EClientModifyTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientModifyTargetType.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005576 RID: 21878
		[Nullable(2)]
		protected new IClientModifyPlayerTarget FbInstance;

		// Token: 0x04005577 RID: 21879
		[Nullable(2)]
		protected new IClientModifyPlayerTarget_SetValue PocoInterface;
	}
}
