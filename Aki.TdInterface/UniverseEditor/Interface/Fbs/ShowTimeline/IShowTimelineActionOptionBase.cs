using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FA9 RID: 16297
	public struct IShowTimelineActionOptionBase : IFlatbufferObject
	{
		// Token: 0x17006E49 RID: 28233
		// (get) Token: 0x06016391 RID: 91025 RVA: 0x0032F6BC File Offset: 0x0032D8BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016392 RID: 91026 RVA: 0x0032F6C9 File Offset: 0x0032D8C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016393 RID: 91027 RVA: 0x0032F6D0 File Offset: 0x0032D8D0
		public static IShowTimelineActionOptionBase GetRootAsIShowTimelineActionOptionBase(ByteBuffer _bb)
		{
			return IShowTimelineActionOptionBase.GetRootAsIShowTimelineActionOptionBase(_bb, default(IShowTimelineActionOptionBase));
		}

		// Token: 0x06016394 RID: 91028 RVA: 0x0032F6EC File Offset: 0x0032D8EC
		public static IShowTimelineActionOptionBase GetRootAsIShowTimelineActionOptionBase(ByteBuffer _bb, IShowTimelineActionOptionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016395 RID: 91029 RVA: 0x0032F709 File Offset: 0x0032D909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016396 RID: 91030 RVA: 0x0032F718 File Offset: 0x0032D918
		public IShowTimelineActionOptionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E4A RID: 28234
		// (get) Token: 0x06016397 RID: 91031 RVA: 0x0032F728 File Offset: 0x0032D928
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

		// Token: 0x06016398 RID: 91032 RVA: 0x0032F764 File Offset: 0x0032D964
		public static Offset<IShowTimelineActionOptionBase> CreateIShowTimelineActionOptionBase(FlatBufferBuilder builder, EShowTimelineActionType Type = EShowTimelineActionType.Skill)
		{
			builder.StartTable(1);
			IShowTimelineActionOptionBase.AddType(builder, Type);
			return IShowTimelineActionOptionBase.EndIShowTimelineActionOptionBase(builder);
		}

		// Token: 0x06016399 RID: 91033 RVA: 0x0032F77A File Offset: 0x0032D97A
		public static void StartIShowTimelineActionOptionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601639A RID: 91034 RVA: 0x0032F783 File Offset: 0x0032D983
		public static void AddType(FlatBufferBuilder builder, EShowTimelineActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601639B RID: 91035 RVA: 0x0032F78E File Offset: 0x0032D98E
		public static Offset<IShowTimelineActionOptionBase> EndIShowTimelineActionOptionBase(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineActionOptionBase>(builder.EndTable());
		}

		// Token: 0x0601639C RID: 91036 RVA: 0x0032F79C File Offset: 0x0032D99C
		public IShowTimelineActionOptionBaseT UnPack()
		{
			IShowTimelineActionOptionBaseT showTimelineActionOptionBaseT = new IShowTimelineActionOptionBaseT();
			this.UnPackTo(showTimelineActionOptionBaseT);
			return showTimelineActionOptionBaseT;
		}

		// Token: 0x0601639D RID: 91037 RVA: 0x0032F7B7 File Offset: 0x0032D9B7
		public void UnPackTo(IShowTimelineActionOptionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601639E RID: 91038 RVA: 0x0032F7C8 File Offset: 0x0032D9C8
		public static Offset<IShowTimelineActionOptionBase> Pack(FlatBufferBuilder builder, IShowTimelineActionOptionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineActionOptionBase>);
			}
			return IShowTimelineActionOptionBase.CreateIShowTimelineActionOptionBase(builder, _o.Type);
		}

		// Token: 0x0400BA91 RID: 47761
		private Table __p;
	}
}
