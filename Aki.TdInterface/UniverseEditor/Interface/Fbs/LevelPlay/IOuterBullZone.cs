using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004536 RID: 17718
	public struct IOuterBullZone : IFlatbufferObject
	{
		// Token: 0x17007DA9 RID: 32169
		// (get) Token: 0x0601AA4F RID: 109135 RVA: 0x003CD59D File Offset: 0x003CB79D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA50 RID: 109136 RVA: 0x003CD5AA File Offset: 0x003CB7AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA51 RID: 109137 RVA: 0x003CD5B4 File Offset: 0x003CB7B4
		public static IOuterBullZone GetRootAsIOuterBullZone(ByteBuffer _bb)
		{
			return IOuterBullZone.GetRootAsIOuterBullZone(_bb, default(IOuterBullZone));
		}

		// Token: 0x0601AA52 RID: 109138 RVA: 0x003CD5D0 File Offset: 0x003CB7D0
		public static IOuterBullZone GetRootAsIOuterBullZone(ByteBuffer _bb, IOuterBullZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA53 RID: 109139 RVA: 0x003CD5ED File Offset: 0x003CB7ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA54 RID: 109140 RVA: 0x003CD5FC File Offset: 0x003CB7FC
		public IOuterBullZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DAA RID: 32170
		// (get) Token: 0x0601AA55 RID: 109141 RVA: 0x003CD60C File Offset: 0x003CB80C
		public EDartboardZoneType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartboardZoneType.CenterBull;
				}
				return (EDartboardZoneType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AA56 RID: 109142 RVA: 0x003CD648 File Offset: 0x003CB848
		public static Offset<IOuterBullZone> CreateIOuterBullZone(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull)
		{
			builder.StartTable(1);
			IOuterBullZone.AddType(builder, Type);
			return IOuterBullZone.EndIOuterBullZone(builder);
		}

		// Token: 0x0601AA57 RID: 109143 RVA: 0x003CD65E File Offset: 0x003CB85E
		public static void StartIOuterBullZone(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AA58 RID: 109144 RVA: 0x003CD667 File Offset: 0x003CB867
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA59 RID: 109145 RVA: 0x003CD672 File Offset: 0x003CB872
		public static Offset<IOuterBullZone> EndIOuterBullZone(FlatBufferBuilder builder)
		{
			return new Offset<IOuterBullZone>(builder.EndTable());
		}

		// Token: 0x0601AA5A RID: 109146 RVA: 0x003CD680 File Offset: 0x003CB880
		public IOuterBullZoneT UnPack()
		{
			IOuterBullZoneT outerBullZoneT = new IOuterBullZoneT();
			this.UnPackTo(outerBullZoneT);
			return outerBullZoneT;
		}

		// Token: 0x0601AA5B RID: 109147 RVA: 0x003CD69B File Offset: 0x003CB89B
		public void UnPackTo(IOuterBullZoneT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AA5C RID: 109148 RVA: 0x003CD6AC File Offset: 0x003CB8AC
		public static Offset<IOuterBullZone> Pack(FlatBufferBuilder builder, IOuterBullZoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOuterBullZone>);
			}
			return IOuterBullZone.CreateIOuterBullZone(builder, _o.Type);
		}

		// Token: 0x0400C5BA RID: 50618
		private Table __p;
	}
}
