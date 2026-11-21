using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9E RID: 23198
	public struct ILookAtTargetPlayer : IFlatbufferObject
	{
		// Token: 0x1700A90B RID: 43275
		// (get) Token: 0x06026065 RID: 155749 RVA: 0x0053611A File Offset: 0x0053431A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026066 RID: 155750 RVA: 0x00536127 File Offset: 0x00534327
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026067 RID: 155751 RVA: 0x00536130 File Offset: 0x00534330
		public static ILookAtTargetPlayer GetRootAsILookAtTargetPlayer(ByteBuffer _bb)
		{
			return ILookAtTargetPlayer.GetRootAsILookAtTargetPlayer(_bb, default(ILookAtTargetPlayer));
		}

		// Token: 0x06026068 RID: 155752 RVA: 0x0053614C File Offset: 0x0053434C
		public static ILookAtTargetPlayer GetRootAsILookAtTargetPlayer(ByteBuffer _bb, ILookAtTargetPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026069 RID: 155753 RVA: 0x00536169 File Offset: 0x00534369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602606A RID: 155754 RVA: 0x00536178 File Offset: 0x00534378
		public ILookAtTargetPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A90C RID: 43276
		// (get) Token: 0x0602606B RID: 155755 RVA: 0x00536188 File Offset: 0x00534388
		public ELookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELookAtTargetType.Entity;
				}
				return (ELookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602606C RID: 155756 RVA: 0x005361C4 File Offset: 0x005343C4
		public static Offset<ILookAtTargetPlayer> CreateILookAtTargetPlayer(FlatBufferBuilder builder, ELookAtTargetType Type = ELookAtTargetType.Entity)
		{
			builder.StartTable(1);
			ILookAtTargetPlayer.AddType(builder, Type);
			return ILookAtTargetPlayer.EndILookAtTargetPlayer(builder);
		}

		// Token: 0x0602606D RID: 155757 RVA: 0x005361DA File Offset: 0x005343DA
		public static void StartILookAtTargetPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602606E RID: 155758 RVA: 0x005361E3 File Offset: 0x005343E3
		public static void AddType(FlatBufferBuilder builder, ELookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602606F RID: 155759 RVA: 0x005361EE File Offset: 0x005343EE
		public static Offset<ILookAtTargetPlayer> EndILookAtTargetPlayer(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtTargetPlayer>(builder.EndTable());
		}

		// Token: 0x06026070 RID: 155760 RVA: 0x005361FC File Offset: 0x005343FC
		public ILookAtTargetPlayerT UnPack()
		{
			ILookAtTargetPlayerT lookAtTargetPlayerT = new ILookAtTargetPlayerT();
			this.UnPackTo(lookAtTargetPlayerT);
			return lookAtTargetPlayerT;
		}

		// Token: 0x06026071 RID: 155761 RVA: 0x00536217 File Offset: 0x00534417
		public void UnPackTo(ILookAtTargetPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026072 RID: 155762 RVA: 0x00536228 File Offset: 0x00534428
		public static Offset<ILookAtTargetPlayer> Pack(FlatBufferBuilder builder, ILookAtTargetPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtTargetPlayer>);
			}
			return ILookAtTargetPlayer.CreateILookAtTargetPlayer(builder, _o.Type);
		}

		// Token: 0x0400F43E RID: 62526
		private Table __p;
	}
}
