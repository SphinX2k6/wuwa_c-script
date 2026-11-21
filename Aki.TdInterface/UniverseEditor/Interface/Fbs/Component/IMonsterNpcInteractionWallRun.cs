using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B31 RID: 23345
	public struct IMonsterNpcInteractionWallRun : IFlatbufferObject
	{
		// Token: 0x1700AA60 RID: 43616
		// (get) Token: 0x0602664E RID: 157262 RVA: 0x0054245D File Offset: 0x0054065D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602664F RID: 157263 RVA: 0x0054246A File Offset: 0x0054066A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026650 RID: 157264 RVA: 0x00542474 File Offset: 0x00540674
		public static IMonsterNpcInteractionWallRun GetRootAsIMonsterNpcInteractionWallRun(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionWallRun.GetRootAsIMonsterNpcInteractionWallRun(_bb, default(IMonsterNpcInteractionWallRun));
		}

		// Token: 0x06026651 RID: 157265 RVA: 0x00542490 File Offset: 0x00540690
		public static IMonsterNpcInteractionWallRun GetRootAsIMonsterNpcInteractionWallRun(ByteBuffer _bb, IMonsterNpcInteractionWallRun obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026652 RID: 157266 RVA: 0x005424AD File Offset: 0x005406AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026653 RID: 157267 RVA: 0x005424BC File Offset: 0x005406BC
		public IMonsterNpcInteractionWallRun __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA61 RID: 43617
		// (get) Token: 0x06026654 RID: 157268 RVA: 0x005424CC File Offset: 0x005406CC
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

		// Token: 0x06026655 RID: 157269 RVA: 0x00542508 File Offset: 0x00540708
		public static Offset<IMonsterNpcInteractionWallRun> CreateIMonsterNpcInteractionWallRun(FlatBufferBuilder builder, EMonsterNpcInteractionType Type = EMonsterNpcInteractionType.WallRun)
		{
			builder.StartTable(1);
			IMonsterNpcInteractionWallRun.AddType(builder, Type);
			return IMonsterNpcInteractionWallRun.EndIMonsterNpcInteractionWallRun(builder);
		}

		// Token: 0x06026656 RID: 157270 RVA: 0x0054251E File Offset: 0x0054071E
		public static void StartIMonsterNpcInteractionWallRun(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026657 RID: 157271 RVA: 0x00542527 File Offset: 0x00540727
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026658 RID: 157272 RVA: 0x00542532 File Offset: 0x00540732
		public static Offset<IMonsterNpcInteractionWallRun> EndIMonsterNpcInteractionWallRun(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionWallRun>(builder.EndTable());
		}

		// Token: 0x06026659 RID: 157273 RVA: 0x00542540 File Offset: 0x00540740
		public IMonsterNpcInteractionWallRunT UnPack()
		{
			IMonsterNpcInteractionWallRunT monsterNpcInteractionWallRunT = new IMonsterNpcInteractionWallRunT();
			this.UnPackTo(monsterNpcInteractionWallRunT);
			return monsterNpcInteractionWallRunT;
		}

		// Token: 0x0602665A RID: 157274 RVA: 0x0054255B File Offset: 0x0054075B
		public void UnPackTo(IMonsterNpcInteractionWallRunT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602665B RID: 157275 RVA: 0x0054256C File Offset: 0x0054076C
		public static Offset<IMonsterNpcInteractionWallRun> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionWallRunT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionWallRun>);
			}
			return IMonsterNpcInteractionWallRun.CreateIMonsterNpcInteractionWallRun(builder, _o.Type);
		}

		// Token: 0x0400F525 RID: 62757
		private Table __p;
	}
}
