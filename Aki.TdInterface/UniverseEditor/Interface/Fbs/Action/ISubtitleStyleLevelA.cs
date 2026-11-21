using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079FE RID: 31230
	public struct ISubtitleStyleLevelA : IFlatbufferObject
	{
		// Token: 0x1700E4E5 RID: 58597
		// (get) Token: 0x06037072 RID: 225394 RVA: 0x0075B044 File Offset: 0x00759244
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037073 RID: 225395 RVA: 0x0075B051 File Offset: 0x00759251
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037074 RID: 225396 RVA: 0x0075B058 File Offset: 0x00759258
		public static ISubtitleStyleLevelA GetRootAsISubtitleStyleLevelA(ByteBuffer _bb)
		{
			return ISubtitleStyleLevelA.GetRootAsISubtitleStyleLevelA(_bb, default(ISubtitleStyleLevelA));
		}

		// Token: 0x06037075 RID: 225397 RVA: 0x0075B074 File Offset: 0x00759274
		public static ISubtitleStyleLevelA GetRootAsISubtitleStyleLevelA(ByteBuffer _bb, ISubtitleStyleLevelA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037076 RID: 225398 RVA: 0x0075B091 File Offset: 0x00759291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037077 RID: 225399 RVA: 0x0075B0A0 File Offset: 0x007592A0
		public ISubtitleStyleLevelA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4E6 RID: 58598
		// (get) Token: 0x06037078 RID: 225400 RVA: 0x0075B0B0 File Offset: 0x007592B0
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

		// Token: 0x06037079 RID: 225401 RVA: 0x0075B0EC File Offset: 0x007592EC
		public static Offset<ISubtitleStyleLevelA> CreateISubtitleStyleLevelA(FlatBufferBuilder builder, ESubtitleStyle Type = ESubtitleStyle.LevelA)
		{
			builder.StartTable(1);
			ISubtitleStyleLevelA.AddType(builder, Type);
			return ISubtitleStyleLevelA.EndISubtitleStyleLevelA(builder);
		}

		// Token: 0x0603707A RID: 225402 RVA: 0x0075B102 File Offset: 0x00759302
		public static void StartISubtitleStyleLevelA(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603707B RID: 225403 RVA: 0x0075B10B File Offset: 0x0075930B
		public static void AddType(FlatBufferBuilder builder, ESubtitleStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603707C RID: 225404 RVA: 0x0075B116 File Offset: 0x00759316
		public static Offset<ISubtitleStyleLevelA> EndISubtitleStyleLevelA(FlatBufferBuilder builder)
		{
			return new Offset<ISubtitleStyleLevelA>(builder.EndTable());
		}

		// Token: 0x0603707D RID: 225405 RVA: 0x0075B124 File Offset: 0x00759324
		public ISubtitleStyleLevelAT UnPack()
		{
			ISubtitleStyleLevelAT subtitleStyleLevelAT = new ISubtitleStyleLevelAT();
			this.UnPackTo(subtitleStyleLevelAT);
			return subtitleStyleLevelAT;
		}

		// Token: 0x0603707E RID: 225406 RVA: 0x0075B13F File Offset: 0x0075933F
		public void UnPackTo(ISubtitleStyleLevelAT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603707F RID: 225407 RVA: 0x0075B150 File Offset: 0x00759350
		public static Offset<ISubtitleStyleLevelA> Pack(FlatBufferBuilder builder, ISubtitleStyleLevelAT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubtitleStyleLevelA>);
			}
			return ISubtitleStyleLevelA.CreateISubtitleStyleLevelA(builder, _o.Type);
		}

		// Token: 0x04012D1E RID: 77086
		private Table __p;
	}
}
