using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004905 RID: 18693
	public struct ILoopTeleportClientMpcEffect : IFlatbufferObject
	{
		// Token: 0x1700878A RID: 34698
		// (get) Token: 0x0601D384 RID: 119684 RVA: 0x0041F5DA File Offset: 0x0041D7DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D385 RID: 119685 RVA: 0x0041F5E7 File Offset: 0x0041D7E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D386 RID: 119686 RVA: 0x0041F5F0 File Offset: 0x0041D7F0
		public static ILoopTeleportClientMpcEffect GetRootAsILoopTeleportClientMpcEffect(ByteBuffer _bb)
		{
			return ILoopTeleportClientMpcEffect.GetRootAsILoopTeleportClientMpcEffect(_bb, default(ILoopTeleportClientMpcEffect));
		}

		// Token: 0x0601D387 RID: 119687 RVA: 0x0041F60C File Offset: 0x0041D80C
		public static ILoopTeleportClientMpcEffect GetRootAsILoopTeleportClientMpcEffect(ByteBuffer _bb, ILoopTeleportClientMpcEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D388 RID: 119688 RVA: 0x0041F629 File Offset: 0x0041D829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D389 RID: 119689 RVA: 0x0041F638 File Offset: 0x0041D838
		public ILoopTeleportClientMpcEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700878B RID: 34699
		// (get) Token: 0x0601D38A RID: 119690 RVA: 0x0041F648 File Offset: 0x0041D848
		public ELoopTeleportClientEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELoopTeleportClientEffectType.ScreenEffect;
				}
				return (ELoopTeleportClientEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700878C RID: 34700
		// (get) Token: 0x0601D38B RID: 119691 RVA: 0x0041F684 File Offset: 0x0041D884
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

		// Token: 0x0601D38C RID: 119692 RVA: 0x0041F6BB File Offset: 0x0041D8BB
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D38D RID: 119693 RVA: 0x0041F6CA File Offset: 0x0041D8CA
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601D38E RID: 119694 RVA: 0x0041F6D8 File Offset: 0x0041D8D8
		public static Offset<ILoopTeleportClientMpcEffect> CreateILoopTeleportClientMpcEffect(FlatBufferBuilder builder, ELoopTeleportClientEffectType Type = ELoopTeleportClientEffectType.ScreenEffect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILoopTeleportClientMpcEffect.AddPath(builder, PathOffset);
			ILoopTeleportClientMpcEffect.AddType(builder, Type);
			return ILoopTeleportClientMpcEffect.EndILoopTeleportClientMpcEffect(builder);
		}

		// Token: 0x0601D38F RID: 119695 RVA: 0x0041F6F5 File Offset: 0x0041D8F5
		public static void StartILoopTeleportClientMpcEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D390 RID: 119696 RVA: 0x0041F6FE File Offset: 0x0041D8FE
		public static void AddType(FlatBufferBuilder builder, ELoopTeleportClientEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D391 RID: 119697 RVA: 0x0041F709 File Offset: 0x0041D909
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0601D392 RID: 119698 RVA: 0x0041F719 File Offset: 0x0041D919
		public static Offset<ILoopTeleportClientMpcEffect> EndILoopTeleportClientMpcEffect(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportClientMpcEffect>(builder.EndTable());
		}

		// Token: 0x0601D393 RID: 119699 RVA: 0x0041F728 File Offset: 0x0041D928
		public ILoopTeleportClientMpcEffectT UnPack()
		{
			ILoopTeleportClientMpcEffectT loopTeleportClientMpcEffectT = new ILoopTeleportClientMpcEffectT();
			this.UnPackTo(loopTeleportClientMpcEffectT);
			return loopTeleportClientMpcEffectT;
		}

		// Token: 0x0601D394 RID: 119700 RVA: 0x0041F743 File Offset: 0x0041D943
		public void UnPackTo(ILoopTeleportClientMpcEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x0601D395 RID: 119701 RVA: 0x0041F760 File Offset: 0x0041D960
		public static Offset<ILoopTeleportClientMpcEffect> Pack(FlatBufferBuilder builder, ILoopTeleportClientMpcEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopTeleportClientMpcEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return ILoopTeleportClientMpcEffect.CreateILoopTeleportClientMpcEffect(builder, _o.Type, pathOffset);
		}

		// Token: 0x0400CF75 RID: 53109
		private Table __p;
	}
}
