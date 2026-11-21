using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007642 RID: 30274
	public struct IRestoreTrialCharacter : IFlatbufferObject
	{
		// Token: 0x1700DE5D RID: 56925
		// (get) Token: 0x060351F6 RID: 217590 RVA: 0x00722224 File Offset: 0x00720424
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060351F7 RID: 217591 RVA: 0x00722231 File Offset: 0x00720431
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060351F8 RID: 217592 RVA: 0x00722238 File Offset: 0x00720438
		public static IRestoreTrialCharacter GetRootAsIRestoreTrialCharacter(ByteBuffer _bb)
		{
			return IRestoreTrialCharacter.GetRootAsIRestoreTrialCharacter(_bb, default(IRestoreTrialCharacter));
		}

		// Token: 0x060351F9 RID: 217593 RVA: 0x00722254 File Offset: 0x00720454
		public static IRestoreTrialCharacter GetRootAsIRestoreTrialCharacter(ByteBuffer _bb, IRestoreTrialCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060351FA RID: 217594 RVA: 0x00722271 File Offset: 0x00720471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060351FB RID: 217595 RVA: 0x00722280 File Offset: 0x00720480
		public IRestoreTrialCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060351FC RID: 217596 RVA: 0x00722290 File Offset: 0x00720490
		public static void StartIRestoreTrialCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060351FD RID: 217597 RVA: 0x00722299 File Offset: 0x00720499
		public static Offset<IRestoreTrialCharacter> EndIRestoreTrialCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IRestoreTrialCharacter>(builder.EndTable());
		}

		// Token: 0x060351FE RID: 217598 RVA: 0x007222A8 File Offset: 0x007204A8
		public IRestoreTrialCharacterT UnPack()
		{
			IRestoreTrialCharacterT restoreTrialCharacterT = new IRestoreTrialCharacterT();
			this.UnPackTo(restoreTrialCharacterT);
			return restoreTrialCharacterT;
		}

		// Token: 0x060351FF RID: 217599 RVA: 0x007222C3 File Offset: 0x007204C3
		public void UnPackTo(IRestoreTrialCharacterT _o)
		{
		}

		// Token: 0x06035200 RID: 217600 RVA: 0x007222C8 File Offset: 0x007204C8
		public static Offset<IRestoreTrialCharacter> Pack(FlatBufferBuilder builder, IRestoreTrialCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRestoreTrialCharacter>);
			}
			IRestoreTrialCharacter.StartIRestoreTrialCharacter(builder);
			return IRestoreTrialCharacter.EndIRestoreTrialCharacter(builder);
		}

		// Token: 0x04012837 RID: 75831
		private Table __p;
	}
}
