using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005981 RID: 22913
	public struct IInhalationConfig : IFlatbufferObject
	{
		// Token: 0x1700A66F RID: 42607
		// (get) Token: 0x0602559F RID: 152991 RVA: 0x005204D3 File Offset: 0x0051E6D3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060255A0 RID: 152992 RVA: 0x005204E0 File Offset: 0x0051E6E0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060255A1 RID: 152993 RVA: 0x005204E8 File Offset: 0x0051E6E8
		public static IInhalationConfig GetRootAsIInhalationConfig(ByteBuffer _bb)
		{
			return IInhalationConfig.GetRootAsIInhalationConfig(_bb, default(IInhalationConfig));
		}

		// Token: 0x060255A2 RID: 152994 RVA: 0x00520504 File Offset: 0x0051E704
		public static IInhalationConfig GetRootAsIInhalationConfig(ByteBuffer _bb, IInhalationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060255A3 RID: 152995 RVA: 0x00520521 File Offset: 0x0051E721
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060255A4 RID: 152996 RVA: 0x00520530 File Offset: 0x0051E730
		public IInhalationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A670 RID: 42608
		// (get) Token: 0x060255A5 RID: 152997 RVA: 0x00520540 File Offset: 0x0051E740
		public IInhalationMatching? InhalationMatching
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IInhalationMatching?(default(IInhalationMatching).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A671 RID: 42609
		// (get) Token: 0x060255A6 RID: 152998 RVA: 0x005205A0 File Offset: 0x0051E7A0
		public TInhalationPerformance InhalationPerformanceType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TInhalationPerformance.NONE;
				}
				return (TInhalationPerformance)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060255A7 RID: 152999 RVA: 0x005205DC File Offset: 0x0051E7DC
		public TTable? InhalationPerformance<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060255A8 RID: 153000 RVA: 0x00520620 File Offset: 0x0051E820
		public IRoleInhalation InhalationPerformanceAsIRoleInhalation()
		{
			return this.InhalationPerformance<IRoleInhalation>().Value;
		}

		// Token: 0x060255A9 RID: 153001 RVA: 0x0052063C File Offset: 0x0051E83C
		public ISceneItemInhalation InhalationPerformanceAsISceneItemInhalation()
		{
			return this.InhalationPerformance<ISceneItemInhalation>().Value;
		}

		// Token: 0x060255AA RID: 153002 RVA: 0x00520657 File Offset: 0x0051E857
		public static Offset<IInhalationConfig> CreateIInhalationConfig(FlatBufferBuilder builder, Offset<IInhalationMatching> InhalationMatchingOffset = default(Offset<IInhalationMatching>), TInhalationPerformance InhalationPerformance_type = TInhalationPerformance.NONE, int InhalationPerformanceOffset = 0)
		{
			builder.StartTable(3);
			IInhalationConfig.AddInhalationPerformance(builder, InhalationPerformanceOffset);
			IInhalationConfig.AddInhalationMatching(builder, InhalationMatchingOffset);
			IInhalationConfig.AddInhalationPerformanceType(builder, InhalationPerformance_type);
			return IInhalationConfig.EndIInhalationConfig(builder);
		}

		// Token: 0x060255AB RID: 153003 RVA: 0x0052067B File Offset: 0x0051E87B
		public static void StartIInhalationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060255AC RID: 153004 RVA: 0x00520684 File Offset: 0x0051E884
		public static void AddInhalationMatching(FlatBufferBuilder builder, Offset<IInhalationMatching> inhalationMatchingOffset)
		{
			builder.AddOffset(0, inhalationMatchingOffset.Value, 0);
		}

		// Token: 0x060255AD RID: 153005 RVA: 0x00520694 File Offset: 0x0051E894
		public static void AddInhalationPerformanceType(FlatBufferBuilder builder, TInhalationPerformance inhalationPerformanceType)
		{
			builder.AddByte(1, (byte)inhalationPerformanceType, 0);
		}

		// Token: 0x060255AE RID: 153006 RVA: 0x0052069F File Offset: 0x0051E89F
		public static void AddInhalationPerformance(FlatBufferBuilder builder, int inhalationPerformanceOffset)
		{
			builder.AddOffset(2, inhalationPerformanceOffset, 0);
		}

		// Token: 0x060255AF RID: 153007 RVA: 0x005206AA File Offset: 0x0051E8AA
		public static Offset<IInhalationConfig> EndIInhalationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInhalationConfig>(builder.EndTable());
		}

		// Token: 0x060255B0 RID: 153008 RVA: 0x005206B8 File Offset: 0x0051E8B8
		public IInhalationConfigT UnPack()
		{
			IInhalationConfigT inhalationConfigT = new IInhalationConfigT();
			this.UnPackTo(inhalationConfigT);
			return inhalationConfigT;
		}

		// Token: 0x060255B1 RID: 153009 RVA: 0x005206D4 File Offset: 0x0051E8D4
		public void UnPackTo(IInhalationConfigT _o)
		{
			_o.InhalationMatching = ((this.InhalationMatching != null) ? this.InhalationMatching.Value.UnPack() : null);
			_o.InhalationPerformance = new TInhalationPerformanceUnion();
			_o.InhalationPerformance.Type = this.InhalationPerformanceType;
			TInhalationPerformance inhalationPerformanceType = this.InhalationPerformanceType;
			if (inhalationPerformanceType == TInhalationPerformance.IRoleInhalation)
			{
				_o.InhalationPerformance.Value = ((this.InhalationPerformance<IRoleInhalation>() != null) ? this.InhalationPerformance<IRoleInhalation>().Value.UnPack() : null);
				return;
			}
			if (inhalationPerformanceType != TInhalationPerformance.ISceneItemInhalation)
			{
				return;
			}
			_o.InhalationPerformance.Value = ((this.InhalationPerformance<ISceneItemInhalation>() != null) ? this.InhalationPerformance<ISceneItemInhalation>().Value.UnPack() : null);
		}

		// Token: 0x060255B2 RID: 153010 RVA: 0x005207AC File Offset: 0x0051E9AC
		public static Offset<IInhalationConfig> Pack(FlatBufferBuilder builder, IInhalationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhalationConfig>);
			}
			Offset<IInhalationMatching> inhalationMatchingOffset = (_o.InhalationMatching == null) ? default(Offset<IInhalationMatching>) : IInhalationMatching.Pack(builder, _o.InhalationMatching);
			TInhalationPerformance inhalationPerformance_type = (_o.InhalationPerformance == null) ? TInhalationPerformance.NONE : _o.InhalationPerformance.Type;
			int inhalationPerformanceOffset = (_o.InhalationPerformance == null) ? 0 : TInhalationPerformanceUnion.Pack(builder, _o.InhalationPerformance);
			return IInhalationConfig.CreateIInhalationConfig(builder, inhalationMatchingOffset, inhalationPerformance_type, inhalationPerformanceOffset);
		}

		// Token: 0x0400F270 RID: 62064
		private Table __p;
	}
}
