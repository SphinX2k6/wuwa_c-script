using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A3 RID: 29603
	public struct ITeleportTransitionType : IFlatbufferObject
	{
		// Token: 0x1700E0BF RID: 57535
		// (get) Token: 0x06035BD3 RID: 220115 RVA: 0x00750BDC File Offset: 0x0074EDDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035BD4 RID: 220116 RVA: 0x00750BE9 File Offset: 0x0074EDE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035BD5 RID: 220117 RVA: 0x00750BF0 File Offset: 0x0074EDF0
		public static ITeleportTransitionType GetRootAsITeleportTransitionType(ByteBuffer _bb)
		{
			return ITeleportTransitionType.GetRootAsITeleportTransitionType(_bb, default(ITeleportTransitionType));
		}

		// Token: 0x06035BD6 RID: 220118 RVA: 0x00750C0C File Offset: 0x0074EE0C
		public static ITeleportTransitionType GetRootAsITeleportTransitionType(ByteBuffer _bb, ITeleportTransitionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035BD7 RID: 220119 RVA: 0x00750C29 File Offset: 0x0074EE29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035BD8 RID: 220120 RVA: 0x00750C38 File Offset: 0x0074EE38
		public ITeleportTransitionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0C0 RID: 57536
		// (get) Token: 0x06035BD9 RID: 220121 RVA: 0x00750C48 File Offset: 0x0074EE48
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035BDA RID: 220122 RVA: 0x00750C84 File Offset: 0x0074EE84
		public static Offset<ITeleportTransitionType> CreateITeleportTransitionType(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4)
		{
			builder.StartTable(1);
			ITeleportTransitionType.AddType(builder, Type);
			return ITeleportTransitionType.EndITeleportTransitionType(builder);
		}

		// Token: 0x06035BDB RID: 220123 RVA: 0x00750C9A File Offset: 0x0074EE9A
		public static void StartITeleportTransitionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035BDC RID: 220124 RVA: 0x00750CA3 File Offset: 0x0074EEA3
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035BDD RID: 220125 RVA: 0x00750CAE File Offset: 0x0074EEAE
		public static Offset<ITeleportTransitionType> EndITeleportTransitionType(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionType>(builder.EndTable());
		}

		// Token: 0x06035BDE RID: 220126 RVA: 0x00750CBC File Offset: 0x0074EEBC
		public ITeleportTransitionTypeT UnPack()
		{
			ITeleportTransitionTypeT teleportTransitionTypeT = new ITeleportTransitionTypeT();
			this.UnPackTo(teleportTransitionTypeT);
			return teleportTransitionTypeT;
		}

		// Token: 0x06035BDF RID: 220127 RVA: 0x00750CD7 File Offset: 0x0074EED7
		public void UnPackTo(ITeleportTransitionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035BE0 RID: 220128 RVA: 0x00750CE8 File Offset: 0x0074EEE8
		public static Offset<ITeleportTransitionType> Pack(FlatBufferBuilder builder, ITeleportTransitionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionType>);
			}
			return ITeleportTransitionType.CreateITeleportTransitionType(builder, _o.Type);
		}

		// Token: 0x040121CB RID: 74187
		private Table __p;
	}
}
