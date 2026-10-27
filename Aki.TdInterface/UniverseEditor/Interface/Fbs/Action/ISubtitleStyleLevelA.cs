using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007229 RID: 29225
	public struct ISubtitleStyleLevelA : IFlatbufferObject
	{
		// Token: 0x1700D8EC RID: 55532
		// (get) Token: 0x06033D70 RID: 212336 RVA: 0x006F9CE4 File Offset: 0x006F7EE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D71 RID: 212337 RVA: 0x006F9CF1 File Offset: 0x006F7EF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D72 RID: 212338 RVA: 0x006F9CF8 File Offset: 0x006F7EF8
		public static ISubtitleStyleLevelA GetRootAsISubtitleStyleLevelA(ByteBuffer _bb)
		{
			return ISubtitleStyleLevelA.GetRootAsISubtitleStyleLevelA(_bb, default(ISubtitleStyleLevelA));
		}

		// Token: 0x06033D73 RID: 212339 RVA: 0x006F9D14 File Offset: 0x006F7F14
		public static ISubtitleStyleLevelA GetRootAsISubtitleStyleLevelA(ByteBuffer _bb, ISubtitleStyleLevelA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D74 RID: 212340 RVA: 0x006F9D31 File Offset: 0x006F7F31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D75 RID: 212341 RVA: 0x006F9D40 File Offset: 0x006F7F40
		public ISubtitleStyleLevelA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8ED RID: 55533
		// (get) Token: 0x06033D76 RID: 212342 RVA: 0x006F9D50 File Offset: 0x006F7F50
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

		// Token: 0x06033D77 RID: 212343 RVA: 0x006F9D8C File Offset: 0x006F7F8C
		public static Offset<ISubtitleStyleLevelA> CreateISubtitleStyleLevelA(FlatBufferBuilder builder, ESubtitleStyle Type = ESubtitleStyle.LevelA)
		{
			builder.StartTable(1);
			ISubtitleStyleLevelA.AddType(builder, Type);
			return ISubtitleStyleLevelA.EndISubtitleStyleLevelA(builder);
		}

		// Token: 0x06033D78 RID: 212344 RVA: 0x006F9DA2 File Offset: 0x006F7FA2
		public static void StartISubtitleStyleLevelA(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033D79 RID: 212345 RVA: 0x006F9DAB File Offset: 0x006F7FAB
		public static void AddType(FlatBufferBuilder builder, ESubtitleStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033D7A RID: 212346 RVA: 0x006F9DB6 File Offset: 0x006F7FB6
		public static Offset<ISubtitleStyleLevelA> EndISubtitleStyleLevelA(FlatBufferBuilder builder)
		{
			return new Offset<ISubtitleStyleLevelA>(builder.EndTable());
		}

		// Token: 0x06033D7B RID: 212347 RVA: 0x006F9DC4 File Offset: 0x006F7FC4
		public ISubtitleStyleLevelAT UnPack()
		{
			ISubtitleStyleLevelAT subtitleStyleLevelAT = new ISubtitleStyleLevelAT();
			this.UnPackTo(subtitleStyleLevelAT);
			return subtitleStyleLevelAT;
		}

		// Token: 0x06033D7C RID: 212348 RVA: 0x006F9DDF File Offset: 0x006F7FDF
		public void UnPackTo(ISubtitleStyleLevelAT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033D7D RID: 212349 RVA: 0x006F9DF0 File Offset: 0x006F7FF0
		public static Offset<ISubtitleStyleLevelA> Pack(FlatBufferBuilder builder, ISubtitleStyleLevelAT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubtitleStyleLevelA>);
			}
			return ISubtitleStyleLevelA.CreateISubtitleStyleLevelA(builder, _o.Type);
		}

		// Token: 0x04011D1C RID: 72988
		private Table __p;
	}
}
