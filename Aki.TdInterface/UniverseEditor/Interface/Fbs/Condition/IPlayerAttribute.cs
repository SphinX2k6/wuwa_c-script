using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C82 RID: 19586
	public struct IPlayerAttribute : IFlatbufferObject
	{
		// Token: 0x17008E3B RID: 36411
		// (get) Token: 0x0601F0F3 RID: 127219 RVA: 0x00457402 File Offset: 0x00455602
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F0F4 RID: 127220 RVA: 0x0045740F File Offset: 0x0045560F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F0F5 RID: 127221 RVA: 0x00457418 File Offset: 0x00455618
		public static IPlayerAttribute GetRootAsIPlayerAttribute(ByteBuffer _bb)
		{
			return IPlayerAttribute.GetRootAsIPlayerAttribute(_bb, default(IPlayerAttribute));
		}

		// Token: 0x0601F0F6 RID: 127222 RVA: 0x00457434 File Offset: 0x00455634
		public static IPlayerAttribute GetRootAsIPlayerAttribute(ByteBuffer _bb, IPlayerAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F0F7 RID: 127223 RVA: 0x00457451 File Offset: 0x00455651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F0F8 RID: 127224 RVA: 0x00457460 File Offset: 0x00455660
		public IPlayerAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E3C RID: 36412
		// (get) Token: 0x0601F0F9 RID: 127225 RVA: 0x00457470 File Offset: 0x00455670
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

		// Token: 0x17008E3D RID: 36413
		// (get) Token: 0x0601F0FA RID: 127226 RVA: 0x004574AC File Offset: 0x004556AC
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

		// Token: 0x0601F0FB RID: 127227 RVA: 0x004574E8 File Offset: 0x004556E8
		public TPlayerAttribute AttributeTypesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TPlayerAttribute.NONE;
			}
			return (TPlayerAttribute)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008E3E RID: 36414
		// (get) Token: 0x0601F0FC RID: 127228 RVA: 0x00457528 File Offset: 0x00455728
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

		// Token: 0x0601F0FD RID: 127229 RVA: 0x00457553 File Offset: 0x00455753
		public Span<TPlayerAttribute> GetAttributeTypesTypeBytes()
		{
			return this.__p.__vector_as_span<TPlayerAttribute>(8, 1);
		}

		// Token: 0x0601F0FE RID: 127230 RVA: 0x00457564 File Offset: 0x00455764
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

		// Token: 0x0601F0FF RID: 127231 RVA: 0x004575D0 File Offset: 0x004557D0
		public TTable? AttributeTypes<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008E3F RID: 36415
		// (get) Token: 0x0601F100 RID: 127232 RVA: 0x00457618 File Offset: 0x00455818
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

		// Token: 0x0601F101 RID: 127233 RVA: 0x00457644 File Offset: 0x00455844
		public static Offset<IPlayerAttribute> CreateIPlayerAttribute(FlatBufferBuilder builder, ETargetType Type = ETargetType.Player, EPlayerCheckType Option = EPlayerCheckType.AnyRole, VectorOffset AttributeTypes_typeOffset = default(VectorOffset), VectorOffset AttributeTypesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IPlayerAttribute.AddAttributeTypes(builder, AttributeTypesOffset);
			IPlayerAttribute.AddAttributeTypesType(builder, AttributeTypes_typeOffset);
			IPlayerAttribute.AddOption(builder, Option);
			IPlayerAttribute.AddType(builder, Type);
			return IPlayerAttribute.EndIPlayerAttribute(builder);
		}

		// Token: 0x0601F102 RID: 127234 RVA: 0x00457670 File Offset: 0x00455870
		public static void StartIPlayerAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F103 RID: 127235 RVA: 0x00457679 File Offset: 0x00455879
		public static void AddType(FlatBufferBuilder builder, ETargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F104 RID: 127236 RVA: 0x00457684 File Offset: 0x00455884
		public static void AddOption(FlatBufferBuilder builder, EPlayerCheckType option)
		{
			builder.AddByte(1, (byte)option, 0);
		}

		// Token: 0x0601F105 RID: 127237 RVA: 0x0045768F File Offset: 0x0045588F
		public static void AddAttributeTypesType(FlatBufferBuilder builder, VectorOffset attributeTypesTypeOffset)
		{
			builder.AddOffset(2, attributeTypesTypeOffset.Value, 0);
		}

		// Token: 0x0601F106 RID: 127238 RVA: 0x004576A0 File Offset: 0x004558A0
		public static VectorOffset CreateAttributeTypesTypeVector(FlatBufferBuilder builder, TPlayerAttribute[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F107 RID: 127239 RVA: 0x004576D7 File Offset: 0x004558D7
		public static VectorOffset CreateAttributeTypesTypeVectorBlock(FlatBufferBuilder builder, TPlayerAttribute[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPlayerAttribute>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F108 RID: 127240 RVA: 0x004576F1 File Offset: 0x004558F1
		public static VectorOffset CreateAttributeTypesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPlayerAttribute> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPlayerAttribute>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F109 RID: 127241 RVA: 0x0045770F File Offset: 0x0045590F
		public static VectorOffset CreateAttributeTypesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPlayerAttribute>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F10A RID: 127242 RVA: 0x00457728 File Offset: 0x00455928
		public static void StartAttributeTypesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601F10B RID: 127243 RVA: 0x00457733 File Offset: 0x00455933
		public static void AddAttributeTypes(FlatBufferBuilder builder, VectorOffset attributeTypesOffset)
		{
			builder.AddOffset(3, attributeTypesOffset.Value, 0);
		}

		// Token: 0x0601F10C RID: 127244 RVA: 0x00457744 File Offset: 0x00455944
		public static VectorOffset CreateAttributeTypesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F10D RID: 127245 RVA: 0x0045777B File Offset: 0x0045597B
		public static VectorOffset CreateAttributeTypesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F10E RID: 127246 RVA: 0x00457795 File Offset: 0x00455995
		public static VectorOffset CreateAttributeTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F10F RID: 127247 RVA: 0x004577B3 File Offset: 0x004559B3
		public static VectorOffset CreateAttributeTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F110 RID: 127248 RVA: 0x004577CC File Offset: 0x004559CC
		public static void StartAttributeTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F111 RID: 127249 RVA: 0x004577D7 File Offset: 0x004559D7
		public static Offset<IPlayerAttribute> EndIPlayerAttribute(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerAttribute>(builder.EndTable());
		}

		// Token: 0x0601F112 RID: 127250 RVA: 0x004577E4 File Offset: 0x004559E4
		public IPlayerAttributeT UnPack()
		{
			IPlayerAttributeT playerAttributeT = new IPlayerAttributeT();
			this.UnPackTo(playerAttributeT);
			return playerAttributeT;
		}

		// Token: 0x0601F113 RID: 127251 RVA: 0x00457800 File Offset: 0x00455A00
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

		// Token: 0x0601F114 RID: 127252 RVA: 0x004578E0 File Offset: 0x00455AE0
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

		// Token: 0x0400D638 RID: 54840
		private Table __p;
	}
}
