using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BA4 RID: 19364
	public struct IFlowTemplateData : IFlatbufferObject
	{
		// Token: 0x1700890B RID: 35083
		// (get) Token: 0x0601D88C RID: 120972 RVA: 0x004257AB File Offset: 0x004239AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D88D RID: 120973 RVA: 0x004257B8 File Offset: 0x004239B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D88E RID: 120974 RVA: 0x004257C0 File Offset: 0x004239C0
		public static IFlowTemplateData GetRootAsIFlowTemplateData(ByteBuffer _bb)
		{
			return IFlowTemplateData.GetRootAsIFlowTemplateData(_bb, default(IFlowTemplateData));
		}

		// Token: 0x0601D88F RID: 120975 RVA: 0x004257DC File Offset: 0x004239DC
		public static IFlowTemplateData GetRootAsIFlowTemplateData(ByteBuffer _bb, IFlowTemplateData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D890 RID: 120976 RVA: 0x004257F9 File Offset: 0x004239F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D891 RID: 120977 RVA: 0x00425808 File Offset: 0x00423A08
		public IFlowTemplateData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700890C RID: 35084
		// (get) Token: 0x0601D892 RID: 120978 RVA: 0x00425818 File Offset: 0x00423A18
		public int TemplateId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700890D RID: 35085
		// (get) Token: 0x0601D893 RID: 120979 RVA: 0x00425854 File Offset: 0x00423A54
		public string Name
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

		// Token: 0x0601D894 RID: 120980 RVA: 0x0042588B File Offset: 0x00423A8B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D895 RID: 120981 RVA: 0x0042589A File Offset: 0x00423A9A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601D896 RID: 120982 RVA: 0x004258A8 File Offset: 0x00423AA8
		public IPosA? ActorDataArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IPosA?(default(IPosA).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700890E RID: 35086
		// (get) Token: 0x0601D897 RID: 120983 RVA: 0x00425908 File Offset: 0x00423B08
		public int ActorDataArrayLength
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

		// Token: 0x0601D898 RID: 120984 RVA: 0x00425934 File Offset: 0x00423B34
		public ICameraParam? CameraParamMap(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ICameraParam?(default(ICameraParam).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700890F RID: 35087
		// (get) Token: 0x0601D899 RID: 120985 RVA: 0x00425998 File Offset: 0x00423B98
		public int CameraParamMapLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601D89A RID: 120986 RVA: 0x004259C4 File Offset: 0x00423BC4
		public static Offset<IFlowTemplateData> CreateIFlowTemplateData(FlatBufferBuilder builder, int TemplateId = 0, StringOffset NameOffset = default(StringOffset), VectorOffset ActorDataArrayOffset = default(VectorOffset), VectorOffset CameraParamMapOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IFlowTemplateData.AddCameraParamMap(builder, CameraParamMapOffset);
			IFlowTemplateData.AddActorDataArray(builder, ActorDataArrayOffset);
			IFlowTemplateData.AddName(builder, NameOffset);
			IFlowTemplateData.AddTemplateId(builder, TemplateId);
			return IFlowTemplateData.EndIFlowTemplateData(builder);
		}

		// Token: 0x0601D89B RID: 120987 RVA: 0x004259F0 File Offset: 0x00423BF0
		public static void StartIFlowTemplateData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D89C RID: 120988 RVA: 0x004259F9 File Offset: 0x00423BF9
		public static void AddTemplateId(FlatBufferBuilder builder, int templateId)
		{
			builder.AddInt(0, templateId, 0);
		}

		// Token: 0x0601D89D RID: 120989 RVA: 0x00425A04 File Offset: 0x00423C04
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601D89E RID: 120990 RVA: 0x00425A14 File Offset: 0x00423C14
		public static void AddActorDataArray(FlatBufferBuilder builder, VectorOffset actorDataArrayOffset)
		{
			builder.AddOffset(2, actorDataArrayOffset.Value, 0);
		}

		// Token: 0x0601D89F RID: 120991 RVA: 0x00425A24 File Offset: 0x00423C24
		public static VectorOffset CreateActorDataArrayVector(FlatBufferBuilder builder, Offset<IPosA>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D8A0 RID: 120992 RVA: 0x00425A64 File Offset: 0x00423C64
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, Offset<IPosA>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPosA>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D8A1 RID: 120993 RVA: 0x00425A7E File Offset: 0x00423C7E
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPosA>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPosA>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D8A2 RID: 120994 RVA: 0x00425A9C File Offset: 0x00423C9C
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPosA>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D8A3 RID: 120995 RVA: 0x00425AB5 File Offset: 0x00423CB5
		public static void StartActorDataArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D8A4 RID: 120996 RVA: 0x00425AC0 File Offset: 0x00423CC0
		public static void AddCameraParamMap(FlatBufferBuilder builder, VectorOffset cameraParamMapOffset)
		{
			builder.AddOffset(3, cameraParamMapOffset.Value, 0);
		}

		// Token: 0x0601D8A5 RID: 120997 RVA: 0x00425AD0 File Offset: 0x00423CD0
		public static VectorOffset CreateCameraParamMapVector(FlatBufferBuilder builder, Offset<ICameraParam>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D8A6 RID: 120998 RVA: 0x00425B10 File Offset: 0x00423D10
		public static VectorOffset CreateCameraParamMapVectorBlock(FlatBufferBuilder builder, Offset<ICameraParam>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICameraParam>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D8A7 RID: 120999 RVA: 0x00425B2A File Offset: 0x00423D2A
		public static VectorOffset CreateCameraParamMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICameraParam>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICameraParam>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D8A8 RID: 121000 RVA: 0x00425B48 File Offset: 0x00423D48
		public static VectorOffset CreateCameraParamMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICameraParam>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D8A9 RID: 121001 RVA: 0x00425B61 File Offset: 0x00423D61
		public static void StartCameraParamMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D8AA RID: 121002 RVA: 0x00425B6C File Offset: 0x00423D6C
		public static Offset<IFlowTemplateData> EndIFlowTemplateData(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateData>(builder.EndTable());
		}

		// Token: 0x0601D8AB RID: 121003 RVA: 0x00425B7C File Offset: 0x00423D7C
		public IFlowTemplateDataT UnPack()
		{
			IFlowTemplateDataT flowTemplateDataT = new IFlowTemplateDataT();
			this.UnPackTo(flowTemplateDataT);
			return flowTemplateDataT;
		}

		// Token: 0x0601D8AC RID: 121004 RVA: 0x00425B98 File Offset: 0x00423D98
		public void UnPackTo(IFlowTemplateDataT _o)
		{
			_o.TemplateId = this.TemplateId;
			_o.Name = this.Name;
			_o.ActorDataArray = new List<IPosAT>();
			for (int i = 0; i < this.ActorDataArrayLength; i++)
			{
				_o.ActorDataArray.Add((this.ActorDataArray(i) != null) ? this.ActorDataArray(i).Value.UnPack() : null);
			}
			_o.CameraParamMap = new List<ICameraParamT>();
			for (int j = 0; j < this.CameraParamMapLength; j++)
			{
				_o.CameraParamMap.Add((this.CameraParamMap(j) != null) ? this.CameraParamMap(j).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D8AD RID: 121005 RVA: 0x00425C64 File Offset: 0x00423E64
		public static Offset<IFlowTemplateData> Pack(FlatBufferBuilder builder, IFlowTemplateDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTemplateData>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			VectorOffset actorDataArrayOffset = default(VectorOffset);
			if (_o.ActorDataArray != null)
			{
				Offset<IPosA>[] array = new Offset<IPosA>[_o.ActorDataArray.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPosA.Pack(builder, _o.ActorDataArray[i]);
				}
				actorDataArrayOffset = IFlowTemplateData.CreateActorDataArrayVector(builder, array);
			}
			VectorOffset cameraParamMapOffset = default(VectorOffset);
			if (_o.CameraParamMap != null)
			{
				Offset<ICameraParam>[] array2 = new Offset<ICameraParam>[_o.CameraParamMap.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ICameraParam.Pack(builder, _o.CameraParamMap[j]);
				}
				cameraParamMapOffset = IFlowTemplateData.CreateCameraParamMapVector(builder, array2);
			}
			return IFlowTemplateData.CreateIFlowTemplateData(builder, _o.TemplateId, nameOffset, actorDataArrayOffset, cameraParamMapOffset);
		}

		// Token: 0x0400D451 RID: 54353
		private Table __p;
	}
}
