using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078F3 RID: 30963
	public struct ISkillBlackboardVector : IFlatbufferObject
	{
		// Token: 0x1700E334 RID: 58164
		// (get) Token: 0x0603685F RID: 223327 RVA: 0x0074CA2A File Offset: 0x0074AC2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036860 RID: 223328 RVA: 0x0074CA37 File Offset: 0x0074AC37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036861 RID: 223329 RVA: 0x0074CA40 File Offset: 0x0074AC40
		public static ISkillBlackboardVector GetRootAsISkillBlackboardVector(ByteBuffer _bb)
		{
			return ISkillBlackboardVector.GetRootAsISkillBlackboardVector(_bb, default(ISkillBlackboardVector));
		}

		// Token: 0x06036862 RID: 223330 RVA: 0x0074CA5C File Offset: 0x0074AC5C
		public static ISkillBlackboardVector GetRootAsISkillBlackboardVector(ByteBuffer _bb, ISkillBlackboardVector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036863 RID: 223331 RVA: 0x0074CA79 File Offset: 0x0074AC79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036864 RID: 223332 RVA: 0x0074CA88 File Offset: 0x0074AC88
		public ISkillBlackboardVector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E335 RID: 58165
		// (get) Token: 0x06036865 RID: 223333 RVA: 0x0074CA98 File Offset: 0x0074AC98
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036866 RID: 223334 RVA: 0x0074CACF File Offset: 0x0074ACCF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036867 RID: 223335 RVA: 0x0074CADE File Offset: 0x0074ACDE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E336 RID: 58166
		// (get) Token: 0x06036868 RID: 223336 RVA: 0x0074CAEC File Offset: 0x0074ACEC
		public IVectorInfo? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06036869 RID: 223337 RVA: 0x0074CB49 File Offset: 0x0074AD49
		public static Offset<ISkillBlackboardVector> CreateISkillBlackboardVector(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), Offset<IVectorInfo> ValueOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ISkillBlackboardVector.AddValue(builder, ValueOffset);
			ISkillBlackboardVector.AddKey(builder, KeyOffset);
			return ISkillBlackboardVector.EndISkillBlackboardVector(builder);
		}

		// Token: 0x0603686A RID: 223338 RVA: 0x0074CB66 File Offset: 0x0074AD66
		public static void StartISkillBlackboardVector(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603686B RID: 223339 RVA: 0x0074CB6F File Offset: 0x0074AD6F
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0603686C RID: 223340 RVA: 0x0074CB7F File Offset: 0x0074AD7F
		public static void AddValue(FlatBufferBuilder builder, Offset<IVectorInfo> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0603686D RID: 223341 RVA: 0x0074CB8F File Offset: 0x0074AD8F
		public static Offset<ISkillBlackboardVector> EndISkillBlackboardVector(FlatBufferBuilder builder)
		{
			return new Offset<ISkillBlackboardVector>(builder.EndTable());
		}

		// Token: 0x0603686E RID: 223342 RVA: 0x0074CB9C File Offset: 0x0074AD9C
		public ISkillBlackboardVectorT UnPack()
		{
			ISkillBlackboardVectorT skillBlackboardVectorT = new ISkillBlackboardVectorT();
			this.UnPackTo(skillBlackboardVectorT);
			return skillBlackboardVectorT;
		}

		// Token: 0x0603686F RID: 223343 RVA: 0x0074CBB8 File Offset: 0x0074ADB8
		public void UnPackTo(ISkillBlackboardVectorT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x06036870 RID: 223344 RVA: 0x0074CC00 File Offset: 0x0074AE00
		public static Offset<ISkillBlackboardVector> Pack(FlatBufferBuilder builder, ISkillBlackboardVectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillBlackboardVector>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			Offset<IVectorInfo> valueOffset = (_o.Value == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Value);
			return ISkillBlackboardVector.CreateISkillBlackboardVector(builder, keyOffset, valueOffset);
		}

		// Token: 0x04012BAC RID: 76716
		private Table __p;
	}
}
