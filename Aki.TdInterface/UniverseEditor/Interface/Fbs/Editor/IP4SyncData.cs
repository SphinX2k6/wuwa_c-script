using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004892 RID: 18578
	public struct IP4SyncData : IFlatbufferObject
	{
		// Token: 0x170086C1 RID: 34497
		// (get) Token: 0x0601CFDC RID: 118748 RVA: 0x004189C4 File Offset: 0x00416BC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CFDD RID: 118749 RVA: 0x004189D1 File Offset: 0x00416BD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CFDE RID: 118750 RVA: 0x004189D8 File Offset: 0x00416BD8
		public static IP4SyncData GetRootAsIP4SyncData(ByteBuffer _bb)
		{
			return IP4SyncData.GetRootAsIP4SyncData(_bb, default(IP4SyncData));
		}

		// Token: 0x0601CFDF RID: 118751 RVA: 0x004189F4 File Offset: 0x00416BF4
		public static IP4SyncData GetRootAsIP4SyncData(ByteBuffer _bb, IP4SyncData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CFE0 RID: 118752 RVA: 0x00418A11 File Offset: 0x00416C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CFE1 RID: 118753 RVA: 0x00418A20 File Offset: 0x00416C20
		public IP4SyncData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086C2 RID: 34498
		// (get) Token: 0x0601CFE2 RID: 118754 RVA: 0x00418A30 File Offset: 0x00416C30
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

		// Token: 0x0601CFE3 RID: 118755 RVA: 0x00418A6C File Offset: 0x00416C6C
		public static Offset<IP4SyncData> CreateIP4SyncData(FlatBufferBuilder builder, EP4SyncMethodType Type = EP4SyncMethodType.EditorSavior)
		{
			builder.StartTable(1);
			IP4SyncData.AddType(builder, Type);
			return IP4SyncData.EndIP4SyncData(builder);
		}

		// Token: 0x0601CFE4 RID: 118756 RVA: 0x00418A82 File Offset: 0x00416C82
		public static void StartIP4SyncData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CFE5 RID: 118757 RVA: 0x00418A8B File Offset: 0x00416C8B
		public static void AddType(FlatBufferBuilder builder, EP4SyncMethodType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CFE6 RID: 118758 RVA: 0x00418A96 File Offset: 0x00416C96
		public static Offset<IP4SyncData> EndIP4SyncData(FlatBufferBuilder builder)
		{
			return new Offset<IP4SyncData>(builder.EndTable());
		}

		// Token: 0x0601CFE7 RID: 118759 RVA: 0x00418AA4 File Offset: 0x00416CA4
		public IP4SyncDataT UnPack()
		{
			IP4SyncDataT ip4SyncDataT = new IP4SyncDataT();
			this.UnPackTo(ip4SyncDataT);
			return ip4SyncDataT;
		}

		// Token: 0x0601CFE8 RID: 118760 RVA: 0x00418ABF File Offset: 0x00416CBF
		public void UnPackTo(IP4SyncDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CFE9 RID: 118761 RVA: 0x00418AD0 File Offset: 0x00416CD0
		public static Offset<IP4SyncData> Pack(FlatBufferBuilder builder, IP4SyncDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IP4SyncData>);
			}
			return IP4SyncData.CreateIP4SyncData(builder, _o.Type);
		}

		// Token: 0x0400CE7C RID: 52860
		private Table __p;
	}
}
