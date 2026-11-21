using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C9 RID: 21705
	public struct IChildEntityStateControl : IFlatbufferObject
	{
		// Token: 0x17009AF2 RID: 39666
		// (get) Token: 0x060223BD RID: 140221 RVA: 0x004B80AC File Offset: 0x004B62AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060223BE RID: 140222 RVA: 0x004B80B9 File Offset: 0x004B62B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060223BF RID: 140223 RVA: 0x004B80C0 File Offset: 0x004B62C0
		public static IChildEntityStateControl GetRootAsIChildEntityStateControl(ByteBuffer _bb)
		{
			return IChildEntityStateControl.GetRootAsIChildEntityStateControl(_bb, default(IChildEntityStateControl));
		}

		// Token: 0x060223C0 RID: 140224 RVA: 0x004B80DC File Offset: 0x004B62DC
		public static IChildEntityStateControl GetRootAsIChildEntityStateControl(ByteBuffer _bb, IChildEntityStateControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060223C1 RID: 140225 RVA: 0x004B80F9 File Offset: 0x004B62F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060223C2 RID: 140226 RVA: 0x004B8108 File Offset: 0x004B6308
		public IChildEntityStateControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AF3 RID: 39667
		// (get) Token: 0x060223C3 RID: 140227 RVA: 0x004B8118 File Offset: 0x004B6318
		public ETemplateEntityGroupType GroupType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETemplateEntityGroupType.None;
				}
				return (ETemplateEntityGroupType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009AF4 RID: 39668
		// (get) Token: 0x060223C4 RID: 140228 RVA: 0x004B8154 File Offset: 0x004B6354
		public string InitState
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

		// Token: 0x060223C5 RID: 140229 RVA: 0x004B818B File Offset: 0x004B638B
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060223C6 RID: 140230 RVA: 0x004B819A File Offset: 0x004B639A
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060223C7 RID: 140231 RVA: 0x004B81A8 File Offset: 0x004B63A8
		public IChildStateChangedConfig? OnChildStateChangedConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IChildStateChangedConfig?(default(IChildStateChangedConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AF5 RID: 39669
		// (get) Token: 0x060223C8 RID: 140232 RVA: 0x004B8208 File Offset: 0x004B6408
		public int OnChildStateChangedConfigsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009AF6 RID: 39670
		// (get) Token: 0x060223C9 RID: 140233 RVA: 0x004B8234 File Offset: 0x004B6434
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060223CA RID: 140234 RVA: 0x004B8271 File Offset: 0x004B6471
		public static Offset<IChildEntityStateControl> CreateIChildEntityStateControl(FlatBufferBuilder builder, ETemplateEntityGroupType GroupType = ETemplateEntityGroupType.None, StringOffset InitStateOffset = default(StringOffset), VectorOffset OnChildStateChangedConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IChildEntityStateControl.AddOnChildStateChangedConfigs(builder, OnChildStateChangedConfigsOffset);
			IChildEntityStateControl.AddInitState(builder, InitStateOffset);
			IChildEntityStateControl.AddNullMask(builder, NullMask);
			IChildEntityStateControl.AddGroupType(builder, GroupType);
			return IChildEntityStateControl.EndIChildEntityStateControl(builder);
		}

		// Token: 0x060223CB RID: 140235 RVA: 0x004B829D File Offset: 0x004B649D
		public static void StartIChildEntityStateControl(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060223CC RID: 140236 RVA: 0x004B82A6 File Offset: 0x004B64A6
		public static void AddGroupType(FlatBufferBuilder builder, ETemplateEntityGroupType groupType)
		{
			builder.AddByte(0, (byte)groupType, 0);
		}

		// Token: 0x060223CD RID: 140237 RVA: 0x004B82B1 File Offset: 0x004B64B1
		public static void AddInitState(FlatBufferBuilder builder, StringOffset initStateOffset)
		{
			builder.AddOffset(1, initStateOffset.Value, 0);
		}

		// Token: 0x060223CE RID: 140238 RVA: 0x004B82C1 File Offset: 0x004B64C1
		public static void AddOnChildStateChangedConfigs(FlatBufferBuilder builder, VectorOffset onChildStateChangedConfigsOffset)
		{
			builder.AddOffset(2, onChildStateChangedConfigsOffset.Value, 0);
		}

		// Token: 0x060223CF RID: 140239 RVA: 0x004B82D4 File Offset: 0x004B64D4
		public static VectorOffset CreateOnChildStateChangedConfigsVector(FlatBufferBuilder builder, Offset<IChildStateChangedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060223D0 RID: 140240 RVA: 0x004B8314 File Offset: 0x004B6514
		public static VectorOffset CreateOnChildStateChangedConfigsVectorBlock(FlatBufferBuilder builder, Offset<IChildStateChangedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IChildStateChangedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060223D1 RID: 140241 RVA: 0x004B832E File Offset: 0x004B652E
		public static VectorOffset CreateOnChildStateChangedConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IChildStateChangedConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IChildStateChangedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060223D2 RID: 140242 RVA: 0x004B834C File Offset: 0x004B654C
		public static VectorOffset CreateOnChildStateChangedConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IChildStateChangedConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060223D3 RID: 140243 RVA: 0x004B8365 File Offset: 0x004B6565
		public static void StartOnChildStateChangedConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060223D4 RID: 140244 RVA: 0x004B8370 File Offset: 0x004B6570
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060223D5 RID: 140245 RVA: 0x004B837B File Offset: 0x004B657B
		public static Offset<IChildEntityStateControl> EndIChildEntityStateControl(FlatBufferBuilder builder)
		{
			return new Offset<IChildEntityStateControl>(builder.EndTable());
		}

		// Token: 0x060223D6 RID: 140246 RVA: 0x004B8388 File Offset: 0x004B6588
		public IChildEntityStateControlT UnPack()
		{
			IChildEntityStateControlT childEntityStateControlT = new IChildEntityStateControlT();
			this.UnPackTo(childEntityStateControlT);
			return childEntityStateControlT;
		}

		// Token: 0x060223D7 RID: 140247 RVA: 0x004B83A4 File Offset: 0x004B65A4
		public void UnPackTo(IChildEntityStateControlT _o)
		{
			_o.GroupType = this.GroupType;
			_o.InitState = this.InitState;
			_o.OnChildStateChangedConfigs = new List<IChildStateChangedConfigT>();
			for (int i = 0; i < this.OnChildStateChangedConfigsLength; i++)
			{
				_o.OnChildStateChangedConfigs.Add((this.OnChildStateChangedConfigs(i) != null) ? this.OnChildStateChangedConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060223D8 RID: 140248 RVA: 0x004B8428 File Offset: 0x004B6628
		public static Offset<IChildEntityStateControl> Pack(FlatBufferBuilder builder, IChildEntityStateControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildEntityStateControl>);
			}
			StringOffset initStateOffset = (_o.InitState == null) ? default(StringOffset) : builder.CreateString(_o.InitState);
			VectorOffset onChildStateChangedConfigsOffset = default(VectorOffset);
			if (_o.OnChildStateChangedConfigs != null)
			{
				Offset<IChildStateChangedConfig>[] array = new Offset<IChildStateChangedConfig>[_o.OnChildStateChangedConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IChildStateChangedConfig.Pack(builder, _o.OnChildStateChangedConfigs[i]);
				}
				onChildStateChangedConfigsOffset = IChildEntityStateControl.CreateOnChildStateChangedConfigsVector(builder, array);
			}
			return IChildEntityStateControl.CreateIChildEntityStateControl(builder, _o.GroupType, initStateOffset, onChildStateChangedConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400EA0C RID: 59916
		private Table __p;
	}
}
