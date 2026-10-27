using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E03 RID: 24067
	public struct IGravityDirectionWorldAxis : IFlatbufferObject
	{
		// Token: 0x1700B411 RID: 46097
		// (get) Token: 0x0602931C RID: 168732 RVA: 0x005A6C48 File Offset: 0x005A4E48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602931D RID: 168733 RVA: 0x005A6C55 File Offset: 0x005A4E55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602931E RID: 168734 RVA: 0x005A6C5C File Offset: 0x005A4E5C
		public static IGravityDirectionWorldAxis GetRootAsIGravityDirectionWorldAxis(ByteBuffer _bb)
		{
			return IGravityDirectionWorldAxis.GetRootAsIGravityDirectionWorldAxis(_bb, default(IGravityDirectionWorldAxis));
		}

		// Token: 0x0602931F RID: 168735 RVA: 0x005A6C78 File Offset: 0x005A4E78
		public static IGravityDirectionWorldAxis GetRootAsIGravityDirectionWorldAxis(ByteBuffer _bb, IGravityDirectionWorldAxis obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029320 RID: 168736 RVA: 0x005A6C95 File Offset: 0x005A4E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029321 RID: 168737 RVA: 0x005A6CA4 File Offset: 0x005A4EA4
		public IGravityDirectionWorldAxis __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B412 RID: 46098
		// (get) Token: 0x06029322 RID: 168738 RVA: 0x005A6CB4 File Offset: 0x005A4EB4
		public EGravityDirectionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGravityDirectionType.SelfRotation;
				}
				return (EGravityDirectionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B413 RID: 46099
		// (get) Token: 0x06029323 RID: 168739 RVA: 0x005A6CF0 File Offset: 0x005A4EF0
		public EWorldAxisType WorldAxis
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EWorldAxisType.PositiveX;
				}
				return (EWorldAxisType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029324 RID: 168740 RVA: 0x005A6D2C File Offset: 0x005A4F2C
		public static Offset<IGravityDirectionWorldAxis> CreateIGravityDirectionWorldAxis(FlatBufferBuilder builder, EGravityDirectionType Type = EGravityDirectionType.SelfRotation, EWorldAxisType WorldAxis = EWorldAxisType.PositiveX)
		{
			builder.StartTable(2);
			IGravityDirectionWorldAxis.AddWorldAxis(builder, WorldAxis);
			IGravityDirectionWorldAxis.AddType(builder, Type);
			return IGravityDirectionWorldAxis.EndIGravityDirectionWorldAxis(builder);
		}

		// Token: 0x06029325 RID: 168741 RVA: 0x005A6D49 File Offset: 0x005A4F49
		public static void StartIGravityDirectionWorldAxis(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029326 RID: 168742 RVA: 0x005A6D52 File Offset: 0x005A4F52
		public static void AddType(FlatBufferBuilder builder, EGravityDirectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029327 RID: 168743 RVA: 0x005A6D5D File Offset: 0x005A4F5D
		public static void AddWorldAxis(FlatBufferBuilder builder, EWorldAxisType worldAxis)
		{
			builder.AddByte(1, (byte)worldAxis, 0);
		}

		// Token: 0x06029328 RID: 168744 RVA: 0x005A6D68 File Offset: 0x005A4F68
		public static Offset<IGravityDirectionWorldAxis> EndIGravityDirectionWorldAxis(FlatBufferBuilder builder)
		{
			return new Offset<IGravityDirectionWorldAxis>(builder.EndTable());
		}

		// Token: 0x06029329 RID: 168745 RVA: 0x005A6D78 File Offset: 0x005A4F78
		public IGravityDirectionWorldAxisT UnPack()
		{
			IGravityDirectionWorldAxisT gravityDirectionWorldAxisT = new IGravityDirectionWorldAxisT();
			this.UnPackTo(gravityDirectionWorldAxisT);
			return gravityDirectionWorldAxisT;
		}

		// Token: 0x0602932A RID: 168746 RVA: 0x005A6D93 File Offset: 0x005A4F93
		public void UnPackTo(IGravityDirectionWorldAxisT _o)
		{
			_o.Type = this.Type;
			_o.WorldAxis = this.WorldAxis;
		}

		// Token: 0x0602932B RID: 168747 RVA: 0x005A6DB0 File Offset: 0x005A4FB0
		public static Offset<IGravityDirectionWorldAxis> Pack(FlatBufferBuilder builder, IGravityDirectionWorldAxisT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityDirectionWorldAxis>);
			}
			return IGravityDirectionWorldAxis.CreateIGravityDirectionWorldAxis(builder, _o.Type, _o.WorldAxis);
		}

		// Token: 0x0400F7F5 RID: 63477
		private Table __p;
	}
}
