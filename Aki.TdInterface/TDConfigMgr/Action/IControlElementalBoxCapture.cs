using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001934 RID: 6452
	[NullableContext(2)]
	[Nullable(0)]
	public class IControlElementalBoxCapture : IControlElementalBoxTypeBase
	{
		// Token: 0x06008A59 RID: 35417 RVA: 0x00145FEC File Offset: 0x001441EC
		[NullableContext(1)]
		private IControlElementalBoxCapture_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlElementalBoxCapture 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlElementalBoxCapture_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlElementalBoxCapture_SetValue());
			}
			return result;
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x00146024 File Offset: 0x00144224
		[NullableContext(1)]
		public static IControlElementalBoxCapture Create([Nullable(2)] IControlElementalBoxCapture instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlElementalBoxCapture
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A5B RID: 35419 RVA: 0x00146037 File Offset: 0x00144237
		[NullableContext(1)]
		public static IControlElementalBoxCapture CreateFromSetValue([Nullable(2)] IControlElementalBoxCapture_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlElementalBoxCapture
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A5C RID: 35420 RVA: 0x0014604A File Offset: 0x0014424A
		[NullableContext(1)]
		public new IControlElementalBoxCapture_SetValue ToSetValue()
		{
			return new IControlElementalBoxCapture_SetValue
			{
				Type = this.Type,
				CaptureCompleteSeq = this.CaptureCompleteSeq
			};
		}

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x06008A5D RID: 35421 RVA: 0x00146069 File Offset: 0x00144269
		// (set) Token: 0x06008A5E RID: 35422 RVA: 0x00146094 File Offset: 0x00144294
		public override EControlElementalBoxType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EControlElementalBoxType.Capture;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x06008A5F RID: 35423 RVA: 0x001460A2 File Offset: 0x001442A2
		// (set) Token: 0x06008A60 RID: 35424 RVA: 0x001460C9 File Offset: 0x001442C9
		public virtual string CaptureCompleteSeq
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CaptureCompleteSeq;
				}
				IControlElementalBoxCapture_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CaptureCompleteSeq;
			}
			set
			{
				this.GetOrCreatePoco().CaptureCompleteSeq = value;
			}
		}

		// Token: 0x04005682 RID: 22146
		protected new IControlElementalBoxCapture FbInstance;

		// Token: 0x04005683 RID: 22147
		protected new IControlElementalBoxCapture_SetValue PocoInterface;
	}
}
