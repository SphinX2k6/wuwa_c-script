using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052B8 RID: 21176
	public struct IFollowTrackToStart : IFlatbufferObject
	{
		// Token: 0x17009B47 RID: 39751
		// (get) Token: 0x06022869 RID: 141417 RVA: 0x004C90E1 File Offset: 0x004C72E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602286A RID: 141418 RVA: 0x004C90EE File Offset: 0x004C72EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602286B RID: 141419 RVA: 0x004C90F8 File Offset: 0x004C72F8
		public static IFollowTrackToStart GetRootAsIFollowTrackToStart(ByteBuffer _bb)
		{
			return IFollowTrackToStart.GetRootAsIFollowTrackToStart(_bb, default(IFollowTrackToStart));
		}

		// Token: 0x0602286C RID: 141420 RVA: 0x004C9114 File Offset: 0x004C7314
		public static IFollowTrackToStart GetRootAsIFollowTrackToStart(ByteBuffer _bb, IFollowTrackToStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602286D RID: 141421 RVA: 0x004C9131 File Offset: 0x004C7331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602286E RID: 141422 RVA: 0x004C9140 File Offset: 0x004C7340
		public IFollowTrackToStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B48 RID: 39752
		// (get) Token: 0x0602286F RID: 141423 RVA: 0x004C9150 File Offset: 0x004C7350
		public EFollowTrackEndType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowTrackEndType.ToStart;
				}
				return (EFollowTrackEndType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022870 RID: 141424 RVA: 0x004C918C File Offset: 0x004C738C
		public static Offset<IFollowTrackToStart> CreateIFollowTrackToStart(FlatBufferBuilder builder, EFollowTrackEndType Type = EFollowTrackEndType.ToStart)
		{
			builder.StartTable(1);
			IFollowTrackToStart.AddType(builder, Type);
			return IFollowTrackToStart.EndIFollowTrackToStart(builder);
		}

		// Token: 0x06022871 RID: 141425 RVA: 0x004C91A2 File Offset: 0x004C73A2
		public static void StartIFollowTrackToStart(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022872 RID: 141426 RVA: 0x004C91AB File Offset: 0x004C73AB
		public static void AddType(FlatBufferBuilder builder, EFollowTrackEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022873 RID: 141427 RVA: 0x004C91B6 File Offset: 0x004C73B6
		public static Offset<IFollowTrackToStart> EndIFollowTrackToStart(FlatBufferBuilder builder)
		{
			return new Offset<IFollowTrackToStart>(builder.EndTable());
		}

		// Token: 0x06022874 RID: 141428 RVA: 0x004C91C4 File Offset: 0x004C73C4
		public IFollowTrackToStartT UnPack()
		{
			IFollowTrackToStartT followTrackToStartT = new IFollowTrackToStartT();
			this.UnPackTo(followTrackToStartT);
			return followTrackToStartT;
		}

		// Token: 0x06022875 RID: 141429 RVA: 0x004C91DF File Offset: 0x004C73DF
		public void UnPackTo(IFollowTrackToStartT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022876 RID: 141430 RVA: 0x004C91F0 File Offset: 0x004C73F0
		public static Offset<IFollowTrackToStart> Pack(FlatBufferBuilder builder, IFollowTrackToStartT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowTrackToStart>);
			}
			return IFollowTrackToStart.CreateIFollowTrackToStart(builder, _o.Type);
		}

		// Token: 0x0400E439 RID: 58425
		private Table __p;
	}
}
