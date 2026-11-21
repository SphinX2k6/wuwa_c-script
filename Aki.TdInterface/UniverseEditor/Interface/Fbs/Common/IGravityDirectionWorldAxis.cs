using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006440 RID: 25664
	public struct IGravityDirectionWorldAxis : IFlatbufferObject
	{
		// Token: 0x1700BD77 RID: 48503
		// (get) Token: 0x0602B9A6 RID: 178598 RVA: 0x005EF978 File Offset: 0x005EDB78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B9A7 RID: 178599 RVA: 0x005EF985 File Offset: 0x005EDB85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B9A8 RID: 178600 RVA: 0x005EF98C File Offset: 0x005EDB8C
		public static IGravityDirectionWorldAxis GetRootAsIGravityDirectionWorldAxis(ByteBuffer _bb)
		{
			return IGravityDirectionWorldAxis.GetRootAsIGravityDirectionWorldAxis(_bb, default(IGravityDirectionWorldAxis));
		}

		// Token: 0x0602B9A9 RID: 178601 RVA: 0x005EF9A8 File Offset: 0x005EDBA8
		public static IGravityDirectionWorldAxis GetRootAsIGravityDirectionWorldAxis(ByteBuffer _bb, IGravityDirectionWorldAxis obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B9AA RID: 178602 RVA: 0x005EF9C5 File Offset: 0x005EDBC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B9AB RID: 178603 RVA: 0x005EF9D4 File Offset: 0x005EDBD4
		public IGravityDirectionWorldAxis __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD78 RID: 48504
		// (get) Token: 0x0602B9AC RID: 178604 RVA: 0x005EF9E4 File Offset: 0x005EDBE4
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

		// Token: 0x1700BD79 RID: 48505
		// (get) Token: 0x0602B9AD RID: 178605 RVA: 0x005EFA20 File Offset: 0x005EDC20
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

		// Token: 0x0602B9AE RID: 178606 RVA: 0x005EFA5C File Offset: 0x005EDC5C
		public static Offset<IGravityDirectionWorldAxis> CreateIGravityDirectionWorldAxis(FlatBufferBuilder builder, EGravityDirectionType Type = EGravityDirectionType.SelfRotation, EWorldAxisType WorldAxis = EWorldAxisType.PositiveX)
		{
			builder.StartTable(2);
			IGravityDirectionWorldAxis.AddWorldAxis(builder, WorldAxis);
			IGravityDirectionWorldAxis.AddType(builder, Type);
			return IGravityDirectionWorldAxis.EndIGravityDirectionWorldAxis(builder);
		}

		// Token: 0x0602B9AF RID: 178607 RVA: 0x005EFA79 File Offset: 0x005EDC79
		public static void StartIGravityDirectionWorldAxis(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B9B0 RID: 178608 RVA: 0x005EFA82 File Offset: 0x005EDC82
		public static void AddType(FlatBufferBuilder builder, EGravityDirectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B9B1 RID: 178609 RVA: 0x005EFA8D File Offset: 0x005EDC8D
		public static void AddWorldAxis(FlatBufferBuilder builder, EWorldAxisType worldAxis)
		{
			builder.AddByte(1, (byte)worldAxis, 0);
		}

		// Token: 0x0602B9B2 RID: 178610 RVA: 0x005EFA98 File Offset: 0x005EDC98
		public static Offset<IGravityDirectionWorldAxis> EndIGravityDirectionWorldAxis(FlatBufferBuilder builder)
		{
			return new Offset<IGravityDirectionWorldAxis>(builder.EndTable());
		}

		// Token: 0x0602B9B3 RID: 178611 RVA: 0x005EFAA8 File Offset: 0x005EDCA8
		public IGravityDirectionWorldAxisT UnPack()
		{
			IGravityDirectionWorldAxisT gravityDirectionWorldAxisT = new IGravityDirectionWorldAxisT();
			this.UnPackTo(gravityDirectionWorldAxisT);
			return gravityDirectionWorldAxisT;
		}

		// Token: 0x0602B9B4 RID: 178612 RVA: 0x005EFAC3 File Offset: 0x005EDCC3
		public void UnPackTo(IGravityDirectionWorldAxisT _o)
		{
			_o.Type = this.Type;
			_o.WorldAxis = this.WorldAxis;
		}

		// Token: 0x0602B9B5 RID: 178613 RVA: 0x005EFAE0 File Offset: 0x005EDCE0
		public static Offset<IGravityDirectionWorldAxis> Pack(FlatBufferBuilder builder, IGravityDirectionWorldAxisT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityDirectionWorldAxis>);
			}
			return IGravityDirectionWorldAxis.CreateIGravityDirectionWorldAxis(builder, _o.Type, _o.WorldAxis);
		}

		// Token: 0x04010550 RID: 66896
		private Table __p;
	}
}
