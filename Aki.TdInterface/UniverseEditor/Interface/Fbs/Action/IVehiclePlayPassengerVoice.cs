using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200752C RID: 29996
	public struct IVehiclePlayPassengerVoice : IFlatbufferObject
	{
		// Token: 0x1700E3A1 RID: 58273
		// (get) Token: 0x06036925 RID: 223525 RVA: 0x0076A1F4 File Offset: 0x007683F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036926 RID: 223526 RVA: 0x0076A201 File Offset: 0x00768401
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036927 RID: 223527 RVA: 0x0076A208 File Offset: 0x00768408
		public static IVehiclePlayPassengerVoice GetRootAsIVehiclePlayPassengerVoice(ByteBuffer _bb)
		{
			return IVehiclePlayPassengerVoice.GetRootAsIVehiclePlayPassengerVoice(_bb, default(IVehiclePlayPassengerVoice));
		}

		// Token: 0x06036928 RID: 223528 RVA: 0x0076A224 File Offset: 0x00768424
		public static IVehiclePlayPassengerVoice GetRootAsIVehiclePlayPassengerVoice(ByteBuffer _bb, IVehiclePlayPassengerVoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036929 RID: 223529 RVA: 0x0076A241 File Offset: 0x00768441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603692A RID: 223530 RVA: 0x0076A250 File Offset: 0x00768450
		public IVehiclePlayPassengerVoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3A2 RID: 58274
		// (get) Token: 0x0603692B RID: 223531 RVA: 0x0076A260 File Offset: 0x00768460
		public EGondolaVoiceTriggeredType TriggerType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGondolaVoiceTriggeredType.FindTreasure;
				}
				return (EGondolaVoiceTriggeredType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E3A3 RID: 58275
		// (get) Token: 0x0603692C RID: 223532 RVA: 0x0076A29C File Offset: 0x0076849C
		public IPlayVoicePassengersConfig? TriggerPassengers
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayVoicePassengersConfig?(default(IPlayVoicePassengersConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603692D RID: 223533 RVA: 0x0076A2FC File Offset: 0x007684FC
		public float TriggerParams(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E3A4 RID: 58276
		// (get) Token: 0x0603692E RID: 223534 RVA: 0x0076A340 File Offset: 0x00768540
		public int TriggerParamsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0603692F RID: 223535 RVA: 0x0076A36B File Offset: 0x0076856B
		public Span<float> GetTriggerParamsBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x06036930 RID: 223536 RVA: 0x0076A37A File Offset: 0x0076857A
		public float[] GetTriggerParamsArray()
		{
			return this.__p.__vector_as_array<float>(8);
		}

		// Token: 0x1700E3A5 RID: 58277
		// (get) Token: 0x06036931 RID: 223537 RVA: 0x0076A388 File Offset: 0x00768588
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036932 RID: 223538 RVA: 0x0076A3C5 File Offset: 0x007685C5
		public static Offset<IVehiclePlayPassengerVoice> CreateIVehiclePlayPassengerVoice(FlatBufferBuilder builder, EGondolaVoiceTriggeredType TriggerType = EGondolaVoiceTriggeredType.FindTreasure, Offset<IPlayVoicePassengersConfig> TriggerPassengersOffset = default(Offset<IPlayVoicePassengersConfig>), VectorOffset TriggerParamsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVehiclePlayPassengerVoice.AddTriggerParams(builder, TriggerParamsOffset);
			IVehiclePlayPassengerVoice.AddTriggerPassengers(builder, TriggerPassengersOffset);
			IVehiclePlayPassengerVoice.AddNullMask(builder, NullMask);
			IVehiclePlayPassengerVoice.AddTriggerType(builder, TriggerType);
			return IVehiclePlayPassengerVoice.EndIVehiclePlayPassengerVoice(builder);
		}

		// Token: 0x06036933 RID: 223539 RVA: 0x0076A3F1 File Offset: 0x007685F1
		public static void StartIVehiclePlayPassengerVoice(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036934 RID: 223540 RVA: 0x0076A3FA File Offset: 0x007685FA
		public static void AddTriggerType(FlatBufferBuilder builder, EGondolaVoiceTriggeredType triggerType)
		{
			builder.AddByte(0, (byte)triggerType, 0);
		}

		// Token: 0x06036935 RID: 223541 RVA: 0x0076A405 File Offset: 0x00768605
		public static void AddTriggerPassengers(FlatBufferBuilder builder, Offset<IPlayVoicePassengersConfig> triggerPassengersOffset)
		{
			builder.AddOffset(1, triggerPassengersOffset.Value, 0);
		}

		// Token: 0x06036936 RID: 223542 RVA: 0x0076A415 File Offset: 0x00768615
		public static void AddTriggerParams(FlatBufferBuilder builder, VectorOffset triggerParamsOffset)
		{
			builder.AddOffset(2, triggerParamsOffset.Value, 0);
		}

		// Token: 0x06036937 RID: 223543 RVA: 0x0076A428 File Offset: 0x00768628
		public static VectorOffset CreateTriggerParamsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddFloat(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036938 RID: 223544 RVA: 0x0076A45F File Offset: 0x0076865F
		public static VectorOffset CreateTriggerParamsVectorBlock(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x06036939 RID: 223545 RVA: 0x0076A479 File Offset: 0x00768679
		public static VectorOffset CreateTriggerParamsVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x0603693A RID: 223546 RVA: 0x0076A497 File Offset: 0x00768697
		public static VectorOffset CreateTriggerParamsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<float>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603693B RID: 223547 RVA: 0x0076A4B0 File Offset: 0x007686B0
		public static void StartTriggerParamsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603693C RID: 223548 RVA: 0x0076A4BB File Offset: 0x007686BB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603693D RID: 223549 RVA: 0x0076A4C6 File Offset: 0x007686C6
		public static Offset<IVehiclePlayPassengerVoice> EndIVehiclePlayPassengerVoice(FlatBufferBuilder builder)
		{
			return new Offset<IVehiclePlayPassengerVoice>(builder.EndTable());
		}

		// Token: 0x0603693E RID: 223550 RVA: 0x0076A4D4 File Offset: 0x007686D4
		public IVehiclePlayPassengerVoiceT UnPack()
		{
			IVehiclePlayPassengerVoiceT vehiclePlayPassengerVoiceT = new IVehiclePlayPassengerVoiceT();
			this.UnPackTo(vehiclePlayPassengerVoiceT);
			return vehiclePlayPassengerVoiceT;
		}

		// Token: 0x0603693F RID: 223551 RVA: 0x0076A4F0 File Offset: 0x007686F0
		public void UnPackTo(IVehiclePlayPassengerVoiceT _o)
		{
			_o.TriggerType = this.TriggerType;
			_o.TriggerPassengers = ((this.TriggerPassengers != null) ? this.TriggerPassengers.Value.UnPack() : null);
			_o.TriggerParams = new List<float>();
			for (int i = 0; i < this.TriggerParamsLength; i++)
			{
				_o.TriggerParams.Add(this.TriggerParams(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036940 RID: 223552 RVA: 0x0076A574 File Offset: 0x00768774
		public static Offset<IVehiclePlayPassengerVoice> Pack(FlatBufferBuilder builder, IVehiclePlayPassengerVoiceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehiclePlayPassengerVoice>);
			}
			Offset<IPlayVoicePassengersConfig> triggerPassengersOffset = (_o.TriggerPassengers == null) ? default(Offset<IPlayVoicePassengersConfig>) : IPlayVoicePassengersConfig.Pack(builder, _o.TriggerPassengers);
			VectorOffset triggerParamsOffset = default(VectorOffset);
			if (_o.TriggerParams != null)
			{
				float[] data = _o.TriggerParams.ToArray();
				triggerParamsOffset = IVehiclePlayPassengerVoice.CreateTriggerParamsVector(builder, data);
			}
			return IVehiclePlayPassengerVoice.CreateIVehiclePlayPassengerVoice(builder, _o.TriggerType, triggerPassengersOffset, triggerParamsOffset, _o.NullMask);
		}

		// Token: 0x0401241F RID: 74783
		private Table __p;
	}
}
