using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D28 RID: 7464
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotConfig
	{
		// Token: 0x0600A02D RID: 41005 RVA: 0x0016D940 File Offset: 0x0016BB40
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

		// Token: 0x0600A02E RID: 41006 RVA: 0x0016D978 File Offset: 0x0016BB78
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

		// Token: 0x0600A02F RID: 41007 RVA: 0x0016D98B File Offset: 0x0016BB8B
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

		// Token: 0x0600A030 RID: 41008 RVA: 0x0016D99E File Offset: 0x0016BB9E
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

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600A031 RID: 41009 RVA: 0x0016D9D5 File Offset: 0x0016BBD5
		// (set) Token: 0x0600A032 RID: 41010 RVA: 0x0016D9EC File Offset: 0x0016BBEC
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

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600A033 RID: 41011 RVA: 0x0016D9FA File Offset: 0x0016BBFA
		// (set) Token: 0x0600A034 RID: 41012 RVA: 0x0016DA11 File Offset: 0x0016BC11
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

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600A035 RID: 41013 RVA: 0x0016DA1F File Offset: 0x0016BC1F
		// (set) Token: 0x0600A036 RID: 41014 RVA: 0x0016DA36 File Offset: 0x0016BC36
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

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0600A037 RID: 41015 RVA: 0x0016DA44 File Offset: 0x0016BC44
		// (set) Token: 0x0600A038 RID: 41016 RVA: 0x0016DA6E File Offset: 0x0016BC6E
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

		// Token: 0x04006094 RID: 24724
		[Nullable(2)]
		protected IPlotConfig FbInstance;

		// Token: 0x04006095 RID: 24725
		[Nullable(2)]
		protected IPlotConfig_SetValue PocoInterface;
	}
}
