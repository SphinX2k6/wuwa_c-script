using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007130 RID: 28976
	public struct ISkillOperationType : IFlatbufferObject
	{
		// Token: 0x1700D75B RID: 55131
		// (get) Token: 0x060335F3 RID: 210419 RVA: 0x006EC952 File Offset: 0x006EAB52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060335F4 RID: 210420 RVA: 0x006EC95F File Offset: 0x006EAB5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060335F5 RID: 210421 RVA: 0x006EC968 File Offset: 0x006EAB68
		public static ISkillOperationType GetRootAsISkillOperationType(ByteBuffer _bb)
		{
			return ISkillOperationType.GetRootAsISkillOperationType(_bb, default(ISkillOperationType));
		}

		// Token: 0x060335F6 RID: 210422 RVA: 0x006EC984 File Offset: 0x006EAB84
		public static ISkillOperationType GetRootAsISkillOperationType(ByteBuffer _bb, ISkillOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060335F7 RID: 210423 RVA: 0x006EC9A1 File Offset: 0x006EABA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060335F8 RID: 210424 RVA: 0x006EC9B0 File Offset: 0x006EABB0
		public ISkillOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D75C RID: 55132
		// (get) Token: 0x060335F9 RID: 210425 RVA: 0x006EC9C0 File Offset: 0x006EABC0
		public ESkillOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillOperationType.Enable;
				}
				return (ESkillOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060335FA RID: 210426 RVA: 0x006EC9FC File Offset: 0x006EABFC
		public static Offset<ISkillOperationType> CreateISkillOperationType(FlatBufferBuilder builder, ESkillOperationType Type = ESkillOperationType.Enable)
		{
			builder.StartTable(1);
			ISkillOperationType.AddType(builder, Type);
			return ISkillOperationType.EndISkillOperationType(builder);
		}

		// Token: 0x060335FB RID: 210427 RVA: 0x006ECA12 File Offset: 0x006EAC12
		public static void StartISkillOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060335FC RID: 210428 RVA: 0x006ECA1B File Offset: 0x006EAC1B
		public static void AddType(FlatBufferBuilder builder, ESkillOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060335FD RID: 210429 RVA: 0x006ECA26 File Offset: 0x006EAC26
		public static Offset<ISkillOperationType> EndISkillOperationType(FlatBufferBuilder builder)
		{
			return new Offset<ISkillOperationType>(builder.EndTable());
		}

		// Token: 0x060335FE RID: 210430 RVA: 0x006ECA34 File Offset: 0x006EAC34
		public ISkillOperationTypeT UnPack()
		{
			ISkillOperationTypeT skillOperationTypeT = new ISkillOperationTypeT();
			this.UnPackTo(skillOperationTypeT);
			return skillOperationTypeT;
		}

		// Token: 0x060335FF RID: 210431 RVA: 0x006ECA4F File Offset: 0x006EAC4F
		public void UnPackTo(ISkillOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033600 RID: 210432 RVA: 0x006ECA60 File Offset: 0x006EAC60
		public static Offset<ISkillOperationType> Pack(FlatBufferBuilder builder, ISkillOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillOperationType>);
			}
			return ISkillOperationType.CreateISkillOperationType(builder, _o.Type);
		}

		// Token: 0x04011BC9 RID: 72649
		private Table __p;
	}
}
