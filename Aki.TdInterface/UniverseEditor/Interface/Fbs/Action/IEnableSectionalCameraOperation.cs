using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200667E RID: 26238
	public struct IEnableSectionalCameraOperation : IFlatbufferObject
	{
		// Token: 0x1700C2E3 RID: 49891
		// (get) Token: 0x0602D953 RID: 186707 RVA: 0x0063D725 File Offset: 0x0063B925
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D954 RID: 186708 RVA: 0x0063D732 File Offset: 0x0063B932
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D955 RID: 186709 RVA: 0x0063D73C File Offset: 0x0063B93C
		public static IEnableSectionalCameraOperation GetRootAsIEnableSectionalCameraOperation(ByteBuffer _bb)
		{
			return IEnableSectionalCameraOperation.GetRootAsIEnableSectionalCameraOperation(_bb, default(IEnableSectionalCameraOperation));
		}

		// Token: 0x0602D956 RID: 186710 RVA: 0x0063D758 File Offset: 0x0063B958
		public static IEnableSectionalCameraOperation GetRootAsIEnableSectionalCameraOperation(ByteBuffer _bb, IEnableSectionalCameraOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D957 RID: 186711 RVA: 0x0063D775 File Offset: 0x0063B975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D958 RID: 186712 RVA: 0x0063D784 File Offset: 0x0063B984
		public IEnableSectionalCameraOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2E4 RID: 49892
		// (get) Token: 0x0602D959 RID: 186713 RVA: 0x0063D794 File Offset: 0x0063B994
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

		// Token: 0x1700C2E5 RID: 49893
		// (get) Token: 0x0602D95A RID: 186714 RVA: 0x0063D7D0 File Offset: 0x0063B9D0
		public bool EnableRotate
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2E6 RID: 49894
		// (get) Token: 0x0602D95B RID: 186715 RVA: 0x0063D810 File Offset: 0x0063BA10
		public bool EnableZoom
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2E7 RID: 49895
		// (get) Token: 0x0602D95C RID: 186716 RVA: 0x0063D850 File Offset: 0x0063BA50
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

		// Token: 0x0602D95D RID: 186717 RVA: 0x0063D88D File Offset: 0x0063BA8D
		public static Offset<IEnableSectionalCameraOperation> CreateIEnableSectionalCameraOperation(FlatBufferBuilder builder, ECameraOperationType Type = ECameraOperationType.Enable, bool EnableRotate = false, bool EnableZoom = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEnableSectionalCameraOperation.AddNullMask(builder, NullMask);
			IEnableSectionalCameraOperation.AddEnableZoom(builder, EnableZoom);
			IEnableSectionalCameraOperation.AddEnableRotate(builder, EnableRotate);
			IEnableSectionalCameraOperation.AddType(builder, Type);
			return IEnableSectionalCameraOperation.EndIEnableSectionalCameraOperation(builder);
		}

		// Token: 0x0602D95E RID: 186718 RVA: 0x0063D8B9 File Offset: 0x0063BAB9
		public static void StartIEnableSectionalCameraOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D95F RID: 186719 RVA: 0x0063D8C2 File Offset: 0x0063BAC2
		public static void AddType(FlatBufferBuilder builder, ECameraOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D960 RID: 186720 RVA: 0x0063D8CD File Offset: 0x0063BACD
		public static void AddEnableRotate(FlatBufferBuilder builder, bool enableRotate)
		{
			builder.AddBool(1, enableRotate, false);
		}

		// Token: 0x0602D961 RID: 186721 RVA: 0x0063D8D8 File Offset: 0x0063BAD8
		public static void AddEnableZoom(FlatBufferBuilder builder, bool enableZoom)
		{
			builder.AddBool(2, enableZoom, false);
		}

		// Token: 0x0602D962 RID: 186722 RVA: 0x0063D8E3 File Offset: 0x0063BAE3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602D963 RID: 186723 RVA: 0x0063D8EE File Offset: 0x0063BAEE
		public static Offset<IEnableSectionalCameraOperation> EndIEnableSectionalCameraOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSectionalCameraOperation>(builder.EndTable());
		}

		// Token: 0x0602D964 RID: 186724 RVA: 0x0063D8FC File Offset: 0x0063BAFC
		public IEnableSectionalCameraOperationT UnPack()
		{
			IEnableSectionalCameraOperationT enableSectionalCameraOperationT = new IEnableSectionalCameraOperationT();
			this.UnPackTo(enableSectionalCameraOperationT);
			return enableSectionalCameraOperationT;
		}

		// Token: 0x0602D965 RID: 186725 RVA: 0x0063D917 File Offset: 0x0063BB17
		public void UnPackTo(IEnableSectionalCameraOperationT _o)
		{
			_o.Type = this.Type;
			_o.EnableRotate = this.EnableRotate;
			_o.EnableZoom = this.EnableZoom;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D966 RID: 186726 RVA: 0x0063D94C File Offset: 0x0063BB4C
		public static Offset<IEnableSectionalCameraOperation> Pack(FlatBufferBuilder builder, IEnableSectionalCameraOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSectionalCameraOperation>);
			}
			return IEnableSectionalCameraOperation.CreateIEnableSectionalCameraOperation(builder, _o.Type, _o.EnableRotate, _o.EnableZoom, _o.NullMask);
		}

		// Token: 0x04010D24 RID: 68900
		private Table __p;
	}
}
