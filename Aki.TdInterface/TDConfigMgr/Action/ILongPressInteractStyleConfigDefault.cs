using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D8B RID: 7563
	public class ILongPressInteractStyleConfigDefault : ILongPressInteractStyleConfig
	{
		// Token: 0x0600A08F RID: 41103 RVA: 0x0017040C File Offset: 0x0016E60C
		private ILongPressInteractStyleConfigDefault_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressInteractStyleConfigDefault 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressInteractStyleConfigDefault_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressInteractStyleConfigDefault_SetValue());
			}
			return result;
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x00170444 File Offset: 0x0016E644
		public static ILongPressInteractStyleConfigDefault Create([Nullable(2)] ILongPressInteractStyleConfigDefault instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigDefault
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A091 RID: 41105 RVA: 0x00170457 File Offset: 0x0016E657
		public static ILongPressInteractStyleConfigDefault CreateFromSetValue([Nullable(2)] ILongPressInteractStyleConfigDefault_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigDefault
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x0017046A File Offset: 0x0016E66A
		public new ILongPressInteractStyleConfigDefault_SetValue ToSetValue()
		{
			return new ILongPressInteractStyleConfigDefault_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600A093 RID: 41107 RVA: 0x0017047D File Offset: 0x0016E67D
		// (set) Token: 0x0600A094 RID: 41108 RVA: 0x001704A8 File Offset: 0x0016E6A8
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

		// Token: 0x04006198 RID: 24984
		[Nullable(2)]
		protected new ILongPressInteractStyleConfigDefault FbInstance;

		// Token: 0x04006199 RID: 24985
		[Nullable(2)]
		protected new ILongPressInteractStyleConfigDefault_SetValue PocoInterface;
	}
}
