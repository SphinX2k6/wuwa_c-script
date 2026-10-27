using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B29 RID: 15145
	public struct IVectorInfo : IFlatbufferObject
	{
		// Token: 0x170067E1 RID: 26593
		// (get) Token: 0x06014AED RID: 84717 RVA: 0x003023CC File Offset: 0x003005CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014AEE RID: 84718 RVA: 0x003023D9 File Offset: 0x003005D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014AEF RID: 84719 RVA: 0x003023E0 File Offset: 0x003005E0
		public static IVectorInfo GetRootAsIVectorInfo(ByteBuffer _bb)
		{
			return IVectorInfo.GetRootAsIVectorInfo(_bb, default(IVectorInfo));
		}

		// Token: 0x06014AF0 RID: 84720 RVA: 0x003023FC File Offset: 0x003005FC
		public static IVectorInfo GetRootAsIVectorInfo(ByteBuffer _bb, IVectorInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014AF1 RID: 84721 RVA: 0x00302419 File Offset: 0x00300619
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014AF2 RID: 84722 RVA: 0x00302428 File Offset: 0x00300628
		public IVectorInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067E2 RID: 26594
		// (get) Token: 0x06014AF3 RID: 84723 RVA: 0x00302438 File Offset: 0x00300638
		public float X
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067E3 RID: 26595
		// (get) Token: 0x06014AF4 RID: 84724 RVA: 0x00302478 File Offset: 0x00300678
		public float Y
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067E4 RID: 26596
		// (get) Token: 0x06014AF5 RID: 84725 RVA: 0x003024B8 File Offset: 0x003006B8
		public float Z
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067E5 RID: 26597
		// (get) Token: 0x06014AF6 RID: 84726 RVA: 0x003024F8 File Offset: 0x003006F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014AF7 RID: 84727 RVA: 0x00302535 File Offset: 0x00300735
		public static Offset<IVectorInfo> CreateIVectorInfo(FlatBufferBuilder builder, float X = 0f, float Y = 0f, float Z = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVectorInfo.AddZ(builder, Z);
			IVectorInfo.AddY(builder, Y);
			IVectorInfo.AddX(builder, X);
			IVectorInfo.AddNullMask(builder, NullMask);
			return IVectorInfo.EndIVectorInfo(builder);
		}

		// Token: 0x06014AF8 RID: 84728 RVA: 0x00302561 File Offset: 0x00300761
		public static void StartIVectorInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06014AF9 RID: 84729 RVA: 0x0030256A File Offset: 0x0030076A
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x06014AFA RID: 84730 RVA: 0x0030257D File Offset: 0x0030077D
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x06014AFB RID: 84731 RVA: 0x00302590 File Offset: 0x00300790
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x06014AFC RID: 84732 RVA: 0x003025A3 File Offset: 0x003007A3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06014AFD RID: 84733 RVA: 0x003025AE File Offset: 0x003007AE
		public static Offset<IVectorInfo> EndIVectorInfo(FlatBufferBuilder builder)
		{
			return new Offset<IVectorInfo>(builder.EndTable());
		}

		// Token: 0x06014AFE RID: 84734 RVA: 0x003025BC File Offset: 0x003007BC
		public IVectorInfoT UnPack()
		{
			IVectorInfoT vectorInfoT = new IVectorInfoT();
			this.UnPackTo(vectorInfoT);
			return vectorInfoT;
		}

		// Token: 0x06014AFF RID: 84735 RVA: 0x003025D7 File Offset: 0x003007D7
		public void UnPackTo(IVectorInfoT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06014B00 RID: 84736 RVA: 0x0030260C File Offset: 0x0030080C
		public static Offset<IVectorInfo> Pack(FlatBufferBuilder builder, IVectorInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVectorInfo>);
			}
			return IVectorInfo.CreateIVectorInfo(builder, _o.X, _o.Y, _o.Z, _o.NullMask);
		}

		// Token: 0x0400B002 RID: 45058
		private Table __p;
	}
}
