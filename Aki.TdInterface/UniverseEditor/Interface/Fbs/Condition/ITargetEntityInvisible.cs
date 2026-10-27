using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CEE RID: 19694
	public struct ITargetEntityInvisible : IFlatbufferObject
	{
		// Token: 0x17008EE9 RID: 36585
		// (get) Token: 0x0601F416 RID: 128022 RVA: 0x0045C912 File Offset: 0x0045AB12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F417 RID: 128023 RVA: 0x0045C91F File Offset: 0x0045AB1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F418 RID: 128024 RVA: 0x0045C928 File Offset: 0x0045AB28
		public static ITargetEntityInvisible GetRootAsITargetEntityInvisible(ByteBuffer _bb)
		{
			return ITargetEntityInvisible.GetRootAsITargetEntityInvisible(_bb, default(ITargetEntityInvisible));
		}

		// Token: 0x0601F419 RID: 128025 RVA: 0x0045C944 File Offset: 0x0045AB44
		public static ITargetEntityInvisible GetRootAsITargetEntityInvisible(ByteBuffer _bb, ITargetEntityInvisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F41A RID: 128026 RVA: 0x0045C961 File Offset: 0x0045AB61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F41B RID: 128027 RVA: 0x0045C970 File Offset: 0x0045AB70
		public ITargetEntityInvisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EEA RID: 36586
		// (get) Token: 0x0601F41C RID: 128028 RVA: 0x0045C980 File Offset: 0x0045AB80
		public EVisibleCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisibleCondition.Weather;
				}
				return (EVisibleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EEB RID: 36587
		// (get) Token: 0x0601F41D RID: 128029 RVA: 0x0045C9BC File Offset: 0x0045ABBC
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EEC RID: 36588
		// (get) Token: 0x0601F41E RID: 128030 RVA: 0x0045C9F8 File Offset: 0x0045ABF8
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F41F RID: 128031 RVA: 0x0045CA34 File Offset: 0x0045AC34
		public static Offset<ITargetEntityInvisible> CreateITargetEntityInvisible(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, int EntityId = 0)
		{
			builder.StartTable(3);
			ITargetEntityInvisible.AddEntityId(builder, EntityId);
			ITargetEntityInvisible.AddCompare(builder, Compare);
			ITargetEntityInvisible.AddType(builder, Type);
			return ITargetEntityInvisible.EndITargetEntityInvisible(builder);
		}

		// Token: 0x0601F420 RID: 128032 RVA: 0x0045CA58 File Offset: 0x0045AC58
		public static void StartITargetEntityInvisible(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F421 RID: 128033 RVA: 0x0045CA61 File Offset: 0x0045AC61
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F422 RID: 128034 RVA: 0x0045CA6C File Offset: 0x0045AC6C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F423 RID: 128035 RVA: 0x0045CA77 File Offset: 0x0045AC77
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601F424 RID: 128036 RVA: 0x0045CA82 File Offset: 0x0045AC82
		public static Offset<ITargetEntityInvisible> EndITargetEntityInvisible(FlatBufferBuilder builder)
		{
			return new Offset<ITargetEntityInvisible>(builder.EndTable());
		}

		// Token: 0x0601F425 RID: 128037 RVA: 0x0045CA90 File Offset: 0x0045AC90
		public ITargetEntityInvisibleT UnPack()
		{
			ITargetEntityInvisibleT targetEntityInvisibleT = new ITargetEntityInvisibleT();
			this.UnPackTo(targetEntityInvisibleT);
			return targetEntityInvisibleT;
		}

		// Token: 0x0601F426 RID: 128038 RVA: 0x0045CAAB File Offset: 0x0045ACAB
		public void UnPackTo(ITargetEntityInvisibleT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601F427 RID: 128039 RVA: 0x0045CAD4 File Offset: 0x0045ACD4
		public static Offset<ITargetEntityInvisible> Pack(FlatBufferBuilder builder, ITargetEntityInvisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetEntityInvisible>);
			}
			return ITargetEntityInvisible.CreateITargetEntityInvisible(builder, _o.Type, _o.Compare, _o.EntityId);
		}

		// Token: 0x0400D6C3 RID: 54979
		private Table __p;
	}
}
