using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007571 RID: 30065
	public struct IVisualNovelCgLoadSpine : IFlatbufferObject
	{
		// Token: 0x1700E400 RID: 58368
		// (get) Token: 0x06036B0C RID: 224012 RVA: 0x0076D2C6 File Offset: 0x0076B4C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036B0D RID: 224013 RVA: 0x0076D2D3 File Offset: 0x0076B4D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036B0E RID: 224014 RVA: 0x0076D2DC File Offset: 0x0076B4DC
		public static IVisualNovelCgLoadSpine GetRootAsIVisualNovelCgLoadSpine(ByteBuffer _bb)
		{
			return IVisualNovelCgLoadSpine.GetRootAsIVisualNovelCgLoadSpine(_bb, default(IVisualNovelCgLoadSpine));
		}

		// Token: 0x06036B0F RID: 224015 RVA: 0x0076D2F8 File Offset: 0x0076B4F8
		public static IVisualNovelCgLoadSpine GetRootAsIVisualNovelCgLoadSpine(ByteBuffer _bb, IVisualNovelCgLoadSpine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036B10 RID: 224016 RVA: 0x0076D315 File Offset: 0x0076B515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036B11 RID: 224017 RVA: 0x0076D324 File Offset: 0x0076B524
		public IVisualNovelCgLoadSpine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E401 RID: 58369
		// (get) Token: 0x06036B12 RID: 224018 RVA: 0x0076D334 File Offset: 0x0076B534
		public EVisualNovelCgType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelCgType.LoadSpine;
				}
				return (EVisualNovelCgType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E402 RID: 58370
		// (get) Token: 0x06036B13 RID: 224019 RVA: 0x0076D370 File Offset: 0x0076B570
		public int SpineId
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

		// Token: 0x06036B14 RID: 224020 RVA: 0x0076D3AC File Offset: 0x0076B5AC
		public static Offset<IVisualNovelCgLoadSpine> CreateIVisualNovelCgLoadSpine(FlatBufferBuilder builder, EVisualNovelCgType Type = EVisualNovelCgType.LoadSpine, int SpineId = 0)
		{
			builder.StartTable(2);
			IVisualNovelCgLoadSpine.AddSpineId(builder, SpineId);
			IVisualNovelCgLoadSpine.AddType(builder, Type);
			return IVisualNovelCgLoadSpine.EndIVisualNovelCgLoadSpine(builder);
		}

		// Token: 0x06036B15 RID: 224021 RVA: 0x0076D3C9 File Offset: 0x0076B5C9
		public static void StartIVisualNovelCgLoadSpine(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036B16 RID: 224022 RVA: 0x0076D3D2 File Offset: 0x0076B5D2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelCgType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036B17 RID: 224023 RVA: 0x0076D3DD File Offset: 0x0076B5DD
		public static void AddSpineId(FlatBufferBuilder builder, int spineId)
		{
			builder.AddInt(1, spineId, 0);
		}

		// Token: 0x06036B18 RID: 224024 RVA: 0x0076D3E8 File Offset: 0x0076B5E8
		public static Offset<IVisualNovelCgLoadSpine> EndIVisualNovelCgLoadSpine(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelCgLoadSpine>(builder.EndTable());
		}

		// Token: 0x06036B19 RID: 224025 RVA: 0x0076D3F8 File Offset: 0x0076B5F8
		public IVisualNovelCgLoadSpineT UnPack()
		{
			IVisualNovelCgLoadSpineT visualNovelCgLoadSpineT = new IVisualNovelCgLoadSpineT();
			this.UnPackTo(visualNovelCgLoadSpineT);
			return visualNovelCgLoadSpineT;
		}

		// Token: 0x06036B1A RID: 224026 RVA: 0x0076D413 File Offset: 0x0076B613
		public void UnPackTo(IVisualNovelCgLoadSpineT _o)
		{
			_o.Type = this.Type;
			_o.SpineId = this.SpineId;
		}

		// Token: 0x06036B1B RID: 224027 RVA: 0x0076D430 File Offset: 0x0076B630
		public static Offset<IVisualNovelCgLoadSpine> Pack(FlatBufferBuilder builder, IVisualNovelCgLoadSpineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelCgLoadSpine>);
			}
			return IVisualNovelCgLoadSpine.CreateIVisualNovelCgLoadSpine(builder, _o.Type, _o.SpineId);
		}

		// Token: 0x04012470 RID: 74864
		private Table __p;
	}
}
