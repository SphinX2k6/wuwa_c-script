using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075EE RID: 30190
	public struct IRemoveScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700DDDE RID: 56798
		// (get) Token: 0x06034F6E RID: 216942 RVA: 0x0071DAF9 File Offset: 0x0071BCF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034F6F RID: 216943 RVA: 0x0071DB06 File Offset: 0x0071BD06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034F70 RID: 216944 RVA: 0x0071DB10 File Offset: 0x0071BD10
		public static IRemoveScreenEffect GetRootAsIRemoveScreenEffect(ByteBuffer _bb)
		{
			return IRemoveScreenEffect.GetRootAsIRemoveScreenEffect(_bb, default(IRemoveScreenEffect));
		}

		// Token: 0x06034F71 RID: 216945 RVA: 0x0071DB2C File Offset: 0x0071BD2C
		public static IRemoveScreenEffect GetRootAsIRemoveScreenEffect(ByteBuffer _bb, IRemoveScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034F72 RID: 216946 RVA: 0x0071DB49 File Offset: 0x0071BD49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034F73 RID: 216947 RVA: 0x0071DB58 File Offset: 0x0071BD58
		public IRemoveScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDDF RID: 56799
		// (get) Token: 0x06034F74 RID: 216948 RVA: 0x0071DB68 File Offset: 0x0071BD68
		public EEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectType.Effect;
				}
				return (EEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DDE0 RID: 56800
		// (get) Token: 0x06034F75 RID: 216949 RVA: 0x0071DBA4 File Offset: 0x0071BDA4
		public string Path
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034F76 RID: 216950 RVA: 0x0071DBDB File Offset: 0x0071BDDB
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06034F77 RID: 216951 RVA: 0x0071DBEA File Offset: 0x0071BDEA
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06034F78 RID: 216952 RVA: 0x0071DBF8 File Offset: 0x0071BDF8
		public static Offset<IRemoveScreenEffect> CreateIRemoveScreenEffect(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRemoveScreenEffect.AddPath(builder, PathOffset);
			IRemoveScreenEffect.AddType(builder, Type);
			return IRemoveScreenEffect.EndIRemoveScreenEffect(builder);
		}

		// Token: 0x06034F79 RID: 216953 RVA: 0x0071DC15 File Offset: 0x0071BE15
		public static void StartIRemoveScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034F7A RID: 216954 RVA: 0x0071DC1E File Offset: 0x0071BE1E
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034F7B RID: 216955 RVA: 0x0071DC29 File Offset: 0x0071BE29
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06034F7C RID: 216956 RVA: 0x0071DC39 File Offset: 0x0071BE39
		public static Offset<IRemoveScreenEffect> EndIRemoveScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveScreenEffect>(builder.EndTable());
		}

		// Token: 0x06034F7D RID: 216957 RVA: 0x0071DC48 File Offset: 0x0071BE48
		public IRemoveScreenEffectT UnPack()
		{
			IRemoveScreenEffectT removeScreenEffectT = new IRemoveScreenEffectT();
			this.UnPackTo(removeScreenEffectT);
			return removeScreenEffectT;
		}

		// Token: 0x06034F7E RID: 216958 RVA: 0x0071DC63 File Offset: 0x0071BE63
		public void UnPackTo(IRemoveScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x06034F7F RID: 216959 RVA: 0x0071DC80 File Offset: 0x0071BE80
		public static Offset<IRemoveScreenEffect> Pack(FlatBufferBuilder builder, IRemoveScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveScreenEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IRemoveScreenEffect.CreateIRemoveScreenEffect(builder, _o.Type, pathOffset);
		}

		// Token: 0x040127D9 RID: 75737
		private Table __p;
	}
}
