using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006074 RID: 24692
	public struct IThrowMotion : IFlatbufferObject
	{
		// Token: 0x1700B761 RID: 46945
		// (get) Token: 0x06029B9B RID: 170907 RVA: 0x005B2794 File Offset: 0x005B0994
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029B9C RID: 170908 RVA: 0x005B27A1 File Offset: 0x005B09A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029B9D RID: 170909 RVA: 0x005B27A8 File Offset: 0x005B09A8
		public static IThrowMotion GetRootAsIThrowMotion(ByteBuffer _bb)
		{
			return IThrowMotion.GetRootAsIThrowMotion(_bb, default(IThrowMotion));
		}

		// Token: 0x06029B9E RID: 170910 RVA: 0x005B27C4 File Offset: 0x005B09C4
		public static IThrowMotion GetRootAsIThrowMotion(ByteBuffer _bb, IThrowMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029B9F RID: 170911 RVA: 0x005B27E1 File Offset: 0x005B09E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029BA0 RID: 170912 RVA: 0x005B27F0 File Offset: 0x005B09F0
		public IThrowMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B762 RID: 46946
		// (get) Token: 0x06029BA1 RID: 170913 RVA: 0x005B2800 File Offset: 0x005B0A00
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

		// Token: 0x06029BA2 RID: 170914 RVA: 0x005B283C File Offset: 0x005B0A3C
		public static Offset<IThrowMotion> CreateIThrowMotion(FlatBufferBuilder builder, EThrowMotion Type = EThrowMotion.Projectile)
		{
			builder.StartTable(1);
			IThrowMotion.AddType(builder, Type);
			return IThrowMotion.EndIThrowMotion(builder);
		}

		// Token: 0x06029BA3 RID: 170915 RVA: 0x005B2852 File Offset: 0x005B0A52
		public static void StartIThrowMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029BA4 RID: 170916 RVA: 0x005B285B File Offset: 0x005B0A5B
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029BA5 RID: 170917 RVA: 0x005B2866 File Offset: 0x005B0A66
		public static Offset<IThrowMotion> EndIThrowMotion(FlatBufferBuilder builder)
		{
			return new Offset<IThrowMotion>(builder.EndTable());
		}

		// Token: 0x06029BA6 RID: 170918 RVA: 0x005B2874 File Offset: 0x005B0A74
		public IThrowMotionT UnPack()
		{
			IThrowMotionT throwMotionT = new IThrowMotionT();
			this.UnPackTo(throwMotionT);
			return throwMotionT;
		}

		// Token: 0x06029BA7 RID: 170919 RVA: 0x005B288F File Offset: 0x005B0A8F
		public void UnPackTo(IThrowMotionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029BA8 RID: 170920 RVA: 0x005B28A0 File Offset: 0x005B0AA0
		public static Offset<IThrowMotion> Pack(FlatBufferBuilder builder, IThrowMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowMotion>);
			}
			return IThrowMotion.CreateIThrowMotion(builder, _o.Type);
		}

		// Token: 0x0400FDF0 RID: 65008
		private Table __p;
	}
}
