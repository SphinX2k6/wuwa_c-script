using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8B RID: 28299
	public struct IResetLevelPlay : IFlatbufferObject
	{
		// Token: 0x1700D2B9 RID: 53945
		// (get) Token: 0x06032031 RID: 204849 RVA: 0x006C3C18 File Offset: 0x006C1E18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032032 RID: 204850 RVA: 0x006C3C25 File Offset: 0x006C1E25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032033 RID: 204851 RVA: 0x006C3C2C File Offset: 0x006C1E2C
		public static IResetLevelPlay GetRootAsIResetLevelPlay(ByteBuffer _bb)
		{
			return IResetLevelPlay.GetRootAsIResetLevelPlay(_bb, default(IResetLevelPlay));
		}

		// Token: 0x06032034 RID: 204852 RVA: 0x006C3C48 File Offset: 0x006C1E48
		public static IResetLevelPlay GetRootAsIResetLevelPlay(ByteBuffer _bb, IResetLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032035 RID: 204853 RVA: 0x006C3C65 File Offset: 0x006C1E65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032036 RID: 204854 RVA: 0x006C3C74 File Offset: 0x006C1E74
		public IResetLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032037 RID: 204855 RVA: 0x006C3C84 File Offset: 0x006C1E84
		public int ResetLevelPlayList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D2BA RID: 53946
		// (get) Token: 0x06032038 RID: 204856 RVA: 0x006C3CC4 File Offset: 0x006C1EC4
		public int ResetLevelPlayListLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06032039 RID: 204857 RVA: 0x006C3CEF File Offset: 0x006C1EEF
		public Span<int> GetResetLevelPlayListBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0603203A RID: 204858 RVA: 0x006C3CFE File Offset: 0x006C1EFE
		public int[] GetResetLevelPlayListArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0603203B RID: 204859 RVA: 0x006C3D0C File Offset: 0x006C1F0C
		public static Offset<IResetLevelPlay> CreateIResetLevelPlay(FlatBufferBuilder builder, VectorOffset ResetLevelPlayListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IResetLevelPlay.AddResetLevelPlayList(builder, ResetLevelPlayListOffset);
			return IResetLevelPlay.EndIResetLevelPlay(builder);
		}

		// Token: 0x0603203C RID: 204860 RVA: 0x006C3D22 File Offset: 0x006C1F22
		public static void StartIResetLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603203D RID: 204861 RVA: 0x006C3D2B File Offset: 0x006C1F2B
		public static void AddResetLevelPlayList(FlatBufferBuilder builder, VectorOffset resetLevelPlayListOffset)
		{
			builder.AddOffset(0, resetLevelPlayListOffset.Value, 0);
		}

		// Token: 0x0603203E RID: 204862 RVA: 0x006C3D3C File Offset: 0x006C1F3C
		public static VectorOffset CreateResetLevelPlayListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603203F RID: 204863 RVA: 0x006C3D73 File Offset: 0x006C1F73
		public static VectorOffset CreateResetLevelPlayListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032040 RID: 204864 RVA: 0x006C3D8D File Offset: 0x006C1F8D
		public static VectorOffset CreateResetLevelPlayListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032041 RID: 204865 RVA: 0x006C3DAB File Offset: 0x006C1FAB
		public static VectorOffset CreateResetLevelPlayListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032042 RID: 204866 RVA: 0x006C3DC4 File Offset: 0x006C1FC4
		public static void StartResetLevelPlayListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032043 RID: 204867 RVA: 0x006C3DCF File Offset: 0x006C1FCF
		public static Offset<IResetLevelPlay> EndIResetLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<IResetLevelPlay>(builder.EndTable());
		}

		// Token: 0x06032044 RID: 204868 RVA: 0x006C3DDC File Offset: 0x006C1FDC
		public IResetLevelPlayT UnPack()
		{
			IResetLevelPlayT resetLevelPlayT = new IResetLevelPlayT();
			this.UnPackTo(resetLevelPlayT);
			return resetLevelPlayT;
		}

		// Token: 0x06032045 RID: 204869 RVA: 0x006C3DF8 File Offset: 0x006C1FF8
		public void UnPackTo(IResetLevelPlayT _o)
		{
			_o.ResetLevelPlayList = new List<int>();
			for (int i = 0; i < this.ResetLevelPlayListLength; i++)
			{
				_o.ResetLevelPlayList.Add(this.ResetLevelPlayList(i));
			}
		}

		// Token: 0x06032046 RID: 204870 RVA: 0x006C3E34 File Offset: 0x006C2034
		public static Offset<IResetLevelPlay> Pack(FlatBufferBuilder builder, IResetLevelPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetLevelPlay>);
			}
			VectorOffset resetLevelPlayListOffset = default(VectorOffset);
			if (_o.ResetLevelPlayList != null)
			{
				int[] data = _o.ResetLevelPlayList.ToArray();
				resetLevelPlayListOffset = IResetLevelPlay.CreateResetLevelPlayListVector(builder, data);
			}
			return IResetLevelPlay.CreateIResetLevelPlay(builder, resetLevelPlayListOffset);
		}

		// Token: 0x04011878 RID: 71800
		private Table __p;
	}
}
