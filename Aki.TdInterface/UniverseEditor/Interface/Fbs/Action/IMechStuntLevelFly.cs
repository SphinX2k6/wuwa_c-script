using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A9A RID: 27290
	public struct IMechStuntLevelFly : IFlatbufferObject
	{
		// Token: 0x1700CA8F RID: 51855
		// (get) Token: 0x0602FD2A RID: 195882 RVA: 0x00681B21 File Offset: 0x0067FD21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD2B RID: 195883 RVA: 0x00681B2E File Offset: 0x0067FD2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD2C RID: 195884 RVA: 0x00681B38 File Offset: 0x0067FD38
		public static IMechStuntLevelFly GetRootAsIMechStuntLevelFly(ByteBuffer _bb)
		{
			return IMechStuntLevelFly.GetRootAsIMechStuntLevelFly(_bb, default(IMechStuntLevelFly));
		}

		// Token: 0x0602FD2D RID: 195885 RVA: 0x00681B54 File Offset: 0x0067FD54
		public static IMechStuntLevelFly GetRootAsIMechStuntLevelFly(ByteBuffer _bb, IMechStuntLevelFly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD2E RID: 195886 RVA: 0x00681B71 File Offset: 0x0067FD71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD2F RID: 195887 RVA: 0x00681B80 File Offset: 0x0067FD80
		public IMechStuntLevelFly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA90 RID: 51856
		// (get) Token: 0x0602FD30 RID: 195888 RVA: 0x00681B90 File Offset: 0x0067FD90
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

		// Token: 0x0602FD31 RID: 195889 RVA: 0x00681BCC File Offset: 0x0067FDCC
		public static Offset<IMechStuntLevelFly> CreateIMechStuntLevelFly(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntLevelFly.AddType(builder, Type);
			return IMechStuntLevelFly.EndIMechStuntLevelFly(builder);
		}

		// Token: 0x0602FD32 RID: 195890 RVA: 0x00681BE2 File Offset: 0x0067FDE2
		public static void StartIMechStuntLevelFly(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FD33 RID: 195891 RVA: 0x00681BEB File Offset: 0x0067FDEB
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD34 RID: 195892 RVA: 0x00681BF6 File Offset: 0x0067FDF6
		public static Offset<IMechStuntLevelFly> EndIMechStuntLevelFly(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntLevelFly>(builder.EndTable());
		}

		// Token: 0x0602FD35 RID: 195893 RVA: 0x00681C04 File Offset: 0x0067FE04
		public IMechStuntLevelFlyT UnPack()
		{
			IMechStuntLevelFlyT mechStuntLevelFlyT = new IMechStuntLevelFlyT();
			this.UnPackTo(mechStuntLevelFlyT);
			return mechStuntLevelFlyT;
		}

		// Token: 0x0602FD36 RID: 195894 RVA: 0x00681C1F File Offset: 0x0067FE1F
		public void UnPackTo(IMechStuntLevelFlyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FD37 RID: 195895 RVA: 0x00681C30 File Offset: 0x0067FE30
		public static Offset<IMechStuntLevelFly> Pack(FlatBufferBuilder builder, IMechStuntLevelFlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntLevelFly>);
			}
			return IMechStuntLevelFly.CreateIMechStuntLevelFly(builder, _o.Type);
		}

		// Token: 0x040112D9 RID: 70361
		private Table __p;
	}
}
