using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007127 RID: 28967
	public struct ISkillBlackboardVector : IFlatbufferObject
	{
		// Token: 0x1700D751 RID: 55121
		// (get) Token: 0x060335BD RID: 210365 RVA: 0x006EC41E File Offset: 0x006EA61E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060335BE RID: 210366 RVA: 0x006EC42B File Offset: 0x006EA62B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060335BF RID: 210367 RVA: 0x006EC434 File Offset: 0x006EA634
		public static ISkillBlackboardVector GetRootAsISkillBlackboardVector(ByteBuffer _bb)
		{
			return ISkillBlackboardVector.GetRootAsISkillBlackboardVector(_bb, default(ISkillBlackboardVector));
		}

		// Token: 0x060335C0 RID: 210368 RVA: 0x006EC450 File Offset: 0x006EA650
		public static ISkillBlackboardVector GetRootAsISkillBlackboardVector(ByteBuffer _bb, ISkillBlackboardVector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060335C1 RID: 210369 RVA: 0x006EC46D File Offset: 0x006EA66D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060335C2 RID: 210370 RVA: 0x006EC47C File Offset: 0x006EA67C
		public ISkillBlackboardVector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D752 RID: 55122
		// (get) Token: 0x060335C3 RID: 210371 RVA: 0x006EC48C File Offset: 0x006EA68C
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

		// Token: 0x060335C4 RID: 210372 RVA: 0x006EC4C3 File Offset: 0x006EA6C3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060335C5 RID: 210373 RVA: 0x006EC4D2 File Offset: 0x006EA6D2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D753 RID: 55123
		// (get) Token: 0x060335C6 RID: 210374 RVA: 0x006EC4E0 File Offset: 0x006EA6E0
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

		// Token: 0x060335C7 RID: 210375 RVA: 0x006EC53D File Offset: 0x006EA73D
		public static Offset<ISkillBlackboardVector> CreateISkillBlackboardVector(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), Offset<IVectorInfo> ValueOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ISkillBlackboardVector.AddValue(builder, ValueOffset);
			ISkillBlackboardVector.AddKey(builder, KeyOffset);
			return ISkillBlackboardVector.EndISkillBlackboardVector(builder);
		}

		// Token: 0x060335C8 RID: 210376 RVA: 0x006EC55A File Offset: 0x006EA75A
		public static void StartISkillBlackboardVector(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060335C9 RID: 210377 RVA: 0x006EC563 File Offset: 0x006EA763
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x060335CA RID: 210378 RVA: 0x006EC573 File Offset: 0x006EA773
		public static void AddValue(FlatBufferBuilder builder, Offset<IVectorInfo> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x060335CB RID: 210379 RVA: 0x006EC583 File Offset: 0x006EA783
		public static Offset<ISkillBlackboardVector> EndISkillBlackboardVector(FlatBufferBuilder builder)
		{
			return new Offset<ISkillBlackboardVector>(builder.EndTable());
		}

		// Token: 0x060335CC RID: 210380 RVA: 0x006EC590 File Offset: 0x006EA790
		public ISkillBlackboardVectorT UnPack()
		{
			ISkillBlackboardVectorT skillBlackboardVectorT = new ISkillBlackboardVectorT();
			this.UnPackTo(skillBlackboardVectorT);
			return skillBlackboardVectorT;
		}

		// Token: 0x060335CD RID: 210381 RVA: 0x006EC5AC File Offset: 0x006EA7AC
		public void UnPackTo(ISkillBlackboardVectorT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x060335CE RID: 210382 RVA: 0x006EC5F4 File Offset: 0x006EA7F4
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

		// Token: 0x04011BBE RID: 72638
		private Table __p;
	}
}
