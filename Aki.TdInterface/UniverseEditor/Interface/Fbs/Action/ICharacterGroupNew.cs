using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A8 RID: 27048
	public struct ICharacterGroupNew : IFlatbufferObject
	{
		// Token: 0x1700C716 RID: 50966
		// (get) Token: 0x0602E657 RID: 190039 RVA: 0x0065502A File Offset: 0x0065322A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E658 RID: 190040 RVA: 0x00655037 File Offset: 0x00653237
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E659 RID: 190041 RVA: 0x00655040 File Offset: 0x00653240
		public static ICharacterGroupNew GetRootAsICharacterGroupNew(ByteBuffer _bb)
		{
			return ICharacterGroupNew.GetRootAsICharacterGroupNew(_bb, default(ICharacterGroupNew));
		}

		// Token: 0x0602E65A RID: 190042 RVA: 0x0065505C File Offset: 0x0065325C
		public static ICharacterGroupNew GetRootAsICharacterGroupNew(ByteBuffer _bb, ICharacterGroupNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E65B RID: 190043 RVA: 0x00655079 File Offset: 0x00653279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E65C RID: 190044 RVA: 0x00655088 File Offset: 0x00653288
		public ICharacterGroupNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C717 RID: 50967
		// (get) Token: 0x0602E65D RID: 190045 RVA: 0x00655098 File Offset: 0x00653298
		public int CharacterId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C718 RID: 50968
		// (get) Token: 0x0602E65E RID: 190046 RVA: 0x006550D4 File Offset: 0x006532D4
		public bool IsAiCharacter
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602E65F RID: 190047 RVA: 0x00655113 File Offset: 0x00653313
		public static Offset<ICharacterGroupNew> CreateICharacterGroupNew(FlatBufferBuilder builder, int CharacterId = 0, bool IsAiCharacter = false)
		{
			builder.StartTable(2);
			ICharacterGroupNew.AddCharacterId(builder, CharacterId);
			ICharacterGroupNew.AddIsAiCharacter(builder, IsAiCharacter);
			return ICharacterGroupNew.EndICharacterGroupNew(builder);
		}

		// Token: 0x0602E660 RID: 190048 RVA: 0x00655130 File Offset: 0x00653330
		public static void StartICharacterGroupNew(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E661 RID: 190049 RVA: 0x00655139 File Offset: 0x00653339
		public static void AddCharacterId(FlatBufferBuilder builder, int characterId)
		{
			builder.AddInt(0, characterId, 0);
		}

		// Token: 0x0602E662 RID: 190050 RVA: 0x00655144 File Offset: 0x00653344
		public static void AddIsAiCharacter(FlatBufferBuilder builder, bool isAiCharacter)
		{
			builder.AddBool(1, isAiCharacter, false);
		}

		// Token: 0x0602E663 RID: 190051 RVA: 0x0065514F File Offset: 0x0065334F
		public static Offset<ICharacterGroupNew> EndICharacterGroupNew(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterGroupNew>(builder.EndTable());
		}

		// Token: 0x0602E664 RID: 190052 RVA: 0x0065515C File Offset: 0x0065335C
		public ICharacterGroupNewT UnPack()
		{
			ICharacterGroupNewT characterGroupNewT = new ICharacterGroupNewT();
			this.UnPackTo(characterGroupNewT);
			return characterGroupNewT;
		}

		// Token: 0x0602E665 RID: 190053 RVA: 0x00655177 File Offset: 0x00653377
		public void UnPackTo(ICharacterGroupNewT _o)
		{
			_o.CharacterId = this.CharacterId;
			_o.IsAiCharacter = this.IsAiCharacter;
		}

		// Token: 0x0602E666 RID: 190054 RVA: 0x00655194 File Offset: 0x00653394
		public static Offset<ICharacterGroupNew> Pack(FlatBufferBuilder builder, ICharacterGroupNewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterGroupNew>);
			}
			return ICharacterGroupNew.CreateICharacterGroupNew(builder, _o.CharacterId, _o.IsAiCharacter);
		}

		// Token: 0x04011713 RID: 71443
		private Table __p;
	}
}
