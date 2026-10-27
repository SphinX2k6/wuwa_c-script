using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004648 RID: 17992
	public struct IExitDungeonInGm : IFlatbufferObject
	{
		// Token: 0x17007FA6 RID: 32678
		// (get) Token: 0x0601B40F RID: 111631 RVA: 0x003E0DD0 File Offset: 0x003DEFD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B410 RID: 111632 RVA: 0x003E0DDD File Offset: 0x003DEFDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B411 RID: 111633 RVA: 0x003E0DE4 File Offset: 0x003DEFE4
		public static IExitDungeonInGm GetRootAsIExitDungeonInGm(ByteBuffer _bb)
		{
			return IExitDungeonInGm.GetRootAsIExitDungeonInGm(_bb, default(IExitDungeonInGm));
		}

		// Token: 0x0601B412 RID: 111634 RVA: 0x003E0E00 File Offset: 0x003DF000
		public static IExitDungeonInGm GetRootAsIExitDungeonInGm(ByteBuffer _bb, IExitDungeonInGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B413 RID: 111635 RVA: 0x003E0E1D File Offset: 0x003DF01D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B414 RID: 111636 RVA: 0x003E0E2C File Offset: 0x003DF02C
		public IExitDungeonInGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FA7 RID: 32679
		// (get) Token: 0x0601B415 RID: 111637 RVA: 0x003E0E3C File Offset: 0x003DF03C
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

		// Token: 0x0601B416 RID: 111638 RVA: 0x003E0E78 File Offset: 0x003DF078
		public static Offset<IExitDungeonInGm> CreateIExitDungeonInGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IExitDungeonInGm.AddType(builder, Type);
			return IExitDungeonInGm.EndIExitDungeonInGm(builder);
		}

		// Token: 0x0601B417 RID: 111639 RVA: 0x003E0E8E File Offset: 0x003DF08E
		public static void StartIExitDungeonInGm(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B418 RID: 111640 RVA: 0x003E0E97 File Offset: 0x003DF097
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B419 RID: 111641 RVA: 0x003E0EA2 File Offset: 0x003DF0A2
		public static Offset<IExitDungeonInGm> EndIExitDungeonInGm(FlatBufferBuilder builder)
		{
			return new Offset<IExitDungeonInGm>(builder.EndTable());
		}

		// Token: 0x0601B41A RID: 111642 RVA: 0x003E0EB0 File Offset: 0x003DF0B0
		public IExitDungeonInGmT UnPack()
		{
			IExitDungeonInGmT exitDungeonInGmT = new IExitDungeonInGmT();
			this.UnPackTo(exitDungeonInGmT);
			return exitDungeonInGmT;
		}

		// Token: 0x0601B41B RID: 111643 RVA: 0x003E0ECB File Offset: 0x003DF0CB
		public void UnPackTo(IExitDungeonInGmT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B41C RID: 111644 RVA: 0x003E0EDC File Offset: 0x003DF0DC
		public static Offset<IExitDungeonInGm> Pack(FlatBufferBuilder builder, IExitDungeonInGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitDungeonInGm>);
			}
			return IExitDungeonInGm.CreateIExitDungeonInGm(builder, _o.Type);
		}

		// Token: 0x0400C7BD RID: 51133
		private Table __p;
	}
}
