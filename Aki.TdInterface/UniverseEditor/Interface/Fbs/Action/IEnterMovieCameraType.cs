using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066AE RID: 26286
	public struct IEnterMovieCameraType : IFlatbufferObject
	{
		// Token: 0x1700C350 RID: 50000
		// (get) Token: 0x0602DB0C RID: 187148 RVA: 0x006406B9 File Offset: 0x0063E8B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB0D RID: 187149 RVA: 0x006406C6 File Offset: 0x0063E8C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB0E RID: 187150 RVA: 0x006406D0 File Offset: 0x0063E8D0
		public static IEnterMovieCameraType GetRootAsIEnterMovieCameraType(ByteBuffer _bb)
		{
			return IEnterMovieCameraType.GetRootAsIEnterMovieCameraType(_bb, default(IEnterMovieCameraType));
		}

		// Token: 0x0602DB0F RID: 187151 RVA: 0x006406EC File Offset: 0x0063E8EC
		public static IEnterMovieCameraType GetRootAsIEnterMovieCameraType(ByteBuffer _bb, IEnterMovieCameraType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DB10 RID: 187152 RVA: 0x00640709 File Offset: 0x0063E909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DB11 RID: 187153 RVA: 0x00640718 File Offset: 0x0063E918
		public IEnterMovieCameraType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C351 RID: 50001
		// (get) Token: 0x0602DB12 RID: 187154 RVA: 0x00640728 File Offset: 0x0063E928
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

		// Token: 0x0602DB13 RID: 187155 RVA: 0x00640764 File Offset: 0x0063E964
		public static Offset<IEnterMovieCameraType> CreateIEnterMovieCameraType(FlatBufferBuilder builder, EMovieCameraType Type = EMovieCameraType.Common)
		{
			builder.StartTable(1);
			IEnterMovieCameraType.AddType(builder, Type);
			return IEnterMovieCameraType.EndIEnterMovieCameraType(builder);
		}

		// Token: 0x0602DB14 RID: 187156 RVA: 0x0064077A File Offset: 0x0063E97A
		public static void StartIEnterMovieCameraType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DB15 RID: 187157 RVA: 0x00640783 File Offset: 0x0063E983
		public static void AddType(FlatBufferBuilder builder, EMovieCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DB16 RID: 187158 RVA: 0x0064078E File Offset: 0x0063E98E
		public static Offset<IEnterMovieCameraType> EndIEnterMovieCameraType(FlatBufferBuilder builder)
		{
			return new Offset<IEnterMovieCameraType>(builder.EndTable());
		}

		// Token: 0x0602DB17 RID: 187159 RVA: 0x0064079C File Offset: 0x0063E99C
		public IEnterMovieCameraTypeT UnPack()
		{
			IEnterMovieCameraTypeT enterMovieCameraTypeT = new IEnterMovieCameraTypeT();
			this.UnPackTo(enterMovieCameraTypeT);
			return enterMovieCameraTypeT;
		}

		// Token: 0x0602DB18 RID: 187160 RVA: 0x006407B7 File Offset: 0x0063E9B7
		public void UnPackTo(IEnterMovieCameraTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DB19 RID: 187161 RVA: 0x006407C8 File Offset: 0x0063E9C8
		public static Offset<IEnterMovieCameraType> Pack(FlatBufferBuilder builder, IEnterMovieCameraTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterMovieCameraType>);
			}
			return IEnterMovieCameraType.CreateIEnterMovieCameraType(builder, _o.Type);
		}

		// Token: 0x04010D67 RID: 68967
		private Table __p;
	}
}
