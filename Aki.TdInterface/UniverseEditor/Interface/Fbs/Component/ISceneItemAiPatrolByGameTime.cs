using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058AC RID: 22700
	public struct ISceneItemAiPatrolByGameTime : IFlatbufferObject
	{
		// Token: 0x1700A9FA RID: 43514
		// (get) Token: 0x060264C8 RID: 156872 RVA: 0x005478BF File Offset: 0x00545ABF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060264C9 RID: 156873 RVA: 0x005478CC File Offset: 0x00545ACC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060264CA RID: 156874 RVA: 0x005478D4 File Offset: 0x00545AD4
		public static ISceneItemAiPatrolByGameTime GetRootAsISceneItemAiPatrolByGameTime(ByteBuffer _bb)
		{
			return ISceneItemAiPatrolByGameTime.GetRootAsISceneItemAiPatrolByGameTime(_bb, default(ISceneItemAiPatrolByGameTime));
		}

		// Token: 0x060264CB RID: 156875 RVA: 0x005478F0 File Offset: 0x00545AF0
		public static ISceneItemAiPatrolByGameTime GetRootAsISceneItemAiPatrolByGameTime(ByteBuffer _bb, ISceneItemAiPatrolByGameTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060264CC RID: 156876 RVA: 0x0054790D File Offset: 0x00545B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060264CD RID: 156877 RVA: 0x0054791C File Offset: 0x00545B1C
		public ISceneItemAiPatrolByGameTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9FB RID: 43515
		// (get) Token: 0x060264CE RID: 156878 RVA: 0x0054792C File Offset: 0x00545B2C
		public ESceneItemAiPatrolType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneItemAiPatrolType.ByGameTime;
				}
				return (ESceneItemAiPatrolType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A9FC RID: 43516
		// (get) Token: 0x060264CF RID: 156879 RVA: 0x00547968 File Offset: 0x00545B68
		public int Spline
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060264D0 RID: 156880 RVA: 0x005479A4 File Offset: 0x00545BA4
		public static Offset<ISceneItemAiPatrolByGameTime> CreateISceneItemAiPatrolByGameTime(FlatBufferBuilder builder, ESceneItemAiPatrolType Type = ESceneItemAiPatrolType.ByGameTime, int Spline = 0)
		{
			builder.StartTable(2);
			ISceneItemAiPatrolByGameTime.AddSpline(builder, Spline);
			ISceneItemAiPatrolByGameTime.AddType(builder, Type);
			return ISceneItemAiPatrolByGameTime.EndISceneItemAiPatrolByGameTime(builder);
		}

		// Token: 0x060264D1 RID: 156881 RVA: 0x005479C1 File Offset: 0x00545BC1
		public static void StartISceneItemAiPatrolByGameTime(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060264D2 RID: 156882 RVA: 0x005479CA File Offset: 0x00545BCA
		public static void AddType(FlatBufferBuilder builder, ESceneItemAiPatrolType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060264D3 RID: 156883 RVA: 0x005479D5 File Offset: 0x00545BD5
		public static void AddSpline(FlatBufferBuilder builder, int spline)
		{
			builder.AddInt(1, spline, 0);
		}

		// Token: 0x060264D4 RID: 156884 RVA: 0x005479E0 File Offset: 0x00545BE0
		public static Offset<ISceneItemAiPatrolByGameTime> EndISceneItemAiPatrolByGameTime(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemAiPatrolByGameTime>(builder.EndTable());
		}

		// Token: 0x060264D5 RID: 156885 RVA: 0x005479F0 File Offset: 0x00545BF0
		public ISceneItemAiPatrolByGameTimeT UnPack()
		{
			ISceneItemAiPatrolByGameTimeT sceneItemAiPatrolByGameTimeT = new ISceneItemAiPatrolByGameTimeT();
			this.UnPackTo(sceneItemAiPatrolByGameTimeT);
			return sceneItemAiPatrolByGameTimeT;
		}

		// Token: 0x060264D6 RID: 156886 RVA: 0x00547A0B File Offset: 0x00545C0B
		public void UnPackTo(ISceneItemAiPatrolByGameTimeT _o)
		{
			_o.Type = this.Type;
			_o.Spline = this.Spline;
		}

		// Token: 0x060264D7 RID: 156887 RVA: 0x00547A28 File Offset: 0x00545C28
		public static Offset<ISceneItemAiPatrolByGameTime> Pack(FlatBufferBuilder builder, ISceneItemAiPatrolByGameTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemAiPatrolByGameTime>);
			}
			return ISceneItemAiPatrolByGameTime.CreateISceneItemAiPatrolByGameTime(builder, _o.Type, _o.Spline);
		}

		// Token: 0x0400EE18 RID: 60952
		private Table __p;
	}
}
