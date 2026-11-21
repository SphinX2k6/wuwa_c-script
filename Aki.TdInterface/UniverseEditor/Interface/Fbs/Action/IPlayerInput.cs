using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007474 RID: 29812
	public struct IPlayerInput : IFlatbufferObject
	{
		// Token: 0x1700DB05 RID: 56069
		// (get) Token: 0x060342FF RID: 213759 RVA: 0x00707B11 File Offset: 0x00705D11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034300 RID: 213760 RVA: 0x00707B1E File Offset: 0x00705D1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034301 RID: 213761 RVA: 0x00707B28 File Offset: 0x00705D28
		public static IPlayerInput GetRootAsIPlayerInput(ByteBuffer _bb)
		{
			return IPlayerInput.GetRootAsIPlayerInput(_bb, default(IPlayerInput));
		}

		// Token: 0x06034302 RID: 213762 RVA: 0x00707B44 File Offset: 0x00705D44
		public static IPlayerInput GetRootAsIPlayerInput(ByteBuffer _bb, IPlayerInput obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034303 RID: 213763 RVA: 0x00707B61 File Offset: 0x00705D61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034304 RID: 213764 RVA: 0x00707B70 File Offset: 0x00705D70
		public IPlayerInput __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB06 RID: 56070
		// (get) Token: 0x06034305 RID: 213765 RVA: 0x00707B80 File Offset: 0x00705D80
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

		// Token: 0x06034306 RID: 213766 RVA: 0x00707BBC File Offset: 0x00705DBC
		public static Offset<IPlayerInput> CreateIPlayerInput(FlatBufferBuilder builder, EPlayerInputType Input = EPlayerInputType.None)
		{
			builder.StartTable(1);
			IPlayerInput.AddInput(builder, Input);
			return IPlayerInput.EndIPlayerInput(builder);
		}

		// Token: 0x06034307 RID: 213767 RVA: 0x00707BD2 File Offset: 0x00705DD2
		public static void StartIPlayerInput(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034308 RID: 213768 RVA: 0x00707BDB File Offset: 0x00705DDB
		public static void AddInput(FlatBufferBuilder builder, EPlayerInputType input)
		{
			builder.AddByte(0, (byte)input, 0);
		}

		// Token: 0x06034309 RID: 213769 RVA: 0x00707BE6 File Offset: 0x00705DE6
		public static Offset<IPlayerInput> EndIPlayerInput(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerInput>(builder.EndTable());
		}

		// Token: 0x0603430A RID: 213770 RVA: 0x00707BF4 File Offset: 0x00705DF4
		public IPlayerInputT UnPack()
		{
			IPlayerInputT playerInputT = new IPlayerInputT();
			this.UnPackTo(playerInputT);
			return playerInputT;
		}

		// Token: 0x0603430B RID: 213771 RVA: 0x00707C0F File Offset: 0x00705E0F
		public void UnPackTo(IPlayerInputT _o)
		{
			_o.Input = this.Input;
		}

		// Token: 0x0603430C RID: 213772 RVA: 0x00707C20 File Offset: 0x00705E20
		public static Offset<IPlayerInput> Pack(FlatBufferBuilder builder, IPlayerInputT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerInput>);
			}
			return IPlayerInput.CreateIPlayerInput(builder, _o.Input);
		}

		// Token: 0x040125EF RID: 75247
		private Table __p;
	}
}
