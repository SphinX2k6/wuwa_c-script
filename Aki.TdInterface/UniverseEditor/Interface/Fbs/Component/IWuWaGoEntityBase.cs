using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA4 RID: 23460
	public struct IWuWaGoEntityBase : IFlatbufferObject
	{
		// Token: 0x1700B149 RID: 45385
		// (get) Token: 0x060282B9 RID: 164537 RVA: 0x005854FA File Offset: 0x005836FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060282BA RID: 164538 RVA: 0x00585507 File Offset: 0x00583707
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060282BB RID: 164539 RVA: 0x00585510 File Offset: 0x00583710
		public static IWuWaGoEntityBase GetRootAsIWuWaGoEntityBase(ByteBuffer _bb)
		{
			return IWuWaGoEntityBase.GetRootAsIWuWaGoEntityBase(_bb, default(IWuWaGoEntityBase));
		}

		// Token: 0x060282BC RID: 164540 RVA: 0x0058552C File Offset: 0x0058372C
		public static IWuWaGoEntityBase GetRootAsIWuWaGoEntityBase(ByteBuffer _bb, IWuWaGoEntityBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060282BD RID: 164541 RVA: 0x00585549 File Offset: 0x00583749
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060282BE RID: 164542 RVA: 0x00585558 File Offset: 0x00583758
		public IWuWaGoEntityBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B14A RID: 45386
		// (get) Token: 0x060282BF RID: 164543 RVA: 0x00585568 File Offset: 0x00583768
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060282C0 RID: 164544 RVA: 0x005855A4 File Offset: 0x005837A4
		public static Offset<IWuWaGoEntityBase> CreateIWuWaGoEntityBase(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter)
		{
			builder.StartTable(1);
			IWuWaGoEntityBase.AddType(builder, Type);
			return IWuWaGoEntityBase.EndIWuWaGoEntityBase(builder);
		}

		// Token: 0x060282C1 RID: 164545 RVA: 0x005855BA File Offset: 0x005837BA
		public static void StartIWuWaGoEntityBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060282C2 RID: 164546 RVA: 0x005855C3 File Offset: 0x005837C3
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060282C3 RID: 164547 RVA: 0x005855CE File Offset: 0x005837CE
		public static Offset<IWuWaGoEntityBase> EndIWuWaGoEntityBase(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoEntityBase>(builder.EndTable());
		}

		// Token: 0x060282C4 RID: 164548 RVA: 0x005855DC File Offset: 0x005837DC
		public IWuWaGoEntityBaseT UnPack()
		{
			IWuWaGoEntityBaseT wuWaGoEntityBaseT = new IWuWaGoEntityBaseT();
			this.UnPackTo(wuWaGoEntityBaseT);
			return wuWaGoEntityBaseT;
		}

		// Token: 0x060282C5 RID: 164549 RVA: 0x005855F7 File Offset: 0x005837F7
		public void UnPackTo(IWuWaGoEntityBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060282C6 RID: 164550 RVA: 0x00585608 File Offset: 0x00583808
		public static Offset<IWuWaGoEntityBase> Pack(FlatBufferBuilder builder, IWuWaGoEntityBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoEntityBase>);
			}
			return IWuWaGoEntityBase.CreateIWuWaGoEntityBase(builder, _o.Type);
		}

		// Token: 0x0400F30B RID: 62219
		private Table __p;
	}
}
