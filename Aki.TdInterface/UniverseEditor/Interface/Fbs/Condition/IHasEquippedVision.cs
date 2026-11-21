using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005127 RID: 20775
	public struct IHasEquippedVision : IFlatbufferObject
	{
		// Token: 0x170094E1 RID: 38113
		// (get) Token: 0x06020AAB RID: 133803 RVA: 0x00487025 File Offset: 0x00485225
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020AAC RID: 133804 RVA: 0x00487032 File Offset: 0x00485232
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020AAD RID: 133805 RVA: 0x0048703C File Offset: 0x0048523C
		public static IHasEquippedVision GetRootAsIHasEquippedVision(ByteBuffer _bb)
		{
			return IHasEquippedVision.GetRootAsIHasEquippedVision(_bb, default(IHasEquippedVision));
		}

		// Token: 0x06020AAE RID: 133806 RVA: 0x00487058 File Offset: 0x00485258
		public static IHasEquippedVision GetRootAsIHasEquippedVision(ByteBuffer _bb, IHasEquippedVision obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020AAF RID: 133807 RVA: 0x00487075 File Offset: 0x00485275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020AB0 RID: 133808 RVA: 0x00487084 File Offset: 0x00485284
		public IHasEquippedVision __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094E2 RID: 38114
		// (get) Token: 0x06020AB1 RID: 133809 RVA: 0x00487094 File Offset: 0x00485294
		public EFormationRoleInfoType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFormationRoleInfoType.RoleLevel;
				}
				return (EFormationRoleInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094E3 RID: 38115
		// (get) Token: 0x06020AB2 RID: 133810 RVA: 0x004870D0 File Offset: 0x004852D0
		public EHasEquippedVisionType Option
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EHasEquippedVisionType.AnyRole;
				}
				return (EHasEquippedVisionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020AB3 RID: 133811 RVA: 0x0048710C File Offset: 0x0048530C
		public static Offset<IHasEquippedVision> CreateIHasEquippedVision(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel, EHasEquippedVisionType Option = EHasEquippedVisionType.AnyRole)
		{
			builder.StartTable(2);
			IHasEquippedVision.AddOption(builder, Option);
			IHasEquippedVision.AddType(builder, Type);
			return IHasEquippedVision.EndIHasEquippedVision(builder);
		}

		// Token: 0x06020AB4 RID: 133812 RVA: 0x00487129 File Offset: 0x00485329
		public static void StartIHasEquippedVision(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020AB5 RID: 133813 RVA: 0x00487132 File Offset: 0x00485332
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020AB6 RID: 133814 RVA: 0x0048713D File Offset: 0x0048533D
		public static void AddOption(FlatBufferBuilder builder, EHasEquippedVisionType option)
		{
			builder.AddByte(1, (byte)option, 0);
		}

		// Token: 0x06020AB7 RID: 133815 RVA: 0x00487148 File Offset: 0x00485348
		public static Offset<IHasEquippedVision> EndIHasEquippedVision(FlatBufferBuilder builder)
		{
			return new Offset<IHasEquippedVision>(builder.EndTable());
		}

		// Token: 0x06020AB8 RID: 133816 RVA: 0x00487158 File Offset: 0x00485358
		public IHasEquippedVisionT UnPack()
		{
			IHasEquippedVisionT hasEquippedVisionT = new IHasEquippedVisionT();
			this.UnPackTo(hasEquippedVisionT);
			return hasEquippedVisionT;
		}

		// Token: 0x06020AB9 RID: 133817 RVA: 0x00487173 File Offset: 0x00485373
		public void UnPackTo(IHasEquippedVisionT _o)
		{
			_o.Type = this.Type;
			_o.Option = this.Option;
		}

		// Token: 0x06020ABA RID: 133818 RVA: 0x00487190 File Offset: 0x00485390
		public static Offset<IHasEquippedVision> Pack(FlatBufferBuilder builder, IHasEquippedVisionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHasEquippedVision>);
			}
			return IHasEquippedVision.CreateIHasEquippedVision(builder, _o.Type, _o.Option);
		}

		// Token: 0x0400E0F7 RID: 57591
		private Table __p;
	}
}
