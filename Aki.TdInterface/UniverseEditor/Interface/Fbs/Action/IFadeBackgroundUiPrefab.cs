using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E06 RID: 28166
	public struct IFadeBackgroundUiPrefab : IFlatbufferObject
	{
		// Token: 0x1700CE69 RID: 52841
		// (get) Token: 0x060309F9 RID: 199161 RVA: 0x00699D5A File Offset: 0x00697F5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060309FA RID: 199162 RVA: 0x00699D67 File Offset: 0x00697F67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060309FB RID: 199163 RVA: 0x00699D70 File Offset: 0x00697F70
		public static IFadeBackgroundUiPrefab GetRootAsIFadeBackgroundUiPrefab(ByteBuffer _bb)
		{
			return IFadeBackgroundUiPrefab.GetRootAsIFadeBackgroundUiPrefab(_bb, default(IFadeBackgroundUiPrefab));
		}

		// Token: 0x060309FC RID: 199164 RVA: 0x00699D8C File Offset: 0x00697F8C
		public static IFadeBackgroundUiPrefab GetRootAsIFadeBackgroundUiPrefab(ByteBuffer _bb, IFadeBackgroundUiPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060309FD RID: 199165 RVA: 0x00699DA9 File Offset: 0x00697FA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060309FE RID: 199166 RVA: 0x00699DB8 File Offset: 0x00697FB8
		public IFadeBackgroundUiPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE6A RID: 52842
		// (get) Token: 0x060309FF RID: 199167 RVA: 0x00699DC8 File Offset: 0x00697FC8
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

		// Token: 0x1700CE6B RID: 52843
		// (get) Token: 0x06030A00 RID: 199168 RVA: 0x00699E04 File Offset: 0x00698004
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

		// Token: 0x06030A01 RID: 199169 RVA: 0x00699E61 File Offset: 0x00698061
		public static Offset<IFadeBackgroundUiPrefab> CreateIFadeBackgroundUiPrefab(FlatBufferBuilder builder, EFadeBackgroundType Type = EFadeBackgroundType.Spine, Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> PrefabTypeOffset = default(Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText>))
		{
			builder.StartTable(2);
			IFadeBackgroundUiPrefab.AddPrefabType(builder, PrefabTypeOffset);
			IFadeBackgroundUiPrefab.AddType(builder, Type);
			return IFadeBackgroundUiPrefab.EndIFadeBackgroundUiPrefab(builder);
		}

		// Token: 0x06030A02 RID: 199170 RVA: 0x00699E7E File Offset: 0x0069807E
		public static void StartIFadeBackgroundUiPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030A03 RID: 199171 RVA: 0x00699E87 File Offset: 0x00698087
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030A04 RID: 199172 RVA: 0x00699E92 File Offset: 0x00698092
		public static void AddPrefabType(FlatBufferBuilder builder, Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> prefabTypeOffset)
		{
			builder.AddOffset(1, prefabTypeOffset.Value, 0);
		}

		// Token: 0x06030A05 RID: 199173 RVA: 0x00699EA2 File Offset: 0x006980A2
		public static Offset<IFadeBackgroundUiPrefab> EndIFadeBackgroundUiPrefab(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundUiPrefab>(builder.EndTable());
		}

		// Token: 0x06030A06 RID: 199174 RVA: 0x00699EB0 File Offset: 0x006980B0
		public IFadeBackgroundUiPrefabT UnPack()
		{
			IFadeBackgroundUiPrefabT fadeBackgroundUiPrefabT = new IFadeBackgroundUiPrefabT();
			this.UnPackTo(fadeBackgroundUiPrefabT);
			return fadeBackgroundUiPrefabT;
		}

		// Token: 0x06030A07 RID: 199175 RVA: 0x00699ECC File Offset: 0x006980CC
		public void UnPackTo(IFadeBackgroundUiPrefabT _o)
		{
			_o.Type = this.Type;
			_o.PrefabType = ((this.PrefabType != null) ? this.PrefabType.Value.UnPack() : null);
		}

		// Token: 0x06030A08 RID: 199176 RVA: 0x00699F14 File Offset: 0x00698114
		public static Offset<IFadeBackgroundUiPrefab> Pack(FlatBufferBuilder builder, IFadeBackgroundUiPrefabT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundUiPrefab>);
			}
			Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> prefabTypeOffset = (_o.PrefabType == null) ? default(Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText>) : IFadeBackgroundUiPrefabBlackScreenWhiteText.Pack(builder, _o.PrefabType);
			return IFadeBackgroundUiPrefab.CreateIFadeBackgroundUiPrefab(builder, _o.Type, prefabTypeOffset);
		}

		// Token: 0x04011CBC RID: 72892
		private Table __p;
	}
}
