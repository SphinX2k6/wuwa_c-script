using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BD8 RID: 7128
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechStuntLevelFly : IMechStuntConfigType
	{
		// Token: 0x060098B1 RID: 39089 RVA: 0x0015FCD8 File Offset: 0x0015DED8
		private IMechStuntLevelFly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntLevelFly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntLevelFly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntLevelFly_SetValue());
			}
			return result;
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x0015FD10 File Offset: 0x0015DF10
		public static IMechStuntLevelFly Create([Nullable(2)] IMechStuntLevelFly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntLevelFly
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x0015FD23 File Offset: 0x0015DF23
		public static IMechStuntLevelFly CreateFromSetValue([Nullable(2)] IMechStuntLevelFly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntLevelFly
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x0015FD36 File Offset: 0x0015DF36
		public new IMechStuntLevelFly_SetValue ToSetValue()
		{
			return new IMechStuntLevelFly_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x060098B5 RID: 39093 RVA: 0x0015FD49 File Offset: 0x0015DF49
		// (set) Token: 0x060098B6 RID: 39094 RVA: 0x0015FD74 File Offset: 0x0015DF74
		public override EMechStuntType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechStuntType.Dive;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D16 RID: 23830
		[Nullable(2)]
		protected new IMechStuntLevelFly FbInstance;

		// Token: 0x04005D17 RID: 23831
		[Nullable(2)]
		protected new IMechStuntLevelFly_SetValue PocoInterface;
	}
}
