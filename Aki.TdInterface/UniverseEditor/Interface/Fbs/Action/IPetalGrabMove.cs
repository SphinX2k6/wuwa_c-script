using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007406 RID: 29702
	public struct IPetalGrabMove : IFlatbufferObject
	{
		// Token: 0x1700DA2C RID: 55852
		// (get) Token: 0x06033F6C RID: 212844 RVA: 0x00701476 File Offset: 0x006FF676
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F6D RID: 212845 RVA: 0x00701483 File Offset: 0x006FF683
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033F6E RID: 212846 RVA: 0x0070148C File Offset: 0x006FF68C
		public static IPetalGrabMove GetRootAsIPetalGrabMove(ByteBuffer _bb)
		{
			return IPetalGrabMove.GetRootAsIPetalGrabMove(_bb, default(IPetalGrabMove));
		}

		// Token: 0x06033F6F RID: 212847 RVA: 0x007014A8 File Offset: 0x006FF6A8
		public static IPetalGrabMove GetRootAsIPetalGrabMove(ByteBuffer _bb, IPetalGrabMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033F70 RID: 212848 RVA: 0x007014C5 File Offset: 0x006FF6C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033F71 RID: 212849 RVA: 0x007014D4 File Offset: 0x006FF6D4
		public IPetalGrabMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA2D RID: 55853
		// (get) Token: 0x06033F72 RID: 212850 RVA: 0x007014E4 File Offset: 0x006FF6E4
		public ESplineMovePattern Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMovePattern.PathLine;
				}
				return (ESplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DA2E RID: 55854
		// (get) Token: 0x06033F73 RID: 212851 RVA: 0x00701520 File Offset: 0x006FF720
		public float MaxOffsetDistance
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DA2F RID: 55855
		// (get) Token: 0x06033F74 RID: 212852 RVA: 0x00701560 File Offset: 0x006FF760
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DA30 RID: 55856
		// (get) Token: 0x06033F75 RID: 212853 RVA: 0x007015A0 File Offset: 0x006FF7A0
		public float LayerVerticalLimit
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DA31 RID: 55857
		// (get) Token: 0x06033F76 RID: 212854 RVA: 0x007015E4 File Offset: 0x006FF7E4
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DA32 RID: 55858
		// (get) Token: 0x06033F77 RID: 212855 RVA: 0x00701624 File Offset: 0x006FF824
		public float GravitySwitchAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DA33 RID: 55859
		// (get) Token: 0x06033F78 RID: 212856 RVA: 0x00701668 File Offset: 0x006FF868
		public int AutoExitDistance
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DA34 RID: 55860
		// (get) Token: 0x06033F79 RID: 212857 RVA: 0x007016A8 File Offset: 0x006FF8A8
		public IPetalGrabMoveLinear? ControlType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IPetalGrabMoveLinear?(default(IPetalGrabMoveLinear).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DA35 RID: 55861
		// (get) Token: 0x06033F7A RID: 212858 RVA: 0x00701708 File Offset: 0x006FF908
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033F7B RID: 212859 RVA: 0x00701748 File Offset: 0x006FF948
		public static Offset<IPetalGrabMove> CreateIPetalGrabMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float MaxOffsetDistance = 0f, bool IsOneWay = false, float LayerVerticalLimit = 0f, bool DynamicGravity = false, float GravitySwitchAngularVelocity = 0f, int AutoExitDistance = 0, Offset<IPetalGrabMoveLinear> ControlTypeOffset = default(Offset<IPetalGrabMoveLinear>), byte NullMask = 0)
		{
			builder.StartTable(9);
			IPetalGrabMove.AddControlType(builder, ControlTypeOffset);
			IPetalGrabMove.AddAutoExitDistance(builder, AutoExitDistance);
			IPetalGrabMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			IPetalGrabMove.AddLayerVerticalLimit(builder, LayerVerticalLimit);
			IPetalGrabMove.AddMaxOffsetDistance(builder, MaxOffsetDistance);
			IPetalGrabMove.AddNullMask(builder, NullMask);
			IPetalGrabMove.AddDynamicGravity(builder, DynamicGravity);
			IPetalGrabMove.AddIsOneWay(builder, IsOneWay);
			IPetalGrabMove.AddType(builder, Type);
			return IPetalGrabMove.EndIPetalGrabMove(builder);
		}

		// Token: 0x06033F7C RID: 212860 RVA: 0x007017A8 File Offset: 0x006FF9A8
		public static void StartIPetalGrabMove(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06033F7D RID: 212861 RVA: 0x007017B2 File Offset: 0x006FF9B2
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033F7E RID: 212862 RVA: 0x007017BD File Offset: 0x006FF9BD
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x06033F7F RID: 212863 RVA: 0x007017D0 File Offset: 0x006FF9D0
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x06033F80 RID: 212864 RVA: 0x007017DB File Offset: 0x006FF9DB
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x06033F81 RID: 212865 RVA: 0x007017EE File Offset: 0x006FF9EE
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x06033F82 RID: 212866 RVA: 0x007017F9 File Offset: 0x006FF9F9
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x06033F83 RID: 212867 RVA: 0x0070180C File Offset: 0x006FFA0C
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x06033F84 RID: 212868 RVA: 0x00701817 File Offset: 0x006FFA17
		public static void AddControlType(FlatBufferBuilder builder, Offset<IPetalGrabMoveLinear> controlTypeOffset)
		{
			builder.AddOffset(7, controlTypeOffset.Value, 0);
		}

		// Token: 0x06033F85 RID: 212869 RVA: 0x00701827 File Offset: 0x006FFA27
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06033F86 RID: 212870 RVA: 0x00701832 File Offset: 0x006FFA32
		public static Offset<IPetalGrabMove> EndIPetalGrabMove(FlatBufferBuilder builder)
		{
			return new Offset<IPetalGrabMove>(builder.EndTable());
		}

		// Token: 0x06033F87 RID: 212871 RVA: 0x00701840 File Offset: 0x006FFA40
		public IPetalGrabMoveT UnPack()
		{
			IPetalGrabMoveT petalGrabMoveT = new IPetalGrabMoveT();
			this.UnPackTo(petalGrabMoveT);
			return petalGrabMoveT;
		}

		// Token: 0x06033F88 RID: 212872 RVA: 0x0070185C File Offset: 0x006FFA5C
		public void UnPackTo(IPetalGrabMoveT _o)
		{
			_o.Type = this.Type;
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.IsOneWay = this.IsOneWay;
			_o.LayerVerticalLimit = this.LayerVerticalLimit;
			_o.DynamicGravity = this.DynamicGravity;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.AutoExitDistance = this.AutoExitDistance;
			_o.ControlType = ((this.ControlType != null) ? this.ControlType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033F89 RID: 212873 RVA: 0x007018F8 File Offset: 0x006FFAF8
		public static Offset<IPetalGrabMove> Pack(FlatBufferBuilder builder, IPetalGrabMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPetalGrabMove>);
			}
			Offset<IPetalGrabMoveLinear> controlTypeOffset = (_o.ControlType == null) ? default(Offset<IPetalGrabMoveLinear>) : IPetalGrabMoveLinear.Pack(builder, _o.ControlType);
			return IPetalGrabMove.CreateIPetalGrabMove(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, controlTypeOffset, _o.NullMask);
		}

		// Token: 0x0401254D RID: 75085
		private Table __p;
	}
}
