using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D4F RID: 7503
	public class ILiveDanmakuPool
	{
		// Token: 0x06009F4D RID: 40781 RVA: 0x0016DE78 File Offset: 0x0016C078
		private ILiveDanmakuPool_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveDanmakuPool 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveDanmakuPool_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveDanmakuPool_SetValue());
			}
			return result;
		}

		// Token: 0x06009F4E RID: 40782 RVA: 0x0016DEB0 File Offset: 0x0016C0B0
		public static ILiveDanmakuPool Create([Nullable(2)] ILiveDanmakuPool instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveDanmakuPool
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F4F RID: 40783 RVA: 0x0016DEC3 File Offset: 0x0016C0C3
		public static ILiveDanmakuPool CreateFromSetValue([Nullable(2)] ILiveDanmakuPool_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveDanmakuPool
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x0016DED6 File Offset: 0x0016C0D6
		public ILiveDanmakuPool_SetValue ToSetValue()
		{
			return new ILiveDanmakuPool_SetValue
			{
				DanmakuPoolId = this.DanmakuPoolId,
				Weight = this.Weight,
				DelayTime = this.DelayTime,
				LoopType = this.LoopType
			};
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x06009F51 RID: 40785 RVA: 0x0016DF0D File Offset: 0x0016C10D
		// (set) Token: 0x06009F52 RID: 40786 RVA: 0x0016DF38 File Offset: 0x0016C138
		public virtual int DanmakuPoolId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DanmakuPoolId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DanmakuPoolId;
			}
			set
			{
				this.GetOrCreatePoco().DanmakuPoolId = value;
			}
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x06009F53 RID: 40787 RVA: 0x0016DF46 File Offset: 0x0016C146
		// (set) Token: 0x06009F54 RID: 40788 RVA: 0x0016DF75 File Offset: 0x0016C175
		public virtual float Weight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weight;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Weight;
			}
			set
			{
				this.GetOrCreatePoco().Weight = value;
			}
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x06009F55 RID: 40789 RVA: 0x0016DF83 File Offset: 0x0016C183
		// (set) Token: 0x06009F56 RID: 40790 RVA: 0x0016DFB2 File Offset: 0x0016C1B2
		public virtual float DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x06009F57 RID: 40791 RVA: 0x0016DFC0 File Offset: 0x0016C1C0
		// (set) Token: 0x06009F58 RID: 40792 RVA: 0x0016DFEB File Offset: 0x0016C1EB
		public virtual ELiveDanmakuLoopType LoopType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoopType;
				}
				if (this.PocoInterface == null)
				{
					return ELiveDanmakuLoopType.OrderOnce;
				}
				return this.PocoInterface.LoopType;
			}
			set
			{
				this.GetOrCreatePoco().LoopType = value;
			}
		}

		// Token: 0x040060FF RID: 24831
		[Nullable(2)]
		protected ILiveDanmakuPool FbInstance;

		// Token: 0x04006100 RID: 24832
		[Nullable(2)]
		protected ILiveDanmakuPool_SetValue PocoInterface;
	}
}
