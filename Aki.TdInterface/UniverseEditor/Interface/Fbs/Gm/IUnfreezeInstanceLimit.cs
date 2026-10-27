using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046C9 RID: 18121
	public struct IUnfreezeInstanceLimit : IFlatbufferObject
	{
		// Token: 0x170080C4 RID: 32964
		// (get) Token: 0x0601B8C9 RID: 112841 RVA: 0x003E8A43 File Offset: 0x003E6C43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B8CA RID: 112842 RVA: 0x003E8A50 File Offset: 0x003E6C50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B8CB RID: 112843 RVA: 0x003E8A58 File Offset: 0x003E6C58
		public static IUnfreezeInstanceLimit GetRootAsIUnfreezeInstanceLimit(ByteBuffer _bb)
		{
			return IUnfreezeInstanceLimit.GetRootAsIUnfreezeInstanceLimit(_bb, default(IUnfreezeInstanceLimit));
		}

		// Token: 0x0601B8CC RID: 112844 RVA: 0x003E8A74 File Offset: 0x003E6C74
		public static IUnfreezeInstanceLimit GetRootAsIUnfreezeInstanceLimit(ByteBuffer _bb, IUnfreezeInstanceLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B8CD RID: 112845 RVA: 0x003E8A91 File Offset: 0x003E6C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B8CE RID: 112846 RVA: 0x003E8AA0 File Offset: 0x003E6CA0
		public IUnfreezeInstanceLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080C5 RID: 32965
		// (get) Token: 0x0601B8CF RID: 112847 RVA: 0x003E8AB0 File Offset: 0x003E6CB0
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B8D0 RID: 112848 RVA: 0x003E8AEC File Offset: 0x003E6CEC
		public static Offset<IUnfreezeInstanceLimit> CreateIUnfreezeInstanceLimit(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IUnfreezeInstanceLimit.AddType(builder, Type);
			return IUnfreezeInstanceLimit.EndIUnfreezeInstanceLimit(builder);
		}

		// Token: 0x0601B8D1 RID: 112849 RVA: 0x003E8B02 File Offset: 0x003E6D02
		public static void StartIUnfreezeInstanceLimit(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B8D2 RID: 112850 RVA: 0x003E8B0B File Offset: 0x003E6D0B
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B8D3 RID: 112851 RVA: 0x003E8B16 File Offset: 0x003E6D16
		public static Offset<IUnfreezeInstanceLimit> EndIUnfreezeInstanceLimit(FlatBufferBuilder builder)
		{
			return new Offset<IUnfreezeInstanceLimit>(builder.EndTable());
		}

		// Token: 0x0601B8D4 RID: 112852 RVA: 0x003E8B24 File Offset: 0x003E6D24
		public IUnfreezeInstanceLimitT UnPack()
		{
			IUnfreezeInstanceLimitT unfreezeInstanceLimitT = new IUnfreezeInstanceLimitT();
			this.UnPackTo(unfreezeInstanceLimitT);
			return unfreezeInstanceLimitT;
		}

		// Token: 0x0601B8D5 RID: 112853 RVA: 0x003E8B3F File Offset: 0x003E6D3F
		public void UnPackTo(IUnfreezeInstanceLimitT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B8D6 RID: 112854 RVA: 0x003E8B50 File Offset: 0x003E6D50
		public static Offset<IUnfreezeInstanceLimit> Pack(FlatBufferBuilder builder, IUnfreezeInstanceLimitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnfreezeInstanceLimit>);
			}
			return IUnfreezeInstanceLimit.CreateIUnfreezeInstanceLimit(builder, _o.Type);
		}

		// Token: 0x0400C89D RID: 51357
		private Table __p;
	}
}
