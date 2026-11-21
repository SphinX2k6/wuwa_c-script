using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005883 RID: 22659
	public struct IGramophoneAudioControl : IFlatbufferObject
	{
		// Token: 0x1700A43A RID: 42042
		// (get) Token: 0x06024BE8 RID: 150504 RVA: 0x0050C052 File Offset: 0x0050A252
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024BE9 RID: 150505 RVA: 0x0050C05F File Offset: 0x0050A25F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024BEA RID: 150506 RVA: 0x0050C068 File Offset: 0x0050A268
		public static IGramophoneAudioControl GetRootAsIGramophoneAudioControl(ByteBuffer _bb)
		{
			return IGramophoneAudioControl.GetRootAsIGramophoneAudioControl(_bb, default(IGramophoneAudioControl));
		}

		// Token: 0x06024BEB RID: 150507 RVA: 0x0050C084 File Offset: 0x0050A284
		public static IGramophoneAudioControl GetRootAsIGramophoneAudioControl(ByteBuffer _bb, IGramophoneAudioControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024BEC RID: 150508 RVA: 0x0050C0A1 File Offset: 0x0050A2A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024BED RID: 150509 RVA: 0x0050C0B0 File Offset: 0x0050A2B0
		public IGramophoneAudioControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A43B RID: 42043
		// (get) Token: 0x06024BEE RID: 150510 RVA: 0x0050C0C0 File Offset: 0x0050A2C0
		public EAudioControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAudioControlType.Gramophone;
				}
				return (EAudioControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024BEF RID: 150511 RVA: 0x0050C0FC File Offset: 0x0050A2FC
		public static Offset<IGramophoneAudioControl> CreateIGramophoneAudioControl(FlatBufferBuilder builder, EAudioControlType Type = EAudioControlType.Gramophone)
		{
			builder.StartTable(1);
			IGramophoneAudioControl.AddType(builder, Type);
			return IGramophoneAudioControl.EndIGramophoneAudioControl(builder);
		}

		// Token: 0x06024BF0 RID: 150512 RVA: 0x0050C112 File Offset: 0x0050A312
		public static void StartIGramophoneAudioControl(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024BF1 RID: 150513 RVA: 0x0050C11B File Offset: 0x0050A31B
		public static void AddType(FlatBufferBuilder builder, EAudioControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024BF2 RID: 150514 RVA: 0x0050C126 File Offset: 0x0050A326
		public static Offset<IGramophoneAudioControl> EndIGramophoneAudioControl(FlatBufferBuilder builder)
		{
			return new Offset<IGramophoneAudioControl>(builder.EndTable());
		}

		// Token: 0x06024BF3 RID: 150515 RVA: 0x0050C134 File Offset: 0x0050A334
		public IGramophoneAudioControlT UnPack()
		{
			IGramophoneAudioControlT gramophoneAudioControlT = new IGramophoneAudioControlT();
			this.UnPackTo(gramophoneAudioControlT);
			return gramophoneAudioControlT;
		}

		// Token: 0x06024BF4 RID: 150516 RVA: 0x0050C14F File Offset: 0x0050A34F
		public void UnPackTo(IGramophoneAudioControlT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024BF5 RID: 150517 RVA: 0x0050C160 File Offset: 0x0050A360
		public static Offset<IGramophoneAudioControl> Pack(FlatBufferBuilder builder, IGramophoneAudioControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGramophoneAudioControl>);
			}
			return IGramophoneAudioControl.CreateIGramophoneAudioControl(builder, _o.Type);
		}

		// Token: 0x0400F0DC RID: 61660
		private Table __p;
	}
}
