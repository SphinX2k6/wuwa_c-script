using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002210 RID: 8720
	[NullableContext(1)]
	[Nullable(0)]
	public class SlideRailEnd : ActionParams
	{
		// Token: 0x0600BF70 RID: 49008 RVA: 0x001B81E4 File Offset: 0x001B63E4
		private SlideRailEnd_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SlideRailEnd 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SlideRailEnd_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SlideRailEnd_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF71 RID: 49009 RVA: 0x001B821C File Offset: 0x001B641C
		public static SlideRailEnd Create([Nullable(2)] SlideRailEnd instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlideRailEnd
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF72 RID: 49010 RVA: 0x001B822F File Offset: 0x001B642F
		public static SlideRailEnd CreateFromSetValue([Nullable(2)] SlideRailEnd_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SlideRailEnd
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF73 RID: 49011 RVA: 0x001B8242 File Offset: 0x001B6442
		public SlideRailEnd_SetValue ToSetValue()
		{
			return new SlideRailEnd_SetValue
			{
				EndTarget = this.EndTarget
			};
		}

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0600BF74 RID: 49012 RVA: 0x001B8255 File Offset: 0x001B6455
		// (set) Token: 0x0600BF75 RID: 49013 RVA: 0x001B827C File Offset: 0x001B647C
		public virtual ISlideRailEndType EndTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndTarget;
				}
				SlideRailEnd_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndTarget;
			}
			set
			{
				this.GetOrCreatePoco().EndTarget = value;
			}
		}

		// Token: 0x04007224 RID: 29220
		[Nullable(2)]
		protected new SlideRailEnd FbInstance;

		// Token: 0x04007225 RID: 29221
		[Nullable(2)]
		protected SlideRailEnd_SetValue PocoInterface;
	}
}
