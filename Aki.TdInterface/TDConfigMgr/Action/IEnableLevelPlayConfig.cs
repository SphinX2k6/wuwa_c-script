using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019E6 RID: 6630
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnableLevelPlayConfig
	{
		// Token: 0x06008DFB RID: 36347 RVA: 0x0014C528 File Offset: 0x0014A728
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

		// Token: 0x06008DFC RID: 36348 RVA: 0x0014C560 File Offset: 0x0014A760
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

		// Token: 0x06008DFD RID: 36349 RVA: 0x0014C573 File Offset: 0x0014A773
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

		// Token: 0x06008DFE RID: 36350 RVA: 0x0014C586 File Offset: 0x0014A786
		public IEnableLevelPlayConfig_SetValue ToSetValue()
		{
			return new IEnableLevelPlayConfig_SetValue
			{
				LevelPlayId = this.LevelPlayId,
				Enable = this.Enable
			};
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x06008DFF RID: 36351 RVA: 0x0014C5A5 File Offset: 0x0014A7A5
		// (set) Token: 0x06008E00 RID: 36352 RVA: 0x0014C5D0 File Offset: 0x0014A7D0
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

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x06008E01 RID: 36353 RVA: 0x0014C5DE File Offset: 0x0014A7DE
		// (set) Token: 0x06008E02 RID: 36354 RVA: 0x0014C609 File Offset: 0x0014A809
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

		// Token: 0x0400581A RID: 22554
		[Nullable(2)]
		protected IEnableLevelPlayConfig FbInstance;

		// Token: 0x0400581B RID: 22555
		[Nullable(2)]
		protected IEnableLevelPlayConfig_SetValue PocoInterface;
	}
}
