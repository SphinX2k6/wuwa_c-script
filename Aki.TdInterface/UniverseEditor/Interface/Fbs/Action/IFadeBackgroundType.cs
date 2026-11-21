using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E00 RID: 28160
	public struct IFadeBackgroundType : IFlatbufferObject
	{
		// Token: 0x1700CE64 RID: 52836
		// (get) Token: 0x060309D7 RID: 199127 RVA: 0x00699A56 File Offset: 0x00697C56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060309D8 RID: 199128 RVA: 0x00699A63 File Offset: 0x00697C63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060309D9 RID: 199129 RVA: 0x00699A6C File Offset: 0x00697C6C
		public static IFadeBackgroundType GetRootAsIFadeBackgroundType(ByteBuffer _bb)
		{
			return IFadeBackgroundType.GetRootAsIFadeBackgroundType(_bb, default(IFadeBackgroundType));
		}

		// Token: 0x060309DA RID: 199130 RVA: 0x00699A88 File Offset: 0x00697C88
		public static IFadeBackgroundType GetRootAsIFadeBackgroundType(ByteBuffer _bb, IFadeBackgroundType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060309DB RID: 199131 RVA: 0x00699AA5 File Offset: 0x00697CA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060309DC RID: 199132 RVA: 0x00699AB4 File Offset: 0x00697CB4
		public IFadeBackgroundType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE65 RID: 52837
		// (get) Token: 0x060309DD RID: 199133 RVA: 0x00699AC4 File Offset: 0x00697CC4
		public EFadeBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundType.Spine;
				}
				return (EFadeBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060309DE RID: 199134 RVA: 0x00699B00 File Offset: 0x00697D00
		public static Offset<IFadeBackgroundType> CreateIFadeBackgroundType(FlatBufferBuilder builder, EFadeBackgroundType Type = EFadeBackgroundType.Spine)
		{
			builder.StartTable(1);
			IFadeBackgroundType.AddType(builder, Type);
			return IFadeBackgroundType.EndIFadeBackgroundType(builder);
		}

		// Token: 0x060309DF RID: 199135 RVA: 0x00699B16 File Offset: 0x00697D16
		public static void StartIFadeBackgroundType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060309E0 RID: 199136 RVA: 0x00699B1F File Offset: 0x00697D1F
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060309E1 RID: 199137 RVA: 0x00699B2A File Offset: 0x00697D2A
		public static Offset<IFadeBackgroundType> EndIFadeBackgroundType(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundType>(builder.EndTable());
		}

		// Token: 0x060309E2 RID: 199138 RVA: 0x00699B38 File Offset: 0x00697D38
		public IFadeBackgroundTypeT UnPack()
		{
			IFadeBackgroundTypeT fadeBackgroundTypeT = new IFadeBackgroundTypeT();
			this.UnPackTo(fadeBackgroundTypeT);
			return fadeBackgroundTypeT;
		}

		// Token: 0x060309E3 RID: 199139 RVA: 0x00699B53 File Offset: 0x00697D53
		public void UnPackTo(IFadeBackgroundTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060309E4 RID: 199140 RVA: 0x00699B64 File Offset: 0x00697D64
		public static Offset<IFadeBackgroundType> Pack(FlatBufferBuilder builder, IFadeBackgroundTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundType>);
			}
			return IFadeBackgroundType.CreateIFadeBackgroundType(builder, _o.Type);
		}

		// Token: 0x04011CB2 RID: 72882
		private Table __p;
	}
}
