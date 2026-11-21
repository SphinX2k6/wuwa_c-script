using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005109 RID: 20745
	public struct IESkillReady : IFlatbufferObject
	{
		// Token: 0x170094AF RID: 38063
		// (get) Token: 0x060209C3 RID: 133571 RVA: 0x004858B5 File Offset: 0x00483AB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060209C4 RID: 133572 RVA: 0x004858C2 File Offset: 0x00483AC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060209C5 RID: 133573 RVA: 0x004858CC File Offset: 0x00483ACC
		public static IESkillReady GetRootAsIESkillReady(ByteBuffer _bb)
		{
			return IESkillReady.GetRootAsIESkillReady(_bb, default(IESkillReady));
		}

		// Token: 0x060209C6 RID: 133574 RVA: 0x004858E8 File Offset: 0x00483AE8
		public static IESkillReady GetRootAsIESkillReady(ByteBuffer _bb, IESkillReady obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060209C7 RID: 133575 RVA: 0x00485905 File Offset: 0x00483B05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060209C8 RID: 133576 RVA: 0x00485914 File Offset: 0x00483B14
		public IESkillReady __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094B0 RID: 38064
		// (get) Token: 0x060209C9 RID: 133577 RVA: 0x00485924 File Offset: 0x00483B24
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

		// Token: 0x060209CA RID: 133578 RVA: 0x00485960 File Offset: 0x00483B60
		public static Offset<IESkillReady> CreateIESkillReady(FlatBufferBuilder builder, ESkillReadyType Type = ESkillReadyType.UltimateSkill)
		{
			builder.StartTable(1);
			IESkillReady.AddType(builder, Type);
			return IESkillReady.EndIESkillReady(builder);
		}

		// Token: 0x060209CB RID: 133579 RVA: 0x00485976 File Offset: 0x00483B76
		public static void StartIESkillReady(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060209CC RID: 133580 RVA: 0x0048597F File Offset: 0x00483B7F
		public static void AddType(FlatBufferBuilder builder, ESkillReadyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060209CD RID: 133581 RVA: 0x0048598A File Offset: 0x00483B8A
		public static Offset<IESkillReady> EndIESkillReady(FlatBufferBuilder builder)
		{
			return new Offset<IESkillReady>(builder.EndTable());
		}

		// Token: 0x060209CE RID: 133582 RVA: 0x00485998 File Offset: 0x00483B98
		public IESkillReadyT UnPack()
		{
			IESkillReadyT ieskillReadyT = new IESkillReadyT();
			this.UnPackTo(ieskillReadyT);
			return ieskillReadyT;
		}

		// Token: 0x060209CF RID: 133583 RVA: 0x004859B3 File Offset: 0x00483BB3
		public void UnPackTo(IESkillReadyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060209D0 RID: 133584 RVA: 0x004859C4 File Offset: 0x00483BC4
		public static Offset<IESkillReady> Pack(FlatBufferBuilder builder, IESkillReadyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IESkillReady>);
			}
			return IESkillReady.CreateIESkillReady(builder, _o.Type);
		}

		// Token: 0x0400E0CC RID: 57548
		private Table __p;
	}
}
