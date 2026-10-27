using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007286 RID: 29318
	public struct ISystemOptionType : IFlatbufferObject
	{
		// Token: 0x1700D980 RID: 55680
		// (get) Token: 0x06034045 RID: 213061 RVA: 0x006FE887 File Offset: 0x006FCA87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034046 RID: 213062 RVA: 0x006FE894 File Offset: 0x006FCA94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034047 RID: 213063 RVA: 0x006FE89C File Offset: 0x006FCA9C
		public static ISystemOptionType GetRootAsISystemOptionType(ByteBuffer _bb)
		{
			return ISystemOptionType.GetRootAsISystemOptionType(_bb, default(ISystemOptionType));
		}

		// Token: 0x06034048 RID: 213064 RVA: 0x006FE8B8 File Offset: 0x006FCAB8
		public static ISystemOptionType GetRootAsISystemOptionType(ByteBuffer _bb, ISystemOptionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034049 RID: 213065 RVA: 0x006FE8D5 File Offset: 0x006FCAD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603404A RID: 213066 RVA: 0x006FE8E4 File Offset: 0x006FCAE4
		public ISystemOptionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D981 RID: 55681
		// (get) Token: 0x0603404B RID: 213067 RVA: 0x006FE8F4 File Offset: 0x006FCAF4
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

		// Token: 0x0603404C RID: 213068 RVA: 0x006FE930 File Offset: 0x006FCB30
		public ISystemOption? SystemOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemOption?(default(ISystemOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D982 RID: 55682
		// (get) Token: 0x0603404D RID: 213069 RVA: 0x006FE990 File Offset: 0x006FCB90
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

		// Token: 0x1700D983 RID: 55683
		// (get) Token: 0x0603404E RID: 213070 RVA: 0x006FE9BC File Offset: 0x006FCBBC
		public bool KeepPreTalkItem
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D984 RID: 55684
		// (get) Token: 0x0603404F RID: 213071 RVA: 0x006FE9FC File Offset: 0x006FCBFC
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

		// Token: 0x06034050 RID: 213072 RVA: 0x006FEA39 File Offset: 0x006FCC39
		public static Offset<ISystemOptionType> CreateISystemOptionType(FlatBufferBuilder builder, ESystemOptionType Type = ESystemOptionType.RogueRandomEvent, VectorOffset SystemOptionsOffset = default(VectorOffset), bool KeepPreTalkItem = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISystemOptionType.AddSystemOptions(builder, SystemOptionsOffset);
			ISystemOptionType.AddNullMask(builder, NullMask);
			ISystemOptionType.AddKeepPreTalkItem(builder, KeepPreTalkItem);
			ISystemOptionType.AddType(builder, Type);
			return ISystemOptionType.EndISystemOptionType(builder);
		}

		// Token: 0x06034051 RID: 213073 RVA: 0x006FEA65 File Offset: 0x006FCC65
		public static void StartISystemOptionType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06034052 RID: 213074 RVA: 0x006FEA6E File Offset: 0x006FCC6E
		public static void AddType(FlatBufferBuilder builder, ESystemOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034053 RID: 213075 RVA: 0x006FEA79 File Offset: 0x006FCC79
		public static void AddSystemOptions(FlatBufferBuilder builder, VectorOffset systemOptionsOffset)
		{
			builder.AddOffset(1, systemOptionsOffset.Value, 0);
		}

		// Token: 0x06034054 RID: 213076 RVA: 0x006FEA8C File Offset: 0x006FCC8C
		public static VectorOffset CreateSystemOptionsVector(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034055 RID: 213077 RVA: 0x006FEACC File Offset: 0x006FCCCC
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034056 RID: 213078 RVA: 0x006FEAE6 File Offset: 0x006FCCE6
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034057 RID: 213079 RVA: 0x006FEB04 File Offset: 0x006FCD04
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034058 RID: 213080 RVA: 0x006FEB1D File Offset: 0x006FCD1D
		public static void StartSystemOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034059 RID: 213081 RVA: 0x006FEB28 File Offset: 0x006FCD28
		public static void AddKeepPreTalkItem(FlatBufferBuilder builder, bool keepPreTalkItem)
		{
			builder.AddBool(2, keepPreTalkItem, false);
		}

		// Token: 0x0603405A RID: 213082 RVA: 0x006FEB33 File Offset: 0x006FCD33
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603405B RID: 213083 RVA: 0x006FEB3E File Offset: 0x006FCD3E
		public static Offset<ISystemOptionType> EndISystemOptionType(FlatBufferBuilder builder)
		{
			return new Offset<ISystemOptionType>(builder.EndTable());
		}

		// Token: 0x0603405C RID: 213084 RVA: 0x006FEB4C File Offset: 0x006FCD4C
		public ISystemOptionTypeT UnPack()
		{
			ISystemOptionTypeT systemOptionTypeT = new ISystemOptionTypeT();
			this.UnPackTo(systemOptionTypeT);
			return systemOptionTypeT;
		}

		// Token: 0x0603405D RID: 213085 RVA: 0x006FEB68 File Offset: 0x006FCD68
		public void UnPackTo(ISystemOptionTypeT _o)
		{
			_o.Type = this.Type;
			_o.SystemOptions = new List<ISystemOptionT>();
			for (int i = 0; i < this.SystemOptionsLength; i++)
			{
				_o.SystemOptions.Add((this.SystemOptions(i) != null) ? this.SystemOptions(i).Value.UnPack() : null);
			}
			_o.KeepPreTalkItem = this.KeepPreTalkItem;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603405E RID: 213086 RVA: 0x006FEBEC File Offset: 0x006FCDEC
		public static Offset<ISystemOptionType> Pack(FlatBufferBuilder builder, ISystemOptionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemOptionType>);
			}
			VectorOffset systemOptionsOffset = default(VectorOffset);
			if (_o.SystemOptions != null)
			{
				Offset<ISystemOption>[] array = new Offset<ISystemOption>[_o.SystemOptions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISystemOption.Pack(builder, _o.SystemOptions[i]);
				}
				systemOptionsOffset = ISystemOptionType.CreateSystemOptionsVector(builder, array);
			}
			return ISystemOptionType.CreateISystemOptionType(builder, _o.Type, systemOptionsOffset, _o.KeepPreTalkItem, _o.NullMask);
		}

		// Token: 0x04011D8F RID: 73103
		private Table __p;
	}
}
