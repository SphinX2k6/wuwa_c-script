using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200473C RID: 18236
	public struct IFlowTemplateData : IFlatbufferObject
	{
		// Token: 0x170082CA RID: 33482
		// (get) Token: 0x0601C0B7 RID: 114871 RVA: 0x003F950F File Offset: 0x003F770F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C0B8 RID: 114872 RVA: 0x003F951C File Offset: 0x003F771C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C0B9 RID: 114873 RVA: 0x003F9524 File Offset: 0x003F7724
		public static IFlowTemplateData GetRootAsIFlowTemplateData(ByteBuffer _bb)
		{
			return IFlowTemplateData.GetRootAsIFlowTemplateData(_bb, default(IFlowTemplateData));
		}

		// Token: 0x0601C0BA RID: 114874 RVA: 0x003F9540 File Offset: 0x003F7740
		public static IFlowTemplateData GetRootAsIFlowTemplateData(ByteBuffer _bb, IFlowTemplateData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C0BB RID: 114875 RVA: 0x003F955D File Offset: 0x003F775D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C0BC RID: 114876 RVA: 0x003F956C File Offset: 0x003F776C
		public IFlowTemplateData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082CB RID: 33483
		// (get) Token: 0x0601C0BD RID: 114877 RVA: 0x003F957C File Offset: 0x003F777C
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

		// Token: 0x170082CC RID: 33484
		// (get) Token: 0x0601C0BE RID: 114878 RVA: 0x003F95B8 File Offset: 0x003F77B8
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

		// Token: 0x0601C0BF RID: 114879 RVA: 0x003F95EF File Offset: 0x003F77EF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C0C0 RID: 114880 RVA: 0x003F95FE File Offset: 0x003F77FE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601C0C1 RID: 114881 RVA: 0x003F960C File Offset: 0x003F780C
		public IPosA? ActorDataArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IPosA?(default(IPosA).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082CD RID: 33485
		// (get) Token: 0x0601C0C2 RID: 114882 RVA: 0x003F966C File Offset: 0x003F786C
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

		// Token: 0x0601C0C3 RID: 114883 RVA: 0x003F9698 File Offset: 0x003F7898
		public ICameraParam? CameraParamMap(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ICameraParam?(default(ICameraParam).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082CE RID: 33486
		// (get) Token: 0x0601C0C4 RID: 114884 RVA: 0x003F96FC File Offset: 0x003F78FC
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

		// Token: 0x0601C0C5 RID: 114885 RVA: 0x003F9728 File Offset: 0x003F7928
		public static Offset<IFlowTemplateData> CreateIFlowTemplateData(FlatBufferBuilder builder, int TemplateId = 0, StringOffset NameOffset = default(StringOffset), VectorOffset ActorDataArrayOffset = default(VectorOffset), VectorOffset CameraParamMapOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IFlowTemplateData.AddCameraParamMap(builder, CameraParamMapOffset);
			IFlowTemplateData.AddActorDataArray(builder, ActorDataArrayOffset);
			IFlowTemplateData.AddName(builder, NameOffset);
			IFlowTemplateData.AddTemplateId(builder, TemplateId);
			return IFlowTemplateData.EndIFlowTemplateData(builder);
		}

		// Token: 0x0601C0C6 RID: 114886 RVA: 0x003F9754 File Offset: 0x003F7954
		public static void StartIFlowTemplateData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C0C7 RID: 114887 RVA: 0x003F975D File Offset: 0x003F795D
		public static void AddTemplateId(FlatBufferBuilder builder, int templateId)
		{
			builder.AddInt(0, templateId, 0);
		}

		// Token: 0x0601C0C8 RID: 114888 RVA: 0x003F9768 File Offset: 0x003F7968
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601C0C9 RID: 114889 RVA: 0x003F9778 File Offset: 0x003F7978
		public static void AddActorDataArray(FlatBufferBuilder builder, VectorOffset actorDataArrayOffset)
		{
			builder.AddOffset(2, actorDataArrayOffset.Value, 0);
		}

		// Token: 0x0601C0CA RID: 114890 RVA: 0x003F9788 File Offset: 0x003F7988
		public static VectorOffset CreateActorDataArrayVector(FlatBufferBuilder builder, Offset<IPosA>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C0CB RID: 114891 RVA: 0x003F97C8 File Offset: 0x003F79C8
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, Offset<IPosA>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPosA>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C0CC RID: 114892 RVA: 0x003F97E2 File Offset: 0x003F79E2
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPosA>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPosA>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C0CD RID: 114893 RVA: 0x003F9800 File Offset: 0x003F7A00
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPosA>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C0CE RID: 114894 RVA: 0x003F9819 File Offset: 0x003F7A19
		public static void StartActorDataArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C0CF RID: 114895 RVA: 0x003F9824 File Offset: 0x003F7A24
		public static void AddCameraParamMap(FlatBufferBuilder builder, VectorOffset cameraParamMapOffset)
		{
			builder.AddOffset(3, cameraParamMapOffset.Value, 0);
		}

		// Token: 0x0601C0D0 RID: 114896 RVA: 0x003F9834 File Offset: 0x003F7A34
		public static VectorOffset CreateCameraParamMapVector(FlatBufferBuilder builder, Offset<ICameraParam>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C0D1 RID: 114897 RVA: 0x003F9874 File Offset: 0x003F7A74
		public static VectorOffset CreateCameraParamMapVectorBlock(FlatBufferBuilder builder, Offset<ICameraParam>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICameraParam>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C0D2 RID: 114898 RVA: 0x003F988E File Offset: 0x003F7A8E
		public static VectorOffset CreateCameraParamMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICameraParam>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICameraParam>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C0D3 RID: 114899 RVA: 0x003F98AC File Offset: 0x003F7AAC
		public static VectorOffset CreateCameraParamMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICameraParam>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C0D4 RID: 114900 RVA: 0x003F98C5 File Offset: 0x003F7AC5
		public static void StartCameraParamMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C0D5 RID: 114901 RVA: 0x003F98D0 File Offset: 0x003F7AD0
		public static Offset<IFlowTemplateData> EndIFlowTemplateData(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateData>(builder.EndTable());
		}

		// Token: 0x0601C0D6 RID: 114902 RVA: 0x003F98E0 File Offset: 0x003F7AE0
		public IFlowTemplateDataT UnPack()
		{
			IFlowTemplateDataT flowTemplateDataT = new IFlowTemplateDataT();
			this.UnPackTo(flowTemplateDataT);
			return flowTemplateDataT;
		}

		// Token: 0x0601C0D7 RID: 114903 RVA: 0x003F98FC File Offset: 0x003F7AFC
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

		// Token: 0x0601C0D8 RID: 114904 RVA: 0x003F99C8 File Offset: 0x003F7BC8
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

		// Token: 0x0400CA22 RID: 51746
		private Table __p;
	}
}
