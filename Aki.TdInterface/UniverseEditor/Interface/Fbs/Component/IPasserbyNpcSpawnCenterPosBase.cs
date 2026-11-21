using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC0 RID: 23744
	public struct IPasserbyNpcSpawnCenterPosBase : IFlatbufferObject
	{
		// Token: 0x1700AE67 RID: 44647
		// (get) Token: 0x0602765D RID: 161373 RVA: 0x00564694 File Offset: 0x00562894
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602765E RID: 161374 RVA: 0x005646A1 File Offset: 0x005628A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602765F RID: 161375 RVA: 0x005646A8 File Offset: 0x005628A8
		public static IPasserbyNpcSpawnCenterPosBase GetRootAsIPasserbyNpcSpawnCenterPosBase(ByteBuffer _bb)
		{
			return IPasserbyNpcSpawnCenterPosBase.GetRootAsIPasserbyNpcSpawnCenterPosBase(_bb, default(IPasserbyNpcSpawnCenterPosBase));
		}

		// Token: 0x06027660 RID: 161376 RVA: 0x005646C4 File Offset: 0x005628C4
		public static IPasserbyNpcSpawnCenterPosBase GetRootAsIPasserbyNpcSpawnCenterPosBase(ByteBuffer _bb, IPasserbyNpcSpawnCenterPosBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027661 RID: 161377 RVA: 0x005646E1 File Offset: 0x005628E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027662 RID: 161378 RVA: 0x005646F0 File Offset: 0x005628F0
		public IPasserbyNpcSpawnCenterPosBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE68 RID: 44648
		// (get) Token: 0x06027663 RID: 161379 RVA: 0x00564700 File Offset: 0x00562900
		public EPasserbyNpcSpawnCenterPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcSpawnCenterPosType.Self;
				}
				return (EPasserbyNpcSpawnCenterPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027664 RID: 161380 RVA: 0x0056473C File Offset: 0x0056293C
		public static Offset<IPasserbyNpcSpawnCenterPosBase> CreateIPasserbyNpcSpawnCenterPosBase(FlatBufferBuilder builder, EPasserbyNpcSpawnCenterPosType Type = EPasserbyNpcSpawnCenterPosType.Self)
		{
			builder.StartTable(1);
			IPasserbyNpcSpawnCenterPosBase.AddType(builder, Type);
			return IPasserbyNpcSpawnCenterPosBase.EndIPasserbyNpcSpawnCenterPosBase(builder);
		}

		// Token: 0x06027665 RID: 161381 RVA: 0x00564752 File Offset: 0x00562952
		public static void StartIPasserbyNpcSpawnCenterPosBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027666 RID: 161382 RVA: 0x0056475B File Offset: 0x0056295B
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSpawnCenterPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027667 RID: 161383 RVA: 0x00564766 File Offset: 0x00562966
		public static Offset<IPasserbyNpcSpawnCenterPosBase> EndIPasserbyNpcSpawnCenterPosBase(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSpawnCenterPosBase>(builder.EndTable());
		}

		// Token: 0x06027668 RID: 161384 RVA: 0x00564774 File Offset: 0x00562974
		public IPasserbyNpcSpawnCenterPosBaseT UnPack()
		{
			IPasserbyNpcSpawnCenterPosBaseT passerbyNpcSpawnCenterPosBaseT = new IPasserbyNpcSpawnCenterPosBaseT();
			this.UnPackTo(passerbyNpcSpawnCenterPosBaseT);
			return passerbyNpcSpawnCenterPosBaseT;
		}

		// Token: 0x06027669 RID: 161385 RVA: 0x0056478F File Offset: 0x0056298F
		public void UnPackTo(IPasserbyNpcSpawnCenterPosBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602766A RID: 161386 RVA: 0x005647A0 File Offset: 0x005629A0
		public static Offset<IPasserbyNpcSpawnCenterPosBase> Pack(FlatBufferBuilder builder, IPasserbyNpcSpawnCenterPosBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSpawnCenterPosBase>);
			}
			return IPasserbyNpcSpawnCenterPosBase.CreateIPasserbyNpcSpawnCenterPosBase(builder, _o.Type);
		}

		// Token: 0x0400F7DF RID: 63455
		private Table __p;
	}
}
