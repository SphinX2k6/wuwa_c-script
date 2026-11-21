using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687D RID: 26749
	public struct IBlendAnimTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C49B RID: 50331
		// (get) Token: 0x0602DB9C RID: 187292 RVA: 0x00640892 File Offset: 0x0063EA92
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB9D RID: 187293 RVA: 0x0064089F File Offset: 0x0063EA9F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB9E RID: 187294 RVA: 0x006408A8 File Offset: 0x0063EAA8
		public static IBlendAnimTypeBase GetRootAsIBlendAnimTypeBase(ByteBuffer _bb)
		{
			return IBlendAnimTypeBase.GetRootAsIBlendAnimTypeBase(_bb, default(IBlendAnimTypeBase));
		}

		// Token: 0x0602DB9F RID: 187295 RVA: 0x006408C4 File Offset: 0x0063EAC4
		public static IBlendAnimTypeBase GetRootAsIBlendAnimTypeBase(ByteBuffer _bb, IBlendAnimTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DBA0 RID: 187296 RVA: 0x006408E1 File Offset: 0x0063EAE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DBA1 RID: 187297 RVA: 0x006408F0 File Offset: 0x0063EAF0
		public IBlendAnimTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C49C RID: 50332
		// (get) Token: 0x0602DBA2 RID: 187298 RVA: 0x00640900 File Offset: 0x0063EB00
		public EBlendAnimType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlendAnimType.StateMachine;
				}
				return (EBlendAnimType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DBA3 RID: 187299 RVA: 0x0064093C File Offset: 0x0063EB3C
		public static Offset<IBlendAnimTypeBase> CreateIBlendAnimTypeBase(FlatBufferBuilder builder, EBlendAnimType Type = EBlendAnimType.StateMachine)
		{
			builder.StartTable(1);
			IBlendAnimTypeBase.AddType(builder, Type);
			return IBlendAnimTypeBase.EndIBlendAnimTypeBase(builder);
		}

		// Token: 0x0602DBA4 RID: 187300 RVA: 0x00640952 File Offset: 0x0063EB52
		public static void StartIBlendAnimTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DBA5 RID: 187301 RVA: 0x0064095B File Offset: 0x0063EB5B
		public static void AddType(FlatBufferBuilder builder, EBlendAnimType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DBA6 RID: 187302 RVA: 0x00640966 File Offset: 0x0063EB66
		public static Offset<IBlendAnimTypeBase> EndIBlendAnimTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IBlendAnimTypeBase>(builder.EndTable());
		}

		// Token: 0x0602DBA7 RID: 187303 RVA: 0x00640974 File Offset: 0x0063EB74
		public IBlendAnimTypeBaseT UnPack()
		{
			IBlendAnimTypeBaseT blendAnimTypeBaseT = new IBlendAnimTypeBaseT();
			this.UnPackTo(blendAnimTypeBaseT);
			return blendAnimTypeBaseT;
		}

		// Token: 0x0602DBA8 RID: 187304 RVA: 0x0064098F File Offset: 0x0063EB8F
		public void UnPackTo(IBlendAnimTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DBA9 RID: 187305 RVA: 0x006409A0 File Offset: 0x0063EBA0
		public static Offset<IBlendAnimTypeBase> Pack(FlatBufferBuilder builder, IBlendAnimTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlendAnimTypeBase>);
			}
			return IBlendAnimTypeBase.CreateIBlendAnimTypeBase(builder, _o.Type);
		}

		// Token: 0x0401155C RID: 71004
		private Table __p;
	}
}
