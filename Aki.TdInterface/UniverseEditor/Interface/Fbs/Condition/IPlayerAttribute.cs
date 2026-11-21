using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200517B RID: 20859
	public struct IPlayerAttribute : IFlatbufferObject
	{
		// Token: 0x17009569 RID: 38249
		// (get) Token: 0x06020D15 RID: 134421 RVA: 0x0048AF52 File Offset: 0x00489152
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020D16 RID: 134422 RVA: 0x0048AF5F File Offset: 0x0048915F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020D17 RID: 134423 RVA: 0x0048AF68 File Offset: 0x00489168
		public static IPlayerAttribute GetRootAsIPlayerAttribute(ByteBuffer _bb)
		{
			return IPlayerAttribute.GetRootAsIPlayerAttribute(_bb, default(IPlayerAttribute));
		}

		// Token: 0x06020D18 RID: 134424 RVA: 0x0048AF84 File Offset: 0x00489184
		public static IPlayerAttribute GetRootAsIPlayerAttribute(ByteBuffer _bb, IPlayerAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020D19 RID: 134425 RVA: 0x0048AFA1 File Offset: 0x004891A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020D1A RID: 134426 RVA: 0x0048AFB0 File Offset: 0x004891B0
		public IPlayerAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700956A RID: 38250
		// (get) Token: 0x06020D1B RID: 134427 RVA: 0x0048AFC0 File Offset: 0x004891C0
		public ETargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetType.Player;
				}
				return (ETargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700956B RID: 38251
		// (get) Token: 0x06020D1C RID: 134428 RVA: 0x0048AFFC File Offset: 0x004891FC
		public EPlayerCheckType Option
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPlayerCheckType.AnyRole;
				}
				return (EPlayerCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020D1D RID: 134429 RVA: 0x0048B038 File Offset: 0x00489238
		public TPlayerAttribute AttributeTypesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TPlayerAttribute.NONE;
			}
			return (TPlayerAttribute)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700956C RID: 38252
		// (get) Token: 0x06020D1E RID: 134430 RVA: 0x0048B078 File Offset: 0x00489278
		public int AttributeTypesTypeLength
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

		// Token: 0x06020D1F RID: 134431 RVA: 0x0048B0A3 File Offset: 0x004892A3
		public Span<TPlayerAttribute> GetAttributeTypesTypeBytes()
		{
			return this.__p.__vector_as_span<TPlayerAttribute>(8, 1);
		}

		// Token: 0x06020D20 RID: 134432 RVA: 0x0048B0B4 File Offset: 0x004892B4
		public TPlayerAttribute[] GetAttributeTypesTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TPlayerAttribute[] array = new TPlayerAttribute[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TPlayerAttribute)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06020D21 RID: 134433 RVA: 0x0048B120 File Offset: 0x00489320
		public TTable? AttributeTypes<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700956D RID: 38253
		// (get) Token: 0x06020D22 RID: 134434 RVA: 0x0048B168 File Offset: 0x00489368
		public int AttributeTypesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06020D23 RID: 134435 RVA: 0x0048B194 File Offset: 0x00489394
		public static Offset<IPlayerAttribute> CreateIPlayerAttribute(FlatBufferBuilder builder, ETargetType Type = ETargetType.Player, EPlayerCheckType Option = EPlayerCheckType.AnyRole, VectorOffset AttributeTypes_typeOffset = default(VectorOffset), VectorOffset AttributeTypesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IPlayerAttribute.AddAttributeTypes(builder, AttributeTypesOffset);
			IPlayerAttribute.AddAttributeTypesType(builder, AttributeTypes_typeOffset);
			IPlayerAttribute.AddOption(builder, Option);
			IPlayerAttribute.AddType(builder, Type);
			return IPlayerAttribute.EndIPlayerAttribute(builder);
		}

		// Token: 0x06020D24 RID: 134436 RVA: 0x0048B1C0 File Offset: 0x004893C0
		public static void StartIPlayerAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020D25 RID: 134437 RVA: 0x0048B1C9 File Offset: 0x004893C9
		public static void AddType(FlatBufferBuilder builder, ETargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020D26 RID: 134438 RVA: 0x0048B1D4 File Offset: 0x004893D4
		public static void AddOption(FlatBufferBuilder builder, EPlayerCheckType option)
		{
			builder.AddByte(1, (byte)option, 0);
		}

		// Token: 0x06020D27 RID: 134439 RVA: 0x0048B1DF File Offset: 0x004893DF
		public static void AddAttributeTypesType(FlatBufferBuilder builder, VectorOffset attributeTypesTypeOffset)
		{
			builder.AddOffset(2, attributeTypesTypeOffset.Value, 0);
		}

		// Token: 0x06020D28 RID: 134440 RVA: 0x0048B1F0 File Offset: 0x004893F0
		public static VectorOffset CreateAttributeTypesTypeVector(FlatBufferBuilder builder, TPlayerAttribute[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06020D29 RID: 134441 RVA: 0x0048B227 File Offset: 0x00489427
		public static VectorOffset CreateAttributeTypesTypeVectorBlock(FlatBufferBuilder builder, TPlayerAttribute[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPlayerAttribute>(data);
			return builder.EndVector();
		}

		// Token: 0x06020D2A RID: 134442 RVA: 0x0048B241 File Offset: 0x00489441
		public static VectorOffset CreateAttributeTypesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPlayerAttribute> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPlayerAttribute>(data);
			return builder.EndVector();
		}

		// Token: 0x06020D2B RID: 134443 RVA: 0x0048B25F File Offset: 0x0048945F
		public static VectorOffset CreateAttributeTypesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPlayerAttribute>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020D2C RID: 134444 RVA: 0x0048B278 File Offset: 0x00489478
		public static void StartAttributeTypesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06020D2D RID: 134445 RVA: 0x0048B283 File Offset: 0x00489483
		public static void AddAttributeTypes(FlatBufferBuilder builder, VectorOffset attributeTypesOffset)
		{
			builder.AddOffset(3, attributeTypesOffset.Value, 0);
		}

		// Token: 0x06020D2E RID: 134446 RVA: 0x0048B294 File Offset: 0x00489494
		public static VectorOffset CreateAttributeTypesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06020D2F RID: 134447 RVA: 0x0048B2CB File Offset: 0x004894CB
		public static VectorOffset CreateAttributeTypesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020D30 RID: 134448 RVA: 0x0048B2E5 File Offset: 0x004894E5
		public static VectorOffset CreateAttributeTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020D31 RID: 134449 RVA: 0x0048B303 File Offset: 0x00489503
		public static VectorOffset CreateAttributeTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020D32 RID: 134450 RVA: 0x0048B31C File Offset: 0x0048951C
		public static void StartAttributeTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020D33 RID: 134451 RVA: 0x0048B327 File Offset: 0x00489527
		public static Offset<IPlayerAttribute> EndIPlayerAttribute(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerAttribute>(builder.EndTable());
		}

		// Token: 0x06020D34 RID: 134452 RVA: 0x0048B334 File Offset: 0x00489534
		public IPlayerAttributeT UnPack()
		{
			IPlayerAttributeT playerAttributeT = new IPlayerAttributeT();
			this.UnPackTo(playerAttributeT);
			return playerAttributeT;
		}

		// Token: 0x06020D35 RID: 134453 RVA: 0x0048B350 File Offset: 0x00489550
		public void UnPackTo(IPlayerAttributeT _o)
		{
			_o.Type = this.Type;
			_o.Option = this.Option;
			_o.AttributeTypes = new List<TPlayerAttributeUnion>();
			for (int i = 0; i < this.AttributeTypesLength; i++)
			{
				TPlayerAttributeUnion tplayerAttributeUnion = new TPlayerAttributeUnion();
				tplayerAttributeUnion.Type = this.AttributeTypesType(i);
				TPlayerAttribute tplayerAttribute = this.AttributeTypesType(i);
				if (tplayerAttribute != TPlayerAttribute.IHealthAttribute)
				{
					if (tplayerAttribute == TPlayerAttribute.IStabilityPointAttribute)
					{
						tplayerAttributeUnion.Value = ((this.AttributeTypes<IStabilityPointAttribute>(i) != null) ? this.AttributeTypes<IStabilityPointAttribute>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tplayerAttributeUnion.Value = ((this.AttributeTypes<IHealthAttribute>(i) != null) ? this.AttributeTypes<IHealthAttribute>(i).Value.UnPack() : null);
				}
				_o.AttributeTypes.Add(tplayerAttributeUnion);
			}
		}

		// Token: 0x06020D36 RID: 134454 RVA: 0x0048B430 File Offset: 0x00489630
		public static Offset<IPlayerAttribute> Pack(FlatBufferBuilder builder, IPlayerAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerAttribute>);
			}
			VectorOffset attributeTypes_typeOffset = default(VectorOffset);
			if (_o.AttributeTypes != null)
			{
				TPlayerAttribute[] array = new TPlayerAttribute[_o.AttributeTypes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.AttributeTypes[i].Type;
				}
				attributeTypes_typeOffset = IPlayerAttribute.CreateAttributeTypesTypeVector(builder, array);
			}
			VectorOffset attributeTypesOffset = default(VectorOffset);
			if (_o.AttributeTypes != null)
			{
				int[] array2 = new int[_o.AttributeTypes.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPlayerAttributeUnion.Pack(builder, _o.AttributeTypes[j]);
				}
				attributeTypesOffset = IPlayerAttribute.CreateAttributeTypesVector(builder, array2);
			}
			return IPlayerAttribute.CreateIPlayerAttribute(builder, _o.Type, _o.Option, attributeTypes_typeOffset, attributeTypesOffset);
		}

		// Token: 0x0400E15F RID: 57695
		private Table __p;
	}
}
