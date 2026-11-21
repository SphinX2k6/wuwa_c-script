using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B12 RID: 27410
	public struct ICommonTipPrepareCountdown : IFlatbufferObject
	{
		// Token: 0x1700C94D RID: 51533
		// (get) Token: 0x0602F210 RID: 193040 RVA: 0x0066D402 File Offset: 0x0066B602
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F211 RID: 193041 RVA: 0x0066D40F File Offset: 0x0066B60F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F212 RID: 193042 RVA: 0x0066D418 File Offset: 0x0066B618
		public static ICommonTipPrepareCountdown GetRootAsICommonTipPrepareCountdown(ByteBuffer _bb)
		{
			return ICommonTipPrepareCountdown.GetRootAsICommonTipPrepareCountdown(_bb, default(ICommonTipPrepareCountdown));
		}

		// Token: 0x0602F213 RID: 193043 RVA: 0x0066D434 File Offset: 0x0066B634
		public static ICommonTipPrepareCountdown GetRootAsICommonTipPrepareCountdown(ByteBuffer _bb, ICommonTipPrepareCountdown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F214 RID: 193044 RVA: 0x0066D451 File Offset: 0x0066B651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F215 RID: 193045 RVA: 0x0066D460 File Offset: 0x0066B660
		public ICommonTipPrepareCountdown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C94E RID: 51534
		// (get) Token: 0x0602F216 RID: 193046 RVA: 0x0066D470 File Offset: 0x0066B670
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

		// Token: 0x0602F217 RID: 193047 RVA: 0x0066D4AC File Offset: 0x0066B6AC
		public static Offset<ICommonTipPrepareCountdown> CreateICommonTipPrepareCountdown(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition)
		{
			builder.StartTable(1);
			ICommonTipPrepareCountdown.AddType(builder, Type);
			return ICommonTipPrepareCountdown.EndICommonTipPrepareCountdown(builder);
		}

		// Token: 0x0602F218 RID: 193048 RVA: 0x0066D4C2 File Offset: 0x0066B6C2
		public static void StartICommonTipPrepareCountdown(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F219 RID: 193049 RVA: 0x0066D4CB File Offset: 0x0066B6CB
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F21A RID: 193050 RVA: 0x0066D4D6 File Offset: 0x0066B6D6
		public static Offset<ICommonTipPrepareCountdown> EndICommonTipPrepareCountdown(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipPrepareCountdown>(builder.EndTable());
		}

		// Token: 0x0602F21B RID: 193051 RVA: 0x0066D4E4 File Offset: 0x0066B6E4
		public ICommonTipPrepareCountdownT UnPack()
		{
			ICommonTipPrepareCountdownT commonTipPrepareCountdownT = new ICommonTipPrepareCountdownT();
			this.UnPackTo(commonTipPrepareCountdownT);
			return commonTipPrepareCountdownT;
		}

		// Token: 0x0602F21C RID: 193052 RVA: 0x0066D4FF File Offset: 0x0066B6FF
		public void UnPackTo(ICommonTipPrepareCountdownT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F21D RID: 193053 RVA: 0x0066D510 File Offset: 0x0066B710
		public static Offset<ICommonTipPrepareCountdown> Pack(FlatBufferBuilder builder, ICommonTipPrepareCountdownT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipPrepareCountdown>);
			}
			return ICommonTipPrepareCountdown.CreateICommonTipPrepareCountdown(builder, _o.Type);
		}

		// Token: 0x040118C7 RID: 71879
		private Table __p;
	}
}
