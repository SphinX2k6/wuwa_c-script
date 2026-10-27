using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CD9 RID: 19673
	public struct IStabilityPointAttribute : IFlatbufferObject
	{
		// Token: 0x17008ECA RID: 36554
		// (get) Token: 0x0601F379 RID: 127865 RVA: 0x0045B5D8 File Offset: 0x004597D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F37A RID: 127866 RVA: 0x0045B5E5 File Offset: 0x004597E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F37B RID: 127867 RVA: 0x0045B5EC File Offset: 0x004597EC
		public static IStabilityPointAttribute GetRootAsIStabilityPointAttribute(ByteBuffer _bb)
		{
			return IStabilityPointAttribute.GetRootAsIStabilityPointAttribute(_bb, default(IStabilityPointAttribute));
		}

		// Token: 0x0601F37C RID: 127868 RVA: 0x0045B608 File Offset: 0x00459808
		public static IStabilityPointAttribute GetRootAsIStabilityPointAttribute(ByteBuffer _bb, IStabilityPointAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F37D RID: 127869 RVA: 0x0045B625 File Offset: 0x00459825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F37E RID: 127870 RVA: 0x0045B634 File Offset: 0x00459834
		public IStabilityPointAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008ECB RID: 36555
		// (get) Token: 0x0601F37F RID: 127871 RVA: 0x0045B644 File Offset: 0x00459844
		public EPlayerAttributeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerAttributeType.Health;
				}
				return (EPlayerAttributeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008ECC RID: 36556
		// (get) Token: 0x0601F380 RID: 127872 RVA: 0x0045B680 File Offset: 0x00459880
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008ECD RID: 36557
		// (get) Token: 0x0601F381 RID: 127873 RVA: 0x0045B6BC File Offset: 0x004598BC
		public int Value
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008ECE RID: 36558
		// (get) Token: 0x0601F382 RID: 127874 RVA: 0x0045B6F8 File Offset: 0x004598F8
		public int ValueGroup
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008ECF RID: 36559
		// (get) Token: 0x0601F383 RID: 127875 RVA: 0x0045B738 File Offset: 0x00459938
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

		// Token: 0x0601F384 RID: 127876 RVA: 0x0045B775 File Offset: 0x00459975
		public static Offset<IStabilityPointAttribute> CreateIStabilityPointAttribute(FlatBufferBuilder builder, EPlayerAttributeType Type = EPlayerAttributeType.Health, ECompare Compare = ECompare.Eq, int Value = 0, int ValueGroup = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IStabilityPointAttribute.AddValueGroup(builder, ValueGroup);
			IStabilityPointAttribute.AddValue(builder, Value);
			IStabilityPointAttribute.AddNullMask(builder, NullMask);
			IStabilityPointAttribute.AddCompare(builder, Compare);
			IStabilityPointAttribute.AddType(builder, Type);
			return IStabilityPointAttribute.EndIStabilityPointAttribute(builder);
		}

		// Token: 0x0601F385 RID: 127877 RVA: 0x0045B7A9 File Offset: 0x004599A9
		public static void StartIStabilityPointAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F386 RID: 127878 RVA: 0x0045B7B2 File Offset: 0x004599B2
		public static void AddType(FlatBufferBuilder builder, EPlayerAttributeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F387 RID: 127879 RVA: 0x0045B7BD File Offset: 0x004599BD
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F388 RID: 127880 RVA: 0x0045B7C8 File Offset: 0x004599C8
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(2, value, 0);
		}

		// Token: 0x0601F389 RID: 127881 RVA: 0x0045B7D3 File Offset: 0x004599D3
		public static void AddValueGroup(FlatBufferBuilder builder, int valueGroup)
		{
			builder.AddInt(3, valueGroup, 0);
		}

		// Token: 0x0601F38A RID: 127882 RVA: 0x0045B7DE File Offset: 0x004599DE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601F38B RID: 127883 RVA: 0x0045B7E9 File Offset: 0x004599E9
		public static Offset<IStabilityPointAttribute> EndIStabilityPointAttribute(FlatBufferBuilder builder)
		{
			return new Offset<IStabilityPointAttribute>(builder.EndTable());
		}

		// Token: 0x0601F38C RID: 127884 RVA: 0x0045B7F8 File Offset: 0x004599F8
		public IStabilityPointAttributeT UnPack()
		{
			IStabilityPointAttributeT stabilityPointAttributeT = new IStabilityPointAttributeT();
			this.UnPackTo(stabilityPointAttributeT);
			return stabilityPointAttributeT;
		}

		// Token: 0x0601F38D RID: 127885 RVA: 0x0045B813 File Offset: 0x00459A13
		public void UnPackTo(IStabilityPointAttributeT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Value = this.Value;
			_o.ValueGroup = this.ValueGroup;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F38E RID: 127886 RVA: 0x0045B854 File Offset: 0x00459A54
		public static Offset<IStabilityPointAttribute> Pack(FlatBufferBuilder builder, IStabilityPointAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStabilityPointAttribute>);
			}
			return IStabilityPointAttribute.CreateIStabilityPointAttribute(builder, _o.Type, _o.Compare, _o.Value, _o.ValueGroup, _o.NullMask);
		}

		// Token: 0x0400D6A7 RID: 54951
		private Table __p;
	}
}
