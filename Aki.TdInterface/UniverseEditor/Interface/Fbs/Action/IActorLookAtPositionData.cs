using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200674B RID: 26443
	public struct IActorLookAtPositionData : IFlatbufferObject
	{
		// Token: 0x1700C044 RID: 49220
		// (get) Token: 0x0602CCF3 RID: 183539 RVA: 0x00620F50 File Offset: 0x0061F150
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CCF4 RID: 183540 RVA: 0x00620F5D File Offset: 0x0061F15D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CCF5 RID: 183541 RVA: 0x00620F64 File Offset: 0x0061F164
		public static IActorLookAtPositionData GetRootAsIActorLookAtPositionData(ByteBuffer _bb)
		{
			return IActorLookAtPositionData.GetRootAsIActorLookAtPositionData(_bb, default(IActorLookAtPositionData));
		}

		// Token: 0x0602CCF6 RID: 183542 RVA: 0x00620F80 File Offset: 0x0061F180
		public static IActorLookAtPositionData GetRootAsIActorLookAtPositionData(ByteBuffer _bb, IActorLookAtPositionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CCF7 RID: 183543 RVA: 0x00620F9D File Offset: 0x0061F19D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CCF8 RID: 183544 RVA: 0x00620FAC File Offset: 0x0061F1AC
		public IActorLookAtPositionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C045 RID: 49221
		// (get) Token: 0x0602CCF9 RID: 183545 RVA: 0x00620FBC File Offset: 0x0061F1BC
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

		// Token: 0x1700C046 RID: 49222
		// (get) Token: 0x0602CCFA RID: 183546 RVA: 0x00620FF8 File Offset: 0x0061F1F8
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C047 RID: 49223
		// (get) Token: 0x0602CCFB RID: 183547 RVA: 0x00621038 File Offset: 0x0061F238
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C048 RID: 49224
		// (get) Token: 0x0602CCFC RID: 183548 RVA: 0x00621098 File Offset: 0x0061F298
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CCFD RID: 183549 RVA: 0x006210D5 File Offset: 0x0061F2D5
		public static Offset<IActorLookAtPositionData> CreateIActorLookAtPositionData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IActorLookAtPositionData.AddPos(builder, PosOffset);
			IActorLookAtPositionData.AddNullMask(builder, NullMask);
			IActorLookAtPositionData.AddLock(builder, Lock);
			IActorLookAtPositionData.AddType(builder, Type);
			return IActorLookAtPositionData.EndIActorLookAtPositionData(builder);
		}

		// Token: 0x0602CCFE RID: 183550 RVA: 0x00621101 File Offset: 0x0061F301
		public static void StartIActorLookAtPositionData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602CCFF RID: 183551 RVA: 0x0062110A File Offset: 0x0061F30A
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CD00 RID: 183552 RVA: 0x00621115 File Offset: 0x0061F315
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602CD01 RID: 183553 RVA: 0x00621120 File Offset: 0x0061F320
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x0602CD02 RID: 183554 RVA: 0x00621130 File Offset: 0x0061F330
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602CD03 RID: 183555 RVA: 0x0062113B File Offset: 0x0061F33B
		public static Offset<IActorLookAtPositionData> EndIActorLookAtPositionData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtPositionData>(builder.EndTable());
		}

		// Token: 0x0602CD04 RID: 183556 RVA: 0x00621148 File Offset: 0x0061F348
		public IActorLookAtPositionDataT UnPack()
		{
			IActorLookAtPositionDataT actorLookAtPositionDataT = new IActorLookAtPositionDataT();
			this.UnPackTo(actorLookAtPositionDataT);
			return actorLookAtPositionDataT;
		}

		// Token: 0x0602CD05 RID: 183557 RVA: 0x00621164 File Offset: 0x0061F364
		public void UnPackTo(IActorLookAtPositionDataT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CD06 RID: 183558 RVA: 0x006211C4 File Offset: 0x0061F3C4
		public static Offset<IActorLookAtPositionData> Pack(FlatBufferBuilder builder, IActorLookAtPositionDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtPositionData>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IActorLookAtPositionData.CreateIActorLookAtPositionData(builder, _o.Type, _o.Lock, posOffset, _o.NullMask);
		}

		// Token: 0x040112AD RID: 70317
		private Table __p;
	}
}
