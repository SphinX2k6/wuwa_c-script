using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200512A RID: 20778
	public struct IHasUpgradableVision : IFlatbufferObject
	{
		// Token: 0x170094E6 RID: 38118
		// (get) Token: 0x06020AC1 RID: 133825 RVA: 0x00487226 File Offset: 0x00485426
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020AC2 RID: 133826 RVA: 0x00487233 File Offset: 0x00485433
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020AC3 RID: 133827 RVA: 0x0048723C File Offset: 0x0048543C
		public static IHasUpgradableVision GetRootAsIHasUpgradableVision(ByteBuffer _bb)
		{
			return IHasUpgradableVision.GetRootAsIHasUpgradableVision(_bb, default(IHasUpgradableVision));
		}

		// Token: 0x06020AC4 RID: 133828 RVA: 0x00487258 File Offset: 0x00485458
		public static IHasUpgradableVision GetRootAsIHasUpgradableVision(ByteBuffer _bb, IHasUpgradableVision obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020AC5 RID: 133829 RVA: 0x00487275 File Offset: 0x00485475
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020AC6 RID: 133830 RVA: 0x00487284 File Offset: 0x00485484
		public IHasUpgradableVision __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094E7 RID: 38119
		// (get) Token: 0x06020AC7 RID: 133831 RVA: 0x00487294 File Offset: 0x00485494
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

		// Token: 0x170094E8 RID: 38120
		// (get) Token: 0x06020AC8 RID: 133832 RVA: 0x004872D0 File Offset: 0x004854D0
		public EHasUpgradableVisionType Option
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EHasUpgradableVisionType.AnyRole;
				}
				return (EHasUpgradableVisionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020AC9 RID: 133833 RVA: 0x0048730C File Offset: 0x0048550C
		public static Offset<IHasUpgradableVision> CreateIHasUpgradableVision(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel, EHasUpgradableVisionType Option = EHasUpgradableVisionType.AnyRole)
		{
			builder.StartTable(2);
			IHasUpgradableVision.AddOption(builder, Option);
			IHasUpgradableVision.AddType(builder, Type);
			return IHasUpgradableVision.EndIHasUpgradableVision(builder);
		}

		// Token: 0x06020ACA RID: 133834 RVA: 0x00487329 File Offset: 0x00485529
		public static void StartIHasUpgradableVision(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020ACB RID: 133835 RVA: 0x00487332 File Offset: 0x00485532
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020ACC RID: 133836 RVA: 0x0048733D File Offset: 0x0048553D
		public static void AddOption(FlatBufferBuilder builder, EHasUpgradableVisionType option)
		{
			builder.AddByte(1, (byte)option, 0);
		}

		// Token: 0x06020ACD RID: 133837 RVA: 0x00487348 File Offset: 0x00485548
		public static Offset<IHasUpgradableVision> EndIHasUpgradableVision(FlatBufferBuilder builder)
		{
			return new Offset<IHasUpgradableVision>(builder.EndTable());
		}

		// Token: 0x06020ACE RID: 133838 RVA: 0x00487358 File Offset: 0x00485558
		public IHasUpgradableVisionT UnPack()
		{
			IHasUpgradableVisionT hasUpgradableVisionT = new IHasUpgradableVisionT();
			this.UnPackTo(hasUpgradableVisionT);
			return hasUpgradableVisionT;
		}

		// Token: 0x06020ACF RID: 133839 RVA: 0x00487373 File Offset: 0x00485573
		public void UnPackTo(IHasUpgradableVisionT _o)
		{
			_o.Type = this.Type;
			_o.Option = this.Option;
		}

		// Token: 0x06020AD0 RID: 133840 RVA: 0x00487390 File Offset: 0x00485590
		public static Offset<IHasUpgradableVision> Pack(FlatBufferBuilder builder, IHasUpgradableVisionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHasUpgradableVision>);
			}
			return IHasUpgradableVision.CreateIHasUpgradableVision(builder, _o.Type, _o.Option);
		}

		// Token: 0x0400E0FA RID: 57594
		private Table __p;
	}
}
