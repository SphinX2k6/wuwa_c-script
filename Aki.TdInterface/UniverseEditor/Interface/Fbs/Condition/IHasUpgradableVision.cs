using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C37 RID: 19511
	public struct IHasUpgradableVision : IFlatbufferObject
	{
		// Token: 0x17008DBD RID: 36285
		// (get) Token: 0x0601EEBD RID: 126653 RVA: 0x0045394A File Offset: 0x00451B4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EEBE RID: 126654 RVA: 0x00453957 File Offset: 0x00451B57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EEBF RID: 126655 RVA: 0x00453960 File Offset: 0x00451B60
		public static IHasUpgradableVision GetRootAsIHasUpgradableVision(ByteBuffer _bb)
		{
			return IHasUpgradableVision.GetRootAsIHasUpgradableVision(_bb, default(IHasUpgradableVision));
		}

		// Token: 0x0601EEC0 RID: 126656 RVA: 0x0045397C File Offset: 0x00451B7C
		public static IHasUpgradableVision GetRootAsIHasUpgradableVision(ByteBuffer _bb, IHasUpgradableVision obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EEC1 RID: 126657 RVA: 0x00453999 File Offset: 0x00451B99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EEC2 RID: 126658 RVA: 0x004539A8 File Offset: 0x00451BA8
		public IHasUpgradableVision __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DBE RID: 36286
		// (get) Token: 0x0601EEC3 RID: 126659 RVA: 0x004539B8 File Offset: 0x00451BB8
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

		// Token: 0x17008DBF RID: 36287
		// (get) Token: 0x0601EEC4 RID: 126660 RVA: 0x004539F4 File Offset: 0x00451BF4
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

		// Token: 0x0601EEC5 RID: 126661 RVA: 0x00453A30 File Offset: 0x00451C30
		public static Offset<IHasUpgradableVision> CreateIHasUpgradableVision(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel, EHasUpgradableVisionType Option = EHasUpgradableVisionType.AnyRole)
		{
			builder.StartTable(2);
			IHasUpgradableVision.AddOption(builder, Option);
			IHasUpgradableVision.AddType(builder, Type);
			return IHasUpgradableVision.EndIHasUpgradableVision(builder);
		}

		// Token: 0x0601EEC6 RID: 126662 RVA: 0x00453A4D File Offset: 0x00451C4D
		public static void StartIHasUpgradableVision(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EEC7 RID: 126663 RVA: 0x00453A56 File Offset: 0x00451C56
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EEC8 RID: 126664 RVA: 0x00453A61 File Offset: 0x00451C61
		public static void AddOption(FlatBufferBuilder builder, EHasUpgradableVisionType option)
		{
			builder.AddByte(1, (byte)option, 0);
		}

		// Token: 0x0601EEC9 RID: 126665 RVA: 0x00453A6C File Offset: 0x00451C6C
		public static Offset<IHasUpgradableVision> EndIHasUpgradableVision(FlatBufferBuilder builder)
		{
			return new Offset<IHasUpgradableVision>(builder.EndTable());
		}

		// Token: 0x0601EECA RID: 126666 RVA: 0x00453A7C File Offset: 0x00451C7C
		public IHasUpgradableVisionT UnPack()
		{
			IHasUpgradableVisionT hasUpgradableVisionT = new IHasUpgradableVisionT();
			this.UnPackTo(hasUpgradableVisionT);
			return hasUpgradableVisionT;
		}

		// Token: 0x0601EECB RID: 126667 RVA: 0x00453A97 File Offset: 0x00451C97
		public void UnPackTo(IHasUpgradableVisionT _o)
		{
			_o.Type = this.Type;
			_o.Option = this.Option;
		}

		// Token: 0x0601EECC RID: 126668 RVA: 0x00453AB4 File Offset: 0x00451CB4
		public static Offset<IHasUpgradableVision> Pack(FlatBufferBuilder builder, IHasUpgradableVisionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHasUpgradableVision>);
			}
			return IHasUpgradableVision.CreateIHasUpgradableVision(builder, _o.Type, _o.Option);
		}

		// Token: 0x0400D5DB RID: 54747
		private Table __p;
	}
}
