using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E89 RID: 24201
	public struct IRoleMotionInteractType : IFlatbufferObject
	{
		// Token: 0x1700B29D RID: 45725
		// (get) Token: 0x06028814 RID: 165908 RVA: 0x00589E0B File Offset: 0x0058800B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028815 RID: 165909 RVA: 0x00589E18 File Offset: 0x00588018
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028816 RID: 165910 RVA: 0x00589E20 File Offset: 0x00588020
		public static IRoleMotionInteractType GetRootAsIRoleMotionInteractType(ByteBuffer _bb)
		{
			return IRoleMotionInteractType.GetRootAsIRoleMotionInteractType(_bb, default(IRoleMotionInteractType));
		}

		// Token: 0x06028817 RID: 165911 RVA: 0x00589E3C File Offset: 0x0058803C
		public static IRoleMotionInteractType GetRootAsIRoleMotionInteractType(ByteBuffer _bb, IRoleMotionInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028818 RID: 165912 RVA: 0x00589E59 File Offset: 0x00588059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028819 RID: 165913 RVA: 0x00589E68 File Offset: 0x00588068
		public IRoleMotionInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B29E RID: 45726
		// (get) Token: 0x0602881A RID: 165914 RVA: 0x00589E78 File Offset: 0x00588078
		public ERoleMotionInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleMotionInteractType.PetalGrab;
				}
				return (ERoleMotionInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602881B RID: 165915 RVA: 0x00589EB4 File Offset: 0x005880B4
		public static Offset<IRoleMotionInteractType> CreateIRoleMotionInteractType(FlatBufferBuilder builder, ERoleMotionInteractType Type = ERoleMotionInteractType.PetalGrab)
		{
			builder.StartTable(1);
			IRoleMotionInteractType.AddType(builder, Type);
			return IRoleMotionInteractType.EndIRoleMotionInteractType(builder);
		}

		// Token: 0x0602881C RID: 165916 RVA: 0x00589ECA File Offset: 0x005880CA
		public static void StartIRoleMotionInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602881D RID: 165917 RVA: 0x00589ED3 File Offset: 0x005880D3
		public static void AddType(FlatBufferBuilder builder, ERoleMotionInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602881E RID: 165918 RVA: 0x00589EDE File Offset: 0x005880DE
		public static Offset<IRoleMotionInteractType> EndIRoleMotionInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IRoleMotionInteractType>(builder.EndTable());
		}

		// Token: 0x0602881F RID: 165919 RVA: 0x00589EEC File Offset: 0x005880EC
		public IRoleMotionInteractTypeT UnPack()
		{
			IRoleMotionInteractTypeT roleMotionInteractTypeT = new IRoleMotionInteractTypeT();
			this.UnPackTo(roleMotionInteractTypeT);
			return roleMotionInteractTypeT;
		}

		// Token: 0x06028820 RID: 165920 RVA: 0x00589F07 File Offset: 0x00588107
		public void UnPackTo(IRoleMotionInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028821 RID: 165921 RVA: 0x00589F18 File Offset: 0x00588118
		public static Offset<IRoleMotionInteractType> Pack(FlatBufferBuilder builder, IRoleMotionInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleMotionInteractType>);
			}
			return IRoleMotionInteractType.CreateIRoleMotionInteractType(builder, _o.Type);
		}

		// Token: 0x0400FAB8 RID: 64184
		private Table __p;
	}
}
