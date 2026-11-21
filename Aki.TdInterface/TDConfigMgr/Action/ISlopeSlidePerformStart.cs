using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C4 RID: 8388
	public class ISlopeSlidePerformStart : IStartSlidePerformType
	{
		// Token: 0x0600B220 RID: 45600 RVA: 0x00190364 File Offset: 0x0018E564
		private ISlopeSlidePerformStart_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlopeSlidePerformStart 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlopeSlidePerformStart_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlopeSlidePerformStart_SetValue());
			}
			return result;
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x0019039C File Offset: 0x0018E59C
		public static ISlopeSlidePerformStart Create([Nullable(2)] ISlopeSlidePerformStart instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlopeSlidePerformStart
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B222 RID: 45602 RVA: 0x001903AF File Offset: 0x0018E5AF
		public static ISlopeSlidePerformStart CreateFromSetValue([Nullable(2)] ISlopeSlidePerformStart_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlopeSlidePerformStart
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x001903C2 File Offset: 0x0018E5C2
		public new ISlopeSlidePerformStart_SetValue ToSetValue()
		{
			return new ISlopeSlidePerformStart_SetValue
			{
				Type = this.Type,
				SlopeSlidePerformDaPath = this.SlopeSlidePerformDaPath
			};
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600B224 RID: 45604 RVA: 0x001903E1 File Offset: 0x0018E5E1
		// (set) Token: 0x0600B225 RID: 45605 RVA: 0x0019040C File Offset: 0x0018E60C
		public override ESlidePerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600B226 RID: 45606 RVA: 0x0019041A File Offset: 0x0018E61A
		// (set) Token: 0x0600B227 RID: 45607 RVA: 0x00190445 File Offset: 0x0018E645
		public virtual string SlopeSlidePerformDaPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SlopeSlidePerformDaPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SlopeSlidePerformDaPath;
			}
			set
			{
				this.GetOrCreatePoco().SlopeSlidePerformDaPath = value;
			}
		}

		// Token: 0x040069C0 RID: 27072
		[Nullable(2)]
		protected new ISlopeSlidePerformStart FbInstance;

		// Token: 0x040069C1 RID: 27073
		[Nullable(2)]
		protected new ISlopeSlidePerformStart_SetValue PocoInterface;
	}
}
