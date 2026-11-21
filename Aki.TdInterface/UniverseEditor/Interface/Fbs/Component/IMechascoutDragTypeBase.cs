using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB6 RID: 23222
	public struct IMechascoutDragTypeBase : IFlatbufferObject
	{
		// Token: 0x1700A943 RID: 43331
		// (get) Token: 0x06026143 RID: 155971 RVA: 0x005379E2 File Offset: 0x00535BE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026144 RID: 155972 RVA: 0x005379EF File Offset: 0x00535BEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026145 RID: 155973 RVA: 0x005379F8 File Offset: 0x00535BF8
		public static IMechascoutDragTypeBase GetRootAsIMechascoutDragTypeBase(ByteBuffer _bb)
		{
			return IMechascoutDragTypeBase.GetRootAsIMechascoutDragTypeBase(_bb, default(IMechascoutDragTypeBase));
		}

		// Token: 0x06026146 RID: 155974 RVA: 0x00537A14 File Offset: 0x00535C14
		public static IMechascoutDragTypeBase GetRootAsIMechascoutDragTypeBase(ByteBuffer _bb, IMechascoutDragTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026147 RID: 155975 RVA: 0x00537A31 File Offset: 0x00535C31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026148 RID: 155976 RVA: 0x00537A40 File Offset: 0x00535C40
		public IMechascoutDragTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A944 RID: 43332
		// (get) Token: 0x06026149 RID: 155977 RVA: 0x00537A50 File Offset: 0x00535C50
		public EMechascoutDragType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechascoutDragType.Instant;
				}
				return (EMechascoutDragType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602614A RID: 155978 RVA: 0x00537A8C File Offset: 0x00535C8C
		public static Offset<IMechascoutDragTypeBase> CreateIMechascoutDragTypeBase(FlatBufferBuilder builder, EMechascoutDragType Type = EMechascoutDragType.Instant)
		{
			builder.StartTable(1);
			IMechascoutDragTypeBase.AddType(builder, Type);
			return IMechascoutDragTypeBase.EndIMechascoutDragTypeBase(builder);
		}

		// Token: 0x0602614B RID: 155979 RVA: 0x00537AA2 File Offset: 0x00535CA2
		public static void StartIMechascoutDragTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602614C RID: 155980 RVA: 0x00537AAB File Offset: 0x00535CAB
		public static void AddType(FlatBufferBuilder builder, EMechascoutDragType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602614D RID: 155981 RVA: 0x00537AB6 File Offset: 0x00535CB6
		public static Offset<IMechascoutDragTypeBase> EndIMechascoutDragTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IMechascoutDragTypeBase>(builder.EndTable());
		}

		// Token: 0x0602614E RID: 155982 RVA: 0x00537AC4 File Offset: 0x00535CC4
		public IMechascoutDragTypeBaseT UnPack()
		{
			IMechascoutDragTypeBaseT mechascoutDragTypeBaseT = new IMechascoutDragTypeBaseT();
			this.UnPackTo(mechascoutDragTypeBaseT);
			return mechascoutDragTypeBaseT;
		}

		// Token: 0x0602614F RID: 155983 RVA: 0x00537ADF File Offset: 0x00535CDF
		public void UnPackTo(IMechascoutDragTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026150 RID: 155984 RVA: 0x00537AF0 File Offset: 0x00535CF0
		public static Offset<IMechascoutDragTypeBase> Pack(FlatBufferBuilder builder, IMechascoutDragTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechascoutDragTypeBase>);
			}
			return IMechascoutDragTypeBase.CreateIMechascoutDragTypeBase(builder, _o.Type);
		}

		// Token: 0x0400F45E RID: 62558
		private Table __p;
	}
}
