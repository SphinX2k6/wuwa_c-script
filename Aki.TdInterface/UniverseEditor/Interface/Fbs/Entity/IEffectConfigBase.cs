using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004784 RID: 18308
	public struct IEffectConfigBase : IFlatbufferObject
	{
		// Token: 0x17008352 RID: 33618
		// (get) Token: 0x0601C311 RID: 115473 RVA: 0x003FE0EB File Offset: 0x003FC2EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C312 RID: 115474 RVA: 0x003FE0F8 File Offset: 0x003FC2F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C313 RID: 115475 RVA: 0x003FE100 File Offset: 0x003FC300
		public static IEffectConfigBase GetRootAsIEffectConfigBase(ByteBuffer _bb)
		{
			return IEffectConfigBase.GetRootAsIEffectConfigBase(_bb, default(IEffectConfigBase));
		}

		// Token: 0x0601C314 RID: 115476 RVA: 0x003FE11C File Offset: 0x003FC31C
		public static IEffectConfigBase GetRootAsIEffectConfigBase(ByteBuffer _bb, IEffectConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C315 RID: 115477 RVA: 0x003FE139 File Offset: 0x003FC339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C316 RID: 115478 RVA: 0x003FE148 File Offset: 0x003FC348
		public IEffectConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008353 RID: 33619
		// (get) Token: 0x0601C317 RID: 115479 RVA: 0x003FE158 File Offset: 0x003FC358
		public EEffectConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectConfigType.Death;
				}
				return (EEffectConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C318 RID: 115480 RVA: 0x003FE194 File Offset: 0x003FC394
		public static Offset<IEffectConfigBase> CreateIEffectConfigBase(FlatBufferBuilder builder, EEffectConfigType Type = EEffectConfigType.Death)
		{
			builder.StartTable(1);
			IEffectConfigBase.AddType(builder, Type);
			return IEffectConfigBase.EndIEffectConfigBase(builder);
		}

		// Token: 0x0601C319 RID: 115481 RVA: 0x003FE1AA File Offset: 0x003FC3AA
		public static void StartIEffectConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C31A RID: 115482 RVA: 0x003FE1B3 File Offset: 0x003FC3B3
		public static void AddType(FlatBufferBuilder builder, EEffectConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C31B RID: 115483 RVA: 0x003FE1BE File Offset: 0x003FC3BE
		public static Offset<IEffectConfigBase> EndIEffectConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IEffectConfigBase>(builder.EndTable());
		}

		// Token: 0x0601C31C RID: 115484 RVA: 0x003FE1CC File Offset: 0x003FC3CC
		public IEffectConfigBaseT UnPack()
		{
			IEffectConfigBaseT effectConfigBaseT = new IEffectConfigBaseT();
			this.UnPackTo(effectConfigBaseT);
			return effectConfigBaseT;
		}

		// Token: 0x0601C31D RID: 115485 RVA: 0x003FE1E7 File Offset: 0x003FC3E7
		public void UnPackTo(IEffectConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C31E RID: 115486 RVA: 0x003FE1F8 File Offset: 0x003FC3F8
		public static Offset<IEffectConfigBase> Pack(FlatBufferBuilder builder, IEffectConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectConfigBase>);
			}
			return IEffectConfigBase.CreateIEffectConfigBase(builder, _o.Type);
		}

		// Token: 0x0400CBE6 RID: 52198
		private Table __p;
	}
}
