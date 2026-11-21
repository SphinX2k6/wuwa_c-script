using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200673C RID: 26428
	public struct IActorLookAtEmptyData : IFlatbufferObject
	{
		// Token: 0x1700C01D RID: 49181
		// (get) Token: 0x0602CC69 RID: 183401 RVA: 0x0062015C File Offset: 0x0061E35C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CC6A RID: 183402 RVA: 0x00620169 File Offset: 0x0061E369
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CC6B RID: 183403 RVA: 0x00620170 File Offset: 0x0061E370
		public static IActorLookAtEmptyData GetRootAsIActorLookAtEmptyData(ByteBuffer _bb)
		{
			return IActorLookAtEmptyData.GetRootAsIActorLookAtEmptyData(_bb, default(IActorLookAtEmptyData));
		}

		// Token: 0x0602CC6C RID: 183404 RVA: 0x0062018C File Offset: 0x0061E38C
		public static IActorLookAtEmptyData GetRootAsIActorLookAtEmptyData(ByteBuffer _bb, IActorLookAtEmptyData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CC6D RID: 183405 RVA: 0x006201A9 File Offset: 0x0061E3A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CC6E RID: 183406 RVA: 0x006201B8 File Offset: 0x0061E3B8
		public IActorLookAtEmptyData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C01E RID: 49182
		// (get) Token: 0x0602CC6F RID: 183407 RVA: 0x006201C8 File Offset: 0x0061E3C8
		public EActorLookAtMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorLookAtMode.Talker;
				}
				return (EActorLookAtMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C01F RID: 49183
		// (get) Token: 0x0602CC70 RID: 183408 RVA: 0x00620204 File Offset: 0x0061E404
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C020 RID: 49184
		// (get) Token: 0x0602CC71 RID: 183409 RVA: 0x00620244 File Offset: 0x0061E444
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

		// Token: 0x0602CC72 RID: 183410 RVA: 0x00620280 File Offset: 0x0061E480
		public static Offset<IActorLookAtEmptyData> CreateIActorLookAtEmptyData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorLookAtEmptyData.AddNullMask(builder, NullMask);
			IActorLookAtEmptyData.AddLock(builder, Lock);
			IActorLookAtEmptyData.AddType(builder, Type);
			return IActorLookAtEmptyData.EndIActorLookAtEmptyData(builder);
		}

		// Token: 0x0602CC73 RID: 183411 RVA: 0x006202A4 File Offset: 0x0061E4A4
		public static void StartIActorLookAtEmptyData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CC74 RID: 183412 RVA: 0x006202AD File Offset: 0x0061E4AD
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CC75 RID: 183413 RVA: 0x006202B8 File Offset: 0x0061E4B8
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602CC76 RID: 183414 RVA: 0x006202C3 File Offset: 0x0061E4C3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602CC77 RID: 183415 RVA: 0x006202CE File Offset: 0x0061E4CE
		public static Offset<IActorLookAtEmptyData> EndIActorLookAtEmptyData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtEmptyData>(builder.EndTable());
		}

		// Token: 0x0602CC78 RID: 183416 RVA: 0x006202DC File Offset: 0x0061E4DC
		public IActorLookAtEmptyDataT UnPack()
		{
			IActorLookAtEmptyDataT actorLookAtEmptyDataT = new IActorLookAtEmptyDataT();
			this.UnPackTo(actorLookAtEmptyDataT);
			return actorLookAtEmptyDataT;
		}

		// Token: 0x0602CC79 RID: 183417 RVA: 0x006202F7 File Offset: 0x0061E4F7
		public void UnPackTo(IActorLookAtEmptyDataT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CC7A RID: 183418 RVA: 0x00620320 File Offset: 0x0061E520
		public static Offset<IActorLookAtEmptyData> Pack(FlatBufferBuilder builder, IActorLookAtEmptyDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtEmptyData>);
			}
			return IActorLookAtEmptyData.CreateIActorLookAtEmptyData(builder, _o.Type, _o.Lock, _o.NullMask);
		}

		// Token: 0x04011297 RID: 70295
		private Table __p;
	}
}
