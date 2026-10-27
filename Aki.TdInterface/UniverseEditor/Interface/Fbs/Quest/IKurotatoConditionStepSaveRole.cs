using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EE4 RID: 16100
	public struct IKurotatoConditionStepSaveRole : IFlatbufferObject
	{
		// Token: 0x17006FB8 RID: 28600
		// (get) Token: 0x06016C63 RID: 93283 RVA: 0x00349439 File Offset: 0x00347639
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016C64 RID: 93284 RVA: 0x00349446 File Offset: 0x00347646
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016C65 RID: 93285 RVA: 0x00349450 File Offset: 0x00347650
		public static IKurotatoConditionStepSaveRole GetRootAsIKurotatoConditionStepSaveRole(ByteBuffer _bb)
		{
			return IKurotatoConditionStepSaveRole.GetRootAsIKurotatoConditionStepSaveRole(_bb, default(IKurotatoConditionStepSaveRole));
		}

		// Token: 0x06016C66 RID: 93286 RVA: 0x0034946C File Offset: 0x0034766C
		public static IKurotatoConditionStepSaveRole GetRootAsIKurotatoConditionStepSaveRole(ByteBuffer _bb, IKurotatoConditionStepSaveRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016C67 RID: 93287 RVA: 0x00349489 File Offset: 0x00347689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016C68 RID: 93288 RVA: 0x00349498 File Offset: 0x00347698
		public IKurotatoConditionStepSaveRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FB9 RID: 28601
		// (get) Token: 0x06016C69 RID: 93289 RVA: 0x003494A8 File Offset: 0x003476A8
		public EKurotatoConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EKurotatoConditionStep.Prepare;
				}
				return (EKurotatoConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016C6A RID: 93290 RVA: 0x003494E4 File Offset: 0x003476E4
		public static Offset<IKurotatoConditionStepSaveRole> CreateIKurotatoConditionStepSaveRole(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepSaveRole.AddType(builder, Type);
			return IKurotatoConditionStepSaveRole.EndIKurotatoConditionStepSaveRole(builder);
		}

		// Token: 0x06016C6B RID: 93291 RVA: 0x003494FA File Offset: 0x003476FA
		public static void StartIKurotatoConditionStepSaveRole(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016C6C RID: 93292 RVA: 0x00349503 File Offset: 0x00347703
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016C6D RID: 93293 RVA: 0x0034950E File Offset: 0x0034770E
		public static Offset<IKurotatoConditionStepSaveRole> EndIKurotatoConditionStepSaveRole(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepSaveRole>(builder.EndTable());
		}

		// Token: 0x06016C6E RID: 93294 RVA: 0x0034951C File Offset: 0x0034771C
		public IKurotatoConditionStepSaveRoleT UnPack()
		{
			IKurotatoConditionStepSaveRoleT kurotatoConditionStepSaveRoleT = new IKurotatoConditionStepSaveRoleT();
			this.UnPackTo(kurotatoConditionStepSaveRoleT);
			return kurotatoConditionStepSaveRoleT;
		}

		// Token: 0x06016C6F RID: 93295 RVA: 0x00349537 File Offset: 0x00347737
		public void UnPackTo(IKurotatoConditionStepSaveRoleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016C70 RID: 93296 RVA: 0x00349548 File Offset: 0x00347748
		public static Offset<IKurotatoConditionStepSaveRole> Pack(FlatBufferBuilder builder, IKurotatoConditionStepSaveRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepSaveRole>);
			}
			return IKurotatoConditionStepSaveRole.CreateIKurotatoConditionStepSaveRole(builder, _o.Type);
		}

		// Token: 0x0400B8C5 RID: 47301
		private Table __p;
	}
}
