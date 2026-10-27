using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DCD RID: 24013
	public struct IGiantSpecialAnimData : IFlatbufferObject
	{
		// Token: 0x1700B3C1 RID: 46017
		// (get) Token: 0x06029190 RID: 168336 RVA: 0x005A41C4 File Offset: 0x005A23C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029191 RID: 168337 RVA: 0x005A41D1 File Offset: 0x005A23D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029192 RID: 168338 RVA: 0x005A41D8 File Offset: 0x005A23D8
		public static IGiantSpecialAnimData GetRootAsIGiantSpecialAnimData(ByteBuffer _bb)
		{
			return IGiantSpecialAnimData.GetRootAsIGiantSpecialAnimData(_bb, default(IGiantSpecialAnimData));
		}

		// Token: 0x06029193 RID: 168339 RVA: 0x005A41F4 File Offset: 0x005A23F4
		public static IGiantSpecialAnimData GetRootAsIGiantSpecialAnimData(ByteBuffer _bb, IGiantSpecialAnimData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029194 RID: 168340 RVA: 0x005A4211 File Offset: 0x005A2411
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029195 RID: 168341 RVA: 0x005A4220 File Offset: 0x005A2420
		public IGiantSpecialAnimData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3C2 RID: 46018
		// (get) Token: 0x06029196 RID: 168342 RVA: 0x005A4230 File Offset: 0x005A2430
		public EGiantAnimationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantAnimationType.Idle;
				}
				return (EGiantAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3C3 RID: 46019
		// (get) Token: 0x06029197 RID: 168343 RVA: 0x005A426C File Offset: 0x005A246C
		public string MontagePath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029198 RID: 168344 RVA: 0x005A42A3 File Offset: 0x005A24A3
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029199 RID: 168345 RVA: 0x005A42B2 File Offset: 0x005A24B2
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B3C4 RID: 46020
		// (get) Token: 0x0602919A RID: 168346 RVA: 0x005A42C0 File Offset: 0x005A24C0
		public bool IsCanBeInterrupt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B3C5 RID: 46021
		// (get) Token: 0x0602919B RID: 168347 RVA: 0x005A4300 File Offset: 0x005A2500
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602919C RID: 168348 RVA: 0x005A433D File Offset: 0x005A253D
		public static Offset<IGiantSpecialAnimData> CreateIGiantSpecialAnimData(FlatBufferBuilder builder, EGiantAnimationType Type = EGiantAnimationType.Idle, StringOffset MontagePathOffset = default(StringOffset), bool IsCanBeInterrupt = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IGiantSpecialAnimData.AddMontagePath(builder, MontagePathOffset);
			IGiantSpecialAnimData.AddNullMask(builder, NullMask);
			IGiantSpecialAnimData.AddIsCanBeInterrupt(builder, IsCanBeInterrupt);
			IGiantSpecialAnimData.AddType(builder, Type);
			return IGiantSpecialAnimData.EndIGiantSpecialAnimData(builder);
		}

		// Token: 0x0602919D RID: 168349 RVA: 0x005A4369 File Offset: 0x005A2569
		public static void StartIGiantSpecialAnimData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602919E RID: 168350 RVA: 0x005A4372 File Offset: 0x005A2572
		public static void AddType(FlatBufferBuilder builder, EGiantAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602919F RID: 168351 RVA: 0x005A437D File Offset: 0x005A257D
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(1, montagePathOffset.Value, 0);
		}

		// Token: 0x060291A0 RID: 168352 RVA: 0x005A438D File Offset: 0x005A258D
		public static void AddIsCanBeInterrupt(FlatBufferBuilder builder, bool isCanBeInterrupt)
		{
			builder.AddBool(2, isCanBeInterrupt, false);
		}

		// Token: 0x060291A1 RID: 168353 RVA: 0x005A4398 File Offset: 0x005A2598
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060291A2 RID: 168354 RVA: 0x005A43A3 File Offset: 0x005A25A3
		public static Offset<IGiantSpecialAnimData> EndIGiantSpecialAnimData(FlatBufferBuilder builder)
		{
			return new Offset<IGiantSpecialAnimData>(builder.EndTable());
		}

		// Token: 0x060291A3 RID: 168355 RVA: 0x005A43B0 File Offset: 0x005A25B0
		public IGiantSpecialAnimDataT UnPack()
		{
			IGiantSpecialAnimDataT giantSpecialAnimDataT = new IGiantSpecialAnimDataT();
			this.UnPackTo(giantSpecialAnimDataT);
			return giantSpecialAnimDataT;
		}

		// Token: 0x060291A4 RID: 168356 RVA: 0x005A43CB File Offset: 0x005A25CB
		public void UnPackTo(IGiantSpecialAnimDataT _o)
		{
			_o.Type = this.Type;
			_o.MontagePath = this.MontagePath;
			_o.IsCanBeInterrupt = this.IsCanBeInterrupt;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060291A5 RID: 168357 RVA: 0x005A4400 File Offset: 0x005A2600
		public static Offset<IGiantSpecialAnimData> Pack(FlatBufferBuilder builder, IGiantSpecialAnimDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantSpecialAnimData>);
			}
			StringOffset montagePathOffset = (_o.MontagePath == null) ? default(StringOffset) : builder.CreateString(_o.MontagePath);
			return IGiantSpecialAnimData.CreateIGiantSpecialAnimData(builder, _o.Type, montagePathOffset, _o.IsCanBeInterrupt, _o.NullMask);
		}

		// Token: 0x0400F7B1 RID: 63409
		private Table __p;
	}
}
