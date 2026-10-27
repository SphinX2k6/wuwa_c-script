using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B0F RID: 27407
	public struct IMotorCatapult : IFlatbufferObject
	{
		// Token: 0x1700CB88 RID: 52104
		// (get) Token: 0x06030138 RID: 196920 RVA: 0x006890EC File Offset: 0x006872EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030139 RID: 196921 RVA: 0x006890F9 File Offset: 0x006872F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603013A RID: 196922 RVA: 0x00689100 File Offset: 0x00687300
		public static IMotorCatapult GetRootAsIMotorCatapult(ByteBuffer _bb)
		{
			return IMotorCatapult.GetRootAsIMotorCatapult(_bb, default(IMotorCatapult));
		}

		// Token: 0x0603013B RID: 196923 RVA: 0x0068911C File Offset: 0x0068731C
		public static IMotorCatapult GetRootAsIMotorCatapult(ByteBuffer _bb, IMotorCatapult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603013C RID: 196924 RVA: 0x00689139 File Offset: 0x00687339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603013D RID: 196925 RVA: 0x00689148 File Offset: 0x00687348
		public IMotorCatapult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB89 RID: 52105
		// (get) Token: 0x0603013E RID: 196926 RVA: 0x00689158 File Offset: 0x00687358
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

		// Token: 0x1700CB8A RID: 52106
		// (get) Token: 0x0603013F RID: 196927 RVA: 0x00689194 File Offset: 0x00687394
		public IMotorCatapultParam? Param
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMotorCatapultParam?(default(IMotorCatapultParam).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CB8B RID: 52107
		// (get) Token: 0x06030140 RID: 196928 RVA: 0x006891F4 File Offset: 0x006873F4
		public EMotorCatapultSkillType SkillType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EMotorCatapultSkillType.None;
				}
				return (EMotorCatapultSkillType)this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB8C RID: 52108
		// (get) Token: 0x06030141 RID: 196929 RVA: 0x00689230 File Offset: 0x00687430
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030142 RID: 196930 RVA: 0x0068926D File Offset: 0x0068746D
		public static Offset<IMotorCatapult> CreateIMotorCatapult(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, Offset<IMotorCatapultParam> ParamOffset = default(Offset<IMotorCatapultParam>), EMotorCatapultSkillType SkillType = EMotorCatapultSkillType.None, byte NullMask = 0)
		{
			builder.StartTable(4);
			IMotorCatapult.AddSkillType(builder, SkillType);
			IMotorCatapult.AddParam(builder, ParamOffset);
			IMotorCatapult.AddNullMask(builder, NullMask);
			IMotorCatapult.AddType(builder, Type);
			return IMotorCatapult.EndIMotorCatapult(builder);
		}

		// Token: 0x06030143 RID: 196931 RVA: 0x00689299 File Offset: 0x00687499
		public static void StartIMotorCatapult(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030144 RID: 196932 RVA: 0x006892A2 File Offset: 0x006874A2
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030145 RID: 196933 RVA: 0x006892AD File Offset: 0x006874AD
		public static void AddParam(FlatBufferBuilder builder, Offset<IMotorCatapultParam> paramOffset)
		{
			builder.AddOffset(1, paramOffset.Value, 0);
		}

		// Token: 0x06030146 RID: 196934 RVA: 0x006892BD File Offset: 0x006874BD
		public static void AddSkillType(FlatBufferBuilder builder, EMotorCatapultSkillType skillType)
		{
			builder.AddInt(2, (int)skillType, 0);
		}

		// Token: 0x06030147 RID: 196935 RVA: 0x006892C8 File Offset: 0x006874C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06030148 RID: 196936 RVA: 0x006892D3 File Offset: 0x006874D3
		public static Offset<IMotorCatapult> EndIMotorCatapult(FlatBufferBuilder builder)
		{
			return new Offset<IMotorCatapult>(builder.EndTable());
		}

		// Token: 0x06030149 RID: 196937 RVA: 0x006892E0 File Offset: 0x006874E0
		public IMotorCatapultT UnPack()
		{
			IMotorCatapultT motorCatapultT = new IMotorCatapultT();
			this.UnPackTo(motorCatapultT);
			return motorCatapultT;
		}

		// Token: 0x0603014A RID: 196938 RVA: 0x006892FC File Offset: 0x006874FC
		public void UnPackTo(IMotorCatapultT _o)
		{
			_o.Type = this.Type;
			_o.Param = ((this.Param != null) ? this.Param.Value.UnPack() : null);
			_o.SkillType = this.SkillType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603014B RID: 196939 RVA: 0x0068935C File Offset: 0x0068755C
		public static Offset<IMotorCatapult> Pack(FlatBufferBuilder builder, IMotorCatapultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorCatapult>);
			}
			Offset<IMotorCatapultParam> paramOffset = (_o.Param == null) ? default(Offset<IMotorCatapultParam>) : IMotorCatapultParam.Pack(builder, _o.Param);
			return IMotorCatapult.CreateIMotorCatapult(builder, _o.Type, paramOffset, _o.SkillType, _o.NullMask);
		}

		// Token: 0x04011388 RID: 70536
		private Table __p;
	}
}
