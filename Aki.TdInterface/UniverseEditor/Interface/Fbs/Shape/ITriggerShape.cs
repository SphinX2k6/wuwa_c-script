using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004076 RID: 16502
	public struct ITriggerShape : IFlatbufferObject
	{
		// Token: 0x17007060 RID: 28768
		// (get) Token: 0x06016B71 RID: 93041 RVA: 0x0033EFF8 File Offset: 0x0033D1F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016B72 RID: 93042 RVA: 0x0033F005 File Offset: 0x0033D205
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016B73 RID: 93043 RVA: 0x0033F00C File Offset: 0x0033D20C
		public static ITriggerShape GetRootAsITriggerShape(ByteBuffer _bb)
		{
			return ITriggerShape.GetRootAsITriggerShape(_bb, default(ITriggerShape));
		}

		// Token: 0x06016B74 RID: 93044 RVA: 0x0033F028 File Offset: 0x0033D228
		public static ITriggerShape GetRootAsITriggerShape(ByteBuffer _bb, ITriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016B75 RID: 93045 RVA: 0x0033F045 File Offset: 0x0033D245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016B76 RID: 93046 RVA: 0x0033F054 File Offset: 0x0033D254
		public ITriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007061 RID: 28769
		// (get) Token: 0x06016B77 RID: 93047 RVA: 0x0033F064 File Offset: 0x0033D264
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016B78 RID: 93048 RVA: 0x0033F0A0 File Offset: 0x0033D2A0
		public static Offset<ITriggerShape> CreateITriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box)
		{
			builder.StartTable(1);
			ITriggerShape.AddType(builder, Type);
			return ITriggerShape.EndITriggerShape(builder);
		}

		// Token: 0x06016B79 RID: 93049 RVA: 0x0033F0B6 File Offset: 0x0033D2B6
		public static void StartITriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016B7A RID: 93050 RVA: 0x0033F0BF File Offset: 0x0033D2BF
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016B7B RID: 93051 RVA: 0x0033F0CA File Offset: 0x0033D2CA
		public static Offset<ITriggerShape> EndITriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerShape>(builder.EndTable());
		}

		// Token: 0x06016B7C RID: 93052 RVA: 0x0033F0D8 File Offset: 0x0033D2D8
		public ITriggerShapeT UnPack()
		{
			ITriggerShapeT triggerShapeT = new ITriggerShapeT();
			this.UnPackTo(triggerShapeT);
			return triggerShapeT;
		}

		// Token: 0x06016B7D RID: 93053 RVA: 0x0033F0F3 File Offset: 0x0033D2F3
		public void UnPackTo(ITriggerShapeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016B7E RID: 93054 RVA: 0x0033F104 File Offset: 0x0033D304
		public static Offset<ITriggerShape> Pack(FlatBufferBuilder builder, ITriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerShape>);
			}
			return ITriggerShape.CreateITriggerShape(builder, _o.Type);
		}

		// Token: 0x0400BC1E RID: 48158
		private Table __p;
	}
}
