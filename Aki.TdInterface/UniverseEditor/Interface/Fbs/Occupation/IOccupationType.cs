using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043B6 RID: 17334
	public struct IOccupationType : IFlatbufferObject
	{
		// Token: 0x17007A9A RID: 31386
		// (get) Token: 0x06019D66 RID: 105830 RVA: 0x003B2E73 File Offset: 0x003B1073
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019D67 RID: 105831 RVA: 0x003B2E80 File Offset: 0x003B1080
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019D68 RID: 105832 RVA: 0x003B2E88 File Offset: 0x003B1088
		public static IOccupationType GetRootAsIOccupationType(ByteBuffer _bb)
		{
			return IOccupationType.GetRootAsIOccupationType(_bb, default(IOccupationType));
		}

		// Token: 0x06019D69 RID: 105833 RVA: 0x003B2EA4 File Offset: 0x003B10A4
		public static IOccupationType GetRootAsIOccupationType(ByteBuffer _bb, IOccupationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019D6A RID: 105834 RVA: 0x003B2EC1 File Offset: 0x003B10C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019D6B RID: 105835 RVA: 0x003B2ED0 File Offset: 0x003B10D0
		public IOccupationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A9B RID: 31387
		// (get) Token: 0x06019D6C RID: 105836 RVA: 0x003B2EE0 File Offset: 0x003B10E0
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

		// Token: 0x06019D6D RID: 105837 RVA: 0x003B2F1C File Offset: 0x003B111C
		public static Offset<IOccupationType> CreateIOccupationType(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			IOccupationType.AddType(builder, Type);
			return IOccupationType.EndIOccupationType(builder);
		}

		// Token: 0x06019D6E RID: 105838 RVA: 0x003B2F32 File Offset: 0x003B1132
		public static void StartIOccupationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019D6F RID: 105839 RVA: 0x003B2F3B File Offset: 0x003B113B
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019D70 RID: 105840 RVA: 0x003B2F46 File Offset: 0x003B1146
		public static Offset<IOccupationType> EndIOccupationType(FlatBufferBuilder builder)
		{
			return new Offset<IOccupationType>(builder.EndTable());
		}

		// Token: 0x06019D71 RID: 105841 RVA: 0x003B2F54 File Offset: 0x003B1154
		public IOccupationTypeT UnPack()
		{
			IOccupationTypeT occupationTypeT = new IOccupationTypeT();
			this.UnPackTo(occupationTypeT);
			return occupationTypeT;
		}

		// Token: 0x06019D72 RID: 105842 RVA: 0x003B2F6F File Offset: 0x003B116F
		public void UnPackTo(IOccupationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019D73 RID: 105843 RVA: 0x003B2F80 File Offset: 0x003B1180
		public static Offset<IOccupationType> Pack(FlatBufferBuilder builder, IOccupationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOccupationType>);
			}
			return IOccupationType.CreateIOccupationType(builder, _o.Type);
		}

		// Token: 0x0400C1F6 RID: 49654
		private Table __p;
	}
}
