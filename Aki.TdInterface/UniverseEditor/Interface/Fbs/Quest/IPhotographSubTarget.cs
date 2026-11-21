using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043C4 RID: 17348
	public struct IPhotographSubTarget : IFlatbufferObject
	{
		// Token: 0x1700777C RID: 30588
		// (get) Token: 0x060189FF RID: 100863 RVA: 0x0038345A File Offset: 0x0038165A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018A00 RID: 100864 RVA: 0x00383467 File Offset: 0x00381667
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018A01 RID: 100865 RVA: 0x00383470 File Offset: 0x00381670
		public static IPhotographSubTarget GetRootAsIPhotographSubTarget(ByteBuffer _bb)
		{
			return IPhotographSubTarget.GetRootAsIPhotographSubTarget(_bb, default(IPhotographSubTarget));
		}

		// Token: 0x06018A02 RID: 100866 RVA: 0x0038348C File Offset: 0x0038168C
		public static IPhotographSubTarget GetRootAsIPhotographSubTarget(ByteBuffer _bb, IPhotographSubTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018A03 RID: 100867 RVA: 0x003834A9 File Offset: 0x003816A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018A04 RID: 100868 RVA: 0x003834B8 File Offset: 0x003816B8
		public IPhotographSubTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700777D RID: 30589
		// (get) Token: 0x06018A05 RID: 100869 RVA: 0x003834C8 File Offset: 0x003816C8
		public EPhotographSubTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographSubTargetType.SpecificRole;
				}
				return (EPhotographSubTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018A06 RID: 100870 RVA: 0x00383504 File Offset: 0x00381704
		public static Offset<IPhotographSubTarget> CreateIPhotographSubTarget(FlatBufferBuilder builder, EPhotographSubTargetType Type = EPhotographSubTargetType.SpecificRole)
		{
			builder.StartTable(1);
			IPhotographSubTarget.AddType(builder, Type);
			return IPhotographSubTarget.EndIPhotographSubTarget(builder);
		}

		// Token: 0x06018A07 RID: 100871 RVA: 0x0038351A File Offset: 0x0038171A
		public static void StartIPhotographSubTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018A08 RID: 100872 RVA: 0x00383523 File Offset: 0x00381723
		public static void AddType(FlatBufferBuilder builder, EPhotographSubTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018A09 RID: 100873 RVA: 0x0038352E File Offset: 0x0038172E
		public static Offset<IPhotographSubTarget> EndIPhotographSubTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographSubTarget>(builder.EndTable());
		}

		// Token: 0x06018A0A RID: 100874 RVA: 0x0038353C File Offset: 0x0038173C
		public IPhotographSubTargetT UnPack()
		{
			IPhotographSubTargetT photographSubTargetT = new IPhotographSubTargetT();
			this.UnPackTo(photographSubTargetT);
			return photographSubTargetT;
		}

		// Token: 0x06018A0B RID: 100875 RVA: 0x00383557 File Offset: 0x00381757
		public void UnPackTo(IPhotographSubTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018A0C RID: 100876 RVA: 0x00383568 File Offset: 0x00381768
		public static Offset<IPhotographSubTarget> Pack(FlatBufferBuilder builder, IPhotographSubTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographSubTarget>);
			}
			return IPhotographSubTarget.CreateIPhotographSubTarget(builder, _o.Type);
		}

		// Token: 0x0400C3BF RID: 50111
		private Table __p;
	}
}
