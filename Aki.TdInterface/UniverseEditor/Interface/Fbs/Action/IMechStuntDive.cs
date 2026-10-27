using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A94 RID: 27284
	public struct IMechStuntDive : IFlatbufferObject
	{
		// Token: 0x1700CA89 RID: 51849
		// (get) Token: 0x0602FD06 RID: 195846 RVA: 0x00681834 File Offset: 0x0067FA34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD07 RID: 195847 RVA: 0x00681841 File Offset: 0x0067FA41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD08 RID: 195848 RVA: 0x00681848 File Offset: 0x0067FA48
		public static IMechStuntDive GetRootAsIMechStuntDive(ByteBuffer _bb)
		{
			return IMechStuntDive.GetRootAsIMechStuntDive(_bb, default(IMechStuntDive));
		}

		// Token: 0x0602FD09 RID: 195849 RVA: 0x00681864 File Offset: 0x0067FA64
		public static IMechStuntDive GetRootAsIMechStuntDive(ByteBuffer _bb, IMechStuntDive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD0A RID: 195850 RVA: 0x00681881 File Offset: 0x0067FA81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD0B RID: 195851 RVA: 0x00681890 File Offset: 0x0067FA90
		public IMechStuntDive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA8A RID: 51850
		// (get) Token: 0x0602FD0C RID: 195852 RVA: 0x006818A0 File Offset: 0x0067FAA0
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

		// Token: 0x0602FD0D RID: 195853 RVA: 0x006818DC File Offset: 0x0067FADC
		public static Offset<IMechStuntDive> CreateIMechStuntDive(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntDive.AddType(builder, Type);
			return IMechStuntDive.EndIMechStuntDive(builder);
		}

		// Token: 0x0602FD0E RID: 195854 RVA: 0x006818F2 File Offset: 0x0067FAF2
		public static void StartIMechStuntDive(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FD0F RID: 195855 RVA: 0x006818FB File Offset: 0x0067FAFB
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD10 RID: 195856 RVA: 0x00681906 File Offset: 0x0067FB06
		public static Offset<IMechStuntDive> EndIMechStuntDive(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntDive>(builder.EndTable());
		}

		// Token: 0x0602FD11 RID: 195857 RVA: 0x00681914 File Offset: 0x0067FB14
		public IMechStuntDiveT UnPack()
		{
			IMechStuntDiveT mechStuntDiveT = new IMechStuntDiveT();
			this.UnPackTo(mechStuntDiveT);
			return mechStuntDiveT;
		}

		// Token: 0x0602FD12 RID: 195858 RVA: 0x0068192F File Offset: 0x0067FB2F
		public void UnPackTo(IMechStuntDiveT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FD13 RID: 195859 RVA: 0x00681940 File Offset: 0x0067FB40
		public static Offset<IMechStuntDive> Pack(FlatBufferBuilder builder, IMechStuntDiveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntDive>);
			}
			return IMechStuntDive.CreateIMechStuntDive(builder, _o.Type);
		}

		// Token: 0x040112D5 RID: 70357
		private Table __p;
	}
}
