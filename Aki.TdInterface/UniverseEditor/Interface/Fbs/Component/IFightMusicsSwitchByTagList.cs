using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057AB RID: 22443
	public struct IFightMusicsSwitchByTagList : IFlatbufferObject
	{
		// Token: 0x1700A249 RID: 41545
		// (get) Token: 0x060243AB RID: 148395 RVA: 0x004FAFB0 File Offset: 0x004F91B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060243AC RID: 148396 RVA: 0x004FAFBD File Offset: 0x004F91BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060243AD RID: 148397 RVA: 0x004FAFC4 File Offset: 0x004F91C4
		public static IFightMusicsSwitchByTagList GetRootAsIFightMusicsSwitchByTagList(ByteBuffer _bb)
		{
			return IFightMusicsSwitchByTagList.GetRootAsIFightMusicsSwitchByTagList(_bb, default(IFightMusicsSwitchByTagList));
		}

		// Token: 0x060243AE RID: 148398 RVA: 0x004FAFE0 File Offset: 0x004F91E0
		public static IFightMusicsSwitchByTagList GetRootAsIFightMusicsSwitchByTagList(ByteBuffer _bb, IFightMusicsSwitchByTagList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060243AF RID: 148399 RVA: 0x004FAFFD File Offset: 0x004F91FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060243B0 RID: 148400 RVA: 0x004FB00C File Offset: 0x004F920C
		public IFightMusicsSwitchByTagList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A24A RID: 41546
		// (get) Token: 0x060243B1 RID: 148401 RVA: 0x004FB01C File Offset: 0x004F921C
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

		// Token: 0x060243B2 RID: 148402 RVA: 0x004FB058 File Offset: 0x004F9258
		public IFightMusicSwitchByTag? Element(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFightMusicSwitchByTag?(default(IFightMusicSwitchByTag).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A24B RID: 41547
		// (get) Token: 0x060243B3 RID: 148403 RVA: 0x004FB0B8 File Offset: 0x004F92B8
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

		// Token: 0x060243B4 RID: 148404 RVA: 0x004FB0E3 File Offset: 0x004F92E3
		public static Offset<IFightMusicsSwitchByTagList> CreateIFightMusicsSwitchByTagList(FlatBufferBuilder builder, EFightMusicsSwitchType Type = EFightMusicsSwitchType.SwitchByTag, VectorOffset ElementOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFightMusicsSwitchByTagList.AddElement(builder, ElementOffset);
			IFightMusicsSwitchByTagList.AddType(builder, Type);
			return IFightMusicsSwitchByTagList.EndIFightMusicsSwitchByTagList(builder);
		}

		// Token: 0x060243B5 RID: 148405 RVA: 0x004FB100 File Offset: 0x004F9300
		public static void StartIFightMusicsSwitchByTagList(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060243B6 RID: 148406 RVA: 0x004FB109 File Offset: 0x004F9309
		public static void AddType(FlatBufferBuilder builder, EFightMusicsSwitchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060243B7 RID: 148407 RVA: 0x004FB114 File Offset: 0x004F9314
		public static void AddElement(FlatBufferBuilder builder, VectorOffset elementOffset)
		{
			builder.AddOffset(1, elementOffset.Value, 0);
		}

		// Token: 0x060243B8 RID: 148408 RVA: 0x004FB124 File Offset: 0x004F9324
		public static VectorOffset CreateElementVector(FlatBufferBuilder builder, Offset<IFightMusicSwitchByTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060243B9 RID: 148409 RVA: 0x004FB164 File Offset: 0x004F9364
		public static VectorOffset CreateElementVectorBlock(FlatBufferBuilder builder, Offset<IFightMusicSwitchByTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFightMusicSwitchByTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x060243BA RID: 148410 RVA: 0x004FB17E File Offset: 0x004F937E
		public static VectorOffset CreateElementVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFightMusicSwitchByTag>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFightMusicSwitchByTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x060243BB RID: 148411 RVA: 0x004FB19C File Offset: 0x004F939C
		public static VectorOffset CreateElementVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFightMusicSwitchByTag>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060243BC RID: 148412 RVA: 0x004FB1B5 File Offset: 0x004F93B5
		public static void StartElementVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060243BD RID: 148413 RVA: 0x004FB1C0 File Offset: 0x004F93C0
		public static Offset<IFightMusicsSwitchByTagList> EndIFightMusicsSwitchByTagList(FlatBufferBuilder builder)
		{
			return new Offset<IFightMusicsSwitchByTagList>(builder.EndTable());
		}

		// Token: 0x060243BE RID: 148414 RVA: 0x004FB1D0 File Offset: 0x004F93D0
		public IFightMusicsSwitchByTagListT UnPack()
		{
			IFightMusicsSwitchByTagListT fightMusicsSwitchByTagListT = new IFightMusicsSwitchByTagListT();
			this.UnPackTo(fightMusicsSwitchByTagListT);
			return fightMusicsSwitchByTagListT;
		}

		// Token: 0x060243BF RID: 148415 RVA: 0x004FB1EC File Offset: 0x004F93EC
		public void UnPackTo(IFightMusicsSwitchByTagListT _o)
		{
			_o.Type = this.Type;
			_o.Element = new List<IFightMusicSwitchByTagT>();
			for (int i = 0; i < this.ElementLength; i++)
			{
				_o.Element.Add((this.Element(i) != null) ? this.Element(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060243C0 RID: 148416 RVA: 0x004FB258 File Offset: 0x004F9458
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

		// Token: 0x0400EF95 RID: 61333
		private Table __p;
	}
}
