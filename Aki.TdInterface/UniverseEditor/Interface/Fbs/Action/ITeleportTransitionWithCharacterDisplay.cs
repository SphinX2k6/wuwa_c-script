using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B93 RID: 31635
	public struct ITeleportTransitionWithCharacterDisplay : IFlatbufferObject
	{
		// Token: 0x1700ECD9 RID: 60633
		// (get) Token: 0x06038FB6 RID: 233398 RVA: 0x007B38B8 File Offset: 0x007B1AB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038FB7 RID: 233399 RVA: 0x007B38C5 File Offset: 0x007B1AC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038FB8 RID: 233400 RVA: 0x007B38CC File Offset: 0x007B1ACC
		public static ITeleportTransitionWithCharacterDisplay GetRootAsITeleportTransitionWithCharacterDisplay(ByteBuffer _bb)
		{
			return ITeleportTransitionWithCharacterDisplay.GetRootAsITeleportTransitionWithCharacterDisplay(_bb, default(ITeleportTransitionWithCharacterDisplay));
		}

		// Token: 0x06038FB9 RID: 233401 RVA: 0x007B38E8 File Offset: 0x007B1AE8
		public static ITeleportTransitionWithCharacterDisplay GetRootAsITeleportTransitionWithCharacterDisplay(ByteBuffer _bb, ITeleportTransitionWithCharacterDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038FBA RID: 233402 RVA: 0x007B3905 File Offset: 0x007B1B05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038FBB RID: 233403 RVA: 0x007B3914 File Offset: 0x007B1B14
		public ITeleportTransitionWithCharacterDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECDA RID: 60634
		// (get) Token: 0x06038FBC RID: 233404 RVA: 0x007B3924 File Offset: 0x007B1B24
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

		// Token: 0x1700ECDB RID: 60635
		// (get) Token: 0x06038FBD RID: 233405 RVA: 0x007B3960 File Offset: 0x007B1B60
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

		// Token: 0x06038FBE RID: 233406 RVA: 0x007B399C File Offset: 0x007B1B9C
		public static Offset<ITeleportTransitionWithCharacterDisplay> CreateITeleportTransitionWithCharacterDisplay(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, int StyleId = 0)
		{
			builder.StartTable(2);
			ITeleportTransitionWithCharacterDisplay.AddStyleId(builder, StyleId);
			ITeleportTransitionWithCharacterDisplay.AddType(builder, Type);
			return ITeleportTransitionWithCharacterDisplay.EndITeleportTransitionWithCharacterDisplay(builder);
		}

		// Token: 0x06038FBF RID: 233407 RVA: 0x007B39B9 File Offset: 0x007B1BB9
		public static void StartITeleportTransitionWithCharacterDisplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038FC0 RID: 233408 RVA: 0x007B39C2 File Offset: 0x007B1BC2
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038FC1 RID: 233409 RVA: 0x007B39CD File Offset: 0x007B1BCD
		public static void AddStyleId(FlatBufferBuilder builder, int styleId)
		{
			builder.AddInt(1, styleId, 0);
		}

		// Token: 0x06038FC2 RID: 233410 RVA: 0x007B39D8 File Offset: 0x007B1BD8
		public static Offset<ITeleportTransitionWithCharacterDisplay> EndITeleportTransitionWithCharacterDisplay(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithCharacterDisplay>(builder.EndTable());
		}

		// Token: 0x06038FC3 RID: 233411 RVA: 0x007B39E8 File Offset: 0x007B1BE8
		public ITeleportTransitionWithCharacterDisplayT UnPack()
		{
			ITeleportTransitionWithCharacterDisplayT teleportTransitionWithCharacterDisplayT = new ITeleportTransitionWithCharacterDisplayT();
			this.UnPackTo(teleportTransitionWithCharacterDisplayT);
			return teleportTransitionWithCharacterDisplayT;
		}

		// Token: 0x06038FC4 RID: 233412 RVA: 0x007B3A03 File Offset: 0x007B1C03
		public void UnPackTo(ITeleportTransitionWithCharacterDisplayT _o)
		{
			_o.Type = this.Type;
			_o.StyleId = this.StyleId;
		}

		// Token: 0x06038FC5 RID: 233413 RVA: 0x007B3A20 File Offset: 0x007B1C20
		public static Offset<ITeleportTransitionWithCharacterDisplay> Pack(FlatBufferBuilder builder, ITeleportTransitionWithCharacterDisplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithCharacterDisplay>);
			}
			return ITeleportTransitionWithCharacterDisplay.CreateITeleportTransitionWithCharacterDisplay(builder, _o.Type, _o.StyleId);
		}

		// Token: 0x040131F9 RID: 78329
		private Table __p;
	}
}
