using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004160 RID: 16736
	public struct ISurvivorsRougeConditionStepChooseWeapon : IFlatbufferObject
	{
		// Token: 0x17007692 RID: 30354
		// (get) Token: 0x06018946 RID: 100678 RVA: 0x0038AA75 File Offset: 0x00388C75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018947 RID: 100679 RVA: 0x0038AA82 File Offset: 0x00388C82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018948 RID: 100680 RVA: 0x0038AA8C File Offset: 0x00388C8C
		public static ISurvivorsRougeConditionStepChooseWeapon GetRootAsISurvivorsRougeConditionStepChooseWeapon(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepChooseWeapon.GetRootAsISurvivorsRougeConditionStepChooseWeapon(_bb, default(ISurvivorsRougeConditionStepChooseWeapon));
		}

		// Token: 0x06018949 RID: 100681 RVA: 0x0038AAA8 File Offset: 0x00388CA8
		public static ISurvivorsRougeConditionStepChooseWeapon GetRootAsISurvivorsRougeConditionStepChooseWeapon(ByteBuffer _bb, ISurvivorsRougeConditionStepChooseWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601894A RID: 100682 RVA: 0x0038AAC5 File Offset: 0x00388CC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601894B RID: 100683 RVA: 0x0038AAD4 File Offset: 0x00388CD4
		public ISurvivorsRougeConditionStepChooseWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007693 RID: 30355
		// (get) Token: 0x0601894C RID: 100684 RVA: 0x0038AAE4 File Offset: 0x00388CE4
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

		// Token: 0x0601894D RID: 100685 RVA: 0x0038AB20 File Offset: 0x00388D20
		public static Offset<ISurvivorsRougeConditionStepChooseWeapon> CreateISurvivorsRougeConditionStepChooseWeapon(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepChooseWeapon.AddType(builder, Type);
			return ISurvivorsRougeConditionStepChooseWeapon.EndISurvivorsRougeConditionStepChooseWeapon(builder);
		}

		// Token: 0x0601894E RID: 100686 RVA: 0x0038AB36 File Offset: 0x00388D36
		public static void StartISurvivorsRougeConditionStepChooseWeapon(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601894F RID: 100687 RVA: 0x0038AB3F File Offset: 0x00388D3F
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018950 RID: 100688 RVA: 0x0038AB4A File Offset: 0x00388D4A
		public static Offset<ISurvivorsRougeConditionStepChooseWeapon> EndISurvivorsRougeConditionStepChooseWeapon(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepChooseWeapon>(builder.EndTable());
		}

		// Token: 0x06018951 RID: 100689 RVA: 0x0038AB58 File Offset: 0x00388D58
		public ISurvivorsRougeConditionStepChooseWeaponT UnPack()
		{
			ISurvivorsRougeConditionStepChooseWeaponT survivorsRougeConditionStepChooseWeaponT = new ISurvivorsRougeConditionStepChooseWeaponT();
			this.UnPackTo(survivorsRougeConditionStepChooseWeaponT);
			return survivorsRougeConditionStepChooseWeaponT;
		}

		// Token: 0x06018952 RID: 100690 RVA: 0x0038AB73 File Offset: 0x00388D73
		public void UnPackTo(ISurvivorsRougeConditionStepChooseWeaponT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018953 RID: 100691 RVA: 0x0038AB84 File Offset: 0x00388D84
		public static Offset<ISurvivorsRougeConditionStepChooseWeapon> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepChooseWeaponT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepChooseWeapon>);
			}
			return ISurvivorsRougeConditionStepChooseWeapon.CreateISurvivorsRougeConditionStepChooseWeapon(builder, _o.Type);
		}

		// Token: 0x0400BD7F RID: 48511
		private Table __p;
	}
}
