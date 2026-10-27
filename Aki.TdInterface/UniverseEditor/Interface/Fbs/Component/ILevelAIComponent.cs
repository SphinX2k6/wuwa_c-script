using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C7 RID: 21703
	public struct ILevelAIComponent : IFlatbufferObject
	{
		// Token: 0x17009FEA RID: 40938
		// (get) Token: 0x06023C32 RID: 146482 RVA: 0x004F1B64 File Offset: 0x004EFD64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023C33 RID: 146483 RVA: 0x004F1B71 File Offset: 0x004EFD71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023C34 RID: 146484 RVA: 0x004F1B78 File Offset: 0x004EFD78
		public static ILevelAIComponent GetRootAsILevelAIComponent(ByteBuffer _bb)
		{
			return ILevelAIComponent.GetRootAsILevelAIComponent(_bb, default(ILevelAIComponent));
		}

		// Token: 0x06023C35 RID: 146485 RVA: 0x004F1B94 File Offset: 0x004EFD94
		public static ILevelAIComponent GetRootAsILevelAIComponent(ByteBuffer _bb, ILevelAIComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023C36 RID: 146486 RVA: 0x004F1BB1 File Offset: 0x004EFDB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023C37 RID: 146487 RVA: 0x004F1BC0 File Offset: 0x004EFDC0
		public ILevelAIComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FEB RID: 40939
		// (get) Token: 0x06023C38 RID: 146488 RVA: 0x004F1BD0 File Offset: 0x004EFDD0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023C39 RID: 146489 RVA: 0x004F1C10 File Offset: 0x004EFE10
		public ILevelAIState? States(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILevelAIState?(default(ILevelAIState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009FEC RID: 40940
		// (get) Token: 0x06023C3A RID: 146490 RVA: 0x004F1C70 File Offset: 0x004EFE70
		public int StatesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009FED RID: 40941
		// (get) Token: 0x06023C3B RID: 146491 RVA: 0x004F1C9C File Offset: 0x004EFE9C
		public string BtTreeAsset
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

		// Token: 0x06023C3C RID: 146492 RVA: 0x004F1CD3 File Offset: 0x004EFED3
		public Span<byte> GetBtTreeAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06023C3D RID: 146493 RVA: 0x004F1CE2 File Offset: 0x004EFEE2
		public byte[] GetBtTreeAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009FEE RID: 40942
		// (get) Token: 0x06023C3E RID: 146494 RVA: 0x004F1CF0 File Offset: 0x004EFEF0
		public ICommonBtOverride? CommonBtOverride
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ICommonBtOverride?(default(ICommonBtOverride).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009FEF RID: 40943
		// (get) Token: 0x06023C3F RID: 146495 RVA: 0x004F1D50 File Offset: 0x004EFF50
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023C40 RID: 146496 RVA: 0x004F1D8D File Offset: 0x004EFF8D
		public static Offset<ILevelAIComponent> CreateILevelAIComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset StatesOffset = default(VectorOffset), StringOffset BtTreeAssetOffset = default(StringOffset), Offset<ICommonBtOverride> CommonBtOverrideOffset = default(Offset<ICommonBtOverride>), byte NullMask = 0)
		{
			builder.StartTable(5);
			ILevelAIComponent.AddCommonBtOverride(builder, CommonBtOverrideOffset);
			ILevelAIComponent.AddBtTreeAsset(builder, BtTreeAssetOffset);
			ILevelAIComponent.AddStates(builder, StatesOffset);
			ILevelAIComponent.AddNullMask(builder, NullMask);
			ILevelAIComponent.AddDisabled(builder, Disabled);
			return ILevelAIComponent.EndILevelAIComponent(builder);
		}

		// Token: 0x06023C41 RID: 146497 RVA: 0x004F1DC1 File Offset: 0x004EFFC1
		public static void StartILevelAIComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023C42 RID: 146498 RVA: 0x004F1DCA File Offset: 0x004EFFCA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023C43 RID: 146499 RVA: 0x004F1DD5 File Offset: 0x004EFFD5
		public static void AddStates(FlatBufferBuilder builder, VectorOffset statesOffset)
		{
			builder.AddOffset(1, statesOffset.Value, 0);
		}

		// Token: 0x06023C44 RID: 146500 RVA: 0x004F1DE8 File Offset: 0x004EFFE8
		public static VectorOffset CreateStatesVector(FlatBufferBuilder builder, Offset<ILevelAIState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023C45 RID: 146501 RVA: 0x004F1E28 File Offset: 0x004F0028
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, Offset<ILevelAIState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelAIState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023C46 RID: 146502 RVA: 0x004F1E42 File Offset: 0x004F0042
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelAIState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelAIState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023C47 RID: 146503 RVA: 0x004F1E60 File Offset: 0x004F0060
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelAIState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023C48 RID: 146504 RVA: 0x004F1E79 File Offset: 0x004F0079
		public static void StartStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023C49 RID: 146505 RVA: 0x004F1E84 File Offset: 0x004F0084
		public static void AddBtTreeAsset(FlatBufferBuilder builder, StringOffset btTreeAssetOffset)
		{
			builder.AddOffset(2, btTreeAssetOffset.Value, 0);
		}

		// Token: 0x06023C4A RID: 146506 RVA: 0x004F1E94 File Offset: 0x004F0094
		public static void AddCommonBtOverride(FlatBufferBuilder builder, Offset<ICommonBtOverride> commonBtOverrideOffset)
		{
			builder.AddOffset(3, commonBtOverrideOffset.Value, 0);
		}

		// Token: 0x06023C4B RID: 146507 RVA: 0x004F1EA4 File Offset: 0x004F00A4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06023C4C RID: 146508 RVA: 0x004F1EAF File Offset: 0x004F00AF
		public static Offset<ILevelAIComponent> EndILevelAIComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAIComponent>(builder.EndTable());
		}

		// Token: 0x06023C4D RID: 146509 RVA: 0x004F1EBC File Offset: 0x004F00BC
		public ILevelAIComponentT UnPack()
		{
			ILevelAIComponentT levelAIComponentT = new ILevelAIComponentT();
			this.UnPackTo(levelAIComponentT);
			return levelAIComponentT;
		}

		// Token: 0x06023C4E RID: 146510 RVA: 0x004F1ED8 File Offset: 0x004F00D8
		public void UnPackTo(ILevelAIComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.States = new List<ILevelAIStateT>();
			for (int i = 0; i < this.StatesLength; i++)
			{
				_o.States.Add((this.States(i) != null) ? this.States(i).Value.UnPack() : null);
			}
			_o.BtTreeAsset = this.BtTreeAsset;
			_o.CommonBtOverride = ((this.CommonBtOverride != null) ? this.CommonBtOverride.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023C4F RID: 146511 RVA: 0x004F1F8C File Offset: 0x004F018C
		public static Offset<ILevelAIComponent> Pack(FlatBufferBuilder builder, ILevelAIComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAIComponent>);
			}
			VectorOffset statesOffset = default(VectorOffset);
			if (_o.States != null)
			{
				Offset<ILevelAIState>[] array = new Offset<ILevelAIState>[_o.States.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILevelAIState.Pack(builder, _o.States[i]);
				}
				statesOffset = ILevelAIComponent.CreateStatesVector(builder, array);
			}
			StringOffset btTreeAssetOffset = (_o.BtTreeAsset == null) ? default(StringOffset) : builder.CreateString(_o.BtTreeAsset);
			Offset<ICommonBtOverride> commonBtOverrideOffset = (_o.CommonBtOverride == null) ? default(Offset<ICommonBtOverride>) : ICommonBtOverride.Pack(builder, _o.CommonBtOverride);
			return ILevelAIComponent.CreateILevelAIComponent(builder, _o.Disabled, statesOffset, btTreeAssetOffset, commonBtOverrideOffset, _o.NullMask);
		}

		// Token: 0x0400E782 RID: 59266
		private Table __p;
	}
}
