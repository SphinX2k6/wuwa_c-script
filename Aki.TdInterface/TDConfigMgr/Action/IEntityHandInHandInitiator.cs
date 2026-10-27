using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A0C RID: 6668
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityHandInHandInitiator : IHandInHandInitiatorType
	{
		// Token: 0x06008ED7 RID: 36567 RVA: 0x0014DDA4 File Offset: 0x0014BFA4
		private IEntityHandInHandInitiator_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityHandInHandInitiator 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityHandInHandInitiator_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityHandInHandInitiator_SetValue());
			}
			return result;
		}

		// Token: 0x06008ED8 RID: 36568 RVA: 0x0014DDDC File Offset: 0x0014BFDC
		public static IEntityHandInHandInitiator Create([Nullable(2)] IEntityHandInHandInitiator instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityHandInHandInitiator
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x0014DDEF File Offset: 0x0014BFEF
		public static IEntityHandInHandInitiator CreateFromSetValue([Nullable(2)] IEntityHandInHandInitiator_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityHandInHandInitiator
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EDA RID: 36570 RVA: 0x0014DE02 File Offset: 0x0014C002
		public new IEntityHandInHandInitiator_SetValue ToSetValue()
		{
			return new IEntityHandInHandInitiator_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x06008EDB RID: 36571 RVA: 0x0014DE21 File Offset: 0x0014C021
		// (set) Token: 0x06008EDC RID: 36572 RVA: 0x0014DE4C File Offset: 0x0014C04C
		public override EHandInHandInitiatorType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHandInHandInitiatorType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x06008EDD RID: 36573 RVA: 0x0014DE5A File Offset: 0x0014C05A
		// (set) Token: 0x06008EDE RID: 36574 RVA: 0x0014DE85 File Offset: 0x0014C085
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

		// Token: 0x04005875 RID: 22645
		[Nullable(2)]
		protected new IEntityHandInHandInitiator FbInstance;

		// Token: 0x04005876 RID: 22646
		[Nullable(2)]
		protected new IEntityHandInHandInitiator_SetValue PocoInterface;
	}
}
