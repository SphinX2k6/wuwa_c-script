using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052FD RID: 21245
	public struct IGramophoneAudioControl : IFlatbufferObject
	{
		// Token: 0x17009C02 RID: 39938
		// (get) Token: 0x06022B34 RID: 142132 RVA: 0x004CF17F File Offset: 0x004CD37F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022B35 RID: 142133 RVA: 0x004CF18C File Offset: 0x004CD38C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022B36 RID: 142134 RVA: 0x004CF194 File Offset: 0x004CD394
		public static IGramophoneAudioControl GetRootAsIGramophoneAudioControl(ByteBuffer _bb)
		{
			return IGramophoneAudioControl.GetRootAsIGramophoneAudioControl(_bb, default(IGramophoneAudioControl));
		}

		// Token: 0x06022B37 RID: 142135 RVA: 0x004CF1B0 File Offset: 0x004CD3B0
		public static IGramophoneAudioControl GetRootAsIGramophoneAudioControl(ByteBuffer _bb, IGramophoneAudioControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022B38 RID: 142136 RVA: 0x004CF1CD File Offset: 0x004CD3CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022B39 RID: 142137 RVA: 0x004CF1DC File Offset: 0x004CD3DC
		public IGramophoneAudioControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C03 RID: 39939
		// (get) Token: 0x06022B3A RID: 142138 RVA: 0x004CF1EC File Offset: 0x004CD3EC
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

		// Token: 0x06022B3B RID: 142139 RVA: 0x004CF228 File Offset: 0x004CD428
		public static Offset<IGramophoneAudioControl> CreateIGramophoneAudioControl(FlatBufferBuilder builder, EAudioControlType Type = EAudioControlType.Gramophone)
		{
			builder.StartTable(1);
			IGramophoneAudioControl.AddType(builder, Type);
			return IGramophoneAudioControl.EndIGramophoneAudioControl(builder);
		}

		// Token: 0x06022B3C RID: 142140 RVA: 0x004CF23E File Offset: 0x004CD43E
		public static void StartIGramophoneAudioControl(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022B3D RID: 142141 RVA: 0x004CF247 File Offset: 0x004CD447
		public static void AddType(FlatBufferBuilder builder, EAudioControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022B3E RID: 142142 RVA: 0x004CF252 File Offset: 0x004CD452
		public static Offset<IGramophoneAudioControl> EndIGramophoneAudioControl(FlatBufferBuilder builder)
		{
			return new Offset<IGramophoneAudioControl>(builder.EndTable());
		}

		// Token: 0x06022B3F RID: 142143 RVA: 0x004CF260 File Offset: 0x004CD460
		public IGramophoneAudioControlT UnPack()
		{
			IGramophoneAudioControlT gramophoneAudioControlT = new IGramophoneAudioControlT();
			this.UnPackTo(gramophoneAudioControlT);
			return gramophoneAudioControlT;
		}

		// Token: 0x06022B40 RID: 142144 RVA: 0x004CF27B File Offset: 0x004CD47B
		public void UnPackTo(IGramophoneAudioControlT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022B41 RID: 142145 RVA: 0x004CF28C File Offset: 0x004CD48C
		public static Offset<IGramophoneAudioControl> Pack(FlatBufferBuilder builder, IGramophoneAudioControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGramophoneAudioControl>);
			}
			return IGramophoneAudioControl.CreateIGramophoneAudioControl(builder, _o.Type);
		}

		// Token: 0x0400E4AC RID: 58540
		private Table __p;
	}
}
