using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C8 RID: 21960
	public struct ICycleModeType : IFlatbufferObject
	{
		// Token: 0x17009D38 RID: 40248
		// (get) Token: 0x06022F03 RID: 143107 RVA: 0x004CF3D9 File Offset: 0x004CD5D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F04 RID: 143108 RVA: 0x004CF3E6 File Offset: 0x004CD5E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F05 RID: 143109 RVA: 0x004CF3F0 File Offset: 0x004CD5F0
		public static ICycleModeType GetRootAsICycleModeType(ByteBuffer _bb)
		{
			return ICycleModeType.GetRootAsICycleModeType(_bb, default(ICycleModeType));
		}

		// Token: 0x06022F06 RID: 143110 RVA: 0x004CF40C File Offset: 0x004CD60C
		public static ICycleModeType GetRootAsICycleModeType(ByteBuffer _bb, ICycleModeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F07 RID: 143111 RVA: 0x004CF429 File Offset: 0x004CD629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F08 RID: 143112 RVA: 0x004CF438 File Offset: 0x004CD638
		public ICycleModeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D39 RID: 40249
		// (get) Token: 0x06022F09 RID: 143113 RVA: 0x004CF448 File Offset: 0x004CD648
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

		// Token: 0x06022F0A RID: 143114 RVA: 0x004CF484 File Offset: 0x004CD684
		public static Offset<ICycleModeType> CreateICycleModeType(FlatBufferBuilder builder, EPatrolCycleMode Type = EPatrolCycleMode.Loop)
		{
			builder.StartTable(1);
			ICycleModeType.AddType(builder, Type);
			return ICycleModeType.EndICycleModeType(builder);
		}

		// Token: 0x06022F0B RID: 143115 RVA: 0x004CF49A File Offset: 0x004CD69A
		public static void StartICycleModeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022F0C RID: 143116 RVA: 0x004CF4A3 File Offset: 0x004CD6A3
		public static void AddType(FlatBufferBuilder builder, EPatrolCycleMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022F0D RID: 143117 RVA: 0x004CF4AE File Offset: 0x004CD6AE
		public static Offset<ICycleModeType> EndICycleModeType(FlatBufferBuilder builder)
		{
			return new Offset<ICycleModeType>(builder.EndTable());
		}

		// Token: 0x06022F0E RID: 143118 RVA: 0x004CF4BC File Offset: 0x004CD6BC
		public ICycleModeTypeT UnPack()
		{
			ICycleModeTypeT cycleModeTypeT = new ICycleModeTypeT();
			this.UnPackTo(cycleModeTypeT);
			return cycleModeTypeT;
		}

		// Token: 0x06022F0F RID: 143119 RVA: 0x004CF4D7 File Offset: 0x004CD6D7
		public void UnPackTo(ICycleModeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022F10 RID: 143120 RVA: 0x004CF4E8 File Offset: 0x004CD6E8
		public static Offset<ICycleModeType> Pack(FlatBufferBuilder builder, ICycleModeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICycleModeType>);
			}
			return ICycleModeType.CreateICycleModeType(builder, _o.Type);
		}

		// Token: 0x0400EC5B RID: 60507
		private Table __p;
	}
}
