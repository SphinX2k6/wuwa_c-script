using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EB9 RID: 24249
	public struct ISceneItemAiPatrolByGameTime : IFlatbufferObject
	{
		// Token: 0x1700B32A RID: 45866
		// (get) Token: 0x06028A2A RID: 166442 RVA: 0x0058E40B File Offset: 0x0058C60B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028A2B RID: 166443 RVA: 0x0058E418 File Offset: 0x0058C618
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028A2C RID: 166444 RVA: 0x0058E420 File Offset: 0x0058C620
		public static ISceneItemAiPatrolByGameTime GetRootAsISceneItemAiPatrolByGameTime(ByteBuffer _bb)
		{
			return ISceneItemAiPatrolByGameTime.GetRootAsISceneItemAiPatrolByGameTime(_bb, default(ISceneItemAiPatrolByGameTime));
		}

		// Token: 0x06028A2D RID: 166445 RVA: 0x0058E43C File Offset: 0x0058C63C
		public static ISceneItemAiPatrolByGameTime GetRootAsISceneItemAiPatrolByGameTime(ByteBuffer _bb, ISceneItemAiPatrolByGameTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028A2E RID: 166446 RVA: 0x0058E459 File Offset: 0x0058C659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028A2F RID: 166447 RVA: 0x0058E468 File Offset: 0x0058C668
		public ISceneItemAiPatrolByGameTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B32B RID: 45867
		// (get) Token: 0x06028A30 RID: 166448 RVA: 0x0058E478 File Offset: 0x0058C678
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

		// Token: 0x1700B32C RID: 45868
		// (get) Token: 0x06028A31 RID: 166449 RVA: 0x0058E4B4 File Offset: 0x0058C6B4
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

		// Token: 0x06028A32 RID: 166450 RVA: 0x0058E4F0 File Offset: 0x0058C6F0
		public static Offset<ISceneItemAiPatrolByGameTime> CreateISceneItemAiPatrolByGameTime(FlatBufferBuilder builder, ESceneItemAiPatrolType Type = ESceneItemAiPatrolType.ByGameTime, int Spline = 0)
		{
			builder.StartTable(2);
			ISceneItemAiPatrolByGameTime.AddSpline(builder, Spline);
			ISceneItemAiPatrolByGameTime.AddType(builder, Type);
			return ISceneItemAiPatrolByGameTime.EndISceneItemAiPatrolByGameTime(builder);
		}

		// Token: 0x06028A33 RID: 166451 RVA: 0x0058E50D File Offset: 0x0058C70D
		public static void StartISceneItemAiPatrolByGameTime(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028A34 RID: 166452 RVA: 0x0058E516 File Offset: 0x0058C716
		public static void AddType(FlatBufferBuilder builder, ESceneItemAiPatrolType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028A35 RID: 166453 RVA: 0x0058E521 File Offset: 0x0058C721
		public static void AddSpline(FlatBufferBuilder builder, int spline)
		{
			builder.AddInt(1, spline, 0);
		}

		// Token: 0x06028A36 RID: 166454 RVA: 0x0058E52C File Offset: 0x0058C72C
		public static Offset<ISceneItemAiPatrolByGameTime> EndISceneItemAiPatrolByGameTime(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemAiPatrolByGameTime>(builder.EndTable());
		}

		// Token: 0x06028A37 RID: 166455 RVA: 0x0058E53C File Offset: 0x0058C73C
		public ISceneItemAiPatrolByGameTimeT UnPack()
		{
			ISceneItemAiPatrolByGameTimeT sceneItemAiPatrolByGameTimeT = new ISceneItemAiPatrolByGameTimeT();
			this.UnPackTo(sceneItemAiPatrolByGameTimeT);
			return sceneItemAiPatrolByGameTimeT;
		}

		// Token: 0x06028A38 RID: 166456 RVA: 0x0058E557 File Offset: 0x0058C757
		public void UnPackTo(ISceneItemAiPatrolByGameTimeT _o)
		{
			_o.Type = this.Type;
			_o.Spline = this.Spline;
		}

		// Token: 0x06028A39 RID: 166457 RVA: 0x0058E574 File Offset: 0x0058C774
		public static Offset<ISceneItemAiPatrolByGameTime> Pack(FlatBufferBuilder builder, ISceneItemAiPatrolByGameTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemAiPatrolByGameTime>);
			}
			return ISceneItemAiPatrolByGameTime.CreateISceneItemAiPatrolByGameTime(builder, _o.Type, _o.Spline);
		}

		// Token: 0x0400FB0B RID: 64267
		private Table __p;
	}
}
