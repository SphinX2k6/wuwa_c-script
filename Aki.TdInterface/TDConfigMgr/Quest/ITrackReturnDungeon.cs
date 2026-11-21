using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012FE RID: 4862
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackReturnDungeon
	{
		// Token: 0x06006D95 RID: 28053 RVA: 0x00105084 File Offset: 0x00103284
		[NullableContext(0)]
		private ITrackReturnDungeon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackReturnDungeon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackReturnDungeon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackReturnDungeon_SetValue());
			}
			return result;
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x001050BC File Offset: 0x001032BC
		[NullableContext(0)]
		public static ITrackReturnDungeon Create([Nullable(2)] ITrackReturnDungeon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackReturnDungeon
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x001050CF File Offset: 0x001032CF
		[NullableContext(0)]
		public static ITrackReturnDungeon CreateFromSetValue([Nullable(2)] ITrackReturnDungeon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackReturnDungeon
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x001050E4 File Offset: 0x001032E4
		[NullableContext(0)]
		public ITrackReturnDungeon_SetValue ToSetValue()
		{
			return new ITrackReturnDungeon_SetValue
			{
				DungeonId = this.DungeonId,
				IsRegroup = this.IsRegroup,
				TransitionOption = this.TransitionOption,
				TidTip = this.TidTip,
				EdTidTip = this.EdTidTip
			};
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x06006D99 RID: 28057 RVA: 0x00105132 File Offset: 0x00103332
		// (set) Token: 0x06006D9A RID: 28058 RVA: 0x0010515D File Offset: 0x0010335D
		public virtual int DungeonId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DungeonId;
			}
			set
			{
				this.GetOrCreatePoco().DungeonId = value;
			}
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x06006D9B RID: 28059 RVA: 0x0010516C File Offset: 0x0010336C
		// (set) Token: 0x06006D9C RID: 28060 RVA: 0x001051A6 File Offset: 0x001033A6
		public virtual bool? IsRegroup
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRegroup;
				}
				ITrackReturnDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsRegroup;
			}
			set
			{
				this.GetOrCreatePoco().IsRegroup = value;
			}
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x06006D9D RID: 28061 RVA: 0x001051B4 File Offset: 0x001033B4
		// (set) Token: 0x06006D9E RID: 28062 RVA: 0x001051DB File Offset: 0x001033DB
		public virtual ITeleportTransitionType TransitionOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionOption;
				}
				ITrackReturnDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionOption;
			}
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
			}
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x06006D9F RID: 28063 RVA: 0x001051E9 File Offset: 0x001033E9
		// (set) Token: 0x06006DA0 RID: 28064 RVA: 0x00105210 File Offset: 0x00103410
		public virtual string TidTip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTip;
				}
				ITrackReturnDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidTip;
			}
			set
			{
				this.GetOrCreatePoco().TidTip = value;
			}
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x06006DA1 RID: 28065 RVA: 0x0010521E File Offset: 0x0010341E
		// (set) Token: 0x06006DA2 RID: 28066 RVA: 0x00105235 File Offset: 0x00103435
		public virtual string EdTidTip
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTip;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidTip = value;
			}
		}

		// Token: 0x04004179 RID: 16761
		protected ITrackReturnDungeon FbInstance;

		// Token: 0x0400417A RID: 16762
		protected ITrackReturnDungeon_SetValue PocoInterface;
	}
}
