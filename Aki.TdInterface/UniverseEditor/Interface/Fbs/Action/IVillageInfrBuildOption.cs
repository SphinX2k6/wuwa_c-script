using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200753E RID: 30014
	public struct IVillageInfrBuildOption : IFlatbufferObject
	{
		// Token: 0x1700E3BF RID: 58303
		// (get) Token: 0x060369BE RID: 223678 RVA: 0x0076B500 File Offset: 0x00769700
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060369BF RID: 223679 RVA: 0x0076B50D File Offset: 0x0076970D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060369C0 RID: 223680 RVA: 0x0076B514 File Offset: 0x00769714
		public static IVillageInfrBuildOption GetRootAsIVillageInfrBuildOption(ByteBuffer _bb)
		{
			return IVillageInfrBuildOption.GetRootAsIVillageInfrBuildOption(_bb, default(IVillageInfrBuildOption));
		}

		// Token: 0x060369C1 RID: 223681 RVA: 0x0076B530 File Offset: 0x00769730
		public static IVillageInfrBuildOption GetRootAsIVillageInfrBuildOption(ByteBuffer _bb, IVillageInfrBuildOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060369C2 RID: 223682 RVA: 0x0076B54D File Offset: 0x0076974D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060369C3 RID: 223683 RVA: 0x0076B55C File Offset: 0x0076975C
		public IVillageInfrBuildOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3C0 RID: 58304
		// (get) Token: 0x060369C4 RID: 223684 RVA: 0x0076B56C File Offset: 0x0076976C
		public EVillageInfrBuildType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVillageInfrBuildType.Village;
				}
				return (EVillageInfrBuildType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060369C5 RID: 223685 RVA: 0x0076B5A8 File Offset: 0x007697A8
		public static Offset<IVillageInfrBuildOption> CreateIVillageInfrBuildOption(FlatBufferBuilder builder, EVillageInfrBuildType Type = EVillageInfrBuildType.Village)
		{
			builder.StartTable(1);
			IVillageInfrBuildOption.AddType(builder, Type);
			return IVillageInfrBuildOption.EndIVillageInfrBuildOption(builder);
		}

		// Token: 0x060369C6 RID: 223686 RVA: 0x0076B5BE File Offset: 0x007697BE
		public static void StartIVillageInfrBuildOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060369C7 RID: 223687 RVA: 0x0076B5C7 File Offset: 0x007697C7
		public static void AddType(FlatBufferBuilder builder, EVillageInfrBuildType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060369C8 RID: 223688 RVA: 0x0076B5D2 File Offset: 0x007697D2
		public static Offset<IVillageInfrBuildOption> EndIVillageInfrBuildOption(FlatBufferBuilder builder)
		{
			return new Offset<IVillageInfrBuildOption>(builder.EndTable());
		}

		// Token: 0x060369C9 RID: 223689 RVA: 0x0076B5E0 File Offset: 0x007697E0
		public IVillageInfrBuildOptionT UnPack()
		{
			IVillageInfrBuildOptionT villageInfrBuildOptionT = new IVillageInfrBuildOptionT();
			this.UnPackTo(villageInfrBuildOptionT);
			return villageInfrBuildOptionT;
		}

		// Token: 0x060369CA RID: 223690 RVA: 0x0076B5FB File Offset: 0x007697FB
		public void UnPackTo(IVillageInfrBuildOptionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060369CB RID: 223691 RVA: 0x0076B60C File Offset: 0x0076980C
		public static Offset<IVillageInfrBuildOption> Pack(FlatBufferBuilder builder, IVillageInfrBuildOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVillageInfrBuildOption>);
			}
			return IVillageInfrBuildOption.CreateIVillageInfrBuildOption(builder, _o.Type);
		}

		// Token: 0x04012431 RID: 74801
		private Table __p;
	}
}
