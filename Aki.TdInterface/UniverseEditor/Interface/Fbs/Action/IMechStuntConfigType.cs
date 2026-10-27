using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8E RID: 27278
	public struct IMechStuntConfigType : IFlatbufferObject
	{
		// Token: 0x1700CA84 RID: 51844
		// (get) Token: 0x0602FCDE RID: 195806 RVA: 0x0068146D File Offset: 0x0067F66D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FCDF RID: 195807 RVA: 0x0068147A File Offset: 0x0067F67A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FCE0 RID: 195808 RVA: 0x00681484 File Offset: 0x0067F684
		public static IMechStuntConfigType GetRootAsIMechStuntConfigType(ByteBuffer _bb)
		{
			return IMechStuntConfigType.GetRootAsIMechStuntConfigType(_bb, default(IMechStuntConfigType));
		}

		// Token: 0x0602FCE1 RID: 195809 RVA: 0x006814A0 File Offset: 0x0067F6A0
		public static IMechStuntConfigType GetRootAsIMechStuntConfigType(ByteBuffer _bb, IMechStuntConfigType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FCE2 RID: 195810 RVA: 0x006814BD File Offset: 0x0067F6BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FCE3 RID: 195811 RVA: 0x006814CC File Offset: 0x0067F6CC
		public IMechStuntConfigType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA85 RID: 51845
		// (get) Token: 0x0602FCE4 RID: 195812 RVA: 0x006814DC File Offset: 0x0067F6DC
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

		// Token: 0x0602FCE5 RID: 195813 RVA: 0x00681518 File Offset: 0x0067F718
		public static Offset<IMechStuntConfigType> CreateIMechStuntConfigType(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntConfigType.AddType(builder, Type);
			return IMechStuntConfigType.EndIMechStuntConfigType(builder);
		}

		// Token: 0x0602FCE6 RID: 195814 RVA: 0x0068152E File Offset: 0x0067F72E
		public static void StartIMechStuntConfigType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FCE7 RID: 195815 RVA: 0x00681537 File Offset: 0x0067F737
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FCE8 RID: 195816 RVA: 0x00681542 File Offset: 0x0067F742
		public static Offset<IMechStuntConfigType> EndIMechStuntConfigType(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntConfigType>(builder.EndTable());
		}

		// Token: 0x0602FCE9 RID: 195817 RVA: 0x00681550 File Offset: 0x0067F750
		public IMechStuntConfigTypeT UnPack()
		{
			IMechStuntConfigTypeT mechStuntConfigTypeT = new IMechStuntConfigTypeT();
			this.UnPackTo(mechStuntConfigTypeT);
			return mechStuntConfigTypeT;
		}

		// Token: 0x0602FCEA RID: 195818 RVA: 0x0068156B File Offset: 0x0067F76B
		public void UnPackTo(IMechStuntConfigTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FCEB RID: 195819 RVA: 0x0068157C File Offset: 0x0067F77C
		public static Offset<IMechStuntConfigType> Pack(FlatBufferBuilder builder, IMechStuntConfigTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntConfigType>);
			}
			return IMechStuntConfigType.CreateIMechStuntConfigType(builder, _o.Type);
		}

		// Token: 0x040112C8 RID: 70344
		private Table __p;
	}
}
