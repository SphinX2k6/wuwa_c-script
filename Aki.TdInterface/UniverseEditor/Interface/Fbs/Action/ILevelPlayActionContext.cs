using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069EA RID: 27114
	public struct ILevelPlayActionContext : IFlatbufferObject
	{
		// Token: 0x1700C927 RID: 51495
		// (get) Token: 0x0602F6F1 RID: 194289 RVA: 0x00676089 File Offset: 0x00674289
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F6F2 RID: 194290 RVA: 0x00676096 File Offset: 0x00674296
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F6F3 RID: 194291 RVA: 0x006760A0 File Offset: 0x006742A0
		public static ILevelPlayActionContext GetRootAsILevelPlayActionContext(ByteBuffer _bb)
		{
			return ILevelPlayActionContext.GetRootAsILevelPlayActionContext(_bb, default(ILevelPlayActionContext));
		}

		// Token: 0x0602F6F4 RID: 194292 RVA: 0x006760BC File Offset: 0x006742BC
		public static ILevelPlayActionContext GetRootAsILevelPlayActionContext(ByteBuffer _bb, ILevelPlayActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F6F5 RID: 194293 RVA: 0x006760D9 File Offset: 0x006742D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F6F6 RID: 194294 RVA: 0x006760E8 File Offset: 0x006742E8
		public ILevelPlayActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C928 RID: 51496
		// (get) Token: 0x0602F6F7 RID: 194295 RVA: 0x006760F8 File Offset: 0x006742F8
		public string Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F6F8 RID: 194296 RVA: 0x0067612F File Offset: 0x0067432F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F6F9 RID: 194297 RVA: 0x0067613E File Offset: 0x0067433E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C929 RID: 51497
		// (get) Token: 0x0602F6FA RID: 194298 RVA: 0x0067614C File Offset: 0x0067434C
		public EDecisionBtType DecisionBtType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDecisionBtType.Bvb;
				}
				return (EDecisionBtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C92A RID: 51498
		// (get) Token: 0x0602F6FB RID: 194299 RVA: 0x00676188 File Offset: 0x00674388
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F6FC RID: 194300 RVA: 0x006761C4 File Offset: 0x006743C4
		public static Offset<ILevelPlayActionContext> CreateILevelPlayActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset), EDecisionBtType DecisionBtType = EDecisionBtType.Bvb, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelPlayActionContext.AddType(builder, TypeOffset);
			ILevelPlayActionContext.AddNullMask(builder, NullMask);
			ILevelPlayActionContext.AddDecisionBtType(builder, DecisionBtType);
			return ILevelPlayActionContext.EndILevelPlayActionContext(builder);
		}

		// Token: 0x0602F6FD RID: 194301 RVA: 0x006761E8 File Offset: 0x006743E8
		public static void StartILevelPlayActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F6FE RID: 194302 RVA: 0x006761F1 File Offset: 0x006743F1
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x0602F6FF RID: 194303 RVA: 0x00676201 File Offset: 0x00674401
		public static void AddDecisionBtType(FlatBufferBuilder builder, EDecisionBtType decisionBtType)
		{
			builder.AddByte(1, (byte)decisionBtType, 0);
		}

		// Token: 0x0602F700 RID: 194304 RVA: 0x0067620C File Offset: 0x0067440C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602F701 RID: 194305 RVA: 0x00676217 File Offset: 0x00674417
		public static Offset<ILevelPlayActionContext> EndILevelPlayActionContext(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayActionContext>(builder.EndTable());
		}

		// Token: 0x0602F702 RID: 194306 RVA: 0x00676224 File Offset: 0x00674424
		public ILevelPlayActionContextT UnPack()
		{
			ILevelPlayActionContextT levelPlayActionContextT = new ILevelPlayActionContextT();
			this.UnPackTo(levelPlayActionContextT);
			return levelPlayActionContextT;
		}

		// Token: 0x0602F703 RID: 194307 RVA: 0x0067623F File Offset: 0x0067443F
		public void UnPackTo(ILevelPlayActionContextT _o)
		{
			_o.Type = this.Type;
			_o.DecisionBtType = this.DecisionBtType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F704 RID: 194308 RVA: 0x00676268 File Offset: 0x00674468
		public static Offset<ILevelPlayActionContext> Pack(FlatBufferBuilder builder, ILevelPlayActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return ILevelPlayActionContext.CreateILevelPlayActionContext(builder, typeOffset, _o.DecisionBtType, _o.NullMask);
		}

		// Token: 0x040111DF RID: 70111
		private Table __p;
	}
}
