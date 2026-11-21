using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007148 RID: 29000
	public struct ILiveUiResumeConfig : IFlatbufferObject
	{
		// Token: 0x1700D443 RID: 54339
		// (get) Token: 0x06032610 RID: 206352 RVA: 0x006CF805 File Offset: 0x006CDA05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032611 RID: 206353 RVA: 0x006CF812 File Offset: 0x006CDA12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032612 RID: 206354 RVA: 0x006CF81C File Offset: 0x006CDA1C
		public static ILiveUiResumeConfig GetRootAsILiveUiResumeConfig(ByteBuffer _bb)
		{
			return ILiveUiResumeConfig.GetRootAsILiveUiResumeConfig(_bb, default(ILiveUiResumeConfig));
		}

		// Token: 0x06032613 RID: 206355 RVA: 0x006CF838 File Offset: 0x006CDA38
		public static ILiveUiResumeConfig GetRootAsILiveUiResumeConfig(ByteBuffer _bb, ILiveUiResumeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032614 RID: 206356 RVA: 0x006CF855 File Offset: 0x006CDA55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032615 RID: 206357 RVA: 0x006CF864 File Offset: 0x006CDA64
		public ILiveUiResumeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D444 RID: 54340
		// (get) Token: 0x06032616 RID: 206358 RVA: 0x006CF874 File Offset: 0x006CDA74
		public ELiveUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveUiType.Start;
				}
				return (ELiveUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032617 RID: 206359 RVA: 0x006CF8B0 File Offset: 0x006CDAB0
		public static Offset<ILiveUiResumeConfig> CreateILiveUiResumeConfig(FlatBufferBuilder builder, ELiveUiType Type = ELiveUiType.Start)
		{
			builder.StartTable(1);
			ILiveUiResumeConfig.AddType(builder, Type);
			return ILiveUiResumeConfig.EndILiveUiResumeConfig(builder);
		}

		// Token: 0x06032618 RID: 206360 RVA: 0x006CF8C6 File Offset: 0x006CDAC6
		public static void StartILiveUiResumeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032619 RID: 206361 RVA: 0x006CF8CF File Offset: 0x006CDACF
		public static void AddType(FlatBufferBuilder builder, ELiveUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603261A RID: 206362 RVA: 0x006CF8DA File Offset: 0x006CDADA
		public static Offset<ILiveUiResumeConfig> EndILiveUiResumeConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveUiResumeConfig>(builder.EndTable());
		}

		// Token: 0x0603261B RID: 206363 RVA: 0x006CF8E8 File Offset: 0x006CDAE8
		public ILiveUiResumeConfigT UnPack()
		{
			ILiveUiResumeConfigT liveUiResumeConfigT = new ILiveUiResumeConfigT();
			this.UnPackTo(liveUiResumeConfigT);
			return liveUiResumeConfigT;
		}

		// Token: 0x0603261C RID: 206364 RVA: 0x006CF903 File Offset: 0x006CDB03
		public void UnPackTo(ILiveUiResumeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603261D RID: 206365 RVA: 0x006CF914 File Offset: 0x006CDB14
		public static Offset<ILiveUiResumeConfig> Pack(FlatBufferBuilder builder, ILiveUiResumeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveUiResumeConfig>);
			}
			return ILiveUiResumeConfig.CreateILiveUiResumeConfig(builder, _o.Type);
		}

		// Token: 0x04012131 RID: 74033
		private Table __p;
	}
}
