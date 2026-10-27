using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006834 RID: 26676
	public struct IFlyingFeatherScanEffect : IFlatbufferObject
	{
		// Token: 0x1700C629 RID: 50729
		// (get) Token: 0x0602E81F RID: 190495 RVA: 0x00658AA8 File Offset: 0x00656CA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E820 RID: 190496 RVA: 0x00658AB5 File Offset: 0x00656CB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E821 RID: 190497 RVA: 0x00658ABC File Offset: 0x00656CBC
		public static IFlyingFeatherScanEffect GetRootAsIFlyingFeatherScanEffect(ByteBuffer _bb)
		{
			return IFlyingFeatherScanEffect.GetRootAsIFlyingFeatherScanEffect(_bb, default(IFlyingFeatherScanEffect));
		}

		// Token: 0x0602E822 RID: 190498 RVA: 0x00658AD8 File Offset: 0x00656CD8
		public static IFlyingFeatherScanEffect GetRootAsIFlyingFeatherScanEffect(ByteBuffer _bb, IFlyingFeatherScanEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E823 RID: 190499 RVA: 0x00658AF5 File Offset: 0x00656CF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E824 RID: 190500 RVA: 0x00658B04 File Offset: 0x00656D04
		public IFlyingFeatherScanEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C62A RID: 50730
		// (get) Token: 0x0602E825 RID: 190501 RVA: 0x00658B14 File Offset: 0x00656D14
		public ESpecificScanType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecificScanType.None;
				}
				return (ESpecificScanType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C62B RID: 50731
		// (get) Token: 0x0602E826 RID: 190502 RVA: 0x00658B50 File Offset: 0x00656D50
		public int TriggerPosEntityId
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

		// Token: 0x0602E827 RID: 190503 RVA: 0x00658B8C File Offset: 0x00656D8C
		public static Offset<IFlyingFeatherScanEffect> CreateIFlyingFeatherScanEffect(FlatBufferBuilder builder, ESpecificScanType Type = ESpecificScanType.None, int TriggerPosEntityId = 0)
		{
			builder.StartTable(2);
			IFlyingFeatherScanEffect.AddTriggerPosEntityId(builder, TriggerPosEntityId);
			IFlyingFeatherScanEffect.AddType(builder, Type);
			return IFlyingFeatherScanEffect.EndIFlyingFeatherScanEffect(builder);
		}

		// Token: 0x0602E828 RID: 190504 RVA: 0x00658BA9 File Offset: 0x00656DA9
		public static void StartIFlyingFeatherScanEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E829 RID: 190505 RVA: 0x00658BB2 File Offset: 0x00656DB2
		public static void AddType(FlatBufferBuilder builder, ESpecificScanType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E82A RID: 190506 RVA: 0x00658BBD File Offset: 0x00656DBD
		public static void AddTriggerPosEntityId(FlatBufferBuilder builder, int triggerPosEntityId)
		{
			builder.AddInt(1, triggerPosEntityId, 0);
		}

		// Token: 0x0602E82B RID: 190507 RVA: 0x00658BC8 File Offset: 0x00656DC8
		public static Offset<IFlyingFeatherScanEffect> EndIFlyingFeatherScanEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFlyingFeatherScanEffect>(builder.EndTable());
		}

		// Token: 0x0602E82C RID: 190508 RVA: 0x00658BD8 File Offset: 0x00656DD8
		public IFlyingFeatherScanEffectT UnPack()
		{
			IFlyingFeatherScanEffectT flyingFeatherScanEffectT = new IFlyingFeatherScanEffectT();
			this.UnPackTo(flyingFeatherScanEffectT);
			return flyingFeatherScanEffectT;
		}

		// Token: 0x0602E82D RID: 190509 RVA: 0x00658BF3 File Offset: 0x00656DF3
		public void UnPackTo(IFlyingFeatherScanEffectT _o)
		{
			_o.Type = this.Type;
			_o.TriggerPosEntityId = this.TriggerPosEntityId;
		}

		// Token: 0x0602E82E RID: 190510 RVA: 0x00658C10 File Offset: 0x00656E10
		public static Offset<IFlyingFeatherScanEffect> Pack(FlatBufferBuilder builder, IFlyingFeatherScanEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlyingFeatherScanEffect>);
			}
			return IFlyingFeatherScanEffect.CreateIFlyingFeatherScanEffect(builder, _o.Type, _o.TriggerPosEntityId);
		}

		// Token: 0x04010F7A RID: 69498
		private Table __p;
	}
}
