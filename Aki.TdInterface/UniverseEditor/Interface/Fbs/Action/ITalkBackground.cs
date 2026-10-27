using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007292 RID: 29330
	public struct ITalkBackground : IFlatbufferObject
	{
		// Token: 0x1700D98D RID: 55693
		// (get) Token: 0x06034093 RID: 213139 RVA: 0x006FF0AA File Offset: 0x006FD2AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034094 RID: 213140 RVA: 0x006FF0B7 File Offset: 0x006FD2B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034095 RID: 213141 RVA: 0x006FF0C0 File Offset: 0x006FD2C0
		public static ITalkBackground GetRootAsITalkBackground(ByteBuffer _bb)
		{
			return ITalkBackground.GetRootAsITalkBackground(_bb, default(ITalkBackground));
		}

		// Token: 0x06034096 RID: 213142 RVA: 0x006FF0DC File Offset: 0x006FD2DC
		public static ITalkBackground GetRootAsITalkBackground(ByteBuffer _bb, ITalkBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034097 RID: 213143 RVA: 0x006FF0F9 File Offset: 0x006FD2F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034098 RID: 213144 RVA: 0x006FF108 File Offset: 0x006FD308
		public ITalkBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D98E RID: 55694
		// (get) Token: 0x06034099 RID: 213145 RVA: 0x006FF118 File Offset: 0x006FD318
		public ETalkBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkBackgroundType.Clean;
				}
				return (ETalkBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603409A RID: 213146 RVA: 0x006FF154 File Offset: 0x006FD354
		public static Offset<ITalkBackground> CreateITalkBackground(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean)
		{
			builder.StartTable(1);
			ITalkBackground.AddType(builder, Type);
			return ITalkBackground.EndITalkBackground(builder);
		}

		// Token: 0x0603409B RID: 213147 RVA: 0x006FF16A File Offset: 0x006FD36A
		public static void StartITalkBackground(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603409C RID: 213148 RVA: 0x006FF173 File Offset: 0x006FD373
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603409D RID: 213149 RVA: 0x006FF17E File Offset: 0x006FD37E
		public static Offset<ITalkBackground> EndITalkBackground(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackground>(builder.EndTable());
		}

		// Token: 0x0603409E RID: 213150 RVA: 0x006FF18C File Offset: 0x006FD38C
		public ITalkBackgroundT UnPack()
		{
			ITalkBackgroundT talkBackgroundT = new ITalkBackgroundT();
			this.UnPackTo(talkBackgroundT);
			return talkBackgroundT;
		}

		// Token: 0x0603409F RID: 213151 RVA: 0x006FF1A7 File Offset: 0x006FD3A7
		public void UnPackTo(ITalkBackgroundT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060340A0 RID: 213152 RVA: 0x006FF1B8 File Offset: 0x006FD3B8
		public static Offset<ITalkBackground> Pack(FlatBufferBuilder builder, ITalkBackgroundT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackground>);
			}
			return ITalkBackground.CreateITalkBackground(builder, _o.Type);
		}

		// Token: 0x04011D9E RID: 73118
		private Table __p;
	}
}
