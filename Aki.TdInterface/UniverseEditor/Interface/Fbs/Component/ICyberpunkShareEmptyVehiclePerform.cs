using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005063 RID: 20579
	public struct ICyberpunkShareEmptyVehiclePerform : IFlatbufferObject
	{
		// Token: 0x1700954D RID: 38221
		// (get) Token: 0x06020FB1 RID: 135089 RVA: 0x004954F2 File Offset: 0x004936F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020FB2 RID: 135090 RVA: 0x004954FF File Offset: 0x004936FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020FB3 RID: 135091 RVA: 0x00495508 File Offset: 0x00493708
		public static ICyberpunkShareEmptyVehiclePerform GetRootAsICyberpunkShareEmptyVehiclePerform(ByteBuffer _bb)
		{
			return ICyberpunkShareEmptyVehiclePerform.GetRootAsICyberpunkShareEmptyVehiclePerform(_bb, default(ICyberpunkShareEmptyVehiclePerform));
		}

		// Token: 0x06020FB4 RID: 135092 RVA: 0x00495524 File Offset: 0x00493724
		public static ICyberpunkShareEmptyVehiclePerform GetRootAsICyberpunkShareEmptyVehiclePerform(ByteBuffer _bb, ICyberpunkShareEmptyVehiclePerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020FB5 RID: 135093 RVA: 0x00495541 File Offset: 0x00493741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020FB6 RID: 135094 RVA: 0x00495550 File Offset: 0x00493750
		public ICyberpunkShareEmptyVehiclePerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700954E RID: 38222
		// (get) Token: 0x06020FB7 RID: 135095 RVA: 0x00495560 File Offset: 0x00493760
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

		// Token: 0x1700954F RID: 38223
		// (get) Token: 0x06020FB8 RID: 135096 RVA: 0x0049559C File Offset: 0x0049379C
		public string Montage
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

		// Token: 0x06020FB9 RID: 135097 RVA: 0x004955D3 File Offset: 0x004937D3
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020FBA RID: 135098 RVA: 0x004955E2 File Offset: 0x004937E2
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06020FBB RID: 135099 RVA: 0x004955F0 File Offset: 0x004937F0
		public static Offset<ICyberpunkShareEmptyVehiclePerform> CreateICyberpunkShareEmptyVehiclePerform(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, StringOffset MontageOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICyberpunkShareEmptyVehiclePerform.AddMontage(builder, MontageOffset);
			ICyberpunkShareEmptyVehiclePerform.AddType(builder, Type);
			return ICyberpunkShareEmptyVehiclePerform.EndICyberpunkShareEmptyVehiclePerform(builder);
		}

		// Token: 0x06020FBC RID: 135100 RVA: 0x0049560D File Offset: 0x0049380D
		public static void StartICyberpunkShareEmptyVehiclePerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020FBD RID: 135101 RVA: 0x00495616 File Offset: 0x00493816
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020FBE RID: 135102 RVA: 0x00495621 File Offset: 0x00493821
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06020FBF RID: 135103 RVA: 0x00495631 File Offset: 0x00493831
		public static Offset<ICyberpunkShareEmptyVehiclePerform> EndICyberpunkShareEmptyVehiclePerform(FlatBufferBuilder builder)
		{
			return new Offset<ICyberpunkShareEmptyVehiclePerform>(builder.EndTable());
		}

		// Token: 0x06020FC0 RID: 135104 RVA: 0x00495640 File Offset: 0x00493840
		public ICyberpunkShareEmptyVehiclePerformT UnPack()
		{
			ICyberpunkShareEmptyVehiclePerformT cyberpunkShareEmptyVehiclePerformT = new ICyberpunkShareEmptyVehiclePerformT();
			this.UnPackTo(cyberpunkShareEmptyVehiclePerformT);
			return cyberpunkShareEmptyVehiclePerformT;
		}

		// Token: 0x06020FC1 RID: 135105 RVA: 0x0049565B File Offset: 0x0049385B
		public void UnPackTo(ICyberpunkShareEmptyVehiclePerformT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
		}

		// Token: 0x06020FC2 RID: 135106 RVA: 0x00495678 File Offset: 0x00493878
		public static Offset<ICyberpunkShareEmptyVehiclePerform> Pack(FlatBufferBuilder builder, ICyberpunkShareEmptyVehiclePerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICyberpunkShareEmptyVehiclePerform>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return ICyberpunkShareEmptyVehiclePerform.CreateICyberpunkShareEmptyVehiclePerform(builder, _o.Type, montageOffset);
		}

		// Token: 0x0400E05F RID: 57439
		private Table __p;
	}
}
