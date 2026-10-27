using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004633 RID: 17971
	public struct IAddAllRole : IFlatbufferObject
	{
		// Token: 0x17007F87 RID: 32647
		// (get) Token: 0x0601B375 RID: 111477 RVA: 0x003DFEF5 File Offset: 0x003DE0F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B376 RID: 111478 RVA: 0x003DFF02 File Offset: 0x003DE102
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B377 RID: 111479 RVA: 0x003DFF0C File Offset: 0x003DE10C
		public static IAddAllRole GetRootAsIAddAllRole(ByteBuffer _bb)
		{
			return IAddAllRole.GetRootAsIAddAllRole(_bb, default(IAddAllRole));
		}

		// Token: 0x0601B378 RID: 111480 RVA: 0x003DFF28 File Offset: 0x003DE128
		public static IAddAllRole GetRootAsIAddAllRole(ByteBuffer _bb, IAddAllRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B379 RID: 111481 RVA: 0x003DFF45 File Offset: 0x003DE145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B37A RID: 111482 RVA: 0x003DFF54 File Offset: 0x003DE154
		public IAddAllRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F88 RID: 32648
		// (get) Token: 0x0601B37B RID: 111483 RVA: 0x003DFF64 File Offset: 0x003DE164
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B37C RID: 111484 RVA: 0x003DFFA0 File Offset: 0x003DE1A0
		public static Offset<IAddAllRole> CreateIAddAllRole(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IAddAllRole.AddType(builder, Type);
			return IAddAllRole.EndIAddAllRole(builder);
		}

		// Token: 0x0601B37D RID: 111485 RVA: 0x003DFFB6 File Offset: 0x003DE1B6
		public static void StartIAddAllRole(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B37E RID: 111486 RVA: 0x003DFFBF File Offset: 0x003DE1BF
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B37F RID: 111487 RVA: 0x003DFFCA File Offset: 0x003DE1CA
		public static Offset<IAddAllRole> EndIAddAllRole(FlatBufferBuilder builder)
		{
			return new Offset<IAddAllRole>(builder.EndTable());
		}

		// Token: 0x0601B380 RID: 111488 RVA: 0x003DFFD8 File Offset: 0x003DE1D8
		public IAddAllRoleT UnPack()
		{
			IAddAllRoleT addAllRoleT = new IAddAllRoleT();
			this.UnPackTo(addAllRoleT);
			return addAllRoleT;
		}

		// Token: 0x0601B381 RID: 111489 RVA: 0x003DFFF3 File Offset: 0x003DE1F3
		public void UnPackTo(IAddAllRoleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B382 RID: 111490 RVA: 0x003E0004 File Offset: 0x003DE204
		public static Offset<IAddAllRole> Pack(FlatBufferBuilder builder, IAddAllRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddAllRole>);
			}
			return IAddAllRole.CreateIAddAllRole(builder, _o.Type);
		}

		// Token: 0x0400C7AA RID: 51114
		private Table __p;
	}
}
