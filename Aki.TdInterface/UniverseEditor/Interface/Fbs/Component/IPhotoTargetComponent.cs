using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D34 RID: 23860
	public struct IPhotoTargetComponent : IFlatbufferObject
	{
		// Token: 0x1700AF70 RID: 44912
		// (get) Token: 0x06027AAC RID: 162476 RVA: 0x0056D412 File Offset: 0x0056B612
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027AAD RID: 162477 RVA: 0x0056D41F File Offset: 0x0056B61F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027AAE RID: 162478 RVA: 0x0056D428 File Offset: 0x0056B628
		public static IPhotoTargetComponent GetRootAsIPhotoTargetComponent(ByteBuffer _bb)
		{
			return IPhotoTargetComponent.GetRootAsIPhotoTargetComponent(_bb, default(IPhotoTargetComponent));
		}

		// Token: 0x06027AAF RID: 162479 RVA: 0x0056D444 File Offset: 0x0056B644
		public static IPhotoTargetComponent GetRootAsIPhotoTargetComponent(ByteBuffer _bb, IPhotoTargetComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027AB0 RID: 162480 RVA: 0x0056D461 File Offset: 0x0056B661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027AB1 RID: 162481 RVA: 0x0056D470 File Offset: 0x0056B670
		public IPhotoTargetComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF71 RID: 44913
		// (get) Token: 0x06027AB2 RID: 162482 RVA: 0x0056D480 File Offset: 0x0056B680
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06027AB3 RID: 162483 RVA: 0x0056D4C0 File Offset: 0x0056B6C0
		public IVectorInfo? RequiredPoints(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF72 RID: 44914
		// (get) Token: 0x06027AB4 RID: 162484 RVA: 0x0056D520 File Offset: 0x0056B720
		public int RequiredPointsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AF73 RID: 44915
		// (get) Token: 0x06027AB5 RID: 162485 RVA: 0x0056D54C File Offset: 0x0056B74C
		public TPhotoTargetCaptureUi TargetCapturePromptUiType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TPhotoTargetCaptureUi.NONE;
				}
				return (TPhotoTargetCaptureUi)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027AB6 RID: 162486 RVA: 0x0056D588 File Offset: 0x0056B788
		public TTable? TargetCapturePromptUi<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027AB7 RID: 162487 RVA: 0x0056D5D0 File Offset: 0x0056B7D0
		public IPhotoTargetCaptureUiCustomPoints TargetCapturePromptUiAsIPhotoTargetCaptureUiCustomPoints()
		{
			return this.TargetCapturePromptUi<IPhotoTargetCaptureUiCustomPoints>().Value;
		}

		// Token: 0x06027AB8 RID: 162488 RVA: 0x0056D5EC File Offset: 0x0056B7EC
		public IPhotoTargetCaptureUiEachRequiredPoints TargetCapturePromptUiAsIPhotoTargetCaptureUiEachRequiredPoints()
		{
			return this.TargetCapturePromptUi<IPhotoTargetCaptureUiEachRequiredPoints>().Value;
		}

		// Token: 0x06027AB9 RID: 162489 RVA: 0x0056D608 File Offset: 0x0056B808
		public IPhotoTargetCaptureUiEntityZero TargetCapturePromptUiAsIPhotoTargetCaptureUiEntityZero()
		{
			return this.TargetCapturePromptUi<IPhotoTargetCaptureUiEntityZero>().Value;
		}

		// Token: 0x06027ABA RID: 162490 RVA: 0x0056D624 File Offset: 0x0056B824
		public IPhotoTargetCaptureUiRequiredPointsCenter TargetCapturePromptUiAsIPhotoTargetCaptureUiRequiredPointsCenter()
		{
			return this.TargetCapturePromptUi<IPhotoTargetCaptureUiRequiredPointsCenter>().Value;
		}

		// Token: 0x06027ABB RID: 162491 RVA: 0x0056D640 File Offset: 0x0056B840
		public int RayCastIgnoreEntities(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AF74 RID: 44916
		// (get) Token: 0x06027ABC RID: 162492 RVA: 0x0056D680 File Offset: 0x0056B880
		public int RayCastIgnoreEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06027ABD RID: 162493 RVA: 0x0056D6AC File Offset: 0x0056B8AC
		public Span<int> GetRayCastIgnoreEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06027ABE RID: 162494 RVA: 0x0056D6BC File Offset: 0x0056B8BC
		public int[] GetRayCastIgnoreEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x1700AF75 RID: 44917
		// (get) Token: 0x06027ABF RID: 162495 RVA: 0x0056D6CC File Offset: 0x0056B8CC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027AC0 RID: 162496 RVA: 0x0056D709 File Offset: 0x0056B909
		public static Offset<IPhotoTargetComponent> CreateIPhotoTargetComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset RequiredPointsOffset = default(VectorOffset), TPhotoTargetCaptureUi TargetCapturePromptUi_type = TPhotoTargetCaptureUi.NONE, int TargetCapturePromptUiOffset = 0, VectorOffset RayCastIgnoreEntitiesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IPhotoTargetComponent.AddRayCastIgnoreEntities(builder, RayCastIgnoreEntitiesOffset);
			IPhotoTargetComponent.AddTargetCapturePromptUi(builder, TargetCapturePromptUiOffset);
			IPhotoTargetComponent.AddRequiredPoints(builder, RequiredPointsOffset);
			IPhotoTargetComponent.AddNullMask(builder, NullMask);
			IPhotoTargetComponent.AddTargetCapturePromptUiType(builder, TargetCapturePromptUi_type);
			IPhotoTargetComponent.AddDisabled(builder, Disabled);
			return IPhotoTargetComponent.EndIPhotoTargetComponent(builder);
		}

		// Token: 0x06027AC1 RID: 162497 RVA: 0x0056D745 File Offset: 0x0056B945
		public static void StartIPhotoTargetComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06027AC2 RID: 162498 RVA: 0x0056D74E File Offset: 0x0056B94E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027AC3 RID: 162499 RVA: 0x0056D759 File Offset: 0x0056B959
		public static void AddRequiredPoints(FlatBufferBuilder builder, VectorOffset requiredPointsOffset)
		{
			builder.AddOffset(1, requiredPointsOffset.Value, 0);
		}

		// Token: 0x06027AC4 RID: 162500 RVA: 0x0056D76C File Offset: 0x0056B96C
		public static VectorOffset CreateRequiredPointsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027AC5 RID: 162501 RVA: 0x0056D7AC File Offset: 0x0056B9AC
		public static VectorOffset CreateRequiredPointsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027AC6 RID: 162502 RVA: 0x0056D7C6 File Offset: 0x0056B9C6
		public static VectorOffset CreateRequiredPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027AC7 RID: 162503 RVA: 0x0056D7E4 File Offset: 0x0056B9E4
		public static VectorOffset CreateRequiredPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027AC8 RID: 162504 RVA: 0x0056D7FD File Offset: 0x0056B9FD
		public static void StartRequiredPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027AC9 RID: 162505 RVA: 0x0056D808 File Offset: 0x0056BA08
		public static void AddTargetCapturePromptUiType(FlatBufferBuilder builder, TPhotoTargetCaptureUi targetCapturePromptUiType)
		{
			builder.AddByte(2, (byte)targetCapturePromptUiType, 0);
		}

		// Token: 0x06027ACA RID: 162506 RVA: 0x0056D813 File Offset: 0x0056BA13
		public static void AddTargetCapturePromptUi(FlatBufferBuilder builder, int targetCapturePromptUiOffset)
		{
			builder.AddOffset(3, targetCapturePromptUiOffset, 0);
		}

		// Token: 0x06027ACB RID: 162507 RVA: 0x0056D81E File Offset: 0x0056BA1E
		public static void AddRayCastIgnoreEntities(FlatBufferBuilder builder, VectorOffset rayCastIgnoreEntitiesOffset)
		{
			builder.AddOffset(4, rayCastIgnoreEntitiesOffset.Value, 0);
		}

		// Token: 0x06027ACC RID: 162508 RVA: 0x0056D830 File Offset: 0x0056BA30
		public static VectorOffset CreateRayCastIgnoreEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027ACD RID: 162509 RVA: 0x0056D867 File Offset: 0x0056BA67
		public static VectorOffset CreateRayCastIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027ACE RID: 162510 RVA: 0x0056D881 File Offset: 0x0056BA81
		public static VectorOffset CreateRayCastIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027ACF RID: 162511 RVA: 0x0056D89F File Offset: 0x0056BA9F
		public static VectorOffset CreateRayCastIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027AD0 RID: 162512 RVA: 0x0056D8B8 File Offset: 0x0056BAB8
		public static void StartRayCastIgnoreEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027AD1 RID: 162513 RVA: 0x0056D8C3 File Offset: 0x0056BAC3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06027AD2 RID: 162514 RVA: 0x0056D8CE File Offset: 0x0056BACE
		public static Offset<IPhotoTargetComponent> EndIPhotoTargetComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetComponent>(builder.EndTable());
		}

		// Token: 0x06027AD3 RID: 162515 RVA: 0x0056D8DC File Offset: 0x0056BADC
		public IPhotoTargetComponentT UnPack()
		{
			IPhotoTargetComponentT photoTargetComponentT = new IPhotoTargetComponentT();
			this.UnPackTo(photoTargetComponentT);
			return photoTargetComponentT;
		}

		// Token: 0x06027AD4 RID: 162516 RVA: 0x0056D8F8 File Offset: 0x0056BAF8
		public void UnPackTo(IPhotoTargetComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.RequiredPoints = new List<IVectorInfoT>();
			for (int i = 0; i < this.RequiredPointsLength; i++)
			{
				_o.RequiredPoints.Add((this.RequiredPoints(i) != null) ? this.RequiredPoints(i).Value.UnPack() : null);
			}
			_o.TargetCapturePromptUi = new TPhotoTargetCaptureUiUnion();
			_o.TargetCapturePromptUi.Type = this.TargetCapturePromptUiType;
			switch (this.TargetCapturePromptUiType)
			{
			case TPhotoTargetCaptureUi.IPhotoTargetCaptureUiCustomPoints:
				_o.TargetCapturePromptUi.Value = ((this.TargetCapturePromptUi<IPhotoTargetCaptureUiCustomPoints>() != null) ? this.TargetCapturePromptUi<IPhotoTargetCaptureUiCustomPoints>().Value.UnPack() : null);
				break;
			case TPhotoTargetCaptureUi.IPhotoTargetCaptureUiEachRequiredPoints:
				_o.TargetCapturePromptUi.Value = ((this.TargetCapturePromptUi<IPhotoTargetCaptureUiEachRequiredPoints>() != null) ? this.TargetCapturePromptUi<IPhotoTargetCaptureUiEachRequiredPoints>().Value.UnPack() : null);
				break;
			case TPhotoTargetCaptureUi.IPhotoTargetCaptureUiEntityZero:
				_o.TargetCapturePromptUi.Value = ((this.TargetCapturePromptUi<IPhotoTargetCaptureUiEntityZero>() != null) ? this.TargetCapturePromptUi<IPhotoTargetCaptureUiEntityZero>().Value.UnPack() : null);
				break;
			case TPhotoTargetCaptureUi.IPhotoTargetCaptureUiRequiredPointsCenter:
				_o.TargetCapturePromptUi.Value = ((this.TargetCapturePromptUi<IPhotoTargetCaptureUiRequiredPointsCenter>() != null) ? this.TargetCapturePromptUi<IPhotoTargetCaptureUiRequiredPointsCenter>().Value.UnPack() : null);
				break;
			}
			_o.RayCastIgnoreEntities = new List<int>();
			for (int j = 0; j < this.RayCastIgnoreEntitiesLength; j++)
			{
				_o.RayCastIgnoreEntities.Add(this.RayCastIgnoreEntities(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027AD5 RID: 162517 RVA: 0x0056DAC8 File Offset: 0x0056BCC8
		public static Offset<IPhotoTargetComponent> Pack(FlatBufferBuilder builder, IPhotoTargetComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTargetComponent>);
			}
			VectorOffset requiredPointsOffset = default(VectorOffset);
			if (_o.RequiredPoints != null)
			{
				Offset<IVectorInfo>[] array = new Offset<IVectorInfo>[_o.RequiredPoints.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVectorInfo.Pack(builder, _o.RequiredPoints[i]);
				}
				requiredPointsOffset = IPhotoTargetComponent.CreateRequiredPointsVector(builder, array);
			}
			TPhotoTargetCaptureUi targetCapturePromptUi_type = (_o.TargetCapturePromptUi == null) ? TPhotoTargetCaptureUi.NONE : _o.TargetCapturePromptUi.Type;
			int targetCapturePromptUiOffset = (_o.TargetCapturePromptUi == null) ? 0 : TPhotoTargetCaptureUiUnion.Pack(builder, _o.TargetCapturePromptUi);
			VectorOffset rayCastIgnoreEntitiesOffset = default(VectorOffset);
			if (_o.RayCastIgnoreEntities != null)
			{
				int[] data = _o.RayCastIgnoreEntities.ToArray();
				rayCastIgnoreEntitiesOffset = IPhotoTargetComponent.CreateRayCastIgnoreEntitiesVector(builder, data);
			}
			return IPhotoTargetComponent.CreateIPhotoTargetComponent(builder, _o.Disabled, requiredPointsOffset, targetCapturePromptUi_type, targetCapturePromptUiOffset, rayCastIgnoreEntitiesOffset, _o.NullMask);
		}

		// Token: 0x0400F893 RID: 63635
		private Table __p;
	}
}
