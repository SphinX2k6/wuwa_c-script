using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A97 RID: 27287
	public struct IMechStuntHighSpeed : IFlatbufferObject
	{
		// Token: 0x1700CA8C RID: 51852
		// (get) Token: 0x0602FD18 RID: 195864 RVA: 0x006819A9 File Offset: 0x0067FBA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD19 RID: 195865 RVA: 0x006819B6 File Offset: 0x0067FBB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD1A RID: 195866 RVA: 0x006819C0 File Offset: 0x0067FBC0
		public static IMechStuntHighSpeed GetRootAsIMechStuntHighSpeed(ByteBuffer _bb)
		{
			return IMechStuntHighSpeed.GetRootAsIMechStuntHighSpeed(_bb, default(IMechStuntHighSpeed));
		}

		// Token: 0x0602FD1B RID: 195867 RVA: 0x006819DC File Offset: 0x0067FBDC
		public static IMechStuntHighSpeed GetRootAsIMechStuntHighSpeed(ByteBuffer _bb, IMechStuntHighSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD1C RID: 195868 RVA: 0x006819F9 File Offset: 0x0067FBF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD1D RID: 195869 RVA: 0x00681A08 File Offset: 0x0067FC08
		public IMechStuntHighSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA8D RID: 51853
		// (get) Token: 0x0602FD1E RID: 195870 RVA: 0x00681A18 File Offset: 0x0067FC18
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

		// Token: 0x0602FD1F RID: 195871 RVA: 0x00681A54 File Offset: 0x0067FC54
		public static Offset<IMechStuntHighSpeed> CreateIMechStuntHighSpeed(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntHighSpeed.AddType(builder, Type);
			return IMechStuntHighSpeed.EndIMechStuntHighSpeed(builder);
		}

		// Token: 0x0602FD20 RID: 195872 RVA: 0x00681A6A File Offset: 0x0067FC6A
		public static void StartIMechStuntHighSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FD21 RID: 195873 RVA: 0x00681A73 File Offset: 0x0067FC73
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD22 RID: 195874 RVA: 0x00681A7E File Offset: 0x0067FC7E
		public static Offset<IMechStuntHighSpeed> EndIMechStuntHighSpeed(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntHighSpeed>(builder.EndTable());
		}

		// Token: 0x0602FD23 RID: 195875 RVA: 0x00681A8C File Offset: 0x0067FC8C
		public IMechStuntHighSpeedT UnPack()
		{
			IMechStuntHighSpeedT mechStuntHighSpeedT = new IMechStuntHighSpeedT();
			this.UnPackTo(mechStuntHighSpeedT);
			return mechStuntHighSpeedT;
		}

		// Token: 0x0602FD24 RID: 195876 RVA: 0x00681AA7 File Offset: 0x0067FCA7
		public void UnPackTo(IMechStuntHighSpeedT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FD25 RID: 195877 RVA: 0x00681AB8 File Offset: 0x0067FCB8
		public static Offset<IMechStuntHighSpeed> Pack(FlatBufferBuilder builder, IMechStuntHighSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntHighSpeed>);
			}
			return IMechStuntHighSpeed.CreateIMechStuntHighSpeed(builder, _o.Type);
		}

		// Token: 0x040112D7 RID: 70359
		private Table __p;
	}
}
