using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007513 RID: 29971
	public struct IPreloadMp4s : IFlatbufferObject
	{
		// Token: 0x1700DC8E RID: 56462
		// (get) Token: 0x060348ED RID: 215277 RVA: 0x00712F76 File Offset: 0x00711176
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060348EE RID: 215278 RVA: 0x00712F83 File Offset: 0x00711183
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060348EF RID: 215279 RVA: 0x00712F8C File Offset: 0x0071118C
		public static IPreloadMp4s GetRootAsIPreloadMp4s(ByteBuffer _bb)
		{
			return IPreloadMp4s.GetRootAsIPreloadMp4s(_bb, default(IPreloadMp4s));
		}

		// Token: 0x060348F0 RID: 215280 RVA: 0x00712FA8 File Offset: 0x007111A8
		public static IPreloadMp4s GetRootAsIPreloadMp4s(ByteBuffer _bb, IPreloadMp4s obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060348F1 RID: 215281 RVA: 0x00712FC5 File Offset: 0x007111C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060348F2 RID: 215282 RVA: 0x00712FD4 File Offset: 0x007111D4
		public IPreloadMp4s __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC8F RID: 56463
		// (get) Token: 0x060348F3 RID: 215283 RVA: 0x00712FE4 File Offset: 0x007111E4
		public EPreloadObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return (EPreloadObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060348F4 RID: 215284 RVA: 0x00713020 File Offset: 0x00711220
		public string Mp4s(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DC90 RID: 56464
		// (get) Token: 0x060348F5 RID: 215285 RVA: 0x0071305C File Offset: 0x0071125C
		public int Mp4sLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060348F6 RID: 215286 RVA: 0x00713087 File Offset: 0x00711287
		public static Offset<IPreloadMp4s> CreateIPreloadMp4s(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill, VectorOffset Mp4sOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPreloadMp4s.AddMp4s(builder, Mp4sOffset);
			IPreloadMp4s.AddType(builder, Type);
			return IPreloadMp4s.EndIPreloadMp4s(builder);
		}

		// Token: 0x060348F7 RID: 215287 RVA: 0x007130A4 File Offset: 0x007112A4
		public static void StartIPreloadMp4s(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060348F8 RID: 215288 RVA: 0x007130AD File Offset: 0x007112AD
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060348F9 RID: 215289 RVA: 0x007130B8 File Offset: 0x007112B8
		public static void AddMp4s(FlatBufferBuilder builder, VectorOffset mp4sOffset)
		{
			builder.AddOffset(1, mp4sOffset.Value, 0);
		}

		// Token: 0x060348FA RID: 215290 RVA: 0x007130C8 File Offset: 0x007112C8
		public static VectorOffset CreateMp4sVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060348FB RID: 215291 RVA: 0x00713108 File Offset: 0x00711308
		public static VectorOffset CreateMp4sVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060348FC RID: 215292 RVA: 0x00713122 File Offset: 0x00711322
		public static VectorOffset CreateMp4sVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060348FD RID: 215293 RVA: 0x00713140 File Offset: 0x00711340
		public static VectorOffset CreateMp4sVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060348FE RID: 215294 RVA: 0x00713159 File Offset: 0x00711359
		public static void StartMp4sVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060348FF RID: 215295 RVA: 0x00713164 File Offset: 0x00711364
		public static Offset<IPreloadMp4s> EndIPreloadMp4s(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadMp4s>(builder.EndTable());
		}

		// Token: 0x06034900 RID: 215296 RVA: 0x00713174 File Offset: 0x00711374
		public IPreloadMp4sT UnPack()
		{
			IPreloadMp4sT preloadMp4sT = new IPreloadMp4sT();
			this.UnPackTo(preloadMp4sT);
			return preloadMp4sT;
		}

		// Token: 0x06034901 RID: 215297 RVA: 0x00713190 File Offset: 0x00711390
		public void UnPackTo(IPreloadMp4sT _o)
		{
			_o.Type = this.Type;
			_o.Mp4s = new List<string>();
			for (int i = 0; i < this.Mp4sLength; i++)
			{
				_o.Mp4s.Add(this.Mp4s(i));
			}
		}

		// Token: 0x06034902 RID: 215298 RVA: 0x007131D8 File Offset: 0x007113D8
		public static Offset<IPreloadMp4s> Pack(FlatBufferBuilder builder, IPreloadMp4sT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadMp4s>);
			}
			VectorOffset mp4sOffset = default(VectorOffset);
			if (_o.Mp4s != null)
			{
				StringOffset[] array = new StringOffset[_o.Mp4s.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Mp4s[i]);
				}
				mp4sOffset = IPreloadMp4s.CreateMp4sVector(builder, array);
			}
			return IPreloadMp4s.CreateIPreloadMp4s(builder, _o.Type, mp4sOffset);
		}

		// Token: 0x040126E7 RID: 75495
		private Table __p;
	}
}
