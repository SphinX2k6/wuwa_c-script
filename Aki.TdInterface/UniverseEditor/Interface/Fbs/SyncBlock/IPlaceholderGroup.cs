using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F83 RID: 16259
	public struct IPlaceholderGroup : IFlatbufferObject
	{
		// Token: 0x17006E07 RID: 28167
		// (get) Token: 0x0601626D RID: 90733 RVA: 0x0032D634 File Offset: 0x0032B834
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601626E RID: 90734 RVA: 0x0032D641 File Offset: 0x0032B841
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601626F RID: 90735 RVA: 0x0032D648 File Offset: 0x0032B848
		public static IPlaceholderGroup GetRootAsIPlaceholderGroup(ByteBuffer _bb)
		{
			return IPlaceholderGroup.GetRootAsIPlaceholderGroup(_bb, default(IPlaceholderGroup));
		}

		// Token: 0x06016270 RID: 90736 RVA: 0x0032D664 File Offset: 0x0032B864
		public static IPlaceholderGroup GetRootAsIPlaceholderGroup(ByteBuffer _bb, IPlaceholderGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016271 RID: 90737 RVA: 0x0032D681 File Offset: 0x0032B881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016272 RID: 90738 RVA: 0x0032D690 File Offset: 0x0032B890
		public IPlaceholderGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E08 RID: 28168
		// (get) Token: 0x06016273 RID: 90739 RVA: 0x0032D6A0 File Offset: 0x0032B8A0
		public int FragmentId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016274 RID: 90740 RVA: 0x0032D6DC File Offset: 0x0032B8DC
		public IPlaceholder? Placeholders(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPlaceholder?(default(IPlaceholder).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006E09 RID: 28169
		// (get) Token: 0x06016275 RID: 90741 RVA: 0x0032D73C File Offset: 0x0032B93C
		public int PlaceholdersLength
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

		// Token: 0x06016276 RID: 90742 RVA: 0x0032D767 File Offset: 0x0032B967
		public static Offset<IPlaceholderGroup> CreateIPlaceholderGroup(FlatBufferBuilder builder, int FragmentId = 0, VectorOffset PlaceholdersOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPlaceholderGroup.AddPlaceholders(builder, PlaceholdersOffset);
			IPlaceholderGroup.AddFragmentId(builder, FragmentId);
			return IPlaceholderGroup.EndIPlaceholderGroup(builder);
		}

		// Token: 0x06016277 RID: 90743 RVA: 0x0032D784 File Offset: 0x0032B984
		public static void StartIPlaceholderGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016278 RID: 90744 RVA: 0x0032D78D File Offset: 0x0032B98D
		public static void AddFragmentId(FlatBufferBuilder builder, int fragmentId)
		{
			builder.AddInt(0, fragmentId, 0);
		}

		// Token: 0x06016279 RID: 90745 RVA: 0x0032D798 File Offset: 0x0032B998
		public static void AddPlaceholders(FlatBufferBuilder builder, VectorOffset placeholdersOffset)
		{
			builder.AddOffset(1, placeholdersOffset.Value, 0);
		}

		// Token: 0x0601627A RID: 90746 RVA: 0x0032D7A8 File Offset: 0x0032B9A8
		public static VectorOffset CreatePlaceholdersVector(FlatBufferBuilder builder, Offset<IPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601627B RID: 90747 RVA: 0x0032D7E8 File Offset: 0x0032B9E8
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, Offset<IPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601627C RID: 90748 RVA: 0x0032D802 File Offset: 0x0032BA02
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPlaceholder>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601627D RID: 90749 RVA: 0x0032D820 File Offset: 0x0032BA20
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPlaceholder>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601627E RID: 90750 RVA: 0x0032D839 File Offset: 0x0032BA39
		public static void StartPlaceholdersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601627F RID: 90751 RVA: 0x0032D844 File Offset: 0x0032BA44
		public static Offset<IPlaceholderGroup> EndIPlaceholderGroup(FlatBufferBuilder builder)
		{
			return new Offset<IPlaceholderGroup>(builder.EndTable());
		}

		// Token: 0x06016280 RID: 90752 RVA: 0x0032D854 File Offset: 0x0032BA54
		public IPlaceholderGroupT UnPack()
		{
			IPlaceholderGroupT placeholderGroupT = new IPlaceholderGroupT();
			this.UnPackTo(placeholderGroupT);
			return placeholderGroupT;
		}

		// Token: 0x06016281 RID: 90753 RVA: 0x0032D870 File Offset: 0x0032BA70
		public void UnPackTo(IPlaceholderGroupT _o)
		{
			_o.FragmentId = this.FragmentId;
			_o.Placeholders = new List<IPlaceholderT>();
			for (int i = 0; i < this.PlaceholdersLength; i++)
			{
				_o.Placeholders.Add((this.Placeholders(i) != null) ? this.Placeholders(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06016282 RID: 90754 RVA: 0x0032D8DC File Offset: 0x0032BADC
		public static Offset<IPlaceholderGroup> Pack(FlatBufferBuilder builder, IPlaceholderGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlaceholderGroup>);
			}
			VectorOffset placeholdersOffset = default(VectorOffset);
			if (_o.Placeholders != null)
			{
				Offset<IPlaceholder>[] array = new Offset<IPlaceholder>[_o.Placeholders.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPlaceholder.Pack(builder, _o.Placeholders[i]);
				}
				placeholdersOffset = IPlaceholderGroup.CreatePlaceholdersVector(builder, array);
			}
			return IPlaceholderGroup.CreateIPlaceholderGroup(builder, _o.FragmentId, placeholdersOffset);
		}

		// Token: 0x0400BA47 RID: 47687
		private Table __p;
	}
}
