using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051F6 RID: 20982
	public struct ITrafficMatchTarget : IFlatbufferObject
	{
		// Token: 0x17009635 RID: 38453
		// (get) Token: 0x060210B3 RID: 135347 RVA: 0x004910C4 File Offset: 0x0048F2C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060210B4 RID: 135348 RVA: 0x004910D1 File Offset: 0x0048F2D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060210B5 RID: 135349 RVA: 0x004910D8 File Offset: 0x0048F2D8
		public static ITrafficMatchTarget GetRootAsITrafficMatchTarget(ByteBuffer _bb)
		{
			return ITrafficMatchTarget.GetRootAsITrafficMatchTarget(_bb, default(ITrafficMatchTarget));
		}

		// Token: 0x060210B6 RID: 135350 RVA: 0x004910F4 File Offset: 0x0048F2F4
		public static ITrafficMatchTarget GetRootAsITrafficMatchTarget(ByteBuffer _bb, ITrafficMatchTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060210B7 RID: 135351 RVA: 0x00491111 File Offset: 0x0048F311
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060210B8 RID: 135352 RVA: 0x00491120 File Offset: 0x0048F320
		public ITrafficMatchTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009636 RID: 38454
		// (get) Token: 0x060210B9 RID: 135353 RVA: 0x00491130 File Offset: 0x0048F330
		public bool MatchPlayer
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009637 RID: 38455
		// (get) Token: 0x060210BA RID: 135354 RVA: 0x00491170 File Offset: 0x0048F370
		public ITrafficMatchTargetByEntityLogic? MatchTargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITrafficMatchTargetByEntityLogic?(default(ITrafficMatchTargetByEntityLogic).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060210BB RID: 135355 RVA: 0x004911CD File Offset: 0x0048F3CD
		public static Offset<ITrafficMatchTarget> CreateITrafficMatchTarget(FlatBufferBuilder builder, bool MatchPlayer = false, Offset<ITrafficMatchTargetByEntityLogic> MatchTargetTypeOffset = default(Offset<ITrafficMatchTargetByEntityLogic>))
		{
			builder.StartTable(2);
			ITrafficMatchTarget.AddMatchTargetType(builder, MatchTargetTypeOffset);
			ITrafficMatchTarget.AddMatchPlayer(builder, MatchPlayer);
			return ITrafficMatchTarget.EndITrafficMatchTarget(builder);
		}

		// Token: 0x060210BC RID: 135356 RVA: 0x004911EA File Offset: 0x0048F3EA
		public static void StartITrafficMatchTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060210BD RID: 135357 RVA: 0x004911F3 File Offset: 0x0048F3F3
		public static void AddMatchPlayer(FlatBufferBuilder builder, bool matchPlayer)
		{
			builder.AddBool(0, matchPlayer, false);
		}

		// Token: 0x060210BE RID: 135358 RVA: 0x004911FE File Offset: 0x0048F3FE
		public static void AddMatchTargetType(FlatBufferBuilder builder, Offset<ITrafficMatchTargetByEntityLogic> matchTargetTypeOffset)
		{
			builder.AddOffset(1, matchTargetTypeOffset.Value, 0);
		}

		// Token: 0x060210BF RID: 135359 RVA: 0x0049120E File Offset: 0x0048F40E
		public static Offset<ITrafficMatchTarget> EndITrafficMatchTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficMatchTarget>(builder.EndTable());
		}

		// Token: 0x060210C0 RID: 135360 RVA: 0x0049121C File Offset: 0x0048F41C
		public ITrafficMatchTargetT UnPack()
		{
			ITrafficMatchTargetT trafficMatchTargetT = new ITrafficMatchTargetT();
			this.UnPackTo(trafficMatchTargetT);
			return trafficMatchTargetT;
		}

		// Token: 0x060210C1 RID: 135361 RVA: 0x00491238 File Offset: 0x0048F438
		public void UnPackTo(ITrafficMatchTargetT _o)
		{
			_o.MatchPlayer = this.MatchPlayer;
			_o.MatchTargetType = ((this.MatchTargetType != null) ? this.MatchTargetType.Value.UnPack() : null);
		}

		// Token: 0x060210C2 RID: 135362 RVA: 0x00491280 File Offset: 0x0048F480
		public static Offset<ITrafficMatchTarget> Pack(FlatBufferBuilder builder, ITrafficMatchTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficMatchTarget>);
			}
			Offset<ITrafficMatchTargetByEntityLogic> matchTargetTypeOffset = (_o.MatchTargetType == null) ? default(Offset<ITrafficMatchTargetByEntityLogic>) : ITrafficMatchTargetByEntityLogic.Pack(builder, _o.MatchTargetType);
			return ITrafficMatchTarget.CreateITrafficMatchTarget(builder, _o.MatchPlayer, matchTargetTypeOffset);
		}

		// Token: 0x0400E203 RID: 57859
		private Table __p;
	}
}
