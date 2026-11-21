using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A6 RID: 27046
	public struct IChangeTimerUiConfig : IFlatbufferObject
	{
		// Token: 0x1700C713 RID: 50963
		// (get) Token: 0x0602E64C RID: 190028 RVA: 0x00654F52 File Offset: 0x00653152
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E64D RID: 190029 RVA: 0x00654F5F File Offset: 0x0065315F
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x0602E64E RID: 190030 RVA: 0x00654F6E File Offset: 0x0065316E
		public IChangeTimerUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C714 RID: 50964
		// (get) Token: 0x0602E64F RID: 190031 RVA: 0x00654F7E File Offset: 0x0065317E
		public EChangeTimerUiType UiType
		{
			get
			{
				return (EChangeTimerUiType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x0602E650 RID: 190032 RVA: 0x00654F9B File Offset: 0x0065319B
		public static Offset<IChangeTimerUiConfig> CreateIChangeTimerUiConfig(FlatBufferBuilder builder, EChangeTimerUiType UiType)
		{
			builder.Prep(1, 1);
			builder.PutByte((byte)UiType);
			return new Offset<IChangeTimerUiConfig>(builder.Offset);
		}

		// Token: 0x0602E651 RID: 190033 RVA: 0x00654FB8 File Offset: 0x006531B8
		public IChangeTimerUiConfigT UnPack()
		{
			IChangeTimerUiConfigT changeTimerUiConfigT = new IChangeTimerUiConfigT();
			this.UnPackTo(changeTimerUiConfigT);
			return changeTimerUiConfigT;
		}

		// Token: 0x0602E652 RID: 190034 RVA: 0x00654FD3 File Offset: 0x006531D3
		public void UnPackTo(IChangeTimerUiConfigT _o)
		{
			_o.UiType = this.UiType;
		}

		// Token: 0x0602E653 RID: 190035 RVA: 0x00654FE4 File Offset: 0x006531E4
		public static Offset<IChangeTimerUiConfig> Pack(FlatBufferBuilder builder, IChangeTimerUiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeTimerUiConfig>);
			}
			return IChangeTimerUiConfig.CreateIChangeTimerUiConfig(builder, _o.UiType);
		}

		// Token: 0x04011711 RID: 71441
		private Struct __p;
	}
}
