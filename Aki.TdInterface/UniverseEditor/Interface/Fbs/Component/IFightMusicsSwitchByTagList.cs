using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005243 RID: 21059
	public struct IFightMusicsSwitchByTagList : IFlatbufferObject
	{
		// Token: 0x17009A4D RID: 39501
		// (get) Token: 0x06022415 RID: 140309 RVA: 0x004C04EC File Offset: 0x004BE6EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022416 RID: 140310 RVA: 0x004C04F9 File Offset: 0x004BE6F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022417 RID: 140311 RVA: 0x004C0500 File Offset: 0x004BE700
		public static IFightMusicsSwitchByTagList GetRootAsIFightMusicsSwitchByTagList(ByteBuffer _bb)
		{
			return IFightMusicsSwitchByTagList.GetRootAsIFightMusicsSwitchByTagList(_bb, default(IFightMusicsSwitchByTagList));
		}

		// Token: 0x06022418 RID: 140312 RVA: 0x004C051C File Offset: 0x004BE71C
		public static IFightMusicsSwitchByTagList GetRootAsIFightMusicsSwitchByTagList(ByteBuffer _bb, IFightMusicsSwitchByTagList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022419 RID: 140313 RVA: 0x004C0539 File Offset: 0x004BE739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602241A RID: 140314 RVA: 0x004C0548 File Offset: 0x004BE748
		public IFightMusicsSwitchByTagList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A4E RID: 39502
		// (get) Token: 0x0602241B RID: 140315 RVA: 0x004C0558 File Offset: 0x004BE758
		public EFightMusicsSwitchType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFightMusicsSwitchType.SwitchByTag;
				}
				return (EFightMusicsSwitchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602241C RID: 140316 RVA: 0x004C0594 File Offset: 0x004BE794
		public IFightMusicSwitchByTag? Element(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFightMusicSwitchByTag?(default(IFightMusicSwitchByTag).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009A4F RID: 39503
		// (get) Token: 0x0602241D RID: 140317 RVA: 0x004C05F4 File Offset: 0x004BE7F4
		public int ElementLength
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

		// Token: 0x0602241E RID: 140318 RVA: 0x004C061F File Offset: 0x004BE81F
		public static Offset<IFightMusicsSwitchByTagList> CreateIFightMusicsSwitchByTagList(FlatBufferBuilder builder, EFightMusicsSwitchType Type = EFightMusicsSwitchType.SwitchByTag, VectorOffset ElementOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFightMusicsSwitchByTagList.AddElement(builder, ElementOffset);
			IFightMusicsSwitchByTagList.AddType(builder, Type);
			return IFightMusicsSwitchByTagList.EndIFightMusicsSwitchByTagList(builder);
		}

		// Token: 0x0602241F RID: 140319 RVA: 0x004C063C File Offset: 0x004BE83C
		public static void StartIFightMusicsSwitchByTagList(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022420 RID: 140320 RVA: 0x004C0645 File Offset: 0x004BE845
		public static void AddType(FlatBufferBuilder builder, EFightMusicsSwitchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022421 RID: 140321 RVA: 0x004C0650 File Offset: 0x004BE850
		public static void AddElement(FlatBufferBuilder builder, VectorOffset elementOffset)
		{
			builder.AddOffset(1, elementOffset.Value, 0);
		}

		// Token: 0x06022422 RID: 140322 RVA: 0x004C0660 File Offset: 0x004BE860
		public static VectorOffset CreateElementVector(FlatBufferBuilder builder, Offset<IFightMusicSwitchByTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022423 RID: 140323 RVA: 0x004C06A0 File Offset: 0x004BE8A0
		public static VectorOffset CreateElementVectorBlock(FlatBufferBuilder builder, Offset<IFightMusicSwitchByTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFightMusicSwitchByTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022424 RID: 140324 RVA: 0x004C06BA File Offset: 0x004BE8BA
		public static VectorOffset CreateElementVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFightMusicSwitchByTag>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFightMusicSwitchByTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022425 RID: 140325 RVA: 0x004C06D8 File Offset: 0x004BE8D8
		public static VectorOffset CreateElementVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFightMusicSwitchByTag>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022426 RID: 140326 RVA: 0x004C06F1 File Offset: 0x004BE8F1
		public static void StartElementVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022427 RID: 140327 RVA: 0x004C06FC File Offset: 0x004BE8FC
		public static Offset<IFightMusicsSwitchByTagList> EndIFightMusicsSwitchByTagList(FlatBufferBuilder builder)
		{
			return new Offset<IFightMusicsSwitchByTagList>(builder.EndTable());
		}

		// Token: 0x06022428 RID: 140328 RVA: 0x004C070C File Offset: 0x004BE90C
		public IFightMusicsSwitchByTagListT UnPack()
		{
			IFightMusicsSwitchByTagListT fightMusicsSwitchByTagListT = new IFightMusicsSwitchByTagListT();
			this.UnPackTo(fightMusicsSwitchByTagListT);
			return fightMusicsSwitchByTagListT;
		}

		// Token: 0x06022429 RID: 140329 RVA: 0x004C0728 File Offset: 0x004BE928
		public void UnPackTo(IFightMusicsSwitchByTagListT _o)
		{
			_o.Type = this.Type;
			_o.Element = new List<IFightMusicSwitchByTagT>();
			for (int i = 0; i < this.ElementLength; i++)
			{
				_o.Element.Add((this.Element(i) != null) ? this.Element(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602242A RID: 140330 RVA: 0x004C0794 File Offset: 0x004BE994
		public static Offset<IFightMusicsSwitchByTagList> Pack(FlatBufferBuilder builder, IFightMusicsSwitchByTagListT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFightMusicsSwitchByTagList>);
			}
			VectorOffset elementOffset = default(VectorOffset);
			if (_o.Element != null)
			{
				Offset<IFightMusicSwitchByTag>[] array = new Offset<IFightMusicSwitchByTag>[_o.Element.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFightMusicSwitchByTag.Pack(builder, _o.Element[i]);
				}
				elementOffset = IFightMusicsSwitchByTagList.CreateElementVector(builder, array);
			}
			return IFightMusicsSwitchByTagList.CreateIFightMusicsSwitchByTagList(builder, _o.Type, elementOffset);
		}

		// Token: 0x0400E38F RID: 58255
		private Table __p;
	}
}
