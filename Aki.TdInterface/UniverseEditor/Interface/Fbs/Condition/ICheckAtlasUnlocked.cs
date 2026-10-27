using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004985 RID: 18821
	public struct ICheckAtlasUnlocked : IFlatbufferObject
	{
		// Token: 0x170087ED RID: 34797
		// (get) Token: 0x0601D56E RID: 120174 RVA: 0x004230D6 File Offset: 0x004212D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D56F RID: 120175 RVA: 0x004230E3 File Offset: 0x004212E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D570 RID: 120176 RVA: 0x004230EC File Offset: 0x004212EC
		public static ICheckAtlasUnlocked GetRootAsICheckAtlasUnlocked(ByteBuffer _bb)
		{
			return ICheckAtlasUnlocked.GetRootAsICheckAtlasUnlocked(_bb, default(ICheckAtlasUnlocked));
		}

		// Token: 0x0601D571 RID: 120177 RVA: 0x00423108 File Offset: 0x00421308
		public static ICheckAtlasUnlocked GetRootAsICheckAtlasUnlocked(ByteBuffer _bb, ICheckAtlasUnlocked obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D572 RID: 120178 RVA: 0x00423125 File Offset: 0x00421325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D573 RID: 120179 RVA: 0x00423134 File Offset: 0x00421334
		public ICheckAtlasUnlocked __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087EE RID: 34798
		// (get) Token: 0x0601D574 RID: 120180 RVA: 0x00423144 File Offset: 0x00421344
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

		// Token: 0x170087EF RID: 34799
		// (get) Token: 0x0601D575 RID: 120181 RVA: 0x00423180 File Offset: 0x00421380
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

		// Token: 0x0601D576 RID: 120182 RVA: 0x004231BC File Offset: 0x004213BC
		public TTable? Atlas<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601D577 RID: 120183 RVA: 0x00423200 File Offset: 0x00421400
		public IUnlockGeographicalAtlasV2 AtlasAsIUnlockGeographicalAtlasV2()
		{
			return this.Atlas<IUnlockGeographicalAtlasV2>().Value;
		}

		// Token: 0x0601D578 RID: 120184 RVA: 0x0042321C File Offset: 0x0042141C
		public IUnlockNounAtlasV2 AtlasAsIUnlockNounAtlasV2()
		{
			return this.Atlas<IUnlockNounAtlasV2>().Value;
		}

		// Token: 0x0601D579 RID: 120185 RVA: 0x00423238 File Offset: 0x00421438
		public IUnlockPanoramaAtlasV2 AtlasAsIUnlockPanoramaAtlasV2()
		{
			return this.Atlas<IUnlockPanoramaAtlasV2>().Value;
		}

		// Token: 0x0601D57A RID: 120186 RVA: 0x00423254 File Offset: 0x00421454
		public IUnlockPlotPhotoAtlasV2 AtlasAsIUnlockPlotPhotoAtlasV2()
		{
			return this.Atlas<IUnlockPlotPhotoAtlasV2>().Value;
		}

		// Token: 0x170087F0 RID: 34800
		// (get) Token: 0x0601D57B RID: 120187 RVA: 0x00423270 File Offset: 0x00421470
		public bool Unlocked
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D57C RID: 120188 RVA: 0x004232B0 File Offset: 0x004214B0
		public static Offset<ICheckAtlasUnlocked> CreateICheckAtlasUnlocked(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TUnlockAtlasSystemOptionV2 Atlas_type = TUnlockAtlasSystemOptionV2.NONE, int AtlasOffset = 0, bool Unlocked = false)
		{
			builder.StartTable(4);
			ICheckAtlasUnlocked.AddAtlas(builder, AtlasOffset);
			ICheckAtlasUnlocked.AddUnlocked(builder, Unlocked);
			ICheckAtlasUnlocked.AddAtlasType(builder, Atlas_type);
			ICheckAtlasUnlocked.AddType(builder, Type);
			return ICheckAtlasUnlocked.EndICheckAtlasUnlocked(builder);
		}

		// Token: 0x0601D57D RID: 120189 RVA: 0x004232DC File Offset: 0x004214DC
		public static void StartICheckAtlasUnlocked(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D57E RID: 120190 RVA: 0x004232E5 File Offset: 0x004214E5
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D57F RID: 120191 RVA: 0x004232F0 File Offset: 0x004214F0
		public static void AddAtlasType(FlatBufferBuilder builder, TUnlockAtlasSystemOptionV2 atlasType)
		{
			builder.AddByte(1, (byte)atlasType, 0);
		}

		// Token: 0x0601D580 RID: 120192 RVA: 0x004232FB File Offset: 0x004214FB
		public static void AddAtlas(FlatBufferBuilder builder, int atlasOffset)
		{
			builder.AddOffset(2, atlasOffset, 0);
		}

		// Token: 0x0601D581 RID: 120193 RVA: 0x00423306 File Offset: 0x00421506
		public static void AddUnlocked(FlatBufferBuilder builder, bool unlocked)
		{
			builder.AddBool(3, unlocked, false);
		}

		// Token: 0x0601D582 RID: 120194 RVA: 0x00423311 File Offset: 0x00421511
		public static Offset<ICheckAtlasUnlocked> EndICheckAtlasUnlocked(FlatBufferBuilder builder)
		{
			return new Offset<ICheckAtlasUnlocked>(builder.EndTable());
		}

		// Token: 0x0601D583 RID: 120195 RVA: 0x00423320 File Offset: 0x00421520
		public ICheckAtlasUnlockedT UnPack()
		{
			ICheckAtlasUnlockedT checkAtlasUnlockedT = new ICheckAtlasUnlockedT();
			this.UnPackTo(checkAtlasUnlockedT);
			return checkAtlasUnlockedT;
		}

		// Token: 0x0601D584 RID: 120196 RVA: 0x0042333C File Offset: 0x0042153C
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

		// Token: 0x0601D585 RID: 120197 RVA: 0x00423484 File Offset: 0x00421684
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

		// Token: 0x0400D190 RID: 53648
		private Table __p;
	}
}
