using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A8B RID: 31371
	public struct ITalkEffectType : IFlatbufferObject
	{
		// Token: 0x1700E5D0 RID: 58832
		// (get) Token: 0x060374CF RID: 226511 RVA: 0x007624E0 File Offset: 0x007606E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060374D0 RID: 226512 RVA: 0x007624ED File Offset: 0x007606ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060374D1 RID: 226513 RVA: 0x007624F4 File Offset: 0x007606F4
		public static ITalkEffectType GetRootAsITalkEffectType(ByteBuffer _bb)
		{
			return ITalkEffectType.GetRootAsITalkEffectType(_bb, default(ITalkEffectType));
		}

		// Token: 0x060374D2 RID: 226514 RVA: 0x00762510 File Offset: 0x00760710
		public static ITalkEffectType GetRootAsITalkEffectType(ByteBuffer _bb, ITalkEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060374D3 RID: 226515 RVA: 0x0076252D File Offset: 0x0076072D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060374D4 RID: 226516 RVA: 0x0076253C File Offset: 0x0076073C
		public ITalkEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E5D1 RID: 58833
		// (get) Token: 0x060374D5 RID: 226517 RVA: 0x0076254C File Offset: 0x0076074C
		public ETalkEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkEffectType.Effect;
				}
				return (ETalkEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060374D6 RID: 226518 RVA: 0x00762588 File Offset: 0x00760788
		public static Offset<ITalkEffectType> CreateITalkEffectType(FlatBufferBuilder builder, ETalkEffectType Type = ETalkEffectType.Effect)
		{
			builder.StartTable(1);
			ITalkEffectType.AddType(builder, Type);
			return ITalkEffectType.EndITalkEffectType(builder);
		}

		// Token: 0x060374D7 RID: 226519 RVA: 0x0076259E File Offset: 0x0076079E
		public static void StartITalkEffectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060374D8 RID: 226520 RVA: 0x007625A7 File Offset: 0x007607A7
		public static void AddType(FlatBufferBuilder builder, ETalkEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060374D9 RID: 226521 RVA: 0x007625B2 File Offset: 0x007607B2
		public static Offset<ITalkEffectType> EndITalkEffectType(FlatBufferBuilder builder)
		{
			return new Offset<ITalkEffectType>(builder.EndTable());
		}

		// Token: 0x060374DA RID: 226522 RVA: 0x007625C0 File Offset: 0x007607C0
		public ITalkEffectTypeT UnPack()
		{
			ITalkEffectTypeT talkEffectTypeT = new ITalkEffectTypeT();
			this.UnPackTo(talkEffectTypeT);
			return talkEffectTypeT;
		}

		// Token: 0x060374DB RID: 226523 RVA: 0x007625DB File Offset: 0x007607DB
		public void UnPackTo(ITalkEffectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060374DC RID: 226524 RVA: 0x007625EC File Offset: 0x007607EC
		public static Offset<ITalkEffectType> Pack(FlatBufferBuilder builder, ITalkEffectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkEffectType>);
			}
			return ITalkEffectType.CreateITalkEffectType(builder, _o.Type);
		}

		// Token: 0x04012DDA RID: 77274
		private Table __p;
	}
}
