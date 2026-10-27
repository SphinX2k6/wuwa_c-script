using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CB2 RID: 19634
	public struct IRoleLevel : IFlatbufferObject
	{
		// Token: 0x17008E92 RID: 36498
		// (get) Token: 0x0601F275 RID: 127605 RVA: 0x00459DAE File Offset: 0x00457FAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F276 RID: 127606 RVA: 0x00459DBB File Offset: 0x00457FBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F277 RID: 127607 RVA: 0x00459DC4 File Offset: 0x00457FC4
		public static IRoleLevel GetRootAsIRoleLevel(ByteBuffer _bb)
		{
			return IRoleLevel.GetRootAsIRoleLevel(_bb, default(IRoleLevel));
		}

		// Token: 0x0601F278 RID: 127608 RVA: 0x00459DE0 File Offset: 0x00457FE0
		public static IRoleLevel GetRootAsIRoleLevel(ByteBuffer _bb, IRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F279 RID: 127609 RVA: 0x00459DFD File Offset: 0x00457FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F27A RID: 127610 RVA: 0x00459E0C File Offset: 0x0045800C
		public IRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E93 RID: 36499
		// (get) Token: 0x0601F27B RID: 127611 RVA: 0x00459E1C File Offset: 0x0045801C
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

		// Token: 0x17008E94 RID: 36500
		// (get) Token: 0x0601F27C RID: 127612 RVA: 0x00459E58 File Offset: 0x00458058
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

		// Token: 0x0601F27D RID: 127613 RVA: 0x00459EB5 File Offset: 0x004580B5
		public static Offset<IRoleLevel> CreateIRoleLevel(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel, Offset<ISpecifyRoleLevel> OptionOffset = default(Offset<ISpecifyRoleLevel>))
		{
			builder.StartTable(2);
			IRoleLevel.AddOption(builder, OptionOffset);
			IRoleLevel.AddType(builder, Type);
			return IRoleLevel.EndIRoleLevel(builder);
		}

		// Token: 0x0601F27E RID: 127614 RVA: 0x00459ED2 File Offset: 0x004580D2
		public static void StartIRoleLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F27F RID: 127615 RVA: 0x00459EDB File Offset: 0x004580DB
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F280 RID: 127616 RVA: 0x00459EE6 File Offset: 0x004580E6
		public static void AddOption(FlatBufferBuilder builder, Offset<ISpecifyRoleLevel> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x0601F281 RID: 127617 RVA: 0x00459EF6 File Offset: 0x004580F6
		public static Offset<IRoleLevel> EndIRoleLevel(FlatBufferBuilder builder)
		{
			return new Offset<IRoleLevel>(builder.EndTable());
		}

		// Token: 0x0601F282 RID: 127618 RVA: 0x00459F04 File Offset: 0x00458104
		public IRoleLevelT UnPack()
		{
			IRoleLevelT roleLevelT = new IRoleLevelT();
			this.UnPackTo(roleLevelT);
			return roleLevelT;
		}

		// Token: 0x0601F283 RID: 127619 RVA: 0x00459F20 File Offset: 0x00458120
		public void UnPackTo(IRoleLevelT _o)
		{
			_o.Type = this.Type;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x0601F284 RID: 127620 RVA: 0x00459F68 File Offset: 0x00458168
		public static Offset<IRoleLevel> Pack(FlatBufferBuilder builder, IRoleLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleLevel>);
			}
			Offset<ISpecifyRoleLevel> optionOffset = (_o.Option == null) ? default(Offset<ISpecifyRoleLevel>) : ISpecifyRoleLevel.Pack(builder, _o.Option);
			return IRoleLevel.CreateIRoleLevel(builder, _o.Type, optionOffset);
		}

		// Token: 0x0400D675 RID: 54901
		private Table __p;
	}
}
