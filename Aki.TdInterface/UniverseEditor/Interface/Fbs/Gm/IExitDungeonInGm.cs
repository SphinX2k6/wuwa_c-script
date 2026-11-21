using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AB0 RID: 19120
	public struct IExitDungeonInGm : IFlatbufferObject
	{
		// Token: 0x170085E7 RID: 34279
		// (get) Token: 0x0601CBE4 RID: 117732 RVA: 0x0040D06C File Offset: 0x0040B26C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CBE5 RID: 117733 RVA: 0x0040D079 File Offset: 0x0040B279
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CBE6 RID: 117734 RVA: 0x0040D080 File Offset: 0x0040B280
		public static IExitDungeonInGm GetRootAsIExitDungeonInGm(ByteBuffer _bb)
		{
			return IExitDungeonInGm.GetRootAsIExitDungeonInGm(_bb, default(IExitDungeonInGm));
		}

		// Token: 0x0601CBE7 RID: 117735 RVA: 0x0040D09C File Offset: 0x0040B29C
		public static IExitDungeonInGm GetRootAsIExitDungeonInGm(ByteBuffer _bb, IExitDungeonInGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CBE8 RID: 117736 RVA: 0x0040D0B9 File Offset: 0x0040B2B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CBE9 RID: 117737 RVA: 0x0040D0C8 File Offset: 0x0040B2C8
		public IExitDungeonInGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085E8 RID: 34280
		// (get) Token: 0x0601CBEA RID: 117738 RVA: 0x0040D0D8 File Offset: 0x0040B2D8
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CBEB RID: 117739 RVA: 0x0040D114 File Offset: 0x0040B314
		public static Offset<IExitDungeonInGm> CreateIExitDungeonInGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IExitDungeonInGm.AddType(builder, Type);
			return IExitDungeonInGm.EndIExitDungeonInGm(builder);
		}

		// Token: 0x0601CBEC RID: 117740 RVA: 0x0040D12A File Offset: 0x0040B32A
		public static void StartIExitDungeonInGm(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CBED RID: 117741 RVA: 0x0040D133 File Offset: 0x0040B333
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CBEE RID: 117742 RVA: 0x0040D13E File Offset: 0x0040B33E
		public static Offset<IExitDungeonInGm> EndIExitDungeonInGm(FlatBufferBuilder builder)
		{
			return new Offset<IExitDungeonInGm>(builder.EndTable());
		}

		// Token: 0x0601CBEF RID: 117743 RVA: 0x0040D14C File Offset: 0x0040B34C
		public IExitDungeonInGmT UnPack()
		{
			IExitDungeonInGmT exitDungeonInGmT = new IExitDungeonInGmT();
			this.UnPackTo(exitDungeonInGmT);
			return exitDungeonInGmT;
		}

		// Token: 0x0601CBF0 RID: 117744 RVA: 0x0040D167 File Offset: 0x0040B367
		public void UnPackTo(IExitDungeonInGmT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CBF1 RID: 117745 RVA: 0x0040D178 File Offset: 0x0040B378
		public static Offset<IExitDungeonInGm> Pack(FlatBufferBuilder builder, IExitDungeonInGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitDungeonInGm>);
			}
			return IExitDungeonInGm.CreateIExitDungeonInGm(builder, _o.Type);
		}

		// Token: 0x0400D1EC RID: 53740
		private Table __p;
	}
}
