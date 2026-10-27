using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055FC RID: 22012
	public struct INoiseRemovalBoarderBase : IFlatbufferObject
	{
		// Token: 0x1700A2E2 RID: 41698
		// (get) Token: 0x0602485F RID: 149599 RVA: 0x0050A628 File Offset: 0x00508828
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024860 RID: 149600 RVA: 0x0050A635 File Offset: 0x00508835
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024861 RID: 149601 RVA: 0x0050A63C File Offset: 0x0050883C
		public static INoiseRemovalBoarderBase GetRootAsINoiseRemovalBoarderBase(ByteBuffer _bb)
		{
			return INoiseRemovalBoarderBase.GetRootAsINoiseRemovalBoarderBase(_bb, default(INoiseRemovalBoarderBase));
		}

		// Token: 0x06024862 RID: 149602 RVA: 0x0050A658 File Offset: 0x00508858
		public static INoiseRemovalBoarderBase GetRootAsINoiseRemovalBoarderBase(ByteBuffer _bb, INoiseRemovalBoarderBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024863 RID: 149603 RVA: 0x0050A675 File Offset: 0x00508875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024864 RID: 149604 RVA: 0x0050A684 File Offset: 0x00508884
		public INoiseRemovalBoarderBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2E3 RID: 41699
		// (get) Token: 0x06024865 RID: 149605 RVA: 0x0050A694 File Offset: 0x00508894
		public ENoiseRemovalBoarderShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENoiseRemovalBoarderShape.Box;
				}
				return (ENoiseRemovalBoarderShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024866 RID: 149606 RVA: 0x0050A6D0 File Offset: 0x005088D0
		public static Offset<INoiseRemovalBoarderBase> CreateINoiseRemovalBoarderBase(FlatBufferBuilder builder, ENoiseRemovalBoarderShape Type = ENoiseRemovalBoarderShape.Box)
		{
			builder.StartTable(1);
			INoiseRemovalBoarderBase.AddType(builder, Type);
			return INoiseRemovalBoarderBase.EndINoiseRemovalBoarderBase(builder);
		}

		// Token: 0x06024867 RID: 149607 RVA: 0x0050A6E6 File Offset: 0x005088E6
		public static void StartINoiseRemovalBoarderBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024868 RID: 149608 RVA: 0x0050A6EF File Offset: 0x005088EF
		public static void AddType(FlatBufferBuilder builder, ENoiseRemovalBoarderShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024869 RID: 149609 RVA: 0x0050A6FA File Offset: 0x005088FA
		public static Offset<INoiseRemovalBoarderBase> EndINoiseRemovalBoarderBase(FlatBufferBuilder builder)
		{
			return new Offset<INoiseRemovalBoarderBase>(builder.EndTable());
		}

		// Token: 0x0602486A RID: 149610 RVA: 0x0050A708 File Offset: 0x00508908
		public INoiseRemovalBoarderBaseT UnPack()
		{
			INoiseRemovalBoarderBaseT noiseRemovalBoarderBaseT = new INoiseRemovalBoarderBaseT();
			this.UnPackTo(noiseRemovalBoarderBaseT);
			return noiseRemovalBoarderBaseT;
		}

		// Token: 0x0602486B RID: 149611 RVA: 0x0050A723 File Offset: 0x00508923
		public void UnPackTo(INoiseRemovalBoarderBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602486C RID: 149612 RVA: 0x0050A734 File Offset: 0x00508934
		public static Offset<INoiseRemovalBoarderBase> Pack(FlatBufferBuilder builder, INoiseRemovalBoarderBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoiseRemovalBoarderBase>);
			}
			return INoiseRemovalBoarderBase.CreateINoiseRemovalBoarderBase(builder, _o.Type);
		}

		// Token: 0x0400E974 RID: 59764
		private Table __p;
	}
}
