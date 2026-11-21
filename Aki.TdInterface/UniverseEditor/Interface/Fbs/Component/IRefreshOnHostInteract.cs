using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E36 RID: 24118
	public struct IRefreshOnHostInteract : IFlatbufferObject
	{
		// Token: 0x1700B1C8 RID: 45512
		// (get) Token: 0x060284A5 RID: 165029 RVA: 0x005824A5 File Offset: 0x005806A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060284A6 RID: 165030 RVA: 0x005824B2 File Offset: 0x005806B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060284A7 RID: 165031 RVA: 0x005824BC File Offset: 0x005806BC
		public static IRefreshOnHostInteract GetRootAsIRefreshOnHostInteract(ByteBuffer _bb)
		{
			return IRefreshOnHostInteract.GetRootAsIRefreshOnHostInteract(_bb, default(IRefreshOnHostInteract));
		}

		// Token: 0x060284A8 RID: 165032 RVA: 0x005824D8 File Offset: 0x005806D8
		public static IRefreshOnHostInteract GetRootAsIRefreshOnHostInteract(ByteBuffer _bb, IRefreshOnHostInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060284A9 RID: 165033 RVA: 0x005824F5 File Offset: 0x005806F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060284AA RID: 165034 RVA: 0x00582504 File Offset: 0x00580704
		public IRefreshOnHostInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1C9 RID: 45513
		// (get) Token: 0x060284AB RID: 165035 RVA: 0x00582514 File Offset: 0x00580714
		public ERewardDropType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERewardDropType.Death;
				}
				return (ERewardDropType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060284AC RID: 165036 RVA: 0x00582550 File Offset: 0x00580750
		public static Offset<IRefreshOnHostInteract> CreateIRefreshOnHostInteract(FlatBufferBuilder builder, ERewardDropType Type = ERewardDropType.Death)
		{
			builder.StartTable(1);
			IRefreshOnHostInteract.AddType(builder, Type);
			return IRefreshOnHostInteract.EndIRefreshOnHostInteract(builder);
		}

		// Token: 0x060284AD RID: 165037 RVA: 0x00582566 File Offset: 0x00580766
		public static void StartIRefreshOnHostInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060284AE RID: 165038 RVA: 0x0058256F File Offset: 0x0058076F
		public static void AddType(FlatBufferBuilder builder, ERewardDropType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060284AF RID: 165039 RVA: 0x0058257A File Offset: 0x0058077A
		public static Offset<IRefreshOnHostInteract> EndIRefreshOnHostInteract(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshOnHostInteract>(builder.EndTable());
		}

		// Token: 0x060284B0 RID: 165040 RVA: 0x00582588 File Offset: 0x00580788
		public IRefreshOnHostInteractT UnPack()
		{
			IRefreshOnHostInteractT refreshOnHostInteractT = new IRefreshOnHostInteractT();
			this.UnPackTo(refreshOnHostInteractT);
			return refreshOnHostInteractT;
		}

		// Token: 0x060284B1 RID: 165041 RVA: 0x005825A3 File Offset: 0x005807A3
		public void UnPackTo(IRefreshOnHostInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060284B2 RID: 165042 RVA: 0x005825B4 File Offset: 0x005807B4
		public static Offset<IRefreshOnHostInteract> Pack(FlatBufferBuilder builder, IRefreshOnHostInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshOnHostInteract>);
			}
			return IRefreshOnHostInteract.CreateIRefreshOnHostInteract(builder, _o.Type);
		}

		// Token: 0x0400FA2C RID: 64044
		private Table __p;
	}
}
