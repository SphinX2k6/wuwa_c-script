using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C1 RID: 29633
	public struct ITeleportTransitionWithSpecialCustomLoading : IFlatbufferObject
	{
		// Token: 0x1700E108 RID: 57608
		// (get) Token: 0x06035CF8 RID: 220408 RVA: 0x00752F54 File Offset: 0x00751154
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035CF9 RID: 220409 RVA: 0x00752F61 File Offset: 0x00751161
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035CFA RID: 220410 RVA: 0x00752F68 File Offset: 0x00751168
		public static ITeleportTransitionWithSpecialCustomLoading GetRootAsITeleportTransitionWithSpecialCustomLoading(ByteBuffer _bb)
		{
			return ITeleportTransitionWithSpecialCustomLoading.GetRootAsITeleportTransitionWithSpecialCustomLoading(_bb, default(ITeleportTransitionWithSpecialCustomLoading));
		}

		// Token: 0x06035CFB RID: 220411 RVA: 0x00752F84 File Offset: 0x00751184
		public static ITeleportTransitionWithSpecialCustomLoading GetRootAsITeleportTransitionWithSpecialCustomLoading(ByteBuffer _bb, ITeleportTransitionWithSpecialCustomLoading obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035CFC RID: 220412 RVA: 0x00752FA1 File Offset: 0x007511A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035CFD RID: 220413 RVA: 0x00752FB0 File Offset: 0x007511B0
		public ITeleportTransitionWithSpecialCustomLoading __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E109 RID: 57609
		// (get) Token: 0x06035CFE RID: 220414 RVA: 0x00752FC0 File Offset: 0x007511C0
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E10A RID: 57610
		// (get) Token: 0x06035CFF RID: 220415 RVA: 0x00752FFC File Offset: 0x007511FC
		public IHonamiStoryCustomLoading? LoadingType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IHonamiStoryCustomLoading?(default(IHonamiStoryCustomLoading).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035D00 RID: 220416 RVA: 0x00753059 File Offset: 0x00751259
		public static Offset<ITeleportTransitionWithSpecialCustomLoading> CreateITeleportTransitionWithSpecialCustomLoading(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, Offset<IHonamiStoryCustomLoading> LoadingTypeOffset = default(Offset<IHonamiStoryCustomLoading>))
		{
			builder.StartTable(2);
			ITeleportTransitionWithSpecialCustomLoading.AddLoadingType(builder, LoadingTypeOffset);
			ITeleportTransitionWithSpecialCustomLoading.AddType(builder, Type);
			return ITeleportTransitionWithSpecialCustomLoading.EndITeleportTransitionWithSpecialCustomLoading(builder);
		}

		// Token: 0x06035D01 RID: 220417 RVA: 0x00753076 File Offset: 0x00751276
		public static void StartITeleportTransitionWithSpecialCustomLoading(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035D02 RID: 220418 RVA: 0x0075307F File Offset: 0x0075127F
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035D03 RID: 220419 RVA: 0x0075308A File Offset: 0x0075128A
		public static void AddLoadingType(FlatBufferBuilder builder, Offset<IHonamiStoryCustomLoading> loadingTypeOffset)
		{
			builder.AddOffset(1, loadingTypeOffset.Value, 0);
		}

		// Token: 0x06035D04 RID: 220420 RVA: 0x0075309A File Offset: 0x0075129A
		public static Offset<ITeleportTransitionWithSpecialCustomLoading> EndITeleportTransitionWithSpecialCustomLoading(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithSpecialCustomLoading>(builder.EndTable());
		}

		// Token: 0x06035D05 RID: 220421 RVA: 0x007530A8 File Offset: 0x007512A8
		public ITeleportTransitionWithSpecialCustomLoadingT UnPack()
		{
			ITeleportTransitionWithSpecialCustomLoadingT teleportTransitionWithSpecialCustomLoadingT = new ITeleportTransitionWithSpecialCustomLoadingT();
			this.UnPackTo(teleportTransitionWithSpecialCustomLoadingT);
			return teleportTransitionWithSpecialCustomLoadingT;
		}

		// Token: 0x06035D06 RID: 220422 RVA: 0x007530C4 File Offset: 0x007512C4
		public void UnPackTo(ITeleportTransitionWithSpecialCustomLoadingT _o)
		{
			_o.Type = this.Type;
			_o.LoadingType = ((this.LoadingType != null) ? this.LoadingType.Value.UnPack() : null);
		}

		// Token: 0x06035D07 RID: 220423 RVA: 0x0075310C File Offset: 0x0075130C
		public static Offset<ITeleportTransitionWithSpecialCustomLoading> Pack(FlatBufferBuilder builder, ITeleportTransitionWithSpecialCustomLoadingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithSpecialCustomLoading>);
			}
			Offset<IHonamiStoryCustomLoading> loadingTypeOffset = (_o.LoadingType == null) ? default(Offset<IHonamiStoryCustomLoading>) : IHonamiStoryCustomLoading.Pack(builder, _o.LoadingType);
			return ITeleportTransitionWithSpecialCustomLoading.CreateITeleportTransitionWithSpecialCustomLoading(builder, _o.Type, loadingTypeOffset);
		}

		// Token: 0x04012203 RID: 74243
		private Table __p;
	}
}
