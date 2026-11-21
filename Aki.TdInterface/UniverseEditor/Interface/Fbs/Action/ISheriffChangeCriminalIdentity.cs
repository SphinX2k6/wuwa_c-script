using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007887 RID: 30855
	public struct ISheriffChangeCriminalIdentity : IFlatbufferObject
	{
		// Token: 0x1700E247 RID: 57927
		// (get) Token: 0x06036474 RID: 222324 RVA: 0x007450F9 File Offset: 0x007432F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036475 RID: 222325 RVA: 0x00745106 File Offset: 0x00743306
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036476 RID: 222326 RVA: 0x00745110 File Offset: 0x00743310
		public static ISheriffChangeCriminalIdentity GetRootAsISheriffChangeCriminalIdentity(ByteBuffer _bb)
		{
			return ISheriffChangeCriminalIdentity.GetRootAsISheriffChangeCriminalIdentity(_bb, default(ISheriffChangeCriminalIdentity));
		}

		// Token: 0x06036477 RID: 222327 RVA: 0x0074512C File Offset: 0x0074332C
		public static ISheriffChangeCriminalIdentity GetRootAsISheriffChangeCriminalIdentity(ByteBuffer _bb, ISheriffChangeCriminalIdentity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036478 RID: 222328 RVA: 0x00745149 File Offset: 0x00743349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036479 RID: 222329 RVA: 0x00745158 File Offset: 0x00743358
		public ISheriffChangeCriminalIdentity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E248 RID: 57928
		// (get) Token: 0x0603647A RID: 222330 RVA: 0x00745168 File Offset: 0x00743368
		public int CriminalId
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

		// Token: 0x1700E249 RID: 57929
		// (get) Token: 0x0603647B RID: 222331 RVA: 0x007451A4 File Offset: 0x007433A4
		public int IdentityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603647C RID: 222332 RVA: 0x007451E0 File Offset: 0x007433E0
		public static Offset<ISheriffChangeCriminalIdentity> CreateISheriffChangeCriminalIdentity(FlatBufferBuilder builder, int CriminalId = 0, int IdentityId = 0)
		{
			builder.StartTable(2);
			ISheriffChangeCriminalIdentity.AddIdentityId(builder, IdentityId);
			ISheriffChangeCriminalIdentity.AddCriminalId(builder, CriminalId);
			return ISheriffChangeCriminalIdentity.EndISheriffChangeCriminalIdentity(builder);
		}

		// Token: 0x0603647D RID: 222333 RVA: 0x007451FD File Offset: 0x007433FD
		public static void StartISheriffChangeCriminalIdentity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603647E RID: 222334 RVA: 0x00745206 File Offset: 0x00743406
		public static void AddCriminalId(FlatBufferBuilder builder, int criminalId)
		{
			builder.AddInt(0, criminalId, 0);
		}

		// Token: 0x0603647F RID: 222335 RVA: 0x00745211 File Offset: 0x00743411
		public static void AddIdentityId(FlatBufferBuilder builder, int identityId)
		{
			builder.AddInt(1, identityId, 0);
		}

		// Token: 0x06036480 RID: 222336 RVA: 0x0074521C File Offset: 0x0074341C
		public static Offset<ISheriffChangeCriminalIdentity> EndISheriffChangeCriminalIdentity(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffChangeCriminalIdentity>(builder.EndTable());
		}

		// Token: 0x06036481 RID: 222337 RVA: 0x0074522C File Offset: 0x0074342C
		public ISheriffChangeCriminalIdentityT UnPack()
		{
			ISheriffChangeCriminalIdentityT sheriffChangeCriminalIdentityT = new ISheriffChangeCriminalIdentityT();
			this.UnPackTo(sheriffChangeCriminalIdentityT);
			return sheriffChangeCriminalIdentityT;
		}

		// Token: 0x06036482 RID: 222338 RVA: 0x00745247 File Offset: 0x00743447
		public void UnPackTo(ISheriffChangeCriminalIdentityT _o)
		{
			_o.CriminalId = this.CriminalId;
			_o.IdentityId = this.IdentityId;
		}

		// Token: 0x06036483 RID: 222339 RVA: 0x00745264 File Offset: 0x00743464
		public static Offset<ISheriffChangeCriminalIdentity> Pack(FlatBufferBuilder builder, ISheriffChangeCriminalIdentityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffChangeCriminalIdentity>);
			}
			return ISheriffChangeCriminalIdentity.CreateISheriffChangeCriminalIdentity(builder, _o.CriminalId, _o.IdentityId);
		}

		// Token: 0x04012B18 RID: 76568
		private Table __p;
	}
}
