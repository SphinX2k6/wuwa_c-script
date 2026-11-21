using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007403 RID: 29699
	public struct IPetalGrabConfig : IFlatbufferObject
	{
		// Token: 0x1700DA27 RID: 55847
		// (get) Token: 0x06033F56 RID: 212822 RVA: 0x00701275 File Offset: 0x006FF475
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F57 RID: 212823 RVA: 0x00701282 File Offset: 0x006FF482
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033F58 RID: 212824 RVA: 0x0070128C File Offset: 0x006FF48C
		public static IPetalGrabConfig GetRootAsIPetalGrabConfig(ByteBuffer _bb)
		{
			return IPetalGrabConfig.GetRootAsIPetalGrabConfig(_bb, default(IPetalGrabConfig));
		}

		// Token: 0x06033F59 RID: 212825 RVA: 0x007012A8 File Offset: 0x006FF4A8
		public static IPetalGrabConfig GetRootAsIPetalGrabConfig(ByteBuffer _bb, IPetalGrabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033F5A RID: 212826 RVA: 0x007012C5 File Offset: 0x006FF4C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033F5B RID: 212827 RVA: 0x007012D4 File Offset: 0x006FF4D4
		public IPetalGrabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA28 RID: 55848
		// (get) Token: 0x06033F5C RID: 212828 RVA: 0x007012E4 File Offset: 0x006FF4E4
		public ESportStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESportStateType.Slide;
				}
				return (ESportStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DA29 RID: 55849
		// (get) Token: 0x06033F5D RID: 212829 RVA: 0x00701320 File Offset: 0x006FF520
		public int FirstGrabEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033F5E RID: 212830 RVA: 0x0070135C File Offset: 0x006FF55C
		public static Offset<IPetalGrabConfig> CreateIPetalGrabConfig(FlatBufferBuilder builder, ESportStateType Type = ESportStateType.Slide, int FirstGrabEntityId = 0)
		{
			builder.StartTable(2);
			IPetalGrabConfig.AddFirstGrabEntityId(builder, FirstGrabEntityId);
			IPetalGrabConfig.AddType(builder, Type);
			return IPetalGrabConfig.EndIPetalGrabConfig(builder);
		}

		// Token: 0x06033F5F RID: 212831 RVA: 0x00701379 File Offset: 0x006FF579
		public static void StartIPetalGrabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033F60 RID: 212832 RVA: 0x00701382 File Offset: 0x006FF582
		public static void AddType(FlatBufferBuilder builder, ESportStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033F61 RID: 212833 RVA: 0x0070138D File Offset: 0x006FF58D
		public static void AddFirstGrabEntityId(FlatBufferBuilder builder, int firstGrabEntityId)
		{
			builder.AddInt(1, firstGrabEntityId, 0);
		}

		// Token: 0x06033F62 RID: 212834 RVA: 0x00701398 File Offset: 0x006FF598
		public static Offset<IPetalGrabConfig> EndIPetalGrabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPetalGrabConfig>(builder.EndTable());
		}

		// Token: 0x06033F63 RID: 212835 RVA: 0x007013A8 File Offset: 0x006FF5A8
		public IPetalGrabConfigT UnPack()
		{
			IPetalGrabConfigT petalGrabConfigT = new IPetalGrabConfigT();
			this.UnPackTo(petalGrabConfigT);
			return petalGrabConfigT;
		}

		// Token: 0x06033F64 RID: 212836 RVA: 0x007013C3 File Offset: 0x006FF5C3
		public void UnPackTo(IPetalGrabConfigT _o)
		{
			_o.Type = this.Type;
			_o.FirstGrabEntityId = this.FirstGrabEntityId;
		}

		// Token: 0x06033F65 RID: 212837 RVA: 0x007013E0 File Offset: 0x006FF5E0
		public static Offset<IPetalGrabConfig> Pack(FlatBufferBuilder builder, IPetalGrabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPetalGrabConfig>);
			}
			return IPetalGrabConfig.CreateIPetalGrabConfig(builder, _o.Type, _o.FirstGrabEntityId);
		}

		// Token: 0x0401254A RID: 75082
		private Table __p;
	}
}
