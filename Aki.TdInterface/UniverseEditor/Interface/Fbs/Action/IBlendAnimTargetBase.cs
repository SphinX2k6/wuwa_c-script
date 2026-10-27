using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006206 RID: 25094
	public struct IBlendAnimTargetBase : IFlatbufferObject
	{
		// Token: 0x1700BB10 RID: 47888
		// (get) Token: 0x0602B425 RID: 177189 RVA: 0x005F5A31 File Offset: 0x005F3C31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B426 RID: 177190 RVA: 0x005F5A3E File Offset: 0x005F3C3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B427 RID: 177191 RVA: 0x005F5A48 File Offset: 0x005F3C48
		public static IBlendAnimTargetBase GetRootAsIBlendAnimTargetBase(ByteBuffer _bb)
		{
			return IBlendAnimTargetBase.GetRootAsIBlendAnimTargetBase(_bb, default(IBlendAnimTargetBase));
		}

		// Token: 0x0602B428 RID: 177192 RVA: 0x005F5A64 File Offset: 0x005F3C64
		public static IBlendAnimTargetBase GetRootAsIBlendAnimTargetBase(ByteBuffer _bb, IBlendAnimTargetBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B429 RID: 177193 RVA: 0x005F5A81 File Offset: 0x005F3C81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B42A RID: 177194 RVA: 0x005F5A90 File Offset: 0x005F3C90
		public IBlendAnimTargetBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB11 RID: 47889
		// (get) Token: 0x0602B42B RID: 177195 RVA: 0x005F5AA0 File Offset: 0x005F3CA0
		public EBlendAnimTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlendAnimTarget.Player;
				}
				return (EBlendAnimTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B42C RID: 177196 RVA: 0x005F5ADC File Offset: 0x005F3CDC
		public static Offset<IBlendAnimTargetBase> CreateIBlendAnimTargetBase(FlatBufferBuilder builder, EBlendAnimTarget Type = EBlendAnimTarget.Player)
		{
			builder.StartTable(1);
			IBlendAnimTargetBase.AddType(builder, Type);
			return IBlendAnimTargetBase.EndIBlendAnimTargetBase(builder);
		}

		// Token: 0x0602B42D RID: 177197 RVA: 0x005F5AF2 File Offset: 0x005F3CF2
		public static void StartIBlendAnimTargetBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B42E RID: 177198 RVA: 0x005F5AFB File Offset: 0x005F3CFB
		public static void AddType(FlatBufferBuilder builder, EBlendAnimTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B42F RID: 177199 RVA: 0x005F5B06 File Offset: 0x005F3D06
		public static Offset<IBlendAnimTargetBase> EndIBlendAnimTargetBase(FlatBufferBuilder builder)
		{
			return new Offset<IBlendAnimTargetBase>(builder.EndTable());
		}

		// Token: 0x0602B430 RID: 177200 RVA: 0x005F5B14 File Offset: 0x005F3D14
		public IBlendAnimTargetBaseT UnPack()
		{
			IBlendAnimTargetBaseT blendAnimTargetBaseT = new IBlendAnimTargetBaseT();
			this.UnPackTo(blendAnimTargetBaseT);
			return blendAnimTargetBaseT;
		}

		// Token: 0x0602B431 RID: 177201 RVA: 0x005F5B2F File Offset: 0x005F3D2F
		public void UnPackTo(IBlendAnimTargetBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B432 RID: 177202 RVA: 0x005F5B40 File Offset: 0x005F3D40
		public static Offset<IBlendAnimTargetBase> Pack(FlatBufferBuilder builder, IBlendAnimTargetBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlendAnimTargetBase>);
			}
			return IBlendAnimTargetBase.CreateIBlendAnimTargetBase(builder, _o.Type);
		}

		// Token: 0x04010740 RID: 67392
		private Table __p;
	}
}
