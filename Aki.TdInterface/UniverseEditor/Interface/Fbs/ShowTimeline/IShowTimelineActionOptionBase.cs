using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BA1 RID: 15265
	public struct IShowTimelineActionOptionBase : IFlatbufferObject
	{
		// Token: 0x170068AA RID: 26794
		// (get) Token: 0x06014EC7 RID: 85703 RVA: 0x00309124 File Offset: 0x00307324
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014EC8 RID: 85704 RVA: 0x00309131 File Offset: 0x00307331
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014EC9 RID: 85705 RVA: 0x00309138 File Offset: 0x00307338
		public static IShowTimelineActionOptionBase GetRootAsIShowTimelineActionOptionBase(ByteBuffer _bb)
		{
			return IShowTimelineActionOptionBase.GetRootAsIShowTimelineActionOptionBase(_bb, default(IShowTimelineActionOptionBase));
		}

		// Token: 0x06014ECA RID: 85706 RVA: 0x00309154 File Offset: 0x00307354
		public static IShowTimelineActionOptionBase GetRootAsIShowTimelineActionOptionBase(ByteBuffer _bb, IShowTimelineActionOptionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014ECB RID: 85707 RVA: 0x00309171 File Offset: 0x00307371
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014ECC RID: 85708 RVA: 0x00309180 File Offset: 0x00307380
		public IShowTimelineActionOptionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068AB RID: 26795
		// (get) Token: 0x06014ECD RID: 85709 RVA: 0x00309190 File Offset: 0x00307390
		public EShowTimelineActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineActionType.Skill;
				}
				return (EShowTimelineActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014ECE RID: 85710 RVA: 0x003091CC File Offset: 0x003073CC
		public static Offset<IShowTimelineActionOptionBase> CreateIShowTimelineActionOptionBase(FlatBufferBuilder builder, EShowTimelineActionType Type = EShowTimelineActionType.Skill)
		{
			builder.StartTable(1);
			IShowTimelineActionOptionBase.AddType(builder, Type);
			return IShowTimelineActionOptionBase.EndIShowTimelineActionOptionBase(builder);
		}

		// Token: 0x06014ECF RID: 85711 RVA: 0x003091E2 File Offset: 0x003073E2
		public static void StartIShowTimelineActionOptionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014ED0 RID: 85712 RVA: 0x003091EB File Offset: 0x003073EB
		public static void AddType(FlatBufferBuilder builder, EShowTimelineActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014ED1 RID: 85713 RVA: 0x003091F6 File Offset: 0x003073F6
		public static Offset<IShowTimelineActionOptionBase> EndIShowTimelineActionOptionBase(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineActionOptionBase>(builder.EndTable());
		}

		// Token: 0x06014ED2 RID: 85714 RVA: 0x00309204 File Offset: 0x00307404
		public IShowTimelineActionOptionBaseT UnPack()
		{
			IShowTimelineActionOptionBaseT showTimelineActionOptionBaseT = new IShowTimelineActionOptionBaseT();
			this.UnPackTo(showTimelineActionOptionBaseT);
			return showTimelineActionOptionBaseT;
		}

		// Token: 0x06014ED3 RID: 85715 RVA: 0x0030921F File Offset: 0x0030741F
		public void UnPackTo(IShowTimelineActionOptionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014ED4 RID: 85716 RVA: 0x00309230 File Offset: 0x00307430
		public static Offset<IShowTimelineActionOptionBase> Pack(FlatBufferBuilder builder, IShowTimelineActionOptionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineActionOptionBase>);
			}
			return IShowTimelineActionOptionBase.CreateIShowTimelineActionOptionBase(builder, _o.Type);
		}

		// Token: 0x0400B114 RID: 45332
		private Table __p;
	}
}
