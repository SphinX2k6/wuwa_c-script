using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B5F RID: 19295
	public struct IHideRangeInfo : IFlatbufferObject
	{
		// Token: 0x17008820 RID: 34848
		// (get) Token: 0x0601D4C0 RID: 120000 RVA: 0x0041D2DC File Offset: 0x0041B4DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D4C1 RID: 120001 RVA: 0x0041D2E9 File Offset: 0x0041B4E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D4C2 RID: 120002 RVA: 0x0041D2F0 File Offset: 0x0041B4F0
		public static IHideRangeInfo GetRootAsIHideRangeInfo(ByteBuffer _bb)
		{
			return IHideRangeInfo.GetRootAsIHideRangeInfo(_bb, default(IHideRangeInfo));
		}

		// Token: 0x0601D4C3 RID: 120003 RVA: 0x0041D30C File Offset: 0x0041B50C
		public static IHideRangeInfo GetRootAsIHideRangeInfo(ByteBuffer _bb, IHideRangeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D4C4 RID: 120004 RVA: 0x0041D329 File Offset: 0x0041B529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D4C5 RID: 120005 RVA: 0x0041D338 File Offset: 0x0041B538
		public IHideRangeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008821 RID: 34849
		// (get) Token: 0x0601D4C6 RID: 120006 RVA: 0x0041D348 File Offset: 0x0041B548
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

		// Token: 0x0601D4C7 RID: 120007 RVA: 0x0041D37F File Offset: 0x0041B57F
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D4C8 RID: 120008 RVA: 0x0041D38E File Offset: 0x0041B58E
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601D4C9 RID: 120009 RVA: 0x0041D39C File Offset: 0x0041B59C
		public int HideRangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008822 RID: 34850
		// (get) Token: 0x0601D4CA RID: 120010 RVA: 0x0041D3DC File Offset: 0x0041B5DC
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

		// Token: 0x0601D4CB RID: 120011 RVA: 0x0041D407 File Offset: 0x0041B607
		public Span<int> GetHideRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601D4CC RID: 120012 RVA: 0x0041D416 File Offset: 0x0041B616
		public int[] GetHideRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601D4CD RID: 120013 RVA: 0x0041D424 File Offset: 0x0041B624
		public int HideRangeLevelPlay(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008823 RID: 34851
		// (get) Token: 0x0601D4CE RID: 120014 RVA: 0x0041D464 File Offset: 0x0041B664
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

		// Token: 0x0601D4CF RID: 120015 RVA: 0x0041D48F File Offset: 0x0041B68F
		public Span<int> GetHideRangeLevelPlayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601D4D0 RID: 120016 RVA: 0x0041D49E File Offset: 0x0041B69E
		public int[] GetHideRangeLevelPlayArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601D4D1 RID: 120017 RVA: 0x0041D4AC File Offset: 0x0041B6AC
		public int ShowRangeEntities(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008824 RID: 34852
		// (get) Token: 0x0601D4D2 RID: 120018 RVA: 0x0041D4EC File Offset: 0x0041B6EC
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

		// Token: 0x0601D4D3 RID: 120019 RVA: 0x0041D518 File Offset: 0x0041B718
		public Span<int> GetShowRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601D4D4 RID: 120020 RVA: 0x0041D528 File Offset: 0x0041B728
		public int[] GetShowRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0601D4D5 RID: 120021 RVA: 0x0041D538 File Offset: 0x0041B738
		public int ShowRangeLevelPlay(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008825 RID: 34853
		// (get) Token: 0x0601D4D6 RID: 120022 RVA: 0x0041D578 File Offset: 0x0041B778
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

		// Token: 0x0601D4D7 RID: 120023 RVA: 0x0041D5A4 File Offset: 0x0041B7A4
		public Span<int> GetShowRangeLevelPlayBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0601D4D8 RID: 120024 RVA: 0x0041D5B4 File Offset: 0x0041B7B4
		public int[] GetShowRangeLevelPlayArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x0601D4D9 RID: 120025 RVA: 0x0041D5C3 File Offset: 0x0041B7C3
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

		// Token: 0x0601D4DA RID: 120026 RVA: 0x0041D5F7 File Offset: 0x0041B7F7
		public static void StartIHideRangeInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601D4DB RID: 120027 RVA: 0x0041D600 File Offset: 0x0041B800
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(0, pathOffset.Value, 0);
		}

		// Token: 0x0601D4DC RID: 120028 RVA: 0x0041D610 File Offset: 0x0041B810
		public static void AddHideRangeEntities(FlatBufferBuilder builder, VectorOffset hideRangeEntitiesOffset)
		{
			builder.AddOffset(1, hideRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601D4DD RID: 120029 RVA: 0x0041D620 File Offset: 0x0041B820
		public static VectorOffset CreateHideRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D4DE RID: 120030 RVA: 0x0041D657 File Offset: 0x0041B857
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D4DF RID: 120031 RVA: 0x0041D671 File Offset: 0x0041B871
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D4E0 RID: 120032 RVA: 0x0041D68F File Offset: 0x0041B88F
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D4E1 RID: 120033 RVA: 0x0041D6A8 File Offset: 0x0041B8A8
		public static void StartHideRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D4E2 RID: 120034 RVA: 0x0041D6B3 File Offset: 0x0041B8B3
		public static void AddHideRangeLevelPlay(FlatBufferBuilder builder, VectorOffset hideRangeLevelPlayOffset)
		{
			builder.AddOffset(2, hideRangeLevelPlayOffset.Value, 0);
		}

		// Token: 0x0601D4E3 RID: 120035 RVA: 0x0041D6C4 File Offset: 0x0041B8C4
		public static VectorOffset CreateHideRangeLevelPlayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D4E4 RID: 120036 RVA: 0x0041D6FB File Offset: 0x0041B8FB
		public static VectorOffset CreateHideRangeLevelPlayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D4E5 RID: 120037 RVA: 0x0041D715 File Offset: 0x0041B915
		public static VectorOffset CreateHideRangeLevelPlayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D4E6 RID: 120038 RVA: 0x0041D733 File Offset: 0x0041B933
		public static VectorOffset CreateHideRangeLevelPlayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D4E7 RID: 120039 RVA: 0x0041D74C File Offset: 0x0041B94C
		public static void StartHideRangeLevelPlayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D4E8 RID: 120040 RVA: 0x0041D757 File Offset: 0x0041B957
		public static void AddShowRangeEntities(FlatBufferBuilder builder, VectorOffset showRangeEntitiesOffset)
		{
			builder.AddOffset(3, showRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601D4E9 RID: 120041 RVA: 0x0041D768 File Offset: 0x0041B968
		public static VectorOffset CreateShowRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D4EA RID: 120042 RVA: 0x0041D79F File Offset: 0x0041B99F
		public static VectorOffset CreateShowRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D4EB RID: 120043 RVA: 0x0041D7B9 File Offset: 0x0041B9B9
		public static VectorOffset CreateShowRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D4EC RID: 120044 RVA: 0x0041D7D7 File Offset: 0x0041B9D7
		public static VectorOffset CreateShowRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D4ED RID: 120045 RVA: 0x0041D7F0 File Offset: 0x0041B9F0
		public static void StartShowRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D4EE RID: 120046 RVA: 0x0041D7FB File Offset: 0x0041B9FB
		public static void AddShowRangeLevelPlay(FlatBufferBuilder builder, VectorOffset showRangeLevelPlayOffset)
		{
			builder.AddOffset(4, showRangeLevelPlayOffset.Value, 0);
		}

		// Token: 0x0601D4EF RID: 120047 RVA: 0x0041D80C File Offset: 0x0041BA0C
		public static VectorOffset CreateShowRangeLevelPlayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D4F0 RID: 120048 RVA: 0x0041D843 File Offset: 0x0041BA43
		public static VectorOffset CreateShowRangeLevelPlayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D4F1 RID: 120049 RVA: 0x0041D85D File Offset: 0x0041BA5D
		public static VectorOffset CreateShowRangeLevelPlayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D4F2 RID: 120050 RVA: 0x0041D87B File Offset: 0x0041BA7B
		public static VectorOffset CreateShowRangeLevelPlayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D4F3 RID: 120051 RVA: 0x0041D894 File Offset: 0x0041BA94
		public static void StartShowRangeLevelPlayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D4F4 RID: 120052 RVA: 0x0041D89F File Offset: 0x0041BA9F
		public static Offset<IHideRangeInfo> EndIHideRangeInfo(FlatBufferBuilder builder)
		{
			return new Offset<IHideRangeInfo>(builder.EndTable());
		}

		// Token: 0x0601D4F5 RID: 120053 RVA: 0x0041D8AC File Offset: 0x0041BAAC
		public IHideRangeInfoT UnPack()
		{
			IHideRangeInfoT hideRangeInfoT = new IHideRangeInfoT();
			this.UnPackTo(hideRangeInfoT);
			return hideRangeInfoT;
		}

		// Token: 0x0601D4F6 RID: 120054 RVA: 0x0041D8C8 File Offset: 0x0041BAC8
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

		// Token: 0x0601D4F7 RID: 120055 RVA: 0x0041D99C File Offset: 0x0041BB9C
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

		// Token: 0x0400D3D0 RID: 54224
		private Table __p;
	}
}
