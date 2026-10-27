using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064A7 RID: 25767
	public struct ICommonTipPrepareCountdown : IFlatbufferObject
	{
		// Token: 0x1700BFC0 RID: 49088
		// (get) Token: 0x0602CA96 RID: 182934 RVA: 0x0062182E File Offset: 0x0061FA2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA97 RID: 182935 RVA: 0x0062183B File Offset: 0x0061FA3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA98 RID: 182936 RVA: 0x00621844 File Offset: 0x0061FA44
		public static ICommonTipPrepareCountdown GetRootAsICommonTipPrepareCountdown(ByteBuffer _bb)
		{
			return ICommonTipPrepareCountdown.GetRootAsICommonTipPrepareCountdown(_bb, default(ICommonTipPrepareCountdown));
		}

		// Token: 0x0602CA99 RID: 182937 RVA: 0x00621860 File Offset: 0x0061FA60
		public static ICommonTipPrepareCountdown GetRootAsICommonTipPrepareCountdown(ByteBuffer _bb, ICommonTipPrepareCountdown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA9A RID: 182938 RVA: 0x0062187D File Offset: 0x0061FA7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA9B RID: 182939 RVA: 0x0062188C File Offset: 0x0061FA8C
		public ICommonTipPrepareCountdown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFC1 RID: 49089
		// (get) Token: 0x0602CA9C RID: 182940 RVA: 0x0062189C File Offset: 0x0061FA9C
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CA9D RID: 182941 RVA: 0x006218D8 File Offset: 0x0061FAD8
		public static Offset<ICommonTipPrepareCountdown> CreateICommonTipPrepareCountdown(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition)
		{
			builder.StartTable(1);
			ICommonTipPrepareCountdown.AddType(builder, Type);
			return ICommonTipPrepareCountdown.EndICommonTipPrepareCountdown(builder);
		}

		// Token: 0x0602CA9E RID: 182942 RVA: 0x006218EE File Offset: 0x0061FAEE
		public static void StartICommonTipPrepareCountdown(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CA9F RID: 182943 RVA: 0x006218F7 File Offset: 0x0061FAF7
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CAA0 RID: 182944 RVA: 0x00621902 File Offset: 0x0061FB02
		public static Offset<ICommonTipPrepareCountdown> EndICommonTipPrepareCountdown(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipPrepareCountdown>(builder.EndTable());
		}

		// Token: 0x0602CAA1 RID: 182945 RVA: 0x00621910 File Offset: 0x0061FB10
		public ICommonTipPrepareCountdownT UnPack()
		{
			ICommonTipPrepareCountdownT commonTipPrepareCountdownT = new ICommonTipPrepareCountdownT();
			this.UnPackTo(commonTipPrepareCountdownT);
			return commonTipPrepareCountdownT;
		}

		// Token: 0x0602CAA2 RID: 182946 RVA: 0x0062192B File Offset: 0x0061FB2B
		public void UnPackTo(ICommonTipPrepareCountdownT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CAA3 RID: 182947 RVA: 0x0062193C File Offset: 0x0061FB3C
		public static Offset<ICommonTipPrepareCountdown> Pack(FlatBufferBuilder builder, ICommonTipPrepareCountdownT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipPrepareCountdown>);
			}
			return ICommonTipPrepareCountdown.CreateICommonTipPrepareCountdown(builder, _o.Type);
		}

		// Token: 0x04010AB6 RID: 68278
		private Table __p;
	}
}
