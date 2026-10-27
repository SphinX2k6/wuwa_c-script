using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006370 RID: 25456
	public struct IClaimDungeonReward : IFlatbufferObject
	{
		// Token: 0x1700BDE3 RID: 48611
		// (get) Token: 0x0602C097 RID: 180375 RVA: 0x0060CE51 File Offset: 0x0060B051
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C098 RID: 180376 RVA: 0x0060CE5E File Offset: 0x0060B05E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C099 RID: 180377 RVA: 0x0060CE68 File Offset: 0x0060B068
		public static IClaimDungeonReward GetRootAsIClaimDungeonReward(ByteBuffer _bb)
		{
			return IClaimDungeonReward.GetRootAsIClaimDungeonReward(_bb, default(IClaimDungeonReward));
		}

		// Token: 0x0602C09A RID: 180378 RVA: 0x0060CE84 File Offset: 0x0060B084
		public static IClaimDungeonReward GetRootAsIClaimDungeonReward(ByteBuffer _bb, IClaimDungeonReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C09B RID: 180379 RVA: 0x0060CEA1 File Offset: 0x0060B0A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C09C RID: 180380 RVA: 0x0060CEB0 File Offset: 0x0060B0B0
		public IClaimDungeonReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C09D RID: 180381 RVA: 0x0060CEC0 File Offset: 0x0060B0C0
		public static void StartIClaimDungeonReward(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602C09E RID: 180382 RVA: 0x0060CEC9 File Offset: 0x0060B0C9
		public static Offset<IClaimDungeonReward> EndIClaimDungeonReward(FlatBufferBuilder builder)
		{
			return new Offset<IClaimDungeonReward>(builder.EndTable());
		}

		// Token: 0x0602C09F RID: 180383 RVA: 0x0060CED8 File Offset: 0x0060B0D8
		public IClaimDungeonRewardT UnPack()
		{
			IClaimDungeonRewardT claimDungeonRewardT = new IClaimDungeonRewardT();
			this.UnPackTo(claimDungeonRewardT);
			return claimDungeonRewardT;
		}

		// Token: 0x0602C0A0 RID: 180384 RVA: 0x0060CEF3 File Offset: 0x0060B0F3
		public void UnPackTo(IClaimDungeonRewardT _o)
		{
		}

		// Token: 0x0602C0A1 RID: 180385 RVA: 0x0060CEF8 File Offset: 0x0060B0F8
		public static Offset<IClaimDungeonReward> Pack(FlatBufferBuilder builder, IClaimDungeonRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClaimDungeonReward>);
			}
			IClaimDungeonReward.StartIClaimDungeonReward(builder);
			return IClaimDungeonReward.EndIClaimDungeonReward(builder);
		}

		// Token: 0x04010940 RID: 67904
		private Table __p;
	}
}
