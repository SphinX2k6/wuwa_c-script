using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D28 RID: 27944
	public struct IEnterMovieCameraType : IFlatbufferObject
	{
		// Token: 0x1700CD01 RID: 52481
		// (get) Token: 0x06030329 RID: 197417 RVA: 0x0068D96D File Offset: 0x0068BB6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603032A RID: 197418 RVA: 0x0068D97A File Offset: 0x0068BB7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603032B RID: 197419 RVA: 0x0068D984 File Offset: 0x0068BB84
		public static IEnterMovieCameraType GetRootAsIEnterMovieCameraType(ByteBuffer _bb)
		{
			return IEnterMovieCameraType.GetRootAsIEnterMovieCameraType(_bb, default(IEnterMovieCameraType));
		}

		// Token: 0x0603032C RID: 197420 RVA: 0x0068D9A0 File Offset: 0x0068BBA0
		public static IEnterMovieCameraType GetRootAsIEnterMovieCameraType(ByteBuffer _bb, IEnterMovieCameraType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603032D RID: 197421 RVA: 0x0068D9BD File Offset: 0x0068BBBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603032E RID: 197422 RVA: 0x0068D9CC File Offset: 0x0068BBCC
		public IEnterMovieCameraType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD02 RID: 52482
		// (get) Token: 0x0603032F RID: 197423 RVA: 0x0068D9DC File Offset: 0x0068BBDC
		public EMovieCameraType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMovieCameraType.Common;
				}
				return (EMovieCameraType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030330 RID: 197424 RVA: 0x0068DA18 File Offset: 0x0068BC18
		public static Offset<IEnterMovieCameraType> CreateIEnterMovieCameraType(FlatBufferBuilder builder, EMovieCameraType Type = EMovieCameraType.Common)
		{
			builder.StartTable(1);
			IEnterMovieCameraType.AddType(builder, Type);
			return IEnterMovieCameraType.EndIEnterMovieCameraType(builder);
		}

		// Token: 0x06030331 RID: 197425 RVA: 0x0068DA2E File Offset: 0x0068BC2E
		public static void StartIEnterMovieCameraType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030332 RID: 197426 RVA: 0x0068DA37 File Offset: 0x0068BC37
		public static void AddType(FlatBufferBuilder builder, EMovieCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030333 RID: 197427 RVA: 0x0068DA42 File Offset: 0x0068BC42
		public static Offset<IEnterMovieCameraType> EndIEnterMovieCameraType(FlatBufferBuilder builder)
		{
			return new Offset<IEnterMovieCameraType>(builder.EndTable());
		}

		// Token: 0x06030334 RID: 197428 RVA: 0x0068DA50 File Offset: 0x0068BC50
		public IEnterMovieCameraTypeT UnPack()
		{
			IEnterMovieCameraTypeT enterMovieCameraTypeT = new IEnterMovieCameraTypeT();
			this.UnPackTo(enterMovieCameraTypeT);
			return enterMovieCameraTypeT;
		}

		// Token: 0x06030335 RID: 197429 RVA: 0x0068DA6B File Offset: 0x0068BC6B
		public void UnPackTo(IEnterMovieCameraTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030336 RID: 197430 RVA: 0x0068DA7C File Offset: 0x0068BC7C
		public static Offset<IEnterMovieCameraType> Pack(FlatBufferBuilder builder, IEnterMovieCameraTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterMovieCameraType>);
			}
			return IEnterMovieCameraType.CreateIEnterMovieCameraType(builder, _o.Type);
		}

		// Token: 0x04011B8D RID: 72589
		private Table __p;
	}
}
