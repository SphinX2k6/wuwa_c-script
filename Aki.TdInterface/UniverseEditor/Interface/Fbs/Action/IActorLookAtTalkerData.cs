using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200674E RID: 26446
	public struct IActorLookAtTalkerData : IFlatbufferObject
	{
		// Token: 0x1700C04D RID: 49229
		// (get) Token: 0x0602CD11 RID: 183569 RVA: 0x006212F3 File Offset: 0x0061F4F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD12 RID: 183570 RVA: 0x00621300 File Offset: 0x0061F500
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD13 RID: 183571 RVA: 0x00621308 File Offset: 0x0061F508
		public static IActorLookAtTalkerData GetRootAsIActorLookAtTalkerData(ByteBuffer _bb)
		{
			return IActorLookAtTalkerData.GetRootAsIActorLookAtTalkerData(_bb, default(IActorLookAtTalkerData));
		}

		// Token: 0x0602CD14 RID: 183572 RVA: 0x00621324 File Offset: 0x0061F524
		public static IActorLookAtTalkerData GetRootAsIActorLookAtTalkerData(ByteBuffer _bb, IActorLookAtTalkerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD15 RID: 183573 RVA: 0x00621341 File Offset: 0x0061F541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD16 RID: 183574 RVA: 0x00621350 File Offset: 0x0061F550
		public IActorLookAtTalkerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C04E RID: 49230
		// (get) Token: 0x0602CD17 RID: 183575 RVA: 0x00621360 File Offset: 0x0061F560
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

		// Token: 0x1700C04F RID: 49231
		// (get) Token: 0x0602CD18 RID: 183576 RVA: 0x0062139C File Offset: 0x0061F59C
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C050 RID: 49232
		// (get) Token: 0x0602CD19 RID: 183577 RVA: 0x006213DC File Offset: 0x0061F5DC
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

		// Token: 0x0602CD1A RID: 183578 RVA: 0x00621418 File Offset: 0x0061F618
		public static Offset<IActorLookAtTalkerData> CreateIActorLookAtTalkerData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorLookAtTalkerData.AddNullMask(builder, NullMask);
			IActorLookAtTalkerData.AddLock(builder, Lock);
			IActorLookAtTalkerData.AddType(builder, Type);
			return IActorLookAtTalkerData.EndIActorLookAtTalkerData(builder);
		}

		// Token: 0x0602CD1B RID: 183579 RVA: 0x0062143C File Offset: 0x0061F63C
		public static void StartIActorLookAtTalkerData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CD1C RID: 183580 RVA: 0x00621445 File Offset: 0x0061F645
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CD1D RID: 183581 RVA: 0x00621450 File Offset: 0x0061F650
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602CD1E RID: 183582 RVA: 0x0062145B File Offset: 0x0061F65B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602CD1F RID: 183583 RVA: 0x00621466 File Offset: 0x0061F666
		public static Offset<IActorLookAtTalkerData> EndIActorLookAtTalkerData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtTalkerData>(builder.EndTable());
		}

		// Token: 0x0602CD20 RID: 183584 RVA: 0x00621474 File Offset: 0x0061F674
		public IActorLookAtTalkerDataT UnPack()
		{
			IActorLookAtTalkerDataT actorLookAtTalkerDataT = new IActorLookAtTalkerDataT();
			this.UnPackTo(actorLookAtTalkerDataT);
			return actorLookAtTalkerDataT;
		}

		// Token: 0x0602CD21 RID: 183585 RVA: 0x0062148F File Offset: 0x0061F68F
		public void UnPackTo(IActorLookAtTalkerDataT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CD22 RID: 183586 RVA: 0x006214B8 File Offset: 0x0061F6B8
		public static Offset<IActorLookAtTalkerData> Pack(FlatBufferBuilder builder, IActorLookAtTalkerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtTalkerData>);
			}
			return IActorLookAtTalkerData.CreateIActorLookAtTalkerData(builder, _o.Type, _o.Lock, _o.NullMask);
		}

		// Token: 0x040112B2 RID: 70322
		private Table __p;
	}
}
