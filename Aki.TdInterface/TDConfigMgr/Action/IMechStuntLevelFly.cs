using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DC1 RID: 7617
	public class IMechStuntLevelFly : IMechStuntConfigType
	{
		// Token: 0x0600A1BF RID: 41407 RVA: 0x00172898 File Offset: 0x00170A98
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

		// Token: 0x0600A1C0 RID: 41408 RVA: 0x001728D0 File Offset: 0x00170AD0
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

		// Token: 0x0600A1C1 RID: 41409 RVA: 0x001728E3 File Offset: 0x00170AE3
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

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x001728F6 File Offset: 0x00170AF6
		public new IMechStuntLevelFly_SetValue ToSetValue()
		{
			return new IMechStuntLevelFly_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600A1C3 RID: 41411 RVA: 0x00172909 File Offset: 0x00170B09
		// (set) Token: 0x0600A1C4 RID: 41412 RVA: 0x00172934 File Offset: 0x00170B34
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

		// Token: 0x0400622F RID: 25135
		[Nullable(2)]
		protected new IMechStuntLevelFly FbInstance;

		// Token: 0x04006230 RID: 25136
		[Nullable(2)]
		protected new IMechStuntLevelFly_SetValue PocoInterface;
	}
}
