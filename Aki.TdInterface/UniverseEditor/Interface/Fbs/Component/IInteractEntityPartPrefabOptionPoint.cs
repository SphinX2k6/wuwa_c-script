using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005452 RID: 21586
	public struct IInteractEntityPartPrefabOptionPoint : IFlatbufferObject
	{
		// Token: 0x17009EEC RID: 40684
		// (get) Token: 0x0602380F RID: 145423 RVA: 0x004E99C0 File Offset: 0x004E7BC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023810 RID: 145424 RVA: 0x004E99CD File Offset: 0x004E7BCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023811 RID: 145425 RVA: 0x004E99D4 File Offset: 0x004E7BD4
		public static IInteractEntityPartPrefabOptionPoint GetRootAsIInteractEntityPartPrefabOptionPoint(ByteBuffer _bb)
		{
			return IInteractEntityPartPrefabOptionPoint.GetRootAsIInteractEntityPartPrefabOptionPoint(_bb, default(IInteractEntityPartPrefabOptionPoint));
		}

		// Token: 0x06023812 RID: 145426 RVA: 0x004E99F0 File Offset: 0x004E7BF0
		public static IInteractEntityPartPrefabOptionPoint GetRootAsIInteractEntityPartPrefabOptionPoint(ByteBuffer _bb, IInteractEntityPartPrefabOptionPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023813 RID: 145427 RVA: 0x004E9A0D File Offset: 0x004E7C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023814 RID: 145428 RVA: 0x004E9A1C File Offset: 0x004E7C1C
		public IInteractEntityPartPrefabOptionPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EED RID: 40685
		// (get) Token: 0x06023815 RID: 145429 RVA: 0x004E9A2C File Offset: 0x004E7C2C
		public string UiStyle
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023816 RID: 145430 RVA: 0x004E9A63 File Offset: 0x004E7C63
		public Span<byte> GetUiStyleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023817 RID: 145431 RVA: 0x004E9A72 File Offset: 0x004E7C72
		public byte[] GetUiStyleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009EEE RID: 40686
		// (get) Token: 0x06023818 RID: 145432 RVA: 0x004E9A80 File Offset: 0x004E7C80
		public string BindName
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

		// Token: 0x06023819 RID: 145433 RVA: 0x004E9AB7 File Offset: 0x004E7CB7
		public Span<byte> GetBindNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602381A RID: 145434 RVA: 0x004E9AC6 File Offset: 0x004E7CC6
		public byte[] GetBindNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602381B RID: 145435 RVA: 0x004E9AD4 File Offset: 0x004E7CD4
		public static Offset<IInteractEntityPartPrefabOptionPoint> CreateIInteractEntityPartPrefabOptionPoint(FlatBufferBuilder builder, StringOffset UiStyleOffset = default(StringOffset), StringOffset BindNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInteractEntityPartPrefabOptionPoint.AddBindName(builder, BindNameOffset);
			IInteractEntityPartPrefabOptionPoint.AddUiStyle(builder, UiStyleOffset);
			return IInteractEntityPartPrefabOptionPoint.EndIInteractEntityPartPrefabOptionPoint(builder);
		}

		// Token: 0x0602381C RID: 145436 RVA: 0x004E9AF1 File Offset: 0x004E7CF1
		public static void StartIInteractEntityPartPrefabOptionPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602381D RID: 145437 RVA: 0x004E9AFA File Offset: 0x004E7CFA
		public static void AddUiStyle(FlatBufferBuilder builder, StringOffset uiStyleOffset)
		{
			builder.AddOffset(0, uiStyleOffset.Value, 0);
		}

		// Token: 0x0602381E RID: 145438 RVA: 0x004E9B0A File Offset: 0x004E7D0A
		public static void AddBindName(FlatBufferBuilder builder, StringOffset bindNameOffset)
		{
			builder.AddOffset(1, bindNameOffset.Value, 0);
		}

		// Token: 0x0602381F RID: 145439 RVA: 0x004E9B1A File Offset: 0x004E7D1A
		public static Offset<IInteractEntityPartPrefabOptionPoint> EndIInteractEntityPartPrefabOptionPoint(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEntityPartPrefabOptionPoint>(builder.EndTable());
		}

		// Token: 0x06023820 RID: 145440 RVA: 0x004E9B28 File Offset: 0x004E7D28
		public IInteractEntityPartPrefabOptionPointT UnPack()
		{
			IInteractEntityPartPrefabOptionPointT interactEntityPartPrefabOptionPointT = new IInteractEntityPartPrefabOptionPointT();
			this.UnPackTo(interactEntityPartPrefabOptionPointT);
			return interactEntityPartPrefabOptionPointT;
		}

		// Token: 0x06023821 RID: 145441 RVA: 0x004E9B43 File Offset: 0x004E7D43
		public void UnPackTo(IInteractEntityPartPrefabOptionPointT _o)
		{
			_o.UiStyle = this.UiStyle;
			_o.BindName = this.BindName;
		}

		// Token: 0x06023822 RID: 145442 RVA: 0x004E9B60 File Offset: 0x004E7D60
		public static Offset<IInteractEntityPartPrefabOptionPoint> Pack(FlatBufferBuilder builder, IInteractEntityPartPrefabOptionPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractEntityPartPrefabOptionPoint>);
			}
			StringOffset uiStyleOffset = (_o.UiStyle == null) ? default(StringOffset) : builder.CreateString(_o.UiStyle);
			StringOffset bindNameOffset = (_o.BindName == null) ? default(StringOffset) : builder.CreateString(_o.BindName);
			return IInteractEntityPartPrefabOptionPoint.CreateIInteractEntityPartPrefabOptionPoint(builder, uiStyleOffset, bindNameOffset);
		}

		// Token: 0x0400E6C7 RID: 59079
		private Table __p;
	}
}
