using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051AB RID: 20907
	public struct IRoleLevel : IFlatbufferObject
	{
		// Token: 0x170095C0 RID: 38336
		// (get) Token: 0x06020E97 RID: 134807 RVA: 0x0048D8FE File Offset: 0x0048BAFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020E98 RID: 134808 RVA: 0x0048D90B File Offset: 0x0048BB0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020E99 RID: 134809 RVA: 0x0048D914 File Offset: 0x0048BB14
		public static IRoleLevel GetRootAsIRoleLevel(ByteBuffer _bb)
		{
			return IRoleLevel.GetRootAsIRoleLevel(_bb, default(IRoleLevel));
		}

		// Token: 0x06020E9A RID: 134810 RVA: 0x0048D930 File Offset: 0x0048BB30
		public static IRoleLevel GetRootAsIRoleLevel(ByteBuffer _bb, IRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E9B RID: 134811 RVA: 0x0048D94D File Offset: 0x0048BB4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E9C RID: 134812 RVA: 0x0048D95C File Offset: 0x0048BB5C
		public IRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095C1 RID: 38337
		// (get) Token: 0x06020E9D RID: 134813 RVA: 0x0048D96C File Offset: 0x0048BB6C
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

		// Token: 0x170095C2 RID: 38338
		// (get) Token: 0x06020E9E RID: 134814 RVA: 0x0048D9A8 File Offset: 0x0048BBA8
		public ISpecifyRoleLevel? Option
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISpecifyRoleLevel?(default(ISpecifyRoleLevel).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06020E9F RID: 134815 RVA: 0x0048DA05 File Offset: 0x0048BC05
		public static Offset<IRoleLevel> CreateIRoleLevel(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel, Offset<ISpecifyRoleLevel> OptionOffset = default(Offset<ISpecifyRoleLevel>))
		{
			builder.StartTable(2);
			IRoleLevel.AddOption(builder, OptionOffset);
			IRoleLevel.AddType(builder, Type);
			return IRoleLevel.EndIRoleLevel(builder);
		}

		// Token: 0x06020EA0 RID: 134816 RVA: 0x0048DA22 File Offset: 0x0048BC22
		public static void StartIRoleLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020EA1 RID: 134817 RVA: 0x0048DA2B File Offset: 0x0048BC2B
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020EA2 RID: 134818 RVA: 0x0048DA36 File Offset: 0x0048BC36
		public static void AddOption(FlatBufferBuilder builder, Offset<ISpecifyRoleLevel> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x06020EA3 RID: 134819 RVA: 0x0048DA46 File Offset: 0x0048BC46
		public static Offset<IRoleLevel> EndIRoleLevel(FlatBufferBuilder builder)
		{
			return new Offset<IRoleLevel>(builder.EndTable());
		}

		// Token: 0x06020EA4 RID: 134820 RVA: 0x0048DA54 File Offset: 0x0048BC54
		public IRoleLevelT UnPack()
		{
			IRoleLevelT roleLevelT = new IRoleLevelT();
			this.UnPackTo(roleLevelT);
			return roleLevelT;
		}

		// Token: 0x06020EA5 RID: 134821 RVA: 0x0048DA70 File Offset: 0x0048BC70
		public void UnPackTo(IRoleLevelT _o)
		{
			_o.Type = this.Type;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x06020EA6 RID: 134822 RVA: 0x0048DAB8 File Offset: 0x0048BCB8
		public static Offset<IRoleLevel> Pack(FlatBufferBuilder builder, IRoleLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleLevel>);
			}
			Offset<ISpecifyRoleLevel> optionOffset = (_o.Option == null) ? default(Offset<ISpecifyRoleLevel>) : ISpecifyRoleLevel.Pack(builder, _o.Option);
			return IRoleLevel.CreateIRoleLevel(builder, _o.Type, optionOffset);
		}

		// Token: 0x0400E19C RID: 57756
		private Table __p;
	}
}
