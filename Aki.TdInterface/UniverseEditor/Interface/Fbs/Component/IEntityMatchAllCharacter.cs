using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F7 RID: 22263
	public struct IEntityMatchAllCharacter : IFlatbufferObject
	{
		// Token: 0x1700A085 RID: 41093
		// (get) Token: 0x06023BD5 RID: 146389 RVA: 0x004E9D9A File Offset: 0x004E7F9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023BD6 RID: 146390 RVA: 0x004E9DA7 File Offset: 0x004E7FA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023BD7 RID: 146391 RVA: 0x004E9DB0 File Offset: 0x004E7FB0
		public static IEntityMatchAllCharacter GetRootAsIEntityMatchAllCharacter(ByteBuffer _bb)
		{
			return IEntityMatchAllCharacter.GetRootAsIEntityMatchAllCharacter(_bb, default(IEntityMatchAllCharacter));
		}

		// Token: 0x06023BD8 RID: 146392 RVA: 0x004E9DCC File Offset: 0x004E7FCC
		public static IEntityMatchAllCharacter GetRootAsIEntityMatchAllCharacter(ByteBuffer _bb, IEntityMatchAllCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023BD9 RID: 146393 RVA: 0x004E9DE9 File Offset: 0x004E7FE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023BDA RID: 146394 RVA: 0x004E9DF8 File Offset: 0x004E7FF8
		public IEntityMatchAllCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A086 RID: 41094
		// (get) Token: 0x06023BDB RID: 146395 RVA: 0x004E9E08 File Offset: 0x004E8008
		public EEntityMatchType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityMatchType.Player;
				}
				return (EEntityMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023BDC RID: 146396 RVA: 0x004E9E44 File Offset: 0x004E8044
		public static Offset<IEntityMatchAllCharacter> CreateIEntityMatchAllCharacter(FlatBufferBuilder builder, EEntityMatchType Type = EEntityMatchType.Player)
		{
			builder.StartTable(1);
			IEntityMatchAllCharacter.AddType(builder, Type);
			return IEntityMatchAllCharacter.EndIEntityMatchAllCharacter(builder);
		}

		// Token: 0x06023BDD RID: 146397 RVA: 0x004E9E5A File Offset: 0x004E805A
		public static void StartIEntityMatchAllCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023BDE RID: 146398 RVA: 0x004E9E63 File Offset: 0x004E8063
		public static void AddType(FlatBufferBuilder builder, EEntityMatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023BDF RID: 146399 RVA: 0x004E9E6E File Offset: 0x004E806E
		public static Offset<IEntityMatchAllCharacter> EndIEntityMatchAllCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatchAllCharacter>(builder.EndTable());
		}

		// Token: 0x06023BE0 RID: 146400 RVA: 0x004E9E7C File Offset: 0x004E807C
		public IEntityMatchAllCharacterT UnPack()
		{
			IEntityMatchAllCharacterT entityMatchAllCharacterT = new IEntityMatchAllCharacterT();
			this.UnPackTo(entityMatchAllCharacterT);
			return entityMatchAllCharacterT;
		}

		// Token: 0x06023BE1 RID: 146401 RVA: 0x004E9E97 File Offset: 0x004E8097
		public void UnPackTo(IEntityMatchAllCharacterT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023BE2 RID: 146402 RVA: 0x004E9EA8 File Offset: 0x004E80A8
		public static Offset<IEntityMatchAllCharacter> Pack(FlatBufferBuilder builder, IEntityMatchAllCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityMatchAllCharacter>);
			}
			return IEntityMatchAllCharacter.CreateIEntityMatchAllCharacter(builder, _o.Type);
		}

		// Token: 0x0400EE68 RID: 61032
		private Table __p;
	}
}
