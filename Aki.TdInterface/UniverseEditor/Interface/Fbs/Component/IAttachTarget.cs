using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E2 RID: 21474
	public struct IAttachTarget : IFlatbufferObject
	{
		// Token: 0x170097F5 RID: 38901
		// (get) Token: 0x060218C9 RID: 137417 RVA: 0x004A0491 File Offset: 0x0049E691
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060218CA RID: 137418 RVA: 0x004A049E File Offset: 0x0049E69E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060218CB RID: 137419 RVA: 0x004A04A8 File Offset: 0x0049E6A8
		public static IAttachTarget GetRootAsIAttachTarget(ByteBuffer _bb)
		{
			return IAttachTarget.GetRootAsIAttachTarget(_bb, default(IAttachTarget));
		}

		// Token: 0x060218CC RID: 137420 RVA: 0x004A04C4 File Offset: 0x0049E6C4
		public static IAttachTarget GetRootAsIAttachTarget(ByteBuffer _bb, IAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060218CD RID: 137421 RVA: 0x004A04E1 File Offset: 0x0049E6E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060218CE RID: 137422 RVA: 0x004A04F0 File Offset: 0x0049E6F0
		public IAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097F6 RID: 38902
		// (get) Token: 0x060218CF RID: 137423 RVA: 0x004A0500 File Offset: 0x0049E700
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

		// Token: 0x060218D0 RID: 137424 RVA: 0x004A053C File Offset: 0x0049E73C
		public static Offset<IAttachTarget> CreateIAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor)
		{
			builder.StartTable(1);
			IAttachTarget.AddType(builder, Type);
			return IAttachTarget.EndIAttachTarget(builder);
		}

		// Token: 0x060218D1 RID: 137425 RVA: 0x004A0552 File Offset: 0x0049E752
		public static void StartIAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060218D2 RID: 137426 RVA: 0x004A055B File Offset: 0x0049E75B
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060218D3 RID: 137427 RVA: 0x004A0566 File Offset: 0x0049E766
		public static Offset<IAttachTarget> EndIAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IAttachTarget>(builder.EndTable());
		}

		// Token: 0x060218D4 RID: 137428 RVA: 0x004A0574 File Offset: 0x0049E774
		public IAttachTargetT UnPack()
		{
			IAttachTargetT attachTargetT = new IAttachTargetT();
			this.UnPackTo(attachTargetT);
			return attachTargetT;
		}

		// Token: 0x060218D5 RID: 137429 RVA: 0x004A058F File Offset: 0x0049E78F
		public void UnPackTo(IAttachTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060218D6 RID: 137430 RVA: 0x004A05A0 File Offset: 0x0049E7A0
		public static Offset<IAttachTarget> Pack(FlatBufferBuilder builder, IAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttachTarget>);
			}
			return IAttachTarget.CreateIAttachTarget(builder, _o.Type);
		}

		// Token: 0x0400E83D RID: 59453
		private Table __p;
	}
}
