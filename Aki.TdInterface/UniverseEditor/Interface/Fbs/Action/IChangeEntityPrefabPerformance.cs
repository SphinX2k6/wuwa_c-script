using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006955 RID: 26965
	public struct IChangeEntityPrefabPerformance : IFlatbufferObject
	{
		// Token: 0x1700C679 RID: 50809
		// (get) Token: 0x0602E386 RID: 189318 RVA: 0x0065018E File Offset: 0x0064E38E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E387 RID: 189319 RVA: 0x0065019B File Offset: 0x0064E39B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E388 RID: 189320 RVA: 0x006501A4 File Offset: 0x0064E3A4
		public static IChangeEntityPrefabPerformance GetRootAsIChangeEntityPrefabPerformance(ByteBuffer _bb)
		{
			return IChangeEntityPrefabPerformance.GetRootAsIChangeEntityPrefabPerformance(_bb, default(IChangeEntityPrefabPerformance));
		}

		// Token: 0x0602E389 RID: 189321 RVA: 0x006501C0 File Offset: 0x0064E3C0
		public static IChangeEntityPrefabPerformance GetRootAsIChangeEntityPrefabPerformance(ByteBuffer _bb, IChangeEntityPrefabPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E38A RID: 189322 RVA: 0x006501DD File Offset: 0x0064E3DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E38B RID: 189323 RVA: 0x006501EC File Offset: 0x0064E3EC
		public IChangeEntityPrefabPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C67A RID: 50810
		// (get) Token: 0x0602E38C RID: 189324 RVA: 0x006501FC File Offset: 0x0064E3FC
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

		// Token: 0x0602E38D RID: 189325 RVA: 0x00650238 File Offset: 0x0064E438
		public static Offset<IChangeEntityPrefabPerformance> CreateIChangeEntityPrefabPerformance(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target)
		{
			builder.StartTable(1);
			IChangeEntityPrefabPerformance.AddType(builder, Type);
			return IChangeEntityPrefabPerformance.EndIChangeEntityPrefabPerformance(builder);
		}

		// Token: 0x0602E38E RID: 189326 RVA: 0x0065024E File Offset: 0x0064E44E
		public static void StartIChangeEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E38F RID: 189327 RVA: 0x00650257 File Offset: 0x0064E457
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E390 RID: 189328 RVA: 0x00650262 File Offset: 0x0064E462
		public static Offset<IChangeEntityPrefabPerformance> EndIChangeEntityPrefabPerformance(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityPrefabPerformance>(builder.EndTable());
		}

		// Token: 0x0602E391 RID: 189329 RVA: 0x00650270 File Offset: 0x0064E470
		public IChangeEntityPrefabPerformanceT UnPack()
		{
			IChangeEntityPrefabPerformanceT changeEntityPrefabPerformanceT = new IChangeEntityPrefabPerformanceT();
			this.UnPackTo(changeEntityPrefabPerformanceT);
			return changeEntityPrefabPerformanceT;
		}

		// Token: 0x0602E392 RID: 189330 RVA: 0x0065028B File Offset: 0x0064E48B
		public void UnPackTo(IChangeEntityPrefabPerformanceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E393 RID: 189331 RVA: 0x0065029C File Offset: 0x0064E49C
		public static Offset<IChangeEntityPrefabPerformance> Pack(FlatBufferBuilder builder, IChangeEntityPrefabPerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityPrefabPerformance>);
			}
			return IChangeEntityPrefabPerformance.CreateIChangeEntityPrefabPerformance(builder, _o.Type);
		}

		// Token: 0x040116A4 RID: 71332
		private Table __p;
	}
}
