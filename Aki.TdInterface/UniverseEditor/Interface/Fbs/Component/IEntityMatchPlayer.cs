using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005703 RID: 22275
	public struct IEntityMatchPlayer : IFlatbufferObject
	{
		// Token: 0x1700A092 RID: 41106
		// (get) Token: 0x06023C27 RID: 146471 RVA: 0x004EA600 File Offset: 0x004E8800
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023C28 RID: 146472 RVA: 0x004EA60D File Offset: 0x004E880D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023C29 RID: 146473 RVA: 0x004EA614 File Offset: 0x004E8814
		public static IEntityMatchPlayer GetRootAsIEntityMatchPlayer(ByteBuffer _bb)
		{
			return IEntityMatchPlayer.GetRootAsIEntityMatchPlayer(_bb, default(IEntityMatchPlayer));
		}

		// Token: 0x06023C2A RID: 146474 RVA: 0x004EA630 File Offset: 0x004E8830
		public static IEntityMatchPlayer GetRootAsIEntityMatchPlayer(ByteBuffer _bb, IEntityMatchPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023C2B RID: 146475 RVA: 0x004EA64D File Offset: 0x004E884D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023C2C RID: 146476 RVA: 0x004EA65C File Offset: 0x004E885C
		public IEntityMatchPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A093 RID: 41107
		// (get) Token: 0x06023C2D RID: 146477 RVA: 0x004EA66C File Offset: 0x004E886C
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

		// Token: 0x06023C2E RID: 146478 RVA: 0x004EA6A8 File Offset: 0x004E88A8
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A094 RID: 41108
		// (get) Token: 0x06023C2F RID: 146479 RVA: 0x004EA6E8 File Offset: 0x004E88E8
		public int MatchRoleOptionTypeLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023C30 RID: 146480 RVA: 0x004EA713 File Offset: 0x004E8913
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(6, 1);
		}

		// Token: 0x06023C31 RID: 146481 RVA: 0x004EA724 File Offset: 0x004E8924
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMatchRoleOption[] array = new TMatchRoleOption[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMatchRoleOption)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06023C32 RID: 146482 RVA: 0x004EA790 File Offset: 0x004E8990
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A095 RID: 41109
		// (get) Token: 0x06023C33 RID: 146483 RVA: 0x004EA7D8 File Offset: 0x004E89D8
		public int MatchRoleOptionLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A096 RID: 41110
		// (get) Token: 0x06023C34 RID: 146484 RVA: 0x004EA804 File Offset: 0x004E8A04
		public bool ChangeRoleTrigger
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A097 RID: 41111
		// (get) Token: 0x06023C35 RID: 146485 RVA: 0x004EA844 File Offset: 0x004E8A44
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023C36 RID: 146486 RVA: 0x004EA881 File Offset: 0x004E8A81
		public static Offset<IEntityMatchPlayer> CreateIEntityMatchPlayer(FlatBufferBuilder builder, EEntityMatchType Type = EEntityMatchType.Player, VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), bool ChangeRoleTrigger = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityMatchPlayer.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			IEntityMatchPlayer.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			IEntityMatchPlayer.AddNullMask(builder, NullMask);
			IEntityMatchPlayer.AddChangeRoleTrigger(builder, ChangeRoleTrigger);
			IEntityMatchPlayer.AddType(builder, Type);
			return IEntityMatchPlayer.EndIEntityMatchPlayer(builder);
		}

		// Token: 0x06023C37 RID: 146487 RVA: 0x004EA8B5 File Offset: 0x004E8AB5
		public static void StartIEntityMatchPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023C38 RID: 146488 RVA: 0x004EA8BE File Offset: 0x004E8ABE
		public static void AddType(FlatBufferBuilder builder, EEntityMatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023C39 RID: 146489 RVA: 0x004EA8C9 File Offset: 0x004E8AC9
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(1, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06023C3A RID: 146490 RVA: 0x004EA8DC File Offset: 0x004E8ADC
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023C3B RID: 146491 RVA: 0x004EA913 File Offset: 0x004E8B13
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06023C3C RID: 146492 RVA: 0x004EA92D File Offset: 0x004E8B2D
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06023C3D RID: 146493 RVA: 0x004EA94B File Offset: 0x004E8B4B
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023C3E RID: 146494 RVA: 0x004EA964 File Offset: 0x004E8B64
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06023C3F RID: 146495 RVA: 0x004EA96F File Offset: 0x004E8B6F
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(2, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x06023C40 RID: 146496 RVA: 0x004EA980 File Offset: 0x004E8B80
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023C41 RID: 146497 RVA: 0x004EA9B7 File Offset: 0x004E8BB7
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023C42 RID: 146498 RVA: 0x004EA9D1 File Offset: 0x004E8BD1
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023C43 RID: 146499 RVA: 0x004EA9EF File Offset: 0x004E8BEF
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023C44 RID: 146500 RVA: 0x004EAA08 File Offset: 0x004E8C08
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023C45 RID: 146501 RVA: 0x004EAA13 File Offset: 0x004E8C13
		public static void AddChangeRoleTrigger(FlatBufferBuilder builder, bool changeRoleTrigger)
		{
			builder.AddBool(3, changeRoleTrigger, false);
		}

		// Token: 0x06023C46 RID: 146502 RVA: 0x004EAA1E File Offset: 0x004E8C1E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06023C47 RID: 146503 RVA: 0x004EAA29 File Offset: 0x004E8C29
		public static Offset<IEntityMatchPlayer> EndIEntityMatchPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatchPlayer>(builder.EndTable());
		}

		// Token: 0x06023C48 RID: 146504 RVA: 0x004EAA38 File Offset: 0x004E8C38
		public IEntityMatchPlayerT UnPack()
		{
			IEntityMatchPlayerT entityMatchPlayerT = new IEntityMatchPlayerT();
			this.UnPackTo(entityMatchPlayerT);
			return entityMatchPlayerT;
		}

		// Token: 0x06023C49 RID: 146505 RVA: 0x004EAA54 File Offset: 0x004E8C54
		public void UnPackTo(IEntityMatchPlayerT _o)
		{
			_o.Type = this.Type;
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int i = 0; i < this.MatchRoleOptionLength; i++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(i);
				switch (this.MatchRoleOptionType(i))
				{
				case TMatchRoleOption.IMatchAssistCharacterRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchAssistCharacterRole>(i) != null) ? this.MatchRoleOption<IMatchAssistCharacterRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPhantomRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPlayerRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					break;
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.ChangeRoleTrigger = this.ChangeRoleTrigger;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023C4A RID: 146506 RVA: 0x004EAB88 File Offset: 0x004E8D88
		public static Offset<IEntityMatchPlayer> Pack(FlatBufferBuilder builder, IEntityMatchPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityMatchPlayer>);
			}
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.MatchRoleOption[i].Type;
				}
				matchRoleOption_typeOffset = IEntityMatchPlayer.CreateMatchRoleOptionTypeVector(builder, array);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array2 = new int[_o.MatchRoleOption.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[j]);
				}
				matchRoleOptionOffset = IEntityMatchPlayer.CreateMatchRoleOptionVector(builder, array2);
			}
			return IEntityMatchPlayer.CreateIEntityMatchPlayer(builder, _o.Type, matchRoleOption_typeOffset, matchRoleOptionOffset, _o.ChangeRoleTrigger, _o.NullMask);
		}

		// Token: 0x0400EE78 RID: 61048
		private Table __p;
	}
}
