using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200407C RID: 16508
	public struct ITriggerTipShape : IFlatbufferObject
	{
		// Token: 0x17007065 RID: 28773
		// (get) Token: 0x06016BA3 RID: 93091 RVA: 0x0033F506 File Offset: 0x0033D706
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016BA4 RID: 93092 RVA: 0x0033F513 File Offset: 0x0033D713
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016BA5 RID: 93093 RVA: 0x0033F51C File Offset: 0x0033D71C
		public static ITriggerTipShape GetRootAsITriggerTipShape(ByteBuffer _bb)
		{
			return ITriggerTipShape.GetRootAsITriggerTipShape(_bb, default(ITriggerTipShape));
		}

		// Token: 0x06016BA6 RID: 93094 RVA: 0x0033F538 File Offset: 0x0033D738
		public static ITriggerTipShape GetRootAsITriggerTipShape(ByteBuffer _bb, ITriggerTipShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016BA7 RID: 93095 RVA: 0x0033F555 File Offset: 0x0033D755
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016BA8 RID: 93096 RVA: 0x0033F564 File Offset: 0x0033D764
		public ITriggerTipShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007066 RID: 28774
		// (get) Token: 0x06016BA9 RID: 93097 RVA: 0x0033F574 File Offset: 0x0033D774
		public ETriggerTipShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerTipShape.Box;
				}
				return (ETriggerTipShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016BAA RID: 93098 RVA: 0x0033F5B0 File Offset: 0x0033D7B0
		public static Offset<ITriggerTipShape> CreateITriggerTipShape(FlatBufferBuilder builder, ETriggerTipShape Type = ETriggerTipShape.Box)
		{
			builder.StartTable(1);
			ITriggerTipShape.AddType(builder, Type);
			return ITriggerTipShape.EndITriggerTipShape(builder);
		}

		// Token: 0x06016BAB RID: 93099 RVA: 0x0033F5C6 File Offset: 0x0033D7C6
		public static void StartITriggerTipShape(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016BAC RID: 93100 RVA: 0x0033F5CF File Offset: 0x0033D7CF
		public static void AddType(FlatBufferBuilder builder, ETriggerTipShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016BAD RID: 93101 RVA: 0x0033F5DA File Offset: 0x0033D7DA
		public static Offset<ITriggerTipShape> EndITriggerTipShape(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerTipShape>(builder.EndTable());
		}

		// Token: 0x06016BAE RID: 93102 RVA: 0x0033F5E8 File Offset: 0x0033D7E8
		public ITriggerTipShapeT UnPack()
		{
			ITriggerTipShapeT triggerTipShapeT = new ITriggerTipShapeT();
			this.UnPackTo(triggerTipShapeT);
			return triggerTipShapeT;
		}

		// Token: 0x06016BAF RID: 93103 RVA: 0x0033F603 File Offset: 0x0033D803
		public void UnPackTo(ITriggerTipShapeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016BB0 RID: 93104 RVA: 0x0033F614 File Offset: 0x0033D814
		public static Offset<ITriggerTipShape> Pack(FlatBufferBuilder builder, ITriggerTipShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerTipShape>);
			}
			return ITriggerTipShape.CreateITriggerTipShape(builder, _o.Type);
		}

		// Token: 0x0400BC30 RID: 48176
		private Table __p;
	}
}
