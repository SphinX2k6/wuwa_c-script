using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006922 RID: 26914
	public struct ICarPaintChangeBpActorFunc : IFlatbufferObject
	{
		// Token: 0x1700C622 RID: 50722
		// (get) Token: 0x0602E1EA RID: 188906 RVA: 0x0064D4E7 File Offset: 0x0064B6E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E1EB RID: 188907 RVA: 0x0064D4F4 File Offset: 0x0064B6F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E1EC RID: 188908 RVA: 0x0064D4FC File Offset: 0x0064B6FC
		public static ICarPaintChangeBpActorFunc GetRootAsICarPaintChangeBpActorFunc(ByteBuffer _bb)
		{
			return ICarPaintChangeBpActorFunc.GetRootAsICarPaintChangeBpActorFunc(_bb, default(ICarPaintChangeBpActorFunc));
		}

		// Token: 0x0602E1ED RID: 188909 RVA: 0x0064D518 File Offset: 0x0064B718
		public static ICarPaintChangeBpActorFunc GetRootAsICarPaintChangeBpActorFunc(ByteBuffer _bb, ICarPaintChangeBpActorFunc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E1EE RID: 188910 RVA: 0x0064D535 File Offset: 0x0064B735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E1EF RID: 188911 RVA: 0x0064D544 File Offset: 0x0064B744
		public ICarPaintChangeBpActorFunc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C623 RID: 50723
		// (get) Token: 0x0602E1F0 RID: 188912 RVA: 0x0064D554 File Offset: 0x0064B754
		public EBpActorFuncType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBpActorFuncType.CarPaintChange;
				}
				return (EBpActorFuncType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C624 RID: 50724
		// (get) Token: 0x0602E1F1 RID: 188913 RVA: 0x0064D590 File Offset: 0x0064B790
		public IActorRef? BpActor
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E1F2 RID: 188914 RVA: 0x0064D5ED File Offset: 0x0064B7ED
		public static Offset<ICarPaintChangeBpActorFunc> CreateICarPaintChangeBpActorFunc(FlatBufferBuilder builder, EBpActorFuncType Type = EBpActorFuncType.CarPaintChange, Offset<IActorRef> BpActorOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(2);
			ICarPaintChangeBpActorFunc.AddBpActor(builder, BpActorOffset);
			ICarPaintChangeBpActorFunc.AddType(builder, Type);
			return ICarPaintChangeBpActorFunc.EndICarPaintChangeBpActorFunc(builder);
		}

		// Token: 0x0602E1F3 RID: 188915 RVA: 0x0064D60A File Offset: 0x0064B80A
		public static void StartICarPaintChangeBpActorFunc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E1F4 RID: 188916 RVA: 0x0064D613 File Offset: 0x0064B813
		public static void AddType(FlatBufferBuilder builder, EBpActorFuncType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E1F5 RID: 188917 RVA: 0x0064D61E File Offset: 0x0064B81E
		public static void AddBpActor(FlatBufferBuilder builder, Offset<IActorRef> bpActorOffset)
		{
			builder.AddOffset(1, bpActorOffset.Value, 0);
		}

		// Token: 0x0602E1F6 RID: 188918 RVA: 0x0064D62E File Offset: 0x0064B82E
		public static Offset<ICarPaintChangeBpActorFunc> EndICarPaintChangeBpActorFunc(FlatBufferBuilder builder)
		{
			return new Offset<ICarPaintChangeBpActorFunc>(builder.EndTable());
		}

		// Token: 0x0602E1F7 RID: 188919 RVA: 0x0064D63C File Offset: 0x0064B83C
		public ICarPaintChangeBpActorFuncT UnPack()
		{
			ICarPaintChangeBpActorFuncT carPaintChangeBpActorFuncT = new ICarPaintChangeBpActorFuncT();
			this.UnPackTo(carPaintChangeBpActorFuncT);
			return carPaintChangeBpActorFuncT;
		}

		// Token: 0x0602E1F8 RID: 188920 RVA: 0x0064D658 File Offset: 0x0064B858
		public void UnPackTo(ICarPaintChangeBpActorFuncT _o)
		{
			_o.Type = this.Type;
			_o.BpActor = ((this.BpActor != null) ? this.BpActor.Value.UnPack() : null);
		}

		// Token: 0x0602E1F9 RID: 188921 RVA: 0x0064D6A0 File Offset: 0x0064B8A0
		public static Offset<ICarPaintChangeBpActorFunc> Pack(FlatBufferBuilder builder, ICarPaintChangeBpActorFuncT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICarPaintChangeBpActorFunc>);
			}
			Offset<IActorRef> bpActorOffset = (_o.BpActor == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.BpActor);
			return ICarPaintChangeBpActorFunc.CreateICarPaintChangeBpActorFunc(builder, _o.Type, bpActorOffset);
		}

		// Token: 0x04011664 RID: 71268
		private Table __p;
	}
}
