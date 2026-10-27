using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572D RID: 22317
	public struct IPhotoTargetComponent : IFlatbufferObject
	{
		// Token: 0x1700A64C RID: 42572
		// (get) Token: 0x0602558C RID: 152972 RVA: 0x00527286 File Offset: 0x00525486
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602558D RID: 152973 RVA: 0x00527293 File Offset: 0x00525493
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602558E RID: 152974 RVA: 0x0052729C File Offset: 0x0052549C
		public static IPhotoTargetComponent GetRootAsIPhotoTargetComponent(ByteBuffer _bb)
		{
			return IPhotoTargetComponent.GetRootAsIPhotoTargetComponent(_bb, default(IPhotoTargetComponent));
		}

		// Token: 0x0602558F RID: 152975 RVA: 0x005272B8 File Offset: 0x005254B8
		public static IPhotoTargetComponent GetRootAsIPhotoTargetComponent(ByteBuffer _bb, IPhotoTargetComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025590 RID: 152976 RVA: 0x005272D5 File Offset: 0x005254D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025591 RID: 152977 RVA: 0x005272E4 File Offset: 0x005254E4
		public IPhotoTargetComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A64D RID: 42573
		// (get) Token: 0x06025592 RID: 152978 RVA: 0x005272F4 File Offset: 0x005254F4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025593 RID: 152979 RVA: 0x00527334 File Offset: 0x00525534
		public IVectorInfo? RequiredPoints(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A64E RID: 42574
		// (get) Token: 0x06025594 RID: 152980 RVA: 0x00527394 File Offset: 0x00525594
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

		// Token: 0x1700A64F RID: 42575
		// (get) Token: 0x06025595 RID: 152981 RVA: 0x005273C0 File Offset: 0x005255C0
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

		// Token: 0x06025596 RID: 152982 RVA: 0x005273FC File Offset: 0x005255FC
		public TTable? TargetCapturePromptUi<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025597 RID: 152983 RVA: 0x00527444 File Offset: 0x00525644
		public IPhotoTargetCaptureUiCustomPoints TargetCapturePromptUiAsIPhotoTargetCaptureUiCustomPoints()
		{
			return this.TargetCapturePromptUi<IPhotoTargetCaptureUiCustomPoints>().Value;
		}

		// Token: 0x06025598 RID: 152984 RVA: 0x00527460 File Offset: 0x00525660
		public IPhotoTargetCaptureUiEachRequiredPoints TargetCapturePromptUiAsIPhotoTargetCaptureUiEachRequiredPoints()
		{
			return this.TargetCapturePromptUi<IPhotoTargetCaptureUiEachRequiredPoints>().Value;
		}

		// Token: 0x06025599 RID: 152985 RVA: 0x0052747C File Offset: 0x0052567C
		public IPhotoTargetCaptureUiEntityZero TargetCapturePromptUiAsIPhotoTargetCaptureUiEntityZero()
		{
			return this.TargetCapturePromptUi<IPhotoTargetCaptureUiEntityZero>().Value;
		}

		// Token: 0x0602559A RID: 152986 RVA: 0x00527498 File Offset: 0x00525698
		public IPhotoTargetCaptureUiRequiredPointsCenter TargetCapturePromptUiAsIPhotoTargetCaptureUiRequiredPointsCenter()
		{
			return this.TargetCapturePromptUi<IPhotoTargetCaptureUiRequiredPointsCenter>().Value;
		}

		// Token: 0x0602559B RID: 152987 RVA: 0x005274B4 File Offset: 0x005256B4
		public int RayCastIgnoreEntities(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A650 RID: 42576
		// (get) Token: 0x0602559C RID: 152988 RVA: 0x005274F4 File Offset: 0x005256F4
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

		// Token: 0x0602559D RID: 152989 RVA: 0x00527520 File Offset: 0x00525720
		public Span<int> GetRayCastIgnoreEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0602559E RID: 152990 RVA: 0x00527530 File Offset: 0x00525730
		public int[] GetRayCastIgnoreEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x1700A651 RID: 42577
		// (get) Token: 0x0602559F RID: 152991 RVA: 0x00527540 File Offset: 0x00525740
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

		// Token: 0x060255A0 RID: 152992 RVA: 0x0052757D File Offset: 0x0052577D
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

		// Token: 0x060255A1 RID: 152993 RVA: 0x005275B9 File Offset: 0x005257B9
		public static void StartIPhotoTargetComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060255A2 RID: 152994 RVA: 0x005275C2 File Offset: 0x005257C2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060255A3 RID: 152995 RVA: 0x005275CD File Offset: 0x005257CD
		public static void AddRequiredPoints(FlatBufferBuilder builder, VectorOffset requiredPointsOffset)
		{
			builder.AddOffset(1, requiredPointsOffset.Value, 0);
		}

		// Token: 0x060255A4 RID: 152996 RVA: 0x005275E0 File Offset: 0x005257E0
		public static VectorOffset CreateRequiredPointsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060255A5 RID: 152997 RVA: 0x00527620 File Offset: 0x00525820
		public static VectorOffset CreateRequiredPointsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060255A6 RID: 152998 RVA: 0x0052763A File Offset: 0x0052583A
		public static VectorOffset CreateRequiredPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060255A7 RID: 152999 RVA: 0x00527658 File Offset: 0x00525858
		public static VectorOffset CreateRequiredPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060255A8 RID: 153000 RVA: 0x00527671 File Offset: 0x00525871
		public static void StartRequiredPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060255A9 RID: 153001 RVA: 0x0052767C File Offset: 0x0052587C
		public static void AddTargetCapturePromptUiType(FlatBufferBuilder builder, TPhotoTargetCaptureUi targetCapturePromptUiType)
		{
			builder.AddByte(2, (byte)targetCapturePromptUiType, 0);
		}

		// Token: 0x060255AA RID: 153002 RVA: 0x00527687 File Offset: 0x00525887
		public static void AddTargetCapturePromptUi(FlatBufferBuilder builder, int targetCapturePromptUiOffset)
		{
			builder.AddOffset(3, targetCapturePromptUiOffset, 0);
		}

		// Token: 0x060255AB RID: 153003 RVA: 0x00527692 File Offset: 0x00525892
		public static void AddRayCastIgnoreEntities(FlatBufferBuilder builder, VectorOffset rayCastIgnoreEntitiesOffset)
		{
			builder.AddOffset(4, rayCastIgnoreEntitiesOffset.Value, 0);
		}

		// Token: 0x060255AC RID: 153004 RVA: 0x005276A4 File Offset: 0x005258A4
		public static VectorOffset CreateRayCastIgnoreEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060255AD RID: 153005 RVA: 0x005276DB File Offset: 0x005258DB
		public static VectorOffset CreateRayCastIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060255AE RID: 153006 RVA: 0x005276F5 File Offset: 0x005258F5
		public static VectorOffset CreateRayCastIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060255AF RID: 153007 RVA: 0x00527713 File Offset: 0x00525913
		public static VectorOffset CreateRayCastIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060255B0 RID: 153008 RVA: 0x0052772C File Offset: 0x0052592C
		public static void StartRayCastIgnoreEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060255B1 RID: 153009 RVA: 0x00527737 File Offset: 0x00525937
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060255B2 RID: 153010 RVA: 0x00527742 File Offset: 0x00525942
		public static Offset<IPhotoTargetComponent> EndIPhotoTargetComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetComponent>(builder.EndTable());
		}

		// Token: 0x060255B3 RID: 153011 RVA: 0x00527750 File Offset: 0x00525950
		public IPhotoTargetComponentT UnPack()
		{
			IPhotoTargetComponentT photoTargetComponentT = new IPhotoTargetComponentT();
			this.UnPackTo(photoTargetComponentT);
			return photoTargetComponentT;
		}

		// Token: 0x060255B4 RID: 153012 RVA: 0x0052776C File Offset: 0x0052596C
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

		// Token: 0x060255B5 RID: 153013 RVA: 0x0052793C File Offset: 0x00525B3C
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

		// Token: 0x0400EBA8 RID: 60328
		private Table __p;
	}
}
