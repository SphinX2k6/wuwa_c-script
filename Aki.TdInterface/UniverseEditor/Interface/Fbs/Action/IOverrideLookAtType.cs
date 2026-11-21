using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073BE RID: 29630
	public struct IOverrideLookAtType : IFlatbufferObject
	{
		// Token: 0x1700D9AF RID: 55727
		// (get) Token: 0x06033D42 RID: 212290 RVA: 0x006FDA88 File Offset: 0x006FBC88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D43 RID: 212291 RVA: 0x006FDA95 File Offset: 0x006FBC95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D44 RID: 212292 RVA: 0x006FDA9C File Offset: 0x006FBC9C
		public static IOverrideLookAtType GetRootAsIOverrideLookAtType(ByteBuffer _bb)
		{
			return IOverrideLookAtType.GetRootAsIOverrideLookAtType(_bb, default(IOverrideLookAtType));
		}

		// Token: 0x06033D45 RID: 212293 RVA: 0x006FDAB8 File Offset: 0x006FBCB8
		public static IOverrideLookAtType GetRootAsIOverrideLookAtType(ByteBuffer _bb, IOverrideLookAtType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D46 RID: 212294 RVA: 0x006FDAD5 File Offset: 0x006FBCD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D47 RID: 212295 RVA: 0x006FDAE4 File Offset: 0x006FBCE4
		public IOverrideLookAtType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9B0 RID: 55728
		// (get) Token: 0x06033D48 RID: 212296 RVA: 0x006FDAF4 File Offset: 0x006FBCF4
		public EOverrideLookAtType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOverrideLookAtType.CheckFlowLookAt;
				}
				return (EOverrideLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033D49 RID: 212297 RVA: 0x006FDB30 File Offset: 0x006FBD30
		public static Offset<IOverrideLookAtType> CreateIOverrideLookAtType(FlatBufferBuilder builder, EOverrideLookAtType Type = EOverrideLookAtType.CheckFlowLookAt)
		{
			builder.StartTable(1);
			IOverrideLookAtType.AddType(builder, Type);
			return IOverrideLookAtType.EndIOverrideLookAtType(builder);
		}

		// Token: 0x06033D4A RID: 212298 RVA: 0x006FDB46 File Offset: 0x006FBD46
		public static void StartIOverrideLookAtType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033D4B RID: 212299 RVA: 0x006FDB4F File Offset: 0x006FBD4F
		public static void AddType(FlatBufferBuilder builder, EOverrideLookAtType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033D4C RID: 212300 RVA: 0x006FDB5A File Offset: 0x006FBD5A
		public static Offset<IOverrideLookAtType> EndIOverrideLookAtType(FlatBufferBuilder builder)
		{
			return new Offset<IOverrideLookAtType>(builder.EndTable());
		}

		// Token: 0x06033D4D RID: 212301 RVA: 0x006FDB68 File Offset: 0x006FBD68
		public IOverrideLookAtTypeT UnPack()
		{
			IOverrideLookAtTypeT overrideLookAtTypeT = new IOverrideLookAtTypeT();
			this.UnPackTo(overrideLookAtTypeT);
			return overrideLookAtTypeT;
		}

		// Token: 0x06033D4E RID: 212302 RVA: 0x006FDB83 File Offset: 0x006FBD83
		public void UnPackTo(IOverrideLookAtTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033D4F RID: 212303 RVA: 0x006FDB94 File Offset: 0x006FBD94
		public static Offset<IOverrideLookAtType> Pack(FlatBufferBuilder builder, IOverrideLookAtTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOverrideLookAtType>);
			}
			return IOverrideLookAtType.CreateIOverrideLookAtType(builder, _o.Type);
		}

		// Token: 0x040124F2 RID: 74994
		private Table __p;
	}
}
