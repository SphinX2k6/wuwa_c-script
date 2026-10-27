using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A67 RID: 23143
	public struct IThrowMotion : IFlatbufferObject
	{
		// Token: 0x1700AE29 RID: 44585
		// (get) Token: 0x06027623 RID: 161315 RVA: 0x0056B788 File Offset: 0x00569988
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027624 RID: 161316 RVA: 0x0056B795 File Offset: 0x00569995
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027625 RID: 161317 RVA: 0x0056B79C File Offset: 0x0056999C
		public static IThrowMotion GetRootAsIThrowMotion(ByteBuffer _bb)
		{
			return IThrowMotion.GetRootAsIThrowMotion(_bb, default(IThrowMotion));
		}

		// Token: 0x06027626 RID: 161318 RVA: 0x0056B7B8 File Offset: 0x005699B8
		public static IThrowMotion GetRootAsIThrowMotion(ByteBuffer _bb, IThrowMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027627 RID: 161319 RVA: 0x0056B7D5 File Offset: 0x005699D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027628 RID: 161320 RVA: 0x0056B7E4 File Offset: 0x005699E4
		public IThrowMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE2A RID: 44586
		// (get) Token: 0x06027629 RID: 161321 RVA: 0x0056B7F4 File Offset: 0x005699F4
		public EThrowMotion Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EThrowMotion.Projectile;
				}
				return (EThrowMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602762A RID: 161322 RVA: 0x0056B830 File Offset: 0x00569A30
		public static Offset<IThrowMotion> CreateIThrowMotion(FlatBufferBuilder builder, EThrowMotion Type = EThrowMotion.Projectile)
		{
			builder.StartTable(1);
			IThrowMotion.AddType(builder, Type);
			return IThrowMotion.EndIThrowMotion(builder);
		}

		// Token: 0x0602762B RID: 161323 RVA: 0x0056B846 File Offset: 0x00569A46
		public static void StartIThrowMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602762C RID: 161324 RVA: 0x0056B84F File Offset: 0x00569A4F
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602762D RID: 161325 RVA: 0x0056B85A File Offset: 0x00569A5A
		public static Offset<IThrowMotion> EndIThrowMotion(FlatBufferBuilder builder)
		{
			return new Offset<IThrowMotion>(builder.EndTable());
		}

		// Token: 0x0602762E RID: 161326 RVA: 0x0056B868 File Offset: 0x00569A68
		public IThrowMotionT UnPack()
		{
			IThrowMotionT throwMotionT = new IThrowMotionT();
			this.UnPackTo(throwMotionT);
			return throwMotionT;
		}

		// Token: 0x0602762F RID: 161327 RVA: 0x0056B883 File Offset: 0x00569A83
		public void UnPackTo(IThrowMotionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027630 RID: 161328 RVA: 0x0056B894 File Offset: 0x00569A94
		public static Offset<IThrowMotion> Pack(FlatBufferBuilder builder, IThrowMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowMotion>);
			}
			return IThrowMotion.CreateIThrowMotion(builder, _o.Type);
		}

		// Token: 0x0400F0F9 RID: 61689
		private Table __p;
	}
}
