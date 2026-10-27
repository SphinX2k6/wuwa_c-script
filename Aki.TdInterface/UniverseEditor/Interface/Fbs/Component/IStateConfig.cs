using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A4 RID: 22948
	public struct IStateConfig : IFlatbufferObject
	{
		// Token: 0x1700AC3A RID: 44090
		// (get) Token: 0x06026DFA RID: 159226 RVA: 0x00559854 File Offset: 0x00557A54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026DFB RID: 159227 RVA: 0x00559861 File Offset: 0x00557A61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026DFC RID: 159228 RVA: 0x00559868 File Offset: 0x00557A68
		public static IStateConfig GetRootAsIStateConfig(ByteBuffer _bb)
		{
			return IStateConfig.GetRootAsIStateConfig(_bb, default(IStateConfig));
		}

		// Token: 0x06026DFD RID: 159229 RVA: 0x00559884 File Offset: 0x00557A84
		public static IStateConfig GetRootAsIStateConfig(ByteBuffer _bb, IStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026DFE RID: 159230 RVA: 0x005598A1 File Offset: 0x00557AA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026DFF RID: 159231 RVA: 0x005598B0 File Offset: 0x00557AB0
		public IStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC3B RID: 44091
		// (get) Token: 0x06026E00 RID: 159232 RVA: 0x005598C0 File Offset: 0x00557AC0
		public string State
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

		// Token: 0x06026E01 RID: 159233 RVA: 0x005598F7 File Offset: 0x00557AF7
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026E02 RID: 159234 RVA: 0x00559906 File Offset: 0x00557B06
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AC3C RID: 44092
		// (get) Token: 0x06026E03 RID: 159235 RVA: 0x00559914 File Offset: 0x00557B14
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026E04 RID: 159236 RVA: 0x00559954 File Offset: 0x00557B54
		public static Offset<IStateConfig> CreateIStateConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), float Duration = 0f)
		{
			builder.StartTable(2);
			IStateConfig.AddDuration(builder, Duration);
			IStateConfig.AddState(builder, StateOffset);
			return IStateConfig.EndIStateConfig(builder);
		}

		// Token: 0x06026E05 RID: 159237 RVA: 0x00559971 File Offset: 0x00557B71
		public static void StartIStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026E06 RID: 159238 RVA: 0x0055997A File Offset: 0x00557B7A
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06026E07 RID: 159239 RVA: 0x0055998A File Offset: 0x00557B8A
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x06026E08 RID: 159240 RVA: 0x0055999D File Offset: 0x00557B9D
		public static Offset<IStateConfig> EndIStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStateConfig>(builder.EndTable());
		}

		// Token: 0x06026E09 RID: 159241 RVA: 0x005599AC File Offset: 0x00557BAC
		public IStateConfigT UnPack()
		{
			IStateConfigT stateConfigT = new IStateConfigT();
			this.UnPackTo(stateConfigT);
			return stateConfigT;
		}

		// Token: 0x06026E0A RID: 159242 RVA: 0x005599C7 File Offset: 0x00557BC7
		public void UnPackTo(IStateConfigT _o)
		{
			_o.State = this.State;
			_o.Duration = this.Duration;
		}

		// Token: 0x06026E0B RID: 159243 RVA: 0x005599E4 File Offset: 0x00557BE4
		public static Offset<IStateConfig> Pack(FlatBufferBuilder builder, IStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IStateConfig.CreateIStateConfig(builder, stateOffset, _o.Duration);
		}

		// Token: 0x0400EFB2 RID: 61362
		private Table __p;
	}
}
