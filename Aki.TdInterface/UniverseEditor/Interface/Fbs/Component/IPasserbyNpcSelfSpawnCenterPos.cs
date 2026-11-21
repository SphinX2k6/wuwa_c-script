using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB1 RID: 23729
	public struct IPasserbyNpcSelfSpawnCenterPos : IFlatbufferObject
	{
		// Token: 0x1700AE54 RID: 44628
		// (get) Token: 0x06027601 RID: 161281 RVA: 0x00563E42 File Offset: 0x00562042
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027602 RID: 161282 RVA: 0x00563E4F File Offset: 0x0056204F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027603 RID: 161283 RVA: 0x00563E58 File Offset: 0x00562058
		public static IPasserbyNpcSelfSpawnCenterPos GetRootAsIPasserbyNpcSelfSpawnCenterPos(ByteBuffer _bb)
		{
			return IPasserbyNpcSelfSpawnCenterPos.GetRootAsIPasserbyNpcSelfSpawnCenterPos(_bb, default(IPasserbyNpcSelfSpawnCenterPos));
		}

		// Token: 0x06027604 RID: 161284 RVA: 0x00563E74 File Offset: 0x00562074
		public static IPasserbyNpcSelfSpawnCenterPos GetRootAsIPasserbyNpcSelfSpawnCenterPos(ByteBuffer _bb, IPasserbyNpcSelfSpawnCenterPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027605 RID: 161285 RVA: 0x00563E91 File Offset: 0x00562091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027606 RID: 161286 RVA: 0x00563EA0 File Offset: 0x005620A0
		public IPasserbyNpcSelfSpawnCenterPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE55 RID: 44629
		// (get) Token: 0x06027607 RID: 161287 RVA: 0x00563EB0 File Offset: 0x005620B0
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

		// Token: 0x06027608 RID: 161288 RVA: 0x00563EEC File Offset: 0x005620EC
		public static Offset<IPasserbyNpcSelfSpawnCenterPos> CreateIPasserbyNpcSelfSpawnCenterPos(FlatBufferBuilder builder, EPasserbyNpcSpawnCenterPosType Type = EPasserbyNpcSpawnCenterPosType.Self)
		{
			builder.StartTable(1);
			IPasserbyNpcSelfSpawnCenterPos.AddType(builder, Type);
			return IPasserbyNpcSelfSpawnCenterPos.EndIPasserbyNpcSelfSpawnCenterPos(builder);
		}

		// Token: 0x06027609 RID: 161289 RVA: 0x00563F02 File Offset: 0x00562102
		public static void StartIPasserbyNpcSelfSpawnCenterPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602760A RID: 161290 RVA: 0x00563F0B File Offset: 0x0056210B
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSpawnCenterPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602760B RID: 161291 RVA: 0x00563F16 File Offset: 0x00562116
		public static Offset<IPasserbyNpcSelfSpawnCenterPos> EndIPasserbyNpcSelfSpawnCenterPos(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSelfSpawnCenterPos>(builder.EndTable());
		}

		// Token: 0x0602760C RID: 161292 RVA: 0x00563F24 File Offset: 0x00562124
		public IPasserbyNpcSelfSpawnCenterPosT UnPack()
		{
			IPasserbyNpcSelfSpawnCenterPosT passerbyNpcSelfSpawnCenterPosT = new IPasserbyNpcSelfSpawnCenterPosT();
			this.UnPackTo(passerbyNpcSelfSpawnCenterPosT);
			return passerbyNpcSelfSpawnCenterPosT;
		}

		// Token: 0x0602760D RID: 161293 RVA: 0x00563F3F File Offset: 0x0056213F
		public void UnPackTo(IPasserbyNpcSelfSpawnCenterPosT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602760E RID: 161294 RVA: 0x00563F50 File Offset: 0x00562150
		public static Offset<IPasserbyNpcSelfSpawnCenterPos> Pack(FlatBufferBuilder builder, IPasserbyNpcSelfSpawnCenterPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSelfSpawnCenterPos>);
			}
			return IPasserbyNpcSelfSpawnCenterPos.CreateIPasserbyNpcSelfSpawnCenterPos(builder, _o.Type);
		}

		// Token: 0x0400F7C9 RID: 63433
		private Table __p;
	}
}
