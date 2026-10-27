using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005748 RID: 22344
	public struct IPlayerAttachTarget : IFlatbufferObject
	{
		// Token: 0x1700A6B4 RID: 42676
		// (get) Token: 0x06025707 RID: 153351 RVA: 0x0052AA3D File Offset: 0x00528C3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025708 RID: 153352 RVA: 0x0052AA4A File Offset: 0x00528C4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025709 RID: 153353 RVA: 0x0052AA54 File Offset: 0x00528C54
		public static IPlayerAttachTarget GetRootAsIPlayerAttachTarget(ByteBuffer _bb)
		{
			return IPlayerAttachTarget.GetRootAsIPlayerAttachTarget(_bb, default(IPlayerAttachTarget));
		}

		// Token: 0x0602570A RID: 153354 RVA: 0x0052AA70 File Offset: 0x00528C70
		public static IPlayerAttachTarget GetRootAsIPlayerAttachTarget(ByteBuffer _bb, IPlayerAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602570B RID: 153355 RVA: 0x0052AA8D File Offset: 0x00528C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602570C RID: 153356 RVA: 0x0052AA9C File Offset: 0x00528C9C
		public IPlayerAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6B5 RID: 42677
		// (get) Token: 0x0602570D RID: 153357 RVA: 0x0052AAAC File Offset: 0x00528CAC
		public EAttachType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachType.Actor;
				}
				return (EAttachType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602570E RID: 153358 RVA: 0x0052AAE8 File Offset: 0x00528CE8
		public static Offset<IPlayerAttachTarget> CreateIPlayerAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor)
		{
			builder.StartTable(1);
			IPlayerAttachTarget.AddType(builder, Type);
			return IPlayerAttachTarget.EndIPlayerAttachTarget(builder);
		}

		// Token: 0x0602570F RID: 153359 RVA: 0x0052AAFE File Offset: 0x00528CFE
		public static void StartIPlayerAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025710 RID: 153360 RVA: 0x0052AB07 File Offset: 0x00528D07
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025711 RID: 153361 RVA: 0x0052AB12 File Offset: 0x00528D12
		public static Offset<IPlayerAttachTarget> EndIPlayerAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerAttachTarget>(builder.EndTable());
		}

		// Token: 0x06025712 RID: 153362 RVA: 0x0052AB20 File Offset: 0x00528D20
		public IPlayerAttachTargetT UnPack()
		{
			IPlayerAttachTargetT playerAttachTargetT = new IPlayerAttachTargetT();
			this.UnPackTo(playerAttachTargetT);
			return playerAttachTargetT;
		}

		// Token: 0x06025713 RID: 153363 RVA: 0x0052AB3B File Offset: 0x00528D3B
		public void UnPackTo(IPlayerAttachTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025714 RID: 153364 RVA: 0x0052AB4C File Offset: 0x00528D4C
		public static Offset<IPlayerAttachTarget> Pack(FlatBufferBuilder builder, IPlayerAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerAttachTarget>);
			}
			return IPlayerAttachTarget.CreateIPlayerAttachTarget(builder, _o.Type);
		}

		// Token: 0x0400EBE5 RID: 60389
		private Table __p;
	}
}
