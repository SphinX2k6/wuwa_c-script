using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052AC RID: 21164
	public struct IFollowTrackEndType : IFlatbufferObject
	{
		// Token: 0x17009B36 RID: 39734
		// (get) Token: 0x06022815 RID: 141333 RVA: 0x004C8891 File Offset: 0x004C6A91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022816 RID: 141334 RVA: 0x004C889E File Offset: 0x004C6A9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022817 RID: 141335 RVA: 0x004C88A8 File Offset: 0x004C6AA8
		public static IFollowTrackEndType GetRootAsIFollowTrackEndType(ByteBuffer _bb)
		{
			return IFollowTrackEndType.GetRootAsIFollowTrackEndType(_bb, default(IFollowTrackEndType));
		}

		// Token: 0x06022818 RID: 141336 RVA: 0x004C88C4 File Offset: 0x004C6AC4
		public static IFollowTrackEndType GetRootAsIFollowTrackEndType(ByteBuffer _bb, IFollowTrackEndType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022819 RID: 141337 RVA: 0x004C88E1 File Offset: 0x004C6AE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602281A RID: 141338 RVA: 0x004C88F0 File Offset: 0x004C6AF0
		public IFollowTrackEndType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B37 RID: 39735
		// (get) Token: 0x0602281B RID: 141339 RVA: 0x004C8900 File Offset: 0x004C6B00
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

		// Token: 0x0602281C RID: 141340 RVA: 0x004C893C File Offset: 0x004C6B3C
		public static Offset<IFollowTrackEndType> CreateIFollowTrackEndType(FlatBufferBuilder builder, EFollowTrackEndType Type = EFollowTrackEndType.ToStart)
		{
			builder.StartTable(1);
			IFollowTrackEndType.AddType(builder, Type);
			return IFollowTrackEndType.EndIFollowTrackEndType(builder);
		}

		// Token: 0x0602281D RID: 141341 RVA: 0x004C8952 File Offset: 0x004C6B52
		public static void StartIFollowTrackEndType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602281E RID: 141342 RVA: 0x004C895B File Offset: 0x004C6B5B
		public static void AddType(FlatBufferBuilder builder, EFollowTrackEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602281F RID: 141343 RVA: 0x004C8966 File Offset: 0x004C6B66
		public static Offset<IFollowTrackEndType> EndIFollowTrackEndType(FlatBufferBuilder builder)
		{
			return new Offset<IFollowTrackEndType>(builder.EndTable());
		}

		// Token: 0x06022820 RID: 141344 RVA: 0x004C8974 File Offset: 0x004C6B74
		public IFollowTrackEndTypeT UnPack()
		{
			IFollowTrackEndTypeT followTrackEndTypeT = new IFollowTrackEndTypeT();
			this.UnPackTo(followTrackEndTypeT);
			return followTrackEndTypeT;
		}

		// Token: 0x06022821 RID: 141345 RVA: 0x004C898F File Offset: 0x004C6B8F
		public void UnPackTo(IFollowTrackEndTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022822 RID: 141346 RVA: 0x004C89A0 File Offset: 0x004C6BA0
		public static Offset<IFollowTrackEndType> Pack(FlatBufferBuilder builder, IFollowTrackEndTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowTrackEndType>);
			}
			return IFollowTrackEndType.CreateIFollowTrackEndType(builder, _o.Type);
		}

		// Token: 0x0400E428 RID: 58408
		private Table __p;
	}
}
