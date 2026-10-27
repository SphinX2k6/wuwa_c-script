using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073AC RID: 29612
	public struct ITeleportTransitionWithCharacterDisplay : IFlatbufferObject
	{
		// Token: 0x1700E0C9 RID: 57545
		// (get) Token: 0x06035C1B RID: 220187 RVA: 0x00751378 File Offset: 0x0074F578
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C1C RID: 220188 RVA: 0x00751385 File Offset: 0x0074F585
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C1D RID: 220189 RVA: 0x0075138C File Offset: 0x0074F58C
		public static ITeleportTransitionWithCharacterDisplay GetRootAsITeleportTransitionWithCharacterDisplay(ByteBuffer _bb)
		{
			return ITeleportTransitionWithCharacterDisplay.GetRootAsITeleportTransitionWithCharacterDisplay(_bb, default(ITeleportTransitionWithCharacterDisplay));
		}

		// Token: 0x06035C1E RID: 220190 RVA: 0x007513A8 File Offset: 0x0074F5A8
		public static ITeleportTransitionWithCharacterDisplay GetRootAsITeleportTransitionWithCharacterDisplay(ByteBuffer _bb, ITeleportTransitionWithCharacterDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C1F RID: 220191 RVA: 0x007513C5 File Offset: 0x0074F5C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C20 RID: 220192 RVA: 0x007513D4 File Offset: 0x0074F5D4
		public ITeleportTransitionWithCharacterDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0CA RID: 57546
		// (get) Token: 0x06035C21 RID: 220193 RVA: 0x007513E4 File Offset: 0x0074F5E4
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0CB RID: 57547
		// (get) Token: 0x06035C22 RID: 220194 RVA: 0x00751420 File Offset: 0x0074F620
		public int StyleId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035C23 RID: 220195 RVA: 0x0075145C File Offset: 0x0074F65C
		public static Offset<ITeleportTransitionWithCharacterDisplay> CreateITeleportTransitionWithCharacterDisplay(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, int StyleId = 0)
		{
			builder.StartTable(2);
			ITeleportTransitionWithCharacterDisplay.AddStyleId(builder, StyleId);
			ITeleportTransitionWithCharacterDisplay.AddType(builder, Type);
			return ITeleportTransitionWithCharacterDisplay.EndITeleportTransitionWithCharacterDisplay(builder);
		}

		// Token: 0x06035C24 RID: 220196 RVA: 0x00751479 File Offset: 0x0074F679
		public static void StartITeleportTransitionWithCharacterDisplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035C25 RID: 220197 RVA: 0x00751482 File Offset: 0x0074F682
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035C26 RID: 220198 RVA: 0x0075148D File Offset: 0x0074F68D
		public static void AddStyleId(FlatBufferBuilder builder, int styleId)
		{
			builder.AddInt(1, styleId, 0);
		}

		// Token: 0x06035C27 RID: 220199 RVA: 0x00751498 File Offset: 0x0074F698
		public static Offset<ITeleportTransitionWithCharacterDisplay> EndITeleportTransitionWithCharacterDisplay(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithCharacterDisplay>(builder.EndTable());
		}

		// Token: 0x06035C28 RID: 220200 RVA: 0x007514A8 File Offset: 0x0074F6A8
		public ITeleportTransitionWithCharacterDisplayT UnPack()
		{
			ITeleportTransitionWithCharacterDisplayT teleportTransitionWithCharacterDisplayT = new ITeleportTransitionWithCharacterDisplayT();
			this.UnPackTo(teleportTransitionWithCharacterDisplayT);
			return teleportTransitionWithCharacterDisplayT;
		}

		// Token: 0x06035C29 RID: 220201 RVA: 0x007514C3 File Offset: 0x0074F6C3
		public void UnPackTo(ITeleportTransitionWithCharacterDisplayT _o)
		{
			_o.Type = this.Type;
			_o.StyleId = this.StyleId;
		}

		// Token: 0x06035C2A RID: 220202 RVA: 0x007514E0 File Offset: 0x0074F6E0
		public static Offset<ITeleportTransitionWithCharacterDisplay> Pack(FlatBufferBuilder builder, ITeleportTransitionWithCharacterDisplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithCharacterDisplay>);
			}
			return ITeleportTransitionWithCharacterDisplay.CreateITeleportTransitionWithCharacterDisplay(builder, _o.Type, _o.StyleId);
		}

		// Token: 0x040121E0 RID: 74208
		private Table __p;
	}
}
