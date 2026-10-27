using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006888 RID: 26760
	public struct IGetRewardByInteract : IFlatbufferObject
	{
		// Token: 0x1700C6B9 RID: 50873
		// (get) Token: 0x0602EAB9 RID: 191161 RVA: 0x0065D259 File Offset: 0x0065B459
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EABA RID: 191162 RVA: 0x0065D266 File Offset: 0x0065B466
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EABB RID: 191163 RVA: 0x0065D270 File Offset: 0x0065B470
		public static IGetRewardByInteract GetRootAsIGetRewardByInteract(ByteBuffer _bb)
		{
			return IGetRewardByInteract.GetRootAsIGetRewardByInteract(_bb, default(IGetRewardByInteract));
		}

		// Token: 0x0602EABC RID: 191164 RVA: 0x0065D28C File Offset: 0x0065B48C
		public static IGetRewardByInteract GetRootAsIGetRewardByInteract(ByteBuffer _bb, IGetRewardByInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EABD RID: 191165 RVA: 0x0065D2A9 File Offset: 0x0065B4A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EABE RID: 191166 RVA: 0x0065D2B8 File Offset: 0x0065B4B8
		public IGetRewardByInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602EABF RID: 191167 RVA: 0x0065D2C8 File Offset: 0x0065B4C8
		public static void StartIGetRewardByInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602EAC0 RID: 191168 RVA: 0x0065D2D1 File Offset: 0x0065B4D1
		public static Offset<IGetRewardByInteract> EndIGetRewardByInteract(FlatBufferBuilder builder)
		{
			return new Offset<IGetRewardByInteract>(builder.EndTable());
		}

		// Token: 0x0602EAC1 RID: 191169 RVA: 0x0065D2E0 File Offset: 0x0065B4E0
		public IGetRewardByInteractT UnPack()
		{
			IGetRewardByInteractT getRewardByInteractT = new IGetRewardByInteractT();
			this.UnPackTo(getRewardByInteractT);
			return getRewardByInteractT;
		}

		// Token: 0x0602EAC2 RID: 191170 RVA: 0x0065D2FB File Offset: 0x0065B4FB
		public void UnPackTo(IGetRewardByInteractT _o)
		{
		}

		// Token: 0x0602EAC3 RID: 191171 RVA: 0x0065D300 File Offset: 0x0065B500
		public static Offset<IGetRewardByInteract> Pack(FlatBufferBuilder builder, IGetRewardByInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetRewardByInteract>);
			}
			IGetRewardByInteract.StartIGetRewardByInteract(builder);
			return IGetRewardByInteract.EndIGetRewardByInteract(builder);
		}

		// Token: 0x04010FDD RID: 69597
		private Table __p;
	}
}
