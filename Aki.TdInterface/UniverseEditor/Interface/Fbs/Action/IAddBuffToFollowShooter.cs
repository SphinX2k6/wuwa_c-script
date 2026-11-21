using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006781 RID: 26497
	public struct IAddBuffToFollowShooter : IFlatbufferObject
	{
		// Token: 0x1700C0A6 RID: 49318
		// (get) Token: 0x0602CEB0 RID: 183984 RVA: 0x0062402E File Offset: 0x0062222E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CEB1 RID: 183985 RVA: 0x0062403B File Offset: 0x0062223B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CEB2 RID: 183986 RVA: 0x00624044 File Offset: 0x00622244
		public static IAddBuffToFollowShooter GetRootAsIAddBuffToFollowShooter(ByteBuffer _bb)
		{
			return IAddBuffToFollowShooter.GetRootAsIAddBuffToFollowShooter(_bb, default(IAddBuffToFollowShooter));
		}

		// Token: 0x0602CEB3 RID: 183987 RVA: 0x00624060 File Offset: 0x00622260
		public static IAddBuffToFollowShooter GetRootAsIAddBuffToFollowShooter(ByteBuffer _bb, IAddBuffToFollowShooter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CEB4 RID: 183988 RVA: 0x0062407D File Offset: 0x0062227D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CEB5 RID: 183989 RVA: 0x0062408C File Offset: 0x0062228C
		public IAddBuffToFollowShooter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CEB6 RID: 183990 RVA: 0x0062409C File Offset: 0x0062229C
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700C0A7 RID: 49319
		// (get) Token: 0x0602CEB7 RID: 183991 RVA: 0x006240DC File Offset: 0x006222DC
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

		// Token: 0x0602CEB8 RID: 183992 RVA: 0x00624107 File Offset: 0x00622307
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x0602CEB9 RID: 183993 RVA: 0x00624116 File Offset: 0x00622316
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x1700C0A8 RID: 49320
		// (get) Token: 0x0602CEBA RID: 183994 RVA: 0x00624124 File Offset: 0x00622324
		public int FollowShooterId
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

		// Token: 0x1700C0A9 RID: 49321
		// (get) Token: 0x0602CEBB RID: 183995 RVA: 0x00624160 File Offset: 0x00622360
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

		// Token: 0x0602CEBC RID: 183996 RVA: 0x0062419C File Offset: 0x0062239C
		public static Offset<IAddBuffToFollowShooter> CreateIAddBuffToFollowShooter(FlatBufferBuilder builder, VectorOffset BuffIdsOffset = default(VectorOffset), int FollowShooterId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IAddBuffToFollowShooter.AddFollowShooterId(builder, FollowShooterId);
			IAddBuffToFollowShooter.AddBuffIds(builder, BuffIdsOffset);
			IAddBuffToFollowShooter.AddNullMask(builder, NullMask);
			return IAddBuffToFollowShooter.EndIAddBuffToFollowShooter(builder);
		}

		// Token: 0x0602CEBD RID: 183997 RVA: 0x006241C0 File Offset: 0x006223C0
		public static void StartIAddBuffToFollowShooter(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CEBE RID: 183998 RVA: 0x006241C9 File Offset: 0x006223C9
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(0, buffIdsOffset.Value, 0);
		}

		// Token: 0x0602CEBF RID: 183999 RVA: 0x006241DC File Offset: 0x006223DC
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CEC0 RID: 184000 RVA: 0x00624213 File Offset: 0x00622413
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CEC1 RID: 184001 RVA: 0x0062422D File Offset: 0x0062242D
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CEC2 RID: 184002 RVA: 0x0062424B File Offset: 0x0062244B
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CEC3 RID: 184003 RVA: 0x00624264 File Offset: 0x00622464
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602CEC4 RID: 184004 RVA: 0x0062426F File Offset: 0x0062246F
		public static void AddFollowShooterId(FlatBufferBuilder builder, int followShooterId)
		{
			builder.AddInt(1, followShooterId, 0);
		}

		// Token: 0x0602CEC5 RID: 184005 RVA: 0x0062427A File Offset: 0x0062247A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602CEC6 RID: 184006 RVA: 0x00624285 File Offset: 0x00622485
		public static Offset<IAddBuffToFollowShooter> EndIAddBuffToFollowShooter(FlatBufferBuilder builder)
		{
			return new Offset<IAddBuffToFollowShooter>(builder.EndTable());
		}

		// Token: 0x0602CEC7 RID: 184007 RVA: 0x00624294 File Offset: 0x00622494
		public IAddBuffToFollowShooterT UnPack()
		{
			IAddBuffToFollowShooterT addBuffToFollowShooterT = new IAddBuffToFollowShooterT();
			this.UnPackTo(addBuffToFollowShooterT);
			return addBuffToFollowShooterT;
		}

		// Token: 0x0602CEC8 RID: 184008 RVA: 0x006242B0 File Offset: 0x006224B0
		public void UnPackTo(IAddBuffToFollowShooterT _o)
		{
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
			_o.FollowShooterId = this.FollowShooterId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CEC9 RID: 184009 RVA: 0x00624304 File Offset: 0x00622504
		public static Offset<IAddBuffToFollowShooter> Pack(FlatBufferBuilder builder, IAddBuffToFollowShooterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddBuffToFollowShooter>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IAddBuffToFollowShooter.CreateBuffIdsVector(builder, data);
			}
			return IAddBuffToFollowShooter.CreateIAddBuffToFollowShooter(builder, buffIdsOffset, _o.FollowShooterId, _o.NullMask);
		}

		// Token: 0x040112F4 RID: 70388
		private Table __p;
	}
}
