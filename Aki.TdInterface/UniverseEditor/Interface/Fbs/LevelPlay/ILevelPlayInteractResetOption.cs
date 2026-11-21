using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004968 RID: 18792
	public struct ILevelPlayInteractResetOption : IFlatbufferObject
	{
		// Token: 0x17008377 RID: 33655
		// (get) Token: 0x0601C040 RID: 114752 RVA: 0x003F6028 File Offset: 0x003F4228
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C041 RID: 114753 RVA: 0x003F6035 File Offset: 0x003F4235
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C042 RID: 114754 RVA: 0x003F603C File Offset: 0x003F423C
		public static ILevelPlayInteractResetOption GetRootAsILevelPlayInteractResetOption(ByteBuffer _bb)
		{
			return ILevelPlayInteractResetOption.GetRootAsILevelPlayInteractResetOption(_bb, default(ILevelPlayInteractResetOption));
		}

		// Token: 0x0601C043 RID: 114755 RVA: 0x003F6058 File Offset: 0x003F4258
		public static ILevelPlayInteractResetOption GetRootAsILevelPlayInteractResetOption(ByteBuffer _bb, ILevelPlayInteractResetOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C044 RID: 114756 RVA: 0x003F6075 File Offset: 0x003F4275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C045 RID: 114757 RVA: 0x003F6084 File Offset: 0x003F4284
		public ILevelPlayInteractResetOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008378 RID: 33656
		// (get) Token: 0x0601C046 RID: 114758 RVA: 0x003F6094 File Offset: 0x003F4294
		public int Count
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008379 RID: 33657
		// (get) Token: 0x0601C047 RID: 114759 RVA: 0x003F60D0 File Offset: 0x003F42D0
		public ELevelPlayInteractResetTime Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ELevelPlayInteractResetTime.Weekly;
				}
				return (ELevelPlayInteractResetTime)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C048 RID: 114760 RVA: 0x003F610C File Offset: 0x003F430C
		public static Offset<ILevelPlayInteractResetOption> CreateILevelPlayInteractResetOption(FlatBufferBuilder builder, int Count = 0, ELevelPlayInteractResetTime Type = ELevelPlayInteractResetTime.Weekly)
		{
			builder.StartTable(2);
			ILevelPlayInteractResetOption.AddCount(builder, Count);
			ILevelPlayInteractResetOption.AddType(builder, Type);
			return ILevelPlayInteractResetOption.EndILevelPlayInteractResetOption(builder);
		}

		// Token: 0x0601C049 RID: 114761 RVA: 0x003F6129 File Offset: 0x003F4329
		public static void StartILevelPlayInteractResetOption(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C04A RID: 114762 RVA: 0x003F6132 File Offset: 0x003F4332
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(0, count, 0);
		}

		// Token: 0x0601C04B RID: 114763 RVA: 0x003F613D File Offset: 0x003F433D
		public static void AddType(FlatBufferBuilder builder, ELevelPlayInteractResetTime type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601C04C RID: 114764 RVA: 0x003F6148 File Offset: 0x003F4348
		public static Offset<ILevelPlayInteractResetOption> EndILevelPlayInteractResetOption(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInteractResetOption>(builder.EndTable());
		}

		// Token: 0x0601C04D RID: 114765 RVA: 0x003F6158 File Offset: 0x003F4358
		public ILevelPlayInteractResetOptionT UnPack()
		{
			ILevelPlayInteractResetOptionT levelPlayInteractResetOptionT = new ILevelPlayInteractResetOptionT();
			this.UnPackTo(levelPlayInteractResetOptionT);
			return levelPlayInteractResetOptionT;
		}

		// Token: 0x0601C04E RID: 114766 RVA: 0x003F6173 File Offset: 0x003F4373
		public void UnPackTo(ILevelPlayInteractResetOptionT _o)
		{
			_o.Count = this.Count;
			_o.Type = this.Type;
		}

		// Token: 0x0601C04F RID: 114767 RVA: 0x003F6190 File Offset: 0x003F4390
		public static Offset<ILevelPlayInteractResetOption> Pack(FlatBufferBuilder builder, ILevelPlayInteractResetOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayInteractResetOption>);
			}
			return ILevelPlayInteractResetOption.CreateILevelPlayInteractResetOption(builder, _o.Count, _o.Type);
		}

		// Token: 0x0400CF95 RID: 53141
		private Table __p;
	}
}
