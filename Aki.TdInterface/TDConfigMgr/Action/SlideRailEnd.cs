using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200247B RID: 9339
	public class SlideRailEnd : ActionParams
	{
		// Token: 0x0600CB2E RID: 52014 RVA: 0x001CF8B0 File Offset: 0x001CDAB0
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

		// Token: 0x0600CB2F RID: 52015 RVA: 0x001CF8E8 File Offset: 0x001CDAE8
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

		// Token: 0x0600CB30 RID: 52016 RVA: 0x001CF8FB File Offset: 0x001CDAFB
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

		// Token: 0x0600CB31 RID: 52017 RVA: 0x001CF90E File Offset: 0x001CDB0E
		public SlideRailEnd_SetValue ToSetValue()
		{
			return new SlideRailEnd_SetValue
			{
				EndTarget = this.EndTarget
			};
		}

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x0600CB32 RID: 52018 RVA: 0x001CF921 File Offset: 0x001CDB21
		// (set) Token: 0x0600CB33 RID: 52019 RVA: 0x001CF948 File Offset: 0x001CDB48
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

		// Token: 0x0400786E RID: 30830
		[Nullable(2)]
		protected new SlideRailEnd FbInstance;

		// Token: 0x0400786F RID: 30831
		[Nullable(2)]
		protected SlideRailEnd_SetValue PocoInterface;
	}
}
