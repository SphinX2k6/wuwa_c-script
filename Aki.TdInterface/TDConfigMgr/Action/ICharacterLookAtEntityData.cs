using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001884 RID: 6276
	[NullableContext(1)]
	[Nullable(0)]
	public class ICharacterLookAtEntityData : ICharacterLookAtData
	{
		// Token: 0x060086D1 RID: 34513 RVA: 0x0013FFD8 File Offset: 0x0013E1D8
		private ICharacterLookAtEntityData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterLookAtEntityData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterLookAtEntityData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterLookAtEntityData_SetValue());
			}
			return result;
		}

		// Token: 0x060086D2 RID: 34514 RVA: 0x00140010 File Offset: 0x0013E210
		public static ICharacterLookAtEntityData Create([Nullable(2)] ICharacterLookAtEntityData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtEntityData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060086D3 RID: 34515 RVA: 0x00140023 File Offset: 0x0013E223
		public static ICharacterLookAtEntityData CreateFromSetValue([Nullable(2)] ICharacterLookAtEntityData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterLookAtEntityData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060086D4 RID: 34516 RVA: 0x00140036 File Offset: 0x0013E236
		public new ICharacterLookAtEntityData_SetValue ToSetValue()
		{
			return new ICharacterLookAtEntityData_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x060086D5 RID: 34517 RVA: 0x00140055 File Offset: 0x0013E255
		// (set) Token: 0x060086D6 RID: 34518 RVA: 0x00140080 File Offset: 0x0013E280
		public override ECharacterLookAt Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECharacterLookAt.Empty;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x060086D7 RID: 34519 RVA: 0x0014008E File Offset: 0x0013E28E
		// (set) Token: 0x060086D8 RID: 34520 RVA: 0x001400B9 File Offset: 0x0013E2B9
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x040054F4 RID: 21748
		[Nullable(2)]
		protected new ICharacterLookAtEntityData FbInstance;

		// Token: 0x040054F5 RID: 21749
		[Nullable(2)]
		protected new ICharacterLookAtEntityData_SetValue PocoInterface;
	}
}
