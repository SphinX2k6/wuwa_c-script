using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044FC RID: 17660
	public struct IRoleSkinTrialActivities : IFlatbufferObject
	{
		// Token: 0x17007AF7 RID: 31479
		// (get) Token: 0x060198EB RID: 104683 RVA: 0x003A4E00 File Offset: 0x003A3000
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060198EC RID: 104684 RVA: 0x003A4E0D File Offset: 0x003A300D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060198ED RID: 104685 RVA: 0x003A4E14 File Offset: 0x003A3014
		public static IRoleSkinTrialActivities GetRootAsIRoleSkinTrialActivities(ByteBuffer _bb)
		{
			return IRoleSkinTrialActivities.GetRootAsIRoleSkinTrialActivities(_bb, default(IRoleSkinTrialActivities));
		}

		// Token: 0x060198EE RID: 104686 RVA: 0x003A4E30 File Offset: 0x003A3030
		public static IRoleSkinTrialActivities GetRootAsIRoleSkinTrialActivities(ByteBuffer _bb, IRoleSkinTrialActivities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060198EF RID: 104687 RVA: 0x003A4E4D File Offset: 0x003A304D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060198F0 RID: 104688 RVA: 0x003A4E5C File Offset: 0x003A305C
		public IRoleSkinTrialActivities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AF8 RID: 31480
		// (get) Token: 0x060198F1 RID: 104689 RVA: 0x003A4E6C File Offset: 0x003A306C
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

		// Token: 0x060198F2 RID: 104690 RVA: 0x003A4EA8 File Offset: 0x003A30A8
		public static Offset<IRoleSkinTrialActivities> CreateIRoleSkinTrialActivities(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All)
		{
			builder.StartTable(1);
			IRoleSkinTrialActivities.AddType(builder, Type);
			return IRoleSkinTrialActivities.EndIRoleSkinTrialActivities(builder);
		}

		// Token: 0x060198F3 RID: 104691 RVA: 0x003A4EBE File Offset: 0x003A30BE
		public static void StartIRoleSkinTrialActivities(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060198F4 RID: 104692 RVA: 0x003A4EC7 File Offset: 0x003A30C7
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060198F5 RID: 104693 RVA: 0x003A4ED2 File Offset: 0x003A30D2
		public static Offset<IRoleSkinTrialActivities> EndIRoleSkinTrialActivities(FlatBufferBuilder builder)
		{
			return new Offset<IRoleSkinTrialActivities>(builder.EndTable());
		}

		// Token: 0x060198F6 RID: 104694 RVA: 0x003A4EE0 File Offset: 0x003A30E0
		public IRoleSkinTrialActivitiesT UnPack()
		{
			IRoleSkinTrialActivitiesT roleSkinTrialActivitiesT = new IRoleSkinTrialActivitiesT();
			this.UnPackTo(roleSkinTrialActivitiesT);
			return roleSkinTrialActivitiesT;
		}

		// Token: 0x060198F7 RID: 104695 RVA: 0x003A4EFB File Offset: 0x003A30FB
		public void UnPackTo(IRoleSkinTrialActivitiesT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060198F8 RID: 104696 RVA: 0x003A4F0C File Offset: 0x003A310C
		public static Offset<IRoleSkinTrialActivities> Pack(FlatBufferBuilder builder, IRoleSkinTrialActivitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleSkinTrialActivities>);
			}
			return IRoleSkinTrialActivities.CreateIRoleSkinTrialActivities(builder, _o.Type);
		}

		// Token: 0x0400C63B RID: 50747
		private Table __p;
	}
}
