using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004395 RID: 17301
	public struct IClosedSegmentOccupationData : IFlatbufferObject
	{
		// Token: 0x17007A4B RID: 31307
		// (get) Token: 0x06019BE1 RID: 105441 RVA: 0x003AF98E File Offset: 0x003ADB8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019BE2 RID: 105442 RVA: 0x003AF99B File Offset: 0x003ADB9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019BE3 RID: 105443 RVA: 0x003AF9A4 File Offset: 0x003ADBA4
		public static IClosedSegmentOccupationData GetRootAsIClosedSegmentOccupationData(ByteBuffer _bb)
		{
			return IClosedSegmentOccupationData.GetRootAsIClosedSegmentOccupationData(_bb, default(IClosedSegmentOccupationData));
		}

		// Token: 0x06019BE4 RID: 105444 RVA: 0x003AF9C0 File Offset: 0x003ADBC0
		public static IClosedSegmentOccupationData GetRootAsIClosedSegmentOccupationData(ByteBuffer _bb, IClosedSegmentOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019BE5 RID: 105445 RVA: 0x003AF9DD File Offset: 0x003ADBDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019BE6 RID: 105446 RVA: 0x003AF9EC File Offset: 0x003ADBEC
		public IClosedSegmentOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A4C RID: 31308
		// (get) Token: 0x06019BE7 RID: 105447 RVA: 0x003AF9FC File Offset: 0x003ADBFC
		public EOccupationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOccupationType.Npc;
				}
				return (EOccupationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019BE8 RID: 105448 RVA: 0x003AFA38 File Offset: 0x003ADC38
		public static Offset<IClosedSegmentOccupationData> CreateIClosedSegmentOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			IClosedSegmentOccupationData.AddType(builder, Type);
			return IClosedSegmentOccupationData.EndIClosedSegmentOccupationData(builder);
		}

		// Token: 0x06019BE9 RID: 105449 RVA: 0x003AFA4E File Offset: 0x003ADC4E
		public static void StartIClosedSegmentOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019BEA RID: 105450 RVA: 0x003AFA57 File Offset: 0x003ADC57
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019BEB RID: 105451 RVA: 0x003AFA62 File Offset: 0x003ADC62
		public static Offset<IClosedSegmentOccupationData> EndIClosedSegmentOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<IClosedSegmentOccupationData>(builder.EndTable());
		}

		// Token: 0x06019BEC RID: 105452 RVA: 0x003AFA70 File Offset: 0x003ADC70
		public IClosedSegmentOccupationDataT UnPack()
		{
			IClosedSegmentOccupationDataT closedSegmentOccupationDataT = new IClosedSegmentOccupationDataT();
			this.UnPackTo(closedSegmentOccupationDataT);
			return closedSegmentOccupationDataT;
		}

		// Token: 0x06019BED RID: 105453 RVA: 0x003AFA8B File Offset: 0x003ADC8B
		public void UnPackTo(IClosedSegmentOccupationDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019BEE RID: 105454 RVA: 0x003AFA9C File Offset: 0x003ADC9C
		public static Offset<IClosedSegmentOccupationData> Pack(FlatBufferBuilder builder, IClosedSegmentOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClosedSegmentOccupationData>);
			}
			return IClosedSegmentOccupationData.CreateIClosedSegmentOccupationData(builder, _o.Type);
		}

		// Token: 0x0400C1C9 RID: 49609
		private Table __p;
	}
}
