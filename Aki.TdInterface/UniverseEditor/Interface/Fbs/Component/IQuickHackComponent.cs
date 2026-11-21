using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DD0 RID: 24016
	public struct IQuickHackComponent : IFlatbufferObject
	{
		// Token: 0x1700B0DE RID: 45278
		// (get) Token: 0x060280A0 RID: 164000 RVA: 0x00579ADC File Offset: 0x00577CDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060280A1 RID: 164001 RVA: 0x00579AE9 File Offset: 0x00577CE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060280A2 RID: 164002 RVA: 0x00579AF0 File Offset: 0x00577CF0
		public static IQuickHackComponent GetRootAsIQuickHackComponent(ByteBuffer _bb)
		{
			return IQuickHackComponent.GetRootAsIQuickHackComponent(_bb, default(IQuickHackComponent));
		}

		// Token: 0x060280A3 RID: 164003 RVA: 0x00579B0C File Offset: 0x00577D0C
		public static IQuickHackComponent GetRootAsIQuickHackComponent(ByteBuffer _bb, IQuickHackComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060280A4 RID: 164004 RVA: 0x00579B29 File Offset: 0x00577D29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060280A5 RID: 164005 RVA: 0x00579B38 File Offset: 0x00577D38
		public IQuickHackComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0DF RID: 45279
		// (get) Token: 0x060280A6 RID: 164006 RVA: 0x00579B48 File Offset: 0x00577D48
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B0E0 RID: 45280
		// (get) Token: 0x060280A7 RID: 164007 RVA: 0x00579B88 File Offset: 0x00577D88
		public float Time
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B0E1 RID: 45281
		// (get) Token: 0x060280A8 RID: 164008 RVA: 0x00579BC8 File Offset: 0x00577DC8
		public IVectorInfo? IconOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060280A9 RID: 164009 RVA: 0x00579C28 File Offset: 0x00577E28
		public IQuickHackSkill? Skills(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IQuickHackSkill?(default(IQuickHackSkill).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B0E2 RID: 45282
		// (get) Token: 0x060280AA RID: 164010 RVA: 0x00579C8C File Offset: 0x00577E8C
		public int SkillsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B0E3 RID: 45283
		// (get) Token: 0x060280AB RID: 164011 RVA: 0x00579CB8 File Offset: 0x00577EB8
		public EQuickHackAutoCloseType AutoClose
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EQuickHackAutoCloseType.OnSkillSelected;
				}
				return (EQuickHackAutoCloseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B0E4 RID: 45284
		// (get) Token: 0x060280AC RID: 164012 RVA: 0x00579CF8 File Offset: 0x00577EF8
		public IQuickHackLinkEffect? LinkEffect
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IQuickHackLinkEffect?(default(IQuickHackLinkEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B0E5 RID: 45285
		// (get) Token: 0x060280AD RID: 164013 RVA: 0x00579D58 File Offset: 0x00577F58
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060280AE RID: 164014 RVA: 0x00579D98 File Offset: 0x00577F98
		public static Offset<IQuickHackComponent> CreateIQuickHackComponent(FlatBufferBuilder builder, bool Disabled = false, float Time = 0f, Offset<IVectorInfo> IconOffsetOffset = default(Offset<IVectorInfo>), VectorOffset SkillsOffset = default(VectorOffset), EQuickHackAutoCloseType AutoClose = EQuickHackAutoCloseType.OnSkillSelected, Offset<IQuickHackLinkEffect> LinkEffectOffset = default(Offset<IQuickHackLinkEffect>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IQuickHackComponent.AddLinkEffect(builder, LinkEffectOffset);
			IQuickHackComponent.AddSkills(builder, SkillsOffset);
			IQuickHackComponent.AddIconOffset(builder, IconOffsetOffset);
			IQuickHackComponent.AddTime(builder, Time);
			IQuickHackComponent.AddNullMask(builder, NullMask);
			IQuickHackComponent.AddAutoClose(builder, AutoClose);
			IQuickHackComponent.AddDisabled(builder, Disabled);
			return IQuickHackComponent.EndIQuickHackComponent(builder);
		}

		// Token: 0x060280AF RID: 164015 RVA: 0x00579DE7 File Offset: 0x00577FE7
		public static void StartIQuickHackComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060280B0 RID: 164016 RVA: 0x00579DF0 File Offset: 0x00577FF0
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060280B1 RID: 164017 RVA: 0x00579DFB File Offset: 0x00577FFB
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x060280B2 RID: 164018 RVA: 0x00579E0E File Offset: 0x0057800E
		public static void AddIconOffset(FlatBufferBuilder builder, Offset<IVectorInfo> iconOffsetOffset)
		{
			builder.AddOffset(2, iconOffsetOffset.Value, 0);
		}

		// Token: 0x060280B3 RID: 164019 RVA: 0x00579E1E File Offset: 0x0057801E
		public static void AddSkills(FlatBufferBuilder builder, VectorOffset skillsOffset)
		{
			builder.AddOffset(3, skillsOffset.Value, 0);
		}

		// Token: 0x060280B4 RID: 164020 RVA: 0x00579E30 File Offset: 0x00578030
		public static VectorOffset CreateSkillsVector(FlatBufferBuilder builder, Offset<IQuickHackSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060280B5 RID: 164021 RVA: 0x00579E70 File Offset: 0x00578070
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, Offset<IQuickHackSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQuickHackSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x060280B6 RID: 164022 RVA: 0x00579E8A File Offset: 0x0057808A
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQuickHackSkill>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQuickHackSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x060280B7 RID: 164023 RVA: 0x00579EA8 File Offset: 0x005780A8
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQuickHackSkill>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060280B8 RID: 164024 RVA: 0x00579EC1 File Offset: 0x005780C1
		public static void StartSkillsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060280B9 RID: 164025 RVA: 0x00579ECC File Offset: 0x005780CC
		public static void AddAutoClose(FlatBufferBuilder builder, EQuickHackAutoCloseType autoClose)
		{
			builder.AddByte(4, (byte)autoClose, 0);
		}

		// Token: 0x060280BA RID: 164026 RVA: 0x00579ED7 File Offset: 0x005780D7
		public static void AddLinkEffect(FlatBufferBuilder builder, Offset<IQuickHackLinkEffect> linkEffectOffset)
		{
			builder.AddOffset(5, linkEffectOffset.Value, 0);
		}

		// Token: 0x060280BB RID: 164027 RVA: 0x00579EE7 File Offset: 0x005780E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060280BC RID: 164028 RVA: 0x00579EF2 File Offset: 0x005780F2
		public static Offset<IQuickHackComponent> EndIQuickHackComponent(FlatBufferBuilder builder)
		{
			return new Offset<IQuickHackComponent>(builder.EndTable());
		}

		// Token: 0x060280BD RID: 164029 RVA: 0x00579F00 File Offset: 0x00578100
		public IQuickHackComponentT UnPack()
		{
			IQuickHackComponentT quickHackComponentT = new IQuickHackComponentT();
			this.UnPackTo(quickHackComponentT);
			return quickHackComponentT;
		}

		// Token: 0x060280BE RID: 164030 RVA: 0x00579F1C File Offset: 0x0057811C
		public void UnPackTo(IQuickHackComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Time = this.Time;
			_o.IconOffset = ((this.IconOffset != null) ? this.IconOffset.Value.UnPack() : null);
			_o.Skills = new List<IQuickHackSkillT>();
			for (int i = 0; i < this.SkillsLength; i++)
			{
				_o.Skills.Add((this.Skills(i) != null) ? this.Skills(i).Value.UnPack() : null);
			}
			_o.AutoClose = this.AutoClose;
			_o.LinkEffect = ((this.LinkEffect != null) ? this.LinkEffect.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060280BF RID: 164031 RVA: 0x0057A010 File Offset: 0x00578210
		public static Offset<IQuickHackComponent> Pack(FlatBufferBuilder builder, IQuickHackComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuickHackComponent>);
			}
			Offset<IVectorInfo> iconOffsetOffset = (_o.IconOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.IconOffset);
			VectorOffset skillsOffset = default(VectorOffset);
			if (_o.Skills != null)
			{
				Offset<IQuickHackSkill>[] array = new Offset<IQuickHackSkill>[_o.Skills.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IQuickHackSkill.Pack(builder, _o.Skills[i]);
				}
				skillsOffset = IQuickHackComponent.CreateSkillsVector(builder, array);
			}
			Offset<IQuickHackLinkEffect> linkEffectOffset = (_o.LinkEffect == null) ? default(Offset<IQuickHackLinkEffect>) : IQuickHackLinkEffect.Pack(builder, _o.LinkEffect);
			return IQuickHackComponent.CreateIQuickHackComponent(builder, _o.Disabled, _o.Time, iconOffsetOffset, skillsOffset, _o.AutoClose, linkEffectOffset, _o.NullMask);
		}

		// Token: 0x0400F992 RID: 63890
		private Table __p;
	}
}
