using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005700 RID: 22272
	public struct IEntityMatchDynamic : IFlatbufferObject
	{
		// Token: 0x1700A08D RID: 41101
		// (get) Token: 0x06023C0B RID: 146443 RVA: 0x004EA254 File Offset: 0x004E8454
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023C0C RID: 146444 RVA: 0x004EA261 File Offset: 0x004E8461
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023C0D RID: 146445 RVA: 0x004EA268 File Offset: 0x004E8468
		public static IEntityMatchDynamic GetRootAsIEntityMatchDynamic(ByteBuffer _bb)
		{
			return IEntityMatchDynamic.GetRootAsIEntityMatchDynamic(_bb, default(IEntityMatchDynamic));
		}

		// Token: 0x06023C0E RID: 146446 RVA: 0x004EA284 File Offset: 0x004E8484
		public static IEntityMatchDynamic GetRootAsIEntityMatchDynamic(ByteBuffer _bb, IEntityMatchDynamic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023C0F RID: 146447 RVA: 0x004EA2A1 File Offset: 0x004E84A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023C10 RID: 146448 RVA: 0x004EA2B0 File Offset: 0x004E84B0
		public IEntityMatchDynamic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A08E RID: 41102
		// (get) Token: 0x06023C11 RID: 146449 RVA: 0x004EA2C0 File Offset: 0x004E84C0
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

		// Token: 0x06023C12 RID: 146450 RVA: 0x004EA2FC File Offset: 0x004E84FC
		public IDynamicEntityMatch? MatchEntity(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A08F RID: 41103
		// (get) Token: 0x06023C13 RID: 146451 RVA: 0x004EA35C File Offset: 0x004E855C
		public int MatchEntityLength
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

		// Token: 0x06023C14 RID: 146452 RVA: 0x004EA387 File Offset: 0x004E8587
		public static Offset<IEntityMatchDynamic> CreateIEntityMatchDynamic(FlatBufferBuilder builder, EEntityMatchType Type = EEntityMatchType.Player, VectorOffset MatchEntityOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityMatchDynamic.AddMatchEntity(builder, MatchEntityOffset);
			IEntityMatchDynamic.AddType(builder, Type);
			return IEntityMatchDynamic.EndIEntityMatchDynamic(builder);
		}

		// Token: 0x06023C15 RID: 146453 RVA: 0x004EA3A4 File Offset: 0x004E85A4
		public static void StartIEntityMatchDynamic(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023C16 RID: 146454 RVA: 0x004EA3AD File Offset: 0x004E85AD
		public static void AddType(FlatBufferBuilder builder, EEntityMatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023C17 RID: 146455 RVA: 0x004EA3B8 File Offset: 0x004E85B8
		public static void AddMatchEntity(FlatBufferBuilder builder, VectorOffset matchEntityOffset)
		{
			builder.AddOffset(1, matchEntityOffset.Value, 0);
		}

		// Token: 0x06023C18 RID: 146456 RVA: 0x004EA3C8 File Offset: 0x004E85C8
		public static VectorOffset CreateMatchEntityVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023C19 RID: 146457 RVA: 0x004EA408 File Offset: 0x004E8608
		public static VectorOffset CreateMatchEntityVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023C1A RID: 146458 RVA: 0x004EA422 File Offset: 0x004E8622
		public static VectorOffset CreateMatchEntityVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023C1B RID: 146459 RVA: 0x004EA440 File Offset: 0x004E8640
		public static VectorOffset CreateMatchEntityVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023C1C RID: 146460 RVA: 0x004EA459 File Offset: 0x004E8659
		public static void StartMatchEntityVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023C1D RID: 146461 RVA: 0x004EA464 File Offset: 0x004E8664
		public static Offset<IEntityMatchDynamic> EndIEntityMatchDynamic(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatchDynamic>(builder.EndTable());
		}

		// Token: 0x06023C1E RID: 146462 RVA: 0x004EA474 File Offset: 0x004E8674
		public IEntityMatchDynamicT UnPack()
		{
			IEntityMatchDynamicT entityMatchDynamicT = new IEntityMatchDynamicT();
			this.UnPackTo(entityMatchDynamicT);
			return entityMatchDynamicT;
		}

		// Token: 0x06023C1F RID: 146463 RVA: 0x004EA490 File Offset: 0x004E8690
		public void UnPackTo(IEntityMatchDynamicT _o)
		{
			_o.Type = this.Type;
			_o.MatchEntity = new List<IDynamicEntityMatchT>();
			for (int i = 0; i < this.MatchEntityLength; i++)
			{
				_o.MatchEntity.Add((this.MatchEntity(i) != null) ? this.MatchEntity(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06023C20 RID: 146464 RVA: 0x004EA4FC File Offset: 0x004E86FC
		public static Offset<IEntityMatchDynamic> Pack(FlatBufferBuilder builder, IEntityMatchDynamicT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityMatchDynamic>);
			}
			VectorOffset matchEntityOffset = default(VectorOffset);
			if (_o.MatchEntity != null)
			{
				Offset<IDynamicEntityMatch>[] array = new Offset<IDynamicEntityMatch>[_o.MatchEntity.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDynamicEntityMatch.Pack(builder, _o.MatchEntity[i]);
				}
				matchEntityOffset = IEntityMatchDynamic.CreateMatchEntityVector(builder, array);
			}
			return IEntityMatchDynamic.CreateIEntityMatchDynamic(builder, _o.Type, matchEntityOffset);
		}

		// Token: 0x0400EE75 RID: 61045
		private Table __p;
	}
}
