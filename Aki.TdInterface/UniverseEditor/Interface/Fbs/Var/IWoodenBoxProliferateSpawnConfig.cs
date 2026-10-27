using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B35 RID: 15157
	public struct IWoodenBoxProliferateSpawnConfig : IFlatbufferObject
	{
		// Token: 0x17006805 RID: 26629
		// (get) Token: 0x06014B73 RID: 84851 RVA: 0x00303430 File Offset: 0x00301630
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014B74 RID: 84852 RVA: 0x0030343D File Offset: 0x0030163D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014B75 RID: 84853 RVA: 0x00303444 File Offset: 0x00301644
		public static IWoodenBoxProliferateSpawnConfig GetRootAsIWoodenBoxProliferateSpawnConfig(ByteBuffer _bb)
		{
			return IWoodenBoxProliferateSpawnConfig.GetRootAsIWoodenBoxProliferateSpawnConfig(_bb, default(IWoodenBoxProliferateSpawnConfig));
		}

		// Token: 0x06014B76 RID: 84854 RVA: 0x00303460 File Offset: 0x00301660
		public static IWoodenBoxProliferateSpawnConfig GetRootAsIWoodenBoxProliferateSpawnConfig(ByteBuffer _bb, IWoodenBoxProliferateSpawnConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014B77 RID: 84855 RVA: 0x0030347D File Offset: 0x0030167D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014B78 RID: 84856 RVA: 0x0030348C File Offset: 0x0030168C
		public IWoodenBoxProliferateSpawnConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006806 RID: 26630
		// (get) Token: 0x06014B79 RID: 84857 RVA: 0x0030349C File Offset: 0x0030169C
		public EWoodenBoxProliferateSpawnType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWoodenBoxProliferateSpawnType.RandomInRange;
				}
				return (EWoodenBoxProliferateSpawnType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014B7A RID: 84858 RVA: 0x003034D8 File Offset: 0x003016D8
		public static Offset<IWoodenBoxProliferateSpawnConfig> CreateIWoodenBoxProliferateSpawnConfig(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType Type = EWoodenBoxProliferateSpawnType.RandomInRange)
		{
			builder.StartTable(1);
			IWoodenBoxProliferateSpawnConfig.AddType(builder, Type);
			return IWoodenBoxProliferateSpawnConfig.EndIWoodenBoxProliferateSpawnConfig(builder);
		}

		// Token: 0x06014B7B RID: 84859 RVA: 0x003034EE File Offset: 0x003016EE
		public static void StartIWoodenBoxProliferateSpawnConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014B7C RID: 84860 RVA: 0x003034F7 File Offset: 0x003016F7
		public static void AddType(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014B7D RID: 84861 RVA: 0x00303502 File Offset: 0x00301702
		public static Offset<IWoodenBoxProliferateSpawnConfig> EndIWoodenBoxProliferateSpawnConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenBoxProliferateSpawnConfig>(builder.EndTable());
		}

		// Token: 0x06014B7E RID: 84862 RVA: 0x00303510 File Offset: 0x00301710
		public IWoodenBoxProliferateSpawnConfigT UnPack()
		{
			IWoodenBoxProliferateSpawnConfigT woodenBoxProliferateSpawnConfigT = new IWoodenBoxProliferateSpawnConfigT();
			this.UnPackTo(woodenBoxProliferateSpawnConfigT);
			return woodenBoxProliferateSpawnConfigT;
		}

		// Token: 0x06014B7F RID: 84863 RVA: 0x0030352B File Offset: 0x0030172B
		public void UnPackTo(IWoodenBoxProliferateSpawnConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014B80 RID: 84864 RVA: 0x0030353C File Offset: 0x0030173C
		public static Offset<IWoodenBoxProliferateSpawnConfig> Pack(FlatBufferBuilder builder, IWoodenBoxProliferateSpawnConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWoodenBoxProliferateSpawnConfig>);
			}
			return IWoodenBoxProliferateSpawnConfig.CreateIWoodenBoxProliferateSpawnConfig(builder, _o.Type);
		}

		// Token: 0x0400B016 RID: 45078
		private Table __p;
	}
}
