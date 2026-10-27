using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF9 RID: 27897
	public struct IPlayerInput : IFlatbufferObject
	{
		// Token: 0x1700CFC1 RID: 53185
		// (get) Token: 0x0603130B RID: 201483 RVA: 0x006AC5E1 File Offset: 0x006AA7E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603130C RID: 201484 RVA: 0x006AC5EE File Offset: 0x006AA7EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603130D RID: 201485 RVA: 0x006AC5F8 File Offset: 0x006AA7F8
		public static IPlayerInput GetRootAsIPlayerInput(ByteBuffer _bb)
		{
			return IPlayerInput.GetRootAsIPlayerInput(_bb, default(IPlayerInput));
		}

		// Token: 0x0603130E RID: 201486 RVA: 0x006AC614 File Offset: 0x006AA814
		public static IPlayerInput GetRootAsIPlayerInput(ByteBuffer _bb, IPlayerInput obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603130F RID: 201487 RVA: 0x006AC631 File Offset: 0x006AA831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031310 RID: 201488 RVA: 0x006AC640 File Offset: 0x006AA840
		public IPlayerInput __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFC2 RID: 53186
		// (get) Token: 0x06031311 RID: 201489 RVA: 0x006AC650 File Offset: 0x006AA850
		public EPlayerInputType Input
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerInputType.None;
				}
				return (EPlayerInputType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031312 RID: 201490 RVA: 0x006AC68C File Offset: 0x006AA88C
		public static Offset<IPlayerInput> CreateIPlayerInput(FlatBufferBuilder builder, EPlayerInputType Input = EPlayerInputType.None)
		{
			builder.StartTable(1);
			IPlayerInput.AddInput(builder, Input);
			return IPlayerInput.EndIPlayerInput(builder);
		}

		// Token: 0x06031313 RID: 201491 RVA: 0x006AC6A2 File Offset: 0x006AA8A2
		public static void StartIPlayerInput(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031314 RID: 201492 RVA: 0x006AC6AB File Offset: 0x006AA8AB
		public static void AddInput(FlatBufferBuilder builder, EPlayerInputType input)
		{
			builder.AddByte(0, (byte)input, 0);
		}

		// Token: 0x06031315 RID: 201493 RVA: 0x006AC6B6 File Offset: 0x006AA8B6
		public static Offset<IPlayerInput> EndIPlayerInput(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerInput>(builder.EndTable());
		}

		// Token: 0x06031316 RID: 201494 RVA: 0x006AC6C4 File Offset: 0x006AA8C4
		public IPlayerInputT UnPack()
		{
			IPlayerInputT playerInputT = new IPlayerInputT();
			this.UnPackTo(playerInputT);
			return playerInputT;
		}

		// Token: 0x06031317 RID: 201495 RVA: 0x006AC6DF File Offset: 0x006AA8DF
		public void UnPackTo(IPlayerInputT _o)
		{
			_o.Input = this.Input;
		}

		// Token: 0x06031318 RID: 201496 RVA: 0x006AC6F0 File Offset: 0x006AA8F0
		public static Offset<IPlayerInput> Pack(FlatBufferBuilder builder, IPlayerInputT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerInput>);
			}
			return IPlayerInput.CreateIPlayerInput(builder, _o.Input);
		}

		// Token: 0x04011675 RID: 71285
		private Table __p;
	}
}
