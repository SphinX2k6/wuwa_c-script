using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200519E RID: 20894
	public struct IEntityMatchPlayer : IFlatbufferObject
	{
		// Token: 0x170098A3 RID: 39075
		// (get) Token: 0x06021CCF RID: 138447 RVA: 0x004B05E0 File Offset: 0x004AE7E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021CD0 RID: 138448 RVA: 0x004B05ED File Offset: 0x004AE7ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021CD1 RID: 138449 RVA: 0x004B05F4 File Offset: 0x004AE7F4
		public static IEntityMatchPlayer GetRootAsIEntityMatchPlayer(ByteBuffer _bb)
		{
			return IEntityMatchPlayer.GetRootAsIEntityMatchPlayer(_bb, default(IEntityMatchPlayer));
		}

		// Token: 0x06021CD2 RID: 138450 RVA: 0x004B0610 File Offset: 0x004AE810
		public static IEntityMatchPlayer GetRootAsIEntityMatchPlayer(ByteBuffer _bb, IEntityMatchPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021CD3 RID: 138451 RVA: 0x004B062D File Offset: 0x004AE82D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021CD4 RID: 138452 RVA: 0x004B063C File Offset: 0x004AE83C
		public IEntityMatchPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098A4 RID: 39076
		// (get) Token: 0x06021CD5 RID: 138453 RVA: 0x004B064C File Offset: 0x004AE84C
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

		// Token: 0x06021CD6 RID: 138454 RVA: 0x004B0688 File Offset: 0x004AE888
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170098A5 RID: 39077
		// (get) Token: 0x06021CD7 RID: 138455 RVA: 0x004B06C8 File Offset: 0x004AE8C8
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

		// Token: 0x06021CD8 RID: 138456 RVA: 0x004B06F3 File Offset: 0x004AE8F3
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(6, 1);
		}

		// Token: 0x06021CD9 RID: 138457 RVA: 0x004B0704 File Offset: 0x004AE904
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

		// Token: 0x06021CDA RID: 138458 RVA: 0x004B0770 File Offset: 0x004AE970
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170098A6 RID: 39078
		// (get) Token: 0x06021CDB RID: 138459 RVA: 0x004B07B8 File Offset: 0x004AE9B8
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

		// Token: 0x170098A7 RID: 39079
		// (get) Token: 0x06021CDC RID: 138460 RVA: 0x004B07E4 File Offset: 0x004AE9E4
		public bool ChangeRoleTrigger
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098A8 RID: 39080
		// (get) Token: 0x06021CDD RID: 138461 RVA: 0x004B0824 File Offset: 0x004AEA24
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

		// Token: 0x06021CDE RID: 138462 RVA: 0x004B0861 File Offset: 0x004AEA61
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

		// Token: 0x06021CDF RID: 138463 RVA: 0x004B0895 File Offset: 0x004AEA95
		public static void StartIEntityMatchPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021CE0 RID: 138464 RVA: 0x004B089E File Offset: 0x004AEA9E
		public static void AddType(FlatBufferBuilder builder, EEntityMatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021CE1 RID: 138465 RVA: 0x004B08A9 File Offset: 0x004AEAA9
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(1, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06021CE2 RID: 138466 RVA: 0x004B08BC File Offset: 0x004AEABC
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021CE3 RID: 138467 RVA: 0x004B08F3 File Offset: 0x004AEAF3
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06021CE4 RID: 138468 RVA: 0x004B090D File Offset: 0x004AEB0D
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06021CE5 RID: 138469 RVA: 0x004B092B File Offset: 0x004AEB2B
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021CE6 RID: 138470 RVA: 0x004B0944 File Offset: 0x004AEB44
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06021CE7 RID: 138471 RVA: 0x004B094F File Offset: 0x004AEB4F
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(2, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x06021CE8 RID: 138472 RVA: 0x004B0960 File Offset: 0x004AEB60
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021CE9 RID: 138473 RVA: 0x004B0997 File Offset: 0x004AEB97
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021CEA RID: 138474 RVA: 0x004B09B1 File Offset: 0x004AEBB1
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021CEB RID: 138475 RVA: 0x004B09CF File Offset: 0x004AEBCF
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021CEC RID: 138476 RVA: 0x004B09E8 File Offset: 0x004AEBE8
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021CED RID: 138477 RVA: 0x004B09F3 File Offset: 0x004AEBF3
		public static void AddChangeRoleTrigger(FlatBufferBuilder builder, bool changeRoleTrigger)
		{
			builder.AddBool(3, changeRoleTrigger, false);
		}

		// Token: 0x06021CEE RID: 138478 RVA: 0x004B09FE File Offset: 0x004AEBFE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021CEF RID: 138479 RVA: 0x004B0A09 File Offset: 0x004AEC09
		public static Offset<IEntityMatchPlayer> EndIEntityMatchPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatchPlayer>(builder.EndTable());
		}

		// Token: 0x06021CF0 RID: 138480 RVA: 0x004B0A18 File Offset: 0x004AEC18
		public IEntityMatchPlayerT UnPack()
		{
			IEntityMatchPlayerT entityMatchPlayerT = new IEntityMatchPlayerT();
			this.UnPackTo(entityMatchPlayerT);
			return entityMatchPlayerT;
		}

		// Token: 0x06021CF1 RID: 138481 RVA: 0x004B0A34 File Offset: 0x004AEC34
		public void UnPackTo(IEntityMatchPlayerT _o)
		{
			_o.Type = this.Type;
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int i = 0; i < this.MatchRoleOptionLength; i++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(i);
				TMatchRoleOption tmatchRoleOption = this.MatchRoleOptionType(i);
				if (tmatchRoleOption != TMatchRoleOption.IMatchPhantomRole)
				{
					if (tmatchRoleOption == TMatchRoleOption.IMatchPlayerRole)
					{
						tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.ChangeRoleTrigger = this.ChangeRoleTrigger;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021CF2 RID: 138482 RVA: 0x004B0B20 File Offset: 0x004AED20
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

		// Token: 0x0400E27A RID: 57978
		private Table __p;
	}
}
