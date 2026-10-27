using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FB3 RID: 16307
	public struct IPreShowInfo : IFlatbufferObject
	{
		// Token: 0x170071E2 RID: 29154
		// (get) Token: 0x06017500 RID: 95488 RVA: 0x0035C5A8 File Offset: 0x0035A7A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017501 RID: 95489 RVA: 0x0035C5B5 File Offset: 0x0035A7B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017502 RID: 95490 RVA: 0x0035C5BC File Offset: 0x0035A7BC
		public static IPreShowInfo GetRootAsIPreShowInfo(ByteBuffer _bb)
		{
			return IPreShowInfo.GetRootAsIPreShowInfo(_bb, default(IPreShowInfo));
		}

		// Token: 0x06017503 RID: 95491 RVA: 0x0035C5D8 File Offset: 0x0035A7D8
		public static IPreShowInfo GetRootAsIPreShowInfo(ByteBuffer _bb, IPreShowInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017504 RID: 95492 RVA: 0x0035C5F5 File Offset: 0x0035A7F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017505 RID: 95493 RVA: 0x0035C604 File Offset: 0x0035A804
		public IPreShowInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071E3 RID: 29155
		// (get) Token: 0x06017506 RID: 95494 RVA: 0x0035C614 File Offset: 0x0035A814
		public IAccessQuestCondition? PreShowCondition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IAccessQuestCondition?(default(IAccessQuestCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170071E4 RID: 29156
		// (get) Token: 0x06017507 RID: 95495 RVA: 0x0035C674 File Offset: 0x0035A874
		public string TidPreShowDesc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017508 RID: 95496 RVA: 0x0035C6AB File Offset: 0x0035A8AB
		public Span<byte> GetTidPreShowDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06017509 RID: 95497 RVA: 0x0035C6BA File Offset: 0x0035A8BA
		public byte[] GetTidPreShowDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601750A RID: 95498 RVA: 0x0035C6C8 File Offset: 0x0035A8C8
		public static Offset<IPreShowInfo> CreateIPreShowInfo(FlatBufferBuilder builder, Offset<IAccessQuestCondition> PreShowConditionOffset = default(Offset<IAccessQuestCondition>), StringOffset TidPreShowDescOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPreShowInfo.AddTidPreShowDesc(builder, TidPreShowDescOffset);
			IPreShowInfo.AddPreShowCondition(builder, PreShowConditionOffset);
			return IPreShowInfo.EndIPreShowInfo(builder);
		}

		// Token: 0x0601750B RID: 95499 RVA: 0x0035C6E5 File Offset: 0x0035A8E5
		public static void StartIPreShowInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601750C RID: 95500 RVA: 0x0035C6EE File Offset: 0x0035A8EE
		public static void AddPreShowCondition(FlatBufferBuilder builder, Offset<IAccessQuestCondition> preShowConditionOffset)
		{
			builder.AddOffset(0, preShowConditionOffset.Value, 0);
		}

		// Token: 0x0601750D RID: 95501 RVA: 0x0035C6FE File Offset: 0x0035A8FE
		public static void AddTidPreShowDesc(FlatBufferBuilder builder, StringOffset tidPreShowDescOffset)
		{
			builder.AddOffset(1, tidPreShowDescOffset.Value, 0);
		}

		// Token: 0x0601750E RID: 95502 RVA: 0x0035C70E File Offset: 0x0035A90E
		public static Offset<IPreShowInfo> EndIPreShowInfo(FlatBufferBuilder builder)
		{
			return new Offset<IPreShowInfo>(builder.EndTable());
		}

		// Token: 0x0601750F RID: 95503 RVA: 0x0035C71C File Offset: 0x0035A91C
		public IPreShowInfoT UnPack()
		{
			IPreShowInfoT preShowInfoT = new IPreShowInfoT();
			this.UnPackTo(preShowInfoT);
			return preShowInfoT;
		}

		// Token: 0x06017510 RID: 95504 RVA: 0x0035C738 File Offset: 0x0035A938
		public void UnPackTo(IPreShowInfoT _o)
		{
			_o.PreShowCondition = ((this.PreShowCondition != null) ? this.PreShowCondition.Value.UnPack() : null);
			_o.TidPreShowDesc = this.TidPreShowDesc;
		}

		// Token: 0x06017511 RID: 95505 RVA: 0x0035C780 File Offset: 0x0035A980
		public static Offset<IPreShowInfo> Pack(FlatBufferBuilder builder, IPreShowInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreShowInfo>);
			}
			Offset<IAccessQuestCondition> preShowConditionOffset = (_o.PreShowCondition == null) ? default(Offset<IAccessQuestCondition>) : IAccessQuestCondition.Pack(builder, _o.PreShowCondition);
			StringOffset tidPreShowDescOffset = (_o.TidPreShowDesc == null) ? default(StringOffset) : builder.CreateString(_o.TidPreShowDesc);
			return IPreShowInfo.CreateIPreShowInfo(builder, preShowConditionOffset, tidPreShowDescOffset);
		}

		// Token: 0x0400BA1F RID: 47647
		private Table __p;
	}
}
