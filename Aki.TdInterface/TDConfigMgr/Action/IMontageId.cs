using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C06 RID: 7174
	[NullableContext(1)]
	[Nullable(0)]
	public class IMontageId
	{
		// Token: 0x060099C1 RID: 39361 RVA: 0x00161D4C File Offset: 0x0015FF4C
		private IMontageId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageId_SetValue());
			}
			return result;
		}

		// Token: 0x060099C2 RID: 39362 RVA: 0x00161D84 File Offset: 0x0015FF84
		public static IMontageId Create([Nullable(2)] IMontageId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageId
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099C3 RID: 39363 RVA: 0x00161D97 File Offset: 0x0015FF97
		public static IMontageId CreateFromSetValue([Nullable(2)] IMontageId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageId
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099C4 RID: 39364 RVA: 0x00161DAA File Offset: 0x0015FFAA
		public IMontageId_SetValue ToSetValue()
		{
			return new IMontageId_SetValue
			{
				MontageId = this.MontageId,
				IsAbp = this.IsAbp
			};
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x060099C5 RID: 39365 RVA: 0x00161DC9 File Offset: 0x0015FFC9
		// (set) Token: 0x060099C6 RID: 39366 RVA: 0x00161DF4 File Offset: 0x0015FFF4
		public virtual int MontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MontageId;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
			}
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x060099C7 RID: 39367 RVA: 0x00161E04 File Offset: 0x00160004
		// (set) Token: 0x060099C8 RID: 39368 RVA: 0x00161E3E File Offset: 0x0016003E
		public virtual bool? IsAbp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAbp;
				}
				IMontageId_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAbp;
			}
			set
			{
				this.GetOrCreatePoco().IsAbp = value;
			}
		}

		// Token: 0x04005D97 RID: 23959
		[Nullable(2)]
		protected IMontageId FbInstance;

		// Token: 0x04005D98 RID: 23960
		[Nullable(2)]
		protected IMontageId_SetValue PocoInterface;
	}
}
