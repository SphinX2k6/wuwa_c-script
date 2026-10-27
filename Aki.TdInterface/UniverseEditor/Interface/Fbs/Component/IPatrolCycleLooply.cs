using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005707 RID: 22279
	public struct IPatrolCycleLooply : IFlatbufferObject
	{
		// Token: 0x1700A5E1 RID: 42465
		// (get) Token: 0x060253FB RID: 152571 RVA: 0x00523DF4 File Offset: 0x00521FF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060253FC RID: 152572 RVA: 0x00523E01 File Offset: 0x00522001
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060253FD RID: 152573 RVA: 0x00523E08 File Offset: 0x00522008
		public static IPatrolCycleLooply GetRootAsIPatrolCycleLooply(ByteBuffer _bb)
		{
			return IPatrolCycleLooply.GetRootAsIPatrolCycleLooply(_bb, default(IPatrolCycleLooply));
		}

		// Token: 0x060253FE RID: 152574 RVA: 0x00523E24 File Offset: 0x00522024
		public static IPatrolCycleLooply GetRootAsIPatrolCycleLooply(ByteBuffer _bb, IPatrolCycleLooply obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060253FF RID: 152575 RVA: 0x00523E41 File Offset: 0x00522041
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025400 RID: 152576 RVA: 0x00523E50 File Offset: 0x00522050
		public IPatrolCycleLooply __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5E2 RID: 42466
		// (get) Token: 0x06025401 RID: 152577 RVA: 0x00523E60 File Offset: 0x00522060
		public EPatrolCycleMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPatrolCycleMode.Loop;
				}
				return (EPatrolCycleMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A5E3 RID: 42467
		// (get) Token: 0x06025402 RID: 152578 RVA: 0x00523E9C File Offset: 0x0052209C
		public bool IsCircle
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025403 RID: 152579 RVA: 0x00523EDB File Offset: 0x005220DB
		public static Offset<IPatrolCycleLooply> CreateIPatrolCycleLooply(FlatBufferBuilder builder, EPatrolCycleMode Type = EPatrolCycleMode.Loop, bool IsCircle = false)
		{
			builder.StartTable(2);
			IPatrolCycleLooply.AddIsCircle(builder, IsCircle);
			IPatrolCycleLooply.AddType(builder, Type);
			return IPatrolCycleLooply.EndIPatrolCycleLooply(builder);
		}

		// Token: 0x06025404 RID: 152580 RVA: 0x00523EF8 File Offset: 0x005220F8
		public static void StartIPatrolCycleLooply(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025405 RID: 152581 RVA: 0x00523F01 File Offset: 0x00522101
		public static void AddType(FlatBufferBuilder builder, EPatrolCycleMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025406 RID: 152582 RVA: 0x00523F0C File Offset: 0x0052210C
		public static void AddIsCircle(FlatBufferBuilder builder, bool isCircle)
		{
			builder.AddBool(1, isCircle, false);
		}

		// Token: 0x06025407 RID: 152583 RVA: 0x00523F17 File Offset: 0x00522117
		public static Offset<IPatrolCycleLooply> EndIPatrolCycleLooply(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolCycleLooply>(builder.EndTable());
		}

		// Token: 0x06025408 RID: 152584 RVA: 0x00523F24 File Offset: 0x00522124
		public IPatrolCycleLooplyT UnPack()
		{
			IPatrolCycleLooplyT patrolCycleLooplyT = new IPatrolCycleLooplyT();
			this.UnPackTo(patrolCycleLooplyT);
			return patrolCycleLooplyT;
		}

		// Token: 0x06025409 RID: 152585 RVA: 0x00523F3F File Offset: 0x0052213F
		public void UnPackTo(IPatrolCycleLooplyT _o)
		{
			_o.Type = this.Type;
			_o.IsCircle = this.IsCircle;
		}

		// Token: 0x0602540A RID: 152586 RVA: 0x00523F5C File Offset: 0x0052215C
		public static Offset<IPatrolCycleLooply> Pack(FlatBufferBuilder builder, IPatrolCycleLooplyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolCycleLooply>);
			}
			return IPatrolCycleLooply.CreateIPatrolCycleLooply(builder, _o.Type, _o.IsCircle);
		}

		// Token: 0x0400EB67 RID: 60263
		private Table __p;
	}
}
