using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007237 RID: 29239
	public struct IMontageParam : IFlatbufferObject
	{
		// Token: 0x1700D628 RID: 54824
		// (get) Token: 0x06032E6A RID: 208490 RVA: 0x006DF570 File Offset: 0x006DD770
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032E6B RID: 208491 RVA: 0x006DF57D File Offset: 0x006DD77D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032E6C RID: 208492 RVA: 0x006DF584 File Offset: 0x006DD784
		public static IMontageParam GetRootAsIMontageParam(ByteBuffer _bb)
		{
			return IMontageParam.GetRootAsIMontageParam(_bb, default(IMontageParam));
		}

		// Token: 0x06032E6D RID: 208493 RVA: 0x006DF5A0 File Offset: 0x006DD7A0
		public static IMontageParam GetRootAsIMontageParam(ByteBuffer _bb, IMontageParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032E6E RID: 208494 RVA: 0x006DF5BD File Offset: 0x006DD7BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032E6F RID: 208495 RVA: 0x006DF5CC File Offset: 0x006DD7CC
		public IMontageParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D629 RID: 54825
		// (get) Token: 0x06032E70 RID: 208496 RVA: 0x006DF5DC File Offset: 0x006DD7DC
		public IMontageId? MontageId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D62A RID: 54826
		// (get) Token: 0x06032E71 RID: 208497 RVA: 0x006DF63C File Offset: 0x006DD83C
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D62B RID: 54827
		// (get) Token: 0x06032E72 RID: 208498 RVA: 0x006DF67C File Offset: 0x006DD87C
		public bool KeepPose
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D62C RID: 54828
		// (get) Token: 0x06032E73 RID: 208499 RVA: 0x006DF6BC File Offset: 0x006DD8BC
		public float DelayTime
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

		// Token: 0x1700D62D RID: 54829
		// (get) Token: 0x06032E74 RID: 208500 RVA: 0x006DF700 File Offset: 0x006DD900
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032E75 RID: 208501 RVA: 0x006DF73D File Offset: 0x006DD93D
		public static Offset<IMontageParam> CreateIMontageParam(FlatBufferBuilder builder, Offset<IMontageId> MontageIdOffset = default(Offset<IMontageId>), bool IsLoop = false, bool KeepPose = false, float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IMontageParam.AddDelayTime(builder, DelayTime);
			IMontageParam.AddMontageId(builder, MontageIdOffset);
			IMontageParam.AddNullMask(builder, NullMask);
			IMontageParam.AddKeepPose(builder, KeepPose);
			IMontageParam.AddIsLoop(builder, IsLoop);
			return IMontageParam.EndIMontageParam(builder);
		}

		// Token: 0x06032E76 RID: 208502 RVA: 0x006DF771 File Offset: 0x006DD971
		public static void StartIMontageParam(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06032E77 RID: 208503 RVA: 0x006DF77A File Offset: 0x006DD97A
		public static void AddMontageId(FlatBufferBuilder builder, Offset<IMontageId> montageIdOffset)
		{
			builder.AddOffset(0, montageIdOffset.Value, 0);
		}

		// Token: 0x06032E78 RID: 208504 RVA: 0x006DF78A File Offset: 0x006DD98A
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(1, isLoop, false);
		}

		// Token: 0x06032E79 RID: 208505 RVA: 0x006DF795 File Offset: 0x006DD995
		public static void AddKeepPose(FlatBufferBuilder builder, bool keepPose)
		{
			builder.AddBool(2, keepPose, false);
		}

		// Token: 0x06032E7A RID: 208506 RVA: 0x006DF7A0 File Offset: 0x006DD9A0
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x06032E7B RID: 208507 RVA: 0x006DF7B3 File Offset: 0x006DD9B3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06032E7C RID: 208508 RVA: 0x006DF7BE File Offset: 0x006DD9BE
		public static Offset<IMontageParam> EndIMontageParam(FlatBufferBuilder builder)
		{
			return new Offset<IMontageParam>(builder.EndTable());
		}

		// Token: 0x06032E7D RID: 208509 RVA: 0x006DF7CC File Offset: 0x006DD9CC
		public IMontageParamT UnPack()
		{
			IMontageParamT montageParamT = new IMontageParamT();
			this.UnPackTo(montageParamT);
			return montageParamT;
		}

		// Token: 0x06032E7E RID: 208510 RVA: 0x006DF7E8 File Offset: 0x006DD9E8
		public void UnPackTo(IMontageParamT _o)
		{
			_o.MontageId = ((this.MontageId != null) ? this.MontageId.Value.UnPack() : null);
			_o.IsLoop = this.IsLoop;
			_o.KeepPose = this.KeepPose;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032E7F RID: 208511 RVA: 0x006DF854 File Offset: 0x006DDA54
		public static Offset<IMontageParam> Pack(FlatBufferBuilder builder, IMontageParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageParam>);
			}
			Offset<IMontageId> montageIdOffset = (_o.MontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.MontageId);
			return IMontageParam.CreateIMontageParam(builder, montageIdOffset, _o.IsLoop, _o.KeepPose, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x04012281 RID: 74369
		private Table __p;
	}
}
