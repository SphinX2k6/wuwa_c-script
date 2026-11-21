using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D8D RID: 7565
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressInteractStyleConfigTimeBackInteract : ILongPressInteractStyleConfig
	{
		// Token: 0x0600A097 RID: 41111 RVA: 0x001704C8 File Offset: 0x0016E6C8
		[NullableContext(0)]
		private ILongPressInteractStyleConfigTimeBackInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressInteractStyleConfigTimeBackInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressInteractStyleConfigTimeBackInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressInteractStyleConfigTimeBackInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600A098 RID: 41112 RVA: 0x00170500 File Offset: 0x0016E700
		[NullableContext(0)]
		public static ILongPressInteractStyleConfigTimeBackInteract Create([Nullable(2)] ILongPressInteractStyleConfigTimeBackInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigTimeBackInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A099 RID: 41113 RVA: 0x00170513 File Offset: 0x0016E713
		[NullableContext(0)]
		public static ILongPressInteractStyleConfigTimeBackInteract CreateFromSetValue([Nullable(2)] ILongPressInteractStyleConfigTimeBackInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigTimeBackInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x00170526 File Offset: 0x0016E726
		[NullableContext(0)]
		public new ILongPressInteractStyleConfigTimeBackInteract_SetValue ToSetValue()
		{
			return new ILongPressInteractStyleConfigTimeBackInteract_SetValue
			{
				Type = this.Type,
				TidContent = this.TidContent,
				StartProgress = this.StartProgress,
				EdTidContent = this.EdTidContent
			};
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600A09B RID: 41115 RVA: 0x0017055D File Offset: 0x0016E75D
		// (set) Token: 0x0600A09C RID: 41116 RVA: 0x00170588 File Offset: 0x0016E788
		public override ELongPressInteractStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELongPressInteractStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600A09D RID: 41117 RVA: 0x00170596 File Offset: 0x0016E796
		// (set) Token: 0x0600A09E RID: 41118 RVA: 0x001705BD File Offset: 0x0016E7BD
		public virtual string TidContent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidContent;
				}
				ILongPressInteractStyleConfigTimeBackInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidContent;
			}
			set
			{
				this.GetOrCreatePoco().TidContent = value;
			}
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600A09F RID: 41119 RVA: 0x001705CC File Offset: 0x0016E7CC
		// (set) Token: 0x0600A0A0 RID: 41120 RVA: 0x00170606 File Offset: 0x0016E806
		public virtual float? StartProgress
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartProgress;
				}
				ILongPressInteractStyleConfigTimeBackInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartProgress;
			}
			set
			{
				this.GetOrCreatePoco().StartProgress = value;
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600A0A1 RID: 41121 RVA: 0x00170614 File Offset: 0x0016E814
		// (set) Token: 0x0600A0A2 RID: 41122 RVA: 0x0017062B File Offset: 0x0016E82B
		public virtual string EdTidContent
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidContent;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidContent = value;
			}
		}

		// Token: 0x0400619B RID: 24987
		protected new ILongPressInteractStyleConfigTimeBackInteract FbInstance;

		// Token: 0x0400619C RID: 24988
		protected new ILongPressInteractStyleConfigTimeBackInteract_SetValue PocoInterface;
	}
}
