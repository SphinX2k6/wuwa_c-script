using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE3 RID: 23267
	public struct IMidViewDistance : IFlatbufferObject
	{
		// Token: 0x1700A9C2 RID: 43458
		// (get) Token: 0x0602635A RID: 156506 RVA: 0x0053C791 File Offset: 0x0053A991
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602635B RID: 156507 RVA: 0x0053C79E File Offset: 0x0053A99E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602635C RID: 156508 RVA: 0x0053C7A8 File Offset: 0x0053A9A8
		public static IMidViewDistance GetRootAsIMidViewDistance(ByteBuffer _bb)
		{
			return IMidViewDistance.GetRootAsIMidViewDistance(_bb, default(IMidViewDistance));
		}

		// Token: 0x0602635D RID: 156509 RVA: 0x0053C7C4 File Offset: 0x0053A9C4
		public static IMidViewDistance GetRootAsIMidViewDistance(ByteBuffer _bb, IMidViewDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602635E RID: 156510 RVA: 0x0053C7E1 File Offset: 0x0053A9E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602635F RID: 156511 RVA: 0x0053C7F0 File Offset: 0x0053A9F0
		public IMidViewDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9C3 RID: 43459
		// (get) Token: 0x06026360 RID: 156512 RVA: 0x0053C800 File Offset: 0x0053AA00
		public EViewDistanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EViewDistanceType.Low;
				}
				return (EViewDistanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026361 RID: 156513 RVA: 0x0053C83C File Offset: 0x0053AA3C
		public static Offset<IMidViewDistance> CreateIMidViewDistance(FlatBufferBuilder builder, EViewDistanceType Type = EViewDistanceType.Low)
		{
			builder.StartTable(1);
			IMidViewDistance.AddType(builder, Type);
			return IMidViewDistance.EndIMidViewDistance(builder);
		}

		// Token: 0x06026362 RID: 156514 RVA: 0x0053C852 File Offset: 0x0053AA52
		public static void StartIMidViewDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026363 RID: 156515 RVA: 0x0053C85B File Offset: 0x0053AA5B
		public static void AddType(FlatBufferBuilder builder, EViewDistanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026364 RID: 156516 RVA: 0x0053C866 File Offset: 0x0053AA66
		public static Offset<IMidViewDistance> EndIMidViewDistance(FlatBufferBuilder builder)
		{
			return new Offset<IMidViewDistance>(builder.EndTable());
		}

		// Token: 0x06026365 RID: 156517 RVA: 0x0053C874 File Offset: 0x0053AA74
		public IMidViewDistanceT UnPack()
		{
			IMidViewDistanceT midViewDistanceT = new IMidViewDistanceT();
			this.UnPackTo(midViewDistanceT);
			return midViewDistanceT;
		}

		// Token: 0x06026366 RID: 156518 RVA: 0x0053C88F File Offset: 0x0053AA8F
		public void UnPackTo(IMidViewDistanceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026367 RID: 156519 RVA: 0x0053C8A0 File Offset: 0x0053AAA0
		public static Offset<IMidViewDistance> Pack(FlatBufferBuilder builder, IMidViewDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMidViewDistance>);
			}
			return IMidViewDistance.CreateIMidViewDistance(builder, _o.Type);
		}

		// Token: 0x0400F4B1 RID: 62641
		private Table __p;
	}
}
