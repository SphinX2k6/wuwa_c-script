using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EBF RID: 16063
	public struct IRequiredVector2 : IFlatbufferObject
	{
		// Token: 0x17006CC3 RID: 27843
		// (get) Token: 0x06015BCE RID: 89038 RVA: 0x00320FE7 File Offset: 0x0031F1E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015BCF RID: 89039 RVA: 0x00320FF4 File Offset: 0x0031F1F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015BD0 RID: 89040 RVA: 0x00320FFC File Offset: 0x0031F1FC
		public static IRequiredVector2 GetRootAsIRequiredVector2(ByteBuffer _bb)
		{
			return IRequiredVector2.GetRootAsIRequiredVector2(_bb, default(IRequiredVector2));
		}

		// Token: 0x06015BD1 RID: 89041 RVA: 0x00321018 File Offset: 0x0031F218
		public static IRequiredVector2 GetRootAsIRequiredVector2(ByteBuffer _bb, IRequiredVector2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015BD2 RID: 89042 RVA: 0x00321035 File Offset: 0x0031F235
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015BD3 RID: 89043 RVA: 0x00321044 File Offset: 0x0031F244
		public IRequiredVector2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CC4 RID: 27844
		// (get) Token: 0x06015BD4 RID: 89044 RVA: 0x00321054 File Offset: 0x0031F254
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

		// Token: 0x17006CC5 RID: 27845
		// (get) Token: 0x06015BD5 RID: 89045 RVA: 0x00321094 File Offset: 0x0031F294
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

		// Token: 0x06015BD6 RID: 89046 RVA: 0x003210D4 File Offset: 0x0031F2D4
		public static Offset<IRequiredVector2> CreateIRequiredVector2(FlatBufferBuilder builder, float X = 0f, float Y = 0f)
		{
			builder.StartTable(2);
			IRequiredVector2.AddY(builder, Y);
			IRequiredVector2.AddX(builder, X);
			return IRequiredVector2.EndIRequiredVector2(builder);
		}

		// Token: 0x06015BD7 RID: 89047 RVA: 0x003210F1 File Offset: 0x0031F2F1
		public static void StartIRequiredVector2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015BD8 RID: 89048 RVA: 0x003210FA File Offset: 0x0031F2FA
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x06015BD9 RID: 89049 RVA: 0x0032110D File Offset: 0x0031F30D
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x06015BDA RID: 89050 RVA: 0x00321120 File Offset: 0x0031F320
		public static Offset<IRequiredVector2> EndIRequiredVector2(FlatBufferBuilder builder)
		{
			return new Offset<IRequiredVector2>(builder.EndTable());
		}

		// Token: 0x06015BDB RID: 89051 RVA: 0x00321130 File Offset: 0x0031F330
		public IRequiredVector2T UnPack()
		{
			IRequiredVector2T requiredVector2T = new IRequiredVector2T();
			this.UnPackTo(requiredVector2T);
			return requiredVector2T;
		}

		// Token: 0x06015BDC RID: 89052 RVA: 0x0032114B File Offset: 0x0031F34B
		public void UnPackTo(IRequiredVector2T _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
		}

		// Token: 0x06015BDD RID: 89053 RVA: 0x00321168 File Offset: 0x0031F368
		public static Offset<IRequiredVector2> Pack(FlatBufferBuilder builder, IRequiredVector2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IRequiredVector2>);
			}
			return IRequiredVector2.CreateIRequiredVector2(builder, _o.X, _o.Y);
		}

		// Token: 0x0400B8C8 RID: 47304
		private Table __p;
	}
}
