using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006786 RID: 26502
	public struct IFadeBackgroundUiPrefab : IFlatbufferObject
	{
		// Token: 0x1700C4B3 RID: 50355
		// (get) Token: 0x0602E1B3 RID: 188851 RVA: 0x0064C616 File Offset: 0x0064A816
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E1B4 RID: 188852 RVA: 0x0064C623 File Offset: 0x0064A823
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E1B5 RID: 188853 RVA: 0x0064C62C File Offset: 0x0064A82C
		public static IFadeBackgroundUiPrefab GetRootAsIFadeBackgroundUiPrefab(ByteBuffer _bb)
		{
			return IFadeBackgroundUiPrefab.GetRootAsIFadeBackgroundUiPrefab(_bb, default(IFadeBackgroundUiPrefab));
		}

		// Token: 0x0602E1B6 RID: 188854 RVA: 0x0064C648 File Offset: 0x0064A848
		public static IFadeBackgroundUiPrefab GetRootAsIFadeBackgroundUiPrefab(ByteBuffer _bb, IFadeBackgroundUiPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E1B7 RID: 188855 RVA: 0x0064C665 File Offset: 0x0064A865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E1B8 RID: 188856 RVA: 0x0064C674 File Offset: 0x0064A874
		public IFadeBackgroundUiPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4B4 RID: 50356
		// (get) Token: 0x0602E1B9 RID: 188857 RVA: 0x0064C684 File Offset: 0x0064A884
		public EFadeBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundType.Spine;
				}
				return (EFadeBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4B5 RID: 50357
		// (get) Token: 0x0602E1BA RID: 188858 RVA: 0x0064C6C0 File Offset: 0x0064A8C0
		public IFadeBackgroundUiPrefabBlackScreenWhiteText? PrefabType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFadeBackgroundUiPrefabBlackScreenWhiteText?(default(IFadeBackgroundUiPrefabBlackScreenWhiteText).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E1BB RID: 188859 RVA: 0x0064C71D File Offset: 0x0064A91D
		public static Offset<IFadeBackgroundUiPrefab> CreateIFadeBackgroundUiPrefab(FlatBufferBuilder builder, EFadeBackgroundType Type = EFadeBackgroundType.Spine, Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> PrefabTypeOffset = default(Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText>))
		{
			builder.StartTable(2);
			IFadeBackgroundUiPrefab.AddPrefabType(builder, PrefabTypeOffset);
			IFadeBackgroundUiPrefab.AddType(builder, Type);
			return IFadeBackgroundUiPrefab.EndIFadeBackgroundUiPrefab(builder);
		}

		// Token: 0x0602E1BC RID: 188860 RVA: 0x0064C73A File Offset: 0x0064A93A
		public static void StartIFadeBackgroundUiPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E1BD RID: 188861 RVA: 0x0064C743 File Offset: 0x0064A943
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E1BE RID: 188862 RVA: 0x0064C74E File Offset: 0x0064A94E
		public static void AddPrefabType(FlatBufferBuilder builder, Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> prefabTypeOffset)
		{
			builder.AddOffset(1, prefabTypeOffset.Value, 0);
		}

		// Token: 0x0602E1BF RID: 188863 RVA: 0x0064C75E File Offset: 0x0064A95E
		public static Offset<IFadeBackgroundUiPrefab> EndIFadeBackgroundUiPrefab(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundUiPrefab>(builder.EndTable());
		}

		// Token: 0x0602E1C0 RID: 188864 RVA: 0x0064C76C File Offset: 0x0064A96C
		public IFadeBackgroundUiPrefabT UnPack()
		{
			IFadeBackgroundUiPrefabT fadeBackgroundUiPrefabT = new IFadeBackgroundUiPrefabT();
			this.UnPackTo(fadeBackgroundUiPrefabT);
			return fadeBackgroundUiPrefabT;
		}

		// Token: 0x0602E1C1 RID: 188865 RVA: 0x0064C788 File Offset: 0x0064A988
		public void UnPackTo(IFadeBackgroundUiPrefabT _o)
		{
			_o.Type = this.Type;
			_o.PrefabType = ((this.PrefabType != null) ? this.PrefabType.Value.UnPack() : null);
		}

		// Token: 0x0602E1C2 RID: 188866 RVA: 0x0064C7D0 File Offset: 0x0064A9D0
		public static Offset<IFadeBackgroundUiPrefab> Pack(FlatBufferBuilder builder, IFadeBackgroundUiPrefabT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundUiPrefab>);
			}
			Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> prefabTypeOffset = (_o.PrefabType == null) ? default(Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText>) : IFadeBackgroundUiPrefabBlackScreenWhiteText.Pack(builder, _o.PrefabType);
			return IFadeBackgroundUiPrefab.CreateIFadeBackgroundUiPrefab(builder, _o.Type, prefabTypeOffset);
		}

		// Token: 0x04010E8A RID: 69258
		private Table __p;
	}
}
