using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061D7 RID: 25047
	public struct IWuWaGoLevelCenter : IFlatbufferObject
	{
		// Token: 0x1700BABD RID: 47805
		// (get) Token: 0x0602A961 RID: 174433 RVA: 0x005CE8D8 File Offset: 0x005CCAD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A962 RID: 174434 RVA: 0x005CE8E5 File Offset: 0x005CCAE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A963 RID: 174435 RVA: 0x005CE8EC File Offset: 0x005CCAEC
		public static IWuWaGoLevelCenter GetRootAsIWuWaGoLevelCenter(ByteBuffer _bb)
		{
			return IWuWaGoLevelCenter.GetRootAsIWuWaGoLevelCenter(_bb, default(IWuWaGoLevelCenter));
		}

		// Token: 0x0602A964 RID: 174436 RVA: 0x005CE908 File Offset: 0x005CCB08
		public static IWuWaGoLevelCenter GetRootAsIWuWaGoLevelCenter(ByteBuffer _bb, IWuWaGoLevelCenter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A965 RID: 174437 RVA: 0x005CE925 File Offset: 0x005CCB25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A966 RID: 174438 RVA: 0x005CE934 File Offset: 0x005CCB34
		public IWuWaGoLevelCenter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BABE RID: 47806
		// (get) Token: 0x0602A967 RID: 174439 RVA: 0x005CE944 File Offset: 0x005CCB44
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BABF RID: 47807
		// (get) Token: 0x0602A968 RID: 174440 RVA: 0x005CE980 File Offset: 0x005CCB80
		public string LevelKey
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

		// Token: 0x0602A969 RID: 174441 RVA: 0x005CE9B7 File Offset: 0x005CCBB7
		public Span<byte> GetLevelKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602A96A RID: 174442 RVA: 0x005CE9C6 File Offset: 0x005CCBC6
		public byte[] GetLevelKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602A96B RID: 174443 RVA: 0x005CE9D4 File Offset: 0x005CCBD4
		public int LevelEntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BAC0 RID: 47808
		// (get) Token: 0x0602A96C RID: 174444 RVA: 0x005CEA14 File Offset: 0x005CCC14
		public int LevelEntityIdsLength
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

		// Token: 0x0602A96D RID: 174445 RVA: 0x005CEA3F File Offset: 0x005CCC3F
		public Span<int> GetLevelEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602A96E RID: 174446 RVA: 0x005CEA4E File Offset: 0x005CCC4E
		public int[] GetLevelEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0602A96F RID: 174447 RVA: 0x005CEA5C File Offset: 0x005CCC5C
		public static Offset<IWuWaGoLevelCenter> CreateIWuWaGoLevelCenter(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, StringOffset LevelKeyOffset = default(StringOffset), VectorOffset LevelEntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IWuWaGoLevelCenter.AddLevelEntityIds(builder, LevelEntityIdsOffset);
			IWuWaGoLevelCenter.AddLevelKey(builder, LevelKeyOffset);
			IWuWaGoLevelCenter.AddType(builder, Type);
			return IWuWaGoLevelCenter.EndIWuWaGoLevelCenter(builder);
		}

		// Token: 0x0602A970 RID: 174448 RVA: 0x005CEA80 File Offset: 0x005CCC80
		public static void StartIWuWaGoLevelCenter(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A971 RID: 174449 RVA: 0x005CEA89 File Offset: 0x005CCC89
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A972 RID: 174450 RVA: 0x005CEA94 File Offset: 0x005CCC94
		public static void AddLevelKey(FlatBufferBuilder builder, StringOffset levelKeyOffset)
		{
			builder.AddOffset(1, levelKeyOffset.Value, 0);
		}

		// Token: 0x0602A973 RID: 174451 RVA: 0x005CEAA4 File Offset: 0x005CCCA4
		public static void AddLevelEntityIds(FlatBufferBuilder builder, VectorOffset levelEntityIdsOffset)
		{
			builder.AddOffset(2, levelEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602A974 RID: 174452 RVA: 0x005CEAB4 File Offset: 0x005CCCB4
		public static VectorOffset CreateLevelEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A975 RID: 174453 RVA: 0x005CEAEB File Offset: 0x005CCCEB
		public static VectorOffset CreateLevelEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A976 RID: 174454 RVA: 0x005CEB05 File Offset: 0x005CCD05
		public static VectorOffset CreateLevelEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A977 RID: 174455 RVA: 0x005CEB23 File Offset: 0x005CCD23
		public static VectorOffset CreateLevelEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A978 RID: 174456 RVA: 0x005CEB3C File Offset: 0x005CCD3C
		public static void StartLevelEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A979 RID: 174457 RVA: 0x005CEB47 File Offset: 0x005CCD47
		public static Offset<IWuWaGoLevelCenter> EndIWuWaGoLevelCenter(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoLevelCenter>(builder.EndTable());
		}

		// Token: 0x0602A97A RID: 174458 RVA: 0x005CEB54 File Offset: 0x005CCD54
		public IWuWaGoLevelCenterT UnPack()
		{
			IWuWaGoLevelCenterT wuWaGoLevelCenterT = new IWuWaGoLevelCenterT();
			this.UnPackTo(wuWaGoLevelCenterT);
			return wuWaGoLevelCenterT;
		}

		// Token: 0x0602A97B RID: 174459 RVA: 0x005CEB70 File Offset: 0x005CCD70
		public void UnPackTo(IWuWaGoLevelCenterT _o)
		{
			_o.Type = this.Type;
			_o.LevelKey = this.LevelKey;
			_o.LevelEntityIds = new List<int>();
			for (int i = 0; i < this.LevelEntityIdsLength; i++)
			{
				_o.LevelEntityIds.Add(this.LevelEntityIds(i));
			}
		}

		// Token: 0x0602A97C RID: 174460 RVA: 0x005CEBC4 File Offset: 0x005CCDC4
		public static Offset<IWuWaGoLevelCenter> Pack(FlatBufferBuilder builder, IWuWaGoLevelCenterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoLevelCenter>);
			}
			StringOffset levelKeyOffset = (_o.LevelKey == null) ? default(StringOffset) : builder.CreateString(_o.LevelKey);
			VectorOffset levelEntityIdsOffset = default(VectorOffset);
			if (_o.LevelEntityIds != null)
			{
				int[] data = _o.LevelEntityIds.ToArray();
				levelEntityIdsOffset = IWuWaGoLevelCenter.CreateLevelEntityIdsVector(builder, data);
			}
			return IWuWaGoLevelCenter.CreateIWuWaGoLevelCenter(builder, _o.Type, levelKeyOffset, levelEntityIdsOffset);
		}

		// Token: 0x0401003F RID: 65599
		private Table __p;
	}
}
