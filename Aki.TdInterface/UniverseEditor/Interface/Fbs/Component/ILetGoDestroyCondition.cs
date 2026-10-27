using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054BB RID: 21691
	public struct ILetGoDestroyCondition : IFlatbufferObject
	{
		// Token: 0x17009FDB RID: 40923
		// (get) Token: 0x06023BE6 RID: 146406 RVA: 0x004F149C File Offset: 0x004EF69C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023BE7 RID: 146407 RVA: 0x004F14A9 File Offset: 0x004EF6A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023BE8 RID: 146408 RVA: 0x004F14B0 File Offset: 0x004EF6B0
		public static ILetGoDestroyCondition GetRootAsILetGoDestroyCondition(ByteBuffer _bb)
		{
			return ILetGoDestroyCondition.GetRootAsILetGoDestroyCondition(_bb, default(ILetGoDestroyCondition));
		}

		// Token: 0x06023BE9 RID: 146409 RVA: 0x004F14CC File Offset: 0x004EF6CC
		public static ILetGoDestroyCondition GetRootAsILetGoDestroyCondition(ByteBuffer _bb, ILetGoDestroyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023BEA RID: 146410 RVA: 0x004F14E9 File Offset: 0x004EF6E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023BEB RID: 146411 RVA: 0x004F14F8 File Offset: 0x004EF6F8
		public ILetGoDestroyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FDC RID: 40924
		// (get) Token: 0x06023BEC RID: 146412 RVA: 0x004F1508 File Offset: 0x004EF708
		public ETeleControlDestroyCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleControlDestroyCondition.LetGo;
				}
				return (ETeleControlDestroyCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023BED RID: 146413 RVA: 0x004F1544 File Offset: 0x004EF744
		public static Offset<ILetGoDestroyCondition> CreateILetGoDestroyCondition(FlatBufferBuilder builder, ETeleControlDestroyCondition Type = ETeleControlDestroyCondition.LetGo)
		{
			builder.StartTable(1);
			ILetGoDestroyCondition.AddType(builder, Type);
			return ILetGoDestroyCondition.EndILetGoDestroyCondition(builder);
		}

		// Token: 0x06023BEE RID: 146414 RVA: 0x004F155A File Offset: 0x004EF75A
		public static void StartILetGoDestroyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023BEF RID: 146415 RVA: 0x004F1563 File Offset: 0x004EF763
		public static void AddType(FlatBufferBuilder builder, ETeleControlDestroyCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023BF0 RID: 146416 RVA: 0x004F156E File Offset: 0x004EF76E
		public static Offset<ILetGoDestroyCondition> EndILetGoDestroyCondition(FlatBufferBuilder builder)
		{
			return new Offset<ILetGoDestroyCondition>(builder.EndTable());
		}

		// Token: 0x06023BF1 RID: 146417 RVA: 0x004F157C File Offset: 0x004EF77C
		public ILetGoDestroyConditionT UnPack()
		{
			ILetGoDestroyConditionT letGoDestroyConditionT = new ILetGoDestroyConditionT();
			this.UnPackTo(letGoDestroyConditionT);
			return letGoDestroyConditionT;
		}

		// Token: 0x06023BF2 RID: 146418 RVA: 0x004F1597 File Offset: 0x004EF797
		public void UnPackTo(ILetGoDestroyConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023BF3 RID: 146419 RVA: 0x004F15A8 File Offset: 0x004EF7A8
		public static Offset<ILetGoDestroyCondition> Pack(FlatBufferBuilder builder, ILetGoDestroyConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILetGoDestroyCondition>);
			}
			return ILetGoDestroyCondition.CreateILetGoDestroyCondition(builder, _o.Type);
		}

		// Token: 0x0400E773 RID: 59251
		private Table __p;
	}
}
