using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B79 RID: 23417
	public struct IMovementPlatformConfig : IFlatbufferObject
	{
		// Token: 0x1700AB21 RID: 43809
		// (get) Token: 0x06026938 RID: 158008 RVA: 0x00548612 File Offset: 0x00546812
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026939 RID: 158009 RVA: 0x0054861F File Offset: 0x0054681F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602693A RID: 158010 RVA: 0x00548628 File Offset: 0x00546828
		public static IMovementPlatformConfig GetRootAsIMovementPlatformConfig(ByteBuffer _bb)
		{
			return IMovementPlatformConfig.GetRootAsIMovementPlatformConfig(_bb, default(IMovementPlatformConfig));
		}

		// Token: 0x0602693B RID: 158011 RVA: 0x00548644 File Offset: 0x00546844
		public static IMovementPlatformConfig GetRootAsIMovementPlatformConfig(ByteBuffer _bb, IMovementPlatformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602693C RID: 158012 RVA: 0x00548661 File Offset: 0x00546861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602693D RID: 158013 RVA: 0x00548670 File Offset: 0x00546870
		public IMovementPlatformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602693E RID: 158014 RVA: 0x00548680 File Offset: 0x00546880
		public int PlayerAttachTags(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AB22 RID: 43810
		// (get) Token: 0x0602693F RID: 158015 RVA: 0x005486C0 File Offset: 0x005468C0
		public int PlayerAttachTagsLength
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

		// Token: 0x06026940 RID: 158016 RVA: 0x005486EB File Offset: 0x005468EB
		public Span<int> GetPlayerAttachTagsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06026941 RID: 158017 RVA: 0x005486FA File Offset: 0x005468FA
		public int[] GetPlayerAttachTagsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700AB23 RID: 43811
		// (get) Token: 0x06026942 RID: 158018 RVA: 0x00548708 File Offset: 0x00546908
		public int SafePointId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AB24 RID: 43812
		// (get) Token: 0x06026943 RID: 158019 RVA: 0x00548744 File Offset: 0x00546944
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026944 RID: 158020 RVA: 0x00548780 File Offset: 0x00546980
		public static Offset<IMovementPlatformConfig> CreateIMovementPlatformConfig(FlatBufferBuilder builder, VectorOffset PlayerAttachTagsOffset = default(VectorOffset), int SafePointId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMovementPlatformConfig.AddSafePointId(builder, SafePointId);
			IMovementPlatformConfig.AddPlayerAttachTags(builder, PlayerAttachTagsOffset);
			IMovementPlatformConfig.AddNullMask(builder, NullMask);
			return IMovementPlatformConfig.EndIMovementPlatformConfig(builder);
		}

		// Token: 0x06026945 RID: 158021 RVA: 0x005487A4 File Offset: 0x005469A4
		public static void StartIMovementPlatformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026946 RID: 158022 RVA: 0x005487AD File Offset: 0x005469AD
		public static void AddPlayerAttachTags(FlatBufferBuilder builder, VectorOffset playerAttachTagsOffset)
		{
			builder.AddOffset(0, playerAttachTagsOffset.Value, 0);
		}

		// Token: 0x06026947 RID: 158023 RVA: 0x005487C0 File Offset: 0x005469C0
		public static VectorOffset CreatePlayerAttachTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026948 RID: 158024 RVA: 0x005487F7 File Offset: 0x005469F7
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026949 RID: 158025 RVA: 0x00548811 File Offset: 0x00546A11
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602694A RID: 158026 RVA: 0x0054882F File Offset: 0x00546A2F
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602694B RID: 158027 RVA: 0x00548848 File Offset: 0x00546A48
		public static void StartPlayerAttachTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602694C RID: 158028 RVA: 0x00548853 File Offset: 0x00546A53
		public static void AddSafePointId(FlatBufferBuilder builder, int safePointId)
		{
			builder.AddInt(1, safePointId, 0);
		}

		// Token: 0x0602694D RID: 158029 RVA: 0x0054885E File Offset: 0x00546A5E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602694E RID: 158030 RVA: 0x00548869 File Offset: 0x00546A69
		public static Offset<IMovementPlatformConfig> EndIMovementPlatformConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMovementPlatformConfig>(builder.EndTable());
		}

		// Token: 0x0602694F RID: 158031 RVA: 0x00548878 File Offset: 0x00546A78
		public IMovementPlatformConfigT UnPack()
		{
			IMovementPlatformConfigT movementPlatformConfigT = new IMovementPlatformConfigT();
			this.UnPackTo(movementPlatformConfigT);
			return movementPlatformConfigT;
		}

		// Token: 0x06026950 RID: 158032 RVA: 0x00548894 File Offset: 0x00546A94
		public void UnPackTo(IMovementPlatformConfigT _o)
		{
			_o.PlayerAttachTags = new List<int>();
			for (int i = 0; i < this.PlayerAttachTagsLength; i++)
			{
				_o.PlayerAttachTags.Add(this.PlayerAttachTags(i));
			}
			_o.SafePointId = this.SafePointId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026951 RID: 158033 RVA: 0x005488E8 File Offset: 0x00546AE8
		public static Offset<IMovementPlatformConfig> Pack(FlatBufferBuilder builder, IMovementPlatformConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovementPlatformConfig>);
			}
			VectorOffset playerAttachTagsOffset = default(VectorOffset);
			if (_o.PlayerAttachTags != null)
			{
				int[] data = _o.PlayerAttachTags.ToArray();
				playerAttachTagsOffset = IMovementPlatformConfig.CreatePlayerAttachTagsVector(builder, data);
			}
			return IMovementPlatformConfig.CreateIMovementPlatformConfig(builder, playerAttachTagsOffset, _o.SafePointId, _o.NullMask);
		}

		// Token: 0x0400F5A0 RID: 62880
		private Table __p;
	}
}
