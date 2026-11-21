using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BBA RID: 27578
	public struct IDeadeyeCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700CA55 RID: 51797
		// (get) Token: 0x0602F77C RID: 194428 RVA: 0x00679664 File Offset: 0x00677864
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F77D RID: 194429 RVA: 0x00679671 File Offset: 0x00677871
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F77E RID: 194430 RVA: 0x00679678 File Offset: 0x00677878
		public static IDeadeyeCameraConfig GetRootAsIDeadeyeCameraConfig(ByteBuffer _bb)
		{
			return IDeadeyeCameraConfig.GetRootAsIDeadeyeCameraConfig(_bb, default(IDeadeyeCameraConfig));
		}

		// Token: 0x0602F77F RID: 194431 RVA: 0x00679694 File Offset: 0x00677894
		public static IDeadeyeCameraConfig GetRootAsIDeadeyeCameraConfig(ByteBuffer _bb, IDeadeyeCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F780 RID: 194432 RVA: 0x006796B1 File Offset: 0x006778B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F781 RID: 194433 RVA: 0x006796C0 File Offset: 0x006778C0
		public IDeadeyeCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA56 RID: 51798
		// (get) Token: 0x0602F782 RID: 194434 RVA: 0x006796D0 File Offset: 0x006778D0
		public int LookAtPointId
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

		// Token: 0x1700CA57 RID: 51799
		// (get) Token: 0x0602F783 RID: 194435 RVA: 0x0067970C File Offset: 0x0067790C
		public int SubLensTag
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

		// Token: 0x1700CA58 RID: 51800
		// (get) Token: 0x0602F784 RID: 194436 RVA: 0x00679748 File Offset: 0x00677948
		public float TransitionTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA59 RID: 51801
		// (get) Token: 0x0602F785 RID: 194437 RVA: 0x00679788 File Offset: 0x00677988
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

		// Token: 0x0602F786 RID: 194438 RVA: 0x006797C5 File Offset: 0x006779C5
		public static Offset<IDeadeyeCameraConfig> CreateIDeadeyeCameraConfig(FlatBufferBuilder builder, int LookAtPointId = 0, int SubLensTag = 0, float TransitionTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDeadeyeCameraConfig.AddTransitionTime(builder, TransitionTime);
			IDeadeyeCameraConfig.AddSubLensTag(builder, SubLensTag);
			IDeadeyeCameraConfig.AddLookAtPointId(builder, LookAtPointId);
			IDeadeyeCameraConfig.AddNullMask(builder, NullMask);
			return IDeadeyeCameraConfig.EndIDeadeyeCameraConfig(builder);
		}

		// Token: 0x0602F787 RID: 194439 RVA: 0x006797F1 File Offset: 0x006779F1
		public static void StartIDeadeyeCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F788 RID: 194440 RVA: 0x006797FA File Offset: 0x006779FA
		public static void AddLookAtPointId(FlatBufferBuilder builder, int lookAtPointId)
		{
			builder.AddInt(0, lookAtPointId, 0);
		}

		// Token: 0x0602F789 RID: 194441 RVA: 0x00679805 File Offset: 0x00677A05
		public static void AddSubLensTag(FlatBufferBuilder builder, int subLensTag)
		{
			builder.AddInt(1, subLensTag, 0);
		}

		// Token: 0x0602F78A RID: 194442 RVA: 0x00679810 File Offset: 0x00677A10
		public static void AddTransitionTime(FlatBufferBuilder builder, float transitionTime)
		{
			builder.AddFloat(2, transitionTime, 0.0);
		}

		// Token: 0x0602F78B RID: 194443 RVA: 0x00679823 File Offset: 0x00677A23
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602F78C RID: 194444 RVA: 0x0067982E File Offset: 0x00677A2E
		public static Offset<IDeadeyeCameraConfig> EndIDeadeyeCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeadeyeCameraConfig>(builder.EndTable());
		}

		// Token: 0x0602F78D RID: 194445 RVA: 0x0067983C File Offset: 0x00677A3C
		public IDeadeyeCameraConfigT UnPack()
		{
			IDeadeyeCameraConfigT deadeyeCameraConfigT = new IDeadeyeCameraConfigT();
			this.UnPackTo(deadeyeCameraConfigT);
			return deadeyeCameraConfigT;
		}

		// Token: 0x0602F78E RID: 194446 RVA: 0x00679857 File Offset: 0x00677A57
		public void UnPackTo(IDeadeyeCameraConfigT _o)
		{
			_o.LookAtPointId = this.LookAtPointId;
			_o.SubLensTag = this.SubLensTag;
			_o.TransitionTime = this.TransitionTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F78F RID: 194447 RVA: 0x0067988C File Offset: 0x00677A8C
		public static Offset<IDeadeyeCameraConfig> Pack(FlatBufferBuilder builder, IDeadeyeCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeadeyeCameraConfig>);
			}
			return IDeadeyeCameraConfig.CreateIDeadeyeCameraConfig(builder, _o.LookAtPointId, _o.SubLensTag, _o.TransitionTime, _o.NullMask);
		}

		// Token: 0x040119B5 RID: 72117
		private Table __p;
	}
}
