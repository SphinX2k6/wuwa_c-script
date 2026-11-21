using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200724C RID: 29260
	public struct IMotorConstraintConfig : IFlatbufferObject
	{
		// Token: 0x1700D671 RID: 54897
		// (get) Token: 0x06032F5C RID: 208732 RVA: 0x006E12C3 File Offset: 0x006DF4C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032F5D RID: 208733 RVA: 0x006E12D0 File Offset: 0x006DF4D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032F5E RID: 208734 RVA: 0x006E12D8 File Offset: 0x006DF4D8
		public static IMotorConstraintConfig GetRootAsIMotorConstraintConfig(ByteBuffer _bb)
		{
			return IMotorConstraintConfig.GetRootAsIMotorConstraintConfig(_bb, default(IMotorConstraintConfig));
		}

		// Token: 0x06032F5F RID: 208735 RVA: 0x006E12F4 File Offset: 0x006DF4F4
		public static IMotorConstraintConfig GetRootAsIMotorConstraintConfig(ByteBuffer _bb, IMotorConstraintConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032F60 RID: 208736 RVA: 0x006E1311 File Offset: 0x006DF511
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032F61 RID: 208737 RVA: 0x006E1320 File Offset: 0x006DF520
		public IMotorConstraintConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032F62 RID: 208738 RVA: 0x006E1330 File Offset: 0x006DF530
		public EPlayerInputConstraintType DisableInput(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return EPlayerInputConstraintType.Left;
			}
			return (EPlayerInputConstraintType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D672 RID: 54898
		// (get) Token: 0x06032F63 RID: 208739 RVA: 0x006E1370 File Offset: 0x006DF570
		public int DisableInputLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06032F64 RID: 208740 RVA: 0x006E139B File Offset: 0x006DF59B
		public Span<EPlayerInputConstraintType> GetDisableInputBytes()
		{
			return this.__p.__vector_as_span<EPlayerInputConstraintType>(4, 1);
		}

		// Token: 0x06032F65 RID: 208741 RVA: 0x006E13AC File Offset: 0x006DF5AC
		public EPlayerInputConstraintType[] GetDisableInputArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EPlayerInputConstraintType[] array = new EPlayerInputConstraintType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EPlayerInputConstraintType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700D673 RID: 54899
		// (get) Token: 0x06032F66 RID: 208742 RVA: 0x006E1418 File Offset: 0x006DF618
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032F67 RID: 208743 RVA: 0x006E1454 File Offset: 0x006DF654
		public static Offset<IMotorConstraintConfig> CreateIMotorConstraintConfig(FlatBufferBuilder builder, VectorOffset DisableInputOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			IMotorConstraintConfig.AddDisableInput(builder, DisableInputOffset);
			IMotorConstraintConfig.AddNullMask(builder, NullMask);
			return IMotorConstraintConfig.EndIMotorConstraintConfig(builder);
		}

		// Token: 0x06032F68 RID: 208744 RVA: 0x006E1471 File Offset: 0x006DF671
		public static void StartIMotorConstraintConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032F69 RID: 208745 RVA: 0x006E147A File Offset: 0x006DF67A
		public static void AddDisableInput(FlatBufferBuilder builder, VectorOffset disableInputOffset)
		{
			builder.AddOffset(0, disableInputOffset.Value, 0);
		}

		// Token: 0x06032F6A RID: 208746 RVA: 0x006E148C File Offset: 0x006DF68C
		public static VectorOffset CreateDisableInputVector(FlatBufferBuilder builder, EPlayerInputConstraintType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032F6B RID: 208747 RVA: 0x006E14C3 File Offset: 0x006DF6C3
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, EPlayerInputConstraintType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EPlayerInputConstraintType>(data);
			return builder.EndVector();
		}

		// Token: 0x06032F6C RID: 208748 RVA: 0x006E14DD File Offset: 0x006DF6DD
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, ArraySegment<EPlayerInputConstraintType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EPlayerInputConstraintType>(data);
			return builder.EndVector();
		}

		// Token: 0x06032F6D RID: 208749 RVA: 0x006E14FB File Offset: 0x006DF6FB
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EPlayerInputConstraintType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032F6E RID: 208750 RVA: 0x006E1514 File Offset: 0x006DF714
		public static void StartDisableInputVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06032F6F RID: 208751 RVA: 0x006E151F File Offset: 0x006DF71F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06032F70 RID: 208752 RVA: 0x006E152A File Offset: 0x006DF72A
		public static Offset<IMotorConstraintConfig> EndIMotorConstraintConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorConstraintConfig>(builder.EndTable());
		}

		// Token: 0x06032F71 RID: 208753 RVA: 0x006E1538 File Offset: 0x006DF738
		public IMotorConstraintConfigT UnPack()
		{
			IMotorConstraintConfigT motorConstraintConfigT = new IMotorConstraintConfigT();
			this.UnPackTo(motorConstraintConfigT);
			return motorConstraintConfigT;
		}

		// Token: 0x06032F72 RID: 208754 RVA: 0x006E1554 File Offset: 0x006DF754
		public void UnPackTo(IMotorConstraintConfigT _o)
		{
			_o.DisableInput = new List<EPlayerInputConstraintType>();
			for (int i = 0; i < this.DisableInputLength; i++)
			{
				_o.DisableInput.Add(this.DisableInput(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032F73 RID: 208755 RVA: 0x006E159C File Offset: 0x006DF79C
		public static Offset<IMotorConstraintConfig> Pack(FlatBufferBuilder builder, IMotorConstraintConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorConstraintConfig>);
			}
			VectorOffset disableInputOffset = default(VectorOffset);
			if (_o.DisableInput != null)
			{
				EPlayerInputConstraintType[] data = _o.DisableInput.ToArray();
				disableInputOffset = IMotorConstraintConfig.CreateDisableInputVector(builder, data);
			}
			return IMotorConstraintConfig.CreateIMotorConstraintConfig(builder, disableInputOffset, _o.NullMask);
		}

		// Token: 0x040122A9 RID: 74409
		private Table __p;
	}
}
