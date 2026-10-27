using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043A1 RID: 17313
	public struct IManualOccupationRefSource : IFlatbufferObject
	{
		// Token: 0x17007A5F RID: 31327
		// (get) Token: 0x06019C51 RID: 105553 RVA: 0x003B0842 File Offset: 0x003AEA42
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019C52 RID: 105554 RVA: 0x003B084F File Offset: 0x003AEA4F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019C53 RID: 105555 RVA: 0x003B0858 File Offset: 0x003AEA58
		public static IManualOccupationRefSource GetRootAsIManualOccupationRefSource(ByteBuffer _bb)
		{
			return IManualOccupationRefSource.GetRootAsIManualOccupationRefSource(_bb, default(IManualOccupationRefSource));
		}

		// Token: 0x06019C54 RID: 105556 RVA: 0x003B0874 File Offset: 0x003AEA74
		public static IManualOccupationRefSource GetRootAsIManualOccupationRefSource(ByteBuffer _bb, IManualOccupationRefSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019C55 RID: 105557 RVA: 0x003B0891 File Offset: 0x003AEA91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019C56 RID: 105558 RVA: 0x003B08A0 File Offset: 0x003AEAA0
		public IManualOccupationRefSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A60 RID: 31328
		// (get) Token: 0x06019C57 RID: 105559 RVA: 0x003B08B0 File Offset: 0x003AEAB0
		public ERefSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefSourceType.AwakeEntity;
				}
				return (ERefSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019C58 RID: 105560 RVA: 0x003B08EC File Offset: 0x003AEAEC
		public static Offset<IManualOccupationRefSource> CreateIManualOccupationRefSource(FlatBufferBuilder builder, ERefSourceType Type = ERefSourceType.AwakeEntity)
		{
			builder.StartTable(1);
			IManualOccupationRefSource.AddType(builder, Type);
			return IManualOccupationRefSource.EndIManualOccupationRefSource(builder);
		}

		// Token: 0x06019C59 RID: 105561 RVA: 0x003B0902 File Offset: 0x003AEB02
		public static void StartIManualOccupationRefSource(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019C5A RID: 105562 RVA: 0x003B090B File Offset: 0x003AEB0B
		public static void AddType(FlatBufferBuilder builder, ERefSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019C5B RID: 105563 RVA: 0x003B0916 File Offset: 0x003AEB16
		public static Offset<IManualOccupationRefSource> EndIManualOccupationRefSource(FlatBufferBuilder builder)
		{
			return new Offset<IManualOccupationRefSource>(builder.EndTable());
		}

		// Token: 0x06019C5C RID: 105564 RVA: 0x003B0924 File Offset: 0x003AEB24
		public IManualOccupationRefSourceT UnPack()
		{
			IManualOccupationRefSourceT manualOccupationRefSourceT = new IManualOccupationRefSourceT();
			this.UnPackTo(manualOccupationRefSourceT);
			return manualOccupationRefSourceT;
		}

		// Token: 0x06019C5D RID: 105565 RVA: 0x003B093F File Offset: 0x003AEB3F
		public void UnPackTo(IManualOccupationRefSourceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019C5E RID: 105566 RVA: 0x003B0950 File Offset: 0x003AEB50
		public static Offset<IManualOccupationRefSource> Pack(FlatBufferBuilder builder, IManualOccupationRefSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IManualOccupationRefSource>);
			}
			return IManualOccupationRefSource.CreateIManualOccupationRefSource(builder, _o.Type);
		}

		// Token: 0x0400C1D5 RID: 49621
		private Table __p;
	}
}
