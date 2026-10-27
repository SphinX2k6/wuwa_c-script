using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200744E RID: 29774
	public struct ITransitionPopupStyle : IFlatbufferObject
	{
		// Token: 0x1700E20D RID: 57869
		// (get) Token: 0x0603617B RID: 221563 RVA: 0x0075B3BD File Offset: 0x007595BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603617C RID: 221564 RVA: 0x0075B3CA File Offset: 0x007595CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603617D RID: 221565 RVA: 0x0075B3D4 File Offset: 0x007595D4
		public static ITransitionPopupStyle GetRootAsITransitionPopupStyle(ByteBuffer _bb)
		{
			return ITransitionPopupStyle.GetRootAsITransitionPopupStyle(_bb, default(ITransitionPopupStyle));
		}

		// Token: 0x0603617E RID: 221566 RVA: 0x0075B3F0 File Offset: 0x007595F0
		public static ITransitionPopupStyle GetRootAsITransitionPopupStyle(ByteBuffer _bb, ITransitionPopupStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603617F RID: 221567 RVA: 0x0075B40D File Offset: 0x0075960D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036180 RID: 221568 RVA: 0x0075B41C File Offset: 0x0075961C
		public ITransitionPopupStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E20E RID: 57870
		// (get) Token: 0x06036181 RID: 221569 RVA: 0x0075B42C File Offset: 0x0075962C
		public ETransitionPopupStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETransitionPopupStyleType.LeftTopTip;
				}
				return (ETransitionPopupStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036182 RID: 221570 RVA: 0x0075B468 File Offset: 0x00759668
		public static Offset<ITransitionPopupStyle> CreateITransitionPopupStyle(FlatBufferBuilder builder, ETransitionPopupStyleType Type = ETransitionPopupStyleType.LeftTopTip)
		{
			builder.StartTable(1);
			ITransitionPopupStyle.AddType(builder, Type);
			return ITransitionPopupStyle.EndITransitionPopupStyle(builder);
		}

		// Token: 0x06036183 RID: 221571 RVA: 0x0075B47E File Offset: 0x0075967E
		public static void StartITransitionPopupStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036184 RID: 221572 RVA: 0x0075B487 File Offset: 0x00759687
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036185 RID: 221573 RVA: 0x0075B492 File Offset: 0x00759692
		public static Offset<ITransitionPopupStyle> EndITransitionPopupStyle(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupStyle>(builder.EndTable());
		}

		// Token: 0x06036186 RID: 221574 RVA: 0x0075B4A0 File Offset: 0x007596A0
		public ITransitionPopupStyleT UnPack()
		{
			ITransitionPopupStyleT transitionPopupStyleT = new ITransitionPopupStyleT();
			this.UnPackTo(transitionPopupStyleT);
			return transitionPopupStyleT;
		}

		// Token: 0x06036187 RID: 221575 RVA: 0x0075B4BB File Offset: 0x007596BB
		public void UnPackTo(ITransitionPopupStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036188 RID: 221576 RVA: 0x0075B4CC File Offset: 0x007596CC
		public static Offset<ITransitionPopupStyle> Pack(FlatBufferBuilder builder, ITransitionPopupStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransitionPopupStyle>);
			}
			return ITransitionPopupStyle.CreateITransitionPopupStyle(builder, _o.Type);
		}

		// Token: 0x040122D2 RID: 74450
		private Table __p;
	}
}
