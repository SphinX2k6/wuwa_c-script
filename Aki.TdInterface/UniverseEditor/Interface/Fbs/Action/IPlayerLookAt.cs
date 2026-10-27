using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CFC RID: 27900
	public struct IPlayerLookAt : IFlatbufferObject
	{
		// Token: 0x1700CFC4 RID: 53188
		// (get) Token: 0x0603131D RID: 201501 RVA: 0x006AC759 File Offset: 0x006AA959
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603131E RID: 201502 RVA: 0x006AC766 File Offset: 0x006AA966
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603131F RID: 201503 RVA: 0x006AC770 File Offset: 0x006AA970
		public static IPlayerLookAt GetRootAsIPlayerLookAt(ByteBuffer _bb)
		{
			return IPlayerLookAt.GetRootAsIPlayerLookAt(_bb, default(IPlayerLookAt));
		}

		// Token: 0x06031320 RID: 201504 RVA: 0x006AC78C File Offset: 0x006AA98C
		public static IPlayerLookAt GetRootAsIPlayerLookAt(ByteBuffer _bb, IPlayerLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031321 RID: 201505 RVA: 0x006AC7A9 File Offset: 0x006AA9A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031322 RID: 201506 RVA: 0x006AC7B8 File Offset: 0x006AA9B8
		public IPlayerLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFC5 RID: 53189
		// (get) Token: 0x06031323 RID: 201507 RVA: 0x006AC7C8 File Offset: 0x006AA9C8
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

		// Token: 0x1700CFC6 RID: 53190
		// (get) Token: 0x06031324 RID: 201508 RVA: 0x006AC828 File Offset: 0x006AAA28
		public bool CameraMove
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CFC7 RID: 53191
		// (get) Token: 0x06031325 RID: 201509 RVA: 0x006AC868 File Offset: 0x006AAA68
		public bool PlayAnimation
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CFC8 RID: 53192
		// (get) Token: 0x06031326 RID: 201510 RVA: 0x006AC8A8 File Offset: 0x006AAAA8
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

		// Token: 0x06031327 RID: 201511 RVA: 0x006AC8E5 File Offset: 0x006AAAE5
		public static Offset<IPlayerLookAt> CreateIPlayerLookAt(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), bool CameraMove = false, bool PlayAnimation = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPlayerLookAt.AddPos(builder, PosOffset);
			IPlayerLookAt.AddNullMask(builder, NullMask);
			IPlayerLookAt.AddPlayAnimation(builder, PlayAnimation);
			IPlayerLookAt.AddCameraMove(builder, CameraMove);
			return IPlayerLookAt.EndIPlayerLookAt(builder);
		}

		// Token: 0x06031328 RID: 201512 RVA: 0x006AC911 File Offset: 0x006AAB11
		public static void StartIPlayerLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031329 RID: 201513 RVA: 0x006AC91A File Offset: 0x006AAB1A
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0603132A RID: 201514 RVA: 0x006AC92A File Offset: 0x006AAB2A
		public static void AddCameraMove(FlatBufferBuilder builder, bool cameraMove)
		{
			builder.AddBool(1, cameraMove, false);
		}

		// Token: 0x0603132B RID: 201515 RVA: 0x006AC935 File Offset: 0x006AAB35
		public static void AddPlayAnimation(FlatBufferBuilder builder, bool playAnimation)
		{
			builder.AddBool(2, playAnimation, false);
		}

		// Token: 0x0603132C RID: 201516 RVA: 0x006AC940 File Offset: 0x006AAB40
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603132D RID: 201517 RVA: 0x006AC94B File Offset: 0x006AAB4B
		public static Offset<IPlayerLookAt> EndIPlayerLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerLookAt>(builder.EndTable());
		}

		// Token: 0x0603132E RID: 201518 RVA: 0x006AC958 File Offset: 0x006AAB58
		public IPlayerLookAtT UnPack()
		{
			IPlayerLookAtT playerLookAtT = new IPlayerLookAtT();
			this.UnPackTo(playerLookAtT);
			return playerLookAtT;
		}

		// Token: 0x0603132F RID: 201519 RVA: 0x006AC974 File Offset: 0x006AAB74
		public void UnPackTo(IPlayerLookAtT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.CameraMove = this.CameraMove;
			_o.PlayAnimation = this.PlayAnimation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031330 RID: 201520 RVA: 0x006AC9D4 File Offset: 0x006AABD4
		public static Offset<IPlayerLookAt> Pack(FlatBufferBuilder builder, IPlayerLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerLookAt>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IPlayerLookAt.CreateIPlayerLookAt(builder, posOffset, _o.CameraMove, _o.PlayAnimation, _o.NullMask);
		}

		// Token: 0x04011677 RID: 71287
		private Table __p;
	}
}
