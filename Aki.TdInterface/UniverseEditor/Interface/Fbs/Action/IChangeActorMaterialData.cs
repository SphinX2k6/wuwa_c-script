using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006931 RID: 26929
	public struct IChangeActorMaterialData : IFlatbufferObject
	{
		// Token: 0x1700C640 RID: 50752
		// (get) Token: 0x0602E268 RID: 189032 RVA: 0x0064E49A File Offset: 0x0064C69A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E269 RID: 189033 RVA: 0x0064E4A7 File Offset: 0x0064C6A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E26A RID: 189034 RVA: 0x0064E4B0 File Offset: 0x0064C6B0
		public static IChangeActorMaterialData GetRootAsIChangeActorMaterialData(ByteBuffer _bb)
		{
			return IChangeActorMaterialData.GetRootAsIChangeActorMaterialData(_bb, default(IChangeActorMaterialData));
		}

		// Token: 0x0602E26B RID: 189035 RVA: 0x0064E4CC File Offset: 0x0064C6CC
		public static IChangeActorMaterialData GetRootAsIChangeActorMaterialData(ByteBuffer _bb, IChangeActorMaterialData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E26C RID: 189036 RVA: 0x0064E4E9 File Offset: 0x0064C6E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E26D RID: 189037 RVA: 0x0064E4F8 File Offset: 0x0064C6F8
		public IChangeActorMaterialData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C641 RID: 50753
		// (get) Token: 0x0602E26E RID: 189038 RVA: 0x0064E508 File Offset: 0x0064C708
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

		// Token: 0x1700C642 RID: 50754
		// (get) Token: 0x0602E26F RID: 189039 RVA: 0x0064E544 File Offset: 0x0064C744
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

		// Token: 0x0602E270 RID: 189040 RVA: 0x0064E57B File Offset: 0x0064C77B
		public Span<byte> GetMaterialDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E271 RID: 189041 RVA: 0x0064E58A File Offset: 0x0064C78A
		public byte[] GetMaterialDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E272 RID: 189042 RVA: 0x0064E598 File Offset: 0x0064C798
		public IActorRef? ActorRefs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C643 RID: 50755
		// (get) Token: 0x0602E273 RID: 189043 RVA: 0x0064E5F8 File Offset: 0x0064C7F8
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

		// Token: 0x0602E274 RID: 189044 RVA: 0x0064E623 File Offset: 0x0064C823
		public static Offset<IChangeActorMaterialData> CreateIChangeActorMaterialData(FlatBufferBuilder builder, EModifyActorMaterialType Type = EModifyActorMaterialType.ChangeMaterialData, StringOffset MaterialDataOffset = default(StringOffset), VectorOffset ActorRefsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IChangeActorMaterialData.AddActorRefs(builder, ActorRefsOffset);
			IChangeActorMaterialData.AddMaterialData(builder, MaterialDataOffset);
			IChangeActorMaterialData.AddType(builder, Type);
			return IChangeActorMaterialData.EndIChangeActorMaterialData(builder);
		}

		// Token: 0x0602E275 RID: 189045 RVA: 0x0064E647 File Offset: 0x0064C847
		public static void StartIChangeActorMaterialData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E276 RID: 189046 RVA: 0x0064E650 File Offset: 0x0064C850
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E277 RID: 189047 RVA: 0x0064E65B File Offset: 0x0064C85B
		public static void AddMaterialData(FlatBufferBuilder builder, StringOffset materialDataOffset)
		{
			builder.AddOffset(1, materialDataOffset.Value, 0);
		}

		// Token: 0x0602E278 RID: 189048 RVA: 0x0064E66B File Offset: 0x0064C86B
		public static void AddActorRefs(FlatBufferBuilder builder, VectorOffset actorRefsOffset)
		{
			builder.AddOffset(2, actorRefsOffset.Value, 0);
		}

		// Token: 0x0602E279 RID: 189049 RVA: 0x0064E67C File Offset: 0x0064C87C
		public static VectorOffset CreateActorRefsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E27A RID: 189050 RVA: 0x0064E6BC File Offset: 0x0064C8BC
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E27B RID: 189051 RVA: 0x0064E6D6 File Offset: 0x0064C8D6
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E27C RID: 189052 RVA: 0x0064E6F4 File Offset: 0x0064C8F4
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E27D RID: 189053 RVA: 0x0064E70D File Offset: 0x0064C90D
		public static void StartActorRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E27E RID: 189054 RVA: 0x0064E718 File Offset: 0x0064C918
		public static Offset<IChangeActorMaterialData> EndIChangeActorMaterialData(FlatBufferBuilder builder)
		{
			return new Offset<IChangeActorMaterialData>(builder.EndTable());
		}

		// Token: 0x0602E27F RID: 189055 RVA: 0x0064E728 File Offset: 0x0064C928
		public IChangeActorMaterialDataT UnPack()
		{
			IChangeActorMaterialDataT changeActorMaterialDataT = new IChangeActorMaterialDataT();
			this.UnPackTo(changeActorMaterialDataT);
			return changeActorMaterialDataT;
		}

		// Token: 0x0602E280 RID: 189056 RVA: 0x0064E744 File Offset: 0x0064C944
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

		// Token: 0x0602E281 RID: 189057 RVA: 0x0064E7BC File Offset: 0x0064C9BC
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

		// Token: 0x0401167C RID: 71292
		private Table __p;
	}
}
