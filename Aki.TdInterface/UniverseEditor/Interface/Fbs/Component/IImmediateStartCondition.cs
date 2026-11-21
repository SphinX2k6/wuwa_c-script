using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005972 RID: 22898
	public struct IImmediateStartCondition : IFlatbufferObject
	{
		// Token: 0x1700A659 RID: 42585
		// (get) Token: 0x06025535 RID: 152885 RVA: 0x0051F991 File Offset: 0x0051DB91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025536 RID: 152886 RVA: 0x0051F99E File Offset: 0x0051DB9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025537 RID: 152887 RVA: 0x0051F9A8 File Offset: 0x0051DBA8
		public static IImmediateStartCondition GetRootAsIImmediateStartCondition(ByteBuffer _bb)
		{
			return IImmediateStartCondition.GetRootAsIImmediateStartCondition(_bb, default(IImmediateStartCondition));
		}

		// Token: 0x06025538 RID: 152888 RVA: 0x0051F9C4 File Offset: 0x0051DBC4
		public static IImmediateStartCondition GetRootAsIImmediateStartCondition(ByteBuffer _bb, IImmediateStartCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025539 RID: 152889 RVA: 0x0051F9E1 File Offset: 0x0051DBE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602553A RID: 152890 RVA: 0x0051F9F0 File Offset: 0x0051DBF0
		public IImmediateStartCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A65A RID: 42586
		// (get) Token: 0x0602553B RID: 152891 RVA: 0x0051FA00 File Offset: 0x0051DC00
		public ESpawnMonsterStartCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return (ESpawnMonsterStartCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602553C RID: 152892 RVA: 0x0051FA3C File Offset: 0x0051DC3C
		public static Offset<IImmediateStartCondition> CreateIImmediateStartCondition(FlatBufferBuilder builder, ESpawnMonsterStartCondition Type = ESpawnMonsterStartCondition.Immediate)
		{
			builder.StartTable(1);
			IImmediateStartCondition.AddType(builder, Type);
			return IImmediateStartCondition.EndIImmediateStartCondition(builder);
		}

		// Token: 0x0602553D RID: 152893 RVA: 0x0051FA52 File Offset: 0x0051DC52
		public static void StartIImmediateStartCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602553E RID: 152894 RVA: 0x0051FA5B File Offset: 0x0051DC5B
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterStartCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602553F RID: 152895 RVA: 0x0051FA66 File Offset: 0x0051DC66
		public static Offset<IImmediateStartCondition> EndIImmediateStartCondition(FlatBufferBuilder builder)
		{
			return new Offset<IImmediateStartCondition>(builder.EndTable());
		}

		// Token: 0x06025540 RID: 152896 RVA: 0x0051FA74 File Offset: 0x0051DC74
		public IImmediateStartConditionT UnPack()
		{
			IImmediateStartConditionT immediateStartConditionT = new IImmediateStartConditionT();
			this.UnPackTo(immediateStartConditionT);
			return immediateStartConditionT;
		}

		// Token: 0x06025541 RID: 152897 RVA: 0x0051FA8F File Offset: 0x0051DC8F
		public void UnPackTo(IImmediateStartConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025542 RID: 152898 RVA: 0x0051FAA0 File Offset: 0x0051DCA0
		public static Offset<IImmediateStartCondition> Pack(FlatBufferBuilder builder, IImmediateStartConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IImmediateStartCondition>);
			}
			return IImmediateStartCondition.CreateIImmediateStartCondition(builder, _o.Type);
		}

		// Token: 0x0400F25E RID: 62046
		private Table __p;
	}
}
