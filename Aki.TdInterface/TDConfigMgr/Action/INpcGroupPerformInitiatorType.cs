using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C6A RID: 7274
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcGroupPerformInitiatorType
	{
		// Token: 0x06009C03 RID: 39939 RVA: 0x0016608C File Offset: 0x0016428C
		private INpcGroupPerformInitiatorType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcGroupPerformInitiatorType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcGroupPerformInitiatorType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcGroupPerformInitiatorType_SetValue());
			}
			return result;
		}

		// Token: 0x06009C04 RID: 39940 RVA: 0x001660C4 File Offset: 0x001642C4
		public static INpcGroupPerformInitiatorType Create([Nullable(2)] INpcGroupPerformInitiatorType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupPerformInitiatorType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C05 RID: 39941 RVA: 0x001660D7 File Offset: 0x001642D7
		public static INpcGroupPerformInitiatorType CreateFromSetValue([Nullable(2)] INpcGroupPerformInitiatorType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcGroupPerformInitiatorType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C06 RID: 39942 RVA: 0x001660EA File Offset: 0x001642EA
		public INpcGroupPerformInitiatorType_SetValue ToSetValue()
		{
			return new INpcGroupPerformInitiatorType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x06009C07 RID: 39943 RVA: 0x001660FD File Offset: 0x001642FD
		// (set) Token: 0x06009C08 RID: 39944 RVA: 0x00166128 File Offset: 0x00164328
		public virtual ENpcGroupPerformInitiatorType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformInitiatorType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005EAC RID: 24236
		[Nullable(2)]
		protected INpcGroupPerformInitiatorType FbInstance;

		// Token: 0x04005EAD RID: 24237
		[Nullable(2)]
		protected INpcGroupPerformInitiatorType_SetValue PocoInterface;
	}
}
