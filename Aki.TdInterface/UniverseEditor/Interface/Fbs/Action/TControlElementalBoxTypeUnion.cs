using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007693 RID: 30355
	public class TControlElementalBoxTypeUnion
	{
		// Token: 0x1700E5F5 RID: 58869
		// (get) Token: 0x060373C0 RID: 226240 RVA: 0x0077C4F2 File Offset: 0x0077A6F2
		// (set) Token: 0x060373C1 RID: 226241 RVA: 0x0077C4FA File Offset: 0x0077A6FA
		public TControlElementalBoxType Type { get; set; }

		// Token: 0x1700E5F6 RID: 58870
		// (get) Token: 0x060373C2 RID: 226242 RVA: 0x0077C503 File Offset: 0x0077A703
		// (set) Token: 0x060373C3 RID: 226243 RVA: 0x0077C50B File Offset: 0x0077A70B
		public object Value { get; set; }

		// Token: 0x060373C4 RID: 226244 RVA: 0x0077C514 File Offset: 0x0077A714
		public TControlElementalBoxTypeUnion()
		{
			this.Type = TControlElementalBoxType.NONE;
			this.Value = null;
		}

		// Token: 0x060373C5 RID: 226245 RVA: 0x0077C52A File Offset: 0x0077A72A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060373C6 RID: 226246 RVA: 0x0077C53C File Offset: 0x0077A73C
		public IControlElementalBoxCaptureT AsIControlElementalBoxCapture()
		{
			return this.As<IControlElementalBoxCaptureT>();
		}

		// Token: 0x060373C7 RID: 226247 RVA: 0x0077C544 File Offset: 0x0077A744
		public static TControlElementalBoxTypeUnion FromIControlElementalBoxCapture(IControlElementalBoxCaptureT _icontrolelementalboxcapture)
		{
			return new TControlElementalBoxTypeUnion
			{
				Type = TControlElementalBoxType.IControlElementalBoxCapture,
				Value = _icontrolelementalboxcapture
			};
		}

		// Token: 0x060373C8 RID: 226248 RVA: 0x0077C559 File Offset: 0x0077A759
		public IControlElementalBoxReturnT AsIControlElementalBoxReturn()
		{
			return this.As<IControlElementalBoxReturnT>();
		}

		// Token: 0x060373C9 RID: 226249 RVA: 0x0077C561 File Offset: 0x0077A761
		public static TControlElementalBoxTypeUnion FromIControlElementalBoxReturn(IControlElementalBoxReturnT _icontrolelementalboxreturn)
		{
			return new TControlElementalBoxTypeUnion
			{
				Type = TControlElementalBoxType.IControlElementalBoxReturn,
				Value = _icontrolelementalboxreturn
			};
		}

		// Token: 0x060373CA RID: 226250 RVA: 0x0077C578 File Offset: 0x0077A778
		public static int Pack(FlatBufferBuilder builder, TControlElementalBoxTypeUnion _o)
		{
			TControlElementalBoxType type = _o.Type;
			if (type == TControlElementalBoxType.IControlElementalBoxCapture)
			{
				return IControlElementalBoxCapture.Pack(builder, _o.AsIControlElementalBoxCapture()).Value;
			}
			if (type != TControlElementalBoxType.IControlElementalBoxReturn)
			{
				return 0;
			}
			return IControlElementalBoxReturn.Pack(builder, _o.AsIControlElementalBoxReturn()).Value;
		}
	}
}
