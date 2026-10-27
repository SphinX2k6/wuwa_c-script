using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007265 RID: 29285
	public struct ISwitchScreenEffectState : IFlatbufferObject
	{
		// Token: 0x1700D947 RID: 55623
		// (get) Token: 0x06033F34 RID: 212788 RVA: 0x006FCA4A File Offset: 0x006FAC4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F35 RID: 212789 RVA: 0x006FCA57 File Offset: 0x006FAC57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033F36 RID: 212790 RVA: 0x006FCA60 File Offset: 0x006FAC60
		public static ISwitchScreenEffectState GetRootAsISwitchScreenEffectState(ByteBuffer _bb)
		{
			return ISwitchScreenEffectState.GetRootAsISwitchScreenEffectState(_bb, default(ISwitchScreenEffectState));
		}

		// Token: 0x06033F37 RID: 212791 RVA: 0x006FCA7C File Offset: 0x006FAC7C
		public static ISwitchScreenEffectState GetRootAsISwitchScreenEffectState(ByteBuffer _bb, ISwitchScreenEffectState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033F38 RID: 212792 RVA: 0x006FCA99 File Offset: 0x006FAC99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033F39 RID: 212793 RVA: 0x006FCAA8 File Offset: 0x006FACA8
		public ISwitchScreenEffectState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D948 RID: 55624
		// (get) Token: 0x06033F3A RID: 212794 RVA: 0x006FCAB8 File Offset: 0x006FACB8
		public ESwitchEffectStateEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchEffectStateEffectType.ScreenEffect;
				}
				return (ESwitchEffectStateEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D949 RID: 55625
		// (get) Token: 0x06033F3B RID: 212795 RVA: 0x006FCAF4 File Offset: 0x006FACF4
		public string Path
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

		// Token: 0x06033F3C RID: 212796 RVA: 0x006FCB2B File Offset: 0x006FAD2B
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033F3D RID: 212797 RVA: 0x006FCB3A File Offset: 0x006FAD3A
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06033F3E RID: 212798 RVA: 0x006FCB48 File Offset: 0x006FAD48
		public static Offset<ISwitchScreenEffectState> CreateISwitchScreenEffectState(FlatBufferBuilder builder, ESwitchEffectStateEffectType Type = ESwitchEffectStateEffectType.ScreenEffect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISwitchScreenEffectState.AddPath(builder, PathOffset);
			ISwitchScreenEffectState.AddType(builder, Type);
			return ISwitchScreenEffectState.EndISwitchScreenEffectState(builder);
		}

		// Token: 0x06033F3F RID: 212799 RVA: 0x006FCB65 File Offset: 0x006FAD65
		public static void StartISwitchScreenEffectState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033F40 RID: 212800 RVA: 0x006FCB6E File Offset: 0x006FAD6E
		public static void AddType(FlatBufferBuilder builder, ESwitchEffectStateEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033F41 RID: 212801 RVA: 0x006FCB79 File Offset: 0x006FAD79
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06033F42 RID: 212802 RVA: 0x006FCB89 File Offset: 0x006FAD89
		public static Offset<ISwitchScreenEffectState> EndISwitchScreenEffectState(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchScreenEffectState>(builder.EndTable());
		}

		// Token: 0x06033F43 RID: 212803 RVA: 0x006FCB98 File Offset: 0x006FAD98
		public ISwitchScreenEffectStateT UnPack()
		{
			ISwitchScreenEffectStateT switchScreenEffectStateT = new ISwitchScreenEffectStateT();
			this.UnPackTo(switchScreenEffectStateT);
			return switchScreenEffectStateT;
		}

		// Token: 0x06033F44 RID: 212804 RVA: 0x006FCBB3 File Offset: 0x006FADB3
		public void UnPackTo(ISwitchScreenEffectStateT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x06033F45 RID: 212805 RVA: 0x006FCBD0 File Offset: 0x006FADD0
		public static Offset<ISwitchScreenEffectState> Pack(FlatBufferBuilder builder, ISwitchScreenEffectStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchScreenEffectState>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return ISwitchScreenEffectState.CreateISwitchScreenEffectState(builder, _o.Type, pathOffset);
		}

		// Token: 0x04011D62 RID: 73058
		private Table __p;
	}
}
