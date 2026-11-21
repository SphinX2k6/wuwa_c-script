using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D22 RID: 32034
	public struct IVehiclePlayPassengerVoice : IFlatbufferObject
	{
		// Token: 0x1700EFCB RID: 61387
		// (get) Token: 0x06039D3B RID: 236859 RVA: 0x007CD49C File Offset: 0x007CB69C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039D3C RID: 236860 RVA: 0x007CD4A9 File Offset: 0x007CB6A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039D3D RID: 236861 RVA: 0x007CD4B0 File Offset: 0x007CB6B0
		public static IVehiclePlayPassengerVoice GetRootAsIVehiclePlayPassengerVoice(ByteBuffer _bb)
		{
			return IVehiclePlayPassengerVoice.GetRootAsIVehiclePlayPassengerVoice(_bb, default(IVehiclePlayPassengerVoice));
		}

		// Token: 0x06039D3E RID: 236862 RVA: 0x007CD4CC File Offset: 0x007CB6CC
		public static IVehiclePlayPassengerVoice GetRootAsIVehiclePlayPassengerVoice(ByteBuffer _bb, IVehiclePlayPassengerVoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039D3F RID: 236863 RVA: 0x007CD4E9 File Offset: 0x007CB6E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039D40 RID: 236864 RVA: 0x007CD4F8 File Offset: 0x007CB6F8
		public IVehiclePlayPassengerVoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFCC RID: 61388
		// (get) Token: 0x06039D41 RID: 236865 RVA: 0x007CD508 File Offset: 0x007CB708
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

		// Token: 0x1700EFCD RID: 61389
		// (get) Token: 0x06039D42 RID: 236866 RVA: 0x007CD544 File Offset: 0x007CB744
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

		// Token: 0x06039D43 RID: 236867 RVA: 0x007CD5A4 File Offset: 0x007CB7A4
		public float TriggerParams(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700EFCE RID: 61390
		// (get) Token: 0x06039D44 RID: 236868 RVA: 0x007CD5E8 File Offset: 0x007CB7E8
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

		// Token: 0x06039D45 RID: 236869 RVA: 0x007CD613 File Offset: 0x007CB813
		public Span<float> GetTriggerParamsBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x06039D46 RID: 236870 RVA: 0x007CD622 File Offset: 0x007CB822
		public float[] GetTriggerParamsArray()
		{
			return this.__p.__vector_as_array<float>(8);
		}

		// Token: 0x1700EFCF RID: 61391
		// (get) Token: 0x06039D47 RID: 236871 RVA: 0x007CD630 File Offset: 0x007CB830
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

		// Token: 0x06039D48 RID: 236872 RVA: 0x007CD66D File Offset: 0x007CB86D
		public static Offset<IVehiclePlayPassengerVoice> CreateIVehiclePlayPassengerVoice(FlatBufferBuilder builder, EGondolaVoiceTriggeredType TriggerType = EGondolaVoiceTriggeredType.FindTreasure, Offset<IPlayVoicePassengersConfig> TriggerPassengersOffset = default(Offset<IPlayVoicePassengersConfig>), VectorOffset TriggerParamsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVehiclePlayPassengerVoice.AddTriggerParams(builder, TriggerParamsOffset);
			IVehiclePlayPassengerVoice.AddTriggerPassengers(builder, TriggerPassengersOffset);
			IVehiclePlayPassengerVoice.AddNullMask(builder, NullMask);
			IVehiclePlayPassengerVoice.AddTriggerType(builder, TriggerType);
			return IVehiclePlayPassengerVoice.EndIVehiclePlayPassengerVoice(builder);
		}

		// Token: 0x06039D49 RID: 236873 RVA: 0x007CD699 File Offset: 0x007CB899
		public static void StartIVehiclePlayPassengerVoice(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06039D4A RID: 236874 RVA: 0x007CD6A2 File Offset: 0x007CB8A2
		public static void AddTriggerType(FlatBufferBuilder builder, EGondolaVoiceTriggeredType triggerType)
		{
			builder.AddByte(0, (byte)triggerType, 0);
		}

		// Token: 0x06039D4B RID: 236875 RVA: 0x007CD6AD File Offset: 0x007CB8AD
		public static void AddTriggerPassengers(FlatBufferBuilder builder, Offset<IPlayVoicePassengersConfig> triggerPassengersOffset)
		{
			builder.AddOffset(1, triggerPassengersOffset.Value, 0);
		}

		// Token: 0x06039D4C RID: 236876 RVA: 0x007CD6BD File Offset: 0x007CB8BD
		public static void AddTriggerParams(FlatBufferBuilder builder, VectorOffset triggerParamsOffset)
		{
			builder.AddOffset(2, triggerParamsOffset.Value, 0);
		}

		// Token: 0x06039D4D RID: 236877 RVA: 0x007CD6D0 File Offset: 0x007CB8D0
		public static VectorOffset CreateTriggerParamsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddFloat(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06039D4E RID: 236878 RVA: 0x007CD707 File Offset: 0x007CB907
		public static VectorOffset CreateTriggerParamsVectorBlock(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x06039D4F RID: 236879 RVA: 0x007CD721 File Offset: 0x007CB921
		public static VectorOffset CreateTriggerParamsVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x06039D50 RID: 236880 RVA: 0x007CD73F File Offset: 0x007CB93F
		public static VectorOffset CreateTriggerParamsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<float>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06039D51 RID: 236881 RVA: 0x007CD758 File Offset: 0x007CB958
		public static void StartTriggerParamsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06039D52 RID: 236882 RVA: 0x007CD763 File Offset: 0x007CB963
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06039D53 RID: 236883 RVA: 0x007CD76E File Offset: 0x007CB96E
		public static Offset<IVehiclePlayPassengerVoice> EndIVehiclePlayPassengerVoice(FlatBufferBuilder builder)
		{
			return new Offset<IVehiclePlayPassengerVoice>(builder.EndTable());
		}

		// Token: 0x06039D54 RID: 236884 RVA: 0x007CD77C File Offset: 0x007CB97C
		public IVehiclePlayPassengerVoiceT UnPack()
		{
			IVehiclePlayPassengerVoiceT vehiclePlayPassengerVoiceT = new IVehiclePlayPassengerVoiceT();
			this.UnPackTo(vehiclePlayPassengerVoiceT);
			return vehiclePlayPassengerVoiceT;
		}

		// Token: 0x06039D55 RID: 236885 RVA: 0x007CD798 File Offset: 0x007CB998
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

		// Token: 0x06039D56 RID: 236886 RVA: 0x007CD81C File Offset: 0x007CBA1C
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

		// Token: 0x04013450 RID: 78928
		private Table __p;
	}
}
