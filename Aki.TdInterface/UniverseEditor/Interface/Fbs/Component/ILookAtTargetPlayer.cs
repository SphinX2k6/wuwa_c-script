using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005518 RID: 21784
	public struct ILookAtTargetPlayer : IFlatbufferObject
	{
		// Token: 0x1700A0D1 RID: 41169
		// (get) Token: 0x06023FAB RID: 147371 RVA: 0x004F8FF6 File Offset: 0x004F71F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023FAC RID: 147372 RVA: 0x004F9003 File Offset: 0x004F7203
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023FAD RID: 147373 RVA: 0x004F900C File Offset: 0x004F720C
		public static ILookAtTargetPlayer GetRootAsILookAtTargetPlayer(ByteBuffer _bb)
		{
			return ILookAtTargetPlayer.GetRootAsILookAtTargetPlayer(_bb, default(ILookAtTargetPlayer));
		}

		// Token: 0x06023FAE RID: 147374 RVA: 0x004F9028 File Offset: 0x004F7228
		public static ILookAtTargetPlayer GetRootAsILookAtTargetPlayer(ByteBuffer _bb, ILookAtTargetPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023FAF RID: 147375 RVA: 0x004F9045 File Offset: 0x004F7245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023FB0 RID: 147376 RVA: 0x004F9054 File Offset: 0x004F7254
		public ILookAtTargetPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0D2 RID: 41170
		// (get) Token: 0x06023FB1 RID: 147377 RVA: 0x004F9064 File Offset: 0x004F7264
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

		// Token: 0x06023FB2 RID: 147378 RVA: 0x004F90A0 File Offset: 0x004F72A0
		public static Offset<ILookAtTargetPlayer> CreateILookAtTargetPlayer(FlatBufferBuilder builder, ELookAtTargetType Type = ELookAtTargetType.Entity)
		{
			builder.StartTable(1);
			ILookAtTargetPlayer.AddType(builder, Type);
			return ILookAtTargetPlayer.EndILookAtTargetPlayer(builder);
		}

		// Token: 0x06023FB3 RID: 147379 RVA: 0x004F90B6 File Offset: 0x004F72B6
		public static void StartILookAtTargetPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023FB4 RID: 147380 RVA: 0x004F90BF File Offset: 0x004F72BF
		public static void AddType(FlatBufferBuilder builder, ELookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023FB5 RID: 147381 RVA: 0x004F90CA File Offset: 0x004F72CA
		public static Offset<ILookAtTargetPlayer> EndILookAtTargetPlayer(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtTargetPlayer>(builder.EndTable());
		}

		// Token: 0x06023FB6 RID: 147382 RVA: 0x004F90D8 File Offset: 0x004F72D8
		public ILookAtTargetPlayerT UnPack()
		{
			ILookAtTargetPlayerT lookAtTargetPlayerT = new ILookAtTargetPlayerT();
			this.UnPackTo(lookAtTargetPlayerT);
			return lookAtTargetPlayerT;
		}

		// Token: 0x06023FB7 RID: 147383 RVA: 0x004F90F3 File Offset: 0x004F72F3
		public void UnPackTo(ILookAtTargetPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023FB8 RID: 147384 RVA: 0x004F9104 File Offset: 0x004F7304
		public static Offset<ILookAtTargetPlayer> Pack(FlatBufferBuilder builder, ILookAtTargetPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtTargetPlayer>);
			}
			return ILookAtTargetPlayer.CreateILookAtTargetPlayer(builder, _o.Type);
		}

		// Token: 0x0400E80D RID: 59405
		private Table __p;
	}
}
