using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046F7 RID: 18167
	public struct IHideRangeInfo : IFlatbufferObject
	{
		// Token: 0x170081DF RID: 33247
		// (get) Token: 0x0601BCEB RID: 113899 RVA: 0x003F1040 File Offset: 0x003EF240
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BCEC RID: 113900 RVA: 0x003F104D File Offset: 0x003EF24D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BCED RID: 113901 RVA: 0x003F1054 File Offset: 0x003EF254
		public static IHideRangeInfo GetRootAsIHideRangeInfo(ByteBuffer _bb)
		{
			return IHideRangeInfo.GetRootAsIHideRangeInfo(_bb, default(IHideRangeInfo));
		}

		// Token: 0x0601BCEE RID: 113902 RVA: 0x003F1070 File Offset: 0x003EF270
		public static IHideRangeInfo GetRootAsIHideRangeInfo(ByteBuffer _bb, IHideRangeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BCEF RID: 113903 RVA: 0x003F108D File Offset: 0x003EF28D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BCF0 RID: 113904 RVA: 0x003F109C File Offset: 0x003EF29C
		public IHideRangeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081E0 RID: 33248
		// (get) Token: 0x0601BCF1 RID: 113905 RVA: 0x003F10AC File Offset: 0x003EF2AC
		public string Path
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BCF2 RID: 113906 RVA: 0x003F10E3 File Offset: 0x003EF2E3
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601BCF3 RID: 113907 RVA: 0x003F10F2 File Offset: 0x003EF2F2
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601BCF4 RID: 113908 RVA: 0x003F1100 File Offset: 0x003EF300
		public int HideRangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170081E1 RID: 33249
		// (get) Token: 0x0601BCF5 RID: 113909 RVA: 0x003F1140 File Offset: 0x003EF340
		public int HideRangeEntitiesLength
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

		// Token: 0x0601BCF6 RID: 113910 RVA: 0x003F116B File Offset: 0x003EF36B
		public Span<int> GetHideRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601BCF7 RID: 113911 RVA: 0x003F117A File Offset: 0x003EF37A
		public int[] GetHideRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601BCF8 RID: 113912 RVA: 0x003F1188 File Offset: 0x003EF388
		public int HideRangeLevelPlay(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170081E2 RID: 33250
		// (get) Token: 0x0601BCF9 RID: 113913 RVA: 0x003F11C8 File Offset: 0x003EF3C8
		public int HideRangeLevelPlayLength
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

		// Token: 0x0601BCFA RID: 113914 RVA: 0x003F11F3 File Offset: 0x003EF3F3
		public Span<int> GetHideRangeLevelPlayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601BCFB RID: 113915 RVA: 0x003F1202 File Offset: 0x003EF402
		public int[] GetHideRangeLevelPlayArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601BCFC RID: 113916 RVA: 0x003F1210 File Offset: 0x003EF410
		public int ShowRangeEntities(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170081E3 RID: 33251
		// (get) Token: 0x0601BCFD RID: 113917 RVA: 0x003F1250 File Offset: 0x003EF450
		public int ShowRangeEntitiesLength
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

		// Token: 0x0601BCFE RID: 113918 RVA: 0x003F127C File Offset: 0x003EF47C
		public Span<int> GetShowRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601BCFF RID: 113919 RVA: 0x003F128C File Offset: 0x003EF48C
		public int[] GetShowRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0601BD00 RID: 113920 RVA: 0x003F129C File Offset: 0x003EF49C
		public int ShowRangeLevelPlay(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170081E4 RID: 33252
		// (get) Token: 0x0601BD01 RID: 113921 RVA: 0x003F12DC File Offset: 0x003EF4DC
		public int ShowRangeLevelPlayLength
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

		// Token: 0x0601BD02 RID: 113922 RVA: 0x003F1308 File Offset: 0x003EF508
		public Span<int> GetShowRangeLevelPlayBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0601BD03 RID: 113923 RVA: 0x003F1318 File Offset: 0x003EF518
		public int[] GetShowRangeLevelPlayArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x0601BD04 RID: 113924 RVA: 0x003F1327 File Offset: 0x003EF527
		public static Offset<IHideRangeInfo> CreateIHideRangeInfo(FlatBufferBuilder builder, StringOffset PathOffset = default(StringOffset), VectorOffset HideRangeEntitiesOffset = default(VectorOffset), VectorOffset HideRangeLevelPlayOffset = default(VectorOffset), VectorOffset ShowRangeEntitiesOffset = default(VectorOffset), VectorOffset ShowRangeLevelPlayOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			IHideRangeInfo.AddShowRangeLevelPlay(builder, ShowRangeLevelPlayOffset);
			IHideRangeInfo.AddShowRangeEntities(builder, ShowRangeEntitiesOffset);
			IHideRangeInfo.AddHideRangeLevelPlay(builder, HideRangeLevelPlayOffset);
			IHideRangeInfo.AddHideRangeEntities(builder, HideRangeEntitiesOffset);
			IHideRangeInfo.AddPath(builder, PathOffset);
			return IHideRangeInfo.EndIHideRangeInfo(builder);
		}

		// Token: 0x0601BD05 RID: 113925 RVA: 0x003F135B File Offset: 0x003EF55B
		public static void StartIHideRangeInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601BD06 RID: 113926 RVA: 0x003F1364 File Offset: 0x003EF564
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(0, pathOffset.Value, 0);
		}

		// Token: 0x0601BD07 RID: 113927 RVA: 0x003F1374 File Offset: 0x003EF574
		public static void AddHideRangeEntities(FlatBufferBuilder builder, VectorOffset hideRangeEntitiesOffset)
		{
			builder.AddOffset(1, hideRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601BD08 RID: 113928 RVA: 0x003F1384 File Offset: 0x003EF584
		public static VectorOffset CreateHideRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD09 RID: 113929 RVA: 0x003F13BB File Offset: 0x003EF5BB
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD0A RID: 113930 RVA: 0x003F13D5 File Offset: 0x003EF5D5
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD0B RID: 113931 RVA: 0x003F13F3 File Offset: 0x003EF5F3
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD0C RID: 113932 RVA: 0x003F140C File Offset: 0x003EF60C
		public static void StartHideRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD0D RID: 113933 RVA: 0x003F1417 File Offset: 0x003EF617
		public static void AddHideRangeLevelPlay(FlatBufferBuilder builder, VectorOffset hideRangeLevelPlayOffset)
		{
			builder.AddOffset(2, hideRangeLevelPlayOffset.Value, 0);
		}

		// Token: 0x0601BD0E RID: 113934 RVA: 0x003F1428 File Offset: 0x003EF628
		public static VectorOffset CreateHideRangeLevelPlayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD0F RID: 113935 RVA: 0x003F145F File Offset: 0x003EF65F
		public static VectorOffset CreateHideRangeLevelPlayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD10 RID: 113936 RVA: 0x003F1479 File Offset: 0x003EF679
		public static VectorOffset CreateHideRangeLevelPlayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD11 RID: 113937 RVA: 0x003F1497 File Offset: 0x003EF697
		public static VectorOffset CreateHideRangeLevelPlayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD12 RID: 113938 RVA: 0x003F14B0 File Offset: 0x003EF6B0
		public static void StartHideRangeLevelPlayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD13 RID: 113939 RVA: 0x003F14BB File Offset: 0x003EF6BB
		public static void AddShowRangeEntities(FlatBufferBuilder builder, VectorOffset showRangeEntitiesOffset)
		{
			builder.AddOffset(3, showRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601BD14 RID: 113940 RVA: 0x003F14CC File Offset: 0x003EF6CC
		public static VectorOffset CreateShowRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD15 RID: 113941 RVA: 0x003F1503 File Offset: 0x003EF703
		public static VectorOffset CreateShowRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD16 RID: 113942 RVA: 0x003F151D File Offset: 0x003EF71D
		public static VectorOffset CreateShowRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD17 RID: 113943 RVA: 0x003F153B File Offset: 0x003EF73B
		public static VectorOffset CreateShowRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD18 RID: 113944 RVA: 0x003F1554 File Offset: 0x003EF754
		public static void StartShowRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD19 RID: 113945 RVA: 0x003F155F File Offset: 0x003EF75F
		public static void AddShowRangeLevelPlay(FlatBufferBuilder builder, VectorOffset showRangeLevelPlayOffset)
		{
			builder.AddOffset(4, showRangeLevelPlayOffset.Value, 0);
		}

		// Token: 0x0601BD1A RID: 113946 RVA: 0x003F1570 File Offset: 0x003EF770
		public static VectorOffset CreateShowRangeLevelPlayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD1B RID: 113947 RVA: 0x003F15A7 File Offset: 0x003EF7A7
		public static VectorOffset CreateShowRangeLevelPlayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD1C RID: 113948 RVA: 0x003F15C1 File Offset: 0x003EF7C1
		public static VectorOffset CreateShowRangeLevelPlayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD1D RID: 113949 RVA: 0x003F15DF File Offset: 0x003EF7DF
		public static VectorOffset CreateShowRangeLevelPlayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD1E RID: 113950 RVA: 0x003F15F8 File Offset: 0x003EF7F8
		public static void StartShowRangeLevelPlayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD1F RID: 113951 RVA: 0x003F1603 File Offset: 0x003EF803
		public static Offset<IHideRangeInfo> EndIHideRangeInfo(FlatBufferBuilder builder)
		{
			return new Offset<IHideRangeInfo>(builder.EndTable());
		}

		// Token: 0x0601BD20 RID: 113952 RVA: 0x003F1610 File Offset: 0x003EF810
		public IHideRangeInfoT UnPack()
		{
			IHideRangeInfoT hideRangeInfoT = new IHideRangeInfoT();
			this.UnPackTo(hideRangeInfoT);
			return hideRangeInfoT;
		}

		// Token: 0x0601BD21 RID: 113953 RVA: 0x003F162C File Offset: 0x003EF82C
		public void UnPackTo(IHideRangeInfoT _o)
		{
			_o.Path = this.Path;
			_o.HideRangeEntities = new List<int>();
			for (int i = 0; i < this.HideRangeEntitiesLength; i++)
			{
				_o.HideRangeEntities.Add(this.HideRangeEntities(i));
			}
			_o.HideRangeLevelPlay = new List<int>();
			for (int j = 0; j < this.HideRangeLevelPlayLength; j++)
			{
				_o.HideRangeLevelPlay.Add(this.HideRangeLevelPlay(j));
			}
			_o.ShowRangeEntities = new List<int>();
			for (int k = 0; k < this.ShowRangeEntitiesLength; k++)
			{
				_o.ShowRangeEntities.Add(this.ShowRangeEntities(k));
			}
			_o.ShowRangeLevelPlay = new List<int>();
			for (int l = 0; l < this.ShowRangeLevelPlayLength; l++)
			{
				_o.ShowRangeLevelPlay.Add(this.ShowRangeLevelPlay(l));
			}
		}

		// Token: 0x0601BD22 RID: 113954 RVA: 0x003F1700 File Offset: 0x003EF900
		public static Offset<IHideRangeInfo> Pack(FlatBufferBuilder builder, IHideRangeInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideRangeInfo>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			VectorOffset hideRangeEntitiesOffset = default(VectorOffset);
			if (_o.HideRangeEntities != null)
			{
				int[] data = _o.HideRangeEntities.ToArray();
				hideRangeEntitiesOffset = IHideRangeInfo.CreateHideRangeEntitiesVector(builder, data);
			}
			VectorOffset hideRangeLevelPlayOffset = default(VectorOffset);
			if (_o.HideRangeLevelPlay != null)
			{
				int[] data2 = _o.HideRangeLevelPlay.ToArray();
				hideRangeLevelPlayOffset = IHideRangeInfo.CreateHideRangeLevelPlayVector(builder, data2);
			}
			VectorOffset showRangeEntitiesOffset = default(VectorOffset);
			if (_o.ShowRangeEntities != null)
			{
				int[] data3 = _o.ShowRangeEntities.ToArray();
				showRangeEntitiesOffset = IHideRangeInfo.CreateShowRangeEntitiesVector(builder, data3);
			}
			VectorOffset showRangeLevelPlayOffset = default(VectorOffset);
			if (_o.ShowRangeLevelPlay != null)
			{
				int[] data4 = _o.ShowRangeLevelPlay.ToArray();
				showRangeLevelPlayOffset = IHideRangeInfo.CreateShowRangeLevelPlayVector(builder, data4);
			}
			return IHideRangeInfo.CreateIHideRangeInfo(builder, pathOffset, hideRangeEntitiesOffset, hideRangeLevelPlayOffset, showRangeEntitiesOffset, showRangeLevelPlayOffset);
		}

		// Token: 0x0400C9A1 RID: 51617
		private Table __p;
	}
}
