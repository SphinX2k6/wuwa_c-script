using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E3F RID: 28223
	public struct IFireBulletType : IFlatbufferObject
	{
		// Token: 0x1700CEE3 RID: 52963
		// (get) Token: 0x06030C03 RID: 199683 RVA: 0x0069DF99 File Offset: 0x0069C199
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030C04 RID: 199684 RVA: 0x0069DFA6 File Offset: 0x0069C1A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030C05 RID: 199685 RVA: 0x0069DFB0 File Offset: 0x0069C1B0
		public static IFireBulletType GetRootAsIFireBulletType(ByteBuffer _bb)
		{
			return IFireBulletType.GetRootAsIFireBulletType(_bb, default(IFireBulletType));
		}

		// Token: 0x06030C06 RID: 199686 RVA: 0x0069DFCC File Offset: 0x0069C1CC
		public static IFireBulletType GetRootAsIFireBulletType(ByteBuffer _bb, IFireBulletType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030C07 RID: 199687 RVA: 0x0069DFE9 File Offset: 0x0069C1E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030C08 RID: 199688 RVA: 0x0069DFF8 File Offset: 0x0069C1F8
		public IFireBulletType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEE4 RID: 52964
		// (get) Token: 0x06030C09 RID: 199689 RVA: 0x0069E008 File Offset: 0x0069C208
		public EFireBulletType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFireBulletType.TrackTarget;
				}
				return (EFireBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030C0A RID: 199690 RVA: 0x0069E044 File Offset: 0x0069C244
		public static Offset<IFireBulletType> CreateIFireBulletType(FlatBufferBuilder builder, EFireBulletType Type = EFireBulletType.TrackTarget)
		{
			builder.StartTable(1);
			IFireBulletType.AddType(builder, Type);
			return IFireBulletType.EndIFireBulletType(builder);
		}

		// Token: 0x06030C0B RID: 199691 RVA: 0x0069E05A File Offset: 0x0069C25A
		public static void StartIFireBulletType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030C0C RID: 199692 RVA: 0x0069E063 File Offset: 0x0069C263
		public static void AddType(FlatBufferBuilder builder, EFireBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030C0D RID: 199693 RVA: 0x0069E06E File Offset: 0x0069C26E
		public static Offset<IFireBulletType> EndIFireBulletType(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletType>(builder.EndTable());
		}

		// Token: 0x06030C0E RID: 199694 RVA: 0x0069E07C File Offset: 0x0069C27C
		public IFireBulletTypeT UnPack()
		{
			IFireBulletTypeT fireBulletTypeT = new IFireBulletTypeT();
			this.UnPackTo(fireBulletTypeT);
			return fireBulletTypeT;
		}

		// Token: 0x06030C0F RID: 199695 RVA: 0x0069E097 File Offset: 0x0069C297
		public void UnPackTo(IFireBulletTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030C10 RID: 199696 RVA: 0x0069E0A8 File Offset: 0x0069C2A8
		public static Offset<IFireBulletType> Pack(FlatBufferBuilder builder, IFireBulletTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBulletType>);
			}
			return IFireBulletType.CreateIFireBulletType(builder, _o.Type);
		}

		// Token: 0x04011D07 RID: 72967
		private Table __p;
	}
}
