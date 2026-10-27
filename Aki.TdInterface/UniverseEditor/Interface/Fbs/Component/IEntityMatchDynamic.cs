using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200519B RID: 20891
	public struct IEntityMatchDynamic : IFlatbufferObject
	{
		// Token: 0x1700989E RID: 39070
		// (get) Token: 0x06021CB3 RID: 138419 RVA: 0x004B0234 File Offset: 0x004AE434
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021CB4 RID: 138420 RVA: 0x004B0241 File Offset: 0x004AE441
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021CB5 RID: 138421 RVA: 0x004B0248 File Offset: 0x004AE448
		public static IEntityMatchDynamic GetRootAsIEntityMatchDynamic(ByteBuffer _bb)
		{
			return IEntityMatchDynamic.GetRootAsIEntityMatchDynamic(_bb, default(IEntityMatchDynamic));
		}

		// Token: 0x06021CB6 RID: 138422 RVA: 0x004B0264 File Offset: 0x004AE464
		public static IEntityMatchDynamic GetRootAsIEntityMatchDynamic(ByteBuffer _bb, IEntityMatchDynamic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021CB7 RID: 138423 RVA: 0x004B0281 File Offset: 0x004AE481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021CB8 RID: 138424 RVA: 0x004B0290 File Offset: 0x004AE490
		public IEntityMatchDynamic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700989F RID: 39071
		// (get) Token: 0x06021CB9 RID: 138425 RVA: 0x004B02A0 File Offset: 0x004AE4A0
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

		// Token: 0x06021CBA RID: 138426 RVA: 0x004B02DC File Offset: 0x004AE4DC
		public IDynamicEntityMatch? MatchEntity(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170098A0 RID: 39072
		// (get) Token: 0x06021CBB RID: 138427 RVA: 0x004B033C File Offset: 0x004AE53C
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

		// Token: 0x06021CBC RID: 138428 RVA: 0x004B0367 File Offset: 0x004AE567
		public static Offset<IEntityMatchDynamic> CreateIEntityMatchDynamic(FlatBufferBuilder builder, EEntityMatchType Type = EEntityMatchType.Player, VectorOffset MatchEntityOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityMatchDynamic.AddMatchEntity(builder, MatchEntityOffset);
			IEntityMatchDynamic.AddType(builder, Type);
			return IEntityMatchDynamic.EndIEntityMatchDynamic(builder);
		}

		// Token: 0x06021CBD RID: 138429 RVA: 0x004B0384 File Offset: 0x004AE584
		public static void StartIEntityMatchDynamic(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021CBE RID: 138430 RVA: 0x004B038D File Offset: 0x004AE58D
		public static void AddType(FlatBufferBuilder builder, EEntityMatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021CBF RID: 138431 RVA: 0x004B0398 File Offset: 0x004AE598
		public static void AddMatchEntity(FlatBufferBuilder builder, VectorOffset matchEntityOffset)
		{
			builder.AddOffset(1, matchEntityOffset.Value, 0);
		}

		// Token: 0x06021CC0 RID: 138432 RVA: 0x004B03A8 File Offset: 0x004AE5A8
		public static VectorOffset CreateMatchEntityVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021CC1 RID: 138433 RVA: 0x004B03E8 File Offset: 0x004AE5E8
		public static VectorOffset CreateMatchEntityVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021CC2 RID: 138434 RVA: 0x004B0402 File Offset: 0x004AE602
		public static VectorOffset CreateMatchEntityVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021CC3 RID: 138435 RVA: 0x004B0420 File Offset: 0x004AE620
		public static VectorOffset CreateMatchEntityVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021CC4 RID: 138436 RVA: 0x004B0439 File Offset: 0x004AE639
		public static void StartMatchEntityVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021CC5 RID: 138437 RVA: 0x004B0444 File Offset: 0x004AE644
		public static Offset<IEntityMatchDynamic> EndIEntityMatchDynamic(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatchDynamic>(builder.EndTable());
		}

		// Token: 0x06021CC6 RID: 138438 RVA: 0x004B0454 File Offset: 0x004AE654
		public IEntityMatchDynamicT UnPack()
		{
			IEntityMatchDynamicT entityMatchDynamicT = new IEntityMatchDynamicT();
			this.UnPackTo(entityMatchDynamicT);
			return entityMatchDynamicT;
		}

		// Token: 0x06021CC7 RID: 138439 RVA: 0x004B0470 File Offset: 0x004AE670
		public void UnPackTo(IEntityMatchDynamicT _o)
		{
			_o.Type = this.Type;
			_o.MatchEntity = new List<IDynamicEntityMatchT>();
			for (int i = 0; i < this.MatchEntityLength; i++)
			{
				_o.MatchEntity.Add((this.MatchEntity(i) != null) ? this.MatchEntity(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06021CC8 RID: 138440 RVA: 0x004B04DC File Offset: 0x004AE6DC
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

		// Token: 0x0400E277 RID: 57975
		private Table __p;
	}
}
