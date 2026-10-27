using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007717 RID: 30487
	public class TModifyActorMaterialTypeUnion
	{
		// Token: 0x1700E653 RID: 58963
		// (get) Token: 0x060376C4 RID: 227012 RVA: 0x0078146A File Offset: 0x0077F66A
		// (set) Token: 0x060376C5 RID: 227013 RVA: 0x00781472 File Offset: 0x0077F672
		public TModifyActorMaterialType Type { get; set; }

		// Token: 0x1700E654 RID: 58964
		// (get) Token: 0x060376C6 RID: 227014 RVA: 0x0078147B File Offset: 0x0077F67B
		// (set) Token: 0x060376C7 RID: 227015 RVA: 0x00781483 File Offset: 0x0077F683
		public object Value { get; set; }

		// Token: 0x060376C8 RID: 227016 RVA: 0x0078148C File Offset: 0x0077F68C
		public TModifyActorMaterialTypeUnion()
		{
			this.Type = TModifyActorMaterialType.NONE;
			this.Value = null;
		}

		// Token: 0x060376C9 RID: 227017 RVA: 0x007814A2 File Offset: 0x0077F6A2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060376CA RID: 227018 RVA: 0x007814B4 File Offset: 0x0077F6B4
		public IChangeActorMaterialDataT AsIChangeActorMaterialData()
		{
			return this.As<IChangeActorMaterialDataT>();
		}

		// Token: 0x060376CB RID: 227019 RVA: 0x007814BC File Offset: 0x0077F6BC
		public static TModifyActorMaterialTypeUnion FromIChangeActorMaterialData(IChangeActorMaterialDataT _ichangeactormaterialdata)
		{
			return new TModifyActorMaterialTypeUnion
			{
				Type = TModifyActorMaterialType.IChangeActorMaterialData,
				Value = _ichangeactormaterialdata
			};
		}

		// Token: 0x060376CC RID: 227020 RVA: 0x007814D1 File Offset: 0x0077F6D1
		public IChangeActorMPCT AsIChangeActorMPC()
		{
			return this.As<IChangeActorMPCT>();
		}

		// Token: 0x060376CD RID: 227021 RVA: 0x007814D9 File Offset: 0x0077F6D9
		public static TModifyActorMaterialTypeUnion FromIChangeActorMPC(IChangeActorMPCT _ichangeactormpc)
		{
			return new TModifyActorMaterialTypeUnion
			{
				Type = TModifyActorMaterialType.IChangeActorMPC,
				Value = _ichangeactormpc
			};
		}

		// Token: 0x060376CE RID: 227022 RVA: 0x007814F0 File Offset: 0x0077F6F0
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
