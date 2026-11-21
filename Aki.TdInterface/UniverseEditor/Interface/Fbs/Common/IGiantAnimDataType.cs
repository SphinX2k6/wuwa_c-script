using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063F2 RID: 25586
	public struct IGiantAnimDataType : IFlatbufferObject
	{
		// Token: 0x1700BD07 RID: 48391
		// (get) Token: 0x0602B77C RID: 178044 RVA: 0x005EC02F File Offset: 0x005EA22F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B77D RID: 178045 RVA: 0x005EC03C File Offset: 0x005EA23C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B77E RID: 178046 RVA: 0x005EC044 File Offset: 0x005EA244
		public static IGiantAnimDataType GetRootAsIGiantAnimDataType(ByteBuffer _bb)
		{
			return IGiantAnimDataType.GetRootAsIGiantAnimDataType(_bb, default(IGiantAnimDataType));
		}

		// Token: 0x0602B77F RID: 178047 RVA: 0x005EC060 File Offset: 0x005EA260
		public static IGiantAnimDataType GetRootAsIGiantAnimDataType(ByteBuffer _bb, IGiantAnimDataType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B780 RID: 178048 RVA: 0x005EC07D File Offset: 0x005EA27D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B781 RID: 178049 RVA: 0x005EC08C File Offset: 0x005EA28C
		public IGiantAnimDataType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD08 RID: 48392
		// (get) Token: 0x0602B782 RID: 178050 RVA: 0x005EC09C File Offset: 0x005EA29C
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

		// Token: 0x0602B783 RID: 178051 RVA: 0x005EC0D8 File Offset: 0x005EA2D8
		public static Offset<IGiantAnimDataType> CreateIGiantAnimDataType(FlatBufferBuilder builder, EGiantAnimationType Type = EGiantAnimationType.Idle)
		{
			builder.StartTable(1);
			IGiantAnimDataType.AddType(builder, Type);
			return IGiantAnimDataType.EndIGiantAnimDataType(builder);
		}

		// Token: 0x0602B784 RID: 178052 RVA: 0x005EC0EE File Offset: 0x005EA2EE
		public static void StartIGiantAnimDataType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B785 RID: 178053 RVA: 0x005EC0F7 File Offset: 0x005EA2F7
		public static void AddType(FlatBufferBuilder builder, EGiantAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B786 RID: 178054 RVA: 0x005EC102 File Offset: 0x005EA302
		public static Offset<IGiantAnimDataType> EndIGiantAnimDataType(FlatBufferBuilder builder)
		{
			return new Offset<IGiantAnimDataType>(builder.EndTable());
		}

		// Token: 0x0602B787 RID: 178055 RVA: 0x005EC110 File Offset: 0x005EA310
		public IGiantAnimDataTypeT UnPack()
		{
			IGiantAnimDataTypeT giantAnimDataTypeT = new IGiantAnimDataTypeT();
			this.UnPackTo(giantAnimDataTypeT);
			return giantAnimDataTypeT;
		}

		// Token: 0x0602B788 RID: 178056 RVA: 0x005EC12B File Offset: 0x005EA32B
		public void UnPackTo(IGiantAnimDataTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B789 RID: 178057 RVA: 0x005EC13C File Offset: 0x005EA33C
		public static Offset<IGiantAnimDataType> Pack(FlatBufferBuilder builder, IGiantAnimDataTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantAnimDataType>);
			}
			return IGiantAnimDataType.CreateIGiantAnimDataType(builder, _o.Type);
		}

		// Token: 0x040104ED RID: 66797
		private Table __p;
	}
}
