using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005443 RID: 21571
	public struct IInteractEntityPartBindBase : IFlatbufferObject
	{
		// Token: 0x17009ED8 RID: 40664
		// (get) Token: 0x0602379D RID: 145309 RVA: 0x004E8D43 File Offset: 0x004E6F43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602379E RID: 145310 RVA: 0x004E8D50 File Offset: 0x004E6F50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602379F RID: 145311 RVA: 0x004E8D58 File Offset: 0x004E6F58
		public static IInteractEntityPartBindBase GetRootAsIInteractEntityPartBindBase(ByteBuffer _bb)
		{
			return IInteractEntityPartBindBase.GetRootAsIInteractEntityPartBindBase(_bb, default(IInteractEntityPartBindBase));
		}

		// Token: 0x060237A0 RID: 145312 RVA: 0x004E8D74 File Offset: 0x004E6F74
		public static IInteractEntityPartBindBase GetRootAsIInteractEntityPartBindBase(ByteBuffer _bb, IInteractEntityPartBindBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060237A1 RID: 145313 RVA: 0x004E8D91 File Offset: 0x004E6F91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060237A2 RID: 145314 RVA: 0x004E8DA0 File Offset: 0x004E6FA0
		public IInteractEntityPartBindBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009ED9 RID: 40665
		// (get) Token: 0x060237A3 RID: 145315 RVA: 0x004E8DB0 File Offset: 0x004E6FB0
		public EInteractEntityPartBindType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractEntityPartBindType.Prefab;
				}
				return (EInteractEntityPartBindType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060237A4 RID: 145316 RVA: 0x004E8DEC File Offset: 0x004E6FEC
		public static Offset<IInteractEntityPartBindBase> CreateIInteractEntityPartBindBase(FlatBufferBuilder builder, EInteractEntityPartBindType Type = EInteractEntityPartBindType.Prefab)
		{
			builder.StartTable(1);
			IInteractEntityPartBindBase.AddType(builder, Type);
			return IInteractEntityPartBindBase.EndIInteractEntityPartBindBase(builder);
		}

		// Token: 0x060237A5 RID: 145317 RVA: 0x004E8E02 File Offset: 0x004E7002
		public static void StartIInteractEntityPartBindBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060237A6 RID: 145318 RVA: 0x004E8E0B File Offset: 0x004E700B
		public static void AddType(FlatBufferBuilder builder, EInteractEntityPartBindType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060237A7 RID: 145319 RVA: 0x004E8E16 File Offset: 0x004E7016
		public static Offset<IInteractEntityPartBindBase> EndIInteractEntityPartBindBase(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEntityPartBindBase>(builder.EndTable());
		}

		// Token: 0x060237A8 RID: 145320 RVA: 0x004E8E24 File Offset: 0x004E7024
		public IInteractEntityPartBindBaseT UnPack()
		{
			IInteractEntityPartBindBaseT interactEntityPartBindBaseT = new IInteractEntityPartBindBaseT();
			this.UnPackTo(interactEntityPartBindBaseT);
			return interactEntityPartBindBaseT;
		}

		// Token: 0x060237A9 RID: 145321 RVA: 0x004E8E3F File Offset: 0x004E703F
		public void UnPackTo(IInteractEntityPartBindBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060237AA RID: 145322 RVA: 0x004E8E50 File Offset: 0x004E7050
		public static Offset<IInteractEntityPartBindBase> Pack(FlatBufferBuilder builder, IInteractEntityPartBindBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractEntityPartBindBase>);
			}
			return IInteractEntityPartBindBase.CreateIInteractEntityPartBindBase(builder, _o.Type);
		}

		// Token: 0x0400E6B5 RID: 59061
		private Table __p;
	}
}
