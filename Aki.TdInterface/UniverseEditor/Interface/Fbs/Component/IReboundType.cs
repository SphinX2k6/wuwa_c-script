using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580E RID: 22542
	public struct IReboundType : IFlatbufferObject
	{
		// Token: 0x1700A868 RID: 43112
		// (get) Token: 0x06025E65 RID: 155237 RVA: 0x0053A003 File Offset: 0x00538203
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025E66 RID: 155238 RVA: 0x0053A010 File Offset: 0x00538210
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025E67 RID: 155239 RVA: 0x0053A018 File Offset: 0x00538218
		public static IReboundType GetRootAsIReboundType(ByteBuffer _bb)
		{
			return IReboundType.GetRootAsIReboundType(_bb, default(IReboundType));
		}

		// Token: 0x06025E68 RID: 155240 RVA: 0x0053A034 File Offset: 0x00538234
		public static IReboundType GetRootAsIReboundType(ByteBuffer _bb, IReboundType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025E69 RID: 155241 RVA: 0x0053A051 File Offset: 0x00538251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025E6A RID: 155242 RVA: 0x0053A060 File Offset: 0x00538260
		public IReboundType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A869 RID: 43113
		// (get) Token: 0x06025E6B RID: 155243 RVA: 0x0053A070 File Offset: 0x00538270
		public EReboundOptionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EReboundOptionType.ForwardFront;
				}
				return (EReboundOptionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025E6C RID: 155244 RVA: 0x0053A0AC File Offset: 0x005382AC
		public static Offset<IReboundType> CreateIReboundType(FlatBufferBuilder builder, EReboundOptionType Type = EReboundOptionType.ForwardFront)
		{
			builder.StartTable(1);
			IReboundType.AddType(builder, Type);
			return IReboundType.EndIReboundType(builder);
		}

		// Token: 0x06025E6D RID: 155245 RVA: 0x0053A0C2 File Offset: 0x005382C2
		public static void StartIReboundType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025E6E RID: 155246 RVA: 0x0053A0CB File Offset: 0x005382CB
		public static void AddType(FlatBufferBuilder builder, EReboundOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025E6F RID: 155247 RVA: 0x0053A0D6 File Offset: 0x005382D6
		public static Offset<IReboundType> EndIReboundType(FlatBufferBuilder builder)
		{
			return new Offset<IReboundType>(builder.EndTable());
		}

		// Token: 0x06025E70 RID: 155248 RVA: 0x0053A0E4 File Offset: 0x005382E4
		public IReboundTypeT UnPack()
		{
			IReboundTypeT reboundTypeT = new IReboundTypeT();
			this.UnPackTo(reboundTypeT);
			return reboundTypeT;
		}

		// Token: 0x06025E71 RID: 155249 RVA: 0x0053A0FF File Offset: 0x005382FF
		public void UnPackTo(IReboundTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025E72 RID: 155250 RVA: 0x0053A110 File Offset: 0x00538310
		public static Offset<IReboundType> Pack(FlatBufferBuilder builder, IReboundTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReboundType>);
			}
			return IReboundType.CreateIReboundType(builder, _o.Type);
		}

		// Token: 0x0400ED0E RID: 60686
		private Table __p;
	}
}
