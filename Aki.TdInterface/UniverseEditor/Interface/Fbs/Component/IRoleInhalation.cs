using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005876 RID: 22646
	public struct IRoleInhalation : IFlatbufferObject
	{
		// Token: 0x1700A963 RID: 43363
		// (get) Token: 0x06026286 RID: 156294 RVA: 0x00542E2A File Offset: 0x0054102A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026287 RID: 156295 RVA: 0x00542E37 File Offset: 0x00541037
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026288 RID: 156296 RVA: 0x00542E40 File Offset: 0x00541040
		public static IRoleInhalation GetRootAsIRoleInhalation(ByteBuffer _bb)
		{
			return IRoleInhalation.GetRootAsIRoleInhalation(_bb, default(IRoleInhalation));
		}

		// Token: 0x06026289 RID: 156297 RVA: 0x00542E5C File Offset: 0x0054105C
		public static IRoleInhalation GetRootAsIRoleInhalation(ByteBuffer _bb, IRoleInhalation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602628A RID: 156298 RVA: 0x00542E79 File Offset: 0x00541079
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602628B RID: 156299 RVA: 0x00542E88 File Offset: 0x00541088
		public IRoleInhalation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A964 RID: 43364
		// (get) Token: 0x0602628C RID: 156300 RVA: 0x00542E98 File Offset: 0x00541098
		public EInhalationPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInhalationPerformanceType.Role;
				}
				return (EInhalationPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602628D RID: 156301 RVA: 0x00542ED4 File Offset: 0x005410D4
		public static Offset<IRoleInhalation> CreateIRoleInhalation(FlatBufferBuilder builder, EInhalationPerformanceType Type = EInhalationPerformanceType.Role)
		{
			builder.StartTable(1);
			IRoleInhalation.AddType(builder, Type);
			return IRoleInhalation.EndIRoleInhalation(builder);
		}

		// Token: 0x0602628E RID: 156302 RVA: 0x00542EEA File Offset: 0x005410EA
		public static void StartIRoleInhalation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602628F RID: 156303 RVA: 0x00542EF3 File Offset: 0x005410F3
		public static void AddType(FlatBufferBuilder builder, EInhalationPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026290 RID: 156304 RVA: 0x00542EFE File Offset: 0x005410FE
		public static Offset<IRoleInhalation> EndIRoleInhalation(FlatBufferBuilder builder)
		{
			return new Offset<IRoleInhalation>(builder.EndTable());
		}

		// Token: 0x06026291 RID: 156305 RVA: 0x00542F0C File Offset: 0x0054110C
		public IRoleInhalationT UnPack()
		{
			IRoleInhalationT roleInhalationT = new IRoleInhalationT();
			this.UnPackTo(roleInhalationT);
			return roleInhalationT;
		}

		// Token: 0x06026292 RID: 156306 RVA: 0x00542F27 File Offset: 0x00541127
		public void UnPackTo(IRoleInhalationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026293 RID: 156307 RVA: 0x00542F38 File Offset: 0x00541138
		public static Offset<IRoleInhalation> Pack(FlatBufferBuilder builder, IRoleInhalationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleInhalation>);
			}
			return IRoleInhalation.CreateIRoleInhalation(builder, _o.Type);
		}

		// Token: 0x0400EDBF RID: 60863
		private Table __p;
	}
}
