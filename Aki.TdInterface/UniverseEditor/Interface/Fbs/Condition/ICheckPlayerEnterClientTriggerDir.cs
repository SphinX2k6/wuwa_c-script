using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AE4 RID: 19172
	public struct ICheckPlayerEnterClientTriggerDir : IFlatbufferObject
	{
		// Token: 0x17008AFF RID: 35583
		// (get) Token: 0x0601E1DA RID: 123354 RVA: 0x004395FC File Offset: 0x004377FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E1DB RID: 123355 RVA: 0x00439609 File Offset: 0x00437809
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E1DC RID: 123356 RVA: 0x00439610 File Offset: 0x00437810
		public static ICheckPlayerEnterClientTriggerDir GetRootAsICheckPlayerEnterClientTriggerDir(ByteBuffer _bb)
		{
			return ICheckPlayerEnterClientTriggerDir.GetRootAsICheckPlayerEnterClientTriggerDir(_bb, default(ICheckPlayerEnterClientTriggerDir));
		}

		// Token: 0x0601E1DD RID: 123357 RVA: 0x0043962C File Offset: 0x0043782C
		public static ICheckPlayerEnterClientTriggerDir GetRootAsICheckPlayerEnterClientTriggerDir(ByteBuffer _bb, ICheckPlayerEnterClientTriggerDir obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E1DE RID: 123358 RVA: 0x00439649 File Offset: 0x00437849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E1DF RID: 123359 RVA: 0x00439658 File Offset: 0x00437858
		public ICheckPlayerEnterClientTriggerDir __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B00 RID: 35584
		// (get) Token: 0x0601E1E0 RID: 123360 RVA: 0x00439668 File Offset: 0x00437868
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B01 RID: 35585
		// (get) Token: 0x0601E1E1 RID: 123361 RVA: 0x004396A4 File Offset: 0x004378A4
		public ECheckEnterClientTriggerTargetType TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECheckEnterClientTriggerTargetType.Player;
				}
				return (ECheckEnterClientTriggerTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E1E2 RID: 123362 RVA: 0x004396E0 File Offset: 0x004378E0
		public TCheckEnterTriggerDirType DirConfigsType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TCheckEnterTriggerDirType.NONE;
			}
			return (TCheckEnterTriggerDirType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008B02 RID: 35586
		// (get) Token: 0x0601E1E3 RID: 123363 RVA: 0x00439720 File Offset: 0x00437920
		public int DirConfigsTypeLength
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

		// Token: 0x0601E1E4 RID: 123364 RVA: 0x0043974B File Offset: 0x0043794B
		public Span<TCheckEnterTriggerDirType> GetDirConfigsTypeBytes()
		{
			return this.__p.__vector_as_span<TCheckEnterTriggerDirType>(8, 1);
		}

		// Token: 0x0601E1E5 RID: 123365 RVA: 0x0043975C File Offset: 0x0043795C
		public TCheckEnterTriggerDirType[] GetDirConfigsTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TCheckEnterTriggerDirType[] array = new TCheckEnterTriggerDirType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TCheckEnterTriggerDirType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601E1E6 RID: 123366 RVA: 0x004397C8 File Offset: 0x004379C8
		public TTable? DirConfigs<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008B03 RID: 35587
		// (get) Token: 0x0601E1E7 RID: 123367 RVA: 0x00439810 File Offset: 0x00437A10
		public int DirConfigsLength
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

		// Token: 0x17008B04 RID: 35588
		// (get) Token: 0x0601E1E8 RID: 123368 RVA: 0x0043983C File Offset: 0x00437A3C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E1E9 RID: 123369 RVA: 0x00439879 File Offset: 0x00437A79
		public static Offset<ICheckPlayerEnterClientTriggerDir> CreateICheckPlayerEnterClientTriggerDir(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECheckEnterClientTriggerTargetType TargetType = ECheckEnterClientTriggerTargetType.Player, VectorOffset DirConfigs_typeOffset = default(VectorOffset), VectorOffset DirConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ICheckPlayerEnterClientTriggerDir.AddDirConfigs(builder, DirConfigsOffset);
			ICheckPlayerEnterClientTriggerDir.AddDirConfigsType(builder, DirConfigs_typeOffset);
			ICheckPlayerEnterClientTriggerDir.AddNullMask(builder, NullMask);
			ICheckPlayerEnterClientTriggerDir.AddTargetType(builder, TargetType);
			ICheckPlayerEnterClientTriggerDir.AddType(builder, Type);
			return ICheckPlayerEnterClientTriggerDir.EndICheckPlayerEnterClientTriggerDir(builder);
		}

		// Token: 0x0601E1EA RID: 123370 RVA: 0x004398AD File Offset: 0x00437AAD
		public static void StartICheckPlayerEnterClientTriggerDir(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601E1EB RID: 123371 RVA: 0x004398B6 File Offset: 0x00437AB6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E1EC RID: 123372 RVA: 0x004398C1 File Offset: 0x00437AC1
		public static void AddTargetType(FlatBufferBuilder builder, ECheckEnterClientTriggerTargetType targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601E1ED RID: 123373 RVA: 0x004398CC File Offset: 0x00437ACC
		public static void AddDirConfigsType(FlatBufferBuilder builder, VectorOffset dirConfigsTypeOffset)
		{
			builder.AddOffset(2, dirConfigsTypeOffset.Value, 0);
		}

		// Token: 0x0601E1EE RID: 123374 RVA: 0x004398DC File Offset: 0x00437ADC
		public static VectorOffset CreateDirConfigsTypeVector(FlatBufferBuilder builder, TCheckEnterTriggerDirType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E1EF RID: 123375 RVA: 0x00439913 File Offset: 0x00437B13
		public static VectorOffset CreateDirConfigsTypeVectorBlock(FlatBufferBuilder builder, TCheckEnterTriggerDirType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCheckEnterTriggerDirType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E1F0 RID: 123376 RVA: 0x0043992D File Offset: 0x00437B2D
		public static VectorOffset CreateDirConfigsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCheckEnterTriggerDirType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCheckEnterTriggerDirType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E1F1 RID: 123377 RVA: 0x0043994B File Offset: 0x00437B4B
		public static VectorOffset CreateDirConfigsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCheckEnterTriggerDirType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E1F2 RID: 123378 RVA: 0x00439964 File Offset: 0x00437B64
		public static void StartDirConfigsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601E1F3 RID: 123379 RVA: 0x0043996F File Offset: 0x00437B6F
		public static void AddDirConfigs(FlatBufferBuilder builder, VectorOffset dirConfigsOffset)
		{
			builder.AddOffset(3, dirConfigsOffset.Value, 0);
		}

		// Token: 0x0601E1F4 RID: 123380 RVA: 0x00439980 File Offset: 0x00437B80
		public static VectorOffset CreateDirConfigsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E1F5 RID: 123381 RVA: 0x004399B7 File Offset: 0x00437BB7
		public static VectorOffset CreateDirConfigsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E1F6 RID: 123382 RVA: 0x004399D1 File Offset: 0x00437BD1
		public static VectorOffset CreateDirConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E1F7 RID: 123383 RVA: 0x004399EF File Offset: 0x00437BEF
		public static VectorOffset CreateDirConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E1F8 RID: 123384 RVA: 0x00439A08 File Offset: 0x00437C08
		public static void StartDirConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E1F9 RID: 123385 RVA: 0x00439A13 File Offset: 0x00437C13
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601E1FA RID: 123386 RVA: 0x00439A1E File Offset: 0x00437C1E
		public static Offset<ICheckPlayerEnterClientTriggerDir> EndICheckPlayerEnterClientTriggerDir(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerEnterClientTriggerDir>(builder.EndTable());
		}

		// Token: 0x0601E1FB RID: 123387 RVA: 0x00439A2C File Offset: 0x00437C2C
		public ICheckPlayerEnterClientTriggerDirT UnPack()
		{
			ICheckPlayerEnterClientTriggerDirT checkPlayerEnterClientTriggerDirT = new ICheckPlayerEnterClientTriggerDirT();
			this.UnPackTo(checkPlayerEnterClientTriggerDirT);
			return checkPlayerEnterClientTriggerDirT;
		}

		// Token: 0x0601E1FC RID: 123388 RVA: 0x00439A48 File Offset: 0x00437C48
		public void UnPackTo(ICheckPlayerEnterClientTriggerDirT _o)
		{
			_o.Type = this.Type;
			_o.TargetType = this.TargetType;
			_o.DirConfigs = new List<TCheckEnterTriggerDirTypeUnion>();
			for (int i = 0; i < this.DirConfigsLength; i++)
			{
				TCheckEnterTriggerDirTypeUnion tcheckEnterTriggerDirTypeUnion = new TCheckEnterTriggerDirTypeUnion();
				tcheckEnterTriggerDirTypeUnion.Type = this.DirConfigsType(i);
				TCheckEnterTriggerDirType tcheckEnterTriggerDirType = this.DirConfigsType(i);
				if (tcheckEnterTriggerDirType != TCheckEnterTriggerDirType.ICheckEnterTriggerDirTypeForwardAngle)
				{
					if (tcheckEnterTriggerDirType == TCheckEnterTriggerDirType.ICheckEnterTriggerDirTypeVelocityDirAngle)
					{
						tcheckEnterTriggerDirTypeUnion.Value = ((this.DirConfigs<ICheckEnterTriggerDirTypeVelocityDirAngle>(i) != null) ? this.DirConfigs<ICheckEnterTriggerDirTypeVelocityDirAngle>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tcheckEnterTriggerDirTypeUnion.Value = ((this.DirConfigs<ICheckEnterTriggerDirTypeForwardAngle>(i) != null) ? this.DirConfigs<ICheckEnterTriggerDirTypeForwardAngle>(i).Value.UnPack() : null);
				}
				_o.DirConfigs.Add(tcheckEnterTriggerDirTypeUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601E1FD RID: 123389 RVA: 0x00439B34 File Offset: 0x00437D34
		public static Offset<ICheckPlayerEnterClientTriggerDir> Pack(FlatBufferBuilder builder, ICheckPlayerEnterClientTriggerDirT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerEnterClientTriggerDir>);
			}
			VectorOffset dirConfigs_typeOffset = default(VectorOffset);
			if (_o.DirConfigs != null)
			{
				TCheckEnterTriggerDirType[] array = new TCheckEnterTriggerDirType[_o.DirConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.DirConfigs[i].Type;
				}
				dirConfigs_typeOffset = ICheckPlayerEnterClientTriggerDir.CreateDirConfigsTypeVector(builder, array);
			}
			VectorOffset dirConfigsOffset = default(VectorOffset);
			if (_o.DirConfigs != null)
			{
				int[] array2 = new int[_o.DirConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TCheckEnterTriggerDirTypeUnion.Pack(builder, _o.DirConfigs[j]);
				}
				dirConfigsOffset = ICheckPlayerEnterClientTriggerDir.CreateDirConfigsVector(builder, array2);
			}
			return ICheckPlayerEnterClientTriggerDir.CreateICheckPlayerEnterClientTriggerDir(builder, _o.Type, _o.TargetType, dirConfigs_typeOffset, dirConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400D372 RID: 54130
		private Table __p;
	}
}
