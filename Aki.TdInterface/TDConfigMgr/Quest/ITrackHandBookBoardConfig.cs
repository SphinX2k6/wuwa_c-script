using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012F6 RID: 4854
	public class ITrackHandBookBoardConfig
	{
		// Token: 0x06006D61 RID: 28001 RVA: 0x00104918 File Offset: 0x00102B18
		private ITrackHandBookBoardConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackHandBookBoardConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackHandBookBoardConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackHandBookBoardConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006D62 RID: 28002 RVA: 0x00104950 File Offset: 0x00102B50
		public static ITrackHandBookBoardConfig Create([Nullable(2)] ITrackHandBookBoardConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackHandBookBoardConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x00104963 File Offset: 0x00102B63
		public static ITrackHandBookBoardConfig CreateFromSetValue([Nullable(2)] ITrackHandBookBoardConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackHandBookBoardConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x00104976 File Offset: 0x00102B76
		public ITrackHandBookBoardConfig_SetValue ToSetValue()
		{
			return new ITrackHandBookBoardConfig_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x06006D65 RID: 28005 RVA: 0x00104989 File Offset: 0x00102B89
		// (set) Token: 0x06006D66 RID: 28006 RVA: 0x001049B4 File Offset: 0x00102BB4
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04004159 RID: 16729
		[Nullable(2)]
		protected ITrackHandBookBoardConfig FbInstance;

		// Token: 0x0400415A RID: 16730
		[Nullable(2)]
		protected ITrackHandBookBoardConfig_SetValue PocoInterface;
	}
}
