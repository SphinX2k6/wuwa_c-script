using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006895 RID: 26773
	public struct IBrokenBridgeEffectInMobileBpActorFunc : IFlatbufferObject
	{
		// Token: 0x1700C4BD RID: 50365
		// (get) Token: 0x0602DC43 RID: 187459 RVA: 0x00641944 File Offset: 0x0063FB44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC44 RID: 187460 RVA: 0x00641951 File Offset: 0x0063FB51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC45 RID: 187461 RVA: 0x00641958 File Offset: 0x0063FB58
		public static IBrokenBridgeEffectInMobileBpActorFunc GetRootAsIBrokenBridgeEffectInMobileBpActorFunc(ByteBuffer _bb)
		{
			return IBrokenBridgeEffectInMobileBpActorFunc.GetRootAsIBrokenBridgeEffectInMobileBpActorFunc(_bb, default(IBrokenBridgeEffectInMobileBpActorFunc));
		}

		// Token: 0x0602DC46 RID: 187462 RVA: 0x00641974 File Offset: 0x0063FB74
		public static IBrokenBridgeEffectInMobileBpActorFunc GetRootAsIBrokenBridgeEffectInMobileBpActorFunc(ByteBuffer _bb, IBrokenBridgeEffectInMobileBpActorFunc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC47 RID: 187463 RVA: 0x00641991 File Offset: 0x0063FB91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC48 RID: 187464 RVA: 0x006419A0 File Offset: 0x0063FBA0
		public IBrokenBridgeEffectInMobileBpActorFunc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4BE RID: 50366
		// (get) Token: 0x0602DC49 RID: 187465 RVA: 0x006419B0 File Offset: 0x0063FBB0
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

		// Token: 0x1700C4BF RID: 50367
		// (get) Token: 0x0602DC4A RID: 187466 RVA: 0x006419EC File Offset: 0x0063FBEC
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

		// Token: 0x0602DC4B RID: 187467 RVA: 0x00641A49 File Offset: 0x0063FC49
		public static Offset<IBrokenBridgeEffectInMobileBpActorFunc> CreateIBrokenBridgeEffectInMobileBpActorFunc(FlatBufferBuilder builder, EBpActorFuncType Type = EBpActorFuncType.CarPaintChange, Offset<IActorRef> BpActorOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(2);
			IBrokenBridgeEffectInMobileBpActorFunc.AddBpActor(builder, BpActorOffset);
			IBrokenBridgeEffectInMobileBpActorFunc.AddType(builder, Type);
			return IBrokenBridgeEffectInMobileBpActorFunc.EndIBrokenBridgeEffectInMobileBpActorFunc(builder);
		}

		// Token: 0x0602DC4C RID: 187468 RVA: 0x00641A66 File Offset: 0x0063FC66
		public static void StartIBrokenBridgeEffectInMobileBpActorFunc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DC4D RID: 187469 RVA: 0x00641A6F File Offset: 0x0063FC6F
		public static void AddType(FlatBufferBuilder builder, EBpActorFuncType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DC4E RID: 187470 RVA: 0x00641A7A File Offset: 0x0063FC7A
		public static void AddBpActor(FlatBufferBuilder builder, Offset<IActorRef> bpActorOffset)
		{
			builder.AddOffset(1, bpActorOffset.Value, 0);
		}

		// Token: 0x0602DC4F RID: 187471 RVA: 0x00641A8A File Offset: 0x0063FC8A
		public static Offset<IBrokenBridgeEffectInMobileBpActorFunc> EndIBrokenBridgeEffectInMobileBpActorFunc(FlatBufferBuilder builder)
		{
			return new Offset<IBrokenBridgeEffectInMobileBpActorFunc>(builder.EndTable());
		}

		// Token: 0x0602DC50 RID: 187472 RVA: 0x00641A98 File Offset: 0x0063FC98
		public IBrokenBridgeEffectInMobileBpActorFuncT UnPack()
		{
			IBrokenBridgeEffectInMobileBpActorFuncT brokenBridgeEffectInMobileBpActorFuncT = new IBrokenBridgeEffectInMobileBpActorFuncT();
			this.UnPackTo(brokenBridgeEffectInMobileBpActorFuncT);
			return brokenBridgeEffectInMobileBpActorFuncT;
		}

		// Token: 0x0602DC51 RID: 187473 RVA: 0x00641AB4 File Offset: 0x0063FCB4
		public void UnPackTo(IBrokenBridgeEffectInMobileBpActorFuncT _o)
		{
			_o.Type = this.Type;
			_o.BpActor = ((this.BpActor != null) ? this.BpActor.Value.UnPack() : null);
		}

		// Token: 0x0602DC52 RID: 187474 RVA: 0x00641AFC File Offset: 0x0063FCFC
		public static Offset<IBrokenBridgeEffectInMobileBpActorFunc> Pack(FlatBufferBuilder builder, IBrokenBridgeEffectInMobileBpActorFuncT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBrokenBridgeEffectInMobileBpActorFunc>);
			}
			Offset<IActorRef> bpActorOffset = (_o.BpActor == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.BpActor);
			return IBrokenBridgeEffectInMobileBpActorFunc.CreateIBrokenBridgeEffectInMobileBpActorFunc(builder, _o.Type, bpActorOffset);
		}

		// Token: 0x0401157C RID: 71036
		private Table __p;
	}
}
