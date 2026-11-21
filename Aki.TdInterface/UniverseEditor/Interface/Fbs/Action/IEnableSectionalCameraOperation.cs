using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF8 RID: 27896
	public struct IEnableSectionalCameraOperation : IFlatbufferObject
	{
		// Token: 0x1700CC94 RID: 52372
		// (get) Token: 0x06030170 RID: 196976 RVA: 0x0068A9D9 File Offset: 0x00688BD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030171 RID: 196977 RVA: 0x0068A9E6 File Offset: 0x00688BE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030172 RID: 196978 RVA: 0x0068A9F0 File Offset: 0x00688BF0
		public static IEnableSectionalCameraOperation GetRootAsIEnableSectionalCameraOperation(ByteBuffer _bb)
		{
			return IEnableSectionalCameraOperation.GetRootAsIEnableSectionalCameraOperation(_bb, default(IEnableSectionalCameraOperation));
		}

		// Token: 0x06030173 RID: 196979 RVA: 0x0068AA0C File Offset: 0x00688C0C
		public static IEnableSectionalCameraOperation GetRootAsIEnableSectionalCameraOperation(ByteBuffer _bb, IEnableSectionalCameraOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030174 RID: 196980 RVA: 0x0068AA29 File Offset: 0x00688C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030175 RID: 196981 RVA: 0x0068AA38 File Offset: 0x00688C38
		public IEnableSectionalCameraOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC95 RID: 52373
		// (get) Token: 0x06030176 RID: 196982 RVA: 0x0068AA48 File Offset: 0x00688C48
		public ECameraOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraOperationType.Enable;
				}
				return (ECameraOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC96 RID: 52374
		// (get) Token: 0x06030177 RID: 196983 RVA: 0x0068AA84 File Offset: 0x00688C84
		public bool EnableRotate
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC97 RID: 52375
		// (get) Token: 0x06030178 RID: 196984 RVA: 0x0068AAC4 File Offset: 0x00688CC4
		public bool EnableZoom
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC98 RID: 52376
		// (get) Token: 0x06030179 RID: 196985 RVA: 0x0068AB04 File Offset: 0x00688D04
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

		// Token: 0x0603017A RID: 196986 RVA: 0x0068AB41 File Offset: 0x00688D41
		public static Offset<IEnableSectionalCameraOperation> CreateIEnableSectionalCameraOperation(FlatBufferBuilder builder, ECameraOperationType Type = ECameraOperationType.Enable, bool EnableRotate = false, bool EnableZoom = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEnableSectionalCameraOperation.AddNullMask(builder, NullMask);
			IEnableSectionalCameraOperation.AddEnableZoom(builder, EnableZoom);
			IEnableSectionalCameraOperation.AddEnableRotate(builder, EnableRotate);
			IEnableSectionalCameraOperation.AddType(builder, Type);
			return IEnableSectionalCameraOperation.EndIEnableSectionalCameraOperation(builder);
		}

		// Token: 0x0603017B RID: 196987 RVA: 0x0068AB6D File Offset: 0x00688D6D
		public static void StartIEnableSectionalCameraOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603017C RID: 196988 RVA: 0x0068AB76 File Offset: 0x00688D76
		public static void AddType(FlatBufferBuilder builder, ECameraOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603017D RID: 196989 RVA: 0x0068AB81 File Offset: 0x00688D81
		public static void AddEnableRotate(FlatBufferBuilder builder, bool enableRotate)
		{
			builder.AddBool(1, enableRotate, false);
		}

		// Token: 0x0603017E RID: 196990 RVA: 0x0068AB8C File Offset: 0x00688D8C
		public static void AddEnableZoom(FlatBufferBuilder builder, bool enableZoom)
		{
			builder.AddBool(2, enableZoom, false);
		}

		// Token: 0x0603017F RID: 196991 RVA: 0x0068AB97 File Offset: 0x00688D97
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06030180 RID: 196992 RVA: 0x0068ABA2 File Offset: 0x00688DA2
		public static Offset<IEnableSectionalCameraOperation> EndIEnableSectionalCameraOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSectionalCameraOperation>(builder.EndTable());
		}

		// Token: 0x06030181 RID: 196993 RVA: 0x0068ABB0 File Offset: 0x00688DB0
		public IEnableSectionalCameraOperationT UnPack()
		{
			IEnableSectionalCameraOperationT enableSectionalCameraOperationT = new IEnableSectionalCameraOperationT();
			this.UnPackTo(enableSectionalCameraOperationT);
			return enableSectionalCameraOperationT;
		}

		// Token: 0x06030182 RID: 196994 RVA: 0x0068ABCB File Offset: 0x00688DCB
		public void UnPackTo(IEnableSectionalCameraOperationT _o)
		{
			_o.Type = this.Type;
			_o.EnableRotate = this.EnableRotate;
			_o.EnableZoom = this.EnableZoom;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030183 RID: 196995 RVA: 0x0068AC00 File Offset: 0x00688E00
		public static Offset<IEnableSectionalCameraOperation> Pack(FlatBufferBuilder builder, IEnableSectionalCameraOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSectionalCameraOperation>);
			}
			return IEnableSectionalCameraOperation.CreateIEnableSectionalCameraOperation(builder, _o.Type, _o.EnableRotate, _o.EnableZoom, _o.NullMask);
		}

		// Token: 0x04011B4A RID: 72522
		private Table __p;
	}
}
