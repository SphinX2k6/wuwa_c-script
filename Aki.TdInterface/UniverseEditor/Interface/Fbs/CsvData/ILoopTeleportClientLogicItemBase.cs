using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D9A RID: 19866
	public struct ILoopTeleportClientLogicItemBase : IFlatbufferObject
	{
		// Token: 0x17008E28 RID: 36392
		// (get) Token: 0x0601ECFF RID: 126207 RVA: 0x0044EAC7 File Offset: 0x0044CCC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED00 RID: 126208 RVA: 0x0044EAD4 File Offset: 0x0044CCD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED01 RID: 126209 RVA: 0x0044EADC File Offset: 0x0044CCDC
		public static ILoopTeleportClientLogicItemBase GetRootAsILoopTeleportClientLogicItemBase(ByteBuffer _bb)
		{
			return ILoopTeleportClientLogicItemBase.GetRootAsILoopTeleportClientLogicItemBase(_bb, default(ILoopTeleportClientLogicItemBase));
		}

		// Token: 0x0601ED02 RID: 126210 RVA: 0x0044EAF8 File Offset: 0x0044CCF8
		public static ILoopTeleportClientLogicItemBase GetRootAsILoopTeleportClientLogicItemBase(ByteBuffer _bb, ILoopTeleportClientLogicItemBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED03 RID: 126211 RVA: 0x0044EB15 File Offset: 0x0044CD15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED04 RID: 126212 RVA: 0x0044EB24 File Offset: 0x0044CD24
		public ILoopTeleportClientLogicItemBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E29 RID: 36393
		// (get) Token: 0x0601ED05 RID: 126213 RVA: 0x0044EB34 File Offset: 0x0044CD34
		public ELoopTeleportClientLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELoopTeleportClientLogicType.PlayEffect;
				}
				return (ELoopTeleportClientLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ED06 RID: 126214 RVA: 0x0044EB70 File Offset: 0x0044CD70
		public static Offset<ILoopTeleportClientLogicItemBase> CreateILoopTeleportClientLogicItemBase(FlatBufferBuilder builder, ELoopTeleportClientLogicType Type = ELoopTeleportClientLogicType.PlayEffect)
		{
			builder.StartTable(1);
			ILoopTeleportClientLogicItemBase.AddType(builder, Type);
			return ILoopTeleportClientLogicItemBase.EndILoopTeleportClientLogicItemBase(builder);
		}

		// Token: 0x0601ED07 RID: 126215 RVA: 0x0044EB86 File Offset: 0x0044CD86
		public static void StartILoopTeleportClientLogicItemBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601ED08 RID: 126216 RVA: 0x0044EB8F File Offset: 0x0044CD8F
		public static void AddType(FlatBufferBuilder builder, ELoopTeleportClientLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ED09 RID: 126217 RVA: 0x0044EB9A File Offset: 0x0044CD9A
		public static Offset<ILoopTeleportClientLogicItemBase> EndILoopTeleportClientLogicItemBase(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportClientLogicItemBase>(builder.EndTable());
		}

		// Token: 0x0601ED0A RID: 126218 RVA: 0x0044EBA8 File Offset: 0x0044CDA8
		public ILoopTeleportClientLogicItemBaseT UnPack()
		{
			ILoopTeleportClientLogicItemBaseT loopTeleportClientLogicItemBaseT = new ILoopTeleportClientLogicItemBaseT();
			this.UnPackTo(loopTeleportClientLogicItemBaseT);
			return loopTeleportClientLogicItemBaseT;
		}

		// Token: 0x0601ED0B RID: 126219 RVA: 0x0044EBC3 File Offset: 0x0044CDC3
		public void UnPackTo(ILoopTeleportClientLogicItemBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601ED0C RID: 126220 RVA: 0x0044EBD4 File Offset: 0x0044CDD4
		public static Offset<ILoopTeleportClientLogicItemBase> Pack(FlatBufferBuilder builder, ILoopTeleportClientLogicItemBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopTeleportClientLogicItemBase>);
			}
			return ILoopTeleportClientLogicItemBase.CreateILoopTeleportClientLogicItemBase(builder, _o.Type);
		}

		// Token: 0x0400D9F8 RID: 55800
		private Table __p;
	}
}
