using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E8 RID: 22760
	public struct IHeadInfoChangeData : IFlatbufferObject
	{
		// Token: 0x1700A510 RID: 42256
		// (get) Token: 0x06024F78 RID: 151416 RVA: 0x005131D0 File Offset: 0x005113D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024F79 RID: 151417 RVA: 0x005131DD File Offset: 0x005113DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024F7A RID: 151418 RVA: 0x005131E4 File Offset: 0x005113E4
		public static IHeadInfoChangeData GetRootAsIHeadInfoChangeData(ByteBuffer _bb)
		{
			return IHeadInfoChangeData.GetRootAsIHeadInfoChangeData(_bb, default(IHeadInfoChangeData));
		}

		// Token: 0x06024F7B RID: 151419 RVA: 0x00513200 File Offset: 0x00511400
		public static IHeadInfoChangeData GetRootAsIHeadInfoChangeData(ByteBuffer _bb, IHeadInfoChangeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024F7C RID: 151420 RVA: 0x0051321D File Offset: 0x0051141D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024F7D RID: 151421 RVA: 0x0051322C File Offset: 0x0051142C
		public IHeadInfoChangeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A511 RID: 42257
		// (get) Token: 0x06024F7E RID: 151422 RVA: 0x0051323C File Offset: 0x0051143C
		public IConditionGroup? Conditions
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A512 RID: 42258
		// (get) Token: 0x06024F7F RID: 151423 RVA: 0x0051329C File Offset: 0x0051149C
		public string TidName
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

		// Token: 0x06024F80 RID: 151424 RVA: 0x005132D3 File Offset: 0x005114D3
		public Span<byte> GetTidNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024F81 RID: 151425 RVA: 0x005132E2 File Offset: 0x005114E2
		public byte[] GetTidNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A513 RID: 42259
		// (get) Token: 0x06024F82 RID: 151426 RVA: 0x005132F0 File Offset: 0x005114F0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024F83 RID: 151427 RVA: 0x00513327 File Offset: 0x00511527
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024F84 RID: 151428 RVA: 0x00513336 File Offset: 0x00511536
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A514 RID: 42260
		// (get) Token: 0x06024F85 RID: 151429 RVA: 0x00513344 File Offset: 0x00511544
		public string TidSecondaryName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024F86 RID: 151430 RVA: 0x0051337C File Offset: 0x0051157C
		public Span<byte> GetTidSecondaryNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024F87 RID: 151431 RVA: 0x0051338C File Offset: 0x0051158C
		public byte[] GetTidSecondaryNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06024F88 RID: 151432 RVA: 0x0051339B File Offset: 0x0051159B
		public static Offset<IHeadInfoChangeData> CreateIHeadInfoChangeData(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), StringOffset TidNameOffset = default(StringOffset), StringOffset IconOffset = default(StringOffset), StringOffset TidSecondaryNameOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IHeadInfoChangeData.AddTidSecondaryName(builder, TidSecondaryNameOffset);
			IHeadInfoChangeData.AddIcon(builder, IconOffset);
			IHeadInfoChangeData.AddTidName(builder, TidNameOffset);
			IHeadInfoChangeData.AddConditions(builder, ConditionsOffset);
			return IHeadInfoChangeData.EndIHeadInfoChangeData(builder);
		}

		// Token: 0x06024F89 RID: 151433 RVA: 0x005133C7 File Offset: 0x005115C7
		public static void StartIHeadInfoChangeData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024F8A RID: 151434 RVA: 0x005133D0 File Offset: 0x005115D0
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(0, conditionsOffset.Value, 0);
		}

		// Token: 0x06024F8B RID: 151435 RVA: 0x005133E0 File Offset: 0x005115E0
		public static void AddTidName(FlatBufferBuilder builder, StringOffset tidNameOffset)
		{
			builder.AddOffset(1, tidNameOffset.Value, 0);
		}

		// Token: 0x06024F8C RID: 151436 RVA: 0x005133F0 File Offset: 0x005115F0
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(2, iconOffset.Value, 0);
		}

		// Token: 0x06024F8D RID: 151437 RVA: 0x00513400 File Offset: 0x00511600
		public static void AddTidSecondaryName(FlatBufferBuilder builder, StringOffset tidSecondaryNameOffset)
		{
			builder.AddOffset(3, tidSecondaryNameOffset.Value, 0);
		}

		// Token: 0x06024F8E RID: 151438 RVA: 0x00513410 File Offset: 0x00511610
		public static Offset<IHeadInfoChangeData> EndIHeadInfoChangeData(FlatBufferBuilder builder)
		{
			return new Offset<IHeadInfoChangeData>(builder.EndTable());
		}

		// Token: 0x06024F8F RID: 151439 RVA: 0x00513420 File Offset: 0x00511620
		public IHeadInfoChangeDataT UnPack()
		{
			IHeadInfoChangeDataT headInfoChangeDataT = new IHeadInfoChangeDataT();
			this.UnPackTo(headInfoChangeDataT);
			return headInfoChangeDataT;
		}

		// Token: 0x06024F90 RID: 151440 RVA: 0x0051343C File Offset: 0x0051163C
		public void UnPackTo(IHeadInfoChangeDataT _o)
		{
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.TidName = this.TidName;
			_o.Icon = this.Icon;
			_o.TidSecondaryName = this.TidSecondaryName;
		}

		// Token: 0x06024F91 RID: 151441 RVA: 0x0051349C File Offset: 0x0051169C
		public static Offset<IHeadInfoChangeData> Pack(FlatBufferBuilder builder, IHeadInfoChangeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadInfoChangeData>);
			}
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			StringOffset tidNameOffset = (_o.TidName == null) ? default(StringOffset) : builder.CreateString(_o.TidName);
			StringOffset iconOffset = (_o.Icon == null) ? default(StringOffset) : builder.CreateString(_o.Icon);
			StringOffset tidSecondaryNameOffset = (_o.TidSecondaryName == null) ? default(StringOffset) : builder.CreateString(_o.TidSecondaryName);
			return IHeadInfoChangeData.CreateIHeadInfoChangeData(builder, conditionsOffset, tidNameOffset, iconOffset, tidSecondaryNameOffset);
		}

		// Token: 0x0400F16D RID: 61805
		private Table __p;
	}
}
