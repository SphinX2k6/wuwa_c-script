using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582F RID: 22575
	public struct IRefreshOnHostInteract : IFlatbufferObject
	{
		// Token: 0x1700A8A4 RID: 43172
		// (get) Token: 0x06025F85 RID: 155525 RVA: 0x0053C319 File Offset: 0x0053A519
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025F86 RID: 155526 RVA: 0x0053C326 File Offset: 0x0053A526
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025F87 RID: 155527 RVA: 0x0053C330 File Offset: 0x0053A530
		public static IRefreshOnHostInteract GetRootAsIRefreshOnHostInteract(ByteBuffer _bb)
		{
			return IRefreshOnHostInteract.GetRootAsIRefreshOnHostInteract(_bb, default(IRefreshOnHostInteract));
		}

		// Token: 0x06025F88 RID: 155528 RVA: 0x0053C34C File Offset: 0x0053A54C
		public static IRefreshOnHostInteract GetRootAsIRefreshOnHostInteract(ByteBuffer _bb, IRefreshOnHostInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025F89 RID: 155529 RVA: 0x0053C369 File Offset: 0x0053A569
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025F8A RID: 155530 RVA: 0x0053C378 File Offset: 0x0053A578
		public IRefreshOnHostInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8A5 RID: 43173
		// (get) Token: 0x06025F8B RID: 155531 RVA: 0x0053C388 File Offset: 0x0053A588
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

		// Token: 0x06025F8C RID: 155532 RVA: 0x0053C3C4 File Offset: 0x0053A5C4
		public static Offset<IRefreshOnHostInteract> CreateIRefreshOnHostInteract(FlatBufferBuilder builder, ERewardDropType Type = ERewardDropType.Death)
		{
			builder.StartTable(1);
			IRefreshOnHostInteract.AddType(builder, Type);
			return IRefreshOnHostInteract.EndIRefreshOnHostInteract(builder);
		}

		// Token: 0x06025F8D RID: 155533 RVA: 0x0053C3DA File Offset: 0x0053A5DA
		public static void StartIRefreshOnHostInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025F8E RID: 155534 RVA: 0x0053C3E3 File Offset: 0x0053A5E3
		public static void AddType(FlatBufferBuilder builder, ERewardDropType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025F8F RID: 155535 RVA: 0x0053C3EE File Offset: 0x0053A5EE
		public static Offset<IRefreshOnHostInteract> EndIRefreshOnHostInteract(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshOnHostInteract>(builder.EndTable());
		}

		// Token: 0x06025F90 RID: 155536 RVA: 0x0053C3FC File Offset: 0x0053A5FC
		public IRefreshOnHostInteractT UnPack()
		{
			IRefreshOnHostInteractT refreshOnHostInteractT = new IRefreshOnHostInteractT();
			this.UnPackTo(refreshOnHostInteractT);
			return refreshOnHostInteractT;
		}

		// Token: 0x06025F91 RID: 155537 RVA: 0x0053C417 File Offset: 0x0053A617
		public void UnPackTo(IRefreshOnHostInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025F92 RID: 155538 RVA: 0x0053C428 File Offset: 0x0053A628
		public static Offset<IRefreshOnHostInteract> Pack(FlatBufferBuilder builder, IRefreshOnHostInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshOnHostInteract>);
			}
			return IRefreshOnHostInteract.CreateIRefreshOnHostInteract(builder, _o.Type);
		}

		// Token: 0x0400ED41 RID: 60737
		private Table __p;
	}
}
