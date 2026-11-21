using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D44 RID: 27972
	public class IEnterOrbitalCameraType_UnionUnion
	{
		// Token: 0x1700CD34 RID: 52532
		// (get) Token: 0x060303FF RID: 197631 RVA: 0x0068F135 File Offset: 0x0068D335
		// (set) Token: 0x06030400 RID: 197632 RVA: 0x0068F13D File Offset: 0x0068D33D
		public IEnterOrbitalCameraType_Union Type { get; set; }

		// Token: 0x1700CD35 RID: 52533
		// (get) Token: 0x06030401 RID: 197633 RVA: 0x0068F146 File Offset: 0x0068D346
		// (set) Token: 0x06030402 RID: 197634 RVA: 0x0068F14E File Offset: 0x0068D34E
		public object Value { get; set; }

		// Token: 0x06030403 RID: 197635 RVA: 0x0068F157 File Offset: 0x0068D357
		public IEnterOrbitalCameraType_UnionUnion()
		{
			this.Type = IEnterOrbitalCameraType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030404 RID: 197636 RVA: 0x0068F16D File Offset: 0x0068D36D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030405 RID: 197637 RVA: 0x0068F17F File Offset: 0x0068D37F
		public IEnterOrbitalCameraTypeT AsIEnterOrbitalCameraType()
		{
			return this.As<IEnterOrbitalCameraTypeT>();
		}

		// Token: 0x06030406 RID: 197638 RVA: 0x0068F187 File Offset: 0x0068D387
		public static IEnterOrbitalCameraType_UnionUnion FromIEnterOrbitalCameraType(IEnterOrbitalCameraTypeT _ienterorbitalcameratype)
		{
			return new IEnterOrbitalCameraType_UnionUnion
			{
				Type = IEnterOrbitalCameraType_Union.IEnterOrbitalCameraType,
				Value = _ienterorbitalcameratype
			};
		}

		// Token: 0x06030407 RID: 197639 RVA: 0x0068F19C File Offset: 0x0068D39C
		public IEnterOrbitalCameraControlByMoveT AsIEnterOrbitalCameraControlByMove()
		{
			return this.As<IEnterOrbitalCameraControlByMoveT>();
		}

		// Token: 0x06030408 RID: 197640 RVA: 0x0068F1A4 File Offset: 0x0068D3A4
		public static IEnterOrbitalCameraType_UnionUnion FromIEnterOrbitalCameraControlByMove(IEnterOrbitalCameraControlByMoveT _ienterorbitalcameracontrolbymove)
		{
			return new IEnterOrbitalCameraType_UnionUnion
			{
				Type = IEnterOrbitalCameraType_Union.IEnterOrbitalCameraControlByMove,
				Value = _ienterorbitalcameracontrolbymove
			};
		}

		// Token: 0x06030409 RID: 197641 RVA: 0x0068F1BC File Offset: 0x0068D3BC
		public static int Pack(FlatBufferBuilder builder, IEnterOrbitalCameraType_UnionUnion _o)
		{
			IEnterOrbitalCameraType_Union type = _o.Type;
			if (type == IEnterOrbitalCameraType_Union.IEnterOrbitalCameraType)
			{
				return IEnterOrbitalCameraType.Pack(builder, _o.AsIEnterOrbitalCameraType()).Value;
			}
			if (type != IEnterOrbitalCameraType_Union.IEnterOrbitalCameraControlByMove)
			{
				return 0;
			}
			return IEnterOrbitalCameraControlByMove.Pack(builder, _o.AsIEnterOrbitalCameraControlByMove()).Value;
		}
	}
}
