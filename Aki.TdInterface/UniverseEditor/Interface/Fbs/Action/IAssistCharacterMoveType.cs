using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200619A RID: 24986
	public struct IAssistCharacterMoveType : IFlatbufferObject
	{
		// Token: 0x1700BA41 RID: 47681
		// (get) Token: 0x0602B098 RID: 176280 RVA: 0x005EFA44 File Offset: 0x005EDC44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B099 RID: 176281 RVA: 0x005EFA51 File Offset: 0x005EDC51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B09A RID: 176282 RVA: 0x005EFA58 File Offset: 0x005EDC58
		public static IAssistCharacterMoveType GetRootAsIAssistCharacterMoveType(ByteBuffer _bb)
		{
			return IAssistCharacterMoveType.GetRootAsIAssistCharacterMoveType(_bb, default(IAssistCharacterMoveType));
		}

		// Token: 0x0602B09B RID: 176283 RVA: 0x005EFA74 File Offset: 0x005EDC74
		public static IAssistCharacterMoveType GetRootAsIAssistCharacterMoveType(ByteBuffer _bb, IAssistCharacterMoveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B09C RID: 176284 RVA: 0x005EFA91 File Offset: 0x005EDC91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B09D RID: 176285 RVA: 0x005EFAA0 File Offset: 0x005EDCA0
		public IAssistCharacterMoveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA42 RID: 47682
		// (get) Token: 0x0602B09E RID: 176286 RVA: 0x005EFAB0 File Offset: 0x005EDCB0
		public EAssistCharacterMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAssistCharacterMoveType.Navigation;
				}
				return (EAssistCharacterMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B09F RID: 176287 RVA: 0x005EFAEC File Offset: 0x005EDCEC
		public static Offset<IAssistCharacterMoveType> CreateIAssistCharacterMoveType(FlatBufferBuilder builder, EAssistCharacterMoveType Type = EAssistCharacterMoveType.Navigation)
		{
			builder.StartTable(1);
			IAssistCharacterMoveType.AddType(builder, Type);
			return IAssistCharacterMoveType.EndIAssistCharacterMoveType(builder);
		}

		// Token: 0x0602B0A0 RID: 176288 RVA: 0x005EFB02 File Offset: 0x005EDD02
		public static void StartIAssistCharacterMoveType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B0A1 RID: 176289 RVA: 0x005EFB0B File Offset: 0x005EDD0B
		public static void AddType(FlatBufferBuilder builder, EAssistCharacterMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B0A2 RID: 176290 RVA: 0x005EFB16 File Offset: 0x005EDD16
		public static Offset<IAssistCharacterMoveType> EndIAssistCharacterMoveType(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterMoveType>(builder.EndTable());
		}

		// Token: 0x0602B0A3 RID: 176291 RVA: 0x005EFB24 File Offset: 0x005EDD24
		public IAssistCharacterMoveTypeT UnPack()
		{
			IAssistCharacterMoveTypeT assistCharacterMoveTypeT = new IAssistCharacterMoveTypeT();
			this.UnPackTo(assistCharacterMoveTypeT);
			return assistCharacterMoveTypeT;
		}

		// Token: 0x0602B0A4 RID: 176292 RVA: 0x005EFB3F File Offset: 0x005EDD3F
		public void UnPackTo(IAssistCharacterMoveTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B0A5 RID: 176293 RVA: 0x005EFB50 File Offset: 0x005EDD50
		public static Offset<IAssistCharacterMoveType> Pack(FlatBufferBuilder builder, IAssistCharacterMoveTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterMoveType>);
			}
			return IAssistCharacterMoveType.CreateIAssistCharacterMoveType(builder, _o.Type);
		}

		// Token: 0x040106AA RID: 67242
		private Table __p;
	}
}
