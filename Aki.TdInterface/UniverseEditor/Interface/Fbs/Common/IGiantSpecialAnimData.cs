using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200640A RID: 25610
	public struct IGiantSpecialAnimData : IFlatbufferObject
	{
		// Token: 0x1700BD27 RID: 48423
		// (get) Token: 0x0602B81A RID: 178202 RVA: 0x005ECEF4 File Offset: 0x005EB0F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B81B RID: 178203 RVA: 0x005ECF01 File Offset: 0x005EB101
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B81C RID: 178204 RVA: 0x005ECF08 File Offset: 0x005EB108
		public static IGiantSpecialAnimData GetRootAsIGiantSpecialAnimData(ByteBuffer _bb)
		{
			return IGiantSpecialAnimData.GetRootAsIGiantSpecialAnimData(_bb, default(IGiantSpecialAnimData));
		}

		// Token: 0x0602B81D RID: 178205 RVA: 0x005ECF24 File Offset: 0x005EB124
		public static IGiantSpecialAnimData GetRootAsIGiantSpecialAnimData(ByteBuffer _bb, IGiantSpecialAnimData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B81E RID: 178206 RVA: 0x005ECF41 File Offset: 0x005EB141
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B81F RID: 178207 RVA: 0x005ECF50 File Offset: 0x005EB150
		public IGiantSpecialAnimData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD28 RID: 48424
		// (get) Token: 0x0602B820 RID: 178208 RVA: 0x005ECF60 File Offset: 0x005EB160
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

		// Token: 0x1700BD29 RID: 48425
		// (get) Token: 0x0602B821 RID: 178209 RVA: 0x005ECF9C File Offset: 0x005EB19C
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

		// Token: 0x0602B822 RID: 178210 RVA: 0x005ECFD3 File Offset: 0x005EB1D3
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B823 RID: 178211 RVA: 0x005ECFE2 File Offset: 0x005EB1E2
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BD2A RID: 48426
		// (get) Token: 0x0602B824 RID: 178212 RVA: 0x005ECFF0 File Offset: 0x005EB1F0
		public bool IsCanBeInterrupt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BD2B RID: 48427
		// (get) Token: 0x0602B825 RID: 178213 RVA: 0x005ED030 File Offset: 0x005EB230
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

		// Token: 0x0602B826 RID: 178214 RVA: 0x005ED06D File Offset: 0x005EB26D
		public static Offset<IGiantSpecialAnimData> CreateIGiantSpecialAnimData(FlatBufferBuilder builder, EGiantAnimationType Type = EGiantAnimationType.Idle, StringOffset MontagePathOffset = default(StringOffset), bool IsCanBeInterrupt = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IGiantSpecialAnimData.AddMontagePath(builder, MontagePathOffset);
			IGiantSpecialAnimData.AddNullMask(builder, NullMask);
			IGiantSpecialAnimData.AddIsCanBeInterrupt(builder, IsCanBeInterrupt);
			IGiantSpecialAnimData.AddType(builder, Type);
			return IGiantSpecialAnimData.EndIGiantSpecialAnimData(builder);
		}

		// Token: 0x0602B827 RID: 178215 RVA: 0x005ED099 File Offset: 0x005EB299
		public static void StartIGiantSpecialAnimData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602B828 RID: 178216 RVA: 0x005ED0A2 File Offset: 0x005EB2A2
		public static void AddType(FlatBufferBuilder builder, EGiantAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B829 RID: 178217 RVA: 0x005ED0AD File Offset: 0x005EB2AD
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(1, montagePathOffset.Value, 0);
		}

		// Token: 0x0602B82A RID: 178218 RVA: 0x005ED0BD File Offset: 0x005EB2BD
		public static void AddIsCanBeInterrupt(FlatBufferBuilder builder, bool isCanBeInterrupt)
		{
			builder.AddBool(2, isCanBeInterrupt, false);
		}

		// Token: 0x0602B82B RID: 178219 RVA: 0x005ED0C8 File Offset: 0x005EB2C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602B82C RID: 178220 RVA: 0x005ED0D3 File Offset: 0x005EB2D3
		public static Offset<IGiantSpecialAnimData> EndIGiantSpecialAnimData(FlatBufferBuilder builder)
		{
			return new Offset<IGiantSpecialAnimData>(builder.EndTable());
		}

		// Token: 0x0602B82D RID: 178221 RVA: 0x005ED0E0 File Offset: 0x005EB2E0
		public IGiantSpecialAnimDataT UnPack()
		{
			IGiantSpecialAnimDataT giantSpecialAnimDataT = new IGiantSpecialAnimDataT();
			this.UnPackTo(giantSpecialAnimDataT);
			return giantSpecialAnimDataT;
		}

		// Token: 0x0602B82E RID: 178222 RVA: 0x005ED0FB File Offset: 0x005EB2FB
		public void UnPackTo(IGiantSpecialAnimDataT _o)
		{
			_o.Type = this.Type;
			_o.MontagePath = this.MontagePath;
			_o.IsCanBeInterrupt = this.IsCanBeInterrupt;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B82F RID: 178223 RVA: 0x005ED130 File Offset: 0x005EB330
		public static Offset<IGiantSpecialAnimData> Pack(FlatBufferBuilder builder, IGiantSpecialAnimDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantSpecialAnimData>);
			}
			StringOffset montagePathOffset = (_o.MontagePath == null) ? default(StringOffset) : builder.CreateString(_o.MontagePath);
			return IGiantSpecialAnimData.CreateIGiantSpecialAnimData(builder, _o.Type, montagePathOffset, _o.IsCanBeInterrupt, _o.NullMask);
		}

		// Token: 0x0401050C RID: 66828
		private Table __p;
	}
}
