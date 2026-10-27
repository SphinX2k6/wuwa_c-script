using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C28 RID: 19496
	public struct IFormationRoleInfoType : IFlatbufferObject
	{
		// Token: 0x17008DA5 RID: 36261
		// (get) Token: 0x0601EE41 RID: 126529 RVA: 0x00452BF8 File Offset: 0x00450DF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EE42 RID: 126530 RVA: 0x00452C05 File Offset: 0x00450E05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EE43 RID: 126531 RVA: 0x00452C0C File Offset: 0x00450E0C
		public static IFormationRoleInfoType GetRootAsIFormationRoleInfoType(ByteBuffer _bb)
		{
			return IFormationRoleInfoType.GetRootAsIFormationRoleInfoType(_bb, default(IFormationRoleInfoType));
		}

		// Token: 0x0601EE44 RID: 126532 RVA: 0x00452C28 File Offset: 0x00450E28
		public static IFormationRoleInfoType GetRootAsIFormationRoleInfoType(ByteBuffer _bb, IFormationRoleInfoType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EE45 RID: 126533 RVA: 0x00452C45 File Offset: 0x00450E45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EE46 RID: 126534 RVA: 0x00452C54 File Offset: 0x00450E54
		public IFormationRoleInfoType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DA6 RID: 36262
		// (get) Token: 0x0601EE47 RID: 126535 RVA: 0x00452C64 File Offset: 0x00450E64
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

		// Token: 0x0601EE48 RID: 126536 RVA: 0x00452CA0 File Offset: 0x00450EA0
		public static Offset<IFormationRoleInfoType> CreateIFormationRoleInfoType(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel)
		{
			builder.StartTable(1);
			IFormationRoleInfoType.AddType(builder, Type);
			return IFormationRoleInfoType.EndIFormationRoleInfoType(builder);
		}

		// Token: 0x0601EE49 RID: 126537 RVA: 0x00452CB6 File Offset: 0x00450EB6
		public static void StartIFormationRoleInfoType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EE4A RID: 126538 RVA: 0x00452CBF File Offset: 0x00450EBF
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EE4B RID: 126539 RVA: 0x00452CCA File Offset: 0x00450ECA
		public static Offset<IFormationRoleInfoType> EndIFormationRoleInfoType(FlatBufferBuilder builder)
		{
			return new Offset<IFormationRoleInfoType>(builder.EndTable());
		}

		// Token: 0x0601EE4C RID: 126540 RVA: 0x00452CD8 File Offset: 0x00450ED8
		public IFormationRoleInfoTypeT UnPack()
		{
			IFormationRoleInfoTypeT formationRoleInfoTypeT = new IFormationRoleInfoTypeT();
			this.UnPackTo(formationRoleInfoTypeT);
			return formationRoleInfoTypeT;
		}

		// Token: 0x0601EE4D RID: 126541 RVA: 0x00452CF3 File Offset: 0x00450EF3
		public void UnPackTo(IFormationRoleInfoTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EE4E RID: 126542 RVA: 0x00452D04 File Offset: 0x00450F04
		public static Offset<IFormationRoleInfoType> Pack(FlatBufferBuilder builder, IFormationRoleInfoTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFormationRoleInfoType>);
			}
			return IFormationRoleInfoType.CreateIFormationRoleInfoType(builder, _o.Type);
		}

		// Token: 0x0400D5C4 RID: 54724
		private Table __p;
	}
}
