using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200511B RID: 20763
	public struct IFormationRoleInfoType : IFlatbufferObject
	{
		// Token: 0x170094CE RID: 38094
		// (get) Token: 0x06020A45 RID: 133701 RVA: 0x004864D4 File Offset: 0x004846D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020A46 RID: 133702 RVA: 0x004864E1 File Offset: 0x004846E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020A47 RID: 133703 RVA: 0x004864E8 File Offset: 0x004846E8
		public static IFormationRoleInfoType GetRootAsIFormationRoleInfoType(ByteBuffer _bb)
		{
			return IFormationRoleInfoType.GetRootAsIFormationRoleInfoType(_bb, default(IFormationRoleInfoType));
		}

		// Token: 0x06020A48 RID: 133704 RVA: 0x00486504 File Offset: 0x00484704
		public static IFormationRoleInfoType GetRootAsIFormationRoleInfoType(ByteBuffer _bb, IFormationRoleInfoType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020A49 RID: 133705 RVA: 0x00486521 File Offset: 0x00484721
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020A4A RID: 133706 RVA: 0x00486530 File Offset: 0x00484730
		public IFormationRoleInfoType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094CF RID: 38095
		// (get) Token: 0x06020A4B RID: 133707 RVA: 0x00486540 File Offset: 0x00484740
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

		// Token: 0x06020A4C RID: 133708 RVA: 0x0048657C File Offset: 0x0048477C
		public static Offset<IFormationRoleInfoType> CreateIFormationRoleInfoType(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel)
		{
			builder.StartTable(1);
			IFormationRoleInfoType.AddType(builder, Type);
			return IFormationRoleInfoType.EndIFormationRoleInfoType(builder);
		}

		// Token: 0x06020A4D RID: 133709 RVA: 0x00486592 File Offset: 0x00484792
		public static void StartIFormationRoleInfoType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020A4E RID: 133710 RVA: 0x0048659B File Offset: 0x0048479B
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020A4F RID: 133711 RVA: 0x004865A6 File Offset: 0x004847A6
		public static Offset<IFormationRoleInfoType> EndIFormationRoleInfoType(FlatBufferBuilder builder)
		{
			return new Offset<IFormationRoleInfoType>(builder.EndTable());
		}

		// Token: 0x06020A50 RID: 133712 RVA: 0x004865B4 File Offset: 0x004847B4
		public IFormationRoleInfoTypeT UnPack()
		{
			IFormationRoleInfoTypeT formationRoleInfoTypeT = new IFormationRoleInfoTypeT();
			this.UnPackTo(formationRoleInfoTypeT);
			return formationRoleInfoTypeT;
		}

		// Token: 0x06020A51 RID: 133713 RVA: 0x004865CF File Offset: 0x004847CF
		public void UnPackTo(IFormationRoleInfoTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020A52 RID: 133714 RVA: 0x004865E0 File Offset: 0x004847E0
		public static Offset<IFormationRoleInfoType> Pack(FlatBufferBuilder builder, IFormationRoleInfoTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFormationRoleInfoType>);
			}
			return IFormationRoleInfoType.CreateIFormationRoleInfoType(builder, _o.Type);
		}

		// Token: 0x0400E0E3 RID: 57571
		private Table __p;
	}
}
