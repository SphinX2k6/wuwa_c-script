using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DEE RID: 32238
	public struct IVisualNovelTransitionConfigBase : IFlatbufferObject
	{
		// Token: 0x1700F17F RID: 61823
		// (get) Token: 0x0603A423 RID: 238627 RVA: 0x007D9B19 File Offset: 0x007D7D19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A424 RID: 238628 RVA: 0x007D9B26 File Offset: 0x007D7D26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A425 RID: 238629 RVA: 0x007D9B30 File Offset: 0x007D7D30
		public static IVisualNovelTransitionConfigBase GetRootAsIVisualNovelTransitionConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelTransitionConfigBase.GetRootAsIVisualNovelTransitionConfigBase(_bb, default(IVisualNovelTransitionConfigBase));
		}

		// Token: 0x0603A426 RID: 238630 RVA: 0x007D9B4C File Offset: 0x007D7D4C
		public static IVisualNovelTransitionConfigBase GetRootAsIVisualNovelTransitionConfigBase(ByteBuffer _bb, IVisualNovelTransitionConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A427 RID: 238631 RVA: 0x007D9B69 File Offset: 0x007D7D69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A428 RID: 238632 RVA: 0x007D9B78 File Offset: 0x007D7D78
		public IVisualNovelTransitionConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F180 RID: 61824
		// (get) Token: 0x0603A429 RID: 238633 RVA: 0x007D9B88 File Offset: 0x007D7D88
		public EVisualNovelTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelTransitionType.Location;
				}
				return (EVisualNovelTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A42A RID: 238634 RVA: 0x007D9BC4 File Offset: 0x007D7DC4
		public static Offset<IVisualNovelTransitionConfigBase> CreateIVisualNovelTransitionConfigBase(FlatBufferBuilder builder, EVisualNovelTransitionType Type = EVisualNovelTransitionType.Location)
		{
			builder.StartTable(1);
			IVisualNovelTransitionConfigBase.AddType(builder, Type);
			return IVisualNovelTransitionConfigBase.EndIVisualNovelTransitionConfigBase(builder);
		}

		// Token: 0x0603A42B RID: 238635 RVA: 0x007D9BDA File Offset: 0x007D7DDA
		public static void StartIVisualNovelTransitionConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A42C RID: 238636 RVA: 0x007D9BE3 File Offset: 0x007D7DE3
		public static void AddType(FlatBufferBuilder builder, EVisualNovelTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A42D RID: 238637 RVA: 0x007D9BEE File Offset: 0x007D7DEE
		public static Offset<IVisualNovelTransitionConfigBase> EndIVisualNovelTransitionConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelTransitionConfigBase>(builder.EndTable());
		}

		// Token: 0x0603A42E RID: 238638 RVA: 0x007D9BFC File Offset: 0x007D7DFC
		public IVisualNovelTransitionConfigBaseT UnPack()
		{
			IVisualNovelTransitionConfigBaseT visualNovelTransitionConfigBaseT = new IVisualNovelTransitionConfigBaseT();
			this.UnPackTo(visualNovelTransitionConfigBaseT);
			return visualNovelTransitionConfigBaseT;
		}

		// Token: 0x0603A42F RID: 238639 RVA: 0x007D9C17 File Offset: 0x007D7E17
		public void UnPackTo(IVisualNovelTransitionConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A430 RID: 238640 RVA: 0x007D9C28 File Offset: 0x007D7E28
		public static Offset<IVisualNovelTransitionConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelTransitionConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelTransitionConfigBase>);
			}
			return IVisualNovelTransitionConfigBase.CreateIVisualNovelTransitionConfigBase(builder, _o.Type);
		}

		// Token: 0x04013591 RID: 79249
		private Table __p;
	}
}
