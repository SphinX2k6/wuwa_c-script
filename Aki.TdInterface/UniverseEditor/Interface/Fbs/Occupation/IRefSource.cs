using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004821 RID: 18465
	public struct IRefSource : IFlatbufferObject
	{
		// Token: 0x170080DF RID: 32991
		// (get) Token: 0x0601B559 RID: 111961 RVA: 0x003DF6EC File Offset: 0x003DD8EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B55A RID: 111962 RVA: 0x003DF6F9 File Offset: 0x003DD8F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B55B RID: 111963 RVA: 0x003DF700 File Offset: 0x003DD900
		public static IRefSource GetRootAsIRefSource(ByteBuffer _bb)
		{
			return IRefSource.GetRootAsIRefSource(_bb, default(IRefSource));
		}

		// Token: 0x0601B55C RID: 111964 RVA: 0x003DF71C File Offset: 0x003DD91C
		public static IRefSource GetRootAsIRefSource(ByteBuffer _bb, IRefSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B55D RID: 111965 RVA: 0x003DF739 File Offset: 0x003DD939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B55E RID: 111966 RVA: 0x003DF748 File Offset: 0x003DD948
		public IRefSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080E0 RID: 32992
		// (get) Token: 0x0601B55F RID: 111967 RVA: 0x003DF758 File Offset: 0x003DD958
		public ERefSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefSourceType.AwakeEntity;
				}
				return (ERefSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B560 RID: 111968 RVA: 0x003DF794 File Offset: 0x003DD994
		public static Offset<IRefSource> CreateIRefSource(FlatBufferBuilder builder, ERefSourceType Type = ERefSourceType.AwakeEntity)
		{
			builder.StartTable(1);
			IRefSource.AddType(builder, Type);
			return IRefSource.EndIRefSource(builder);
		}

		// Token: 0x0601B561 RID: 111969 RVA: 0x003DF7AA File Offset: 0x003DD9AA
		public static void StartIRefSource(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B562 RID: 111970 RVA: 0x003DF7B3 File Offset: 0x003DD9B3
		public static void AddType(FlatBufferBuilder builder, ERefSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B563 RID: 111971 RVA: 0x003DF7BE File Offset: 0x003DD9BE
		public static Offset<IRefSource> EndIRefSource(FlatBufferBuilder builder)
		{
			return new Offset<IRefSource>(builder.EndTable());
		}

		// Token: 0x0601B564 RID: 111972 RVA: 0x003DF7CC File Offset: 0x003DD9CC
		public IRefSourceT UnPack()
		{
			IRefSourceT refSourceT = new IRefSourceT();
			this.UnPackTo(refSourceT);
			return refSourceT;
		}

		// Token: 0x0601B565 RID: 111973 RVA: 0x003DF7E7 File Offset: 0x003DD9E7
		public void UnPackTo(IRefSourceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B566 RID: 111974 RVA: 0x003DF7F8 File Offset: 0x003DD9F8
		public static Offset<IRefSource> Pack(FlatBufferBuilder builder, IRefSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefSource>);
			}
			return IRefSource.CreateIRefSource(builder, _o.Type);
		}

		// Token: 0x0400CC29 RID: 52265
		private Table __p;
	}
}
