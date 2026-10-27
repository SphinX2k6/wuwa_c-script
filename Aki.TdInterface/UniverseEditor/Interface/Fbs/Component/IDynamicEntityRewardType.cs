using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050DE RID: 20702
	public struct IDynamicEntityRewardType : IFlatbufferObject
	{
		// Token: 0x170096B9 RID: 38585
		// (get) Token: 0x06021535 RID: 136501 RVA: 0x004A0E53 File Offset: 0x0049F053
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021536 RID: 136502 RVA: 0x004A0E60 File Offset: 0x0049F060
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021537 RID: 136503 RVA: 0x004A0E68 File Offset: 0x0049F068
		public static IDynamicEntityRewardType GetRootAsIDynamicEntityRewardType(ByteBuffer _bb)
		{
			return IDynamicEntityRewardType.GetRootAsIDynamicEntityRewardType(_bb, default(IDynamicEntityRewardType));
		}

		// Token: 0x06021538 RID: 136504 RVA: 0x004A0E84 File Offset: 0x0049F084
		public static IDynamicEntityRewardType GetRootAsIDynamicEntityRewardType(ByteBuffer _bb, IDynamicEntityRewardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021539 RID: 136505 RVA: 0x004A0EA1 File Offset: 0x0049F0A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602153A RID: 136506 RVA: 0x004A0EB0 File Offset: 0x0049F0B0
		public IDynamicEntityRewardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096BA RID: 38586
		// (get) Token: 0x0602153B RID: 136507 RVA: 0x004A0EC0 File Offset: 0x0049F0C0
		public EDynamicEntityRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicEntityRewardType.Traffic;
				}
				return (EDynamicEntityRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602153C RID: 136508 RVA: 0x004A0EFC File Offset: 0x0049F0FC
		public static Offset<IDynamicEntityRewardType> CreateIDynamicEntityRewardType(FlatBufferBuilder builder, EDynamicEntityRewardType Type = EDynamicEntityRewardType.Traffic)
		{
			builder.StartTable(1);
			IDynamicEntityRewardType.AddType(builder, Type);
			return IDynamicEntityRewardType.EndIDynamicEntityRewardType(builder);
		}

		// Token: 0x0602153D RID: 136509 RVA: 0x004A0F12 File Offset: 0x0049F112
		public static void StartIDynamicEntityRewardType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602153E RID: 136510 RVA: 0x004A0F1B File Offset: 0x0049F11B
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602153F RID: 136511 RVA: 0x004A0F26 File Offset: 0x0049F126
		public static Offset<IDynamicEntityRewardType> EndIDynamicEntityRewardType(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicEntityRewardType>(builder.EndTable());
		}

		// Token: 0x06021540 RID: 136512 RVA: 0x004A0F34 File Offset: 0x0049F134
		public IDynamicEntityRewardTypeT UnPack()
		{
			IDynamicEntityRewardTypeT dynamicEntityRewardTypeT = new IDynamicEntityRewardTypeT();
			this.UnPackTo(dynamicEntityRewardTypeT);
			return dynamicEntityRewardTypeT;
		}

		// Token: 0x06021541 RID: 136513 RVA: 0x004A0F4F File Offset: 0x0049F14F
		public void UnPackTo(IDynamicEntityRewardTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021542 RID: 136514 RVA: 0x004A0F60 File Offset: 0x0049F160
		public static Offset<IDynamicEntityRewardType> Pack(FlatBufferBuilder builder, IDynamicEntityRewardTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicEntityRewardType>);
			}
			return IDynamicEntityRewardType.CreateIDynamicEntityRewardType(builder, _o.Type);
		}

		// Token: 0x0400E12E RID: 57646
		private Table __p;
	}
}
