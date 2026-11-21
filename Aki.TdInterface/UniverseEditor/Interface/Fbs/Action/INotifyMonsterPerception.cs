using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F8 RID: 29432
	public struct INotifyMonsterPerception : IFlatbufferObject
	{
		// Token: 0x1700D7C9 RID: 55241
		// (get) Token: 0x0603351D RID: 210205 RVA: 0x006EBDC1 File Offset: 0x006E9FC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603351E RID: 210206 RVA: 0x006EBDCE File Offset: 0x006E9FCE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603351F RID: 210207 RVA: 0x006EBDD8 File Offset: 0x006E9FD8
		public static INotifyMonsterPerception GetRootAsINotifyMonsterPerception(ByteBuffer _bb)
		{
			return INotifyMonsterPerception.GetRootAsINotifyMonsterPerception(_bb, default(INotifyMonsterPerception));
		}

		// Token: 0x06033520 RID: 210208 RVA: 0x006EBDF4 File Offset: 0x006E9FF4
		public static INotifyMonsterPerception GetRootAsINotifyMonsterPerception(ByteBuffer _bb, INotifyMonsterPerception obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033521 RID: 210209 RVA: 0x006EBE11 File Offset: 0x006EA011
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033522 RID: 210210 RVA: 0x006EBE20 File Offset: 0x006EA020
		public INotifyMonsterPerception __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7CA RID: 55242
		// (get) Token: 0x06033523 RID: 210211 RVA: 0x006EBE30 File Offset: 0x006EA030
		public ESetBattleStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return (ESetBattleStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033524 RID: 210212 RVA: 0x006EBE6C File Offset: 0x006EA06C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D7CB RID: 55243
		// (get) Token: 0x06033525 RID: 210213 RVA: 0x006EBEAC File Offset: 0x006EA0AC
		public int EntityIdsLength
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

		// Token: 0x06033526 RID: 210214 RVA: 0x006EBED7 File Offset: 0x006EA0D7
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06033527 RID: 210215 RVA: 0x006EBEE6 File Offset: 0x006EA0E6
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D7CC RID: 55244
		// (get) Token: 0x06033528 RID: 210216 RVA: 0x006EBEF4 File Offset: 0x006EA0F4
		public TBattleStatePerceptionBehavior PerceptionBehaviorOptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TBattleStatePerceptionBehavior.NONE;
				}
				return (TBattleStatePerceptionBehavior)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033529 RID: 210217 RVA: 0x006EBF30 File Offset: 0x006EA130
		public TTable? PerceptionBehaviorOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603352A RID: 210218 RVA: 0x006EBF78 File Offset: 0x006EA178
		public IPerceptionNotifyGatherToEntity PerceptionBehaviorOptionAsIPerceptionNotifyGatherToEntity()
		{
			return this.PerceptionBehaviorOption<IPerceptionNotifyGatherToEntity>().Value;
		}

		// Token: 0x0603352B RID: 210219 RVA: 0x006EBF94 File Offset: 0x006EA194
		public IPerceptionNotifyGatherToPlayer PerceptionBehaviorOptionAsIPerceptionNotifyGatherToPlayer()
		{
			return this.PerceptionBehaviorOption<IPerceptionNotifyGatherToPlayer>().Value;
		}

		// Token: 0x0603352C RID: 210220 RVA: 0x006EBFAF File Offset: 0x006EA1AF
		public static Offset<INotifyMonsterPerception> CreateINotifyMonsterPerception(FlatBufferBuilder builder, ESetBattleStateType Type = ESetBattleStateType.SetBattleTag, VectorOffset EntityIdsOffset = default(VectorOffset), TBattleStatePerceptionBehavior PerceptionBehaviorOption_type = TBattleStatePerceptionBehavior.NONE, int PerceptionBehaviorOptionOffset = 0)
		{
			builder.StartTable(4);
			INotifyMonsterPerception.AddPerceptionBehaviorOption(builder, PerceptionBehaviorOptionOffset);
			INotifyMonsterPerception.AddEntityIds(builder, EntityIdsOffset);
			INotifyMonsterPerception.AddPerceptionBehaviorOptionType(builder, PerceptionBehaviorOption_type);
			INotifyMonsterPerception.AddType(builder, Type);
			return INotifyMonsterPerception.EndINotifyMonsterPerception(builder);
		}

		// Token: 0x0603352D RID: 210221 RVA: 0x006EBFDB File Offset: 0x006EA1DB
		public static void StartINotifyMonsterPerception(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603352E RID: 210222 RVA: 0x006EBFE4 File Offset: 0x006EA1E4
		public static void AddType(FlatBufferBuilder builder, ESetBattleStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603352F RID: 210223 RVA: 0x006EBFEF File Offset: 0x006EA1EF
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06033530 RID: 210224 RVA: 0x006EC000 File Offset: 0x006EA200
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033531 RID: 210225 RVA: 0x006EC037 File Offset: 0x006EA237
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033532 RID: 210226 RVA: 0x006EC051 File Offset: 0x006EA251
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033533 RID: 210227 RVA: 0x006EC06F File Offset: 0x006EA26F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033534 RID: 210228 RVA: 0x006EC088 File Offset: 0x006EA288
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033535 RID: 210229 RVA: 0x006EC093 File Offset: 0x006EA293
		public static void AddPerceptionBehaviorOptionType(FlatBufferBuilder builder, TBattleStatePerceptionBehavior perceptionBehaviorOptionType)
		{
			builder.AddByte(2, (byte)perceptionBehaviorOptionType, 0);
		}

		// Token: 0x06033536 RID: 210230 RVA: 0x006EC09E File Offset: 0x006EA29E
		public static void AddPerceptionBehaviorOption(FlatBufferBuilder builder, int perceptionBehaviorOptionOffset)
		{
			builder.AddOffset(3, perceptionBehaviorOptionOffset, 0);
		}

		// Token: 0x06033537 RID: 210231 RVA: 0x006EC0A9 File Offset: 0x006EA2A9
		public static Offset<INotifyMonsterPerception> EndINotifyMonsterPerception(FlatBufferBuilder builder)
		{
			return new Offset<INotifyMonsterPerception>(builder.EndTable());
		}

		// Token: 0x06033538 RID: 210232 RVA: 0x006EC0B8 File Offset: 0x006EA2B8
		public INotifyMonsterPerceptionT UnPack()
		{
			INotifyMonsterPerceptionT notifyMonsterPerceptionT = new INotifyMonsterPerceptionT();
			this.UnPackTo(notifyMonsterPerceptionT);
			return notifyMonsterPerceptionT;
		}

		// Token: 0x06033539 RID: 210233 RVA: 0x006EC0D4 File Offset: 0x006EA2D4
		public void UnPackTo(INotifyMonsterPerceptionT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.PerceptionBehaviorOption = new TBattleStatePerceptionBehaviorUnion();
			_o.PerceptionBehaviorOption.Type = this.PerceptionBehaviorOptionType;
			TBattleStatePerceptionBehavior perceptionBehaviorOptionType = this.PerceptionBehaviorOptionType;
			if (perceptionBehaviorOptionType == TBattleStatePerceptionBehavior.IPerceptionNotifyGatherToEntity)
			{
				_o.PerceptionBehaviorOption.Value = ((this.PerceptionBehaviorOption<IPerceptionNotifyGatherToEntity>() != null) ? this.PerceptionBehaviorOption<IPerceptionNotifyGatherToEntity>().Value.UnPack() : null);
				return;
			}
			if (perceptionBehaviorOptionType != TBattleStatePerceptionBehavior.IPerceptionNotifyGatherToPlayer)
			{
				return;
			}
			_o.PerceptionBehaviorOption.Value = ((this.PerceptionBehaviorOption<IPerceptionNotifyGatherToPlayer>() != null) ? this.PerceptionBehaviorOption<IPerceptionNotifyGatherToPlayer>().Value.UnPack() : null);
		}

		// Token: 0x0603353A RID: 210234 RVA: 0x006EC1B4 File Offset: 0x006EA3B4
		public static Offset<INotifyMonsterPerception> Pack(FlatBufferBuilder builder, INotifyMonsterPerceptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<INotifyMonsterPerception>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = INotifyMonsterPerception.CreateEntityIdsVector(builder, data);
			}
			TBattleStatePerceptionBehavior perceptionBehaviorOption_type = (_o.PerceptionBehaviorOption == null) ? TBattleStatePerceptionBehavior.NONE : _o.PerceptionBehaviorOption.Type;
			int perceptionBehaviorOptionOffset = (_o.PerceptionBehaviorOption == null) ? 0 : TBattleStatePerceptionBehaviorUnion.Pack(builder, _o.PerceptionBehaviorOption);
			return INotifyMonsterPerception.CreateINotifyMonsterPerception(builder, _o.Type, entityIdsOffset, perceptionBehaviorOption_type, perceptionBehaviorOptionOffset);
		}

		// Token: 0x040123B0 RID: 74672
		private Table __p;
	}
}
