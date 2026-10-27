using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F2D RID: 28461
	public struct ISceneInspection : IFlatbufferObject
	{
		// Token: 0x1700D38B RID: 54155
		// (get) Token: 0x06032481 RID: 205953 RVA: 0x006CA9BA File Offset: 0x006C8BBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032482 RID: 205954 RVA: 0x006CA9C7 File Offset: 0x006C8BC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032483 RID: 205955 RVA: 0x006CA9D0 File Offset: 0x006C8BD0
		public static ISceneInspection GetRootAsISceneInspection(ByteBuffer _bb)
		{
			return ISceneInspection.GetRootAsISceneInspection(_bb, default(ISceneInspection));
		}

		// Token: 0x06032484 RID: 205956 RVA: 0x006CA9EC File Offset: 0x006C8BEC
		public static ISceneInspection GetRootAsISceneInspection(ByteBuffer _bb, ISceneInspection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032485 RID: 205957 RVA: 0x006CAA09 File Offset: 0x006C8C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032486 RID: 205958 RVA: 0x006CAA18 File Offset: 0x006C8C18
		public ISceneInspection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D38C RID: 54156
		// (get) Token: 0x06032487 RID: 205959 RVA: 0x006CAA28 File Offset: 0x006C8C28
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D38D RID: 54157
		// (get) Token: 0x06032488 RID: 205960 RVA: 0x006CAA64 File Offset: 0x006C8C64
		public string SaveVarName
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

		// Token: 0x06032489 RID: 205961 RVA: 0x006CAA9B File Offset: 0x006C8C9B
		public Span<byte> GetSaveVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603248A RID: 205962 RVA: 0x006CAAAA File Offset: 0x006C8CAA
		public byte[] GetSaveVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603248B RID: 205963 RVA: 0x006CAAB8 File Offset: 0x006C8CB8
		public ISceneInspectionPoint? InteractPoints(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ISceneInspectionPoint?(default(ISceneInspectionPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D38E RID: 54158
		// (get) Token: 0x0603248C RID: 205964 RVA: 0x006CAB18 File Offset: 0x006C8D18
		public int InteractPointsLength
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

		// Token: 0x0603248D RID: 205965 RVA: 0x006CAB43 File Offset: 0x006C8D43
		public static Offset<ISceneInspection> CreateISceneInspection(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, StringOffset SaveVarNameOffset = default(StringOffset), VectorOffset InteractPointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISceneInspection.AddInteractPoints(builder, InteractPointsOffset);
			ISceneInspection.AddSaveVarName(builder, SaveVarNameOffset);
			ISceneInspection.AddType(builder, Type);
			return ISceneInspection.EndISceneInspection(builder);
		}

		// Token: 0x0603248E RID: 205966 RVA: 0x006CAB67 File Offset: 0x006C8D67
		public static void StartISceneInspection(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603248F RID: 205967 RVA: 0x006CAB70 File Offset: 0x006C8D70
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032490 RID: 205968 RVA: 0x006CAB7B File Offset: 0x006C8D7B
		public static void AddSaveVarName(FlatBufferBuilder builder, StringOffset saveVarNameOffset)
		{
			builder.AddOffset(1, saveVarNameOffset.Value, 0);
		}

		// Token: 0x06032491 RID: 205969 RVA: 0x006CAB8B File Offset: 0x006C8D8B
		public static void AddInteractPoints(FlatBufferBuilder builder, VectorOffset interactPointsOffset)
		{
			builder.AddOffset(2, interactPointsOffset.Value, 0);
		}

		// Token: 0x06032492 RID: 205970 RVA: 0x006CAB9C File Offset: 0x006C8D9C
		public static VectorOffset CreateInteractPointsVector(FlatBufferBuilder builder, Offset<ISceneInspectionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032493 RID: 205971 RVA: 0x006CABDC File Offset: 0x006C8DDC
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, Offset<ISceneInspectionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneInspectionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032494 RID: 205972 RVA: 0x006CABF6 File Offset: 0x006C8DF6
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneInspectionPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneInspectionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032495 RID: 205973 RVA: 0x006CAC14 File Offset: 0x006C8E14
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneInspectionPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032496 RID: 205974 RVA: 0x006CAC2D File Offset: 0x006C8E2D
		public static void StartInteractPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032497 RID: 205975 RVA: 0x006CAC38 File Offset: 0x006C8E38
		public static Offset<ISceneInspection> EndISceneInspection(FlatBufferBuilder builder)
		{
			return new Offset<ISceneInspection>(builder.EndTable());
		}

		// Token: 0x06032498 RID: 205976 RVA: 0x006CAC48 File Offset: 0x006C8E48
		public ISceneInspectionT UnPack()
		{
			ISceneInspectionT sceneInspectionT = new ISceneInspectionT();
			this.UnPackTo(sceneInspectionT);
			return sceneInspectionT;
		}

		// Token: 0x06032499 RID: 205977 RVA: 0x006CAC64 File Offset: 0x006C8E64
		public void UnPackTo(ISceneInspectionT _o)
		{
			_o.Type = this.Type;
			_o.SaveVarName = this.SaveVarName;
			_o.InteractPoints = new List<ISceneInspectionPointT>();
			for (int i = 0; i < this.InteractPointsLength; i++)
			{
				_o.InteractPoints.Add((this.InteractPoints(i) != null) ? this.InteractPoints(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0603249A RID: 205978 RVA: 0x006CACDC File Offset: 0x006C8EDC
		public static Offset<ISceneInspection> Pack(FlatBufferBuilder builder, ISceneInspectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneInspection>);
			}
			StringOffset saveVarNameOffset = (_o.SaveVarName == null) ? default(StringOffset) : builder.CreateString(_o.SaveVarName);
			VectorOffset interactPointsOffset = default(VectorOffset);
			if (_o.InteractPoints != null)
			{
				Offset<ISceneInspectionPoint>[] array = new Offset<ISceneInspectionPoint>[_o.InteractPoints.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISceneInspectionPoint.Pack(builder, _o.InteractPoints[i]);
				}
				interactPointsOffset = ISceneInspection.CreateInteractPointsVector(builder, array);
			}
			return ISceneInspection.CreateISceneInspection(builder, _o.Type, saveVarNameOffset, interactPointsOffset);
		}

		// Token: 0x0401191B RID: 71963
		private Table __p;
	}
}
