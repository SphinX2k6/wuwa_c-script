using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007007 RID: 28679
	public struct IInfrActivityUpgradeInfrastructure : IFlatbufferObject
	{
		// Token: 0x1700D206 RID: 53766
		// (get) Token: 0x06031B14 RID: 203540 RVA: 0x006BAD0E File Offset: 0x006B8F0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B15 RID: 203541 RVA: 0x006BAD1B File Offset: 0x006B8F1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B16 RID: 203542 RVA: 0x006BAD24 File Offset: 0x006B8F24
		public static IInfrActivityUpgradeInfrastructure GetRootAsIInfrActivityUpgradeInfrastructure(ByteBuffer _bb)
		{
			return IInfrActivityUpgradeInfrastructure.GetRootAsIInfrActivityUpgradeInfrastructure(_bb, default(IInfrActivityUpgradeInfrastructure));
		}

		// Token: 0x06031B17 RID: 203543 RVA: 0x006BAD40 File Offset: 0x006B8F40
		public static IInfrActivityUpgradeInfrastructure GetRootAsIInfrActivityUpgradeInfrastructure(ByteBuffer _bb, IInfrActivityUpgradeInfrastructure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B18 RID: 203544 RVA: 0x006BAD5D File Offset: 0x006B8F5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B19 RID: 203545 RVA: 0x006BAD6C File Offset: 0x006B8F6C
		public IInfrActivityUpgradeInfrastructure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D207 RID: 53767
		// (get) Token: 0x06031B1A RID: 203546 RVA: 0x006BAD7C File Offset: 0x006B8F7C
		public int Level
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

		// Token: 0x06031B1B RID: 203547 RVA: 0x006BADB8 File Offset: 0x006B8FB8
		public static Offset<IInfrActivityUpgradeInfrastructure> CreateIInfrActivityUpgradeInfrastructure(FlatBufferBuilder builder, int Level = 0)
		{
			builder.StartTable(1);
			IInfrActivityUpgradeInfrastructure.AddLevel(builder, Level);
			return IInfrActivityUpgradeInfrastructure.EndIInfrActivityUpgradeInfrastructure(builder);
		}

		// Token: 0x06031B1C RID: 203548 RVA: 0x006BADCE File Offset: 0x006B8FCE
		public static void StartIInfrActivityUpgradeInfrastructure(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031B1D RID: 203549 RVA: 0x006BADD7 File Offset: 0x006B8FD7
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(0, level, 0);
		}

		// Token: 0x06031B1E RID: 203550 RVA: 0x006BADE2 File Offset: 0x006B8FE2
		public static Offset<IInfrActivityUpgradeInfrastructure> EndIInfrActivityUpgradeInfrastructure(FlatBufferBuilder builder)
		{
			return new Offset<IInfrActivityUpgradeInfrastructure>(builder.EndTable());
		}

		// Token: 0x06031B1F RID: 203551 RVA: 0x006BADF0 File Offset: 0x006B8FF0
		public IInfrActivityUpgradeInfrastructureT UnPack()
		{
			IInfrActivityUpgradeInfrastructureT infrActivityUpgradeInfrastructureT = new IInfrActivityUpgradeInfrastructureT();
			this.UnPackTo(infrActivityUpgradeInfrastructureT);
			return infrActivityUpgradeInfrastructureT;
		}

		// Token: 0x06031B20 RID: 203552 RVA: 0x006BAE0B File Offset: 0x006B900B
		public void UnPackTo(IInfrActivityUpgradeInfrastructureT _o)
		{
			_o.Level = this.Level;
		}

		// Token: 0x06031B21 RID: 203553 RVA: 0x006BAE1C File Offset: 0x006B901C
		public static Offset<IInfrActivityUpgradeInfrastructure> Pack(FlatBufferBuilder builder, IInfrActivityUpgradeInfrastructureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrActivityUpgradeInfrastructure>);
			}
			return IInfrActivityUpgradeInfrastructure.CreateIInfrActivityUpgradeInfrastructure(builder, _o.Level);
		}

		// Token: 0x04011F41 RID: 73537
		private Table __p;
	}
}
