using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006065 RID: 24677
	public struct IAbsolutePos2 : IFlatbufferObject
	{
		// Token: 0x1700B5D2 RID: 46546
		// (get) Token: 0x06029C78 RID: 171128 RVA: 0x005BB944 File Offset: 0x005B9B44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029C79 RID: 171129 RVA: 0x005BB951 File Offset: 0x005B9B51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029C7A RID: 171130 RVA: 0x005BB958 File Offset: 0x005B9B58
		public static IAbsolutePos2 GetRootAsIAbsolutePos2(ByteBuffer _bb)
		{
			return IAbsolutePos2.GetRootAsIAbsolutePos2(_bb, default(IAbsolutePos2));
		}

		// Token: 0x06029C7B RID: 171131 RVA: 0x005BB974 File Offset: 0x005B9B74
		public static IAbsolutePos2 GetRootAsIAbsolutePos2(ByteBuffer _bb, IAbsolutePos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029C7C RID: 171132 RVA: 0x005BB991 File Offset: 0x005B9B91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029C7D RID: 171133 RVA: 0x005BB9A0 File Offset: 0x005B9BA0
		public IAbsolutePos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5D3 RID: 46547
		// (get) Token: 0x06029C7E RID: 171134 RVA: 0x005BB9B0 File Offset: 0x005B9BB0
		public EPos2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPos2.Player;
				}
				return (EPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B5D4 RID: 46548
		// (get) Token: 0x06029C7F RID: 171135 RVA: 0x005BB9EC File Offset: 0x005B9BEC
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029C80 RID: 171136 RVA: 0x005BBA49 File Offset: 0x005B9C49
		public static Offset<IAbsolutePos2> CreateIAbsolutePos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IAbsolutePos2.AddPos(builder, PosOffset);
			IAbsolutePos2.AddType(builder, Type);
			return IAbsolutePos2.EndIAbsolutePos2(builder);
		}

		// Token: 0x06029C81 RID: 171137 RVA: 0x005BBA66 File Offset: 0x005B9C66
		public static void StartIAbsolutePos2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029C82 RID: 171138 RVA: 0x005BBA6F File Offset: 0x005B9C6F
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029C83 RID: 171139 RVA: 0x005BBA7A File Offset: 0x005B9C7A
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06029C84 RID: 171140 RVA: 0x005BBA8A File Offset: 0x005B9C8A
		public static Offset<IAbsolutePos2> EndIAbsolutePos2(FlatBufferBuilder builder)
		{
			return new Offset<IAbsolutePos2>(builder.EndTable());
		}

		// Token: 0x06029C85 RID: 171141 RVA: 0x005BBA98 File Offset: 0x005B9C98
		public IAbsolutePos2T UnPack()
		{
			IAbsolutePos2T absolutePos2T = new IAbsolutePos2T();
			this.UnPackTo(absolutePos2T);
			return absolutePos2T;
		}

		// Token: 0x06029C86 RID: 171142 RVA: 0x005BBAB4 File Offset: 0x005B9CB4
		public void UnPackTo(IAbsolutePos2T _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x06029C87 RID: 171143 RVA: 0x005BBAFC File Offset: 0x005B9CFC
		public static Offset<IAbsolutePos2> Pack(FlatBufferBuilder builder, IAbsolutePos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IAbsolutePos2>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IAbsolutePos2.CreateIAbsolutePos2(builder, _o.Type, posOffset);
		}

		// Token: 0x04010225 RID: 66085
		private Table __p;
	}
}
