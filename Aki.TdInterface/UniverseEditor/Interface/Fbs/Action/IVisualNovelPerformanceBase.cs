using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200759B RID: 30107
	public struct IVisualNovelPerformanceBase : IFlatbufferObject
	{
		// Token: 0x1700E454 RID: 58452
		// (get) Token: 0x06036C5E RID: 224350 RVA: 0x0076F70F File Offset: 0x0076D90F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036C5F RID: 224351 RVA: 0x0076F71C File Offset: 0x0076D91C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036C60 RID: 224352 RVA: 0x0076F724 File Offset: 0x0076D924
		public static IVisualNovelPerformanceBase GetRootAsIVisualNovelPerformanceBase(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceBase.GetRootAsIVisualNovelPerformanceBase(_bb, default(IVisualNovelPerformanceBase));
		}

		// Token: 0x06036C61 RID: 224353 RVA: 0x0076F740 File Offset: 0x0076D940
		public static IVisualNovelPerformanceBase GetRootAsIVisualNovelPerformanceBase(ByteBuffer _bb, IVisualNovelPerformanceBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036C62 RID: 224354 RVA: 0x0076F75D File Offset: 0x0076D95D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036C63 RID: 224355 RVA: 0x0076F76C File Offset: 0x0076D96C
		public IVisualNovelPerformanceBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E455 RID: 58453
		// (get) Token: 0x06036C64 RID: 224356 RVA: 0x0076F77C File Offset: 0x0076D97C
		public EVisualNovelPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return (EVisualNovelPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E456 RID: 58454
		// (get) Token: 0x06036C65 RID: 224357 RVA: 0x0076F7B8 File Offset: 0x0076D9B8
		public float StartTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E457 RID: 58455
		// (get) Token: 0x06036C66 RID: 224358 RVA: 0x0076F7F8 File Offset: 0x0076D9F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036C67 RID: 224359 RVA: 0x0076F834 File Offset: 0x0076DA34
		public static Offset<IVisualNovelPerformanceBase> CreateIVisualNovelPerformanceBase(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVisualNovelPerformanceBase.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceBase.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceBase.AddType(builder, Type);
			return IVisualNovelPerformanceBase.EndIVisualNovelPerformanceBase(builder);
		}

		// Token: 0x06036C68 RID: 224360 RVA: 0x0076F858 File Offset: 0x0076DA58
		public static void StartIVisualNovelPerformanceBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036C69 RID: 224361 RVA: 0x0076F861 File Offset: 0x0076DA61
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036C6A RID: 224362 RVA: 0x0076F86C File Offset: 0x0076DA6C
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036C6B RID: 224363 RVA: 0x0076F87F File Offset: 0x0076DA7F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06036C6C RID: 224364 RVA: 0x0076F88A File Offset: 0x0076DA8A
		public static Offset<IVisualNovelPerformanceBase> EndIVisualNovelPerformanceBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceBase>(builder.EndTable());
		}

		// Token: 0x06036C6D RID: 224365 RVA: 0x0076F898 File Offset: 0x0076DA98
		public IVisualNovelPerformanceBaseT UnPack()
		{
			IVisualNovelPerformanceBaseT visualNovelPerformanceBaseT = new IVisualNovelPerformanceBaseT();
			this.UnPackTo(visualNovelPerformanceBaseT);
			return visualNovelPerformanceBaseT;
		}

		// Token: 0x06036C6E RID: 224366 RVA: 0x0076F8B3 File Offset: 0x0076DAB3
		public void UnPackTo(IVisualNovelPerformanceBaseT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036C6F RID: 224367 RVA: 0x0076F8DC File Offset: 0x0076DADC
		public static Offset<IVisualNovelPerformanceBase> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceBase>);
			}
			return IVisualNovelPerformanceBase.CreateIVisualNovelPerformanceBase(builder, _o.Type, _o.StartTime, _o.NullMask);
		}

		// Token: 0x040124AC RID: 74924
		private Table __p;
	}
}
