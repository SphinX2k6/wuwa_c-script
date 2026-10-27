using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E54 RID: 7764
	[NullableContext(1)]
	[Nullable(0)]
	public class ISheriffReasoning : IUiGame
	{
		// Token: 0x0600A621 RID: 42529 RVA: 0x00178078 File Offset: 0x00176278
		private ISheriffReasoning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISheriffReasoning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISheriffReasoning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISheriffReasoning_SetValue());
			}
			return result;
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x001780B0 File Offset: 0x001762B0
		public static ISheriffReasoning Create([Nullable(2)] ISheriffReasoning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffReasoning
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A623 RID: 42531 RVA: 0x001780C3 File Offset: 0x001762C3
		public static ISheriffReasoning CreateFromSetValue([Nullable(2)] ISheriffReasoning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISheriffReasoning
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A624 RID: 42532 RVA: 0x001780D6 File Offset: 0x001762D6
		public new ISheriffReasoning_SetValue ToSetValue()
		{
			return new ISheriffReasoning_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600A625 RID: 42533 RVA: 0x001780F5 File Offset: 0x001762F5
		// (set) Token: 0x0600A626 RID: 42534 RVA: 0x00178120 File Offset: 0x00176320
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600A627 RID: 42535 RVA: 0x0017812E File Offset: 0x0017632E
		// (set) Token: 0x0600A628 RID: 42536 RVA: 0x00178159 File Offset: 0x00176359
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04006342 RID: 25410
		[Nullable(2)]
		protected new ISheriffReasoning FbInstance;

		// Token: 0x04006343 RID: 25411
		[Nullable(2)]
		protected new ISheriffReasoning_SetValue PocoInterface;
	}
}
