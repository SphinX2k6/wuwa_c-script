using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A5B RID: 31323
	public struct ISystemOptionType : IFlatbufferObject
	{
		// Token: 0x1700E579 RID: 58745
		// (get) Token: 0x06037347 RID: 226119 RVA: 0x0075FBE7 File Offset: 0x0075DDE7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037348 RID: 226120 RVA: 0x0075FBF4 File Offset: 0x0075DDF4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037349 RID: 226121 RVA: 0x0075FBFC File Offset: 0x0075DDFC
		public static ISystemOptionType GetRootAsISystemOptionType(ByteBuffer _bb)
		{
			return ISystemOptionType.GetRootAsISystemOptionType(_bb, default(ISystemOptionType));
		}

		// Token: 0x0603734A RID: 226122 RVA: 0x0075FC18 File Offset: 0x0075DE18
		public static ISystemOptionType GetRootAsISystemOptionType(ByteBuffer _bb, ISystemOptionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603734B RID: 226123 RVA: 0x0075FC35 File Offset: 0x0075DE35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603734C RID: 226124 RVA: 0x0075FC44 File Offset: 0x0075DE44
		public ISystemOptionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E57A RID: 58746
		// (get) Token: 0x0603734D RID: 226125 RVA: 0x0075FC54 File Offset: 0x0075DE54
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

		// Token: 0x0603734E RID: 226126 RVA: 0x0075FC90 File Offset: 0x0075DE90
		public ISystemOption? SystemOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemOption?(default(ISystemOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E57B RID: 58747
		// (get) Token: 0x0603734F RID: 226127 RVA: 0x0075FCF0 File Offset: 0x0075DEF0
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

		// Token: 0x1700E57C RID: 58748
		// (get) Token: 0x06037350 RID: 226128 RVA: 0x0075FD1C File Offset: 0x0075DF1C
		public bool KeepPreTalkItem
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E57D RID: 58749
		// (get) Token: 0x06037351 RID: 226129 RVA: 0x0075FD5C File Offset: 0x0075DF5C
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

		// Token: 0x06037352 RID: 226130 RVA: 0x0075FD99 File Offset: 0x0075DF99
		public static Offset<ISystemOptionType> CreateISystemOptionType(FlatBufferBuilder builder, ESystemOptionType Type = ESystemOptionType.RogueRandomEvent, VectorOffset SystemOptionsOffset = default(VectorOffset), bool KeepPreTalkItem = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISystemOptionType.AddSystemOptions(builder, SystemOptionsOffset);
			ISystemOptionType.AddNullMask(builder, NullMask);
			ISystemOptionType.AddKeepPreTalkItem(builder, KeepPreTalkItem);
			ISystemOptionType.AddType(builder, Type);
			return ISystemOptionType.EndISystemOptionType(builder);
		}

		// Token: 0x06037353 RID: 226131 RVA: 0x0075FDC5 File Offset: 0x0075DFC5
		public static void StartISystemOptionType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06037354 RID: 226132 RVA: 0x0075FDCE File Offset: 0x0075DFCE
		public static void AddType(FlatBufferBuilder builder, ESystemOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037355 RID: 226133 RVA: 0x0075FDD9 File Offset: 0x0075DFD9
		public static void AddSystemOptions(FlatBufferBuilder builder, VectorOffset systemOptionsOffset)
		{
			builder.AddOffset(1, systemOptionsOffset.Value, 0);
		}

		// Token: 0x06037356 RID: 226134 RVA: 0x0075FDEC File Offset: 0x0075DFEC
		public static VectorOffset CreateSystemOptionsVector(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06037357 RID: 226135 RVA: 0x0075FE2C File Offset: 0x0075E02C
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06037358 RID: 226136 RVA: 0x0075FE46 File Offset: 0x0075E046
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06037359 RID: 226137 RVA: 0x0075FE64 File Offset: 0x0075E064
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603735A RID: 226138 RVA: 0x0075FE7D File Offset: 0x0075E07D
		public static void StartSystemOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603735B RID: 226139 RVA: 0x0075FE88 File Offset: 0x0075E088
		public static void AddKeepPreTalkItem(FlatBufferBuilder builder, bool keepPreTalkItem)
		{
			builder.AddBool(2, keepPreTalkItem, false);
		}

		// Token: 0x0603735C RID: 226140 RVA: 0x0075FE93 File Offset: 0x0075E093
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603735D RID: 226141 RVA: 0x0075FE9E File Offset: 0x0075E09E
		public static Offset<ISystemOptionType> EndISystemOptionType(FlatBufferBuilder builder)
		{
			return new Offset<ISystemOptionType>(builder.EndTable());
		}

		// Token: 0x0603735E RID: 226142 RVA: 0x0075FEAC File Offset: 0x0075E0AC
		public ISystemOptionTypeT UnPack()
		{
			ISystemOptionTypeT systemOptionTypeT = new ISystemOptionTypeT();
			this.UnPackTo(systemOptionTypeT);
			return systemOptionTypeT;
		}

		// Token: 0x0603735F RID: 226143 RVA: 0x0075FEC8 File Offset: 0x0075E0C8
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

		// Token: 0x06037360 RID: 226144 RVA: 0x0075FF4C File Offset: 0x0075E14C
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

		// Token: 0x04012D91 RID: 77201
		private Table __p;
	}
}
