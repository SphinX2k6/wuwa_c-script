using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004908 RID: 18696
	public struct ILoopTeleportClientPlayEffectBase : IFlatbufferObject
	{
		// Token: 0x1700878F RID: 34703
		// (get) Token: 0x0601D39C RID: 119708 RVA: 0x0041F80D File Offset: 0x0041DA0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D39D RID: 119709 RVA: 0x0041F81A File Offset: 0x0041DA1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D39E RID: 119710 RVA: 0x0041F824 File Offset: 0x0041DA24
		public static ILoopTeleportClientPlayEffectBase GetRootAsILoopTeleportClientPlayEffectBase(ByteBuffer _bb)
		{
			return ILoopTeleportClientPlayEffectBase.GetRootAsILoopTeleportClientPlayEffectBase(_bb, default(ILoopTeleportClientPlayEffectBase));
		}

		// Token: 0x0601D39F RID: 119711 RVA: 0x0041F840 File Offset: 0x0041DA40
		public static ILoopTeleportClientPlayEffectBase GetRootAsILoopTeleportClientPlayEffectBase(ByteBuffer _bb, ILoopTeleportClientPlayEffectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D3A0 RID: 119712 RVA: 0x0041F85D File Offset: 0x0041DA5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D3A1 RID: 119713 RVA: 0x0041F86C File Offset: 0x0041DA6C
		public ILoopTeleportClientPlayEffectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008790 RID: 34704
		// (get) Token: 0x0601D3A2 RID: 119714 RVA: 0x0041F87C File Offset: 0x0041DA7C
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

		// Token: 0x17008791 RID: 34705
		// (get) Token: 0x0601D3A3 RID: 119715 RVA: 0x0041F8B8 File Offset: 0x0041DAB8
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

		// Token: 0x0601D3A4 RID: 119716 RVA: 0x0041F8EF File Offset: 0x0041DAEF
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D3A5 RID: 119717 RVA: 0x0041F8FE File Offset: 0x0041DAFE
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601D3A6 RID: 119718 RVA: 0x0041F90C File Offset: 0x0041DB0C
		public static Offset<ILoopTeleportClientPlayEffectBase> CreateILoopTeleportClientPlayEffectBase(FlatBufferBuilder builder, ELoopTeleportClientEffectType Type = ELoopTeleportClientEffectType.ScreenEffect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILoopTeleportClientPlayEffectBase.AddPath(builder, PathOffset);
			ILoopTeleportClientPlayEffectBase.AddType(builder, Type);
			return ILoopTeleportClientPlayEffectBase.EndILoopTeleportClientPlayEffectBase(builder);
		}

		// Token: 0x0601D3A7 RID: 119719 RVA: 0x0041F929 File Offset: 0x0041DB29
		public static void StartILoopTeleportClientPlayEffectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D3A8 RID: 119720 RVA: 0x0041F932 File Offset: 0x0041DB32
		public static void AddType(FlatBufferBuilder builder, ELoopTeleportClientEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D3A9 RID: 119721 RVA: 0x0041F93D File Offset: 0x0041DB3D
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0601D3AA RID: 119722 RVA: 0x0041F94D File Offset: 0x0041DB4D
		public static Offset<ILoopTeleportClientPlayEffectBase> EndILoopTeleportClientPlayEffectBase(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportClientPlayEffectBase>(builder.EndTable());
		}

		// Token: 0x0601D3AB RID: 119723 RVA: 0x0041F95C File Offset: 0x0041DB5C
		public ILoopTeleportClientPlayEffectBaseT UnPack()
		{
			ILoopTeleportClientPlayEffectBaseT loopTeleportClientPlayEffectBaseT = new ILoopTeleportClientPlayEffectBaseT();
			this.UnPackTo(loopTeleportClientPlayEffectBaseT);
			return loopTeleportClientPlayEffectBaseT;
		}

		// Token: 0x0601D3AC RID: 119724 RVA: 0x0041F977 File Offset: 0x0041DB77
		public void UnPackTo(ILoopTeleportClientPlayEffectBaseT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x0601D3AD RID: 119725 RVA: 0x0041F994 File Offset: 0x0041DB94
		public static Offset<ILoopTeleportClientPlayEffectBase> Pack(FlatBufferBuilder builder, ILoopTeleportClientPlayEffectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopTeleportClientPlayEffectBase>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return ILoopTeleportClientPlayEffectBase.CreateILoopTeleportClientPlayEffectBase(builder, _o.Type, pathOffset);
		}

		// Token: 0x0400CF78 RID: 53112
		private Table __p;
	}
}
