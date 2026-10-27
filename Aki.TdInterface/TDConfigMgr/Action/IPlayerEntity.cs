using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D00 RID: 7424
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayerEntity : ITargetEntityType
	{
		// Token: 0x06009F5D RID: 40797 RVA: 0x0016C1CC File Offset: 0x0016A3CC
		private IPlayerEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06009F5E RID: 40798 RVA: 0x0016C204 File Offset: 0x0016A404
		public static IPlayerEntity Create([Nullable(2)] IPlayerEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x0016C217 File Offset: 0x0016A417
		public static IPlayerEntity CreateFromSetValue([Nullable(2)] IPlayerEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F60 RID: 40800 RVA: 0x0016C22A File Offset: 0x0016A42A
		public new IPlayerEntity_SetValue ToSetValue()
		{
			return new IPlayerEntity_SetValue
			{
				Type = this.Type,
				PlayerTargetType = this.PlayerTargetType
			};
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x06009F61 RID: 40801 RVA: 0x0016C249 File Offset: 0x0016A449
		// (set) Token: 0x06009F62 RID: 40802 RVA: 0x0016C274 File Offset: 0x0016A474
		public override ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x06009F63 RID: 40803 RVA: 0x0016C284 File Offset: 0x0016A484
		// (set) Token: 0x06009F64 RID: 40804 RVA: 0x0016C2BE File Offset: 0x0016A4BE
		public virtual EPlayerTargetType? PlayerTargetType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerTargetType;
				}
				IPlayerEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayerTargetType;
			}
			set
			{
				this.GetOrCreatePoco().PlayerTargetType = value;
			}
		}

		// Token: 0x04006034 RID: 24628
		[Nullable(2)]
		protected new IPlayerEntity FbInstance;

		// Token: 0x04006035 RID: 24629
		[Nullable(2)]
		protected new IPlayerEntity_SetValue PocoInterface;
	}
}
