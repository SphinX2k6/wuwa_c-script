using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A01 RID: 31233
	public struct ISubtitleStyleNewLevelB : IFlatbufferObject
	{
		// Token: 0x1700E4E8 RID: 58600
		// (get) Token: 0x06037084 RID: 225412 RVA: 0x0075B1B9 File Offset: 0x007593B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037085 RID: 225413 RVA: 0x0075B1C6 File Offset: 0x007593C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037086 RID: 225414 RVA: 0x0075B1D0 File Offset: 0x007593D0
		public static ISubtitleStyleNewLevelB GetRootAsISubtitleStyleNewLevelB(ByteBuffer _bb)
		{
			return ISubtitleStyleNewLevelB.GetRootAsISubtitleStyleNewLevelB(_bb, default(ISubtitleStyleNewLevelB));
		}

		// Token: 0x06037087 RID: 225415 RVA: 0x0075B1EC File Offset: 0x007593EC
		public static ISubtitleStyleNewLevelB GetRootAsISubtitleStyleNewLevelB(ByteBuffer _bb, ISubtitleStyleNewLevelB obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037088 RID: 225416 RVA: 0x0075B209 File Offset: 0x00759409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037089 RID: 225417 RVA: 0x0075B218 File Offset: 0x00759418
		public ISubtitleStyleNewLevelB __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4E9 RID: 58601
		// (get) Token: 0x0603708A RID: 225418 RVA: 0x0075B228 File Offset: 0x00759428
		public ESubtitleStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubtitleStyle.LevelA;
				}
				return (ESubtitleStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603708B RID: 225419 RVA: 0x0075B264 File Offset: 0x00759464
		public static Offset<ISubtitleStyleNewLevelB> CreateISubtitleStyleNewLevelB(FlatBufferBuilder builder, ESubtitleStyle Type = ESubtitleStyle.LevelA)
		{
			builder.StartTable(1);
			ISubtitleStyleNewLevelB.AddType(builder, Type);
			return ISubtitleStyleNewLevelB.EndISubtitleStyleNewLevelB(builder);
		}

		// Token: 0x0603708C RID: 225420 RVA: 0x0075B27A File Offset: 0x0075947A
		public static void StartISubtitleStyleNewLevelB(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603708D RID: 225421 RVA: 0x0075B283 File Offset: 0x00759483
		public static void AddType(FlatBufferBuilder builder, ESubtitleStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603708E RID: 225422 RVA: 0x0075B28E File Offset: 0x0075948E
		public static Offset<ISubtitleStyleNewLevelB> EndISubtitleStyleNewLevelB(FlatBufferBuilder builder)
		{
			return new Offset<ISubtitleStyleNewLevelB>(builder.EndTable());
		}

		// Token: 0x0603708F RID: 225423 RVA: 0x0075B29C File Offset: 0x0075949C
		public ISubtitleStyleNewLevelBT UnPack()
		{
			ISubtitleStyleNewLevelBT subtitleStyleNewLevelBT = new ISubtitleStyleNewLevelBT();
			this.UnPackTo(subtitleStyleNewLevelBT);
			return subtitleStyleNewLevelBT;
		}

		// Token: 0x06037090 RID: 225424 RVA: 0x0075B2B7 File Offset: 0x007594B7
		public void UnPackTo(ISubtitleStyleNewLevelBT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06037091 RID: 225425 RVA: 0x0075B2C8 File Offset: 0x007594C8
		public static Offset<ISubtitleStyleNewLevelB> Pack(FlatBufferBuilder builder, ISubtitleStyleNewLevelBT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubtitleStyleNewLevelB>);
			}
			return ISubtitleStyleNewLevelB.CreateISubtitleStyleNewLevelB(builder, _o.Type);
		}

		// Token: 0x04012D20 RID: 77088
		private Table __p;
	}
}
