using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F8F RID: 16271
	public struct IPhotographTarget : IFlatbufferObject
	{
		// Token: 0x17007195 RID: 29077
		// (get) Token: 0x060173CC RID: 95180 RVA: 0x0035A248 File Offset: 0x00358448
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060173CD RID: 95181 RVA: 0x0035A255 File Offset: 0x00358455
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060173CE RID: 95182 RVA: 0x0035A25C File Offset: 0x0035845C
		public static IPhotographTarget GetRootAsIPhotographTarget(ByteBuffer _bb)
		{
			return IPhotographTarget.GetRootAsIPhotographTarget(_bb, default(IPhotographTarget));
		}

		// Token: 0x060173CF RID: 95183 RVA: 0x0035A278 File Offset: 0x00358478
		public static IPhotographTarget GetRootAsIPhotographTarget(ByteBuffer _bb, IPhotographTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060173D0 RID: 95184 RVA: 0x0035A295 File Offset: 0x00358495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060173D1 RID: 95185 RVA: 0x0035A2A4 File Offset: 0x003584A4
		public IPhotographTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007196 RID: 29078
		// (get) Token: 0x060173D2 RID: 95186 RVA: 0x0035A2B4 File Offset: 0x003584B4
		public EPhotographTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographTargetType.Player;
				}
				return (EPhotographTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060173D3 RID: 95187 RVA: 0x0035A2F0 File Offset: 0x003584F0
		public static Offset<IPhotographTarget> CreateIPhotographTarget(FlatBufferBuilder builder, EPhotographTargetType Type = EPhotographTargetType.Player)
		{
			builder.StartTable(1);
			IPhotographTarget.AddType(builder, Type);
			return IPhotographTarget.EndIPhotographTarget(builder);
		}

		// Token: 0x060173D4 RID: 95188 RVA: 0x0035A306 File Offset: 0x00358506
		public static void StartIPhotographTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060173D5 RID: 95189 RVA: 0x0035A30F File Offset: 0x0035850F
		public static void AddType(FlatBufferBuilder builder, EPhotographTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060173D6 RID: 95190 RVA: 0x0035A31A File Offset: 0x0035851A
		public static Offset<IPhotographTarget> EndIPhotographTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographTarget>(builder.EndTable());
		}

		// Token: 0x060173D7 RID: 95191 RVA: 0x0035A328 File Offset: 0x00358528
		public IPhotographTargetT UnPack()
		{
			IPhotographTargetT photographTargetT = new IPhotographTargetT();
			this.UnPackTo(photographTargetT);
			return photographTargetT;
		}

		// Token: 0x060173D8 RID: 95192 RVA: 0x0035A343 File Offset: 0x00358543
		public void UnPackTo(IPhotographTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060173D9 RID: 95193 RVA: 0x0035A354 File Offset: 0x00358554
		public static Offset<IPhotographTarget> Pack(FlatBufferBuilder builder, IPhotographTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographTarget>);
			}
			return IPhotographTarget.CreateIPhotographTarget(builder, _o.Type);
		}

		// Token: 0x0400B9ED RID: 47597
		private Table __p;
	}
}
