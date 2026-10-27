using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005593 RID: 21907
	public struct IMonsterNpcInteractionWallRun : IFlatbufferObject
	{
		// Token: 0x1700A1D8 RID: 41432
		// (get) Token: 0x06024441 RID: 148545 RVA: 0x00501EE5 File Offset: 0x005000E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024442 RID: 148546 RVA: 0x00501EF2 File Offset: 0x005000F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024443 RID: 148547 RVA: 0x00501EFC File Offset: 0x005000FC
		public static IMonsterNpcInteractionWallRun GetRootAsIMonsterNpcInteractionWallRun(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionWallRun.GetRootAsIMonsterNpcInteractionWallRun(_bb, default(IMonsterNpcInteractionWallRun));
		}

		// Token: 0x06024444 RID: 148548 RVA: 0x00501F18 File Offset: 0x00500118
		public static IMonsterNpcInteractionWallRun GetRootAsIMonsterNpcInteractionWallRun(ByteBuffer _bb, IMonsterNpcInteractionWallRun obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024445 RID: 148549 RVA: 0x00501F35 File Offset: 0x00500135
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024446 RID: 148550 RVA: 0x00501F44 File Offset: 0x00500144
		public IMonsterNpcInteractionWallRun __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1D9 RID: 41433
		// (get) Token: 0x06024447 RID: 148551 RVA: 0x00501F54 File Offset: 0x00500154
		public EMonsterNpcInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return (EMonsterNpcInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024448 RID: 148552 RVA: 0x00501F90 File Offset: 0x00500190
		public static Offset<IMonsterNpcInteractionWallRun> CreateIMonsterNpcInteractionWallRun(FlatBufferBuilder builder, EMonsterNpcInteractionType Type = EMonsterNpcInteractionType.WallRun)
		{
			builder.StartTable(1);
			IMonsterNpcInteractionWallRun.AddType(builder, Type);
			return IMonsterNpcInteractionWallRun.EndIMonsterNpcInteractionWallRun(builder);
		}

		// Token: 0x06024449 RID: 148553 RVA: 0x00501FA6 File Offset: 0x005001A6
		public static void StartIMonsterNpcInteractionWallRun(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602444A RID: 148554 RVA: 0x00501FAF File Offset: 0x005001AF
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602444B RID: 148555 RVA: 0x00501FBA File Offset: 0x005001BA
		public static Offset<IMonsterNpcInteractionWallRun> EndIMonsterNpcInteractionWallRun(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionWallRun>(builder.EndTable());
		}

		// Token: 0x0602444C RID: 148556 RVA: 0x00501FC8 File Offset: 0x005001C8
		public IMonsterNpcInteractionWallRunT UnPack()
		{
			IMonsterNpcInteractionWallRunT monsterNpcInteractionWallRunT = new IMonsterNpcInteractionWallRunT();
			this.UnPackTo(monsterNpcInteractionWallRunT);
			return monsterNpcInteractionWallRunT;
		}

		// Token: 0x0602444D RID: 148557 RVA: 0x00501FE3 File Offset: 0x005001E3
		public void UnPackTo(IMonsterNpcInteractionWallRunT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602444E RID: 148558 RVA: 0x00501FF4 File Offset: 0x005001F4
		public static Offset<IMonsterNpcInteractionWallRun> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionWallRunT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionWallRun>);
			}
			return IMonsterNpcInteractionWallRun.CreateIMonsterNpcInteractionWallRun(builder, _o.Type);
		}

		// Token: 0x0400E8C3 RID: 59587
		private Table __p;
	}
}
