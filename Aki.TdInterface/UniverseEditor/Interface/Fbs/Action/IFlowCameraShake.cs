using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F5 RID: 26613
	public struct IFlowCameraShake : IFlatbufferObject
	{
		// Token: 0x1700C58E RID: 50574
		// (get) Token: 0x0602E56F RID: 189807 RVA: 0x0065366F File Offset: 0x0065186F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E570 RID: 189808 RVA: 0x0065367C File Offset: 0x0065187C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E571 RID: 189809 RVA: 0x00653684 File Offset: 0x00651884
		public static IFlowCameraShake GetRootAsIFlowCameraShake(ByteBuffer _bb)
		{
			return IFlowCameraShake.GetRootAsIFlowCameraShake(_bb, default(IFlowCameraShake));
		}

		// Token: 0x0602E572 RID: 189810 RVA: 0x006536A0 File Offset: 0x006518A0
		public static IFlowCameraShake GetRootAsIFlowCameraShake(ByteBuffer _bb, IFlowCameraShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E573 RID: 189811 RVA: 0x006536BD File Offset: 0x006518BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E574 RID: 189812 RVA: 0x006536CC File Offset: 0x006518CC
		public IFlowCameraShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C58F RID: 50575
		// (get) Token: 0x0602E575 RID: 189813 RVA: 0x006536DC File Offset: 0x006518DC
		public string CameraShakeBp
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E576 RID: 189814 RVA: 0x00653713 File Offset: 0x00651913
		public Span<byte> GetCameraShakeBpBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E577 RID: 189815 RVA: 0x00653722 File Offset: 0x00651922
		public byte[] GetCameraShakeBpArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602E578 RID: 189816 RVA: 0x00653730 File Offset: 0x00651930
		public static Offset<IFlowCameraShake> CreateIFlowCameraShake(FlatBufferBuilder builder, StringOffset CameraShakeBpOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IFlowCameraShake.AddCameraShakeBp(builder, CameraShakeBpOffset);
			return IFlowCameraShake.EndIFlowCameraShake(builder);
		}

		// Token: 0x0602E579 RID: 189817 RVA: 0x00653746 File Offset: 0x00651946
		public static void StartIFlowCameraShake(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E57A RID: 189818 RVA: 0x0065374F File Offset: 0x0065194F
		public static void AddCameraShakeBp(FlatBufferBuilder builder, StringOffset cameraShakeBpOffset)
		{
			builder.AddOffset(0, cameraShakeBpOffset.Value, 0);
		}

		// Token: 0x0602E57B RID: 189819 RVA: 0x0065375F File Offset: 0x0065195F
		public static Offset<IFlowCameraShake> EndIFlowCameraShake(FlatBufferBuilder builder)
		{
			return new Offset<IFlowCameraShake>(builder.EndTable());
		}

		// Token: 0x0602E57C RID: 189820 RVA: 0x0065376C File Offset: 0x0065196C
		public IFlowCameraShakeT UnPack()
		{
			IFlowCameraShakeT flowCameraShakeT = new IFlowCameraShakeT();
			this.UnPackTo(flowCameraShakeT);
			return flowCameraShakeT;
		}

		// Token: 0x0602E57D RID: 189821 RVA: 0x00653787 File Offset: 0x00651987
		public void UnPackTo(IFlowCameraShakeT _o)
		{
			_o.CameraShakeBp = this.CameraShakeBp;
		}

		// Token: 0x0602E57E RID: 189822 RVA: 0x00653798 File Offset: 0x00651998
		public static Offset<IFlowCameraShake> Pack(FlatBufferBuilder builder, IFlowCameraShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowCameraShake>);
			}
			StringOffset cameraShakeBpOffset = (_o.CameraShakeBp == null) ? default(StringOffset) : builder.CreateString(_o.CameraShakeBp);
			return IFlowCameraShake.CreateIFlowCameraShake(builder, cameraShakeBpOffset);
		}

		// Token: 0x04010F15 RID: 69397
		private Table __p;
	}
}
