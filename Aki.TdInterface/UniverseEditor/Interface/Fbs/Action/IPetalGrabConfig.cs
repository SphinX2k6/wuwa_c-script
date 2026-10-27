using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C99 RID: 27801
	public struct IPetalGrabConfig : IFlatbufferObject
	{
		// Token: 0x1700CF09 RID: 53001
		// (get) Token: 0x06030FE9 RID: 200681 RVA: 0x006A6BFF File Offset: 0x006A4DFF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030FEA RID: 200682 RVA: 0x006A6C0C File Offset: 0x006A4E0C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030FEB RID: 200683 RVA: 0x006A6C14 File Offset: 0x006A4E14
		public static IPetalGrabConfig GetRootAsIPetalGrabConfig(ByteBuffer _bb)
		{
			return IPetalGrabConfig.GetRootAsIPetalGrabConfig(_bb, default(IPetalGrabConfig));
		}

		// Token: 0x06030FEC RID: 200684 RVA: 0x006A6C30 File Offset: 0x006A4E30
		public static IPetalGrabConfig GetRootAsIPetalGrabConfig(ByteBuffer _bb, IPetalGrabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030FED RID: 200685 RVA: 0x006A6C4D File Offset: 0x006A4E4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030FEE RID: 200686 RVA: 0x006A6C5C File Offset: 0x006A4E5C
		public IPetalGrabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF0A RID: 53002
		// (get) Token: 0x06030FEF RID: 200687 RVA: 0x006A6C6C File Offset: 0x006A4E6C
		public ESportStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESportStateType.Slide;
				}
				return (ESportStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF0B RID: 53003
		// (get) Token: 0x06030FF0 RID: 200688 RVA: 0x006A6CA8 File Offset: 0x006A4EA8
		public int FirstGrabEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030FF1 RID: 200689 RVA: 0x006A6CE4 File Offset: 0x006A4EE4
		public static Offset<IPetalGrabConfig> CreateIPetalGrabConfig(FlatBufferBuilder builder, ESportStateType Type = ESportStateType.Slide, int FirstGrabEntityId = 0)
		{
			builder.StartTable(2);
			IPetalGrabConfig.AddFirstGrabEntityId(builder, FirstGrabEntityId);
			IPetalGrabConfig.AddType(builder, Type);
			return IPetalGrabConfig.EndIPetalGrabConfig(builder);
		}

		// Token: 0x06030FF2 RID: 200690 RVA: 0x006A6D01 File Offset: 0x006A4F01
		public static void StartIPetalGrabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030FF3 RID: 200691 RVA: 0x006A6D0A File Offset: 0x006A4F0A
		public static void AddType(FlatBufferBuilder builder, ESportStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030FF4 RID: 200692 RVA: 0x006A6D15 File Offset: 0x006A4F15
		public static void AddFirstGrabEntityId(FlatBufferBuilder builder, int firstGrabEntityId)
		{
			builder.AddInt(1, firstGrabEntityId, 0);
		}

		// Token: 0x06030FF5 RID: 200693 RVA: 0x006A6D20 File Offset: 0x006A4F20
		public static Offset<IPetalGrabConfig> EndIPetalGrabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPetalGrabConfig>(builder.EndTable());
		}

		// Token: 0x06030FF6 RID: 200694 RVA: 0x006A6D30 File Offset: 0x006A4F30
		public IPetalGrabConfigT UnPack()
		{
			IPetalGrabConfigT petalGrabConfigT = new IPetalGrabConfigT();
			this.UnPackTo(petalGrabConfigT);
			return petalGrabConfigT;
		}

		// Token: 0x06030FF7 RID: 200695 RVA: 0x006A6D4B File Offset: 0x006A4F4B
		public void UnPackTo(IPetalGrabConfigT _o)
		{
			_o.Type = this.Type;
			_o.FirstGrabEntityId = this.FirstGrabEntityId;
		}

		// Token: 0x06030FF8 RID: 200696 RVA: 0x006A6D68 File Offset: 0x006A4F68
		public static Offset<IPetalGrabConfig> Pack(FlatBufferBuilder builder, IPetalGrabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPetalGrabConfig>);
			}
			return IPetalGrabConfig.CreateIPetalGrabConfig(builder, _o.Type, _o.FirstGrabEntityId);
		}

		// Token: 0x040115F0 RID: 71152
		private Table __p;
	}
}
