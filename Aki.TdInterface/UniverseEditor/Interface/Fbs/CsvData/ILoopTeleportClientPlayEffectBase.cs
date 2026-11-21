using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DA3 RID: 19875
	public struct ILoopTeleportClientPlayEffectBase : IFlatbufferObject
	{
		// Token: 0x17008E32 RID: 36402
		// (get) Token: 0x0601ED35 RID: 126261 RVA: 0x0044EF6D File Offset: 0x0044D16D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED36 RID: 126262 RVA: 0x0044EF7A File Offset: 0x0044D17A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED37 RID: 126263 RVA: 0x0044EF84 File Offset: 0x0044D184
		public static ILoopTeleportClientPlayEffectBase GetRootAsILoopTeleportClientPlayEffectBase(ByteBuffer _bb)
		{
			return ILoopTeleportClientPlayEffectBase.GetRootAsILoopTeleportClientPlayEffectBase(_bb, default(ILoopTeleportClientPlayEffectBase));
		}

		// Token: 0x0601ED38 RID: 126264 RVA: 0x0044EFA0 File Offset: 0x0044D1A0
		public static ILoopTeleportClientPlayEffectBase GetRootAsILoopTeleportClientPlayEffectBase(ByteBuffer _bb, ILoopTeleportClientPlayEffectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED39 RID: 126265 RVA: 0x0044EFBD File Offset: 0x0044D1BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED3A RID: 126266 RVA: 0x0044EFCC File Offset: 0x0044D1CC
		public ILoopTeleportClientPlayEffectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E33 RID: 36403
		// (get) Token: 0x0601ED3B RID: 126267 RVA: 0x0044EFDC File Offset: 0x0044D1DC
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

		// Token: 0x17008E34 RID: 36404
		// (get) Token: 0x0601ED3C RID: 126268 RVA: 0x0044F018 File Offset: 0x0044D218
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

		// Token: 0x0601ED3D RID: 126269 RVA: 0x0044F04F File Offset: 0x0044D24F
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601ED3E RID: 126270 RVA: 0x0044F05E File Offset: 0x0044D25E
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601ED3F RID: 126271 RVA: 0x0044F06C File Offset: 0x0044D26C
		public static Offset<ILoopTeleportClientPlayEffectBase> CreateILoopTeleportClientPlayEffectBase(FlatBufferBuilder builder, ELoopTeleportClientEffectType Type = ELoopTeleportClientEffectType.ScreenEffect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILoopTeleportClientPlayEffectBase.AddPath(builder, PathOffset);
			ILoopTeleportClientPlayEffectBase.AddType(builder, Type);
			return ILoopTeleportClientPlayEffectBase.EndILoopTeleportClientPlayEffectBase(builder);
		}

		// Token: 0x0601ED40 RID: 126272 RVA: 0x0044F089 File Offset: 0x0044D289
		public static void StartILoopTeleportClientPlayEffectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601ED41 RID: 126273 RVA: 0x0044F092 File Offset: 0x0044D292
		public static void AddType(FlatBufferBuilder builder, ELoopTeleportClientEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ED42 RID: 126274 RVA: 0x0044F09D File Offset: 0x0044D29D
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0601ED43 RID: 126275 RVA: 0x0044F0AD File Offset: 0x0044D2AD
		public static Offset<ILoopTeleportClientPlayEffectBase> EndILoopTeleportClientPlayEffectBase(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportClientPlayEffectBase>(builder.EndTable());
		}

		// Token: 0x0601ED44 RID: 126276 RVA: 0x0044F0BC File Offset: 0x0044D2BC
		public ILoopTeleportClientPlayEffectBaseT UnPack()
		{
			ILoopTeleportClientPlayEffectBaseT loopTeleportClientPlayEffectBaseT = new ILoopTeleportClientPlayEffectBaseT();
			this.UnPackTo(loopTeleportClientPlayEffectBaseT);
			return loopTeleportClientPlayEffectBaseT;
		}

		// Token: 0x0601ED45 RID: 126277 RVA: 0x0044F0D7 File Offset: 0x0044D2D7
		public void UnPackTo(ILoopTeleportClientPlayEffectBaseT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x0601ED46 RID: 126278 RVA: 0x0044F0F4 File Offset: 0x0044D2F4
		public static Offset<ILoopTeleportClientPlayEffectBase> Pack(FlatBufferBuilder builder, ILoopTeleportClientPlayEffectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopTeleportClientPlayEffectBase>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return ILoopTeleportClientPlayEffectBase.CreateILoopTeleportClientPlayEffectBase(builder, _o.Type, pathOffset);
		}

		// Token: 0x0400DA03 RID: 55811
		private Table __p;
	}
}
