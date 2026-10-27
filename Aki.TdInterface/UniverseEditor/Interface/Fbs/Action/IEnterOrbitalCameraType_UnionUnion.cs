using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066CA RID: 26314
	public class IEnterOrbitalCameraType_UnionUnion
	{
		// Token: 0x1700C383 RID: 50051
		// (get) Token: 0x0602DBE2 RID: 187362 RVA: 0x00641E81 File Offset: 0x00640081
		// (set) Token: 0x0602DBE3 RID: 187363 RVA: 0x00641E89 File Offset: 0x00640089
		public IEnterOrbitalCameraType_Union Type { get; set; }

		// Token: 0x1700C384 RID: 50052
		// (get) Token: 0x0602DBE4 RID: 187364 RVA: 0x00641E92 File Offset: 0x00640092
		// (set) Token: 0x0602DBE5 RID: 187365 RVA: 0x00641E9A File Offset: 0x0064009A
		public object Value { get; set; }

		// Token: 0x0602DBE6 RID: 187366 RVA: 0x00641EA3 File Offset: 0x006400A3
		public IEnterOrbitalCameraType_UnionUnion()
		{
			this.Type = IEnterOrbitalCameraType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DBE7 RID: 187367 RVA: 0x00641EB9 File Offset: 0x006400B9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DBE8 RID: 187368 RVA: 0x00641ECB File Offset: 0x006400CB
		public IEnterOrbitalCameraTypeT AsIEnterOrbitalCameraType()
		{
			return this.As<IEnterOrbitalCameraTypeT>();
		}

		// Token: 0x0602DBE9 RID: 187369 RVA: 0x00641ED3 File Offset: 0x006400D3
		public static IEnterOrbitalCameraType_UnionUnion FromIEnterOrbitalCameraType(IEnterOrbitalCameraTypeT _ienterorbitalcameratype)
		{
			return new IEnterOrbitalCameraType_UnionUnion
			{
				Type = IEnterOrbitalCameraType_Union.IEnterOrbitalCameraType,
				Value = _ienterorbitalcameratype
			};
		}

		// Token: 0x0602DBEA RID: 187370 RVA: 0x00641EE8 File Offset: 0x006400E8
		public IEnterOrbitalCameraControlByMoveT AsIEnterOrbitalCameraControlByMove()
		{
			return this.As<IEnterOrbitalCameraControlByMoveT>();
		}

		// Token: 0x0602DBEB RID: 187371 RVA: 0x00641EF0 File Offset: 0x006400F0
		public static IEnterOrbitalCameraType_UnionUnion FromIEnterOrbitalCameraControlByMove(IEnterOrbitalCameraControlByMoveT _ienterorbitalcameracontrolbymove)
		{
			return new IEnterOrbitalCameraType_UnionUnion
			{
				Type = IEnterOrbitalCameraType_Union.IEnterOrbitalCameraControlByMove,
				Value = _ienterorbitalcameracontrolbymove
			};
		}

		// Token: 0x0602DBEC RID: 187372 RVA: 0x00641F08 File Offset: 0x00640108
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
