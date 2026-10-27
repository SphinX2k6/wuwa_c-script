using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C67 RID: 15463
	public struct ITriggerShape : IFlatbufferObject
	{
		// Token: 0x17006AAF RID: 27311
		// (get) Token: 0x0601565D RID: 87645 RVA: 0x00318158 File Offset: 0x00316358
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601565E RID: 87646 RVA: 0x00318165 File Offset: 0x00316365
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601565F RID: 87647 RVA: 0x0031816C File Offset: 0x0031636C
		public static ITriggerShape GetRootAsITriggerShape(ByteBuffer _bb)
		{
			return ITriggerShape.GetRootAsITriggerShape(_bb, default(ITriggerShape));
		}

		// Token: 0x06015660 RID: 87648 RVA: 0x00318188 File Offset: 0x00316388
		public static ITriggerShape GetRootAsITriggerShape(ByteBuffer _bb, ITriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015661 RID: 87649 RVA: 0x003181A5 File Offset: 0x003163A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015662 RID: 87650 RVA: 0x003181B4 File Offset: 0x003163B4
		public ITriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006AB0 RID: 27312
		// (get) Token: 0x06015663 RID: 87651 RVA: 0x003181C4 File Offset: 0x003163C4
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

		// Token: 0x06015664 RID: 87652 RVA: 0x00318200 File Offset: 0x00316400
		public static Offset<ITriggerShape> CreateITriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box)
		{
			builder.StartTable(1);
			ITriggerShape.AddType(builder, Type);
			return ITriggerShape.EndITriggerShape(builder);
		}

		// Token: 0x06015665 RID: 87653 RVA: 0x00318216 File Offset: 0x00316416
		public static void StartITriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015666 RID: 87654 RVA: 0x0031821F File Offset: 0x0031641F
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015667 RID: 87655 RVA: 0x0031822A File Offset: 0x0031642A
		public static Offset<ITriggerShape> EndITriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerShape>(builder.EndTable());
		}

		// Token: 0x06015668 RID: 87656 RVA: 0x00318238 File Offset: 0x00316438
		public ITriggerShapeT UnPack()
		{
			ITriggerShapeT triggerShapeT = new ITriggerShapeT();
			this.UnPackTo(triggerShapeT);
			return triggerShapeT;
		}

		// Token: 0x06015669 RID: 87657 RVA: 0x00318253 File Offset: 0x00316453
		public void UnPackTo(ITriggerShapeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601566A RID: 87658 RVA: 0x00318264 File Offset: 0x00316464
		public static Offset<ITriggerShape> Pack(FlatBufferBuilder builder, ITriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerShape>);
			}
			return ITriggerShape.CreateITriggerShape(builder, _o.Type);
		}

		// Token: 0x0400B28E RID: 45710
		private Table __p;
	}
}
