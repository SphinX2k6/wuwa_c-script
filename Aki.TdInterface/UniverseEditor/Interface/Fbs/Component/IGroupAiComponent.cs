using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B6 RID: 22710
	public struct IGroupAiComponent : IFlatbufferObject
	{
		// Token: 0x1700A4A7 RID: 42151
		// (get) Token: 0x06024DC2 RID: 150978 RVA: 0x0050FE57 File Offset: 0x0050E057
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024DC3 RID: 150979 RVA: 0x0050FE64 File Offset: 0x0050E064
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024DC4 RID: 150980 RVA: 0x0050FE6C File Offset: 0x0050E06C
		public static IGroupAiComponent GetRootAsIGroupAiComponent(ByteBuffer _bb)
		{
			return IGroupAiComponent.GetRootAsIGroupAiComponent(_bb, default(IGroupAiComponent));
		}

		// Token: 0x06024DC5 RID: 150981 RVA: 0x0050FE88 File Offset: 0x0050E088
		public static IGroupAiComponent GetRootAsIGroupAiComponent(ByteBuffer _bb, IGroupAiComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024DC6 RID: 150982 RVA: 0x0050FEA5 File Offset: 0x0050E0A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024DC7 RID: 150983 RVA: 0x0050FEB4 File Offset: 0x0050E0B4
		public IGroupAiComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4A8 RID: 42152
		// (get) Token: 0x06024DC8 RID: 150984 RVA: 0x0050FEC4 File Offset: 0x0050E0C4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06024DC9 RID: 150985 RVA: 0x0050FF04 File Offset: 0x0050E104
		public int Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A4A9 RID: 42153
		// (get) Token: 0x06024DCA RID: 150986 RVA: 0x0050FF44 File Offset: 0x0050E144
		public int EntitiesLength
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

		// Token: 0x06024DCB RID: 150987 RVA: 0x0050FF6F File Offset: 0x0050E16F
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06024DCC RID: 150988 RVA: 0x0050FF7E File Offset: 0x0050E17E
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700A4AA RID: 42154
		// (get) Token: 0x06024DCD RID: 150989 RVA: 0x0050FF8C File Offset: 0x0050E18C
		public TGroupAiOption OptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TGroupAiOption.NONE;
				}
				return (TGroupAiOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024DCE RID: 150990 RVA: 0x0050FFC8 File Offset: 0x0050E1C8
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024DCF RID: 150991 RVA: 0x00510010 File Offset: 0x0050E210
		public IGroupAiModeDefault OptionAsIGroupAiModeDefault()
		{
			return this.Option<IGroupAiModeDefault>().Value;
		}

		// Token: 0x06024DD0 RID: 150992 RVA: 0x0051002C File Offset: 0x0050E22C
		public IGroupAiMonsterEcology OptionAsIGroupAiMonsterEcology()
		{
			return this.Option<IGroupAiMonsterEcology>().Value;
		}

		// Token: 0x06024DD1 RID: 150993 RVA: 0x00510048 File Offset: 0x0050E248
		public IGroupAiPatrol OptionAsIGroupAiPatrol()
		{
			return this.Option<IGroupAiPatrol>().Value;
		}

		// Token: 0x06024DD2 RID: 150994 RVA: 0x00510064 File Offset: 0x0050E264
		public string SyncTags(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A4AB RID: 42155
		// (get) Token: 0x06024DD3 RID: 150995 RVA: 0x005100A0 File Offset: 0x0050E2A0
		public int SyncTagsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A4AC RID: 42156
		// (get) Token: 0x06024DD4 RID: 150996 RVA: 0x005100CC File Offset: 0x0050E2CC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024DD5 RID: 150997 RVA: 0x00510109 File Offset: 0x0050E309
		public static Offset<IGroupAiComponent> CreateIGroupAiComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset EntitiesOffset = default(VectorOffset), TGroupAiOption Option_type = TGroupAiOption.NONE, int OptionOffset = 0, VectorOffset SyncTagsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IGroupAiComponent.AddSyncTags(builder, SyncTagsOffset);
			IGroupAiComponent.AddOption(builder, OptionOffset);
			IGroupAiComponent.AddEntities(builder, EntitiesOffset);
			IGroupAiComponent.AddNullMask(builder, NullMask);
			IGroupAiComponent.AddOptionType(builder, Option_type);
			IGroupAiComponent.AddDisabled(builder, Disabled);
			return IGroupAiComponent.EndIGroupAiComponent(builder);
		}

		// Token: 0x06024DD6 RID: 150998 RVA: 0x00510145 File Offset: 0x0050E345
		public static void StartIGroupAiComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06024DD7 RID: 150999 RVA: 0x0051014E File Offset: 0x0050E34E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024DD8 RID: 151000 RVA: 0x00510159 File Offset: 0x0050E359
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x06024DD9 RID: 151001 RVA: 0x0051016C File Offset: 0x0050E36C
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024DDA RID: 151002 RVA: 0x005101A3 File Offset: 0x0050E3A3
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024DDB RID: 151003 RVA: 0x005101BD File Offset: 0x0050E3BD
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024DDC RID: 151004 RVA: 0x005101DB File Offset: 0x0050E3DB
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024DDD RID: 151005 RVA: 0x005101F4 File Offset: 0x0050E3F4
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024DDE RID: 151006 RVA: 0x005101FF File Offset: 0x0050E3FF
		public static void AddOptionType(FlatBufferBuilder builder, TGroupAiOption optionType)
		{
			builder.AddByte(2, (byte)optionType, 0);
		}

		// Token: 0x06024DDF RID: 151007 RVA: 0x0051020A File Offset: 0x0050E40A
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(3, optionOffset, 0);
		}

		// Token: 0x06024DE0 RID: 151008 RVA: 0x00510215 File Offset: 0x0050E415
		public static void AddSyncTags(FlatBufferBuilder builder, VectorOffset syncTagsOffset)
		{
			builder.AddOffset(4, syncTagsOffset.Value, 0);
		}

		// Token: 0x06024DE1 RID: 151009 RVA: 0x00510228 File Offset: 0x0050E428
		public static VectorOffset CreateSyncTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024DE2 RID: 151010 RVA: 0x00510268 File Offset: 0x0050E468
		public static VectorOffset CreateSyncTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06024DE3 RID: 151011 RVA: 0x00510282 File Offset: 0x0050E482
		public static VectorOffset CreateSyncTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06024DE4 RID: 151012 RVA: 0x005102A0 File Offset: 0x0050E4A0
		public static VectorOffset CreateSyncTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024DE5 RID: 151013 RVA: 0x005102B9 File Offset: 0x0050E4B9
		public static void StartSyncTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024DE6 RID: 151014 RVA: 0x005102C4 File Offset: 0x0050E4C4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06024DE7 RID: 151015 RVA: 0x005102CF File Offset: 0x0050E4CF
		public static Offset<IGroupAiComponent> EndIGroupAiComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiComponent>(builder.EndTable());
		}

		// Token: 0x06024DE8 RID: 151016 RVA: 0x005102DC File Offset: 0x0050E4DC
		public IGroupAiComponentT UnPack()
		{
			IGroupAiComponentT groupAiComponentT = new IGroupAiComponentT();
			this.UnPackTo(groupAiComponentT);
			return groupAiComponentT;
		}

		// Token: 0x06024DE9 RID: 151017 RVA: 0x005102F8 File Offset: 0x0050E4F8
		public void UnPackTo(IGroupAiComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Entities = new List<int>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add(this.Entities(i));
			}
			_o.Option = new TGroupAiOptionUnion();
			_o.Option.Type = this.OptionType;
			switch (this.OptionType)
			{
			case TGroupAiOption.IGroupAiModeDefault:
				_o.Option.Value = ((this.Option<IGroupAiModeDefault>() != null) ? this.Option<IGroupAiModeDefault>().Value.UnPack() : null);
				break;
			case TGroupAiOption.IGroupAiMonsterEcology:
				_o.Option.Value = ((this.Option<IGroupAiMonsterEcology>() != null) ? this.Option<IGroupAiMonsterEcology>().Value.UnPack() : null);
				break;
			case TGroupAiOption.IGroupAiPatrol:
				_o.Option.Value = ((this.Option<IGroupAiPatrol>() != null) ? this.Option<IGroupAiPatrol>().Value.UnPack() : null);
				break;
			}
			_o.SyncTags = new List<string>();
			for (int j = 0; j < this.SyncTagsLength; j++)
			{
				_o.SyncTags.Add(this.SyncTags(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024DEA RID: 151018 RVA: 0x00510460 File Offset: 0x0050E660
		public static Offset<IGroupAiComponent> Pack(FlatBufferBuilder builder, IGroupAiComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiComponent>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				int[] data = _o.Entities.ToArray();
				entitiesOffset = IGroupAiComponent.CreateEntitiesVector(builder, data);
			}
			TGroupAiOption option_type = (_o.Option == null) ? TGroupAiOption.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TGroupAiOptionUnion.Pack(builder, _o.Option);
			VectorOffset syncTagsOffset = default(VectorOffset);
			if (_o.SyncTags != null)
			{
				StringOffset[] array = new StringOffset[_o.SyncTags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.SyncTags[i]);
				}
				syncTagsOffset = IGroupAiComponent.CreateSyncTagsVector(builder, array);
			}
			return IGroupAiComponent.CreateIGroupAiComponent(builder, _o.Disabled, entitiesOffset, option_type, optionOffset, syncTagsOffset, _o.NullMask);
		}

		// Token: 0x0400F124 RID: 61732
		private Table __p;
	}
}
