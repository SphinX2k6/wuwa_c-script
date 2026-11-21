using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051EA RID: 20970
	public struct ITargetEntityInvisible : IFlatbufferObject
	{
		// Token: 0x17009622 RID: 38434
		// (get) Token: 0x0602105B RID: 135259 RVA: 0x00490862 File Offset: 0x0048EA62
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602105C RID: 135260 RVA: 0x0049086F File Offset: 0x0048EA6F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602105D RID: 135261 RVA: 0x00490878 File Offset: 0x0048EA78
		public static ITargetEntityInvisible GetRootAsITargetEntityInvisible(ByteBuffer _bb)
		{
			return ITargetEntityInvisible.GetRootAsITargetEntityInvisible(_bb, default(ITargetEntityInvisible));
		}

		// Token: 0x0602105E RID: 135262 RVA: 0x00490894 File Offset: 0x0048EA94
		public static ITargetEntityInvisible GetRootAsITargetEntityInvisible(ByteBuffer _bb, ITargetEntityInvisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602105F RID: 135263 RVA: 0x004908B1 File Offset: 0x0048EAB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021060 RID: 135264 RVA: 0x004908C0 File Offset: 0x0048EAC0
		public ITargetEntityInvisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009623 RID: 38435
		// (get) Token: 0x06021061 RID: 135265 RVA: 0x004908D0 File Offset: 0x0048EAD0
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

		// Token: 0x17009624 RID: 38436
		// (get) Token: 0x06021062 RID: 135266 RVA: 0x0049090C File Offset: 0x0048EB0C
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

		// Token: 0x17009625 RID: 38437
		// (get) Token: 0x06021063 RID: 135267 RVA: 0x00490948 File Offset: 0x0048EB48
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

		// Token: 0x06021064 RID: 135268 RVA: 0x00490984 File Offset: 0x0048EB84
		public static Offset<ITargetEntityInvisible> CreateITargetEntityInvisible(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, int EntityId = 0)
		{
			builder.StartTable(3);
			ITargetEntityInvisible.AddEntityId(builder, EntityId);
			ITargetEntityInvisible.AddCompare(builder, Compare);
			ITargetEntityInvisible.AddType(builder, Type);
			return ITargetEntityInvisible.EndITargetEntityInvisible(builder);
		}

		// Token: 0x06021065 RID: 135269 RVA: 0x004909A8 File Offset: 0x0048EBA8
		public static void StartITargetEntityInvisible(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021066 RID: 135270 RVA: 0x004909B1 File Offset: 0x0048EBB1
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021067 RID: 135271 RVA: 0x004909BC File Offset: 0x0048EBBC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06021068 RID: 135272 RVA: 0x004909C7 File Offset: 0x0048EBC7
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06021069 RID: 135273 RVA: 0x004909D2 File Offset: 0x0048EBD2
		public static Offset<ITargetEntityInvisible> EndITargetEntityInvisible(FlatBufferBuilder builder)
		{
			return new Offset<ITargetEntityInvisible>(builder.EndTable());
		}

		// Token: 0x0602106A RID: 135274 RVA: 0x004909E0 File Offset: 0x0048EBE0
		public ITargetEntityInvisibleT UnPack()
		{
			ITargetEntityInvisibleT targetEntityInvisibleT = new ITargetEntityInvisibleT();
			this.UnPackTo(targetEntityInvisibleT);
			return targetEntityInvisibleT;
		}

		// Token: 0x0602106B RID: 135275 RVA: 0x004909FB File Offset: 0x0048EBFB
		public void UnPackTo(ITargetEntityInvisibleT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602106C RID: 135276 RVA: 0x00490A24 File Offset: 0x0048EC24
		public static Offset<ITargetEntityInvisible> Pack(FlatBufferBuilder builder, ITargetEntityInvisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetEntityInvisible>);
			}
			return ITargetEntityInvisible.CreateITargetEntityInvisible(builder, _o.Type, _o.Compare, _o.EntityId);
		}

		// Token: 0x0400E1F0 RID: 57840
		private Table __p;
	}
}
