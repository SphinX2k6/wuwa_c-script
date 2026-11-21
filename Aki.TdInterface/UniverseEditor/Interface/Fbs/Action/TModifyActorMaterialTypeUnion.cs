using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F3D RID: 32573
	public class TModifyActorMaterialTypeUnion
	{
		// Token: 0x1700F2A1 RID: 62113
		// (get) Token: 0x0603ABED RID: 240621 RVA: 0x007E621E File Offset: 0x007E441E
		// (set) Token: 0x0603ABEE RID: 240622 RVA: 0x007E6226 File Offset: 0x007E4426
		public TModifyActorMaterialType Type { get; set; }

		// Token: 0x1700F2A2 RID: 62114
		// (get) Token: 0x0603ABEF RID: 240623 RVA: 0x007E622F File Offset: 0x007E442F
		// (set) Token: 0x0603ABF0 RID: 240624 RVA: 0x007E6237 File Offset: 0x007E4437
		public object Value { get; set; }

		// Token: 0x0603ABF1 RID: 240625 RVA: 0x007E6240 File Offset: 0x007E4440
		public TModifyActorMaterialTypeUnion()
		{
			this.Type = TModifyActorMaterialType.NONE;
			this.Value = null;
		}

		// Token: 0x0603ABF2 RID: 240626 RVA: 0x007E6256 File Offset: 0x007E4456
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ABF3 RID: 240627 RVA: 0x007E6268 File Offset: 0x007E4468
		public IChangeActorMaterialDataT AsIChangeActorMaterialData()
		{
			return this.As<IChangeActorMaterialDataT>();
		}

		// Token: 0x0603ABF4 RID: 240628 RVA: 0x007E6270 File Offset: 0x007E4470
		public static TModifyActorMaterialTypeUnion FromIChangeActorMaterialData(IChangeActorMaterialDataT _ichangeactormaterialdata)
		{
			return new TModifyActorMaterialTypeUnion
			{
				Type = TModifyActorMaterialType.IChangeActorMaterialData,
				Value = _ichangeactormaterialdata
			};
		}

		// Token: 0x0603ABF5 RID: 240629 RVA: 0x007E6285 File Offset: 0x007E4485
		public IChangeActorMPCT AsIChangeActorMPC()
		{
			return this.As<IChangeActorMPCT>();
		}

		// Token: 0x0603ABF6 RID: 240630 RVA: 0x007E628D File Offset: 0x007E448D
		public static TModifyActorMaterialTypeUnion FromIChangeActorMPC(IChangeActorMPCT _ichangeactormpc)
		{
			return new TModifyActorMaterialTypeUnion
			{
				Type = TModifyActorMaterialType.IChangeActorMPC,
				Value = _ichangeactormpc
			};
		}

		// Token: 0x0603ABF7 RID: 240631 RVA: 0x007E62A4 File Offset: 0x007E44A4
		public static int Pack(FlatBufferBuilder builder, TModifyActorMaterialTypeUnion _o)
		{
			TModifyActorMaterialType type = _o.Type;
			if (type == TModifyActorMaterialType.IChangeActorMaterialData)
			{
				return IChangeActorMaterialData.Pack(builder, _o.AsIChangeActorMaterialData()).Value;
			}
			if (type != TModifyActorMaterialType.IChangeActorMPC)
			{
				return 0;
			}
			return IChangeActorMPC.Pack(builder, _o.AsIChangeActorMPC()).Value;
		}
	}
}
