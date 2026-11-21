using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C39 RID: 23609
	public struct IOnDollGrabDeliveryPerform : IFlatbufferObject
	{
		// Token: 0x1700AD66 RID: 44390
		// (get) Token: 0x06027217 RID: 160279 RVA: 0x0055CAC7 File Offset: 0x0055ACC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027218 RID: 160280 RVA: 0x0055CAD4 File Offset: 0x0055ACD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027219 RID: 160281 RVA: 0x0055CADC File Offset: 0x0055ACDC
		public static IOnDollGrabDeliveryPerform GetRootAsIOnDollGrabDeliveryPerform(ByteBuffer _bb)
		{
			return IOnDollGrabDeliveryPerform.GetRootAsIOnDollGrabDeliveryPerform(_bb, default(IOnDollGrabDeliveryPerform));
		}

		// Token: 0x0602721A RID: 160282 RVA: 0x0055CAF8 File Offset: 0x0055ACF8
		public static IOnDollGrabDeliveryPerform GetRootAsIOnDollGrabDeliveryPerform(ByteBuffer _bb, IOnDollGrabDeliveryPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602721B RID: 160283 RVA: 0x0055CB15 File Offset: 0x0055AD15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602721C RID: 160284 RVA: 0x0055CB24 File Offset: 0x0055AD24
		public IOnDollGrabDeliveryPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD67 RID: 44391
		// (get) Token: 0x0602721D RID: 160285 RVA: 0x0055CB34 File Offset: 0x0055AD34
		public string EventMontage
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602721E RID: 160286 RVA: 0x0055CB6B File Offset: 0x0055AD6B
		public Span<byte> GetEventMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602721F RID: 160287 RVA: 0x0055CB7A File Offset: 0x0055AD7A
		public byte[] GetEventMontageArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AD68 RID: 44392
		// (get) Token: 0x06027220 RID: 160288 RVA: 0x0055CB88 File Offset: 0x0055AD88
		public string StandByMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027221 RID: 160289 RVA: 0x0055CBBF File Offset: 0x0055ADBF
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027222 RID: 160290 RVA: 0x0055CBCE File Offset: 0x0055ADCE
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AD69 RID: 44393
		// (get) Token: 0x06027223 RID: 160291 RVA: 0x0055CBDC File Offset: 0x0055ADDC
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AD6A RID: 44394
		// (get) Token: 0x06027224 RID: 160292 RVA: 0x0055CC3C File Offset: 0x0055AE3C
		public float PerformDuration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD6B RID: 44395
		// (get) Token: 0x06027225 RID: 160293 RVA: 0x0055CC80 File Offset: 0x0055AE80
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027226 RID: 160294 RVA: 0x0055CCBD File Offset: 0x0055AEBD
		public static Offset<IOnDollGrabDeliveryPerform> CreateIOnDollGrabDeliveryPerform(FlatBufferBuilder builder, StringOffset EventMontageOffset = default(StringOffset), StringOffset StandByMontageOffset = default(StringOffset), Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>), float PerformDuration = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IOnDollGrabDeliveryPerform.AddPerformDuration(builder, PerformDuration);
			IOnDollGrabDeliveryPerform.AddFlow(builder, FlowOffset);
			IOnDollGrabDeliveryPerform.AddStandByMontage(builder, StandByMontageOffset);
			IOnDollGrabDeliveryPerform.AddEventMontage(builder, EventMontageOffset);
			IOnDollGrabDeliveryPerform.AddNullMask(builder, NullMask);
			return IOnDollGrabDeliveryPerform.EndIOnDollGrabDeliveryPerform(builder);
		}

		// Token: 0x06027227 RID: 160295 RVA: 0x0055CCF1 File Offset: 0x0055AEF1
		public static void StartIOnDollGrabDeliveryPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027228 RID: 160296 RVA: 0x0055CCFA File Offset: 0x0055AEFA
		public static void AddEventMontage(FlatBufferBuilder builder, StringOffset eventMontageOffset)
		{
			builder.AddOffset(0, eventMontageOffset.Value, 0);
		}

		// Token: 0x06027229 RID: 160297 RVA: 0x0055CD0A File Offset: 0x0055AF0A
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(1, standByMontageOffset.Value, 0);
		}

		// Token: 0x0602722A RID: 160298 RVA: 0x0055CD1A File Offset: 0x0055AF1A
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(2, flowOffset.Value, 0);
		}

		// Token: 0x0602722B RID: 160299 RVA: 0x0055CD2A File Offset: 0x0055AF2A
		public static void AddPerformDuration(FlatBufferBuilder builder, float performDuration)
		{
			builder.AddFloat(3, performDuration, 0.0);
		}

		// Token: 0x0602722C RID: 160300 RVA: 0x0055CD3D File Offset: 0x0055AF3D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602722D RID: 160301 RVA: 0x0055CD48 File Offset: 0x0055AF48
		public static Offset<IOnDollGrabDeliveryPerform> EndIOnDollGrabDeliveryPerform(FlatBufferBuilder builder)
		{
			return new Offset<IOnDollGrabDeliveryPerform>(builder.EndTable());
		}

		// Token: 0x0602722E RID: 160302 RVA: 0x0055CD58 File Offset: 0x0055AF58
		public IOnDollGrabDeliveryPerformT UnPack()
		{
			IOnDollGrabDeliveryPerformT onDollGrabDeliveryPerformT = new IOnDollGrabDeliveryPerformT();
			this.UnPackTo(onDollGrabDeliveryPerformT);
			return onDollGrabDeliveryPerformT;
		}

		// Token: 0x0602722F RID: 160303 RVA: 0x0055CD74 File Offset: 0x0055AF74
		public void UnPackTo(IOnDollGrabDeliveryPerformT _o)
		{
			_o.EventMontage = this.EventMontage;
			_o.StandByMontage = this.StandByMontage;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.PerformDuration = this.PerformDuration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027230 RID: 160304 RVA: 0x0055CDE0 File Offset: 0x0055AFE0
		public static Offset<IOnDollGrabDeliveryPerform> Pack(FlatBufferBuilder builder, IOnDollGrabDeliveryPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnDollGrabDeliveryPerform>);
			}
			StringOffset eventMontageOffset = (_o.EventMontage == null) ? default(StringOffset) : builder.CreateString(_o.EventMontage);
			StringOffset standByMontageOffset = (_o.StandByMontage == null) ? default(StringOffset) : builder.CreateString(_o.StandByMontage);
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IOnDollGrabDeliveryPerform.CreateIOnDollGrabDeliveryPerform(builder, eventMontageOffset, standByMontageOffset, flowOffset, _o.PerformDuration, _o.NullMask);
		}

		// Token: 0x0400F722 RID: 63266
		private Table __p;
	}
}
