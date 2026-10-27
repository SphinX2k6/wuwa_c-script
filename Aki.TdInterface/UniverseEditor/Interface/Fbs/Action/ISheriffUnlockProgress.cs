using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D0 RID: 28880
	public struct ISheriffUnlockProgress : IFlatbufferObject
	{
		// Token: 0x1700D683 RID: 54915
		// (get) Token: 0x06033264 RID: 209508 RVA: 0x006E57DD File Offset: 0x006E39DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033265 RID: 209509 RVA: 0x006E57EA File Offset: 0x006E39EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033266 RID: 209510 RVA: 0x006E57F4 File Offset: 0x006E39F4
		public static ISheriffUnlockProgress GetRootAsISheriffUnlockProgress(ByteBuffer _bb)
		{
			return ISheriffUnlockProgress.GetRootAsISheriffUnlockProgress(_bb, default(ISheriffUnlockProgress));
		}

		// Token: 0x06033267 RID: 209511 RVA: 0x006E5810 File Offset: 0x006E3A10
		public static ISheriffUnlockProgress GetRootAsISheriffUnlockProgress(ByteBuffer _bb, ISheriffUnlockProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033268 RID: 209512 RVA: 0x006E582D File Offset: 0x006E3A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033269 RID: 209513 RVA: 0x006E583C File Offset: 0x006E3A3C
		public ISheriffUnlockProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D684 RID: 54916
		// (get) Token: 0x0603326A RID: 209514 RVA: 0x006E584C File Offset: 0x006E3A4C
		public int ProgressId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603326B RID: 209515 RVA: 0x006E5888 File Offset: 0x006E3A88
		public static Offset<ISheriffUnlockProgress> CreateISheriffUnlockProgress(FlatBufferBuilder builder, int ProgressId = 0)
		{
			builder.StartTable(1);
			ISheriffUnlockProgress.AddProgressId(builder, ProgressId);
			return ISheriffUnlockProgress.EndISheriffUnlockProgress(builder);
		}

		// Token: 0x0603326C RID: 209516 RVA: 0x006E589E File Offset: 0x006E3A9E
		public static void StartISheriffUnlockProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603326D RID: 209517 RVA: 0x006E58A7 File Offset: 0x006E3AA7
		public static void AddProgressId(FlatBufferBuilder builder, int progressId)
		{
			builder.AddInt(0, progressId, 0);
		}

		// Token: 0x0603326E RID: 209518 RVA: 0x006E58B2 File Offset: 0x006E3AB2
		public static Offset<ISheriffUnlockProgress> EndISheriffUnlockProgress(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffUnlockProgress>(builder.EndTable());
		}

		// Token: 0x0603326F RID: 209519 RVA: 0x006E58C0 File Offset: 0x006E3AC0
		public ISheriffUnlockProgressT UnPack()
		{
			ISheriffUnlockProgressT sheriffUnlockProgressT = new ISheriffUnlockProgressT();
			this.UnPackTo(sheriffUnlockProgressT);
			return sheriffUnlockProgressT;
		}

		// Token: 0x06033270 RID: 209520 RVA: 0x006E58DB File Offset: 0x006E3ADB
		public void UnPackTo(ISheriffUnlockProgressT _o)
		{
			_o.ProgressId = this.ProgressId;
		}

		// Token: 0x06033271 RID: 209521 RVA: 0x006E58EC File Offset: 0x006E3AEC
		public static Offset<ISheriffUnlockProgress> Pack(FlatBufferBuilder builder, ISheriffUnlockProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffUnlockProgress>);
			}
			return ISheriffUnlockProgress.CreateISheriffUnlockProgress(builder, _o.ProgressId);
		}

		// Token: 0x04011B3D RID: 72509
		private Table __p;
	}
}
