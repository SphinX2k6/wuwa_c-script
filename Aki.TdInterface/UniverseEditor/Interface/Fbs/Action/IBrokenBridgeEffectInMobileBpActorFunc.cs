using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006224 RID: 25124
	public struct IBrokenBridgeEffectInMobileBpActorFunc : IFlatbufferObject
	{
		// Token: 0x1700BB35 RID: 47925
		// (get) Token: 0x0602B4E2 RID: 177378 RVA: 0x005F6B3C File Offset: 0x005F4D3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B4E3 RID: 177379 RVA: 0x005F6B49 File Offset: 0x005F4D49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B4E4 RID: 177380 RVA: 0x005F6B50 File Offset: 0x005F4D50
		public static IBrokenBridgeEffectInMobileBpActorFunc GetRootAsIBrokenBridgeEffectInMobileBpActorFunc(ByteBuffer _bb)
		{
			return IBrokenBridgeEffectInMobileBpActorFunc.GetRootAsIBrokenBridgeEffectInMobileBpActorFunc(_bb, default(IBrokenBridgeEffectInMobileBpActorFunc));
		}

		// Token: 0x0602B4E5 RID: 177381 RVA: 0x005F6B6C File Offset: 0x005F4D6C
		public static IBrokenBridgeEffectInMobileBpActorFunc GetRootAsIBrokenBridgeEffectInMobileBpActorFunc(ByteBuffer _bb, IBrokenBridgeEffectInMobileBpActorFunc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B4E6 RID: 177382 RVA: 0x005F6B89 File Offset: 0x005F4D89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B4E7 RID: 177383 RVA: 0x005F6B98 File Offset: 0x005F4D98
		public IBrokenBridgeEffectInMobileBpActorFunc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB36 RID: 47926
		// (get) Token: 0x0602B4E8 RID: 177384 RVA: 0x005F6BA8 File Offset: 0x005F4DA8
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

		// Token: 0x1700BB37 RID: 47927
		// (get) Token: 0x0602B4E9 RID: 177385 RVA: 0x005F6BE4 File Offset: 0x005F4DE4
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

		// Token: 0x0602B4EA RID: 177386 RVA: 0x005F6C41 File Offset: 0x005F4E41
		public static Offset<IBrokenBridgeEffectInMobileBpActorFunc> CreateIBrokenBridgeEffectInMobileBpActorFunc(FlatBufferBuilder builder, EBpActorFuncType Type = EBpActorFuncType.CarPaintChange, Offset<IActorRef> BpActorOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(2);
			IBrokenBridgeEffectInMobileBpActorFunc.AddBpActor(builder, BpActorOffset);
			IBrokenBridgeEffectInMobileBpActorFunc.AddType(builder, Type);
			return IBrokenBridgeEffectInMobileBpActorFunc.EndIBrokenBridgeEffectInMobileBpActorFunc(builder);
		}

		// Token: 0x0602B4EB RID: 177387 RVA: 0x005F6C5E File Offset: 0x005F4E5E
		public static void StartIBrokenBridgeEffectInMobileBpActorFunc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B4EC RID: 177388 RVA: 0x005F6C67 File Offset: 0x005F4E67
		public static void AddType(FlatBufferBuilder builder, EBpActorFuncType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B4ED RID: 177389 RVA: 0x005F6C72 File Offset: 0x005F4E72
		public static void AddBpActor(FlatBufferBuilder builder, Offset<IActorRef> bpActorOffset)
		{
			builder.AddOffset(1, bpActorOffset.Value, 0);
		}

		// Token: 0x0602B4EE RID: 177390 RVA: 0x005F6C82 File Offset: 0x005F4E82
		public static Offset<IBrokenBridgeEffectInMobileBpActorFunc> EndIBrokenBridgeEffectInMobileBpActorFunc(FlatBufferBuilder builder)
		{
			return new Offset<IBrokenBridgeEffectInMobileBpActorFunc>(builder.EndTable());
		}

		// Token: 0x0602B4EF RID: 177391 RVA: 0x005F6C90 File Offset: 0x005F4E90
		public IBrokenBridgeEffectInMobileBpActorFuncT UnPack()
		{
			IBrokenBridgeEffectInMobileBpActorFuncT brokenBridgeEffectInMobileBpActorFuncT = new IBrokenBridgeEffectInMobileBpActorFuncT();
			this.UnPackTo(brokenBridgeEffectInMobileBpActorFuncT);
			return brokenBridgeEffectInMobileBpActorFuncT;
		}

		// Token: 0x0602B4F0 RID: 177392 RVA: 0x005F6CAC File Offset: 0x005F4EAC
		public void UnPackTo(IBrokenBridgeEffectInMobileBpActorFuncT _o)
		{
			_o.Type = this.Type;
			_o.BpActor = ((this.BpActor != null) ? this.BpActor.Value.UnPack() : null);
		}

		// Token: 0x0602B4F1 RID: 177393 RVA: 0x005F6CF4 File Offset: 0x005F4EF4
		public static Offset<IBrokenBridgeEffectInMobileBpActorFunc> Pack(FlatBufferBuilder builder, IBrokenBridgeEffectInMobileBpActorFuncT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBrokenBridgeEffectInMobileBpActorFunc>);
			}
			Offset<IActorRef> bpActorOffset = (_o.BpActor == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.BpActor);
			return IBrokenBridgeEffectInMobileBpActorFunc.CreateIBrokenBridgeEffectInMobileBpActorFunc(builder, _o.Type, bpActorOffset);
		}

		// Token: 0x04010767 RID: 67431
		private Table __p;
	}
}
