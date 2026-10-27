using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C34 RID: 19508
	public struct IHasEquippedVision : IFlatbufferObject
	{
		// Token: 0x17008DB8 RID: 36280
		// (get) Token: 0x0601EEA7 RID: 126631 RVA: 0x00453749 File Offset: 0x00451949
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EEA8 RID: 126632 RVA: 0x00453756 File Offset: 0x00451956
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EEA9 RID: 126633 RVA: 0x00453760 File Offset: 0x00451960
		public static IHasEquippedVision GetRootAsIHasEquippedVision(ByteBuffer _bb)
		{
			return IHasEquippedVision.GetRootAsIHasEquippedVision(_bb, default(IHasEquippedVision));
		}

		// Token: 0x0601EEAA RID: 126634 RVA: 0x0045377C File Offset: 0x0045197C
		public static IHasEquippedVision GetRootAsIHasEquippedVision(ByteBuffer _bb, IHasEquippedVision obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EEAB RID: 126635 RVA: 0x00453799 File Offset: 0x00451999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EEAC RID: 126636 RVA: 0x004537A8 File Offset: 0x004519A8
		public IHasEquippedVision __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DB9 RID: 36281
		// (get) Token: 0x0601EEAD RID: 126637 RVA: 0x004537B8 File Offset: 0x004519B8
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

		// Token: 0x17008DBA RID: 36282
		// (get) Token: 0x0601EEAE RID: 126638 RVA: 0x004537F4 File Offset: 0x004519F4
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

		// Token: 0x0601EEAF RID: 126639 RVA: 0x00453830 File Offset: 0x00451A30
		public static Offset<IHasEquippedVision> CreateIHasEquippedVision(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel, EHasEquippedVisionType Option = EHasEquippedVisionType.AnyRole)
		{
			builder.StartTable(2);
			IHasEquippedVision.AddOption(builder, Option);
			IHasEquippedVision.AddType(builder, Type);
			return IHasEquippedVision.EndIHasEquippedVision(builder);
		}

		// Token: 0x0601EEB0 RID: 126640 RVA: 0x0045384D File Offset: 0x00451A4D
		public static void StartIHasEquippedVision(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EEB1 RID: 126641 RVA: 0x00453856 File Offset: 0x00451A56
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EEB2 RID: 126642 RVA: 0x00453861 File Offset: 0x00451A61
		public static void AddOption(FlatBufferBuilder builder, EHasEquippedVisionType option)
		{
			builder.AddByte(1, (byte)option, 0);
		}

		// Token: 0x0601EEB3 RID: 126643 RVA: 0x0045386C File Offset: 0x00451A6C
		public static Offset<IHasEquippedVision> EndIHasEquippedVision(FlatBufferBuilder builder)
		{
			return new Offset<IHasEquippedVision>(builder.EndTable());
		}

		// Token: 0x0601EEB4 RID: 126644 RVA: 0x0045387C File Offset: 0x00451A7C
		public IHasEquippedVisionT UnPack()
		{
			IHasEquippedVisionT hasEquippedVisionT = new IHasEquippedVisionT();
			this.UnPackTo(hasEquippedVisionT);
			return hasEquippedVisionT;
		}

		// Token: 0x0601EEB5 RID: 126645 RVA: 0x00453897 File Offset: 0x00451A97
		public void UnPackTo(IHasEquippedVisionT _o)
		{
			_o.Type = this.Type;
			_o.Option = this.Option;
		}

		// Token: 0x0601EEB6 RID: 126646 RVA: 0x004538B4 File Offset: 0x00451AB4
		public static Offset<IHasEquippedVision> Pack(FlatBufferBuilder builder, IHasEquippedVisionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHasEquippedVision>);
			}
			return IHasEquippedVision.CreateIHasEquippedVision(builder, _o.Type, _o.Option);
		}

		// Token: 0x0400D5D8 RID: 54744
		private Table __p;
	}
}
