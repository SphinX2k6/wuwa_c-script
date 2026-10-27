using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062E4 RID: 25316
	public struct IChangeEntityPrefabPerformance : IFlatbufferObject
	{
		// Token: 0x1700BCEF RID: 48367
		// (get) Token: 0x0602BC1D RID: 179229 RVA: 0x00605182 File Offset: 0x00603382
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BC1E RID: 179230 RVA: 0x0060518F File Offset: 0x0060338F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BC1F RID: 179231 RVA: 0x00605198 File Offset: 0x00603398
		public static IChangeEntityPrefabPerformance GetRootAsIChangeEntityPrefabPerformance(ByteBuffer _bb)
		{
			return IChangeEntityPrefabPerformance.GetRootAsIChangeEntityPrefabPerformance(_bb, default(IChangeEntityPrefabPerformance));
		}

		// Token: 0x0602BC20 RID: 179232 RVA: 0x006051B4 File Offset: 0x006033B4
		public static IChangeEntityPrefabPerformance GetRootAsIChangeEntityPrefabPerformance(ByteBuffer _bb, IChangeEntityPrefabPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BC21 RID: 179233 RVA: 0x006051D1 File Offset: 0x006033D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BC22 RID: 179234 RVA: 0x006051E0 File Offset: 0x006033E0
		public IChangeEntityPrefabPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCF0 RID: 48368
		// (get) Token: 0x0602BC23 RID: 179235 RVA: 0x006051F0 File Offset: 0x006033F0
		public EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeEntityPrefabPerformanceType.Target;
				}
				return (EChangeEntityPrefabPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BC24 RID: 179236 RVA: 0x0060522C File Offset: 0x0060342C
		public static Offset<IChangeEntityPrefabPerformance> CreateIChangeEntityPrefabPerformance(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target)
		{
			builder.StartTable(1);
			IChangeEntityPrefabPerformance.AddType(builder, Type);
			return IChangeEntityPrefabPerformance.EndIChangeEntityPrefabPerformance(builder);
		}

		// Token: 0x0602BC25 RID: 179237 RVA: 0x00605242 File Offset: 0x00603442
		public static void StartIChangeEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BC26 RID: 179238 RVA: 0x0060524B File Offset: 0x0060344B
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BC27 RID: 179239 RVA: 0x00605256 File Offset: 0x00603456
		public static Offset<IChangeEntityPrefabPerformance> EndIChangeEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityPrefabPerformance>(builder.EndTable());
		}

		// Token: 0x0602BC28 RID: 179240 RVA: 0x00605264 File Offset: 0x00603464
		public IChangeEntityPrefabPerformanceT UnPack()
		{
			IChangeEntityPrefabPerformanceT changeEntityPrefabPerformanceT = new IChangeEntityPrefabPerformanceT();
			this.UnPackTo(changeEntityPrefabPerformanceT);
			return changeEntityPrefabPerformanceT;
		}

		// Token: 0x0602BC29 RID: 179241 RVA: 0x0060527F File Offset: 0x0060347F
		public void UnPackTo(IChangeEntityPrefabPerformanceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BC2A RID: 179242 RVA: 0x00605290 File Offset: 0x00603490
		public static Offset<IChangeEntityPrefabPerformance> Pack(FlatBufferBuilder builder, IChangeEntityPrefabPerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityPrefabPerformance>);
			}
			return IChangeEntityPrefabPerformance.CreateIChangeEntityPrefabPerformance(builder, _o.Type);
		}

		// Token: 0x0401088E RID: 67726
		private Table __p;
	}
}
