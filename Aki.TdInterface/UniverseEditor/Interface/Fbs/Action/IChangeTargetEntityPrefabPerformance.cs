using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006997 RID: 27031
	public struct IChangeTargetEntityPrefabPerformance : IFlatbufferObject
	{
		// Token: 0x1700C6FD RID: 50941
		// (get) Token: 0x0602E5D8 RID: 189912 RVA: 0x006541DD File Offset: 0x006523DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E5D9 RID: 189913 RVA: 0x006541EA File Offset: 0x006523EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E5DA RID: 189914 RVA: 0x006541F4 File Offset: 0x006523F4
		public static IChangeTargetEntityPrefabPerformance GetRootAsIChangeTargetEntityPrefabPerformance(ByteBuffer _bb)
		{
			return IChangeTargetEntityPrefabPerformance.GetRootAsIChangeTargetEntityPrefabPerformance(_bb, default(IChangeTargetEntityPrefabPerformance));
		}

		// Token: 0x0602E5DB RID: 189915 RVA: 0x00654210 File Offset: 0x00652410
		public static IChangeTargetEntityPrefabPerformance GetRootAsIChangeTargetEntityPrefabPerformance(ByteBuffer _bb, IChangeTargetEntityPrefabPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E5DC RID: 189916 RVA: 0x0065422D File Offset: 0x0065242D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E5DD RID: 189917 RVA: 0x0065423C File Offset: 0x0065243C
		public IChangeTargetEntityPrefabPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6FE RID: 50942
		// (get) Token: 0x0602E5DE RID: 189918 RVA: 0x0065424C File Offset: 0x0065244C
		public EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeEntityPrefabPerformanceType.Target;
				}
				return (EChangeEntityPrefabPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C6FF RID: 50943
		// (get) Token: 0x0602E5DF RID: 189919 RVA: 0x00654288 File Offset: 0x00652488
		public int EntityId
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

		// Token: 0x1700C700 RID: 50944
		// (get) Token: 0x0602E5E0 RID: 189920 RVA: 0x006542C4 File Offset: 0x006524C4
		public string PerformanceTag
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E5E1 RID: 189921 RVA: 0x006542FB File Offset: 0x006524FB
		public Span<byte> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602E5E2 RID: 189922 RVA: 0x0065430A File Offset: 0x0065250A
		public byte[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602E5E3 RID: 189923 RVA: 0x00654318 File Offset: 0x00652518
		public static Offset<IChangeTargetEntityPrefabPerformance> CreateIChangeTargetEntityPrefabPerformance(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target, int EntityId = 0, StringOffset PerformanceTagOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IChangeTargetEntityPrefabPerformance.AddPerformanceTag(builder, PerformanceTagOffset);
			IChangeTargetEntityPrefabPerformance.AddEntityId(builder, EntityId);
			IChangeTargetEntityPrefabPerformance.AddType(builder, Type);
			return IChangeTargetEntityPrefabPerformance.EndIChangeTargetEntityPrefabPerformance(builder);
		}

		// Token: 0x0602E5E4 RID: 189924 RVA: 0x0065433C File Offset: 0x0065253C
		public static void StartIChangeTargetEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E5E5 RID: 189925 RVA: 0x00654345 File Offset: 0x00652545
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E5E6 RID: 189926 RVA: 0x00654350 File Offset: 0x00652550
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602E5E7 RID: 189927 RVA: 0x0065435B File Offset: 0x0065255B
		public static void AddPerformanceTag(FlatBufferBuilder builder, StringOffset performanceTagOffset)
		{
			builder.AddOffset(2, performanceTagOffset.Value, 0);
		}

		// Token: 0x0602E5E8 RID: 189928 RVA: 0x0065436B File Offset: 0x0065256B
		public static Offset<IChangeTargetEntityPrefabPerformance> EndIChangeTargetEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			return new Offset<IChangeTargetEntityPrefabPerformance>(builder.EndTable());
		}

		// Token: 0x0602E5E9 RID: 189929 RVA: 0x00654378 File Offset: 0x00652578
		public IChangeTargetEntityPrefabPerformanceT UnPack()
		{
			IChangeTargetEntityPrefabPerformanceT changeTargetEntityPrefabPerformanceT = new IChangeTargetEntityPrefabPerformanceT();
			this.UnPackTo(changeTargetEntityPrefabPerformanceT);
			return changeTargetEntityPrefabPerformanceT;
		}

		// Token: 0x0602E5EA RID: 189930 RVA: 0x00654393 File Offset: 0x00652593
		public void UnPackTo(IChangeTargetEntityPrefabPerformanceT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PerformanceTag = this.PerformanceTag;
		}

		// Token: 0x0602E5EB RID: 189931 RVA: 0x006543BC File Offset: 0x006525BC
		public static Offset<IChangeTargetEntityPrefabPerformance> Pack(FlatBufferBuilder builder, IChangeTargetEntityPrefabPerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeTargetEntityPrefabPerformance>);
			}
			StringOffset performanceTagOffset = (_o.PerformanceTag == null) ? default(StringOffset) : builder.CreateString(_o.PerformanceTag);
			return IChangeTargetEntityPrefabPerformance.CreateIChangeTargetEntityPrefabPerformance(builder, _o.Type, _o.EntityId, performanceTagOffset);
		}

		// Token: 0x040116FD RID: 71421
		private Table __p;
	}
}
