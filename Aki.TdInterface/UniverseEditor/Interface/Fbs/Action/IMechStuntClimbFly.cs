using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8B RID: 27275
	public struct IMechStuntClimbFly : IFlatbufferObject
	{
		// Token: 0x1700CA81 RID: 51841
		// (get) Token: 0x0602FCCC RID: 195788 RVA: 0x006812F5 File Offset: 0x0067F4F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FCCD RID: 195789 RVA: 0x00681302 File Offset: 0x0067F502
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FCCE RID: 195790 RVA: 0x0068130C File Offset: 0x0067F50C
		public static IMechStuntClimbFly GetRootAsIMechStuntClimbFly(ByteBuffer _bb)
		{
			return IMechStuntClimbFly.GetRootAsIMechStuntClimbFly(_bb, default(IMechStuntClimbFly));
		}

		// Token: 0x0602FCCF RID: 195791 RVA: 0x00681328 File Offset: 0x0067F528
		public static IMechStuntClimbFly GetRootAsIMechStuntClimbFly(ByteBuffer _bb, IMechStuntClimbFly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FCD0 RID: 195792 RVA: 0x00681345 File Offset: 0x0067F545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FCD1 RID: 195793 RVA: 0x00681354 File Offset: 0x0067F554
		public IMechStuntClimbFly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA82 RID: 51842
		// (get) Token: 0x0602FCD2 RID: 195794 RVA: 0x00681364 File Offset: 0x0067F564
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

		// Token: 0x0602FCD3 RID: 195795 RVA: 0x006813A0 File Offset: 0x0067F5A0
		public static Offset<IMechStuntClimbFly> CreateIMechStuntClimbFly(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntClimbFly.AddType(builder, Type);
			return IMechStuntClimbFly.EndIMechStuntClimbFly(builder);
		}

		// Token: 0x0602FCD4 RID: 195796 RVA: 0x006813B6 File Offset: 0x0067F5B6
		public static void StartIMechStuntClimbFly(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FCD5 RID: 195797 RVA: 0x006813BF File Offset: 0x0067F5BF
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FCD6 RID: 195798 RVA: 0x006813CA File Offset: 0x0067F5CA
		public static Offset<IMechStuntClimbFly> EndIMechStuntClimbFly(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntClimbFly>(builder.EndTable());
		}

		// Token: 0x0602FCD7 RID: 195799 RVA: 0x006813D8 File Offset: 0x0067F5D8
		public IMechStuntClimbFlyT UnPack()
		{
			IMechStuntClimbFlyT mechStuntClimbFlyT = new IMechStuntClimbFlyT();
			this.UnPackTo(mechStuntClimbFlyT);
			return mechStuntClimbFlyT;
		}

		// Token: 0x0602FCD8 RID: 195800 RVA: 0x006813F3 File Offset: 0x0067F5F3
		public void UnPackTo(IMechStuntClimbFlyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FCD9 RID: 195801 RVA: 0x00681404 File Offset: 0x0067F604
		public static Offset<IMechStuntClimbFly> Pack(FlatBufferBuilder builder, IMechStuntClimbFlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntClimbFly>);
			}
			return IMechStuntClimbFly.CreateIMechStuntClimbFly(builder, _o.Type);
		}

		// Token: 0x040112C6 RID: 70342
		private Table __p;
	}
}
