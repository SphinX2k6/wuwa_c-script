using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B15 RID: 27413
	public struct IMotorConstraintConfig : IFlatbufferObject
	{
		// Token: 0x1700CBA2 RID: 52130
		// (get) Token: 0x06030188 RID: 197000 RVA: 0x00689C0B File Offset: 0x00687E0B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030189 RID: 197001 RVA: 0x00689C18 File Offset: 0x00687E18
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603018A RID: 197002 RVA: 0x00689C20 File Offset: 0x00687E20
		public static IMotorConstraintConfig GetRootAsIMotorConstraintConfig(ByteBuffer _bb)
		{
			return IMotorConstraintConfig.GetRootAsIMotorConstraintConfig(_bb, default(IMotorConstraintConfig));
		}

		// Token: 0x0603018B RID: 197003 RVA: 0x00689C3C File Offset: 0x00687E3C
		public static IMotorConstraintConfig GetRootAsIMotorConstraintConfig(ByteBuffer _bb, IMotorConstraintConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603018C RID: 197004 RVA: 0x00689C59 File Offset: 0x00687E59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603018D RID: 197005 RVA: 0x00689C68 File Offset: 0x00687E68
		public IMotorConstraintConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603018E RID: 197006 RVA: 0x00689C78 File Offset: 0x00687E78
		public EPlayerInputConstraintType DisableInput(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return EPlayerInputConstraintType.Left;
			}
			return (EPlayerInputConstraintType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700CBA3 RID: 52131
		// (get) Token: 0x0603018F RID: 197007 RVA: 0x00689CB8 File Offset: 0x00687EB8
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

		// Token: 0x06030190 RID: 197008 RVA: 0x00689CE3 File Offset: 0x00687EE3
		public Span<EPlayerInputConstraintType> GetDisableInputBytes()
		{
			return this.__p.__vector_as_span<EPlayerInputConstraintType>(4, 1);
		}

		// Token: 0x06030191 RID: 197009 RVA: 0x00689CF4 File Offset: 0x00687EF4
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

		// Token: 0x1700CBA4 RID: 52132
		// (get) Token: 0x06030192 RID: 197010 RVA: 0x00689D60 File Offset: 0x00687F60
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

		// Token: 0x06030193 RID: 197011 RVA: 0x00689D9C File Offset: 0x00687F9C
		public static Offset<IMotorConstraintConfig> CreateIMotorConstraintConfig(FlatBufferBuilder builder, VectorOffset DisableInputOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			IMotorConstraintConfig.AddDisableInput(builder, DisableInputOffset);
			IMotorConstraintConfig.AddNullMask(builder, NullMask);
			return IMotorConstraintConfig.EndIMotorConstraintConfig(builder);
		}

		// Token: 0x06030194 RID: 197012 RVA: 0x00689DB9 File Offset: 0x00687FB9
		public static void StartIMotorConstraintConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030195 RID: 197013 RVA: 0x00689DC2 File Offset: 0x00687FC2
		public static void AddDisableInput(FlatBufferBuilder builder, VectorOffset disableInputOffset)
		{
			builder.AddOffset(0, disableInputOffset.Value, 0);
		}

		// Token: 0x06030196 RID: 197014 RVA: 0x00689DD4 File Offset: 0x00687FD4
		public static VectorOffset CreateDisableInputVector(FlatBufferBuilder builder, EPlayerInputConstraintType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030197 RID: 197015 RVA: 0x00689E0B File Offset: 0x0068800B
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, EPlayerInputConstraintType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EPlayerInputConstraintType>(data);
			return builder.EndVector();
		}

		// Token: 0x06030198 RID: 197016 RVA: 0x00689E25 File Offset: 0x00688025
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, ArraySegment<EPlayerInputConstraintType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EPlayerInputConstraintType>(data);
			return builder.EndVector();
		}

		// Token: 0x06030199 RID: 197017 RVA: 0x00689E43 File Offset: 0x00688043
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EPlayerInputConstraintType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603019A RID: 197018 RVA: 0x00689E5C File Offset: 0x0068805C
		public static void StartDisableInputVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603019B RID: 197019 RVA: 0x00689E67 File Offset: 0x00688067
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0603019C RID: 197020 RVA: 0x00689E72 File Offset: 0x00688072
		public static Offset<IMotorConstraintConfig> EndIMotorConstraintConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorConstraintConfig>(builder.EndTable());
		}

		// Token: 0x0603019D RID: 197021 RVA: 0x00689E80 File Offset: 0x00688080
		public IMotorConstraintConfigT UnPack()
		{
			IMotorConstraintConfigT motorConstraintConfigT = new IMotorConstraintConfigT();
			this.UnPackTo(motorConstraintConfigT);
			return motorConstraintConfigT;
		}

		// Token: 0x0603019E RID: 197022 RVA: 0x00689E9C File Offset: 0x0068809C
		public void UnPackTo(IMotorConstraintConfigT _o)
		{
			_o.DisableInput = new List<EPlayerInputConstraintType>();
			for (int i = 0; i < this.DisableInputLength; i++)
			{
				_o.DisableInput.Add(this.DisableInput(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603019F RID: 197023 RVA: 0x00689EE4 File Offset: 0x006880E4
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

		// Token: 0x04011396 RID: 70550
		private Table __p;
	}
}
