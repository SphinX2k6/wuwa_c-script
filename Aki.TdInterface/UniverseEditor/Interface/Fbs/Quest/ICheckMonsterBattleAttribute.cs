using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004169 RID: 16745
	public struct ICheckMonsterBattleAttribute : IFlatbufferObject
	{
		// Token: 0x17007177 RID: 29047
		// (get) Token: 0x06017099 RID: 94361 RVA: 0x00349075 File Offset: 0x00347275
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601709A RID: 94362 RVA: 0x00349082 File Offset: 0x00347282
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601709B RID: 94363 RVA: 0x0034908C File Offset: 0x0034728C
		public static ICheckMonsterBattleAttribute GetRootAsICheckMonsterBattleAttribute(ByteBuffer _bb)
		{
			return ICheckMonsterBattleAttribute.GetRootAsICheckMonsterBattleAttribute(_bb, default(ICheckMonsterBattleAttribute));
		}

		// Token: 0x0601709C RID: 94364 RVA: 0x003490A8 File Offset: 0x003472A8
		public static ICheckMonsterBattleAttribute GetRootAsICheckMonsterBattleAttribute(ByteBuffer _bb, ICheckMonsterBattleAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601709D RID: 94365 RVA: 0x003490C5 File Offset: 0x003472C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601709E RID: 94366 RVA: 0x003490D4 File Offset: 0x003472D4
		public ICheckMonsterBattleAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007178 RID: 29048
		// (get) Token: 0x0601709F RID: 94367 RVA: 0x003490E4 File Offset: 0x003472E4
		public ETargetBattleAttribute Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetBattleAttribute.Player;
				}
				return (ETargetBattleAttribute)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007179 RID: 29049
		// (get) Token: 0x060170A0 RID: 94368 RVA: 0x00349120 File Offset: 0x00347320
		public IHealthAttributeToTarget? Option
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IHealthAttributeToTarget?(default(IHealthAttributeToTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060170A1 RID: 94369 RVA: 0x00349180 File Offset: 0x00347380
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700717A RID: 29050
		// (get) Token: 0x060170A2 RID: 94370 RVA: 0x003491C0 File Offset: 0x003473C0
		public int EntityIdsLength
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

		// Token: 0x060170A3 RID: 94371 RVA: 0x003491EB File Offset: 0x003473EB
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060170A4 RID: 94372 RVA: 0x003491FA File Offset: 0x003473FA
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x060170A5 RID: 94373 RVA: 0x00349208 File Offset: 0x00347408
		public static Offset<ICheckMonsterBattleAttribute> CreateICheckMonsterBattleAttribute(FlatBufferBuilder builder, ETargetBattleAttribute Type = ETargetBattleAttribute.Player, Offset<IHealthAttributeToTarget> OptionOffset = default(Offset<IHealthAttributeToTarget>), VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckMonsterBattleAttribute.AddEntityIds(builder, EntityIdsOffset);
			ICheckMonsterBattleAttribute.AddOption(builder, OptionOffset);
			ICheckMonsterBattleAttribute.AddType(builder, Type);
			return ICheckMonsterBattleAttribute.EndICheckMonsterBattleAttribute(builder);
		}

		// Token: 0x060170A6 RID: 94374 RVA: 0x0034922C File Offset: 0x0034742C
		public static void StartICheckMonsterBattleAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060170A7 RID: 94375 RVA: 0x00349235 File Offset: 0x00347435
		public static void AddType(FlatBufferBuilder builder, ETargetBattleAttribute type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060170A8 RID: 94376 RVA: 0x00349240 File Offset: 0x00347440
		public static void AddOption(FlatBufferBuilder builder, Offset<IHealthAttributeToTarget> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x060170A9 RID: 94377 RVA: 0x00349250 File Offset: 0x00347450
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x060170AA RID: 94378 RVA: 0x00349260 File Offset: 0x00347460
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060170AB RID: 94379 RVA: 0x00349297 File Offset: 0x00347497
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060170AC RID: 94380 RVA: 0x003492B1 File Offset: 0x003474B1
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060170AD RID: 94381 RVA: 0x003492CF File Offset: 0x003474CF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060170AE RID: 94382 RVA: 0x003492E8 File Offset: 0x003474E8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060170AF RID: 94383 RVA: 0x003492F3 File Offset: 0x003474F3
		public static Offset<ICheckMonsterBattleAttribute> EndICheckMonsterBattleAttribute(FlatBufferBuilder builder)
		{
			return new Offset<ICheckMonsterBattleAttribute>(builder.EndTable());
		}

		// Token: 0x060170B0 RID: 94384 RVA: 0x00349300 File Offset: 0x00347500
		public ICheckMonsterBattleAttributeT UnPack()
		{
			ICheckMonsterBattleAttributeT checkMonsterBattleAttributeT = new ICheckMonsterBattleAttributeT();
			this.UnPackTo(checkMonsterBattleAttributeT);
			return checkMonsterBattleAttributeT;
		}

		// Token: 0x060170B1 RID: 94385 RVA: 0x0034931C File Offset: 0x0034751C
		public void UnPackTo(ICheckMonsterBattleAttributeT _o)
		{
			_o.Type = this.Type;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x060170B2 RID: 94386 RVA: 0x00349394 File Offset: 0x00347594
		public static Offset<ICheckMonsterBattleAttribute> Pack(FlatBufferBuilder builder, ICheckMonsterBattleAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckMonsterBattleAttribute>);
			}
			Offset<IHealthAttributeToTarget> optionOffset = (_o.Option == null) ? default(Offset<IHealthAttributeToTarget>) : IHealthAttributeToTarget.Pack(builder, _o.Option);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ICheckMonsterBattleAttribute.CreateEntityIdsVector(builder, data);
			}
			return ICheckMonsterBattleAttribute.CreateICheckMonsterBattleAttribute(builder, _o.Type, optionOffset, entityIdsOffset);
		}

		// Token: 0x0400BFDC RID: 49116
		private Table __p;
	}
}
