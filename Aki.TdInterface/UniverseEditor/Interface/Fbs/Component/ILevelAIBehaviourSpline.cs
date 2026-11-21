using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4A RID: 23114
	public struct ILevelAIBehaviourSpline : IFlatbufferObject
	{
		// Token: 0x1700A81D RID: 43037
		// (get) Token: 0x06025CD0 RID: 154832 RVA: 0x0052E948 File Offset: 0x0052CB48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025CD1 RID: 154833 RVA: 0x0052E955 File Offset: 0x0052CB55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025CD2 RID: 154834 RVA: 0x0052E95C File Offset: 0x0052CB5C
		public static ILevelAIBehaviourSpline GetRootAsILevelAIBehaviourSpline(ByteBuffer _bb)
		{
			return ILevelAIBehaviourSpline.GetRootAsILevelAIBehaviourSpline(_bb, default(ILevelAIBehaviourSpline));
		}

		// Token: 0x06025CD3 RID: 154835 RVA: 0x0052E978 File Offset: 0x0052CB78
		public static ILevelAIBehaviourSpline GetRootAsILevelAIBehaviourSpline(ByteBuffer _bb, ILevelAIBehaviourSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025CD4 RID: 154836 RVA: 0x0052E995 File Offset: 0x0052CB95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025CD5 RID: 154837 RVA: 0x0052E9A4 File Offset: 0x0052CBA4
		public ILevelAIBehaviourSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A81E RID: 43038
		// (get) Token: 0x06025CD6 RID: 154838 RVA: 0x0052E9B4 File Offset: 0x0052CBB4
		public ELevelAIBehaviourType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelAIBehaviourType.Spline;
				}
				return (ELevelAIBehaviourType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A81F RID: 43039
		// (get) Token: 0x06025CD7 RID: 154839 RVA: 0x0052E9F0 File Offset: 0x0052CBF0
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A820 RID: 43040
		// (get) Token: 0x06025CD8 RID: 154840 RVA: 0x0052EA2C File Offset: 0x0052CC2C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025CD9 RID: 154841 RVA: 0x0052EA68 File Offset: 0x0052CC68
		public static Offset<ILevelAIBehaviourSpline> CreateILevelAIBehaviourSpline(FlatBufferBuilder builder, ELevelAIBehaviourType Type = ELevelAIBehaviourType.Spline, int SplineEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelAIBehaviourSpline.AddSplineEntityId(builder, SplineEntityId);
			ILevelAIBehaviourSpline.AddNullMask(builder, NullMask);
			ILevelAIBehaviourSpline.AddType(builder, Type);
			return ILevelAIBehaviourSpline.EndILevelAIBehaviourSpline(builder);
		}

		// Token: 0x06025CDA RID: 154842 RVA: 0x0052EA8C File Offset: 0x0052CC8C
		public static void StartILevelAIBehaviourSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025CDB RID: 154843 RVA: 0x0052EA95 File Offset: 0x0052CC95
		public static void AddType(FlatBufferBuilder builder, ELevelAIBehaviourType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025CDC RID: 154844 RVA: 0x0052EAA0 File Offset: 0x0052CCA0
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06025CDD RID: 154845 RVA: 0x0052EAAB File Offset: 0x0052CCAB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06025CDE RID: 154846 RVA: 0x0052EAB6 File Offset: 0x0052CCB6
		public static Offset<ILevelAIBehaviourSpline> EndILevelAIBehaviourSpline(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAIBehaviourSpline>(builder.EndTable());
		}

		// Token: 0x06025CDF RID: 154847 RVA: 0x0052EAC4 File Offset: 0x0052CCC4
		public ILevelAIBehaviourSplineT UnPack()
		{
			ILevelAIBehaviourSplineT levelAIBehaviourSplineT = new ILevelAIBehaviourSplineT();
			this.UnPackTo(levelAIBehaviourSplineT);
			return levelAIBehaviourSplineT;
		}

		// Token: 0x06025CE0 RID: 154848 RVA: 0x0052EADF File Offset: 0x0052CCDF
		public void UnPackTo(ILevelAIBehaviourSplineT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025CE1 RID: 154849 RVA: 0x0052EB08 File Offset: 0x0052CD08
		public static Offset<ILevelAIBehaviourSpline> Pack(FlatBufferBuilder builder, ILevelAIBehaviourSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAIBehaviourSpline>);
			}
			return ILevelAIBehaviourSpline.CreateILevelAIBehaviourSpline(builder, _o.Type, _o.SplineEntityId, _o.NullMask);
		}

		// Token: 0x0400F3AF RID: 62383
		private Table __p;
	}
}
