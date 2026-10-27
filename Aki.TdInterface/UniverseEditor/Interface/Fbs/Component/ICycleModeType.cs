using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005066 RID: 20582
	public struct ICycleModeType : IFlatbufferObject
	{
		// Token: 0x17009552 RID: 38226
		// (get) Token: 0x06020FC9 RID: 135113 RVA: 0x00495725 File Offset: 0x00493925
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020FCA RID: 135114 RVA: 0x00495732 File Offset: 0x00493932
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020FCB RID: 135115 RVA: 0x0049573C File Offset: 0x0049393C
		public static ICycleModeType GetRootAsICycleModeType(ByteBuffer _bb)
		{
			return ICycleModeType.GetRootAsICycleModeType(_bb, default(ICycleModeType));
		}

		// Token: 0x06020FCC RID: 135116 RVA: 0x00495758 File Offset: 0x00493958
		public static ICycleModeType GetRootAsICycleModeType(ByteBuffer _bb, ICycleModeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020FCD RID: 135117 RVA: 0x00495775 File Offset: 0x00493975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020FCE RID: 135118 RVA: 0x00495784 File Offset: 0x00493984
		public ICycleModeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009553 RID: 38227
		// (get) Token: 0x06020FCF RID: 135119 RVA: 0x00495794 File Offset: 0x00493994
		public EPatrolCycleMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPatrolCycleMode.Loop;
				}
				return (EPatrolCycleMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020FD0 RID: 135120 RVA: 0x004957D0 File Offset: 0x004939D0
		public static Offset<ICycleModeType> CreateICycleModeType(FlatBufferBuilder builder, EPatrolCycleMode Type = EPatrolCycleMode.Loop)
		{
			builder.StartTable(1);
			ICycleModeType.AddType(builder, Type);
			return ICycleModeType.EndICycleModeType(builder);
		}

		// Token: 0x06020FD1 RID: 135121 RVA: 0x004957E6 File Offset: 0x004939E6
		public static void StartICycleModeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020FD2 RID: 135122 RVA: 0x004957EF File Offset: 0x004939EF
		public static void AddType(FlatBufferBuilder builder, EPatrolCycleMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020FD3 RID: 135123 RVA: 0x004957FA File Offset: 0x004939FA
		public static Offset<ICycleModeType> EndICycleModeType(FlatBufferBuilder builder)
		{
			return new Offset<ICycleModeType>(builder.EndTable());
		}

		// Token: 0x06020FD4 RID: 135124 RVA: 0x00495808 File Offset: 0x00493A08
		public ICycleModeTypeT UnPack()
		{
			ICycleModeTypeT cycleModeTypeT = new ICycleModeTypeT();
			this.UnPackTo(cycleModeTypeT);
			return cycleModeTypeT;
		}

		// Token: 0x06020FD5 RID: 135125 RVA: 0x00495823 File Offset: 0x00493A23
		public void UnPackTo(ICycleModeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020FD6 RID: 135126 RVA: 0x00495834 File Offset: 0x00493A34
		public static Offset<ICycleModeType> Pack(FlatBufferBuilder builder, ICycleModeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICycleModeType>);
			}
			return ICycleModeType.CreateICycleModeType(builder, _o.Type);
		}

		// Token: 0x0400E062 RID: 57442
		private Table __p;
	}
}
