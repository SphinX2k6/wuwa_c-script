using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ED2 RID: 16082
	public struct IKurotatoConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17006FA7 RID: 28583
		// (get) Token: 0x06016BEF RID: 93167 RVA: 0x00348A11 File Offset: 0x00346C11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016BF0 RID: 93168 RVA: 0x00348A1E File Offset: 0x00346C1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016BF1 RID: 93169 RVA: 0x00348A28 File Offset: 0x00346C28
		public static IKurotatoConditionStepBase GetRootAsIKurotatoConditionStepBase(ByteBuffer _bb)
		{
			return IKurotatoConditionStepBase.GetRootAsIKurotatoConditionStepBase(_bb, default(IKurotatoConditionStepBase));
		}

		// Token: 0x06016BF2 RID: 93170 RVA: 0x00348A44 File Offset: 0x00346C44
		public static IKurotatoConditionStepBase GetRootAsIKurotatoConditionStepBase(ByteBuffer _bb, IKurotatoConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016BF3 RID: 93171 RVA: 0x00348A61 File Offset: 0x00346C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016BF4 RID: 93172 RVA: 0x00348A70 File Offset: 0x00346C70
		public IKurotatoConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FA8 RID: 28584
		// (get) Token: 0x06016BF5 RID: 93173 RVA: 0x00348A80 File Offset: 0x00346C80
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

		// Token: 0x06016BF6 RID: 93174 RVA: 0x00348ABC File Offset: 0x00346CBC
		public static Offset<IKurotatoConditionStepBase> CreateIKurotatoConditionStepBase(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepBase.AddType(builder, Type);
			return IKurotatoConditionStepBase.EndIKurotatoConditionStepBase(builder);
		}

		// Token: 0x06016BF7 RID: 93175 RVA: 0x00348AD2 File Offset: 0x00346CD2
		public static void StartIKurotatoConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016BF8 RID: 93176 RVA: 0x00348ADB File Offset: 0x00346CDB
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016BF9 RID: 93177 RVA: 0x00348AE6 File Offset: 0x00346CE6
		public static Offset<IKurotatoConditionStepBase> EndIKurotatoConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepBase>(builder.EndTable());
		}

		// Token: 0x06016BFA RID: 93178 RVA: 0x00348AF4 File Offset: 0x00346CF4
		public IKurotatoConditionStepBaseT UnPack()
		{
			IKurotatoConditionStepBaseT kurotatoConditionStepBaseT = new IKurotatoConditionStepBaseT();
			this.UnPackTo(kurotatoConditionStepBaseT);
			return kurotatoConditionStepBaseT;
		}

		// Token: 0x06016BFB RID: 93179 RVA: 0x00348B0F File Offset: 0x00346D0F
		public void UnPackTo(IKurotatoConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016BFC RID: 93180 RVA: 0x00348B20 File Offset: 0x00346D20
		public static Offset<IKurotatoConditionStepBase> Pack(FlatBufferBuilder builder, IKurotatoConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepBase>);
			}
			return IKurotatoConditionStepBase.CreateIKurotatoConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400B8AE RID: 47278
		private Table __p;
	}
}
