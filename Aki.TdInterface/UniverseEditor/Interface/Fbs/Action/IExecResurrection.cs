using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D91 RID: 28049
	public struct IExecResurrection : IFlatbufferObject
	{
		// Token: 0x1700CDB6 RID: 52662
		// (get) Token: 0x06030689 RID: 198281 RVA: 0x00693F0C File Offset: 0x0069210C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603068A RID: 198282 RVA: 0x00693F19 File Offset: 0x00692119
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603068B RID: 198283 RVA: 0x00693F20 File Offset: 0x00692120
		public static IExecResurrection GetRootAsIExecResurrection(ByteBuffer _bb)
		{
			return IExecResurrection.GetRootAsIExecResurrection(_bb, default(IExecResurrection));
		}

		// Token: 0x0603068C RID: 198284 RVA: 0x00693F3C File Offset: 0x0069213C
		public static IExecResurrection GetRootAsIExecResurrection(ByteBuffer _bb, IExecResurrection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603068D RID: 198285 RVA: 0x00693F59 File Offset: 0x00692159
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603068E RID: 198286 RVA: 0x00693F68 File Offset: 0x00692168
		public IExecResurrection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDB7 RID: 52663
		// (get) Token: 0x0603068F RID: 198287 RVA: 0x00693F78 File Offset: 0x00692178
		public int ReviveId
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

		// Token: 0x06030690 RID: 198288 RVA: 0x00693FB4 File Offset: 0x006921B4
		public static Offset<IExecResurrection> CreateIExecResurrection(FlatBufferBuilder builder, int ReviveId = 0)
		{
			builder.StartTable(1);
			IExecResurrection.AddReviveId(builder, ReviveId);
			return IExecResurrection.EndIExecResurrection(builder);
		}

		// Token: 0x06030691 RID: 198289 RVA: 0x00693FCA File Offset: 0x006921CA
		public static void StartIExecResurrection(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030692 RID: 198290 RVA: 0x00693FD3 File Offset: 0x006921D3
		public static void AddReviveId(FlatBufferBuilder builder, int reviveId)
		{
			builder.AddInt(0, reviveId, 0);
		}

		// Token: 0x06030693 RID: 198291 RVA: 0x00693FDE File Offset: 0x006921DE
		public static Offset<IExecResurrection> EndIExecResurrection(FlatBufferBuilder builder)
		{
			return new Offset<IExecResurrection>(builder.EndTable());
		}

		// Token: 0x06030694 RID: 198292 RVA: 0x00693FEC File Offset: 0x006921EC
		public IExecResurrectionT UnPack()
		{
			IExecResurrectionT execResurrectionT = new IExecResurrectionT();
			this.UnPackTo(execResurrectionT);
			return execResurrectionT;
		}

		// Token: 0x06030695 RID: 198293 RVA: 0x00694007 File Offset: 0x00692207
		public void UnPackTo(IExecResurrectionT _o)
		{
			_o.ReviveId = this.ReviveId;
		}

		// Token: 0x06030696 RID: 198294 RVA: 0x00694018 File Offset: 0x00692218
		public static Offset<IExecResurrection> Pack(FlatBufferBuilder builder, IExecResurrectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecResurrection>);
			}
			return IExecResurrection.CreateIExecResurrection(builder, _o.ReviveId);
		}

		// Token: 0x04011C2A RID: 72746
		private Table __p;
	}
}
