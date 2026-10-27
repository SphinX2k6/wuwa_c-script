using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755F RID: 30047
	public struct IVisualNovelBackgroundClean : IFlatbufferObject
	{
		// Token: 0x1700E3EB RID: 58347
		// (get) Token: 0x06036A9A RID: 223898 RVA: 0x0076C8D4 File Offset: 0x0076AAD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A9B RID: 223899 RVA: 0x0076C8E1 File Offset: 0x0076AAE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A9C RID: 223900 RVA: 0x0076C8E8 File Offset: 0x0076AAE8
		public static IVisualNovelBackgroundClean GetRootAsIVisualNovelBackgroundClean(ByteBuffer _bb)
		{
			return IVisualNovelBackgroundClean.GetRootAsIVisualNovelBackgroundClean(_bb, default(IVisualNovelBackgroundClean));
		}

		// Token: 0x06036A9D RID: 223901 RVA: 0x0076C904 File Offset: 0x0076AB04
		public static IVisualNovelBackgroundClean GetRootAsIVisualNovelBackgroundClean(ByteBuffer _bb, IVisualNovelBackgroundClean obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A9E RID: 223902 RVA: 0x0076C921 File Offset: 0x0076AB21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A9F RID: 223903 RVA: 0x0076C930 File Offset: 0x0076AB30
		public IVisualNovelBackgroundClean __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3EC RID: 58348
		// (get) Token: 0x06036AA0 RID: 223904 RVA: 0x0076C940 File Offset: 0x0076AB40
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

		// Token: 0x06036AA1 RID: 223905 RVA: 0x0076C97C File Offset: 0x0076AB7C
		public static Offset<IVisualNovelBackgroundClean> CreateIVisualNovelBackgroundClean(FlatBufferBuilder builder, EVisualNovelBackgroundType Type = EVisualNovelBackgroundType.Load)
		{
			builder.StartTable(1);
			IVisualNovelBackgroundClean.AddType(builder, Type);
			return IVisualNovelBackgroundClean.EndIVisualNovelBackgroundClean(builder);
		}

		// Token: 0x06036AA2 RID: 223906 RVA: 0x0076C992 File Offset: 0x0076AB92
		public static void StartIVisualNovelBackgroundClean(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036AA3 RID: 223907 RVA: 0x0076C99B File Offset: 0x0076AB9B
		public static void AddType(FlatBufferBuilder builder, EVisualNovelBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036AA4 RID: 223908 RVA: 0x0076C9A6 File Offset: 0x0076ABA6
		public static Offset<IVisualNovelBackgroundClean> EndIVisualNovelBackgroundClean(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelBackgroundClean>(builder.EndTable());
		}

		// Token: 0x06036AA5 RID: 223909 RVA: 0x0076C9B4 File Offset: 0x0076ABB4
		public IVisualNovelBackgroundCleanT UnPack()
		{
			IVisualNovelBackgroundCleanT visualNovelBackgroundCleanT = new IVisualNovelBackgroundCleanT();
			this.UnPackTo(visualNovelBackgroundCleanT);
			return visualNovelBackgroundCleanT;
		}

		// Token: 0x06036AA6 RID: 223910 RVA: 0x0076C9CF File Offset: 0x0076ABCF
		public void UnPackTo(IVisualNovelBackgroundCleanT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036AA7 RID: 223911 RVA: 0x0076C9E0 File Offset: 0x0076ABE0
		public static Offset<IVisualNovelBackgroundClean> Pack(FlatBufferBuilder builder, IVisualNovelBackgroundCleanT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelBackgroundClean>);
			}
			return IVisualNovelBackgroundClean.CreateIVisualNovelBackgroundClean(builder, _o.Type);
		}

		// Token: 0x0401245C RID: 74844
		private Table __p;
	}
}
