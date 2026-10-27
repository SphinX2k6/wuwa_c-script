using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064D5 RID: 25813
	public class IControlElementalBoxTypeBase_UnionUnion
	{
		// Token: 0x1700C015 RID: 49173
		// (get) Token: 0x0602CC68 RID: 183400 RVA: 0x006274A9 File Offset: 0x006256A9
		// (set) Token: 0x0602CC69 RID: 183401 RVA: 0x006274B1 File Offset: 0x006256B1
		public IControlElementalBoxTypeBase_Union Type { get; set; }

		// Token: 0x1700C016 RID: 49174
		// (get) Token: 0x0602CC6A RID: 183402 RVA: 0x006274BA File Offset: 0x006256BA
		// (set) Token: 0x0602CC6B RID: 183403 RVA: 0x006274C2 File Offset: 0x006256C2
		public object Value { get; set; }

		// Token: 0x0602CC6C RID: 183404 RVA: 0x006274CB File Offset: 0x006256CB
		public IControlElementalBoxTypeBase_UnionUnion()
		{
			this.Type = IControlElementalBoxTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CC6D RID: 183405 RVA: 0x006274E1 File Offset: 0x006256E1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CC6E RID: 183406 RVA: 0x006274F3 File Offset: 0x006256F3
		public IControlElementalBoxTypeBaseT AsIControlElementalBoxTypeBase()
		{
			return this.As<IControlElementalBoxTypeBaseT>();
		}

		// Token: 0x0602CC6F RID: 183407 RVA: 0x006274FB File Offset: 0x006256FB
		public static IControlElementalBoxTypeBase_UnionUnion FromIControlElementalBoxTypeBase(IControlElementalBoxTypeBaseT _icontrolelementalboxtypebase)
		{
			return new IControlElementalBoxTypeBase_UnionUnion
			{
				Type = IControlElementalBoxTypeBase_Union.IControlElementalBoxTypeBase,
				Value = _icontrolelementalboxtypebase
			};
		}

		// Token: 0x0602CC70 RID: 183408 RVA: 0x00627510 File Offset: 0x00625710
		public IControlElementalBoxCaptureT AsIControlElementalBoxCapture()
		{
			return this.As<IControlElementalBoxCaptureT>();
		}

		// Token: 0x0602CC71 RID: 183409 RVA: 0x00627518 File Offset: 0x00625718
		public static IControlElementalBoxTypeBase_UnionUnion FromIControlElementalBoxCapture(IControlElementalBoxCaptureT _icontrolelementalboxcapture)
		{
			return new IControlElementalBoxTypeBase_UnionUnion
			{
				Type = IControlElementalBoxTypeBase_Union.IControlElementalBoxCapture,
				Value = _icontrolelementalboxcapture
			};
		}

		// Token: 0x0602CC72 RID: 183410 RVA: 0x0062752D File Offset: 0x0062572D
		public IControlElementalBoxReturnT AsIControlElementalBoxReturn()
		{
			return this.As<IControlElementalBoxReturnT>();
		}

		// Token: 0x0602CC73 RID: 183411 RVA: 0x00627535 File Offset: 0x00625735
		public static IControlElementalBoxTypeBase_UnionUnion FromIControlElementalBoxReturn(IControlElementalBoxReturnT _icontrolelementalboxreturn)
		{
			return new IControlElementalBoxTypeBase_UnionUnion
			{
				Type = IControlElementalBoxTypeBase_Union.IControlElementalBoxReturn,
				Value = _icontrolelementalboxreturn
			};
		}

		// Token: 0x0602CC74 RID: 183412 RVA: 0x0062754C File Offset: 0x0062574C
		public static int Pack(FlatBufferBuilder builder, IControlElementalBoxTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IControlElementalBoxTypeBase_Union.IControlElementalBoxTypeBase:
				return IControlElementalBoxTypeBase.Pack(builder, _o.AsIControlElementalBoxTypeBase()).Value;
			case IControlElementalBoxTypeBase_Union.IControlElementalBoxCapture:
				return IControlElementalBoxCapture.Pack(builder, _o.AsIControlElementalBoxCapture()).Value;
			case IControlElementalBoxTypeBase_Union.IControlElementalBoxReturn:
				return IControlElementalBoxReturn.Pack(builder, _o.AsIControlElementalBoxReturn()).Value;
			default:
				return 0;
			}
		}
	}
}
