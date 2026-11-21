using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760F RID: 30223
	public struct IResetLevelPlay : IFlatbufferObject
	{
		// Token: 0x1700DE10 RID: 56848
		// (get) Token: 0x06035071 RID: 217201 RVA: 0x0071F94C File Offset: 0x0071DB4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035072 RID: 217202 RVA: 0x0071F959 File Offset: 0x0071DB59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035073 RID: 217203 RVA: 0x0071F960 File Offset: 0x0071DB60
		public static IResetLevelPlay GetRootAsIResetLevelPlay(ByteBuffer _bb)
		{
			return IResetLevelPlay.GetRootAsIResetLevelPlay(_bb, default(IResetLevelPlay));
		}

		// Token: 0x06035074 RID: 217204 RVA: 0x0071F97C File Offset: 0x0071DB7C
		public static IResetLevelPlay GetRootAsIResetLevelPlay(ByteBuffer _bb, IResetLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035075 RID: 217205 RVA: 0x0071F999 File Offset: 0x0071DB99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035076 RID: 217206 RVA: 0x0071F9A8 File Offset: 0x0071DBA8
		public IResetLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06035077 RID: 217207 RVA: 0x0071F9B8 File Offset: 0x0071DBB8
		public int ResetLevelPlayList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DE11 RID: 56849
		// (get) Token: 0x06035078 RID: 217208 RVA: 0x0071F9F8 File Offset: 0x0071DBF8
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

		// Token: 0x06035079 RID: 217209 RVA: 0x0071FA23 File Offset: 0x0071DC23
		public Span<int> GetResetLevelPlayListBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0603507A RID: 217210 RVA: 0x0071FA32 File Offset: 0x0071DC32
		public int[] GetResetLevelPlayListArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0603507B RID: 217211 RVA: 0x0071FA40 File Offset: 0x0071DC40
		public static Offset<IResetLevelPlay> CreateIResetLevelPlay(FlatBufferBuilder builder, VectorOffset ResetLevelPlayListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IResetLevelPlay.AddResetLevelPlayList(builder, ResetLevelPlayListOffset);
			return IResetLevelPlay.EndIResetLevelPlay(builder);
		}

		// Token: 0x0603507C RID: 217212 RVA: 0x0071FA56 File Offset: 0x0071DC56
		public static void StartIResetLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603507D RID: 217213 RVA: 0x0071FA5F File Offset: 0x0071DC5F
		public static void AddResetLevelPlayList(FlatBufferBuilder builder, VectorOffset resetLevelPlayListOffset)
		{
			builder.AddOffset(0, resetLevelPlayListOffset.Value, 0);
		}

		// Token: 0x0603507E RID: 217214 RVA: 0x0071FA70 File Offset: 0x0071DC70
		public static VectorOffset CreateResetLevelPlayListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603507F RID: 217215 RVA: 0x0071FAA7 File Offset: 0x0071DCA7
		public static VectorOffset CreateResetLevelPlayListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035080 RID: 217216 RVA: 0x0071FAC1 File Offset: 0x0071DCC1
		public static VectorOffset CreateResetLevelPlayListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035081 RID: 217217 RVA: 0x0071FADF File Offset: 0x0071DCDF
		public static VectorOffset CreateResetLevelPlayListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035082 RID: 217218 RVA: 0x0071FAF8 File Offset: 0x0071DCF8
		public static void StartResetLevelPlayListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035083 RID: 217219 RVA: 0x0071FB03 File Offset: 0x0071DD03
		public static Offset<IResetLevelPlay> EndIResetLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<IResetLevelPlay>(builder.EndTable());
		}

		// Token: 0x06035084 RID: 217220 RVA: 0x0071FB10 File Offset: 0x0071DD10
		public IResetLevelPlayT UnPack()
		{
			IResetLevelPlayT resetLevelPlayT = new IResetLevelPlayT();
			this.UnPackTo(resetLevelPlayT);
			return resetLevelPlayT;
		}

		// Token: 0x06035085 RID: 217221 RVA: 0x0071FB2C File Offset: 0x0071DD2C
		public void UnPackTo(IResetLevelPlayT _o)
		{
			_o.ResetLevelPlayList = new List<int>();
			for (int i = 0; i < this.ResetLevelPlayListLength; i++)
			{
				_o.ResetLevelPlayList.Add(this.ResetLevelPlayList(i));
			}
		}

		// Token: 0x06035086 RID: 217222 RVA: 0x0071FB68 File Offset: 0x0071DD68
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

		// Token: 0x040127FD RID: 75773
		private Table __p;
	}
}
