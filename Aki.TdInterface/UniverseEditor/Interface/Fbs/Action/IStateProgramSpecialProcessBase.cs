using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C0 RID: 29120
	public struct IStateProgramSpecialProcessBase : IFlatbufferObject
	{
		// Token: 0x1700D865 RID: 55397
		// (get) Token: 0x06033A94 RID: 211604 RVA: 0x006F513E File Offset: 0x006F333E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033A95 RID: 211605 RVA: 0x006F514B File Offset: 0x006F334B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033A96 RID: 211606 RVA: 0x006F5154 File Offset: 0x006F3354
		public static IStateProgramSpecialProcessBase GetRootAsIStateProgramSpecialProcessBase(ByteBuffer _bb)
		{
			return IStateProgramSpecialProcessBase.GetRootAsIStateProgramSpecialProcessBase(_bb, default(IStateProgramSpecialProcessBase));
		}

		// Token: 0x06033A97 RID: 211607 RVA: 0x006F5170 File Offset: 0x006F3370
		public static IStateProgramSpecialProcessBase GetRootAsIStateProgramSpecialProcessBase(ByteBuffer _bb, IStateProgramSpecialProcessBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033A98 RID: 211608 RVA: 0x006F518D File Offset: 0x006F338D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033A99 RID: 211609 RVA: 0x006F519C File Offset: 0x006F339C
		public IStateProgramSpecialProcessBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D866 RID: 55398
		// (get) Token: 0x06033A9A RID: 211610 RVA: 0x006F51AC File Offset: 0x006F33AC
		public ELogicProgramSpecialProcess Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELogicProgramSpecialProcess.ChangeTeamOptimization;
				}
				return (ELogicProgramSpecialProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033A9B RID: 211611 RVA: 0x006F51E8 File Offset: 0x006F33E8
		public static Offset<IStateProgramSpecialProcessBase> CreateIStateProgramSpecialProcessBase(FlatBufferBuilder builder, ELogicProgramSpecialProcess Type = ELogicProgramSpecialProcess.ChangeTeamOptimization)
		{
			builder.StartTable(1);
			IStateProgramSpecialProcessBase.AddType(builder, Type);
			return IStateProgramSpecialProcessBase.EndIStateProgramSpecialProcessBase(builder);
		}

		// Token: 0x06033A9C RID: 211612 RVA: 0x006F51FE File Offset: 0x006F33FE
		public static void StartIStateProgramSpecialProcessBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033A9D RID: 211613 RVA: 0x006F5207 File Offset: 0x006F3407
		public static void AddType(FlatBufferBuilder builder, ELogicProgramSpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033A9E RID: 211614 RVA: 0x006F5212 File Offset: 0x006F3412
		public static Offset<IStateProgramSpecialProcessBase> EndIStateProgramSpecialProcessBase(FlatBufferBuilder builder)
		{
			return new Offset<IStateProgramSpecialProcessBase>(builder.EndTable());
		}

		// Token: 0x06033A9F RID: 211615 RVA: 0x006F5220 File Offset: 0x006F3420
		public IStateProgramSpecialProcessBaseT UnPack()
		{
			IStateProgramSpecialProcessBaseT stateProgramSpecialProcessBaseT = new IStateProgramSpecialProcessBaseT();
			this.UnPackTo(stateProgramSpecialProcessBaseT);
			return stateProgramSpecialProcessBaseT;
		}

		// Token: 0x06033AA0 RID: 211616 RVA: 0x006F523B File Offset: 0x006F343B
		public void UnPackTo(IStateProgramSpecialProcessBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033AA1 RID: 211617 RVA: 0x006F524C File Offset: 0x006F344C
		public static Offset<IStateProgramSpecialProcessBase> Pack(FlatBufferBuilder builder, IStateProgramSpecialProcessBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateProgramSpecialProcessBase>);
			}
			return IStateProgramSpecialProcessBase.CreateIStateProgramSpecialProcessBase(builder, _o.Type);
		}

		// Token: 0x04011CA1 RID: 72865
		private Table __p;
	}
}
