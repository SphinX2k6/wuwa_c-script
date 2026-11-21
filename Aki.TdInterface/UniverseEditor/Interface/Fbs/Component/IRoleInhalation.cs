using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E83 RID: 24195
	public struct IRoleInhalation : IFlatbufferObject
	{
		// Token: 0x1700B293 RID: 45715
		// (get) Token: 0x060287E8 RID: 165864 RVA: 0x00589976 File Offset: 0x00587B76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060287E9 RID: 165865 RVA: 0x00589983 File Offset: 0x00587B83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060287EA RID: 165866 RVA: 0x0058998C File Offset: 0x00587B8C
		public static IRoleInhalation GetRootAsIRoleInhalation(ByteBuffer _bb)
		{
			return IRoleInhalation.GetRootAsIRoleInhalation(_bb, default(IRoleInhalation));
		}

		// Token: 0x060287EB RID: 165867 RVA: 0x005899A8 File Offset: 0x00587BA8
		public static IRoleInhalation GetRootAsIRoleInhalation(ByteBuffer _bb, IRoleInhalation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060287EC RID: 165868 RVA: 0x005899C5 File Offset: 0x00587BC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060287ED RID: 165869 RVA: 0x005899D4 File Offset: 0x00587BD4
		public IRoleInhalation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B294 RID: 45716
		// (get) Token: 0x060287EE RID: 165870 RVA: 0x005899E4 File Offset: 0x00587BE4
		public EInhalationPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInhalationPerformanceType.Role;
				}
				return (EInhalationPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060287EF RID: 165871 RVA: 0x00589A20 File Offset: 0x00587C20
		public static Offset<IRoleInhalation> CreateIRoleInhalation(FlatBufferBuilder builder, EInhalationPerformanceType Type = EInhalationPerformanceType.Role)
		{
			builder.StartTable(1);
			IRoleInhalation.AddType(builder, Type);
			return IRoleInhalation.EndIRoleInhalation(builder);
		}

		// Token: 0x060287F0 RID: 165872 RVA: 0x00589A36 File Offset: 0x00587C36
		public static void StartIRoleInhalation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060287F1 RID: 165873 RVA: 0x00589A3F File Offset: 0x00587C3F
		public static void AddType(FlatBufferBuilder builder, EInhalationPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060287F2 RID: 165874 RVA: 0x00589A4A File Offset: 0x00587C4A
		public static Offset<IRoleInhalation> EndIRoleInhalation(FlatBufferBuilder builder)
		{
			return new Offset<IRoleInhalation>(builder.EndTable());
		}

		// Token: 0x060287F3 RID: 165875 RVA: 0x00589A58 File Offset: 0x00587C58
		public IRoleInhalationT UnPack()
		{
			IRoleInhalationT roleInhalationT = new IRoleInhalationT();
			this.UnPackTo(roleInhalationT);
			return roleInhalationT;
		}

		// Token: 0x060287F4 RID: 165876 RVA: 0x00589A73 File Offset: 0x00587C73
		public void UnPackTo(IRoleInhalationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060287F5 RID: 165877 RVA: 0x00589A84 File Offset: 0x00587C84
		public static Offset<IRoleInhalation> Pack(FlatBufferBuilder builder, IRoleInhalationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleInhalation>);
			}
			return IRoleInhalation.CreateIRoleInhalation(builder, _o.Type);
		}

		// Token: 0x0400FAB2 RID: 64178
		private Table __p;
	}
}
