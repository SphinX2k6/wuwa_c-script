using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007151 RID: 29009
	public struct ILiveUnloadDanmakuConfig : IFlatbufferObject
	{
		// Token: 0x1700D44C RID: 54348
		// (get) Token: 0x06032646 RID: 206406 RVA: 0x006CFC6D File Offset: 0x006CDE6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032647 RID: 206407 RVA: 0x006CFC7A File Offset: 0x006CDE7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032648 RID: 206408 RVA: 0x006CFC84 File Offset: 0x006CDE84
		public static ILiveUnloadDanmakuConfig GetRootAsILiveUnloadDanmakuConfig(ByteBuffer _bb)
		{
			return ILiveUnloadDanmakuConfig.GetRootAsILiveUnloadDanmakuConfig(_bb, default(ILiveUnloadDanmakuConfig));
		}

		// Token: 0x06032649 RID: 206409 RVA: 0x006CFCA0 File Offset: 0x006CDEA0
		public static ILiveUnloadDanmakuConfig GetRootAsILiveUnloadDanmakuConfig(ByteBuffer _bb, ILiveUnloadDanmakuConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603264A RID: 206410 RVA: 0x006CFCBD File Offset: 0x006CDEBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603264B RID: 206411 RVA: 0x006CFCCC File Offset: 0x006CDECC
		public ILiveUnloadDanmakuConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D44D RID: 54349
		// (get) Token: 0x0603264C RID: 206412 RVA: 0x006CFCDC File Offset: 0x006CDEDC
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

		// Token: 0x1700D44E RID: 54350
		// (get) Token: 0x0603264D RID: 206413 RVA: 0x006CFD18 File Offset: 0x006CDF18
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

		// Token: 0x0603264E RID: 206414 RVA: 0x006CFD54 File Offset: 0x006CDF54
		public static Offset<ILiveUnloadDanmakuConfig> CreateILiveUnloadDanmakuConfig(FlatBufferBuilder builder, ELiveDanmakuOperationType Type = ELiveDanmakuOperationType.Load, ELiveDanmakuClearType ClearType = ELiveDanmakuClearType.FinishCurrent)
		{
			builder.StartTable(2);
			ILiveUnloadDanmakuConfig.AddClearType(builder, ClearType);
			ILiveUnloadDanmakuConfig.AddType(builder, Type);
			return ILiveUnloadDanmakuConfig.EndILiveUnloadDanmakuConfig(builder);
		}

		// Token: 0x0603264F RID: 206415 RVA: 0x006CFD71 File Offset: 0x006CDF71
		public static void StartILiveUnloadDanmakuConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032650 RID: 206416 RVA: 0x006CFD7A File Offset: 0x006CDF7A
		public static void AddType(FlatBufferBuilder builder, ELiveDanmakuOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032651 RID: 206417 RVA: 0x006CFD85 File Offset: 0x006CDF85
		public static void AddClearType(FlatBufferBuilder builder, ELiveDanmakuClearType clearType)
		{
			builder.AddByte(1, (byte)clearType, 0);
		}

		// Token: 0x06032652 RID: 206418 RVA: 0x006CFD90 File Offset: 0x006CDF90
		public static Offset<ILiveUnloadDanmakuConfig> EndILiveUnloadDanmakuConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveUnloadDanmakuConfig>(builder.EndTable());
		}

		// Token: 0x06032653 RID: 206419 RVA: 0x006CFDA0 File Offset: 0x006CDFA0
		public ILiveUnloadDanmakuConfigT UnPack()
		{
			ILiveUnloadDanmakuConfigT liveUnloadDanmakuConfigT = new ILiveUnloadDanmakuConfigT();
			this.UnPackTo(liveUnloadDanmakuConfigT);
			return liveUnloadDanmakuConfigT;
		}

		// Token: 0x06032654 RID: 206420 RVA: 0x006CFDBB File Offset: 0x006CDFBB
		public void UnPackTo(ILiveUnloadDanmakuConfigT _o)
		{
			_o.Type = this.Type;
			_o.ClearType = this.ClearType;
		}

		// Token: 0x06032655 RID: 206421 RVA: 0x006CFDD8 File Offset: 0x006CDFD8
		public static Offset<ILiveUnloadDanmakuConfig> Pack(FlatBufferBuilder builder, ILiveUnloadDanmakuConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveUnloadDanmakuConfig>);
			}
			return ILiveUnloadDanmakuConfig.CreateILiveUnloadDanmakuConfig(builder, _o.Type, _o.ClearType);
		}

		// Token: 0x04012137 RID: 74039
		private Table __p;
	}
}
