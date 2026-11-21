using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B97 RID: 23447
	public struct INextSlideRail : IFlatbufferObject
	{
		// Token: 0x1700AB61 RID: 43873
		// (get) Token: 0x06026A51 RID: 158289 RVA: 0x0054A922 File Offset: 0x00548B22
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026A52 RID: 158290 RVA: 0x0054A92F File Offset: 0x00548B2F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026A53 RID: 158291 RVA: 0x0054A938 File Offset: 0x00548B38
		public static INextSlideRail GetRootAsINextSlideRail(ByteBuffer _bb)
		{
			return INextSlideRail.GetRootAsINextSlideRail(_bb, default(INextSlideRail));
		}

		// Token: 0x06026A54 RID: 158292 RVA: 0x0054A954 File Offset: 0x00548B54
		public static INextSlideRail GetRootAsINextSlideRail(ByteBuffer _bb, INextSlideRail obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026A55 RID: 158293 RVA: 0x0054A971 File Offset: 0x00548B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026A56 RID: 158294 RVA: 0x0054A980 File Offset: 0x00548B80
		public INextSlideRail __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB62 RID: 43874
		// (get) Token: 0x06026A57 RID: 158295 RVA: 0x0054A990 File Offset: 0x00548B90
		public ETriggerKey TriggerKey
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerKey.Left;
				}
				return (ETriggerKey)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AB63 RID: 43875
		// (get) Token: 0x06026A58 RID: 158296 RVA: 0x0054A9CC File Offset: 0x00548BCC
		public int TargetRailEntityId
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

		// Token: 0x1700AB64 RID: 43876
		// (get) Token: 0x06026A59 RID: 158297 RVA: 0x0054AA08 File Offset: 0x00548C08
		public bool IsFallbackRail
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB65 RID: 43877
		// (get) Token: 0x06026A5A RID: 158298 RVA: 0x0054AA48 File Offset: 0x00548C48
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

		// Token: 0x06026A5B RID: 158299 RVA: 0x0054AA85 File Offset: 0x00548C85
		public static Offset<INextSlideRail> CreateINextSlideRail(FlatBufferBuilder builder, ETriggerKey TriggerKey = ETriggerKey.Left, int TargetRailEntityId = 0, bool IsFallbackRail = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			INextSlideRail.AddTargetRailEntityId(builder, TargetRailEntityId);
			INextSlideRail.AddNullMask(builder, NullMask);
			INextSlideRail.AddIsFallbackRail(builder, IsFallbackRail);
			INextSlideRail.AddTriggerKey(builder, TriggerKey);
			return INextSlideRail.EndINextSlideRail(builder);
		}

		// Token: 0x06026A5C RID: 158300 RVA: 0x0054AAB1 File Offset: 0x00548CB1
		public static void StartINextSlideRail(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026A5D RID: 158301 RVA: 0x0054AABA File Offset: 0x00548CBA
		public static void AddTriggerKey(FlatBufferBuilder builder, ETriggerKey triggerKey)
		{
			builder.AddByte(0, (byte)triggerKey, 0);
		}

		// Token: 0x06026A5E RID: 158302 RVA: 0x0054AAC5 File Offset: 0x00548CC5
		public static void AddTargetRailEntityId(FlatBufferBuilder builder, int targetRailEntityId)
		{
			builder.AddInt(1, targetRailEntityId, 0);
		}

		// Token: 0x06026A5F RID: 158303 RVA: 0x0054AAD0 File Offset: 0x00548CD0
		public static void AddIsFallbackRail(FlatBufferBuilder builder, bool isFallbackRail)
		{
			builder.AddBool(2, isFallbackRail, false);
		}

		// Token: 0x06026A60 RID: 158304 RVA: 0x0054AADB File Offset: 0x00548CDB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06026A61 RID: 158305 RVA: 0x0054AAE6 File Offset: 0x00548CE6
		public static Offset<INextSlideRail> EndINextSlideRail(FlatBufferBuilder builder)
		{
			return new Offset<INextSlideRail>(builder.EndTable());
		}

		// Token: 0x06026A62 RID: 158306 RVA: 0x0054AAF4 File Offset: 0x00548CF4
		public INextSlideRailT UnPack()
		{
			INextSlideRailT nextSlideRailT = new INextSlideRailT();
			this.UnPackTo(nextSlideRailT);
			return nextSlideRailT;
		}

		// Token: 0x06026A63 RID: 158307 RVA: 0x0054AB0F File Offset: 0x00548D0F
		public void UnPackTo(INextSlideRailT _o)
		{
			_o.TriggerKey = this.TriggerKey;
			_o.TargetRailEntityId = this.TargetRailEntityId;
			_o.IsFallbackRail = this.IsFallbackRail;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026A64 RID: 158308 RVA: 0x0054AB44 File Offset: 0x00548D44
		public static Offset<INextSlideRail> Pack(FlatBufferBuilder builder, INextSlideRailT _o)
		{
			if (_o == null)
			{
				return default(Offset<INextSlideRail>);
			}
			return INextSlideRail.CreateINextSlideRail(builder, _o.TriggerKey, _o.TargetRailEntityId, _o.IsFallbackRail, _o.NullMask);
		}

		// Token: 0x0400F5D2 RID: 62930
		private Table __p;
	}
}
