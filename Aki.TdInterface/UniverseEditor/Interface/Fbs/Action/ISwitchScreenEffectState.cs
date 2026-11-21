using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A3A RID: 31290
	public struct ISwitchScreenEffectState : IFlatbufferObject
	{
		// Token: 0x1700E540 RID: 58688
		// (get) Token: 0x06037236 RID: 225846 RVA: 0x0075DDAA File Offset: 0x0075BFAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037237 RID: 225847 RVA: 0x0075DDB7 File Offset: 0x0075BFB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037238 RID: 225848 RVA: 0x0075DDC0 File Offset: 0x0075BFC0
		public static ISwitchScreenEffectState GetRootAsISwitchScreenEffectState(ByteBuffer _bb)
		{
			return ISwitchScreenEffectState.GetRootAsISwitchScreenEffectState(_bb, default(ISwitchScreenEffectState));
		}

		// Token: 0x06037239 RID: 225849 RVA: 0x0075DDDC File Offset: 0x0075BFDC
		public static ISwitchScreenEffectState GetRootAsISwitchScreenEffectState(ByteBuffer _bb, ISwitchScreenEffectState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603723A RID: 225850 RVA: 0x0075DDF9 File Offset: 0x0075BFF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603723B RID: 225851 RVA: 0x0075DE08 File Offset: 0x0075C008
		public ISwitchScreenEffectState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E541 RID: 58689
		// (get) Token: 0x0603723C RID: 225852 RVA: 0x0075DE18 File Offset: 0x0075C018
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

		// Token: 0x1700E542 RID: 58690
		// (get) Token: 0x0603723D RID: 225853 RVA: 0x0075DE54 File Offset: 0x0075C054
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

		// Token: 0x0603723E RID: 225854 RVA: 0x0075DE8B File Offset: 0x0075C08B
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603723F RID: 225855 RVA: 0x0075DE9A File Offset: 0x0075C09A
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06037240 RID: 225856 RVA: 0x0075DEA8 File Offset: 0x0075C0A8
		public static Offset<ISwitchScreenEffectState> CreateISwitchScreenEffectState(FlatBufferBuilder builder, ESwitchEffectStateEffectType Type = ESwitchEffectStateEffectType.ScreenEffect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISwitchScreenEffectState.AddPath(builder, PathOffset);
			ISwitchScreenEffectState.AddType(builder, Type);
			return ISwitchScreenEffectState.EndISwitchScreenEffectState(builder);
		}

		// Token: 0x06037241 RID: 225857 RVA: 0x0075DEC5 File Offset: 0x0075C0C5
		public static void StartISwitchScreenEffectState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06037242 RID: 225858 RVA: 0x0075DECE File Offset: 0x0075C0CE
		public static void AddType(FlatBufferBuilder builder, ESwitchEffectStateEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037243 RID: 225859 RVA: 0x0075DED9 File Offset: 0x0075C0D9
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06037244 RID: 225860 RVA: 0x0075DEE9 File Offset: 0x0075C0E9
		public static Offset<ISwitchScreenEffectState> EndISwitchScreenEffectState(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchScreenEffectState>(builder.EndTable());
		}

		// Token: 0x06037245 RID: 225861 RVA: 0x0075DEF8 File Offset: 0x0075C0F8
		public ISwitchScreenEffectStateT UnPack()
		{
			ISwitchScreenEffectStateT switchScreenEffectStateT = new ISwitchScreenEffectStateT();
			this.UnPackTo(switchScreenEffectStateT);
			return switchScreenEffectStateT;
		}

		// Token: 0x06037246 RID: 225862 RVA: 0x0075DF13 File Offset: 0x0075C113
		public void UnPackTo(ISwitchScreenEffectStateT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x06037247 RID: 225863 RVA: 0x0075DF30 File Offset: 0x0075C130
		public static Offset<ISwitchScreenEffectState> Pack(FlatBufferBuilder builder, ISwitchScreenEffectStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchScreenEffectState>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return ISwitchScreenEffectState.CreateISwitchScreenEffectState(builder, _o.Type, pathOffset);
		}

		// Token: 0x04012D64 RID: 77156
		private Table __p;
	}
}
