using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2B RID: 23339
	public struct IMonsterNpcInteractionHook : IFlatbufferObject
	{
		// Token: 0x1700AA5A RID: 43610
		// (get) Token: 0x0602662A RID: 157226 RVA: 0x0054216D File Offset: 0x0054036D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602662B RID: 157227 RVA: 0x0054217A File Offset: 0x0054037A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602662C RID: 157228 RVA: 0x00542184 File Offset: 0x00540384
		public static IMonsterNpcInteractionHook GetRootAsIMonsterNpcInteractionHook(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionHook.GetRootAsIMonsterNpcInteractionHook(_bb, default(IMonsterNpcInteractionHook));
		}

		// Token: 0x0602662D RID: 157229 RVA: 0x005421A0 File Offset: 0x005403A0
		public static IMonsterNpcInteractionHook GetRootAsIMonsterNpcInteractionHook(ByteBuffer _bb, IMonsterNpcInteractionHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602662E RID: 157230 RVA: 0x005421BD File Offset: 0x005403BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602662F RID: 157231 RVA: 0x005421CC File Offset: 0x005403CC
		public IMonsterNpcInteractionHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA5B RID: 43611
		// (get) Token: 0x06026630 RID: 157232 RVA: 0x005421DC File Offset: 0x005403DC
		public EMonsterNpcInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return (EMonsterNpcInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026631 RID: 157233 RVA: 0x00542218 File Offset: 0x00540418
		public static Offset<IMonsterNpcInteractionHook> CreateIMonsterNpcInteractionHook(FlatBufferBuilder builder, EMonsterNpcInteractionType Type = EMonsterNpcInteractionType.WallRun)
		{
			builder.StartTable(1);
			IMonsterNpcInteractionHook.AddType(builder, Type);
			return IMonsterNpcInteractionHook.EndIMonsterNpcInteractionHook(builder);
		}

		// Token: 0x06026632 RID: 157234 RVA: 0x0054222E File Offset: 0x0054042E
		public static void StartIMonsterNpcInteractionHook(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026633 RID: 157235 RVA: 0x00542237 File Offset: 0x00540437
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026634 RID: 157236 RVA: 0x00542242 File Offset: 0x00540442
		public static Offset<IMonsterNpcInteractionHook> EndIMonsterNpcInteractionHook(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionHook>(builder.EndTable());
		}

		// Token: 0x06026635 RID: 157237 RVA: 0x00542250 File Offset: 0x00540450
		public IMonsterNpcInteractionHookT UnPack()
		{
			IMonsterNpcInteractionHookT monsterNpcInteractionHookT = new IMonsterNpcInteractionHookT();
			this.UnPackTo(monsterNpcInteractionHookT);
			return monsterNpcInteractionHookT;
		}

		// Token: 0x06026636 RID: 157238 RVA: 0x0054226B File Offset: 0x0054046B
		public void UnPackTo(IMonsterNpcInteractionHookT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026637 RID: 157239 RVA: 0x0054227C File Offset: 0x0054047C
		public static Offset<IMonsterNpcInteractionHook> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionHook>);
			}
			return IMonsterNpcInteractionHook.CreateIMonsterNpcInteractionHook(builder, _o.Type);
		}

		// Token: 0x0400F521 RID: 62753
		private Table __p;
	}
}
