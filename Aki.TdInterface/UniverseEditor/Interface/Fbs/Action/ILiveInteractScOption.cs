using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710C RID: 28940
	public struct ILiveInteractScOption : IFlatbufferObject
	{
		// Token: 0x1700D3EC RID: 54252
		// (get) Token: 0x06032431 RID: 205873 RVA: 0x006CC026 File Offset: 0x006CA226
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032432 RID: 205874 RVA: 0x006CC033 File Offset: 0x006CA233
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032433 RID: 205875 RVA: 0x006CC03C File Offset: 0x006CA23C
		public static ILiveInteractScOption GetRootAsILiveInteractScOption(ByteBuffer _bb)
		{
			return ILiveInteractScOption.GetRootAsILiveInteractScOption(_bb, default(ILiveInteractScOption));
		}

		// Token: 0x06032434 RID: 205876 RVA: 0x006CC058 File Offset: 0x006CA258
		public static ILiveInteractScOption GetRootAsILiveInteractScOption(ByteBuffer _bb, ILiveInteractScOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032435 RID: 205877 RVA: 0x006CC075 File Offset: 0x006CA275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032436 RID: 205878 RVA: 0x006CC084 File Offset: 0x006CA284
		public ILiveInteractScOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3ED RID: 54253
		// (get) Token: 0x06032437 RID: 205879 RVA: 0x006CC094 File Offset: 0x006CA294
		public ESystemOptionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemOptionType.RogueRandomEvent;
				}
				return (ESystemOptionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032438 RID: 205880 RVA: 0x006CC0D0 File Offset: 0x006CA2D0
		public ISystemOption? SystemOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemOption?(default(ISystemOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D3EE RID: 54254
		// (get) Token: 0x06032439 RID: 205881 RVA: 0x006CC130 File Offset: 0x006CA330
		public int SystemOptionsLength
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

		// Token: 0x1700D3EF RID: 54255
		// (get) Token: 0x0603243A RID: 205882 RVA: 0x006CC15C File Offset: 0x006CA35C
		public bool KeepPreTalkItem
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0603243B RID: 205883 RVA: 0x006CC19C File Offset: 0x006CA39C
		public int ScIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D3F0 RID: 54256
		// (get) Token: 0x0603243C RID: 205884 RVA: 0x006CC1DC File Offset: 0x006CA3DC
		public int ScIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0603243D RID: 205885 RVA: 0x006CC208 File Offset: 0x006CA408
		public Span<int> GetScIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0603243E RID: 205886 RVA: 0x006CC218 File Offset: 0x006CA418
		public int[] GetScIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700D3F1 RID: 54257
		// (get) Token: 0x0603243F RID: 205887 RVA: 0x006CC228 File Offset: 0x006CA428
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

		// Token: 0x06032440 RID: 205888 RVA: 0x006CC265 File Offset: 0x006CA465
		public static Offset<ILiveInteractScOption> CreateILiveInteractScOption(FlatBufferBuilder builder, ESystemOptionType Type = ESystemOptionType.RogueRandomEvent, VectorOffset SystemOptionsOffset = default(VectorOffset), bool KeepPreTalkItem = false, VectorOffset ScIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ILiveInteractScOption.AddScIds(builder, ScIdsOffset);
			ILiveInteractScOption.AddSystemOptions(builder, SystemOptionsOffset);
			ILiveInteractScOption.AddNullMask(builder, NullMask);
			ILiveInteractScOption.AddKeepPreTalkItem(builder, KeepPreTalkItem);
			ILiveInteractScOption.AddType(builder, Type);
			return ILiveInteractScOption.EndILiveInteractScOption(builder);
		}

		// Token: 0x06032441 RID: 205889 RVA: 0x006CC299 File Offset: 0x006CA499
		public static void StartILiveInteractScOption(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06032442 RID: 205890 RVA: 0x006CC2A2 File Offset: 0x006CA4A2
		public static void AddType(FlatBufferBuilder builder, ESystemOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032443 RID: 205891 RVA: 0x006CC2AD File Offset: 0x006CA4AD
		public static void AddSystemOptions(FlatBufferBuilder builder, VectorOffset systemOptionsOffset)
		{
			builder.AddOffset(1, systemOptionsOffset.Value, 0);
		}

		// Token: 0x06032444 RID: 205892 RVA: 0x006CC2C0 File Offset: 0x006CA4C0
		public static VectorOffset CreateSystemOptionsVector(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032445 RID: 205893 RVA: 0x006CC300 File Offset: 0x006CA500
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032446 RID: 205894 RVA: 0x006CC31A File Offset: 0x006CA51A
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032447 RID: 205895 RVA: 0x006CC338 File Offset: 0x006CA538
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032448 RID: 205896 RVA: 0x006CC351 File Offset: 0x006CA551
		public static void StartSystemOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032449 RID: 205897 RVA: 0x006CC35C File Offset: 0x006CA55C
		public static void AddKeepPreTalkItem(FlatBufferBuilder builder, bool keepPreTalkItem)
		{
			builder.AddBool(2, keepPreTalkItem, false);
		}

		// Token: 0x0603244A RID: 205898 RVA: 0x006CC367 File Offset: 0x006CA567
		public static void AddScIds(FlatBufferBuilder builder, VectorOffset scIdsOffset)
		{
			builder.AddOffset(3, scIdsOffset.Value, 0);
		}

		// Token: 0x0603244B RID: 205899 RVA: 0x006CC378 File Offset: 0x006CA578
		public static VectorOffset CreateScIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603244C RID: 205900 RVA: 0x006CC3AF File Offset: 0x006CA5AF
		public static VectorOffset CreateScIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603244D RID: 205901 RVA: 0x006CC3C9 File Offset: 0x006CA5C9
		public static VectorOffset CreateScIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603244E RID: 205902 RVA: 0x006CC3E7 File Offset: 0x006CA5E7
		public static VectorOffset CreateScIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603244F RID: 205903 RVA: 0x006CC400 File Offset: 0x006CA600
		public static void StartScIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032450 RID: 205904 RVA: 0x006CC40B File Offset: 0x006CA60B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06032451 RID: 205905 RVA: 0x006CC416 File Offset: 0x006CA616
		public static Offset<ILiveInteractScOption> EndILiveInteractScOption(FlatBufferBuilder builder)
		{
			return new Offset<ILiveInteractScOption>(builder.EndTable());
		}

		// Token: 0x06032452 RID: 205906 RVA: 0x006CC424 File Offset: 0x006CA624
		public ILiveInteractScOptionT UnPack()
		{
			ILiveInteractScOptionT liveInteractScOptionT = new ILiveInteractScOptionT();
			this.UnPackTo(liveInteractScOptionT);
			return liveInteractScOptionT;
		}

		// Token: 0x06032453 RID: 205907 RVA: 0x006CC440 File Offset: 0x006CA640
		public void UnPackTo(ILiveInteractScOptionT _o)
		{
			_o.Type = this.Type;
			_o.SystemOptions = new List<ISystemOptionT>();
			for (int i = 0; i < this.SystemOptionsLength; i++)
			{
				_o.SystemOptions.Add((this.SystemOptions(i) != null) ? this.SystemOptions(i).Value.UnPack() : null);
			}
			_o.KeepPreTalkItem = this.KeepPreTalkItem;
			_o.ScIds = new List<int>();
			for (int j = 0; j < this.ScIdsLength; j++)
			{
				_o.ScIds.Add(this.ScIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032454 RID: 205908 RVA: 0x006CC4F4 File Offset: 0x006CA6F4
		public static Offset<ILiveInteractScOption> Pack(FlatBufferBuilder builder, ILiveInteractScOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveInteractScOption>);
			}
			VectorOffset systemOptionsOffset = default(VectorOffset);
			if (_o.SystemOptions != null)
			{
				Offset<ISystemOption>[] array = new Offset<ISystemOption>[_o.SystemOptions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISystemOption.Pack(builder, _o.SystemOptions[i]);
				}
				systemOptionsOffset = ILiveInteractScOption.CreateSystemOptionsVector(builder, array);
			}
			VectorOffset scIdsOffset = default(VectorOffset);
			if (_o.ScIds != null)
			{
				int[] data = _o.ScIds.ToArray();
				scIdsOffset = ILiveInteractScOption.CreateScIdsVector(builder, data);
			}
			return ILiveInteractScOption.CreateILiveInteractScOption(builder, _o.Type, systemOptionsOffset, _o.KeepPreTalkItem, scIdsOffset, _o.NullMask);
		}

		// Token: 0x040120E4 RID: 73956
		private Table __p;
	}
}
