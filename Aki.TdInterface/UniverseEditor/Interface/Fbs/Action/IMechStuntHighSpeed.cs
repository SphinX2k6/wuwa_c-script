using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071BC RID: 29116
	public struct IMechStuntHighSpeed : IFlatbufferObject
	{
		// Token: 0x1700D53C RID: 54588
		// (get) Token: 0x06032A54 RID: 207444 RVA: 0x006D7C69 File Offset: 0x006D5E69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A55 RID: 207445 RVA: 0x006D7C76 File Offset: 0x006D5E76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A56 RID: 207446 RVA: 0x006D7C80 File Offset: 0x006D5E80
		public static IMechStuntHighSpeed GetRootAsIMechStuntHighSpeed(ByteBuffer _bb)
		{
			return IMechStuntHighSpeed.GetRootAsIMechStuntHighSpeed(_bb, default(IMechStuntHighSpeed));
		}

		// Token: 0x06032A57 RID: 207447 RVA: 0x006D7C9C File Offset: 0x006D5E9C
		public static IMechStuntHighSpeed GetRootAsIMechStuntHighSpeed(ByteBuffer _bb, IMechStuntHighSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A58 RID: 207448 RVA: 0x006D7CB9 File Offset: 0x006D5EB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A59 RID: 207449 RVA: 0x006D7CC8 File Offset: 0x006D5EC8
		public IMechStuntHighSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D53D RID: 54589
		// (get) Token: 0x06032A5A RID: 207450 RVA: 0x006D7CD8 File Offset: 0x006D5ED8
		public EMechStuntType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechStuntType.Dive;
				}
				return (EMechStuntType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032A5B RID: 207451 RVA: 0x006D7D14 File Offset: 0x006D5F14
		public static Offset<IMechStuntHighSpeed> CreateIMechStuntHighSpeed(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntHighSpeed.AddType(builder, Type);
			return IMechStuntHighSpeed.EndIMechStuntHighSpeed(builder);
		}

		// Token: 0x06032A5C RID: 207452 RVA: 0x006D7D2A File Offset: 0x006D5F2A
		public static void StartIMechStuntHighSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032A5D RID: 207453 RVA: 0x006D7D33 File Offset: 0x006D5F33
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032A5E RID: 207454 RVA: 0x006D7D3E File Offset: 0x006D5F3E
		public static Offset<IMechStuntHighSpeed> EndIMechStuntHighSpeed(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntHighSpeed>(builder.EndTable());
		}

		// Token: 0x06032A5F RID: 207455 RVA: 0x006D7D4C File Offset: 0x006D5F4C
		public IMechStuntHighSpeedT UnPack()
		{
			IMechStuntHighSpeedT mechStuntHighSpeedT = new IMechStuntHighSpeedT();
			this.UnPackTo(mechStuntHighSpeedT);
			return mechStuntHighSpeedT;
		}

		// Token: 0x06032A60 RID: 207456 RVA: 0x006D7D67 File Offset: 0x006D5F67
		public void UnPackTo(IMechStuntHighSpeedT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032A61 RID: 207457 RVA: 0x006D7D78 File Offset: 0x006D5F78
		public static Offset<IMechStuntHighSpeed> Pack(FlatBufferBuilder builder, IMechStuntHighSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntHighSpeed>);
			}
			return IMechStuntHighSpeed.CreateIMechStuntHighSpeed(builder, _o.Type);
		}

		// Token: 0x040121D2 RID: 74194
		private Table __p;
	}
}
