using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007B8 RID: 1976
	public class IStateRepPerfMontagePath : IStateRepPerfBase
	{
		// Token: 0x06002A27 RID: 10791 RVA: 0x0006F030 File Offset: 0x0006D230
		private IStateRepPerfMontagePath_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateRepPerfMontagePath 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateRepPerfMontagePath_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateRepPerfMontagePath_SetValue());
			}
			return result;
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x0006F068 File Offset: 0x0006D268
		public static IStateRepPerfMontagePath Create([Nullable(2)] IStateRepPerfMontagePath instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfMontagePath
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x0006F07B File Offset: 0x0006D27B
		public static IStateRepPerfMontagePath CreateFromSetValue([Nullable(2)] IStateRepPerfMontagePath_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateRepPerfMontagePath
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x0006F08E File Offset: 0x0006D28E
		public new IStateRepPerfMontagePath_SetValue ToSetValue()
		{
			return new IStateRepPerfMontagePath_SetValue
			{
				Type = this.Type,
				MontagePath = this.MontagePath,
				MontageName = this.MontageName
			};
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x0006F0B9 File Offset: 0x0006D2B9
		// (set) Token: 0x06002A2C RID: 10796 RVA: 0x0006F0E4 File Offset: 0x0006D2E4
		public override EStateRepPerfType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStateRepPerfType.SkillId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x0006F0F2 File Offset: 0x0006D2F2
		// (set) Token: 0x06002A2E RID: 10798 RVA: 0x0006F11D File Offset: 0x0006D31D
		public virtual string MontagePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontagePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MontagePath;
			}
			set
			{
				this.GetOrCreatePoco().MontagePath = value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x0006F12B File Offset: 0x0006D32B
		// (set) Token: 0x06002A30 RID: 10800 RVA: 0x0006F156 File Offset: 0x0006D356
		public virtual string MontageName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MontageName;
			}
			set
			{
				this.GetOrCreatePoco().MontageName = value;
			}
		}

		// Token: 0x04001C5A RID: 7258
		[Nullable(2)]
		protected new IStateRepPerfMontagePath FbInstance;

		// Token: 0x04001C5B RID: 7259
		[Nullable(2)]
		protected new IStateRepPerfMontagePath_SetValue PocoInterface;
	}
}
