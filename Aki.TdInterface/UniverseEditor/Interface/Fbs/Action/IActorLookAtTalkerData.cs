using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060EC RID: 24812
	public struct IActorLookAtTalkerData : IFlatbufferObject
	{
		// Token: 0x1700B6E2 RID: 46818
		// (get) Token: 0x0602A630 RID: 173616 RVA: 0x005D734B File Offset: 0x005D554B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A631 RID: 173617 RVA: 0x005D7358 File Offset: 0x005D5558
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A632 RID: 173618 RVA: 0x005D7360 File Offset: 0x005D5560
		public static IActorLookAtTalkerData GetRootAsIActorLookAtTalkerData(ByteBuffer _bb)
		{
			return IActorLookAtTalkerData.GetRootAsIActorLookAtTalkerData(_bb, default(IActorLookAtTalkerData));
		}

		// Token: 0x0602A633 RID: 173619 RVA: 0x005D737C File Offset: 0x005D557C
		public static IActorLookAtTalkerData GetRootAsIActorLookAtTalkerData(ByteBuffer _bb, IActorLookAtTalkerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A634 RID: 173620 RVA: 0x005D7399 File Offset: 0x005D5599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A635 RID: 173621 RVA: 0x005D73A8 File Offset: 0x005D55A8
		public IActorLookAtTalkerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6E3 RID: 46819
		// (get) Token: 0x0602A636 RID: 173622 RVA: 0x005D73B8 File Offset: 0x005D55B8
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

		// Token: 0x1700B6E4 RID: 46820
		// (get) Token: 0x0602A637 RID: 173623 RVA: 0x005D73F4 File Offset: 0x005D55F4
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6E5 RID: 46821
		// (get) Token: 0x0602A638 RID: 173624 RVA: 0x005D7434 File Offset: 0x005D5634
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

		// Token: 0x0602A639 RID: 173625 RVA: 0x005D7470 File Offset: 0x005D5670
		public static Offset<IActorLookAtTalkerData> CreateIActorLookAtTalkerData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorLookAtTalkerData.AddNullMask(builder, NullMask);
			IActorLookAtTalkerData.AddLock(builder, Lock);
			IActorLookAtTalkerData.AddType(builder, Type);
			return IActorLookAtTalkerData.EndIActorLookAtTalkerData(builder);
		}

		// Token: 0x0602A63A RID: 173626 RVA: 0x005D7494 File Offset: 0x005D5694
		public static void StartIActorLookAtTalkerData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A63B RID: 173627 RVA: 0x005D749D File Offset: 0x005D569D
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A63C RID: 173628 RVA: 0x005D74A8 File Offset: 0x005D56A8
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602A63D RID: 173629 RVA: 0x005D74B3 File Offset: 0x005D56B3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A63E RID: 173630 RVA: 0x005D74BE File Offset: 0x005D56BE
		public static Offset<IActorLookAtTalkerData> EndIActorLookAtTalkerData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtTalkerData>(builder.EndTable());
		}

		// Token: 0x0602A63F RID: 173631 RVA: 0x005D74CC File Offset: 0x005D56CC
		public IActorLookAtTalkerDataT UnPack()
		{
			IActorLookAtTalkerDataT actorLookAtTalkerDataT = new IActorLookAtTalkerDataT();
			this.UnPackTo(actorLookAtTalkerDataT);
			return actorLookAtTalkerDataT;
		}

		// Token: 0x0602A640 RID: 173632 RVA: 0x005D74E7 File Offset: 0x005D56E7
		public void UnPackTo(IActorLookAtTalkerDataT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A641 RID: 173633 RVA: 0x005D7510 File Offset: 0x005D5710
		public static Offset<IActorLookAtTalkerData> Pack(FlatBufferBuilder builder, IActorLookAtTalkerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtTalkerData>);
			}
			return IActorLookAtTalkerData.CreateIActorLookAtTalkerData(builder, _o.Type, _o.Lock, _o.NullMask);
		}

		// Token: 0x040104AE RID: 66734
		private Table __p;
	}
}
