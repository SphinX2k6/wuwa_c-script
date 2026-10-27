using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B7B RID: 15227
	public struct IPlaceholderGroup : IFlatbufferObject
	{
		// Token: 0x17006868 RID: 26728
		// (get) Token: 0x06014DA3 RID: 85411 RVA: 0x0030709C File Offset: 0x0030529C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014DA4 RID: 85412 RVA: 0x003070A9 File Offset: 0x003052A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014DA5 RID: 85413 RVA: 0x003070B0 File Offset: 0x003052B0
		public static IPlaceholderGroup GetRootAsIPlaceholderGroup(ByteBuffer _bb)
		{
			return IPlaceholderGroup.GetRootAsIPlaceholderGroup(_bb, default(IPlaceholderGroup));
		}

		// Token: 0x06014DA6 RID: 85414 RVA: 0x003070CC File Offset: 0x003052CC
		public static IPlaceholderGroup GetRootAsIPlaceholderGroup(ByteBuffer _bb, IPlaceholderGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014DA7 RID: 85415 RVA: 0x003070E9 File Offset: 0x003052E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014DA8 RID: 85416 RVA: 0x003070F8 File Offset: 0x003052F8
		public IPlaceholderGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006869 RID: 26729
		// (get) Token: 0x06014DA9 RID: 85417 RVA: 0x00307108 File Offset: 0x00305308
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

		// Token: 0x06014DAA RID: 85418 RVA: 0x00307144 File Offset: 0x00305344
		public IPlaceholder? Placeholders(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPlaceholder?(default(IPlaceholder).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700686A RID: 26730
		// (get) Token: 0x06014DAB RID: 85419 RVA: 0x003071A4 File Offset: 0x003053A4
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

		// Token: 0x06014DAC RID: 85420 RVA: 0x003071CF File Offset: 0x003053CF
		public static Offset<IPlaceholderGroup> CreateIPlaceholderGroup(FlatBufferBuilder builder, int FragmentId = 0, VectorOffset PlaceholdersOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPlaceholderGroup.AddPlaceholders(builder, PlaceholdersOffset);
			IPlaceholderGroup.AddFragmentId(builder, FragmentId);
			return IPlaceholderGroup.EndIPlaceholderGroup(builder);
		}

		// Token: 0x06014DAD RID: 85421 RVA: 0x003071EC File Offset: 0x003053EC
		public static void StartIPlaceholderGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014DAE RID: 85422 RVA: 0x003071F5 File Offset: 0x003053F5
		public static void AddFragmentId(FlatBufferBuilder builder, int fragmentId)
		{
			builder.AddInt(0, fragmentId, 0);
		}

		// Token: 0x06014DAF RID: 85423 RVA: 0x00307200 File Offset: 0x00305400
		public static void AddPlaceholders(FlatBufferBuilder builder, VectorOffset placeholdersOffset)
		{
			builder.AddOffset(1, placeholdersOffset.Value, 0);
		}

		// Token: 0x06014DB0 RID: 85424 RVA: 0x00307210 File Offset: 0x00305410
		public static VectorOffset CreatePlaceholdersVector(FlatBufferBuilder builder, Offset<IPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06014DB1 RID: 85425 RVA: 0x00307250 File Offset: 0x00305450
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, Offset<IPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014DB2 RID: 85426 RVA: 0x0030726A File Offset: 0x0030546A
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPlaceholder>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014DB3 RID: 85427 RVA: 0x00307288 File Offset: 0x00305488
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPlaceholder>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014DB4 RID: 85428 RVA: 0x003072A1 File Offset: 0x003054A1
		public static void StartPlaceholdersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014DB5 RID: 85429 RVA: 0x003072AC File Offset: 0x003054AC
		public static Offset<IPlaceholderGroup> EndIPlaceholderGroup(FlatBufferBuilder builder)
		{
			return new Offset<IPlaceholderGroup>(builder.EndTable());
		}

		// Token: 0x06014DB6 RID: 85430 RVA: 0x003072BC File Offset: 0x003054BC
		public IPlaceholderGroupT UnPack()
		{
			IPlaceholderGroupT placeholderGroupT = new IPlaceholderGroupT();
			this.UnPackTo(placeholderGroupT);
			return placeholderGroupT;
		}

		// Token: 0x06014DB7 RID: 85431 RVA: 0x003072D8 File Offset: 0x003054D8
		public void UnPackTo(IPlaceholderGroupT _o)
		{
			_o.FragmentId = this.FragmentId;
			_o.Placeholders = new List<IPlaceholderT>();
			for (int i = 0; i < this.PlaceholdersLength; i++)
			{
				_o.Placeholders.Add((this.Placeholders(i) != null) ? this.Placeholders(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06014DB8 RID: 85432 RVA: 0x00307344 File Offset: 0x00305544
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

		// Token: 0x0400B0CA RID: 45258
		private Table __p;
	}
}
