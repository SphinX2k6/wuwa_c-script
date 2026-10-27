using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A96 RID: 19094
	public struct ICheckIsPlayerHoldingHands : IFlatbufferObject
	{
		// Token: 0x17008A56 RID: 35414
		// (get) Token: 0x0601DF2C RID: 122668 RVA: 0x0043486A File Offset: 0x00432A6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF2D RID: 122669 RVA: 0x00434877 File Offset: 0x00432A77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF2E RID: 122670 RVA: 0x00434880 File Offset: 0x00432A80
		public static ICheckIsPlayerHoldingHands GetRootAsICheckIsPlayerHoldingHands(ByteBuffer _bb)
		{
			return ICheckIsPlayerHoldingHands.GetRootAsICheckIsPlayerHoldingHands(_bb, default(ICheckIsPlayerHoldingHands));
		}

		// Token: 0x0601DF2F RID: 122671 RVA: 0x0043489C File Offset: 0x00432A9C
		public static ICheckIsPlayerHoldingHands GetRootAsICheckIsPlayerHoldingHands(ByteBuffer _bb, ICheckIsPlayerHoldingHands obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF30 RID: 122672 RVA: 0x004348B9 File Offset: 0x00432AB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF31 RID: 122673 RVA: 0x004348C8 File Offset: 0x00432AC8
		public ICheckIsPlayerHoldingHands __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A57 RID: 35415
		// (get) Token: 0x0601DF32 RID: 122674 RVA: 0x004348D8 File Offset: 0x00432AD8
		public ECheckHoldingHandsCharacter Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckHoldingHandsCharacter.Player;
				}
				return (ECheckHoldingHandsCharacter)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DF33 RID: 122675 RVA: 0x00434914 File Offset: 0x00432B14
		public static Offset<ICheckIsPlayerHoldingHands> CreateICheckIsPlayerHoldingHands(FlatBufferBuilder builder, ECheckHoldingHandsCharacter Type = ECheckHoldingHandsCharacter.Player)
		{
			builder.StartTable(1);
			ICheckIsPlayerHoldingHands.AddType(builder, Type);
			return ICheckIsPlayerHoldingHands.EndICheckIsPlayerHoldingHands(builder);
		}

		// Token: 0x0601DF34 RID: 122676 RVA: 0x0043492A File Offset: 0x00432B2A
		public static void StartICheckIsPlayerHoldingHands(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DF35 RID: 122677 RVA: 0x00434933 File Offset: 0x00432B33
		public static void AddType(FlatBufferBuilder builder, ECheckHoldingHandsCharacter type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DF36 RID: 122678 RVA: 0x0043493E File Offset: 0x00432B3E
		public static Offset<ICheckIsPlayerHoldingHands> EndICheckIsPlayerHoldingHands(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsPlayerHoldingHands>(builder.EndTable());
		}

		// Token: 0x0601DF37 RID: 122679 RVA: 0x0043494C File Offset: 0x00432B4C
		public ICheckIsPlayerHoldingHandsT UnPack()
		{
			ICheckIsPlayerHoldingHandsT checkIsPlayerHoldingHandsT = new ICheckIsPlayerHoldingHandsT();
			this.UnPackTo(checkIsPlayerHoldingHandsT);
			return checkIsPlayerHoldingHandsT;
		}

		// Token: 0x0601DF38 RID: 122680 RVA: 0x00434967 File Offset: 0x00432B67
		public void UnPackTo(ICheckIsPlayerHoldingHandsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601DF39 RID: 122681 RVA: 0x00434978 File Offset: 0x00432B78
		public static Offset<ICheckIsPlayerHoldingHands> Pack(FlatBufferBuilder builder, ICheckIsPlayerHoldingHandsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsPlayerHoldingHands>);
			}
			return ICheckIsPlayerHoldingHands.CreateICheckIsPlayerHoldingHands(builder, _o.Type);
		}

		// Token: 0x0400D307 RID: 54023
		private Table __p;
	}
}
