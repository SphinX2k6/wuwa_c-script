using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007136 RID: 28982
	public struct ILiveStopInteractDanmakuConfig : IFlatbufferObject
	{
		// Token: 0x1700D42E RID: 54318
		// (get) Token: 0x06032598 RID: 206232 RVA: 0x006CED54 File Offset: 0x006CCF54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032599 RID: 206233 RVA: 0x006CED61 File Offset: 0x006CCF61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603259A RID: 206234 RVA: 0x006CED68 File Offset: 0x006CCF68
		public static ILiveStopInteractDanmakuConfig GetRootAsILiveStopInteractDanmakuConfig(ByteBuffer _bb)
		{
			return ILiveStopInteractDanmakuConfig.GetRootAsILiveStopInteractDanmakuConfig(_bb, default(ILiveStopInteractDanmakuConfig));
		}

		// Token: 0x0603259B RID: 206235 RVA: 0x006CED84 File Offset: 0x006CCF84
		public static ILiveStopInteractDanmakuConfig GetRootAsILiveStopInteractDanmakuConfig(ByteBuffer _bb, ILiveStopInteractDanmakuConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603259C RID: 206236 RVA: 0x006CEDA1 File Offset: 0x006CCFA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603259D RID: 206237 RVA: 0x006CEDB0 File Offset: 0x006CCFB0
		public ILiveStopInteractDanmakuConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D42F RID: 54319
		// (get) Token: 0x0603259E RID: 206238 RVA: 0x006CEDC0 File Offset: 0x006CCFC0
		public ELiveDanmakuOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveDanmakuOperationType.Load;
				}
				return (ELiveDanmakuOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D430 RID: 54320
		// (get) Token: 0x0603259F RID: 206239 RVA: 0x006CEDFC File Offset: 0x006CCFFC
		public ELiveDanmakuClearType ClearType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ELiveDanmakuClearType.FinishCurrent;
				}
				return (ELiveDanmakuClearType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060325A0 RID: 206240 RVA: 0x006CEE38 File Offset: 0x006CD038
		public static Offset<ILiveStopInteractDanmakuConfig> CreateILiveStopInteractDanmakuConfig(FlatBufferBuilder builder, ELiveDanmakuOperationType Type = ELiveDanmakuOperationType.Load, ELiveDanmakuClearType ClearType = ELiveDanmakuClearType.FinishCurrent)
		{
			builder.StartTable(2);
			ILiveStopInteractDanmakuConfig.AddClearType(builder, ClearType);
			ILiveStopInteractDanmakuConfig.AddType(builder, Type);
			return ILiveStopInteractDanmakuConfig.EndILiveStopInteractDanmakuConfig(builder);
		}

		// Token: 0x060325A1 RID: 206241 RVA: 0x006CEE55 File Offset: 0x006CD055
		public static void StartILiveStopInteractDanmakuConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060325A2 RID: 206242 RVA: 0x006CEE5E File Offset: 0x006CD05E
		public static void AddType(FlatBufferBuilder builder, ELiveDanmakuOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060325A3 RID: 206243 RVA: 0x006CEE69 File Offset: 0x006CD069
		public static void AddClearType(FlatBufferBuilder builder, ELiveDanmakuClearType clearType)
		{
			builder.AddByte(1, (byte)clearType, 0);
		}

		// Token: 0x060325A4 RID: 206244 RVA: 0x006CEE74 File Offset: 0x006CD074
		public static Offset<ILiveStopInteractDanmakuConfig> EndILiveStopInteractDanmakuConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveStopInteractDanmakuConfig>(builder.EndTable());
		}

		// Token: 0x060325A5 RID: 206245 RVA: 0x006CEE84 File Offset: 0x006CD084
		public ILiveStopInteractDanmakuConfigT UnPack()
		{
			ILiveStopInteractDanmakuConfigT liveStopInteractDanmakuConfigT = new ILiveStopInteractDanmakuConfigT();
			this.UnPackTo(liveStopInteractDanmakuConfigT);
			return liveStopInteractDanmakuConfigT;
		}

		// Token: 0x060325A6 RID: 206246 RVA: 0x006CEE9F File Offset: 0x006CD09F
		public void UnPackTo(ILiveStopInteractDanmakuConfigT _o)
		{
			_o.Type = this.Type;
			_o.ClearType = this.ClearType;
		}

		// Token: 0x060325A7 RID: 206247 RVA: 0x006CEEBC File Offset: 0x006CD0BC
		public static Offset<ILiveStopInteractDanmakuConfig> Pack(FlatBufferBuilder builder, ILiveStopInteractDanmakuConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveStopInteractDanmakuConfig>);
			}
			return ILiveStopInteractDanmakuConfig.CreateILiveStopInteractDanmakuConfig(builder, _o.Type, _o.ClearType);
		}

		// Token: 0x0401211A RID: 74010
		private Table __p;
	}
}
