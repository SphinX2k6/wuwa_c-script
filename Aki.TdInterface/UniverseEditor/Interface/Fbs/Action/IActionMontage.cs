using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006080 RID: 24704
	public struct IActionMontage : IFlatbufferObject
	{
		// Token: 0x1700B61C RID: 46620
		// (get) Token: 0x06029D8C RID: 171404 RVA: 0x005BD971 File Offset: 0x005BBB71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029D8D RID: 171405 RVA: 0x005BD97E File Offset: 0x005BBB7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029D8E RID: 171406 RVA: 0x005BD988 File Offset: 0x005BBB88
		public static IActionMontage GetRootAsIActionMontage(ByteBuffer _bb)
		{
			return IActionMontage.GetRootAsIActionMontage(_bb, default(IActionMontage));
		}

		// Token: 0x06029D8F RID: 171407 RVA: 0x005BD9A4 File Offset: 0x005BBBA4
		public static IActionMontage GetRootAsIActionMontage(ByteBuffer _bb, IActionMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029D90 RID: 171408 RVA: 0x005BD9C1 File Offset: 0x005BBBC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029D91 RID: 171409 RVA: 0x005BD9D0 File Offset: 0x005BBBD0
		public IActionMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B61D RID: 46621
		// (get) Token: 0x06029D92 RID: 171410 RVA: 0x005BD9E0 File Offset: 0x005BBBE0
		public EActionMontageType MontageType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActionMontageType.Normal;
				}
				return (EActionMontageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B61E RID: 46622
		// (get) Token: 0x06029D93 RID: 171411 RVA: 0x005BDA1C File Offset: 0x005BBC1C
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

		// Token: 0x06029D94 RID: 171412 RVA: 0x005BDA53 File Offset: 0x005BBC53
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029D95 RID: 171413 RVA: 0x005BDA62 File Offset: 0x005BBC62
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06029D96 RID: 171414 RVA: 0x005BDA70 File Offset: 0x005BBC70
		public static Offset<IActionMontage> CreateIActionMontage(FlatBufferBuilder builder, EActionMontageType MontageType = EActionMontageType.Normal, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IActionMontage.AddPath(builder, PathOffset);
			IActionMontage.AddMontageType(builder, MontageType);
			return IActionMontage.EndIActionMontage(builder);
		}

		// Token: 0x06029D97 RID: 171415 RVA: 0x005BDA8D File Offset: 0x005BBC8D
		public static void StartIActionMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029D98 RID: 171416 RVA: 0x005BDA96 File Offset: 0x005BBC96
		public static void AddMontageType(FlatBufferBuilder builder, EActionMontageType montageType)
		{
			builder.AddByte(0, (byte)montageType, 0);
		}

		// Token: 0x06029D99 RID: 171417 RVA: 0x005BDAA1 File Offset: 0x005BBCA1
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06029D9A RID: 171418 RVA: 0x005BDAB1 File Offset: 0x005BBCB1
		public static Offset<IActionMontage> EndIActionMontage(FlatBufferBuilder builder)
		{
			return new Offset<IActionMontage>(builder.EndTable());
		}

		// Token: 0x06029D9B RID: 171419 RVA: 0x005BDAC0 File Offset: 0x005BBCC0
		public IActionMontageT UnPack()
		{
			IActionMontageT actionMontageT = new IActionMontageT();
			this.UnPackTo(actionMontageT);
			return actionMontageT;
		}

		// Token: 0x06029D9C RID: 171420 RVA: 0x005BDADB File Offset: 0x005BBCDB
		public void UnPackTo(IActionMontageT _o)
		{
			_o.MontageType = this.MontageType;
			_o.Path = this.Path;
		}

		// Token: 0x06029D9D RID: 171421 RVA: 0x005BDAF8 File Offset: 0x005BBCF8
		public static Offset<IActionMontage> Pack(FlatBufferBuilder builder, IActionMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionMontage>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IActionMontage.CreateIActionMontage(builder, _o.MontageType, pathOffset);
		}

		// Token: 0x0401025A RID: 66138
		private Table __p;
	}
}
