using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075BB RID: 30139
	public struct IRemoveBuffFromPlayer : IFlatbufferObject
	{
		// Token: 0x1700DD9B RID: 56731
		// (get) Token: 0x06034DF8 RID: 216568 RVA: 0x0071B4AC File Offset: 0x007196AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034DF9 RID: 216569 RVA: 0x0071B4B9 File Offset: 0x007196B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034DFA RID: 216570 RVA: 0x0071B4C0 File Offset: 0x007196C0
		public static IRemoveBuffFromPlayer GetRootAsIRemoveBuffFromPlayer(ByteBuffer _bb)
		{
			return IRemoveBuffFromPlayer.GetRootAsIRemoveBuffFromPlayer(_bb, default(IRemoveBuffFromPlayer));
		}

		// Token: 0x06034DFB RID: 216571 RVA: 0x0071B4DC File Offset: 0x007196DC
		public static IRemoveBuffFromPlayer GetRootAsIRemoveBuffFromPlayer(ByteBuffer _bb, IRemoveBuffFromPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034DFC RID: 216572 RVA: 0x0071B4F9 File Offset: 0x007196F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034DFD RID: 216573 RVA: 0x0071B508 File Offset: 0x00719708
		public IRemoveBuffFromPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06034DFE RID: 216574 RVA: 0x0071B518 File Offset: 0x00719718
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700DD9C RID: 56732
		// (get) Token: 0x06034DFF RID: 216575 RVA: 0x0071B558 File Offset: 0x00719758
		public int BuffIdsLength
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

		// Token: 0x06034E00 RID: 216576 RVA: 0x0071B583 File Offset: 0x00719783
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x06034E01 RID: 216577 RVA: 0x0071B592 File Offset: 0x00719792
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x06034E02 RID: 216578 RVA: 0x0071B5A0 File Offset: 0x007197A0
		public static Offset<IRemoveBuffFromPlayer> CreateIRemoveBuffFromPlayer(FlatBufferBuilder builder, VectorOffset BuffIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IRemoveBuffFromPlayer.AddBuffIds(builder, BuffIdsOffset);
			return IRemoveBuffFromPlayer.EndIRemoveBuffFromPlayer(builder);
		}

		// Token: 0x06034E03 RID: 216579 RVA: 0x0071B5B6 File Offset: 0x007197B6
		public static void StartIRemoveBuffFromPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034E04 RID: 216580 RVA: 0x0071B5BF File Offset: 0x007197BF
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(0, buffIdsOffset.Value, 0);
		}

		// Token: 0x06034E05 RID: 216581 RVA: 0x0071B5D0 File Offset: 0x007197D0
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034E06 RID: 216582 RVA: 0x0071B607 File Offset: 0x00719807
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06034E07 RID: 216583 RVA: 0x0071B621 File Offset: 0x00719821
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06034E08 RID: 216584 RVA: 0x0071B63F File Offset: 0x0071983F
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034E09 RID: 216585 RVA: 0x0071B658 File Offset: 0x00719858
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06034E0A RID: 216586 RVA: 0x0071B663 File Offset: 0x00719863
		public static Offset<IRemoveBuffFromPlayer> EndIRemoveBuffFromPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveBuffFromPlayer>(builder.EndTable());
		}

		// Token: 0x06034E0B RID: 216587 RVA: 0x0071B670 File Offset: 0x00719870
		public IRemoveBuffFromPlayerT UnPack()
		{
			IRemoveBuffFromPlayerT removeBuffFromPlayerT = new IRemoveBuffFromPlayerT();
			this.UnPackTo(removeBuffFromPlayerT);
			return removeBuffFromPlayerT;
		}

		// Token: 0x06034E0C RID: 216588 RVA: 0x0071B68C File Offset: 0x0071988C
		public void UnPackTo(IRemoveBuffFromPlayerT _o)
		{
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
		}

		// Token: 0x06034E0D RID: 216589 RVA: 0x0071B6C8 File Offset: 0x007198C8
		public static Offset<IRemoveBuffFromPlayer> Pack(FlatBufferBuilder builder, IRemoveBuffFromPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveBuffFromPlayer>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IRemoveBuffFromPlayer.CreateBuffIdsVector(builder, data);
			}
			return IRemoveBuffFromPlayer.CreateIRemoveBuffFromPlayer(builder, buffIdsOffset);
		}

		// Token: 0x040127A3 RID: 75683
		private Table __p;
	}
}
