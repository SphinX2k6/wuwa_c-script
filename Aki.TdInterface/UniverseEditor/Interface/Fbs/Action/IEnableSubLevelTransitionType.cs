using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D04 RID: 27908
	public struct IEnableSubLevelTransitionType : IFlatbufferObject
	{
		// Token: 0x1700CCC6 RID: 52422
		// (get) Token: 0x06030210 RID: 197136 RVA: 0x0068BD81 File Offset: 0x00689F81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030211 RID: 197137 RVA: 0x0068BD8E File Offset: 0x00689F8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030212 RID: 197138 RVA: 0x0068BD98 File Offset: 0x00689F98
		public static IEnableSubLevelTransitionType GetRootAsIEnableSubLevelTransitionType(ByteBuffer _bb)
		{
			return IEnableSubLevelTransitionType.GetRootAsIEnableSubLevelTransitionType(_bb, default(IEnableSubLevelTransitionType));
		}

		// Token: 0x06030213 RID: 197139 RVA: 0x0068BDB4 File Offset: 0x00689FB4
		public static IEnableSubLevelTransitionType GetRootAsIEnableSubLevelTransitionType(ByteBuffer _bb, IEnableSubLevelTransitionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030214 RID: 197140 RVA: 0x0068BDD1 File Offset: 0x00689FD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030215 RID: 197141 RVA: 0x0068BDE0 File Offset: 0x00689FE0
		public IEnableSubLevelTransitionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCC7 RID: 52423
		// (get) Token: 0x06030216 RID: 197142 RVA: 0x0068BDF0 File Offset: 0x00689FF0
		public EEnableSubLevelTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableSubLevelTransitionType.SceneCapture;
				}
				return (EEnableSubLevelTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030217 RID: 197143 RVA: 0x0068BE2C File Offset: 0x0068A02C
		public static Offset<IEnableSubLevelTransitionType> CreateIEnableSubLevelTransitionType(FlatBufferBuilder builder, EEnableSubLevelTransitionType Type = EEnableSubLevelTransitionType.SceneCapture)
		{
			builder.StartTable(1);
			IEnableSubLevelTransitionType.AddType(builder, Type);
			return IEnableSubLevelTransitionType.EndIEnableSubLevelTransitionType(builder);
		}

		// Token: 0x06030218 RID: 197144 RVA: 0x0068BE42 File Offset: 0x0068A042
		public static void StartIEnableSubLevelTransitionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030219 RID: 197145 RVA: 0x0068BE4B File Offset: 0x0068A04B
		public static void AddType(FlatBufferBuilder builder, EEnableSubLevelTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603021A RID: 197146 RVA: 0x0068BE56 File Offset: 0x0068A056
		public static Offset<IEnableSubLevelTransitionType> EndIEnableSubLevelTransitionType(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSubLevelTransitionType>(builder.EndTable());
		}

		// Token: 0x0603021B RID: 197147 RVA: 0x0068BE64 File Offset: 0x0068A064
		public IEnableSubLevelTransitionTypeT UnPack()
		{
			IEnableSubLevelTransitionTypeT enableSubLevelTransitionTypeT = new IEnableSubLevelTransitionTypeT();
			this.UnPackTo(enableSubLevelTransitionTypeT);
			return enableSubLevelTransitionTypeT;
		}

		// Token: 0x0603021C RID: 197148 RVA: 0x0068BE7F File Offset: 0x0068A07F
		public void UnPackTo(IEnableSubLevelTransitionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603021D RID: 197149 RVA: 0x0068BE90 File Offset: 0x0068A090
		public static Offset<IEnableSubLevelTransitionType> Pack(FlatBufferBuilder builder, IEnableSubLevelTransitionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSubLevelTransitionType>);
			}
			return IEnableSubLevelTransitionType.CreateIEnableSubLevelTransitionType(builder, _o.Type);
		}

		// Token: 0x04011B65 RID: 72549
		private Table __p;
	}
}
