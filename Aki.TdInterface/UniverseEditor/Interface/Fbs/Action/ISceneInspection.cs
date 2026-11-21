using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B4 RID: 30388
	public struct ISceneInspection : IFlatbufferObject
	{
		// Token: 0x1700DEE7 RID: 57063
		// (get) Token: 0x060354D9 RID: 218329 RVA: 0x00726922 File Offset: 0x00724B22
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060354DA RID: 218330 RVA: 0x0072692F File Offset: 0x00724B2F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060354DB RID: 218331 RVA: 0x00726938 File Offset: 0x00724B38
		public static ISceneInspection GetRootAsISceneInspection(ByteBuffer _bb)
		{
			return ISceneInspection.GetRootAsISceneInspection(_bb, default(ISceneInspection));
		}

		// Token: 0x060354DC RID: 218332 RVA: 0x00726954 File Offset: 0x00724B54
		public static ISceneInspection GetRootAsISceneInspection(ByteBuffer _bb, ISceneInspection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060354DD RID: 218333 RVA: 0x00726971 File Offset: 0x00724B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060354DE RID: 218334 RVA: 0x00726980 File Offset: 0x00724B80
		public ISceneInspection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEE8 RID: 57064
		// (get) Token: 0x060354DF RID: 218335 RVA: 0x00726990 File Offset: 0x00724B90
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

		// Token: 0x1700DEE9 RID: 57065
		// (get) Token: 0x060354E0 RID: 218336 RVA: 0x007269CC File Offset: 0x00724BCC
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

		// Token: 0x060354E1 RID: 218337 RVA: 0x00726A03 File Offset: 0x00724C03
		public Span<byte> GetSaveVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060354E2 RID: 218338 RVA: 0x00726A12 File Offset: 0x00724C12
		public byte[] GetSaveVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060354E3 RID: 218339 RVA: 0x00726A20 File Offset: 0x00724C20
		public ISceneInspectionPoint? InteractPoints(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ISceneInspectionPoint?(default(ISceneInspectionPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DEEA RID: 57066
		// (get) Token: 0x060354E4 RID: 218340 RVA: 0x00726A80 File Offset: 0x00724C80
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

		// Token: 0x060354E5 RID: 218341 RVA: 0x00726AAB File Offset: 0x00724CAB
		public static Offset<ISceneInspection> CreateISceneInspection(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, StringOffset SaveVarNameOffset = default(StringOffset), VectorOffset InteractPointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISceneInspection.AddInteractPoints(builder, InteractPointsOffset);
			ISceneInspection.AddSaveVarName(builder, SaveVarNameOffset);
			ISceneInspection.AddType(builder, Type);
			return ISceneInspection.EndISceneInspection(builder);
		}

		// Token: 0x060354E6 RID: 218342 RVA: 0x00726ACF File Offset: 0x00724CCF
		public static void StartISceneInspection(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060354E7 RID: 218343 RVA: 0x00726AD8 File Offset: 0x00724CD8
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060354E8 RID: 218344 RVA: 0x00726AE3 File Offset: 0x00724CE3
		public static void AddSaveVarName(FlatBufferBuilder builder, StringOffset saveVarNameOffset)
		{
			builder.AddOffset(1, saveVarNameOffset.Value, 0);
		}

		// Token: 0x060354E9 RID: 218345 RVA: 0x00726AF3 File Offset: 0x00724CF3
		public static void AddInteractPoints(FlatBufferBuilder builder, VectorOffset interactPointsOffset)
		{
			builder.AddOffset(2, interactPointsOffset.Value, 0);
		}

		// Token: 0x060354EA RID: 218346 RVA: 0x00726B04 File Offset: 0x00724D04
		public static VectorOffset CreateInteractPointsVector(FlatBufferBuilder builder, Offset<ISceneInspectionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060354EB RID: 218347 RVA: 0x00726B44 File Offset: 0x00724D44
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, Offset<ISceneInspectionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneInspectionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060354EC RID: 218348 RVA: 0x00726B5E File Offset: 0x00724D5E
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneInspectionPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneInspectionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060354ED RID: 218349 RVA: 0x00726B7C File Offset: 0x00724D7C
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneInspectionPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060354EE RID: 218350 RVA: 0x00726B95 File Offset: 0x00724D95
		public static void StartInteractPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060354EF RID: 218351 RVA: 0x00726BA0 File Offset: 0x00724DA0
		public static Offset<ISceneInspection> EndISceneInspection(FlatBufferBuilder builder)
		{
			return new Offset<ISceneInspection>(builder.EndTable());
		}

		// Token: 0x060354F0 RID: 218352 RVA: 0x00726BB0 File Offset: 0x00724DB0
		public ISceneInspectionT UnPack()
		{
			ISceneInspectionT sceneInspectionT = new ISceneInspectionT();
			this.UnPackTo(sceneInspectionT);
			return sceneInspectionT;
		}

		// Token: 0x060354F1 RID: 218353 RVA: 0x00726BCC File Offset: 0x00724DCC
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

		// Token: 0x060354F2 RID: 218354 RVA: 0x00726C44 File Offset: 0x00724E44
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

		// Token: 0x040128A3 RID: 75939
		private Table __p;
	}
}
