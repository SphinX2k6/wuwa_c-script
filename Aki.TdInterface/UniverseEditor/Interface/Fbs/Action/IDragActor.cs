using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006606 RID: 26118
	public struct IDragActor : IFlatbufferObject
	{
		// Token: 0x1700C20C RID: 49676
		// (get) Token: 0x0602D58B RID: 185739 RVA: 0x00636FE6 File Offset: 0x006351E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D58C RID: 185740 RVA: 0x00636FF3 File Offset: 0x006351F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D58D RID: 185741 RVA: 0x00636FFC File Offset: 0x006351FC
		public static IDragActor GetRootAsIDragActor(ByteBuffer _bb)
		{
			return IDragActor.GetRootAsIDragActor(_bb, default(IDragActor));
		}

		// Token: 0x0602D58E RID: 185742 RVA: 0x00637018 File Offset: 0x00635218
		public static IDragActor GetRootAsIDragActor(ByteBuffer _bb, IDragActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D58F RID: 185743 RVA: 0x00637035 File Offset: 0x00635235
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D590 RID: 185744 RVA: 0x00637044 File Offset: 0x00635244
		public IDragActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C20D RID: 49677
		// (get) Token: 0x0602D591 RID: 185745 RVA: 0x00637054 File Offset: 0x00635254
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C20E RID: 49678
		// (get) Token: 0x0602D592 RID: 185746 RVA: 0x00637090 File Offset: 0x00635290
		public int TargetEntityId
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

		// Token: 0x0602D593 RID: 185747 RVA: 0x006370CC File Offset: 0x006352CC
		public static Offset<IDragActor> CreateIDragActor(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int TargetEntityId = 0)
		{
			builder.StartTable(2);
			IDragActor.AddTargetEntityId(builder, TargetEntityId);
			IDragActor.AddType(builder, Type);
			return IDragActor.EndIDragActor(builder);
		}

		// Token: 0x0602D594 RID: 185748 RVA: 0x006370E9 File Offset: 0x006352E9
		public static void StartIDragActor(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D595 RID: 185749 RVA: 0x006370F2 File Offset: 0x006352F2
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D596 RID: 185750 RVA: 0x006370FD File Offset: 0x006352FD
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x0602D597 RID: 185751 RVA: 0x00637108 File Offset: 0x00635308
		public static Offset<IDragActor> EndIDragActor(FlatBufferBuilder builder)
		{
			return new Offset<IDragActor>(builder.EndTable());
		}

		// Token: 0x0602D598 RID: 185752 RVA: 0x00637118 File Offset: 0x00635318
		public IDragActorT UnPack()
		{
			IDragActorT dragActorT = new IDragActorT();
			this.UnPackTo(dragActorT);
			return dragActorT;
		}

		// Token: 0x0602D599 RID: 185753 RVA: 0x00637133 File Offset: 0x00635333
		public void UnPackTo(IDragActorT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityId = this.TargetEntityId;
		}

		// Token: 0x0602D59A RID: 185754 RVA: 0x00637150 File Offset: 0x00635350
		public static Offset<IDragActor> Pack(FlatBufferBuilder builder, IDragActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDragActor>);
			}
			return IDragActor.CreateIDragActor(builder, _o.Type, _o.TargetEntityId);
		}

		// Token: 0x04010C8A RID: 68746
		private Table __p;
	}
}
