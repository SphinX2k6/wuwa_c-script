using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FA6 RID: 8102
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionType
	{
		// Token: 0x0600B22E RID: 45614 RVA: 0x0019F57C File Offset: 0x0019D77C
		private ITeleportTransitionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B22F RID: 45615 RVA: 0x0019F5B4 File Offset: 0x0019D7B4
		public static ITeleportTransitionType Create([Nullable(2)] ITeleportTransitionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B230 RID: 45616 RVA: 0x0019F5C7 File Offset: 0x0019D7C7
		public static ITeleportTransitionType CreateFromSetValue([Nullable(2)] ITeleportTransitionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B231 RID: 45617 RVA: 0x0019F5DA File Offset: 0x0019D7DA
		public ITeleportTransitionType_SetValue ToSetValue()
		{
			return new ITeleportTransitionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x0600B232 RID: 45618 RVA: 0x0019F5ED File Offset: 0x0019D7ED
		// (set) Token: 0x0600B233 RID: 45619 RVA: 0x0019F618 File Offset: 0x0019D818
		public virtual ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B9F RID: 27551
		[Nullable(2)]
		protected ITeleportTransitionType FbInstance;

		// Token: 0x04006BA0 RID: 27552
		[Nullable(2)]
		protected ITeleportTransitionType_SetValue PocoInterface;
	}
}
