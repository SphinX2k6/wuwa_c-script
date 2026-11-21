using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044DB RID: 17627
	public struct IRecallVehicle : IFlatbufferObject
	{
		// Token: 0x17007AB6 RID: 31414
		// (get) Token: 0x060197CE RID: 104398 RVA: 0x003A2985 File Offset: 0x003A0B85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060197CF RID: 104399 RVA: 0x003A2992 File Offset: 0x003A0B92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060197D0 RID: 104400 RVA: 0x003A299C File Offset: 0x003A0B9C
		public static IRecallVehicle GetRootAsIRecallVehicle(ByteBuffer _bb)
		{
			return IRecallVehicle.GetRootAsIRecallVehicle(_bb, default(IRecallVehicle));
		}

		// Token: 0x060197D1 RID: 104401 RVA: 0x003A29B8 File Offset: 0x003A0BB8
		public static IRecallVehicle GetRootAsIRecallVehicle(ByteBuffer _bb, IRecallVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060197D2 RID: 104402 RVA: 0x003A29D5 File Offset: 0x003A0BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060197D3 RID: 104403 RVA: 0x003A29E4 File Offset: 0x003A0BE4
		public IRecallVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AB7 RID: 31415
		// (get) Token: 0x060197D4 RID: 104404 RVA: 0x003A29F4 File Offset: 0x003A0BF4
		public EVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060197D5 RID: 104405 RVA: 0x003A2A30 File Offset: 0x003A0C30
		public static Offset<IRecallVehicle> CreateIRecallVehicle(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola)
		{
			builder.StartTable(1);
			IRecallVehicle.AddType(builder, Type);
			return IRecallVehicle.EndIRecallVehicle(builder);
		}

		// Token: 0x060197D6 RID: 104406 RVA: 0x003A2A46 File Offset: 0x003A0C46
		public static void StartIRecallVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060197D7 RID: 104407 RVA: 0x003A2A4F File Offset: 0x003A0C4F
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060197D8 RID: 104408 RVA: 0x003A2A5A File Offset: 0x003A0C5A
		public static Offset<IRecallVehicle> EndIRecallVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IRecallVehicle>(builder.EndTable());
		}

		// Token: 0x060197D9 RID: 104409 RVA: 0x003A2A68 File Offset: 0x003A0C68
		public IRecallVehicleT UnPack()
		{
			IRecallVehicleT recallVehicleT = new IRecallVehicleT();
			this.UnPackTo(recallVehicleT);
			return recallVehicleT;
		}

		// Token: 0x060197DA RID: 104410 RVA: 0x003A2A83 File Offset: 0x003A0C83
		public void UnPackTo(IRecallVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060197DB RID: 104411 RVA: 0x003A2A94 File Offset: 0x003A0C94
		public static Offset<IRecallVehicle> Pack(FlatBufferBuilder builder, IRecallVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallVehicle>);
			}
			return IRecallVehicle.CreateIRecallVehicle(builder, _o.Type);
		}

		// Token: 0x0400C60C RID: 50700
		private Table __p;
	}
}
