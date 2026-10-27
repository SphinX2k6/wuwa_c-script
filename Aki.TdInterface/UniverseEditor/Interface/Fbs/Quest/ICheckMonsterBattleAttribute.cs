using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D52 RID: 15698
	public struct ICheckMonsterBattleAttribute : IFlatbufferObject
	{
		// Token: 0x17006BBD RID: 27581
		// (get) Token: 0x06015B61 RID: 88929 RVA: 0x00321DFD File Offset: 0x0031FFFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015B62 RID: 88930 RVA: 0x00321E0A File Offset: 0x0032000A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015B63 RID: 88931 RVA: 0x00321E14 File Offset: 0x00320014
		public static ICheckMonsterBattleAttribute GetRootAsICheckMonsterBattleAttribute(ByteBuffer _bb)
		{
			return ICheckMonsterBattleAttribute.GetRootAsICheckMonsterBattleAttribute(_bb, default(ICheckMonsterBattleAttribute));
		}

		// Token: 0x06015B64 RID: 88932 RVA: 0x00321E30 File Offset: 0x00320030
		public static ICheckMonsterBattleAttribute GetRootAsICheckMonsterBattleAttribute(ByteBuffer _bb, ICheckMonsterBattleAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015B65 RID: 88933 RVA: 0x00321E4D File Offset: 0x0032004D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015B66 RID: 88934 RVA: 0x00321E5C File Offset: 0x0032005C
		public ICheckMonsterBattleAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BBE RID: 27582
		// (get) Token: 0x06015B67 RID: 88935 RVA: 0x00321E6C File Offset: 0x0032006C
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

		// Token: 0x17006BBF RID: 27583
		// (get) Token: 0x06015B68 RID: 88936 RVA: 0x00321EA8 File Offset: 0x003200A8
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

		// Token: 0x06015B69 RID: 88937 RVA: 0x00321F08 File Offset: 0x00320108
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006BC0 RID: 27584
		// (get) Token: 0x06015B6A RID: 88938 RVA: 0x00321F48 File Offset: 0x00320148
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

		// Token: 0x06015B6B RID: 88939 RVA: 0x00321F73 File Offset: 0x00320173
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06015B6C RID: 88940 RVA: 0x00321F82 File Offset: 0x00320182
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06015B6D RID: 88941 RVA: 0x00321F90 File Offset: 0x00320190
		public static Offset<ICheckMonsterBattleAttribute> CreateICheckMonsterBattleAttribute(FlatBufferBuilder builder, ETargetBattleAttribute Type = ETargetBattleAttribute.Player, Offset<IHealthAttributeToTarget> OptionOffset = default(Offset<IHealthAttributeToTarget>), VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckMonsterBattleAttribute.AddEntityIds(builder, EntityIdsOffset);
			ICheckMonsterBattleAttribute.AddOption(builder, OptionOffset);
			ICheckMonsterBattleAttribute.AddType(builder, Type);
			return ICheckMonsterBattleAttribute.EndICheckMonsterBattleAttribute(builder);
		}

		// Token: 0x06015B6E RID: 88942 RVA: 0x00321FB4 File Offset: 0x003201B4
		public static void StartICheckMonsterBattleAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015B6F RID: 88943 RVA: 0x00321FBD File Offset: 0x003201BD
		public static void AddType(FlatBufferBuilder builder, ETargetBattleAttribute type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015B70 RID: 88944 RVA: 0x00321FC8 File Offset: 0x003201C8
		public static void AddOption(FlatBufferBuilder builder, Offset<IHealthAttributeToTarget> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x06015B71 RID: 88945 RVA: 0x00321FD8 File Offset: 0x003201D8
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x06015B72 RID: 88946 RVA: 0x00321FE8 File Offset: 0x003201E8
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015B73 RID: 88947 RVA: 0x0032201F File Offset: 0x0032021F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015B74 RID: 88948 RVA: 0x00322039 File Offset: 0x00320239
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015B75 RID: 88949 RVA: 0x00322057 File Offset: 0x00320257
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015B76 RID: 88950 RVA: 0x00322070 File Offset: 0x00320270
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015B77 RID: 88951 RVA: 0x0032207B File Offset: 0x0032027B
		public static Offset<ICheckMonsterBattleAttribute> EndICheckMonsterBattleAttribute(FlatBufferBuilder builder)
		{
			return new Offset<ICheckMonsterBattleAttribute>(builder.EndTable());
		}

		// Token: 0x06015B78 RID: 88952 RVA: 0x00322088 File Offset: 0x00320288
		public ICheckMonsterBattleAttributeT UnPack()
		{
			ICheckMonsterBattleAttributeT checkMonsterBattleAttributeT = new ICheckMonsterBattleAttributeT();
			this.UnPackTo(checkMonsterBattleAttributeT);
			return checkMonsterBattleAttributeT;
		}

		// Token: 0x06015B79 RID: 88953 RVA: 0x003220A4 File Offset: 0x003202A4
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

		// Token: 0x06015B7A RID: 88954 RVA: 0x0032211C File Offset: 0x0032031C
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

		// Token: 0x0400B62F RID: 46639
		private Table __p;
	}
}
