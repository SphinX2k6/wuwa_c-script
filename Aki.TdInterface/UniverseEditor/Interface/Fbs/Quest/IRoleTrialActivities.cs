using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004529 RID: 17705
	public struct IRoleTrialActivities : IFlatbufferObject
	{
		// Token: 0x17007B26 RID: 31526
		// (get) Token: 0x06019A0E RID: 104974 RVA: 0x003A69FC File Offset: 0x003A4BFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019A0F RID: 104975 RVA: 0x003A6A09 File Offset: 0x003A4C09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019A10 RID: 104976 RVA: 0x003A6A10 File Offset: 0x003A4C10
		public static IRoleTrialActivities GetRootAsIRoleTrialActivities(ByteBuffer _bb)
		{
			return IRoleTrialActivities.GetRootAsIRoleTrialActivities(_bb, default(IRoleTrialActivities));
		}

		// Token: 0x06019A11 RID: 104977 RVA: 0x003A6A2C File Offset: 0x003A4C2C
		public static IRoleTrialActivities GetRootAsIRoleTrialActivities(ByteBuffer _bb, IRoleTrialActivities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019A12 RID: 104978 RVA: 0x003A6A49 File Offset: 0x003A4C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019A13 RID: 104979 RVA: 0x003A6A58 File Offset: 0x003A4C58
		public IRoleTrialActivities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B27 RID: 31527
		// (get) Token: 0x06019A14 RID: 104980 RVA: 0x003A6A68 File Offset: 0x003A4C68
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

		// Token: 0x06019A15 RID: 104981 RVA: 0x003A6AA4 File Offset: 0x003A4CA4
		public static Offset<IRoleTrialActivities> CreateIRoleTrialActivities(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All)
		{
			builder.StartTable(1);
			IRoleTrialActivities.AddType(builder, Type);
			return IRoleTrialActivities.EndIRoleTrialActivities(builder);
		}

		// Token: 0x06019A16 RID: 104982 RVA: 0x003A6ABA File Offset: 0x003A4CBA
		public static void StartIRoleTrialActivities(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019A17 RID: 104983 RVA: 0x003A6AC3 File Offset: 0x003A4CC3
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019A18 RID: 104984 RVA: 0x003A6ACE File Offset: 0x003A4CCE
		public static Offset<IRoleTrialActivities> EndIRoleTrialActivities(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTrialActivities>(builder.EndTable());
		}

		// Token: 0x06019A19 RID: 104985 RVA: 0x003A6ADC File Offset: 0x003A4CDC
		public IRoleTrialActivitiesT UnPack()
		{
			IRoleTrialActivitiesT roleTrialActivitiesT = new IRoleTrialActivitiesT();
			this.UnPackTo(roleTrialActivitiesT);
			return roleTrialActivitiesT;
		}

		// Token: 0x06019A1A RID: 104986 RVA: 0x003A6AF7 File Offset: 0x003A4CF7
		public void UnPackTo(IRoleTrialActivitiesT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019A1B RID: 104987 RVA: 0x003A6B08 File Offset: 0x003A4D08
		public static Offset<IRoleTrialActivities> Pack(FlatBufferBuilder builder, IRoleTrialActivitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTrialActivities>);
			}
			return IRoleTrialActivities.CreateIRoleTrialActivities(builder, _o.Type);
		}

		// Token: 0x0400C669 RID: 50793
		private Table __p;
	}
}
