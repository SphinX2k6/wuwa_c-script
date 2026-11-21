using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006068 RID: 24680
	public struct ITempleGuid : IFlatbufferObject
	{
		// Token: 0x1700B749 RID: 46921
		// (get) Token: 0x06029B20 RID: 170784 RVA: 0x005B16B3 File Offset: 0x005AF8B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029B21 RID: 170785 RVA: 0x005B16C0 File Offset: 0x005AF8C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029B22 RID: 170786 RVA: 0x005B16C8 File Offset: 0x005AF8C8
		public static ITempleGuid GetRootAsITempleGuid(ByteBuffer _bb)
		{
			return ITempleGuid.GetRootAsITempleGuid(_bb, default(ITempleGuid));
		}

		// Token: 0x06029B23 RID: 170787 RVA: 0x005B16E4 File Offset: 0x005AF8E4
		public static ITempleGuid GetRootAsITempleGuid(ByteBuffer _bb, ITempleGuid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029B24 RID: 170788 RVA: 0x005B1701 File Offset: 0x005AF901
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029B25 RID: 170789 RVA: 0x005B1710 File Offset: 0x005AF910
		public ITempleGuid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B74A RID: 46922
		// (get) Token: 0x06029B26 RID: 170790 RVA: 0x005B1720 File Offset: 0x005AF920
		public int TempleGuid
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

		// Token: 0x06029B27 RID: 170791 RVA: 0x005B175C File Offset: 0x005AF95C
		public static Offset<ITempleGuid> CreateITempleGuid(FlatBufferBuilder builder, int TempleGuid = 0)
		{
			builder.StartTable(1);
			ITempleGuid.AddTempleGuid(builder, TempleGuid);
			return ITempleGuid.EndITempleGuid(builder);
		}

		// Token: 0x06029B28 RID: 170792 RVA: 0x005B1772 File Offset: 0x005AF972
		public static void StartITempleGuid(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029B29 RID: 170793 RVA: 0x005B177B File Offset: 0x005AF97B
		public static void AddTempleGuid(FlatBufferBuilder builder, int templeGuid)
		{
			builder.AddInt(0, templeGuid, 0);
		}

		// Token: 0x06029B2A RID: 170794 RVA: 0x005B1786 File Offset: 0x005AF986
		public static Offset<ITempleGuid> EndITempleGuid(FlatBufferBuilder builder)
		{
			return new Offset<ITempleGuid>(builder.EndTable());
		}

		// Token: 0x06029B2B RID: 170795 RVA: 0x005B1794 File Offset: 0x005AF994
		public ITempleGuidT UnPack()
		{
			ITempleGuidT templeGuidT = new ITempleGuidT();
			this.UnPackTo(templeGuidT);
			return templeGuidT;
		}

		// Token: 0x06029B2C RID: 170796 RVA: 0x005B17AF File Offset: 0x005AF9AF
		public void UnPackTo(ITempleGuidT _o)
		{
			_o.TempleGuid = this.TempleGuid;
		}

		// Token: 0x06029B2D RID: 170797 RVA: 0x005B17C0 File Offset: 0x005AF9C0
		public static Offset<ITempleGuid> Pack(FlatBufferBuilder builder, ITempleGuidT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITempleGuid>);
			}
			return ITempleGuid.CreateITempleGuid(builder, _o.TempleGuid);
		}

		// Token: 0x0400FDE2 RID: 64994
		private Table __p;
	}
}
