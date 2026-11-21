using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007246 RID: 29254
	public struct IMotorCatapult : IFlatbufferObject
	{
		// Token: 0x1700D657 RID: 54871
		// (get) Token: 0x06032F0C RID: 208652 RVA: 0x006E07A4 File Offset: 0x006DE9A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032F0D RID: 208653 RVA: 0x006E07B1 File Offset: 0x006DE9B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032F0E RID: 208654 RVA: 0x006E07B8 File Offset: 0x006DE9B8
		public static IMotorCatapult GetRootAsIMotorCatapult(ByteBuffer _bb)
		{
			return IMotorCatapult.GetRootAsIMotorCatapult(_bb, default(IMotorCatapult));
		}

		// Token: 0x06032F0F RID: 208655 RVA: 0x006E07D4 File Offset: 0x006DE9D4
		public static IMotorCatapult GetRootAsIMotorCatapult(ByteBuffer _bb, IMotorCatapult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032F10 RID: 208656 RVA: 0x006E07F1 File Offset: 0x006DE9F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032F11 RID: 208657 RVA: 0x006E0800 File Offset: 0x006DEA00
		public IMotorCatapult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D658 RID: 54872
		// (get) Token: 0x06032F12 RID: 208658 RVA: 0x006E0810 File Offset: 0x006DEA10
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

		// Token: 0x1700D659 RID: 54873
		// (get) Token: 0x06032F13 RID: 208659 RVA: 0x006E084C File Offset: 0x006DEA4C
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

		// Token: 0x1700D65A RID: 54874
		// (get) Token: 0x06032F14 RID: 208660 RVA: 0x006E08AC File Offset: 0x006DEAAC
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

		// Token: 0x1700D65B RID: 54875
		// (get) Token: 0x06032F15 RID: 208661 RVA: 0x006E08E8 File Offset: 0x006DEAE8
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

		// Token: 0x06032F16 RID: 208662 RVA: 0x006E0925 File Offset: 0x006DEB25
		public static Offset<IMotorCatapult> CreateIMotorCatapult(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, Offset<IMotorCatapultParam> ParamOffset = default(Offset<IMotorCatapultParam>), EMotorCatapultSkillType SkillType = EMotorCatapultSkillType.None, byte NullMask = 0)
		{
			builder.StartTable(4);
			IMotorCatapult.AddSkillType(builder, SkillType);
			IMotorCatapult.AddParam(builder, ParamOffset);
			IMotorCatapult.AddNullMask(builder, NullMask);
			IMotorCatapult.AddType(builder, Type);
			return IMotorCatapult.EndIMotorCatapult(builder);
		}

		// Token: 0x06032F17 RID: 208663 RVA: 0x006E0951 File Offset: 0x006DEB51
		public static void StartIMotorCatapult(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032F18 RID: 208664 RVA: 0x006E095A File Offset: 0x006DEB5A
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032F19 RID: 208665 RVA: 0x006E0965 File Offset: 0x006DEB65
		public static void AddParam(FlatBufferBuilder builder, Offset<IMotorCatapultParam> paramOffset)
		{
			builder.AddOffset(1, paramOffset.Value, 0);
		}

		// Token: 0x06032F1A RID: 208666 RVA: 0x006E0975 File Offset: 0x006DEB75
		public static void AddSkillType(FlatBufferBuilder builder, EMotorCatapultSkillType skillType)
		{
			builder.AddInt(2, (int)skillType, 0);
		}

		// Token: 0x06032F1B RID: 208667 RVA: 0x006E0980 File Offset: 0x006DEB80
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06032F1C RID: 208668 RVA: 0x006E098B File Offset: 0x006DEB8B
		public static Offset<IMotorCatapult> EndIMotorCatapult(FlatBufferBuilder builder)
		{
			return new Offset<IMotorCatapult>(builder.EndTable());
		}

		// Token: 0x06032F1D RID: 208669 RVA: 0x006E0998 File Offset: 0x006DEB98
		public IMotorCatapultT UnPack()
		{
			IMotorCatapultT motorCatapultT = new IMotorCatapultT();
			this.UnPackTo(motorCatapultT);
			return motorCatapultT;
		}

		// Token: 0x06032F1E RID: 208670 RVA: 0x006E09B4 File Offset: 0x006DEBB4
		public void UnPackTo(IMotorCatapultT _o)
		{
			_o.Type = this.Type;
			_o.Param = ((this.Param != null) ? this.Param.Value.UnPack() : null);
			_o.SkillType = this.SkillType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032F1F RID: 208671 RVA: 0x006E0A14 File Offset: 0x006DEC14
		public static Offset<IMotorCatapult> Pack(FlatBufferBuilder builder, IMotorCatapultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorCatapult>);
			}
			Offset<IMotorCatapultParam> paramOffset = (_o.Param == null) ? default(Offset<IMotorCatapultParam>) : IMotorCatapultParam.Pack(builder, _o.Param);
			return IMotorCatapult.CreateIMotorCatapult(builder, _o.Type, paramOffset, _o.SkillType, _o.NullMask);
		}

		// Token: 0x0401229B RID: 74395
		private Table __p;
	}
}
