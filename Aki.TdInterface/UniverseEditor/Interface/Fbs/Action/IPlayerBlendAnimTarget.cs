using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CED RID: 27885
	public struct IPlayerBlendAnimTarget : IFlatbufferObject
	{
		// Token: 0x1700CFB1 RID: 53169
		// (get) Token: 0x060312BB RID: 201403 RVA: 0x006ABEEA File Offset: 0x006AA0EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060312BC RID: 201404 RVA: 0x006ABEF7 File Offset: 0x006AA0F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060312BD RID: 201405 RVA: 0x006ABF00 File Offset: 0x006AA100
		public static IPlayerBlendAnimTarget GetRootAsIPlayerBlendAnimTarget(ByteBuffer _bb)
		{
			return IPlayerBlendAnimTarget.GetRootAsIPlayerBlendAnimTarget(_bb, default(IPlayerBlendAnimTarget));
		}

		// Token: 0x060312BE RID: 201406 RVA: 0x006ABF1C File Offset: 0x006AA11C
		public static IPlayerBlendAnimTarget GetRootAsIPlayerBlendAnimTarget(ByteBuffer _bb, IPlayerBlendAnimTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060312BF RID: 201407 RVA: 0x006ABF39 File Offset: 0x006AA139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060312C0 RID: 201408 RVA: 0x006ABF48 File Offset: 0x006AA148
		public IPlayerBlendAnimTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFB2 RID: 53170
		// (get) Token: 0x060312C1 RID: 201409 RVA: 0x006ABF58 File Offset: 0x006AA158
		public EBlendAnimTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlendAnimTarget.Player;
				}
				return (EBlendAnimTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060312C2 RID: 201410 RVA: 0x006ABF94 File Offset: 0x006AA194
		public static Offset<IPlayerBlendAnimTarget> CreateIPlayerBlendAnimTarget(FlatBufferBuilder builder, EBlendAnimTarget Type = EBlendAnimTarget.Player)
		{
			builder.StartTable(1);
			IPlayerBlendAnimTarget.AddType(builder, Type);
			return IPlayerBlendAnimTarget.EndIPlayerBlendAnimTarget(builder);
		}

		// Token: 0x060312C3 RID: 201411 RVA: 0x006ABFAA File Offset: 0x006AA1AA
		public static void StartIPlayerBlendAnimTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060312C4 RID: 201412 RVA: 0x006ABFB3 File Offset: 0x006AA1B3
		public static void AddType(FlatBufferBuilder builder, EBlendAnimTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060312C5 RID: 201413 RVA: 0x006ABFBE File Offset: 0x006AA1BE
		public static Offset<IPlayerBlendAnimTarget> EndIPlayerBlendAnimTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerBlendAnimTarget>(builder.EndTable());
		}

		// Token: 0x060312C6 RID: 201414 RVA: 0x006ABFCC File Offset: 0x006AA1CC
		public IPlayerBlendAnimTargetT UnPack()
		{
			IPlayerBlendAnimTargetT playerBlendAnimTargetT = new IPlayerBlendAnimTargetT();
			this.UnPackTo(playerBlendAnimTargetT);
			return playerBlendAnimTargetT;
		}

		// Token: 0x060312C7 RID: 201415 RVA: 0x006ABFE7 File Offset: 0x006AA1E7
		public void UnPackTo(IPlayerBlendAnimTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060312C8 RID: 201416 RVA: 0x006ABFF8 File Offset: 0x006AA1F8
		public static Offset<IPlayerBlendAnimTarget> Pack(FlatBufferBuilder builder, IPlayerBlendAnimTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerBlendAnimTarget>);
			}
			return IPlayerBlendAnimTarget.CreateIPlayerBlendAnimTarget(builder, _o.Type);
		}

		// Token: 0x0401166B RID: 71275
		private Table __p;
	}
}
