using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002025 RID: 8229
	public class ISelfEntity : ITargetEntityType
	{
		// Token: 0x0600AEB7 RID: 44727 RVA: 0x00189D58 File Offset: 0x00187F58
		private ISelfEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISelfEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISelfEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISelfEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600AEB8 RID: 44728 RVA: 0x00189D90 File Offset: 0x00187F90
		public static ISelfEntity Create([Nullable(2)] ISelfEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AEB9 RID: 44729 RVA: 0x00189DA3 File Offset: 0x00187FA3
		public static ISelfEntity CreateFromSetValue([Nullable(2)] ISelfEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISelfEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AEBA RID: 44730 RVA: 0x00189DB6 File Offset: 0x00187FB6
		public new ISelfEntity_SetValue ToSetValue()
		{
			return new ISelfEntity_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x0600AEBB RID: 44731 RVA: 0x00189DC9 File Offset: 0x00187FC9
		// (set) Token: 0x0600AEBC RID: 44732 RVA: 0x00189DF4 File Offset: 0x00187FF4
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

		// Token: 0x0400681D RID: 26653
		[Nullable(2)]
		protected new ISelfEntity FbInstance;

		// Token: 0x0400681E RID: 26654
		[Nullable(2)]
		protected new ISelfEntity_SetValue PocoInterface;
	}
}
