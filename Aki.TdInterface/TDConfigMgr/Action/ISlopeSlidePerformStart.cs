using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E8F RID: 7823
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlopeSlidePerformStart : IStartSlidePerformType
	{
		// Token: 0x0600A768 RID: 42856 RVA: 0x0017A664 File Offset: 0x00178864
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

		// Token: 0x0600A769 RID: 42857 RVA: 0x0017A69C File Offset: 0x0017889C
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

		// Token: 0x0600A76A RID: 42858 RVA: 0x0017A6AF File Offset: 0x001788AF
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

		// Token: 0x0600A76B RID: 42859 RVA: 0x0017A6C2 File Offset: 0x001788C2
		public new ISlopeSlidePerformStart_SetValue ToSetValue()
		{
			return new ISlopeSlidePerformStart_SetValue
			{
				Type = this.Type,
				SlopeSlidePerformDaPath = this.SlopeSlidePerformDaPath
			};
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600A76C RID: 42860 RVA: 0x0017A6E1 File Offset: 0x001788E1
		// (set) Token: 0x0600A76D RID: 42861 RVA: 0x0017A70C File Offset: 0x0017890C
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

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600A76E RID: 42862 RVA: 0x0017A71A File Offset: 0x0017891A
		// (set) Token: 0x0600A76F RID: 42863 RVA: 0x0017A745 File Offset: 0x00178945
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

		// Token: 0x040063DC RID: 25564
		[Nullable(2)]
		protected new ISlopeSlidePerformStart FbInstance;

		// Token: 0x040063DD RID: 25565
		[Nullable(2)]
		protected new ISlopeSlidePerformStart_SetValue PocoInterface;
	}
}
