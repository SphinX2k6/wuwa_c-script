using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055DB RID: 21979
	public struct IMovementPlatformConfig : IFlatbufferObject
	{
		// Token: 0x1700A299 RID: 41625
		// (get) Token: 0x0602472B RID: 149291 RVA: 0x0050809A File Offset: 0x0050629A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602472C RID: 149292 RVA: 0x005080A7 File Offset: 0x005062A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602472D RID: 149293 RVA: 0x005080B0 File Offset: 0x005062B0
		public static IMovementPlatformConfig GetRootAsIMovementPlatformConfig(ByteBuffer _bb)
		{
			return IMovementPlatformConfig.GetRootAsIMovementPlatformConfig(_bb, default(IMovementPlatformConfig));
		}

		// Token: 0x0602472E RID: 149294 RVA: 0x005080CC File Offset: 0x005062CC
		public static IMovementPlatformConfig GetRootAsIMovementPlatformConfig(ByteBuffer _bb, IMovementPlatformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602472F RID: 149295 RVA: 0x005080E9 File Offset: 0x005062E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024730 RID: 149296 RVA: 0x005080F8 File Offset: 0x005062F8
		public IMovementPlatformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06024731 RID: 149297 RVA: 0x00508108 File Offset: 0x00506308
		public int PlayerAttachTags(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A29A RID: 41626
		// (get) Token: 0x06024732 RID: 149298 RVA: 0x00508148 File Offset: 0x00506348
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

		// Token: 0x06024733 RID: 149299 RVA: 0x00508173 File Offset: 0x00506373
		public Span<int> GetPlayerAttachTagsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06024734 RID: 149300 RVA: 0x00508182 File Offset: 0x00506382
		public int[] GetPlayerAttachTagsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700A29B RID: 41627
		// (get) Token: 0x06024735 RID: 149301 RVA: 0x00508190 File Offset: 0x00506390
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

		// Token: 0x1700A29C RID: 41628
		// (get) Token: 0x06024736 RID: 149302 RVA: 0x005081CC File Offset: 0x005063CC
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

		// Token: 0x06024737 RID: 149303 RVA: 0x00508208 File Offset: 0x00506408
		public static Offset<IMovementPlatformConfig> CreateIMovementPlatformConfig(FlatBufferBuilder builder, VectorOffset PlayerAttachTagsOffset = default(VectorOffset), int SafePointId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMovementPlatformConfig.AddSafePointId(builder, SafePointId);
			IMovementPlatformConfig.AddPlayerAttachTags(builder, PlayerAttachTagsOffset);
			IMovementPlatformConfig.AddNullMask(builder, NullMask);
			return IMovementPlatformConfig.EndIMovementPlatformConfig(builder);
		}

		// Token: 0x06024738 RID: 149304 RVA: 0x0050822C File Offset: 0x0050642C
		public static void StartIMovementPlatformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024739 RID: 149305 RVA: 0x00508235 File Offset: 0x00506435
		public static void AddPlayerAttachTags(FlatBufferBuilder builder, VectorOffset playerAttachTagsOffset)
		{
			builder.AddOffset(0, playerAttachTagsOffset.Value, 0);
		}

		// Token: 0x0602473A RID: 149306 RVA: 0x00508248 File Offset: 0x00506448
		public static VectorOffset CreatePlayerAttachTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602473B RID: 149307 RVA: 0x0050827F File Offset: 0x0050647F
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602473C RID: 149308 RVA: 0x00508299 File Offset: 0x00506499
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602473D RID: 149309 RVA: 0x005082B7 File Offset: 0x005064B7
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602473E RID: 149310 RVA: 0x005082D0 File Offset: 0x005064D0
		public static void StartPlayerAttachTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602473F RID: 149311 RVA: 0x005082DB File Offset: 0x005064DB
		public static void AddSafePointId(FlatBufferBuilder builder, int safePointId)
		{
			builder.AddInt(1, safePointId, 0);
		}

		// Token: 0x06024740 RID: 149312 RVA: 0x005082E6 File Offset: 0x005064E6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06024741 RID: 149313 RVA: 0x005082F1 File Offset: 0x005064F1
		public static Offset<IMovementPlatformConfig> EndIMovementPlatformConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMovementPlatformConfig>(builder.EndTable());
		}

		// Token: 0x06024742 RID: 149314 RVA: 0x00508300 File Offset: 0x00506500
		public IMovementPlatformConfigT UnPack()
		{
			IMovementPlatformConfigT movementPlatformConfigT = new IMovementPlatformConfigT();
			this.UnPackTo(movementPlatformConfigT);
			return movementPlatformConfigT;
		}

		// Token: 0x06024743 RID: 149315 RVA: 0x0050831C File Offset: 0x0050651C
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

		// Token: 0x06024744 RID: 149316 RVA: 0x00508370 File Offset: 0x00506570
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

		// Token: 0x0400E93E RID: 59710
		private Table __p;
	}
}
