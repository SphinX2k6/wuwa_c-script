using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A9B RID: 19099
	public struct IAddAllRole : IFlatbufferObject
	{
		// Token: 0x170085C8 RID: 34248
		// (get) Token: 0x0601CB4A RID: 117578 RVA: 0x0040C191 File Offset: 0x0040A391
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CB4B RID: 117579 RVA: 0x0040C19E File Offset: 0x0040A39E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CB4C RID: 117580 RVA: 0x0040C1A8 File Offset: 0x0040A3A8
		public static IAddAllRole GetRootAsIAddAllRole(ByteBuffer _bb)
		{
			return IAddAllRole.GetRootAsIAddAllRole(_bb, default(IAddAllRole));
		}

		// Token: 0x0601CB4D RID: 117581 RVA: 0x0040C1C4 File Offset: 0x0040A3C4
		public static IAddAllRole GetRootAsIAddAllRole(ByteBuffer _bb, IAddAllRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CB4E RID: 117582 RVA: 0x0040C1E1 File Offset: 0x0040A3E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CB4F RID: 117583 RVA: 0x0040C1F0 File Offset: 0x0040A3F0
		public IAddAllRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085C9 RID: 34249
		// (get) Token: 0x0601CB50 RID: 117584 RVA: 0x0040C200 File Offset: 0x0040A400
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

		// Token: 0x0601CB51 RID: 117585 RVA: 0x0040C23C File Offset: 0x0040A43C
		public static Offset<IAddAllRole> CreateIAddAllRole(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IAddAllRole.AddType(builder, Type);
			return IAddAllRole.EndIAddAllRole(builder);
		}

		// Token: 0x0601CB52 RID: 117586 RVA: 0x0040C252 File Offset: 0x0040A452
		public static void StartIAddAllRole(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CB53 RID: 117587 RVA: 0x0040C25B File Offset: 0x0040A45B
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CB54 RID: 117588 RVA: 0x0040C266 File Offset: 0x0040A466
		public static Offset<IAddAllRole> EndIAddAllRole(FlatBufferBuilder builder)
		{
			return new Offset<IAddAllRole>(builder.EndTable());
		}

		// Token: 0x0601CB55 RID: 117589 RVA: 0x0040C274 File Offset: 0x0040A474
		public IAddAllRoleT UnPack()
		{
			IAddAllRoleT addAllRoleT = new IAddAllRoleT();
			this.UnPackTo(addAllRoleT);
			return addAllRoleT;
		}

		// Token: 0x0601CB56 RID: 117590 RVA: 0x0040C28F File Offset: 0x0040A48F
		public void UnPackTo(IAddAllRoleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CB57 RID: 117591 RVA: 0x0040C2A0 File Offset: 0x0040A4A0
		public static Offset<IAddAllRole> Pack(FlatBufferBuilder builder, IAddAllRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddAllRole>);
			}
			return IAddAllRole.CreateIAddAllRole(builder, _o.Type);
		}

		// Token: 0x0400D1D9 RID: 53721
		private Table __p;
	}
}
