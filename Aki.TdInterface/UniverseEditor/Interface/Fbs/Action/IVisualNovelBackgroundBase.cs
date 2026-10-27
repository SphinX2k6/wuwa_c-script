using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007559 RID: 30041
	public struct IVisualNovelBackgroundBase : IFlatbufferObject
	{
		// Token: 0x1700E3E6 RID: 58342
		// (get) Token: 0x06036A7A RID: 223866 RVA: 0x0076C612 File Offset: 0x0076A812
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A7B RID: 223867 RVA: 0x0076C61F File Offset: 0x0076A81F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A7C RID: 223868 RVA: 0x0076C628 File Offset: 0x0076A828
		public static IVisualNovelBackgroundBase GetRootAsIVisualNovelBackgroundBase(ByteBuffer _bb)
		{
			return IVisualNovelBackgroundBase.GetRootAsIVisualNovelBackgroundBase(_bb, default(IVisualNovelBackgroundBase));
		}

		// Token: 0x06036A7D RID: 223869 RVA: 0x0076C644 File Offset: 0x0076A844
		public static IVisualNovelBackgroundBase GetRootAsIVisualNovelBackgroundBase(ByteBuffer _bb, IVisualNovelBackgroundBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A7E RID: 223870 RVA: 0x0076C661 File Offset: 0x0076A861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A7F RID: 223871 RVA: 0x0076C670 File Offset: 0x0076A870
		public IVisualNovelBackgroundBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3E7 RID: 58343
		// (get) Token: 0x06036A80 RID: 223872 RVA: 0x0076C680 File Offset: 0x0076A880
		public EVisualNovelBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelBackgroundType.Load;
				}
				return (EVisualNovelBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036A81 RID: 223873 RVA: 0x0076C6BC File Offset: 0x0076A8BC
		public static Offset<IVisualNovelBackgroundBase> CreateIVisualNovelBackgroundBase(FlatBufferBuilder builder, EVisualNovelBackgroundType Type = EVisualNovelBackgroundType.Load)
		{
			builder.StartTable(1);
			IVisualNovelBackgroundBase.AddType(builder, Type);
			return IVisualNovelBackgroundBase.EndIVisualNovelBackgroundBase(builder);
		}

		// Token: 0x06036A82 RID: 223874 RVA: 0x0076C6D2 File Offset: 0x0076A8D2
		public static void StartIVisualNovelBackgroundBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036A83 RID: 223875 RVA: 0x0076C6DB File Offset: 0x0076A8DB
		public static void AddType(FlatBufferBuilder builder, EVisualNovelBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036A84 RID: 223876 RVA: 0x0076C6E6 File Offset: 0x0076A8E6
		public static Offset<IVisualNovelBackgroundBase> EndIVisualNovelBackgroundBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelBackgroundBase>(builder.EndTable());
		}

		// Token: 0x06036A85 RID: 223877 RVA: 0x0076C6F4 File Offset: 0x0076A8F4
		public IVisualNovelBackgroundBaseT UnPack()
		{
			IVisualNovelBackgroundBaseT visualNovelBackgroundBaseT = new IVisualNovelBackgroundBaseT();
			this.UnPackTo(visualNovelBackgroundBaseT);
			return visualNovelBackgroundBaseT;
		}

		// Token: 0x06036A86 RID: 223878 RVA: 0x0076C70F File Offset: 0x0076A90F
		public void UnPackTo(IVisualNovelBackgroundBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036A87 RID: 223879 RVA: 0x0076C720 File Offset: 0x0076A920
		public static Offset<IVisualNovelBackgroundBase> Pack(FlatBufferBuilder builder, IVisualNovelBackgroundBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelBackgroundBase>);
			}
			return IVisualNovelBackgroundBase.CreateIVisualNovelBackgroundBase(builder, _o.Type);
		}

		// Token: 0x04012453 RID: 74835
		private Table __p;
	}
}
