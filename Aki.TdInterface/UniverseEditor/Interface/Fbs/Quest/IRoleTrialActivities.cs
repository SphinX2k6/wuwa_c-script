using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040E8 RID: 16616
	public struct IRoleTrialActivities : IFlatbufferObject
	{
		// Token: 0x17007520 RID: 29984
		// (get) Token: 0x0601836D RID: 99181 RVA: 0x0037CAAC File Offset: 0x0037ACAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601836E RID: 99182 RVA: 0x0037CAB9 File Offset: 0x0037ACB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601836F RID: 99183 RVA: 0x0037CAC0 File Offset: 0x0037ACC0
		public static IRoleTrialActivities GetRootAsIRoleTrialActivities(ByteBuffer _bb)
		{
			return IRoleTrialActivities.GetRootAsIRoleTrialActivities(_bb, default(IRoleTrialActivities));
		}

		// Token: 0x06018370 RID: 99184 RVA: 0x0037CADC File Offset: 0x0037ACDC
		public static IRoleTrialActivities GetRootAsIRoleTrialActivities(ByteBuffer _bb, IRoleTrialActivities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018371 RID: 99185 RVA: 0x0037CAF9 File Offset: 0x0037ACF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018372 RID: 99186 RVA: 0x0037CB08 File Offset: 0x0037AD08
		public IRoleTrialActivities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007521 RID: 29985
		// (get) Token: 0x06018373 RID: 99187 RVA: 0x0037CB18 File Offset: 0x0037AD18
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018374 RID: 99188 RVA: 0x0037CB54 File Offset: 0x0037AD54
		public static Offset<IRoleTrialActivities> CreateIRoleTrialActivities(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All)
		{
			builder.StartTable(1);
			IRoleTrialActivities.AddType(builder, Type);
			return IRoleTrialActivities.EndIRoleTrialActivities(builder);
		}

		// Token: 0x06018375 RID: 99189 RVA: 0x0037CB6A File Offset: 0x0037AD6A
		public static void StartIRoleTrialActivities(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018376 RID: 99190 RVA: 0x0037CB73 File Offset: 0x0037AD73
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018377 RID: 99191 RVA: 0x0037CB7E File Offset: 0x0037AD7E
		public static Offset<IRoleTrialActivities> EndIRoleTrialActivities(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTrialActivities>(builder.EndTable());
		}

		// Token: 0x06018378 RID: 99192 RVA: 0x0037CB8C File Offset: 0x0037AD8C
		public IRoleTrialActivitiesT UnPack()
		{
			IRoleTrialActivitiesT roleTrialActivitiesT = new IRoleTrialActivitiesT();
			this.UnPackTo(roleTrialActivitiesT);
			return roleTrialActivitiesT;
		}

		// Token: 0x06018379 RID: 99193 RVA: 0x0037CBA7 File Offset: 0x0037ADA7
		public void UnPackTo(IRoleTrialActivitiesT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601837A RID: 99194 RVA: 0x0037CBB8 File Offset: 0x0037ADB8
		public static Offset<IRoleTrialActivities> Pack(FlatBufferBuilder builder, IRoleTrialActivitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTrialActivities>);
			}
			return IRoleTrialActivities.CreateIRoleTrialActivities(builder, _o.Type);
		}

		// Token: 0x0400BC80 RID: 48256
		private Table __p;
	}
}
