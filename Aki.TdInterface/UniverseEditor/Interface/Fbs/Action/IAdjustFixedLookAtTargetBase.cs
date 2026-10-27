using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006158 RID: 24920
	public struct IAdjustFixedLookAtTargetBase : IFlatbufferObject
	{
		// Token: 0x1700B90E RID: 47374
		// (get) Token: 0x0602ACE8 RID: 175336 RVA: 0x005E6E51 File Offset: 0x005E5051
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ACE9 RID: 175337 RVA: 0x005E6E5E File Offset: 0x005E505E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ACEA RID: 175338 RVA: 0x005E6E68 File Offset: 0x005E5068
		public static IAdjustFixedLookAtTargetBase GetRootAsIAdjustFixedLookAtTargetBase(ByteBuffer _bb)
		{
			return IAdjustFixedLookAtTargetBase.GetRootAsIAdjustFixedLookAtTargetBase(_bb, default(IAdjustFixedLookAtTargetBase));
		}

		// Token: 0x0602ACEB RID: 175339 RVA: 0x005E6E84 File Offset: 0x005E5084
		public static IAdjustFixedLookAtTargetBase GetRootAsIAdjustFixedLookAtTargetBase(ByteBuffer _bb, IAdjustFixedLookAtTargetBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ACEC RID: 175340 RVA: 0x005E6EA1 File Offset: 0x005E50A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ACED RID: 175341 RVA: 0x005E6EB0 File Offset: 0x005E50B0
		public IAdjustFixedLookAtTargetBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B90F RID: 47375
		// (get) Token: 0x0602ACEE RID: 175342 RVA: 0x005E6EC0 File Offset: 0x005E50C0
		public EFixedLookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFixedLookAtTargetType.RangeEntity;
				}
				return (EFixedLookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ACEF RID: 175343 RVA: 0x005E6EFC File Offset: 0x005E50FC
		public static Offset<IAdjustFixedLookAtTargetBase> CreateIAdjustFixedLookAtTargetBase(FlatBufferBuilder builder, EFixedLookAtTargetType Type = EFixedLookAtTargetType.RangeEntity)
		{
			builder.StartTable(1);
			IAdjustFixedLookAtTargetBase.AddType(builder, Type);
			return IAdjustFixedLookAtTargetBase.EndIAdjustFixedLookAtTargetBase(builder);
		}

		// Token: 0x0602ACF0 RID: 175344 RVA: 0x005E6F12 File Offset: 0x005E5112
		public static void StartIAdjustFixedLookAtTargetBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602ACF1 RID: 175345 RVA: 0x005E6F1B File Offset: 0x005E511B
		public static void AddType(FlatBufferBuilder builder, EFixedLookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ACF2 RID: 175346 RVA: 0x005E6F26 File Offset: 0x005E5126
		public static Offset<IAdjustFixedLookAtTargetBase> EndIAdjustFixedLookAtTargetBase(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedLookAtTargetBase>(builder.EndTable());
		}

		// Token: 0x0602ACF3 RID: 175347 RVA: 0x005E6F34 File Offset: 0x005E5134
		public IAdjustFixedLookAtTargetBaseT UnPack()
		{
			IAdjustFixedLookAtTargetBaseT adjustFixedLookAtTargetBaseT = new IAdjustFixedLookAtTargetBaseT();
			this.UnPackTo(adjustFixedLookAtTargetBaseT);
			return adjustFixedLookAtTargetBaseT;
		}

		// Token: 0x0602ACF4 RID: 175348 RVA: 0x005E6F4F File Offset: 0x005E514F
		public void UnPackTo(IAdjustFixedLookAtTargetBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602ACF5 RID: 175349 RVA: 0x005E6F60 File Offset: 0x005E5160
		public static Offset<IAdjustFixedLookAtTargetBase> Pack(FlatBufferBuilder builder, IAdjustFixedLookAtTargetBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFixedLookAtTargetBase>);
			}
			return IAdjustFixedLookAtTargetBase.CreateIAdjustFixedLookAtTargetBase(builder, _o.Type);
		}

		// Token: 0x040105E3 RID: 67043
		private Table __p;
	}
}
