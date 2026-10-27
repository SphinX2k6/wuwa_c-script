using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E00 RID: 15872
	public struct IEnterDungeonSubTypeCondition : IFlatbufferObject
	{
		// Token: 0x17006DB0 RID: 28080
		// (get) Token: 0x06016337 RID: 90935 RVA: 0x00334BFE File Offset: 0x00332DFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016338 RID: 90936 RVA: 0x00334C0B File Offset: 0x00332E0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016339 RID: 90937 RVA: 0x00334C14 File Offset: 0x00332E14
		public static IEnterDungeonSubTypeCondition GetRootAsIEnterDungeonSubTypeCondition(ByteBuffer _bb)
		{
			return IEnterDungeonSubTypeCondition.GetRootAsIEnterDungeonSubTypeCondition(_bb, default(IEnterDungeonSubTypeCondition));
		}

		// Token: 0x0601633A RID: 90938 RVA: 0x00334C30 File Offset: 0x00332E30
		public static IEnterDungeonSubTypeCondition GetRootAsIEnterDungeonSubTypeCondition(ByteBuffer _bb, IEnterDungeonSubTypeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601633B RID: 90939 RVA: 0x00334C4D File Offset: 0x00332E4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601633C RID: 90940 RVA: 0x00334C5C File Offset: 0x00332E5C
		public IEnterDungeonSubTypeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DB1 RID: 28081
		// (get) Token: 0x0601633D RID: 90941 RVA: 0x00334C6C File Offset: 0x00332E6C
		public EDungeonConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDungeonConditionType.DungeonSubType;
				}
				return (EDungeonConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006DB2 RID: 28082
		// (get) Token: 0x0601633E RID: 90942 RVA: 0x00334CA8 File Offset: 0x00332EA8
		public EDungeonSubType DungeonSubType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDungeonSubType.Test;
				}
				return (EDungeonSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601633F RID: 90943 RVA: 0x00334CE4 File Offset: 0x00332EE4
		public static Offset<IEnterDungeonSubTypeCondition> CreateIEnterDungeonSubTypeCondition(FlatBufferBuilder builder, EDungeonConditionType Type = EDungeonConditionType.DungeonSubType, EDungeonSubType DungeonSubType = EDungeonSubType.Test)
		{
			builder.StartTable(2);
			IEnterDungeonSubTypeCondition.AddDungeonSubType(builder, DungeonSubType);
			IEnterDungeonSubTypeCondition.AddType(builder, Type);
			return IEnterDungeonSubTypeCondition.EndIEnterDungeonSubTypeCondition(builder);
		}

		// Token: 0x06016340 RID: 90944 RVA: 0x00334D01 File Offset: 0x00332F01
		public static void StartIEnterDungeonSubTypeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016341 RID: 90945 RVA: 0x00334D0A File Offset: 0x00332F0A
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016342 RID: 90946 RVA: 0x00334D15 File Offset: 0x00332F15
		public static void AddDungeonSubType(FlatBufferBuilder builder, EDungeonSubType dungeonSubType)
		{
			builder.AddByte(1, (byte)dungeonSubType, 0);
		}

		// Token: 0x06016343 RID: 90947 RVA: 0x00334D20 File Offset: 0x00332F20
		public static Offset<IEnterDungeonSubTypeCondition> EndIEnterDungeonSubTypeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEnterDungeonSubTypeCondition>(builder.EndTable());
		}

		// Token: 0x06016344 RID: 90948 RVA: 0x00334D30 File Offset: 0x00332F30
		public IEnterDungeonSubTypeConditionT UnPack()
		{
			IEnterDungeonSubTypeConditionT enterDungeonSubTypeConditionT = new IEnterDungeonSubTypeConditionT();
			this.UnPackTo(enterDungeonSubTypeConditionT);
			return enterDungeonSubTypeConditionT;
		}

		// Token: 0x06016345 RID: 90949 RVA: 0x00334D4B File Offset: 0x00332F4B
		public void UnPackTo(IEnterDungeonSubTypeConditionT _o)
		{
			_o.Type = this.Type;
			_o.DungeonSubType = this.DungeonSubType;
		}

		// Token: 0x06016346 RID: 90950 RVA: 0x00334D68 File Offset: 0x00332F68
		public static Offset<IEnterDungeonSubTypeCondition> Pack(FlatBufferBuilder builder, IEnterDungeonSubTypeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterDungeonSubTypeCondition>);
			}
			return IEnterDungeonSubTypeCondition.CreateIEnterDungeonSubTypeCondition(builder, _o.Type, _o.DungeonSubType);
		}

		// Token: 0x0400B76B RID: 46955
		private Table __p;
	}
}
