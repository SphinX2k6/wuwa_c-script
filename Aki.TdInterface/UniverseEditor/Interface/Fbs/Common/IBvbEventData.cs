using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D4C RID: 23884
	public struct IBvbEventData : IFlatbufferObject
	{
		// Token: 0x1700B303 RID: 45827
		// (get) Token: 0x06028DB0 RID: 167344 RVA: 0x0059D655 File Offset: 0x0059B855
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028DB1 RID: 167345 RVA: 0x0059D662 File Offset: 0x0059B862
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028DB2 RID: 167346 RVA: 0x0059D66C File Offset: 0x0059B86C
		public static IBvbEventData GetRootAsIBvbEventData(ByteBuffer _bb)
		{
			return IBvbEventData.GetRootAsIBvbEventData(_bb, default(IBvbEventData));
		}

		// Token: 0x06028DB3 RID: 167347 RVA: 0x0059D688 File Offset: 0x0059B888
		public static IBvbEventData GetRootAsIBvbEventData(ByteBuffer _bb, IBvbEventData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028DB4 RID: 167348 RVA: 0x0059D6A5 File Offset: 0x0059B8A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028DB5 RID: 167349 RVA: 0x0059D6B4 File Offset: 0x0059B8B4
		public IBvbEventData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B304 RID: 45828
		// (get) Token: 0x06028DB6 RID: 167350 RVA: 0x0059D6C4 File Offset: 0x0059B8C4
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028DB7 RID: 167351 RVA: 0x0059D700 File Offset: 0x0059B900
		public static Offset<IBvbEventData> CreateIBvbEventData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbEventData.AddType(builder, Type);
			return IBvbEventData.EndIBvbEventData(builder);
		}

		// Token: 0x06028DB8 RID: 167352 RVA: 0x0059D716 File Offset: 0x0059B916
		public static void StartIBvbEventData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028DB9 RID: 167353 RVA: 0x0059D71F File Offset: 0x0059B91F
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028DBA RID: 167354 RVA: 0x0059D72A File Offset: 0x0059B92A
		public static Offset<IBvbEventData> EndIBvbEventData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbEventData>(builder.EndTable());
		}

		// Token: 0x06028DBB RID: 167355 RVA: 0x0059D738 File Offset: 0x0059B938
		public IBvbEventDataT UnPack()
		{
			IBvbEventDataT bvbEventDataT = new IBvbEventDataT();
			this.UnPackTo(bvbEventDataT);
			return bvbEventDataT;
		}

		// Token: 0x06028DBC RID: 167356 RVA: 0x0059D753 File Offset: 0x0059B953
		public void UnPackTo(IBvbEventDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028DBD RID: 167357 RVA: 0x0059D764 File Offset: 0x0059B964
		public static Offset<IBvbEventData> Pack(FlatBufferBuilder builder, IBvbEventDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbEventData>);
			}
			return IBvbEventData.CreateIBvbEventData(builder, _o.Type);
		}

		// Token: 0x0400F700 RID: 63232
		private Table __p;
	}
}
