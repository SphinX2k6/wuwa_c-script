using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E3C RID: 20028
	public struct ICheckAtlasUnlocked : IFlatbufferObject
	{
		// Token: 0x17008EA8 RID: 36520
		// (get) Token: 0x0601EF93 RID: 126867 RVA: 0x0045358A File Offset: 0x0045178A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF94 RID: 126868 RVA: 0x00453597 File Offset: 0x00451797
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF95 RID: 126869 RVA: 0x004535A0 File Offset: 0x004517A0
		public static ICheckAtlasUnlocked GetRootAsICheckAtlasUnlocked(ByteBuffer _bb)
		{
			return ICheckAtlasUnlocked.GetRootAsICheckAtlasUnlocked(_bb, default(ICheckAtlasUnlocked));
		}

		// Token: 0x0601EF96 RID: 126870 RVA: 0x004535BC File Offset: 0x004517BC
		public static ICheckAtlasUnlocked GetRootAsICheckAtlasUnlocked(ByteBuffer _bb, ICheckAtlasUnlocked obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF97 RID: 126871 RVA: 0x004535D9 File Offset: 0x004517D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF98 RID: 126872 RVA: 0x004535E8 File Offset: 0x004517E8
		public ICheckAtlasUnlocked __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EA9 RID: 36521
		// (get) Token: 0x0601EF99 RID: 126873 RVA: 0x004535F8 File Offset: 0x004517F8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EAA RID: 36522
		// (get) Token: 0x0601EF9A RID: 126874 RVA: 0x00453634 File Offset: 0x00451834
		public TUnlockAtlasSystemOptionV2 AtlasType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TUnlockAtlasSystemOptionV2.NONE;
				}
				return (TUnlockAtlasSystemOptionV2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EF9B RID: 126875 RVA: 0x00453670 File Offset: 0x00451870
		public TTable? Atlas<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601EF9C RID: 126876 RVA: 0x004536B4 File Offset: 0x004518B4
		public IUnlockGeographicalAtlasV2 AtlasAsIUnlockGeographicalAtlasV2()
		{
			return this.Atlas<IUnlockGeographicalAtlasV2>().Value;
		}

		// Token: 0x0601EF9D RID: 126877 RVA: 0x004536D0 File Offset: 0x004518D0
		public IUnlockNounAtlasV2 AtlasAsIUnlockNounAtlasV2()
		{
			return this.Atlas<IUnlockNounAtlasV2>().Value;
		}

		// Token: 0x0601EF9E RID: 126878 RVA: 0x004536EC File Offset: 0x004518EC
		public IUnlockPanoramaAtlasV2 AtlasAsIUnlockPanoramaAtlasV2()
		{
			return this.Atlas<IUnlockPanoramaAtlasV2>().Value;
		}

		// Token: 0x0601EF9F RID: 126879 RVA: 0x00453708 File Offset: 0x00451908
		public IUnlockPlotPhotoAtlasV2 AtlasAsIUnlockPlotPhotoAtlasV2()
		{
			return this.Atlas<IUnlockPlotPhotoAtlasV2>().Value;
		}

		// Token: 0x17008EAB RID: 36523
		// (get) Token: 0x0601EFA0 RID: 126880 RVA: 0x00453724 File Offset: 0x00451924
		public bool Unlocked
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601EFA1 RID: 126881 RVA: 0x00453764 File Offset: 0x00451964
		public static Offset<ICheckAtlasUnlocked> CreateICheckAtlasUnlocked(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TUnlockAtlasSystemOptionV2 Atlas_type = TUnlockAtlasSystemOptionV2.NONE, int AtlasOffset = 0, bool Unlocked = false)
		{
			builder.StartTable(4);
			ICheckAtlasUnlocked.AddAtlas(builder, AtlasOffset);
			ICheckAtlasUnlocked.AddUnlocked(builder, Unlocked);
			ICheckAtlasUnlocked.AddAtlasType(builder, Atlas_type);
			ICheckAtlasUnlocked.AddType(builder, Type);
			return ICheckAtlasUnlocked.EndICheckAtlasUnlocked(builder);
		}

		// Token: 0x0601EFA2 RID: 126882 RVA: 0x00453790 File Offset: 0x00451990
		public static void StartICheckAtlasUnlocked(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EFA3 RID: 126883 RVA: 0x00453799 File Offset: 0x00451999
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EFA4 RID: 126884 RVA: 0x004537A4 File Offset: 0x004519A4
		public static void AddAtlasType(FlatBufferBuilder builder, TUnlockAtlasSystemOptionV2 atlasType)
		{
			builder.AddByte(1, (byte)atlasType, 0);
		}

		// Token: 0x0601EFA5 RID: 126885 RVA: 0x004537AF File Offset: 0x004519AF
		public static void AddAtlas(FlatBufferBuilder builder, int atlasOffset)
		{
			builder.AddOffset(2, atlasOffset, 0);
		}

		// Token: 0x0601EFA6 RID: 126886 RVA: 0x004537BA File Offset: 0x004519BA
		public static void AddUnlocked(FlatBufferBuilder builder, bool unlocked)
		{
			builder.AddBool(3, unlocked, false);
		}

		// Token: 0x0601EFA7 RID: 126887 RVA: 0x004537C5 File Offset: 0x004519C5
		public static Offset<ICheckAtlasUnlocked> EndICheckAtlasUnlocked(FlatBufferBuilder builder)
		{
			return new Offset<ICheckAtlasUnlocked>(builder.EndTable());
		}

		// Token: 0x0601EFA8 RID: 126888 RVA: 0x004537D4 File Offset: 0x004519D4
		public ICheckAtlasUnlockedT UnPack()
		{
			ICheckAtlasUnlockedT checkAtlasUnlockedT = new ICheckAtlasUnlockedT();
			this.UnPackTo(checkAtlasUnlockedT);
			return checkAtlasUnlockedT;
		}

		// Token: 0x0601EFA9 RID: 126889 RVA: 0x004537F0 File Offset: 0x004519F0
		public void UnPackTo(ICheckAtlasUnlockedT _o)
		{
			_o.Type = this.Type;
			_o.Atlas = new TUnlockAtlasSystemOptionV2Union();
			_o.Atlas.Type = this.AtlasType;
			switch (this.AtlasType)
			{
			case TUnlockAtlasSystemOptionV2.IUnlockGeographicalAtlasV2:
				_o.Atlas.Value = ((this.Atlas<IUnlockGeographicalAtlasV2>() != null) ? this.Atlas<IUnlockGeographicalAtlasV2>().Value.UnPack() : null);
				break;
			case TUnlockAtlasSystemOptionV2.IUnlockNounAtlasV2:
				_o.Atlas.Value = ((this.Atlas<IUnlockNounAtlasV2>() != null) ? this.Atlas<IUnlockNounAtlasV2>().Value.UnPack() : null);
				break;
			case TUnlockAtlasSystemOptionV2.IUnlockPanoramaAtlasV2:
				_o.Atlas.Value = ((this.Atlas<IUnlockPanoramaAtlasV2>() != null) ? this.Atlas<IUnlockPanoramaAtlasV2>().Value.UnPack() : null);
				break;
			case TUnlockAtlasSystemOptionV2.IUnlockPlotPhotoAtlasV2:
				_o.Atlas.Value = ((this.Atlas<IUnlockPlotPhotoAtlasV2>() != null) ? this.Atlas<IUnlockPlotPhotoAtlasV2>().Value.UnPack() : null);
				break;
			}
			_o.Unlocked = this.Unlocked;
		}

		// Token: 0x0601EFAA RID: 126890 RVA: 0x00453938 File Offset: 0x00451B38
		public static Offset<ICheckAtlasUnlocked> Pack(FlatBufferBuilder builder, ICheckAtlasUnlockedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckAtlasUnlocked>);
			}
			TUnlockAtlasSystemOptionV2 atlas_type = (_o.Atlas == null) ? TUnlockAtlasSystemOptionV2.NONE : _o.Atlas.Type;
			int atlasOffset = (_o.Atlas == null) ? 0 : TUnlockAtlasSystemOptionV2Union.Pack(builder, _o.Atlas);
			return ICheckAtlasUnlocked.CreateICheckAtlasUnlocked(builder, _o.Type, atlas_type, atlasOffset, _o.Unlocked);
		}

		// Token: 0x0400DC58 RID: 56408
		private Table __p;
	}
}
