using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CF7 RID: 19703
	public struct IP4SyncData : IFlatbufferObject
	{
		// Token: 0x17008D09 RID: 36105
		// (get) Token: 0x0601E7C9 RID: 124873 RVA: 0x00445160 File Offset: 0x00443360
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E7CA RID: 124874 RVA: 0x0044516D File Offset: 0x0044336D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E7CB RID: 124875 RVA: 0x00445174 File Offset: 0x00443374
		public static IP4SyncData GetRootAsIP4SyncData(ByteBuffer _bb)
		{
			return IP4SyncData.GetRootAsIP4SyncData(_bb, default(IP4SyncData));
		}

		// Token: 0x0601E7CC RID: 124876 RVA: 0x00445190 File Offset: 0x00443390
		public static IP4SyncData GetRootAsIP4SyncData(ByteBuffer _bb, IP4SyncData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E7CD RID: 124877 RVA: 0x004451AD File Offset: 0x004433AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E7CE RID: 124878 RVA: 0x004451BC File Offset: 0x004433BC
		public IP4SyncData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D0A RID: 36106
		// (get) Token: 0x0601E7CF RID: 124879 RVA: 0x004451CC File Offset: 0x004433CC
		public EP4SyncMethodType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EP4SyncMethodType.EditorSavior;
				}
				return (EP4SyncMethodType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E7D0 RID: 124880 RVA: 0x00445208 File Offset: 0x00443408
		public static Offset<IP4SyncData> CreateIP4SyncData(FlatBufferBuilder builder, EP4SyncMethodType Type = EP4SyncMethodType.EditorSavior)
		{
			builder.StartTable(1);
			IP4SyncData.AddType(builder, Type);
			return IP4SyncData.EndIP4SyncData(builder);
		}

		// Token: 0x0601E7D1 RID: 124881 RVA: 0x0044521E File Offset: 0x0044341E
		public static void StartIP4SyncData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E7D2 RID: 124882 RVA: 0x00445227 File Offset: 0x00443427
		public static void AddType(FlatBufferBuilder builder, EP4SyncMethodType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E7D3 RID: 124883 RVA: 0x00445232 File Offset: 0x00443432
		public static Offset<IP4SyncData> EndIP4SyncData(FlatBufferBuilder builder)
		{
			return new Offset<IP4SyncData>(builder.EndTable());
		}

		// Token: 0x0601E7D4 RID: 124884 RVA: 0x00445240 File Offset: 0x00443440
		public IP4SyncDataT UnPack()
		{
			IP4SyncDataT ip4SyncDataT = new IP4SyncDataT();
			this.UnPackTo(ip4SyncDataT);
			return ip4SyncDataT;
		}

		// Token: 0x0601E7D5 RID: 124885 RVA: 0x0044525B File Offset: 0x0044345B
		public void UnPackTo(IP4SyncDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E7D6 RID: 124886 RVA: 0x0044526C File Offset: 0x0044346C
		public static Offset<IP4SyncData> Pack(FlatBufferBuilder builder, IP4SyncDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IP4SyncData>);
			}
			return IP4SyncData.CreateIP4SyncData(builder, _o.Type);
		}

		// Token: 0x0400D8B5 RID: 55477
		private Table __p;
	}
}
