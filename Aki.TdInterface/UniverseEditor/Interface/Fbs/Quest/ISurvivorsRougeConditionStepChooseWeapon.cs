using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045A4 RID: 17828
	public struct ISurvivorsRougeConditionStepChooseWeapon : IFlatbufferObject
	{
		// Token: 0x17007CA1 RID: 31905
		// (get) Token: 0x0601A00E RID: 106510 RVA: 0x003B5031 File Offset: 0x003B3231
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A00F RID: 106511 RVA: 0x003B503E File Offset: 0x003B323E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A010 RID: 106512 RVA: 0x003B5048 File Offset: 0x003B3248
		public static ISurvivorsRougeConditionStepChooseWeapon GetRootAsISurvivorsRougeConditionStepChooseWeapon(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepChooseWeapon.GetRootAsISurvivorsRougeConditionStepChooseWeapon(_bb, default(ISurvivorsRougeConditionStepChooseWeapon));
		}

		// Token: 0x0601A011 RID: 106513 RVA: 0x003B5064 File Offset: 0x003B3264
		public static ISurvivorsRougeConditionStepChooseWeapon GetRootAsISurvivorsRougeConditionStepChooseWeapon(ByteBuffer _bb, ISurvivorsRougeConditionStepChooseWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A012 RID: 106514 RVA: 0x003B5081 File Offset: 0x003B3281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A013 RID: 106515 RVA: 0x003B5090 File Offset: 0x003B3290
		public ISurvivorsRougeConditionStepChooseWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CA2 RID: 31906
		// (get) Token: 0x0601A014 RID: 106516 RVA: 0x003B50A0 File Offset: 0x003B32A0
		public ESurvivorsRougeConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESurvivorsRougeConditionStep.Prepare;
				}
				return (ESurvivorsRougeConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A015 RID: 106517 RVA: 0x003B50DC File Offset: 0x003B32DC
		public static Offset<ISurvivorsRougeConditionStepChooseWeapon> CreateISurvivorsRougeConditionStepChooseWeapon(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepChooseWeapon.AddType(builder, Type);
			return ISurvivorsRougeConditionStepChooseWeapon.EndISurvivorsRougeConditionStepChooseWeapon(builder);
		}

		// Token: 0x0601A016 RID: 106518 RVA: 0x003B50F2 File Offset: 0x003B32F2
		public static void StartISurvivorsRougeConditionStepChooseWeapon(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A017 RID: 106519 RVA: 0x003B50FB File Offset: 0x003B32FB
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A018 RID: 106520 RVA: 0x003B5106 File Offset: 0x003B3306
		public static Offset<ISurvivorsRougeConditionStepChooseWeapon> EndISurvivorsRougeConditionStepChooseWeapon(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepChooseWeapon>(builder.EndTable());
		}

		// Token: 0x0601A019 RID: 106521 RVA: 0x003B5114 File Offset: 0x003B3314
		public ISurvivorsRougeConditionStepChooseWeaponT UnPack()
		{
			ISurvivorsRougeConditionStepChooseWeaponT survivorsRougeConditionStepChooseWeaponT = new ISurvivorsRougeConditionStepChooseWeaponT();
			this.UnPackTo(survivorsRougeConditionStepChooseWeaponT);
			return survivorsRougeConditionStepChooseWeaponT;
		}

		// Token: 0x0601A01A RID: 106522 RVA: 0x003B512F File Offset: 0x003B332F
		public void UnPackTo(ISurvivorsRougeConditionStepChooseWeaponT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A01B RID: 106523 RVA: 0x003B5140 File Offset: 0x003B3340
		public static Offset<ISurvivorsRougeConditionStepChooseWeapon> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepChooseWeaponT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepChooseWeapon>);
			}
			return ISurvivorsRougeConditionStepChooseWeapon.CreateISurvivorsRougeConditionStepChooseWeapon(builder, _o.Type);
		}

		// Token: 0x0400C76D RID: 51053
		private Table __p;
	}
}
