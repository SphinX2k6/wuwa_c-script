using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F39 RID: 7993
	public class IPlotConfig
	{
		// Token: 0x0600AA19 RID: 43545 RVA: 0x00181D64 File Offset: 0x0017FF64
		private IPlotConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlotConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlotConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlotConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x00181D9C File Offset: 0x0017FF9C
		public static IPlotConfig Create([Nullable(2)] IPlotConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA1B RID: 43547 RVA: 0x00181DAF File Offset: 0x0017FFAF
		public static IPlotConfig CreateFromSetValue([Nullable(2)] IPlotConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlotConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x00181DC2 File Offset: 0x0017FFC2
		public IPlotConfig_SetValue ToSetValue()
		{
			return new IPlotConfig_SetValue
			{
				EdPlotNode = this.EdPlotNode,
				EdPlotHandleJump = this.EdPlotHandleJump,
				EdPlotFileId = this.EdPlotFileId,
				EdPlotLayout = this.EdPlotLayout
			};
		}

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600AA1D RID: 43549 RVA: 0x00181DF9 File Offset: 0x0017FFF9
		// (set) Token: 0x0600AA1E RID: 43550 RVA: 0x00181E10 File Offset: 0x00180010
		public virtual string EdPlotNode
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlotNode;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPlotNode = value;
			}
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600AA1F RID: 43551 RVA: 0x00181E1E File Offset: 0x0018001E
		// (set) Token: 0x0600AA20 RID: 43552 RVA: 0x00181E35 File Offset: 0x00180035
		public virtual bool EdPlotHandleJump
		{
			get
			{
				return this.PocoInterface != null && this.PocoInterface.EdPlotHandleJump;
			}
			set
			{
				this.GetOrCreatePoco().EdPlotHandleJump = value;
			}
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600AA21 RID: 43553 RVA: 0x00181E43 File Offset: 0x00180043
		// (set) Token: 0x0600AA22 RID: 43554 RVA: 0x00181E5A File Offset: 0x0018005A
		public virtual string EdPlotFileId
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlotFileId;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPlotFileId = value;
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600AA23 RID: 43555 RVA: 0x00181E68 File Offset: 0x00180068
		// (set) Token: 0x0600AA24 RID: 43556 RVA: 0x00181E92 File Offset: 0x00180092
		public virtual EVisualNovelLayout? EdPlotLayout
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlotLayout;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPlotLayout = value;
			}
		}

		// Token: 0x04006610 RID: 26128
		[Nullable(2)]
		protected IPlotConfig FbInstance;

		// Token: 0x04006611 RID: 26129
		[Nullable(2)]
		protected IPlotConfig_SetValue PocoInterface;
	}
}
