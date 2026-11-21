using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B87 RID: 27527
	public struct ICustomSkill : IFlatbufferObject
	{
		// Token: 0x1700C9FF RID: 51711
		// (get) Token: 0x0602F5E5 RID: 194021 RVA: 0x006768F7 File Offset: 0x00674AF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F5E6 RID: 194022 RVA: 0x00676904 File Offset: 0x00674B04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F5E7 RID: 194023 RVA: 0x0067690C File Offset: 0x00674B0C
		public static ICustomSkill GetRootAsICustomSkill(ByteBuffer _bb)
		{
			return ICustomSkill.GetRootAsICustomSkill(_bb, default(ICustomSkill));
		}

		// Token: 0x0602F5E8 RID: 194024 RVA: 0x00676928 File Offset: 0x00674B28
		public static ICustomSkill GetRootAsICustomSkill(ByteBuffer _bb, ICustomSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F5E9 RID: 194025 RVA: 0x00676945 File Offset: 0x00674B45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F5EA RID: 194026 RVA: 0x00676954 File Offset: 0x00674B54
		public ICustomSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA00 RID: 51712
		// (get) Token: 0x0602F5EB RID: 194027 RVA: 0x00676964 File Offset: 0x00674B64
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA01 RID: 51713
		// (get) Token: 0x0602F5EC RID: 194028 RVA: 0x006769A0 File Offset: 0x00674BA0
		public TCommonTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCommonTarget.NONE;
				}
				return (TCommonTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F5ED RID: 194029 RVA: 0x006769DC File Offset: 0x00674BDC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F5EE RID: 194030 RVA: 0x00676A20 File Offset: 0x00674C20
		public IAssistCharacterTarget TargetAsIAssistCharacterTarget()
		{
			return this.Target<IAssistCharacterTarget>().Value;
		}

		// Token: 0x0602F5EF RID: 194031 RVA: 0x00676A3C File Offset: 0x00674C3C
		public IPlayerTarget TargetAsIPlayerTarget()
		{
			return this.Target<IPlayerTarget>().Value;
		}

		// Token: 0x1700CA02 RID: 51714
		// (get) Token: 0x0602F5F0 RID: 194032 RVA: 0x00676A58 File Offset: 0x00674C58
		public int SkillId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F5F1 RID: 194033 RVA: 0x00676A95 File Offset: 0x00674C95
		public static Offset<ICustomSkill> CreateICustomSkill(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, TCommonTarget Target_type = TCommonTarget.NONE, int TargetOffset = 0, int SkillId = 0)
		{
			builder.StartTable(4);
			ICustomSkill.AddSkillId(builder, SkillId);
			ICustomSkill.AddTarget(builder, TargetOffset);
			ICustomSkill.AddTargetType(builder, Target_type);
			ICustomSkill.AddType(builder, Type);
			return ICustomSkill.EndICustomSkill(builder);
		}

		// Token: 0x0602F5F2 RID: 194034 RVA: 0x00676AC1 File Offset: 0x00674CC1
		public static void StartICustomSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F5F3 RID: 194035 RVA: 0x00676ACA File Offset: 0x00674CCA
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F5F4 RID: 194036 RVA: 0x00676AD5 File Offset: 0x00674CD5
		public static void AddTargetType(FlatBufferBuilder builder, TCommonTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602F5F5 RID: 194037 RVA: 0x00676AE0 File Offset: 0x00674CE0
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602F5F6 RID: 194038 RVA: 0x00676AEB File Offset: 0x00674CEB
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(3, skillId, 0);
		}

		// Token: 0x0602F5F7 RID: 194039 RVA: 0x00676AF6 File Offset: 0x00674CF6
		public static Offset<ICustomSkill> EndICustomSkill(FlatBufferBuilder builder)
		{
			return new Offset<ICustomSkill>(builder.EndTable());
		}

		// Token: 0x0602F5F8 RID: 194040 RVA: 0x00676B04 File Offset: 0x00674D04
		public ICustomSkillT UnPack()
		{
			ICustomSkillT customSkillT = new ICustomSkillT();
			this.UnPackTo(customSkillT);
			return customSkillT;
		}

		// Token: 0x0602F5F9 RID: 194041 RVA: 0x00676B20 File Offset: 0x00674D20
		public void UnPackTo(ICustomSkillT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TCommonTargetUnion();
			_o.Target.Type = this.TargetType;
			TCommonTarget targetType = this.TargetType;
			if (targetType != TCommonTarget.IAssistCharacterTarget)
			{
				if (targetType == TCommonTarget.IPlayerTarget)
				{
					_o.Target.Value = ((this.Target<IPlayerTarget>() != null) ? this.Target<IPlayerTarget>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<IAssistCharacterTarget>() != null) ? this.Target<IAssistCharacterTarget>().Value.UnPack() : null);
			}
			_o.SkillId = this.SkillId;
		}

		// Token: 0x0602F5FA RID: 194042 RVA: 0x00676BE0 File Offset: 0x00674DE0
		public static Offset<ICustomSkill> Pack(FlatBufferBuilder builder, ICustomSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomSkill>);
			}
			TCommonTarget target_type = (_o.Target == null) ? TCommonTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TCommonTargetUnion.Pack(builder, _o.Target);
			return ICustomSkill.CreateICustomSkill(builder, _o.Type, target_type, targetOffset, _o.SkillId);
		}

		// Token: 0x0401197B RID: 72059
		private Table __p;
	}
}
