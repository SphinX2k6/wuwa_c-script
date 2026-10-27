using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062C0 RID: 25280
	public struct IChangeActorMaterialData : IFlatbufferObject
	{
		// Token: 0x1700BCB6 RID: 48310
		// (get) Token: 0x0602BAFF RID: 178943 RVA: 0x0060348E File Offset: 0x0060168E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB00 RID: 178944 RVA: 0x0060349B File Offset: 0x0060169B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB01 RID: 178945 RVA: 0x006034A4 File Offset: 0x006016A4
		public static IChangeActorMaterialData GetRootAsIChangeActorMaterialData(ByteBuffer _bb)
		{
			return IChangeActorMaterialData.GetRootAsIChangeActorMaterialData(_bb, default(IChangeActorMaterialData));
		}

		// Token: 0x0602BB02 RID: 178946 RVA: 0x006034C0 File Offset: 0x006016C0
		public static IChangeActorMaterialData GetRootAsIChangeActorMaterialData(ByteBuffer _bb, IChangeActorMaterialData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB03 RID: 178947 RVA: 0x006034DD File Offset: 0x006016DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB04 RID: 178948 RVA: 0x006034EC File Offset: 0x006016EC
		public IChangeActorMaterialData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCB7 RID: 48311
		// (get) Token: 0x0602BB05 RID: 178949 RVA: 0x006034FC File Offset: 0x006016FC
		public EModifyActorMaterialType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModifyActorMaterialType.ChangeMaterialData;
				}
				return (EModifyActorMaterialType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BCB8 RID: 48312
		// (get) Token: 0x0602BB06 RID: 178950 RVA: 0x00603538 File Offset: 0x00601738
		public string MaterialData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BB07 RID: 178951 RVA: 0x0060356F File Offset: 0x0060176F
		public Span<byte> GetMaterialDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602BB08 RID: 178952 RVA: 0x0060357E File Offset: 0x0060177E
		public byte[] GetMaterialDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602BB09 RID: 178953 RVA: 0x0060358C File Offset: 0x0060178C
		public IActorRef? ActorRefs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BCB9 RID: 48313
		// (get) Token: 0x0602BB0A RID: 178954 RVA: 0x006035EC File Offset: 0x006017EC
		public int ActorRefsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602BB0B RID: 178955 RVA: 0x00603617 File Offset: 0x00601817
		public static Offset<IChangeActorMaterialData> CreateIChangeActorMaterialData(FlatBufferBuilder builder, EModifyActorMaterialType Type = EModifyActorMaterialType.ChangeMaterialData, StringOffset MaterialDataOffset = default(StringOffset), VectorOffset ActorRefsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IChangeActorMaterialData.AddActorRefs(builder, ActorRefsOffset);
			IChangeActorMaterialData.AddMaterialData(builder, MaterialDataOffset);
			IChangeActorMaterialData.AddType(builder, Type);
			return IChangeActorMaterialData.EndIChangeActorMaterialData(builder);
		}

		// Token: 0x0602BB0C RID: 178956 RVA: 0x0060363B File Offset: 0x0060183B
		public static void StartIChangeActorMaterialData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BB0D RID: 178957 RVA: 0x00603644 File Offset: 0x00601844
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BB0E RID: 178958 RVA: 0x0060364F File Offset: 0x0060184F
		public static void AddMaterialData(FlatBufferBuilder builder, StringOffset materialDataOffset)
		{
			builder.AddOffset(1, materialDataOffset.Value, 0);
		}

		// Token: 0x0602BB0F RID: 178959 RVA: 0x0060365F File Offset: 0x0060185F
		public static void AddActorRefs(FlatBufferBuilder builder, VectorOffset actorRefsOffset)
		{
			builder.AddOffset(2, actorRefsOffset.Value, 0);
		}

		// Token: 0x0602BB10 RID: 178960 RVA: 0x00603670 File Offset: 0x00601870
		public static VectorOffset CreateActorRefsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BB11 RID: 178961 RVA: 0x006036B0 File Offset: 0x006018B0
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BB12 RID: 178962 RVA: 0x006036CA File Offset: 0x006018CA
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BB13 RID: 178963 RVA: 0x006036E8 File Offset: 0x006018E8
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BB14 RID: 178964 RVA: 0x00603701 File Offset: 0x00601901
		public static void StartActorRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BB15 RID: 178965 RVA: 0x0060370C File Offset: 0x0060190C
		public static Offset<IChangeActorMaterialData> EndIChangeActorMaterialData(FlatBufferBuilder builder)
		{
			return new Offset<IChangeActorMaterialData>(builder.EndTable());
		}

		// Token: 0x0602BB16 RID: 178966 RVA: 0x0060371C File Offset: 0x0060191C
		public IChangeActorMaterialDataT UnPack()
		{
			IChangeActorMaterialDataT changeActorMaterialDataT = new IChangeActorMaterialDataT();
			this.UnPackTo(changeActorMaterialDataT);
			return changeActorMaterialDataT;
		}

		// Token: 0x0602BB17 RID: 178967 RVA: 0x00603738 File Offset: 0x00601938
		public void UnPackTo(IChangeActorMaterialDataT _o)
		{
			_o.Type = this.Type;
			_o.MaterialData = this.MaterialData;
			_o.ActorRefs = new List<IActorRefT>();
			for (int i = 0; i < this.ActorRefsLength; i++)
			{
				_o.ActorRefs.Add((this.ActorRefs(i) != null) ? this.ActorRefs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602BB18 RID: 178968 RVA: 0x006037B0 File Offset: 0x006019B0
		public static Offset<IChangeActorMaterialData> Pack(FlatBufferBuilder builder, IChangeActorMaterialDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeActorMaterialData>);
			}
			StringOffset materialDataOffset = (_o.MaterialData == null) ? default(StringOffset) : builder.CreateString(_o.MaterialData);
			VectorOffset actorRefsOffset = default(VectorOffset);
			if (_o.ActorRefs != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.ActorRefs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.ActorRefs[i]);
				}
				actorRefsOffset = IChangeActorMaterialData.CreateActorRefsVector(builder, array);
			}
			return IChangeActorMaterialData.CreateIChangeActorMaterialData(builder, _o.Type, materialDataOffset, actorRefsOffset);
		}

		// Token: 0x04010866 RID: 67686
		private Table __p;
	}
}
