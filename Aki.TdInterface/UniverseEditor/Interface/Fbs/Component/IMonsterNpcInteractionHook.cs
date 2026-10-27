using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558D RID: 21901
	public struct IMonsterNpcInteractionHook : IFlatbufferObject
	{
		// Token: 0x1700A1D2 RID: 41426
		// (get) Token: 0x0602441D RID: 148509 RVA: 0x00501BF5 File Offset: 0x004FFDF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602441E RID: 148510 RVA: 0x00501C02 File Offset: 0x004FFE02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602441F RID: 148511 RVA: 0x00501C0C File Offset: 0x004FFE0C
		public static IMonsterNpcInteractionHook GetRootAsIMonsterNpcInteractionHook(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionHook.GetRootAsIMonsterNpcInteractionHook(_bb, default(IMonsterNpcInteractionHook));
		}

		// Token: 0x06024420 RID: 148512 RVA: 0x00501C28 File Offset: 0x004FFE28
		public static IMonsterNpcInteractionHook GetRootAsIMonsterNpcInteractionHook(ByteBuffer _bb, IMonsterNpcInteractionHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024421 RID: 148513 RVA: 0x00501C45 File Offset: 0x004FFE45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024422 RID: 148514 RVA: 0x00501C54 File Offset: 0x004FFE54
		public IMonsterNpcInteractionHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1D3 RID: 41427
		// (get) Token: 0x06024423 RID: 148515 RVA: 0x00501C64 File Offset: 0x004FFE64
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

		// Token: 0x06024424 RID: 148516 RVA: 0x00501CA0 File Offset: 0x004FFEA0
		public static Offset<IMonsterNpcInteractionHook> CreateIMonsterNpcInteractionHook(FlatBufferBuilder builder, EMonsterNpcInteractionType Type = EMonsterNpcInteractionType.WallRun)
		{
			builder.StartTable(1);
			IMonsterNpcInteractionHook.AddType(builder, Type);
			return IMonsterNpcInteractionHook.EndIMonsterNpcInteractionHook(builder);
		}

		// Token: 0x06024425 RID: 148517 RVA: 0x00501CB6 File Offset: 0x004FFEB6
		public static void StartIMonsterNpcInteractionHook(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024426 RID: 148518 RVA: 0x00501CBF File Offset: 0x004FFEBF
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024427 RID: 148519 RVA: 0x00501CCA File Offset: 0x004FFECA
		public static Offset<IMonsterNpcInteractionHook> EndIMonsterNpcInteractionHook(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionHook>(builder.EndTable());
		}

		// Token: 0x06024428 RID: 148520 RVA: 0x00501CD8 File Offset: 0x004FFED8
		public IMonsterNpcInteractionHookT UnPack()
		{
			IMonsterNpcInteractionHookT monsterNpcInteractionHookT = new IMonsterNpcInteractionHookT();
			this.UnPackTo(monsterNpcInteractionHookT);
			return monsterNpcInteractionHookT;
		}

		// Token: 0x06024429 RID: 148521 RVA: 0x00501CF3 File Offset: 0x004FFEF3
		public void UnPackTo(IMonsterNpcInteractionHookT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602442A RID: 148522 RVA: 0x00501D04 File Offset: 0x004FFF04
		public static Offset<IMonsterNpcInteractionHook> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionHook>);
			}
			return IMonsterNpcInteractionHook.CreateIMonsterNpcInteractionHook(builder, _o.Type);
		}

		// Token: 0x0400E8BF RID: 59583
		private Table __p;
	}
}
