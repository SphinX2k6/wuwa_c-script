using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C9 RID: 22473
	public struct IQuickHackComponent : IFlatbufferObject
	{
		// Token: 0x1700A7BA RID: 42938
		// (get) Token: 0x06025B80 RID: 154496 RVA: 0x00533950 File Offset: 0x00531B50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025B81 RID: 154497 RVA: 0x0053395D File Offset: 0x00531B5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025B82 RID: 154498 RVA: 0x00533964 File Offset: 0x00531B64
		public static IQuickHackComponent GetRootAsIQuickHackComponent(ByteBuffer _bb)
		{
			return IQuickHackComponent.GetRootAsIQuickHackComponent(_bb, default(IQuickHackComponent));
		}

		// Token: 0x06025B83 RID: 154499 RVA: 0x00533980 File Offset: 0x00531B80
		public static IQuickHackComponent GetRootAsIQuickHackComponent(ByteBuffer _bb, IQuickHackComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025B84 RID: 154500 RVA: 0x0053399D File Offset: 0x00531B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025B85 RID: 154501 RVA: 0x005339AC File Offset: 0x00531BAC
		public IQuickHackComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7BB RID: 42939
		// (get) Token: 0x06025B86 RID: 154502 RVA: 0x005339BC File Offset: 0x00531BBC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A7BC RID: 42940
		// (get) Token: 0x06025B87 RID: 154503 RVA: 0x005339FC File Offset: 0x00531BFC
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

		// Token: 0x1700A7BD RID: 42941
		// (get) Token: 0x06025B88 RID: 154504 RVA: 0x00533A3C File Offset: 0x00531C3C
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

		// Token: 0x06025B89 RID: 154505 RVA: 0x00533A9C File Offset: 0x00531C9C
		public IQuickHackSkill? Skills(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IQuickHackSkill?(default(IQuickHackSkill).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7BE RID: 42942
		// (get) Token: 0x06025B8A RID: 154506 RVA: 0x00533B00 File Offset: 0x00531D00
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

		// Token: 0x1700A7BF RID: 42943
		// (get) Token: 0x06025B8B RID: 154507 RVA: 0x00533B2C File Offset: 0x00531D2C
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

		// Token: 0x1700A7C0 RID: 42944
		// (get) Token: 0x06025B8C RID: 154508 RVA: 0x00533B6C File Offset: 0x00531D6C
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

		// Token: 0x1700A7C1 RID: 42945
		// (get) Token: 0x06025B8D RID: 154509 RVA: 0x00533BCC File Offset: 0x00531DCC
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

		// Token: 0x06025B8E RID: 154510 RVA: 0x00533C0C File Offset: 0x00531E0C
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

		// Token: 0x06025B8F RID: 154511 RVA: 0x00533C5B File Offset: 0x00531E5B
		public static void StartIQuickHackComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06025B90 RID: 154512 RVA: 0x00533C64 File Offset: 0x00531E64
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025B91 RID: 154513 RVA: 0x00533C6F File Offset: 0x00531E6F
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06025B92 RID: 154514 RVA: 0x00533C82 File Offset: 0x00531E82
		public static void AddIconOffset(FlatBufferBuilder builder, Offset<IVectorInfo> iconOffsetOffset)
		{
			builder.AddOffset(2, iconOffsetOffset.Value, 0);
		}

		// Token: 0x06025B93 RID: 154515 RVA: 0x00533C92 File Offset: 0x00531E92
		public static void AddSkills(FlatBufferBuilder builder, VectorOffset skillsOffset)
		{
			builder.AddOffset(3, skillsOffset.Value, 0);
		}

		// Token: 0x06025B94 RID: 154516 RVA: 0x00533CA4 File Offset: 0x00531EA4
		public static VectorOffset CreateSkillsVector(FlatBufferBuilder builder, Offset<IQuickHackSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025B95 RID: 154517 RVA: 0x00533CE4 File Offset: 0x00531EE4
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, Offset<IQuickHackSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQuickHackSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025B96 RID: 154518 RVA: 0x00533CFE File Offset: 0x00531EFE
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQuickHackSkill>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQuickHackSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025B97 RID: 154519 RVA: 0x00533D1C File Offset: 0x00531F1C
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQuickHackSkill>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025B98 RID: 154520 RVA: 0x00533D35 File Offset: 0x00531F35
		public static void StartSkillsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025B99 RID: 154521 RVA: 0x00533D40 File Offset: 0x00531F40
		public static void AddAutoClose(FlatBufferBuilder builder, EQuickHackAutoCloseType autoClose)
		{
			builder.AddByte(4, (byte)autoClose, 0);
		}

		// Token: 0x06025B9A RID: 154522 RVA: 0x00533D4B File Offset: 0x00531F4B
		public static void AddLinkEffect(FlatBufferBuilder builder, Offset<IQuickHackLinkEffect> linkEffectOffset)
		{
			builder.AddOffset(5, linkEffectOffset.Value, 0);
		}

		// Token: 0x06025B9B RID: 154523 RVA: 0x00533D5B File Offset: 0x00531F5B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06025B9C RID: 154524 RVA: 0x00533D66 File Offset: 0x00531F66
		public static Offset<IQuickHackComponent> EndIQuickHackComponent(FlatBufferBuilder builder)
		{
			return new Offset<IQuickHackComponent>(builder.EndTable());
		}

		// Token: 0x06025B9D RID: 154525 RVA: 0x00533D74 File Offset: 0x00531F74
		public IQuickHackComponentT UnPack()
		{
			IQuickHackComponentT quickHackComponentT = new IQuickHackComponentT();
			this.UnPackTo(quickHackComponentT);
			return quickHackComponentT;
		}

		// Token: 0x06025B9E RID: 154526 RVA: 0x00533D90 File Offset: 0x00531F90
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

		// Token: 0x06025B9F RID: 154527 RVA: 0x00533E84 File Offset: 0x00532084
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

		// Token: 0x0400ECA7 RID: 60583
		private Table __p;
	}
}
