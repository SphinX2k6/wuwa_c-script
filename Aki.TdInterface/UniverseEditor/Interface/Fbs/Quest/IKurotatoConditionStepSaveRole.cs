using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004322 RID: 17186
	public struct IKurotatoConditionStepSaveRole : IFlatbufferObject
	{
		// Token: 0x170075A7 RID: 30119
		// (get) Token: 0x060182BA RID: 99002 RVA: 0x00372605 File Offset: 0x00370805
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060182BB RID: 99003 RVA: 0x00372612 File Offset: 0x00370812
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060182BC RID: 99004 RVA: 0x0037261C File Offset: 0x0037081C
		public static IKurotatoConditionStepSaveRole GetRootAsIKurotatoConditionStepSaveRole(ByteBuffer _bb)
		{
			return IKurotatoConditionStepSaveRole.GetRootAsIKurotatoConditionStepSaveRole(_bb, default(IKurotatoConditionStepSaveRole));
		}

		// Token: 0x060182BD RID: 99005 RVA: 0x00372638 File Offset: 0x00370838
		public static IKurotatoConditionStepSaveRole GetRootAsIKurotatoConditionStepSaveRole(ByteBuffer _bb, IKurotatoConditionStepSaveRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060182BE RID: 99006 RVA: 0x00372655 File Offset: 0x00370855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060182BF RID: 99007 RVA: 0x00372664 File Offset: 0x00370864
		public IKurotatoConditionStepSaveRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075A8 RID: 30120
		// (get) Token: 0x060182C0 RID: 99008 RVA: 0x00372674 File Offset: 0x00370874
		public EKurotatoConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EKurotatoConditionStep.Prepare;
				}
				return (EKurotatoConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060182C1 RID: 99009 RVA: 0x003726B0 File Offset: 0x003708B0
		public static Offset<IKurotatoConditionStepSaveRole> CreateIKurotatoConditionStepSaveRole(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepSaveRole.AddType(builder, Type);
			return IKurotatoConditionStepSaveRole.EndIKurotatoConditionStepSaveRole(builder);
		}

		// Token: 0x060182C2 RID: 99010 RVA: 0x003726C6 File Offset: 0x003708C6
		public static void StartIKurotatoConditionStepSaveRole(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060182C3 RID: 99011 RVA: 0x003726CF File Offset: 0x003708CF
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060182C4 RID: 99012 RVA: 0x003726DA File Offset: 0x003708DA
		public static Offset<IKurotatoConditionStepSaveRole> EndIKurotatoConditionStepSaveRole(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepSaveRole>(builder.EndTable());
		}

		// Token: 0x060182C5 RID: 99013 RVA: 0x003726E8 File Offset: 0x003708E8
		public IKurotatoConditionStepSaveRoleT UnPack()
		{
			IKurotatoConditionStepSaveRoleT kurotatoConditionStepSaveRoleT = new IKurotatoConditionStepSaveRoleT();
			this.UnPackTo(kurotatoConditionStepSaveRoleT);
			return kurotatoConditionStepSaveRoleT;
		}

		// Token: 0x060182C6 RID: 99014 RVA: 0x00372703 File Offset: 0x00370903
		public void UnPackTo(IKurotatoConditionStepSaveRoleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060182C7 RID: 99015 RVA: 0x00372714 File Offset: 0x00370914
		public static Offset<IKurotatoConditionStepSaveRole> Pack(FlatBufferBuilder builder, IKurotatoConditionStepSaveRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepSaveRole>);
			}
			return IKurotatoConditionStepSaveRole.CreateIKurotatoConditionStepSaveRole(builder, _o.Type);
		}

		// Token: 0x0400C2A2 RID: 49826
		private Table __p;
	}
}
