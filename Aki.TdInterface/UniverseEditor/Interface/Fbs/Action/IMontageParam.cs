using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B00 RID: 27392
	public struct IMontageParam : IFlatbufferObject
	{
		// Token: 0x1700CB59 RID: 52057
		// (get) Token: 0x06030096 RID: 196758 RVA: 0x00687EB8 File Offset: 0x006860B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030097 RID: 196759 RVA: 0x00687EC5 File Offset: 0x006860C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030098 RID: 196760 RVA: 0x00687ECC File Offset: 0x006860CC
		public static IMontageParam GetRootAsIMontageParam(ByteBuffer _bb)
		{
			return IMontageParam.GetRootAsIMontageParam(_bb, default(IMontageParam));
		}

		// Token: 0x06030099 RID: 196761 RVA: 0x00687EE8 File Offset: 0x006860E8
		public static IMontageParam GetRootAsIMontageParam(ByteBuffer _bb, IMontageParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603009A RID: 196762 RVA: 0x00687F05 File Offset: 0x00686105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603009B RID: 196763 RVA: 0x00687F14 File Offset: 0x00686114
		public IMontageParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB5A RID: 52058
		// (get) Token: 0x0603009C RID: 196764 RVA: 0x00687F24 File Offset: 0x00686124
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

		// Token: 0x1700CB5B RID: 52059
		// (get) Token: 0x0603009D RID: 196765 RVA: 0x00687F84 File Offset: 0x00686184
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB5C RID: 52060
		// (get) Token: 0x0603009E RID: 196766 RVA: 0x00687FC4 File Offset: 0x006861C4
		public bool KeepPose
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB5D RID: 52061
		// (get) Token: 0x0603009F RID: 196767 RVA: 0x00688004 File Offset: 0x00686204
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

		// Token: 0x1700CB5E RID: 52062
		// (get) Token: 0x060300A0 RID: 196768 RVA: 0x00688048 File Offset: 0x00686248
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

		// Token: 0x060300A1 RID: 196769 RVA: 0x00688085 File Offset: 0x00686285
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

		// Token: 0x060300A2 RID: 196770 RVA: 0x006880B9 File Offset: 0x006862B9
		public static void StartIMontageParam(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060300A3 RID: 196771 RVA: 0x006880C2 File Offset: 0x006862C2
		public static void AddMontageId(FlatBufferBuilder builder, Offset<IMontageId> montageIdOffset)
		{
			builder.AddOffset(0, montageIdOffset.Value, 0);
		}

		// Token: 0x060300A4 RID: 196772 RVA: 0x006880D2 File Offset: 0x006862D2
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(1, isLoop, false);
		}

		// Token: 0x060300A5 RID: 196773 RVA: 0x006880DD File Offset: 0x006862DD
		public static void AddKeepPose(FlatBufferBuilder builder, bool keepPose)
		{
			builder.AddBool(2, keepPose, false);
		}

		// Token: 0x060300A6 RID: 196774 RVA: 0x006880E8 File Offset: 0x006862E8
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x060300A7 RID: 196775 RVA: 0x006880FB File Offset: 0x006862FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060300A8 RID: 196776 RVA: 0x00688106 File Offset: 0x00686306
		public static Offset<IMontageParam> EndIMontageParam(FlatBufferBuilder builder)
		{
			return new Offset<IMontageParam>(builder.EndTable());
		}

		// Token: 0x060300A9 RID: 196777 RVA: 0x00688114 File Offset: 0x00686314
		public IMontageParamT UnPack()
		{
			IMontageParamT montageParamT = new IMontageParamT();
			this.UnPackTo(montageParamT);
			return montageParamT;
		}

		// Token: 0x060300AA RID: 196778 RVA: 0x00688130 File Offset: 0x00686330
		public void UnPackTo(IMontageParamT _o)
		{
			_o.MontageId = ((this.MontageId != null) ? this.MontageId.Value.UnPack() : null);
			_o.IsLoop = this.IsLoop;
			_o.KeepPose = this.KeepPose;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060300AB RID: 196779 RVA: 0x0068819C File Offset: 0x0068639C
		public static Offset<IMontageParam> Pack(FlatBufferBuilder builder, IMontageParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageParam>);
			}
			Offset<IMontageId> montageIdOffset = (_o.MontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.MontageId);
			return IMontageParam.CreateIMontageParam(builder, montageIdOffset, _o.IsLoop, _o.KeepPose, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x0401136E RID: 70510
		private Table __p;
	}
}
