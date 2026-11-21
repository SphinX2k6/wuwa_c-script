using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CDB RID: 23771
	public struct IPathDrivenActorInitialSpawnHandle : IFlatbufferObject
	{
		// Token: 0x1700AEAB RID: 44715
		// (get) Token: 0x06027769 RID: 161641 RVA: 0x00566A5F File Offset: 0x00564C5F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602776A RID: 161642 RVA: 0x00566A6C File Offset: 0x00564C6C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602776B RID: 161643 RVA: 0x00566A74 File Offset: 0x00564C74
		public static IPathDrivenActorInitialSpawnHandle GetRootAsIPathDrivenActorInitialSpawnHandle(ByteBuffer _bb)
		{
			return IPathDrivenActorInitialSpawnHandle.GetRootAsIPathDrivenActorInitialSpawnHandle(_bb, default(IPathDrivenActorInitialSpawnHandle));
		}

		// Token: 0x0602776C RID: 161644 RVA: 0x00566A90 File Offset: 0x00564C90
		public static IPathDrivenActorInitialSpawnHandle GetRootAsIPathDrivenActorInitialSpawnHandle(ByteBuffer _bb, IPathDrivenActorInitialSpawnHandle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602776D RID: 161645 RVA: 0x00566AAD File Offset: 0x00564CAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602776E RID: 161646 RVA: 0x00566ABC File Offset: 0x00564CBC
		public IPathDrivenActorInitialSpawnHandle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEAC RID: 44716
		// (get) Token: 0x0602776F RID: 161647 RVA: 0x00566ACC File Offset: 0x00564CCC
		public int Index
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AEAD RID: 44717
		// (get) Token: 0x06027770 RID: 161648 RVA: 0x00566B08 File Offset: 0x00564D08
		public EPathDrivenActorInitialSpawnHandleType HandleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation;
				}
				return (EPathDrivenActorInitialSpawnHandleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027771 RID: 161649 RVA: 0x00566B44 File Offset: 0x00564D44
		public static Offset<IPathDrivenActorInitialSpawnHandle> CreateIPathDrivenActorInitialSpawnHandle(FlatBufferBuilder builder, int Index = 0, EPathDrivenActorInitialSpawnHandleType HandleType = EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation)
		{
			builder.StartTable(2);
			IPathDrivenActorInitialSpawnHandle.AddIndex(builder, Index);
			IPathDrivenActorInitialSpawnHandle.AddHandleType(builder, HandleType);
			return IPathDrivenActorInitialSpawnHandle.EndIPathDrivenActorInitialSpawnHandle(builder);
		}

		// Token: 0x06027772 RID: 161650 RVA: 0x00566B61 File Offset: 0x00564D61
		public static void StartIPathDrivenActorInitialSpawnHandle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027773 RID: 161651 RVA: 0x00566B6A File Offset: 0x00564D6A
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		// Token: 0x06027774 RID: 161652 RVA: 0x00566B75 File Offset: 0x00564D75
		public static void AddHandleType(FlatBufferBuilder builder, EPathDrivenActorInitialSpawnHandleType handleType)
		{
			builder.AddByte(1, (byte)handleType, 0);
		}

		// Token: 0x06027775 RID: 161653 RVA: 0x00566B80 File Offset: 0x00564D80
		public static Offset<IPathDrivenActorInitialSpawnHandle> EndIPathDrivenActorInitialSpawnHandle(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorInitialSpawnHandle>(builder.EndTable());
		}

		// Token: 0x06027776 RID: 161654 RVA: 0x00566B90 File Offset: 0x00564D90
		public IPathDrivenActorInitialSpawnHandleT UnPack()
		{
			IPathDrivenActorInitialSpawnHandleT pathDrivenActorInitialSpawnHandleT = new IPathDrivenActorInitialSpawnHandleT();
			this.UnPackTo(pathDrivenActorInitialSpawnHandleT);
			return pathDrivenActorInitialSpawnHandleT;
		}

		// Token: 0x06027777 RID: 161655 RVA: 0x00566BAB File Offset: 0x00564DAB
		public void UnPackTo(IPathDrivenActorInitialSpawnHandleT _o)
		{
			_o.Index = this.Index;
			_o.HandleType = this.HandleType;
		}

		// Token: 0x06027778 RID: 161656 RVA: 0x00566BC8 File Offset: 0x00564DC8
		public static Offset<IPathDrivenActorInitialSpawnHandle> Pack(FlatBufferBuilder builder, IPathDrivenActorInitialSpawnHandleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathDrivenActorInitialSpawnHandle>);
			}
			return IPathDrivenActorInitialSpawnHandle.CreateIPathDrivenActorInitialSpawnHandle(builder, _o.Index, _o.HandleType);
		}

		// Token: 0x0400F80A RID: 63498
		private Table __p;
	}
}
