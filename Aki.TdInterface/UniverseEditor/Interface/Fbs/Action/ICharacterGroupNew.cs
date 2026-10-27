using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006337 RID: 25399
	public struct ICharacterGroupNew : IFlatbufferObject
	{
		// Token: 0x1700BD8E RID: 48526
		// (get) Token: 0x0602BEED RID: 179949 RVA: 0x00609ED6 File Offset: 0x006080D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BEEE RID: 179950 RVA: 0x00609EE3 File Offset: 0x006080E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BEEF RID: 179951 RVA: 0x00609EEC File Offset: 0x006080EC
		public static ICharacterGroupNew GetRootAsICharacterGroupNew(ByteBuffer _bb)
		{
			return ICharacterGroupNew.GetRootAsICharacterGroupNew(_bb, default(ICharacterGroupNew));
		}

		// Token: 0x0602BEF0 RID: 179952 RVA: 0x00609F08 File Offset: 0x00608108
		public static ICharacterGroupNew GetRootAsICharacterGroupNew(ByteBuffer _bb, ICharacterGroupNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BEF1 RID: 179953 RVA: 0x00609F25 File Offset: 0x00608125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BEF2 RID: 179954 RVA: 0x00609F34 File Offset: 0x00608134
		public ICharacterGroupNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD8F RID: 48527
		// (get) Token: 0x0602BEF3 RID: 179955 RVA: 0x00609F44 File Offset: 0x00608144
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

		// Token: 0x1700BD90 RID: 48528
		// (get) Token: 0x0602BEF4 RID: 179956 RVA: 0x00609F80 File Offset: 0x00608180
		public bool IsAiCharacter
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602BEF5 RID: 179957 RVA: 0x00609FBF File Offset: 0x006081BF
		public static Offset<ICharacterGroupNew> CreateICharacterGroupNew(FlatBufferBuilder builder, int CharacterId = 0, bool IsAiCharacter = false)
		{
			builder.StartTable(2);
			ICharacterGroupNew.AddCharacterId(builder, CharacterId);
			ICharacterGroupNew.AddIsAiCharacter(builder, IsAiCharacter);
			return ICharacterGroupNew.EndICharacterGroupNew(builder);
		}

		// Token: 0x0602BEF6 RID: 179958 RVA: 0x00609FDC File Offset: 0x006081DC
		public static void StartICharacterGroupNew(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BEF7 RID: 179959 RVA: 0x00609FE5 File Offset: 0x006081E5
		public static void AddCharacterId(FlatBufferBuilder builder, int characterId)
		{
			builder.AddInt(0, characterId, 0);
		}

		// Token: 0x0602BEF8 RID: 179960 RVA: 0x00609FF0 File Offset: 0x006081F0
		public static void AddIsAiCharacter(FlatBufferBuilder builder, bool isAiCharacter)
		{
			builder.AddBool(1, isAiCharacter, false);
		}

		// Token: 0x0602BEF9 RID: 179961 RVA: 0x00609FFB File Offset: 0x006081FB
		public static Offset<ICharacterGroupNew> EndICharacterGroupNew(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterGroupNew>(builder.EndTable());
		}

		// Token: 0x0602BEFA RID: 179962 RVA: 0x0060A008 File Offset: 0x00608208
		public ICharacterGroupNewT UnPack()
		{
			ICharacterGroupNewT characterGroupNewT = new ICharacterGroupNewT();
			this.UnPackTo(characterGroupNewT);
			return characterGroupNewT;
		}

		// Token: 0x0602BEFB RID: 179963 RVA: 0x0060A023 File Offset: 0x00608223
		public void UnPackTo(ICharacterGroupNewT _o)
		{
			_o.CharacterId = this.CharacterId;
			_o.IsAiCharacter = this.IsAiCharacter;
		}

		// Token: 0x0602BEFC RID: 179964 RVA: 0x0060A040 File Offset: 0x00608240
		public static Offset<ICharacterGroupNew> Pack(FlatBufferBuilder builder, ICharacterGroupNewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterGroupNew>);
			}
			return ICharacterGroupNew.CreateICharacterGroupNew(builder, _o.CharacterId, _o.IsAiCharacter);
		}

		// Token: 0x040108FE RID: 67838
		private Table __p;
	}
}
