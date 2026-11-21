using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B40 RID: 27456
	public class IControlElementalBoxTypeBase_UnionUnion
	{
		// Token: 0x1700C9A2 RID: 51618
		// (get) Token: 0x0602F3EC RID: 193516 RVA: 0x006735D1 File Offset: 0x006717D1
		// (set) Token: 0x0602F3ED RID: 193517 RVA: 0x006735D9 File Offset: 0x006717D9
		public IControlElementalBoxTypeBase_Union Type { get; set; }

		// Token: 0x1700C9A3 RID: 51619
		// (get) Token: 0x0602F3EE RID: 193518 RVA: 0x006735E2 File Offset: 0x006717E2
		// (set) Token: 0x0602F3EF RID: 193519 RVA: 0x006735EA File Offset: 0x006717EA
		public object Value { get; set; }

		// Token: 0x0602F3F0 RID: 193520 RVA: 0x006735F3 File Offset: 0x006717F3
		public IControlElementalBoxTypeBase_UnionUnion()
		{
			this.Type = IControlElementalBoxTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F3F1 RID: 193521 RVA: 0x00673609 File Offset: 0x00671809
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F3F2 RID: 193522 RVA: 0x0067361B File Offset: 0x0067181B
		public IControlElementalBoxTypeBaseT AsIControlElementalBoxTypeBase()
		{
			return this.As<IControlElementalBoxTypeBaseT>();
		}

		// Token: 0x0602F3F3 RID: 193523 RVA: 0x00673623 File Offset: 0x00671823
		public static IControlElementalBoxTypeBase_UnionUnion FromIControlElementalBoxTypeBase(IControlElementalBoxTypeBaseT _icontrolelementalboxtypebase)
		{
			return new IControlElementalBoxTypeBase_UnionUnion
			{
				Type = IControlElementalBoxTypeBase_Union.IControlElementalBoxTypeBase,
				Value = _icontrolelementalboxtypebase
			};
		}

		// Token: 0x0602F3F4 RID: 193524 RVA: 0x00673638 File Offset: 0x00671838
		public IControlElementalBoxCaptureT AsIControlElementalBoxCapture()
		{
			return this.As<IControlElementalBoxCaptureT>();
		}

		// Token: 0x0602F3F5 RID: 193525 RVA: 0x00673640 File Offset: 0x00671840
		public static IControlElementalBoxTypeBase_UnionUnion FromIControlElementalBoxCapture(IControlElementalBoxCaptureT _icontrolelementalboxcapture)
		{
			return new IControlElementalBoxTypeBase_UnionUnion
			{
				Type = IControlElementalBoxTypeBase_Union.IControlElementalBoxCapture,
				Value = _icontrolelementalboxcapture
			};
		}

		// Token: 0x0602F3F6 RID: 193526 RVA: 0x00673655 File Offset: 0x00671855
		public IControlElementalBoxReturnT AsIControlElementalBoxReturn()
		{
			return this.As<IControlElementalBoxReturnT>();
		}

		// Token: 0x0602F3F7 RID: 193527 RVA: 0x0067365D File Offset: 0x0067185D
		public static IControlElementalBoxTypeBase_UnionUnion FromIControlElementalBoxReturn(IControlElementalBoxReturnT _icontrolelementalboxreturn)
		{
			return new IControlElementalBoxTypeBase_UnionUnion
			{
				Type = IControlElementalBoxTypeBase_Union.IControlElementalBoxReturn,
				Value = _icontrolelementalboxreturn
			};
		}

		// Token: 0x0602F3F8 RID: 193528 RVA: 0x00673674 File Offset: 0x00671874
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
