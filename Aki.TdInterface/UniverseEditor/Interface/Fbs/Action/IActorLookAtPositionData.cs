using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060E9 RID: 24809
	public struct IActorLookAtPositionData : IFlatbufferObject
	{
		// Token: 0x1700B6D9 RID: 46809
		// (get) Token: 0x0602A612 RID: 173586 RVA: 0x005D6FA8 File Offset: 0x005D51A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A613 RID: 173587 RVA: 0x005D6FB5 File Offset: 0x005D51B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A614 RID: 173588 RVA: 0x005D6FBC File Offset: 0x005D51BC
		public static IActorLookAtPositionData GetRootAsIActorLookAtPositionData(ByteBuffer _bb)
		{
			return IActorLookAtPositionData.GetRootAsIActorLookAtPositionData(_bb, default(IActorLookAtPositionData));
		}

		// Token: 0x0602A615 RID: 173589 RVA: 0x005D6FD8 File Offset: 0x005D51D8
		public static IActorLookAtPositionData GetRootAsIActorLookAtPositionData(ByteBuffer _bb, IActorLookAtPositionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A616 RID: 173590 RVA: 0x005D6FF5 File Offset: 0x005D51F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A617 RID: 173591 RVA: 0x005D7004 File Offset: 0x005D5204
		public IActorLookAtPositionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6DA RID: 46810
		// (get) Token: 0x0602A618 RID: 173592 RVA: 0x005D7014 File Offset: 0x005D5214
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

		// Token: 0x1700B6DB RID: 46811
		// (get) Token: 0x0602A619 RID: 173593 RVA: 0x005D7050 File Offset: 0x005D5250
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6DC RID: 46812
		// (get) Token: 0x0602A61A RID: 173594 RVA: 0x005D7090 File Offset: 0x005D5290
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

		// Token: 0x1700B6DD RID: 46813
		// (get) Token: 0x0602A61B RID: 173595 RVA: 0x005D70F0 File Offset: 0x005D52F0
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

		// Token: 0x0602A61C RID: 173596 RVA: 0x005D712D File Offset: 0x005D532D
		public static Offset<IActorLookAtPositionData> CreateIActorLookAtPositionData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IActorLookAtPositionData.AddPos(builder, PosOffset);
			IActorLookAtPositionData.AddNullMask(builder, NullMask);
			IActorLookAtPositionData.AddLock(builder, Lock);
			IActorLookAtPositionData.AddType(builder, Type);
			return IActorLookAtPositionData.EndIActorLookAtPositionData(builder);
		}

		// Token: 0x0602A61D RID: 173597 RVA: 0x005D7159 File Offset: 0x005D5359
		public static void StartIActorLookAtPositionData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A61E RID: 173598 RVA: 0x005D7162 File Offset: 0x005D5362
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A61F RID: 173599 RVA: 0x005D716D File Offset: 0x005D536D
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602A620 RID: 173600 RVA: 0x005D7178 File Offset: 0x005D5378
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x0602A621 RID: 173601 RVA: 0x005D7188 File Offset: 0x005D5388
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602A622 RID: 173602 RVA: 0x005D7193 File Offset: 0x005D5393
		public static Offset<IActorLookAtPositionData> EndIActorLookAtPositionData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtPositionData>(builder.EndTable());
		}

		// Token: 0x0602A623 RID: 173603 RVA: 0x005D71A0 File Offset: 0x005D53A0
		public IActorLookAtPositionDataT UnPack()
		{
			IActorLookAtPositionDataT actorLookAtPositionDataT = new IActorLookAtPositionDataT();
			this.UnPackTo(actorLookAtPositionDataT);
			return actorLookAtPositionDataT;
		}

		// Token: 0x0602A624 RID: 173604 RVA: 0x005D71BC File Offset: 0x005D53BC
		public void UnPackTo(IActorLookAtPositionDataT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A625 RID: 173605 RVA: 0x005D721C File Offset: 0x005D541C
		public static Offset<IActorLookAtPositionData> Pack(FlatBufferBuilder builder, IActorLookAtPositionDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtPositionData>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IActorLookAtPositionData.CreateIActorLookAtPositionData(builder, _o.Type, _o.Lock, posOffset, _o.NullMask);
		}

		// Token: 0x040104A9 RID: 66729
		private Table __p;
	}
}
