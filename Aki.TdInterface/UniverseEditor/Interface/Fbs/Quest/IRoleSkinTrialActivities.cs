using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040BB RID: 16571
	public struct IRoleSkinTrialActivities : IFlatbufferObject
	{
		// Token: 0x170074F1 RID: 29937
		// (get) Token: 0x0601824A RID: 98890 RVA: 0x0037AEB0 File Offset: 0x003790B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601824B RID: 98891 RVA: 0x0037AEBD File Offset: 0x003790BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601824C RID: 98892 RVA: 0x0037AEC4 File Offset: 0x003790C4
		public static IRoleSkinTrialActivities GetRootAsIRoleSkinTrialActivities(ByteBuffer _bb)
		{
			return IRoleSkinTrialActivities.GetRootAsIRoleSkinTrialActivities(_bb, default(IRoleSkinTrialActivities));
		}

		// Token: 0x0601824D RID: 98893 RVA: 0x0037AEE0 File Offset: 0x003790E0
		public static IRoleSkinTrialActivities GetRootAsIRoleSkinTrialActivities(ByteBuffer _bb, IRoleSkinTrialActivities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601824E RID: 98894 RVA: 0x0037AEFD File Offset: 0x003790FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601824F RID: 98895 RVA: 0x0037AF0C File Offset: 0x0037910C
		public IRoleSkinTrialActivities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074F2 RID: 29938
		// (get) Token: 0x06018250 RID: 98896 RVA: 0x0037AF1C File Offset: 0x0037911C
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

		// Token: 0x06018251 RID: 98897 RVA: 0x0037AF58 File Offset: 0x00379158
		public static Offset<IRoleSkinTrialActivities> CreateIRoleSkinTrialActivities(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All)
		{
			builder.StartTable(1);
			IRoleSkinTrialActivities.AddType(builder, Type);
			return IRoleSkinTrialActivities.EndIRoleSkinTrialActivities(builder);
		}

		// Token: 0x06018252 RID: 98898 RVA: 0x0037AF6E File Offset: 0x0037916E
		public static void StartIRoleSkinTrialActivities(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018253 RID: 98899 RVA: 0x0037AF77 File Offset: 0x00379177
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018254 RID: 98900 RVA: 0x0037AF82 File Offset: 0x00379182
		public static Offset<IRoleSkinTrialActivities> EndIRoleSkinTrialActivities(FlatBufferBuilder builder)
		{
			return new Offset<IRoleSkinTrialActivities>(builder.EndTable());
		}

		// Token: 0x06018255 RID: 98901 RVA: 0x0037AF90 File Offset: 0x00379190
		public IRoleSkinTrialActivitiesT UnPack()
		{
			IRoleSkinTrialActivitiesT roleSkinTrialActivitiesT = new IRoleSkinTrialActivitiesT();
			this.UnPackTo(roleSkinTrialActivitiesT);
			return roleSkinTrialActivitiesT;
		}

		// Token: 0x06018256 RID: 98902 RVA: 0x0037AFAB File Offset: 0x003791AB
		public void UnPackTo(IRoleSkinTrialActivitiesT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018257 RID: 98903 RVA: 0x0037AFBC File Offset: 0x003791BC
		public static Offset<IRoleSkinTrialActivities> Pack(FlatBufferBuilder builder, IRoleSkinTrialActivitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleSkinTrialActivities>);
			}
			return IRoleSkinTrialActivities.CreateIRoleSkinTrialActivities(builder, _o.Type);
		}

		// Token: 0x0400BC52 RID: 48210
		private Table __p;
	}
}
