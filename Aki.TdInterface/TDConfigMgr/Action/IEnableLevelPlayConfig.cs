using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B75 RID: 7029
	public class IEnableLevelPlayConfig
	{
		// Token: 0x06009547 RID: 38215 RVA: 0x0015C134 File Offset: 0x0015A334
		private IEnableLevelPlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableLevelPlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableLevelPlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableLevelPlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009548 RID: 38216 RVA: 0x0015C16C File Offset: 0x0015A36C
		public static IEnableLevelPlayConfig Create([Nullable(2)] IEnableLevelPlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableLevelPlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009549 RID: 38217 RVA: 0x0015C17F File Offset: 0x0015A37F
		public static IEnableLevelPlayConfig CreateFromSetValue([Nullable(2)] IEnableLevelPlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableLevelPlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x0015C192 File Offset: 0x0015A392
		public IEnableLevelPlayConfig_SetValue ToSetValue()
		{
			return new IEnableLevelPlayConfig_SetValue
			{
				LevelPlayId = this.LevelPlayId,
				Enable = this.Enable
			};
		}

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x0600954B RID: 38219 RVA: 0x0015C1B1 File Offset: 0x0015A3B1
		// (set) Token: 0x0600954C RID: 38220 RVA: 0x0015C1DC File Offset: 0x0015A3DC
		public virtual int LevelPlayId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelPlayId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LevelPlayId;
			}
			set
			{
				this.GetOrCreatePoco().LevelPlayId = value;
			}
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x0600954D RID: 38221 RVA: 0x0015C1EA File Offset: 0x0015A3EA
		// (set) Token: 0x0600954E RID: 38222 RVA: 0x0015C215 File Offset: 0x0015A415
		public virtual bool Enable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Enable;
				}
				return this.PocoInterface != null && this.PocoInterface.Enable;
			}
			set
			{
				this.GetOrCreatePoco().Enable = value;
			}
		}

		// Token: 0x04005C73 RID: 23667
		[Nullable(2)]
		protected IEnableLevelPlayConfig FbInstance;

		// Token: 0x04005C74 RID: 23668
		[Nullable(2)]
		protected IEnableLevelPlayConfig_SetValue PocoInterface;
	}
}
