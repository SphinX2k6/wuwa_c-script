using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D06 RID: 19718
	public struct ITriggeredEntity : IFlatbufferObject
	{
		// Token: 0x17008F0B RID: 36619
		// (get) Token: 0x0601F4C0 RID: 128192 RVA: 0x0045D9FE File Offset: 0x0045BBFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F4C1 RID: 128193 RVA: 0x0045DA0B File Offset: 0x0045BC0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F4C2 RID: 128194 RVA: 0x0045DA14 File Offset: 0x0045BC14
		public static ITriggeredEntity GetRootAsITriggeredEntity(ByteBuffer _bb)
		{
			return ITriggeredEntity.GetRootAsITriggeredEntity(_bb, default(ITriggeredEntity));
		}

		// Token: 0x0601F4C3 RID: 128195 RVA: 0x0045DA30 File Offset: 0x0045BC30
		public static ITriggeredEntity GetRootAsITriggeredEntity(ByteBuffer _bb, ITriggeredEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F4C4 RID: 128196 RVA: 0x0045DA4D File Offset: 0x0045BC4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F4C5 RID: 128197 RVA: 0x0045DA5C File Offset: 0x0045BC5C
		public ITriggeredEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F0C RID: 36620
		// (get) Token: 0x0601F4C6 RID: 128198 RVA: 0x0045DA6C File Offset: 0x0045BC6C
		public ETargetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetEntityType.Target;
				}
				return (ETargetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F4C7 RID: 128199 RVA: 0x0045DAA8 File Offset: 0x0045BCA8
		public static Offset<ITriggeredEntity> CreateITriggeredEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ITriggeredEntity.AddType(builder, Type);
			return ITriggeredEntity.EndITriggeredEntity(builder);
		}

		// Token: 0x0601F4C8 RID: 128200 RVA: 0x0045DABE File Offset: 0x0045BCBE
		public static void StartITriggeredEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F4C9 RID: 128201 RVA: 0x0045DAC7 File Offset: 0x0045BCC7
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F4CA RID: 128202 RVA: 0x0045DAD2 File Offset: 0x0045BCD2
		public static Offset<ITriggeredEntity> EndITriggeredEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITriggeredEntity>(builder.EndTable());
		}

		// Token: 0x0601F4CB RID: 128203 RVA: 0x0045DAE0 File Offset: 0x0045BCE0
		public ITriggeredEntityT UnPack()
		{
			ITriggeredEntityT triggeredEntityT = new ITriggeredEntityT();
			this.UnPackTo(triggeredEntityT);
			return triggeredEntityT;
		}

		// Token: 0x0601F4CC RID: 128204 RVA: 0x0045DAFB File Offset: 0x0045BCFB
		public void UnPackTo(ITriggeredEntityT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F4CD RID: 128205 RVA: 0x0045DB0C File Offset: 0x0045BD0C
		public static Offset<ITriggeredEntity> Pack(FlatBufferBuilder builder, ITriggeredEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggeredEntity>);
			}
			return ITriggeredEntity.CreateITriggeredEntity(builder, _o.Type);
		}

		// Token: 0x0400D6E4 RID: 55012
		private Table __p;
	}
}
