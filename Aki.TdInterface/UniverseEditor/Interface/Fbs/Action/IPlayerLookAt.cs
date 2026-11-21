using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007477 RID: 29815
	public struct IPlayerLookAt : IFlatbufferObject
	{
		// Token: 0x1700DB08 RID: 56072
		// (get) Token: 0x06034311 RID: 213777 RVA: 0x00707C89 File Offset: 0x00705E89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034312 RID: 213778 RVA: 0x00707C96 File Offset: 0x00705E96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034313 RID: 213779 RVA: 0x00707CA0 File Offset: 0x00705EA0
		public static IPlayerLookAt GetRootAsIPlayerLookAt(ByteBuffer _bb)
		{
			return IPlayerLookAt.GetRootAsIPlayerLookAt(_bb, default(IPlayerLookAt));
		}

		// Token: 0x06034314 RID: 213780 RVA: 0x00707CBC File Offset: 0x00705EBC
		public static IPlayerLookAt GetRootAsIPlayerLookAt(ByteBuffer _bb, IPlayerLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034315 RID: 213781 RVA: 0x00707CD9 File Offset: 0x00705ED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034316 RID: 213782 RVA: 0x00707CE8 File Offset: 0x00705EE8
		public IPlayerLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB09 RID: 56073
		// (get) Token: 0x06034317 RID: 213783 RVA: 0x00707CF8 File Offset: 0x00705EF8
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DB0A RID: 56074
		// (get) Token: 0x06034318 RID: 213784 RVA: 0x00707D58 File Offset: 0x00705F58
		public bool CameraMove
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB0B RID: 56075
		// (get) Token: 0x06034319 RID: 213785 RVA: 0x00707D98 File Offset: 0x00705F98
		public bool PlayAnimation
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB0C RID: 56076
		// (get) Token: 0x0603431A RID: 213786 RVA: 0x00707DD8 File Offset: 0x00705FD8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603431B RID: 213787 RVA: 0x00707E15 File Offset: 0x00706015
		public static Offset<IPlayerLookAt> CreateIPlayerLookAt(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), bool CameraMove = false, bool PlayAnimation = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPlayerLookAt.AddPos(builder, PosOffset);
			IPlayerLookAt.AddNullMask(builder, NullMask);
			IPlayerLookAt.AddPlayAnimation(builder, PlayAnimation);
			IPlayerLookAt.AddCameraMove(builder, CameraMove);
			return IPlayerLookAt.EndIPlayerLookAt(builder);
		}

		// Token: 0x0603431C RID: 213788 RVA: 0x00707E41 File Offset: 0x00706041
		public static void StartIPlayerLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603431D RID: 213789 RVA: 0x00707E4A File Offset: 0x0070604A
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0603431E RID: 213790 RVA: 0x00707E5A File Offset: 0x0070605A
		public static void AddCameraMove(FlatBufferBuilder builder, bool cameraMove)
		{
			builder.AddBool(1, cameraMove, false);
		}

		// Token: 0x0603431F RID: 213791 RVA: 0x00707E65 File Offset: 0x00706065
		public static void AddPlayAnimation(FlatBufferBuilder builder, bool playAnimation)
		{
			builder.AddBool(2, playAnimation, false);
		}

		// Token: 0x06034320 RID: 213792 RVA: 0x00707E70 File Offset: 0x00706070
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06034321 RID: 213793 RVA: 0x00707E7B File Offset: 0x0070607B
		public static Offset<IPlayerLookAt> EndIPlayerLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerLookAt>(builder.EndTable());
		}

		// Token: 0x06034322 RID: 213794 RVA: 0x00707E88 File Offset: 0x00706088
		public IPlayerLookAtT UnPack()
		{
			IPlayerLookAtT playerLookAtT = new IPlayerLookAtT();
			this.UnPackTo(playerLookAtT);
			return playerLookAtT;
		}

		// Token: 0x06034323 RID: 213795 RVA: 0x00707EA4 File Offset: 0x007060A4
		public void UnPackTo(IPlayerLookAtT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.CameraMove = this.CameraMove;
			_o.PlayAnimation = this.PlayAnimation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034324 RID: 213796 RVA: 0x00707F04 File Offset: 0x00706104
		public static Offset<IPlayerLookAt> Pack(FlatBufferBuilder builder, IPlayerLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerLookAt>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IPlayerLookAt.CreateIPlayerLookAt(builder, posOffset, _o.CameraMove, _o.PlayAnimation, _o.NullMask);
		}

		// Token: 0x040125F1 RID: 75249
		private Table __p;
	}
}
