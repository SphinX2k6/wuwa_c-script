using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BA8 RID: 31656
	public struct ITeleportTransitionWithSpecialCustomLoading : IFlatbufferObject
	{
		// Token: 0x1700ED18 RID: 60696
		// (get) Token: 0x06039093 RID: 233619 RVA: 0x007B5494 File Offset: 0x007B3694
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039094 RID: 233620 RVA: 0x007B54A1 File Offset: 0x007B36A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039095 RID: 233621 RVA: 0x007B54A8 File Offset: 0x007B36A8
		public static ITeleportTransitionWithSpecialCustomLoading GetRootAsITeleportTransitionWithSpecialCustomLoading(ByteBuffer _bb)
		{
			return ITeleportTransitionWithSpecialCustomLoading.GetRootAsITeleportTransitionWithSpecialCustomLoading(_bb, default(ITeleportTransitionWithSpecialCustomLoading));
		}

		// Token: 0x06039096 RID: 233622 RVA: 0x007B54C4 File Offset: 0x007B36C4
		public static ITeleportTransitionWithSpecialCustomLoading GetRootAsITeleportTransitionWithSpecialCustomLoading(ByteBuffer _bb, ITeleportTransitionWithSpecialCustomLoading obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039097 RID: 233623 RVA: 0x007B54E1 File Offset: 0x007B36E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039098 RID: 233624 RVA: 0x007B54F0 File Offset: 0x007B36F0
		public ITeleportTransitionWithSpecialCustomLoading __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED19 RID: 60697
		// (get) Token: 0x06039099 RID: 233625 RVA: 0x007B5500 File Offset: 0x007B3700
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

		// Token: 0x1700ED1A RID: 60698
		// (get) Token: 0x0603909A RID: 233626 RVA: 0x007B553C File Offset: 0x007B373C
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

		// Token: 0x0603909B RID: 233627 RVA: 0x007B5599 File Offset: 0x007B3799
		public static Offset<ITeleportTransitionWithSpecialCustomLoading> CreateITeleportTransitionWithSpecialCustomLoading(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, Offset<IHonamiStoryCustomLoading> LoadingTypeOffset = default(Offset<IHonamiStoryCustomLoading>))
		{
			builder.StartTable(2);
			ITeleportTransitionWithSpecialCustomLoading.AddLoadingType(builder, LoadingTypeOffset);
			ITeleportTransitionWithSpecialCustomLoading.AddType(builder, Type);
			return ITeleportTransitionWithSpecialCustomLoading.EndITeleportTransitionWithSpecialCustomLoading(builder);
		}

		// Token: 0x0603909C RID: 233628 RVA: 0x007B55B6 File Offset: 0x007B37B6
		public static void StartITeleportTransitionWithSpecialCustomLoading(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603909D RID: 233629 RVA: 0x007B55BF File Offset: 0x007B37BF
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603909E RID: 233630 RVA: 0x007B55CA File Offset: 0x007B37CA
		public static void AddLoadingType(FlatBufferBuilder builder, Offset<IHonamiStoryCustomLoading> loadingTypeOffset)
		{
			builder.AddOffset(1, loadingTypeOffset.Value, 0);
		}

		// Token: 0x0603909F RID: 233631 RVA: 0x007B55DA File Offset: 0x007B37DA
		public static Offset<ITeleportTransitionWithSpecialCustomLoading> EndITeleportTransitionWithSpecialCustomLoading(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithSpecialCustomLoading>(builder.EndTable());
		}

		// Token: 0x060390A0 RID: 233632 RVA: 0x007B55E8 File Offset: 0x007B37E8
		public ITeleportTransitionWithSpecialCustomLoadingT UnPack()
		{
			ITeleportTransitionWithSpecialCustomLoadingT teleportTransitionWithSpecialCustomLoadingT = new ITeleportTransitionWithSpecialCustomLoadingT();
			this.UnPackTo(teleportTransitionWithSpecialCustomLoadingT);
			return teleportTransitionWithSpecialCustomLoadingT;
		}

		// Token: 0x060390A1 RID: 233633 RVA: 0x007B5604 File Offset: 0x007B3804
		public void UnPackTo(ITeleportTransitionWithSpecialCustomLoadingT _o)
		{
			_o.Type = this.Type;
			_o.LoadingType = ((this.LoadingType != null) ? this.LoadingType.Value.UnPack() : null);
		}

		// Token: 0x060390A2 RID: 233634 RVA: 0x007B564C File Offset: 0x007B384C
		public static Offset<ITeleportTransitionWithSpecialCustomLoading> Pack(FlatBufferBuilder builder, ITeleportTransitionWithSpecialCustomLoadingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithSpecialCustomLoading>);
			}
			Offset<IHonamiStoryCustomLoading> loadingTypeOffset = (_o.LoadingType == null) ? default(Offset<IHonamiStoryCustomLoading>) : IHonamiStoryCustomLoading.Pack(builder, _o.LoadingType);
			return ITeleportTransitionWithSpecialCustomLoading.CreateITeleportTransitionWithSpecialCustomLoading(builder, _o.Type, loadingTypeOffset);
		}

		// Token: 0x0401321C RID: 78364
		private Table __p;
	}
}
