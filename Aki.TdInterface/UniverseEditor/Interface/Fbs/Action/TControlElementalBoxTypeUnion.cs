using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E9E RID: 32414
	public class TControlElementalBoxTypeUnion
	{
		// Token: 0x1700F231 RID: 62001
		// (get) Token: 0x0603A863 RID: 239715 RVA: 0x007E0647 File Offset: 0x007DE847
		// (set) Token: 0x0603A864 RID: 239716 RVA: 0x007E064F File Offset: 0x007DE84F
		public TControlElementalBoxType Type { get; set; }

		// Token: 0x1700F232 RID: 62002
		// (get) Token: 0x0603A865 RID: 239717 RVA: 0x007E0658 File Offset: 0x007DE858
		// (set) Token: 0x0603A866 RID: 239718 RVA: 0x007E0660 File Offset: 0x007DE860
		public object Value { get; set; }

		// Token: 0x0603A867 RID: 239719 RVA: 0x007E0669 File Offset: 0x007DE869
		public TControlElementalBoxTypeUnion()
		{
			this.Type = TControlElementalBoxType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A868 RID: 239720 RVA: 0x007E067F File Offset: 0x007DE87F
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A869 RID: 239721 RVA: 0x007E0691 File Offset: 0x007DE891
		public IControlElementalBoxCaptureT AsIControlElementalBoxCapture()
		{
			return this.As<IControlElementalBoxCaptureT>();
		}

		// Token: 0x0603A86A RID: 239722 RVA: 0x007E0699 File Offset: 0x007DE899
		public static TControlElementalBoxTypeUnion FromIControlElementalBoxCapture(IControlElementalBoxCaptureT _icontrolelementalboxcapture)
		{
			return new TControlElementalBoxTypeUnion
			{
				Type = TControlElementalBoxType.IControlElementalBoxCapture,
				Value = _icontrolelementalboxcapture
			};
		}

		// Token: 0x0603A86B RID: 239723 RVA: 0x007E06AE File Offset: 0x007DE8AE
		public IControlElementalBoxReturnT AsIControlElementalBoxReturn()
		{
			return this.As<IControlElementalBoxReturnT>();
		}

		// Token: 0x0603A86C RID: 239724 RVA: 0x007E06B6 File Offset: 0x007DE8B6
		public static TControlElementalBoxTypeUnion FromIControlElementalBoxReturn(IControlElementalBoxReturnT _icontrolelementalboxreturn)
		{
			return new TControlElementalBoxTypeUnion
			{
				Type = TControlElementalBoxType.IControlElementalBoxReturn,
				Value = _icontrolelementalboxreturn
			};
		}

		// Token: 0x0603A86D RID: 239725 RVA: 0x007E06CC File Offset: 0x007DE8CC
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
