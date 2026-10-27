using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D09 RID: 19721
	public struct IUltimateSkillReady : IFlatbufferObject
	{
		// Token: 0x17008F0E RID: 36622
		// (get) Token: 0x0601F4D2 RID: 128210 RVA: 0x0045DB75 File Offset: 0x0045BD75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F4D3 RID: 128211 RVA: 0x0045DB82 File Offset: 0x0045BD82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F4D4 RID: 128212 RVA: 0x0045DB8C File Offset: 0x0045BD8C
		public static IUltimateSkillReady GetRootAsIUltimateSkillReady(ByteBuffer _bb)
		{
			return IUltimateSkillReady.GetRootAsIUltimateSkillReady(_bb, default(IUltimateSkillReady));
		}

		// Token: 0x0601F4D5 RID: 128213 RVA: 0x0045DBA8 File Offset: 0x0045BDA8
		public static IUltimateSkillReady GetRootAsIUltimateSkillReady(ByteBuffer _bb, IUltimateSkillReady obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F4D6 RID: 128214 RVA: 0x0045DBC5 File Offset: 0x0045BDC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F4D7 RID: 128215 RVA: 0x0045DBD4 File Offset: 0x0045BDD4
		public IUltimateSkillReady __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F0F RID: 36623
		// (get) Token: 0x0601F4D8 RID: 128216 RVA: 0x0045DBE4 File Offset: 0x0045BDE4
		public ESkillReadyType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillReadyType.UltimateSkill;
				}
				return (ESkillReadyType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F4D9 RID: 128217 RVA: 0x0045DC20 File Offset: 0x0045BE20
		public static Offset<IUltimateSkillReady> CreateIUltimateSkillReady(FlatBufferBuilder builder, ESkillReadyType Type = ESkillReadyType.UltimateSkill)
		{
			builder.StartTable(1);
			IUltimateSkillReady.AddType(builder, Type);
			return IUltimateSkillReady.EndIUltimateSkillReady(builder);
		}

		// Token: 0x0601F4DA RID: 128218 RVA: 0x0045DC36 File Offset: 0x0045BE36
		public static void StartIUltimateSkillReady(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F4DB RID: 128219 RVA: 0x0045DC3F File Offset: 0x0045BE3F
		public static void AddType(FlatBufferBuilder builder, ESkillReadyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F4DC RID: 128220 RVA: 0x0045DC4A File Offset: 0x0045BE4A
		public static Offset<IUltimateSkillReady> EndIUltimateSkillReady(FlatBufferBuilder builder)
		{
			return new Offset<IUltimateSkillReady>(builder.EndTable());
		}

		// Token: 0x0601F4DD RID: 128221 RVA: 0x0045DC58 File Offset: 0x0045BE58
		public IUltimateSkillReadyT UnPack()
		{
			IUltimateSkillReadyT ultimateSkillReadyT = new IUltimateSkillReadyT();
			this.UnPackTo(ultimateSkillReadyT);
			return ultimateSkillReadyT;
		}

		// Token: 0x0601F4DE RID: 128222 RVA: 0x0045DC73 File Offset: 0x0045BE73
		public void UnPackTo(IUltimateSkillReadyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F4DF RID: 128223 RVA: 0x0045DC84 File Offset: 0x0045BE84
		public static Offset<IUltimateSkillReady> Pack(FlatBufferBuilder builder, IUltimateSkillReadyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUltimateSkillReady>);
			}
			return IUltimateSkillReady.CreateIUltimateSkillReady(builder, _o.Type);
		}

		// Token: 0x0400D6E6 RID: 55014
		private Table __p;
	}
}
