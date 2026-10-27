using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EBE RID: 28350
	public struct IRestoreTrialCharacter : IFlatbufferObject
	{
		// Token: 0x1700D306 RID: 54022
		// (get) Token: 0x060321B6 RID: 205238 RVA: 0x006C64F0 File Offset: 0x006C46F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060321B7 RID: 205239 RVA: 0x006C64FD File Offset: 0x006C46FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060321B8 RID: 205240 RVA: 0x006C6504 File Offset: 0x006C4704
		public static IRestoreTrialCharacter GetRootAsIRestoreTrialCharacter(ByteBuffer _bb)
		{
			return IRestoreTrialCharacter.GetRootAsIRestoreTrialCharacter(_bb, default(IRestoreTrialCharacter));
		}

		// Token: 0x060321B9 RID: 205241 RVA: 0x006C6520 File Offset: 0x006C4720
		public static IRestoreTrialCharacter GetRootAsIRestoreTrialCharacter(ByteBuffer _bb, IRestoreTrialCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060321BA RID: 205242 RVA: 0x006C653D File Offset: 0x006C473D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060321BB RID: 205243 RVA: 0x006C654C File Offset: 0x006C474C
		public IRestoreTrialCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060321BC RID: 205244 RVA: 0x006C655C File Offset: 0x006C475C
		public static void StartIRestoreTrialCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060321BD RID: 205245 RVA: 0x006C6565 File Offset: 0x006C4765
		public static Offset<IRestoreTrialCharacter> EndIRestoreTrialCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IRestoreTrialCharacter>(builder.EndTable());
		}

		// Token: 0x060321BE RID: 205246 RVA: 0x006C6574 File Offset: 0x006C4774
		public IRestoreTrialCharacterT UnPack()
		{
			IRestoreTrialCharacterT restoreTrialCharacterT = new IRestoreTrialCharacterT();
			this.UnPackTo(restoreTrialCharacterT);
			return restoreTrialCharacterT;
		}

		// Token: 0x060321BF RID: 205247 RVA: 0x006C658F File Offset: 0x006C478F
		public void UnPackTo(IRestoreTrialCharacterT _o)
		{
		}

		// Token: 0x060321C0 RID: 205248 RVA: 0x006C6594 File Offset: 0x006C4794
		public static Offset<IRestoreTrialCharacter> Pack(FlatBufferBuilder builder, IRestoreTrialCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRestoreTrialCharacter>);
			}
			IRestoreTrialCharacter.StartIRestoreTrialCharacter(builder);
			return IRestoreTrialCharacter.EndIRestoreTrialCharacter(builder);
		}

		// Token: 0x040118B2 RID: 71858
		private Table __p;
	}
}
