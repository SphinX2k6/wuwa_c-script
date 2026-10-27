using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C1C RID: 19484
	public struct IESkillReady : IFlatbufferObject
	{
		// Token: 0x17008D8B RID: 36235
		// (get) Token: 0x0601EDDD RID: 126429 RVA: 0x0045224D File Offset: 0x0045044D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EDDE RID: 126430 RVA: 0x0045225A File Offset: 0x0045045A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EDDF RID: 126431 RVA: 0x00452264 File Offset: 0x00450464
		public static IESkillReady GetRootAsIESkillReady(ByteBuffer _bb)
		{
			return IESkillReady.GetRootAsIESkillReady(_bb, default(IESkillReady));
		}

		// Token: 0x0601EDE0 RID: 126432 RVA: 0x00452280 File Offset: 0x00450480
		public static IESkillReady GetRootAsIESkillReady(ByteBuffer _bb, IESkillReady obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EDE1 RID: 126433 RVA: 0x0045229D File Offset: 0x0045049D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EDE2 RID: 126434 RVA: 0x004522AC File Offset: 0x004504AC
		public IESkillReady __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D8C RID: 36236
		// (get) Token: 0x0601EDE3 RID: 126435 RVA: 0x004522BC File Offset: 0x004504BC
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

		// Token: 0x0601EDE4 RID: 126436 RVA: 0x004522F8 File Offset: 0x004504F8
		public static Offset<IESkillReady> CreateIESkillReady(FlatBufferBuilder builder, ESkillReadyType Type = ESkillReadyType.UltimateSkill)
		{
			builder.StartTable(1);
			IESkillReady.AddType(builder, Type);
			return IESkillReady.EndIESkillReady(builder);
		}

		// Token: 0x0601EDE5 RID: 126437 RVA: 0x0045230E File Offset: 0x0045050E
		public static void StartIESkillReady(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EDE6 RID: 126438 RVA: 0x00452317 File Offset: 0x00450517
		public static void AddType(FlatBufferBuilder builder, ESkillReadyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EDE7 RID: 126439 RVA: 0x00452322 File Offset: 0x00450522
		public static Offset<IESkillReady> EndIESkillReady(FlatBufferBuilder builder)
		{
			return new Offset<IESkillReady>(builder.EndTable());
		}

		// Token: 0x0601EDE8 RID: 126440 RVA: 0x00452330 File Offset: 0x00450530
		public IESkillReadyT UnPack()
		{
			IESkillReadyT ieskillReadyT = new IESkillReadyT();
			this.UnPackTo(ieskillReadyT);
			return ieskillReadyT;
		}

		// Token: 0x0601EDE9 RID: 126441 RVA: 0x0045234B File Offset: 0x0045054B
		public void UnPackTo(IESkillReadyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EDEA RID: 126442 RVA: 0x0045235C File Offset: 0x0045055C
		public static Offset<IESkillReady> Pack(FlatBufferBuilder builder, IESkillReadyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IESkillReady>);
			}
			return IESkillReady.CreateIESkillReady(builder, _o.Type);
		}

		// Token: 0x0400D5B5 RID: 54709
		private Table __p;
	}
}
