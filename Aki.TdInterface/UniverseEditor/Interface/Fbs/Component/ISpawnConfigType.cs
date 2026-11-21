using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F4E RID: 24398
	public struct ISpawnConfigType : IFlatbufferObject
	{
		// Token: 0x1700B4B7 RID: 46263
		// (get) Token: 0x0602900E RID: 167950 RVA: 0x00599FC2 File Offset: 0x005981C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602900F RID: 167951 RVA: 0x00599FCF File Offset: 0x005981CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029010 RID: 167952 RVA: 0x00599FD8 File Offset: 0x005981D8
		public static ISpawnConfigType GetRootAsISpawnConfigType(ByteBuffer _bb)
		{
			return ISpawnConfigType.GetRootAsISpawnConfigType(_bb, default(ISpawnConfigType));
		}

		// Token: 0x06029011 RID: 167953 RVA: 0x00599FF4 File Offset: 0x005981F4
		public static ISpawnConfigType GetRootAsISpawnConfigType(ByteBuffer _bb, ISpawnConfigType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029012 RID: 167954 RVA: 0x0059A011 File Offset: 0x00598211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029013 RID: 167955 RVA: 0x0059A020 File Offset: 0x00598220
		public ISpawnConfigType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4B8 RID: 46264
		// (get) Token: 0x06029014 RID: 167956 RVA: 0x0059A030 File Offset: 0x00598230
		public ESpawnConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnConfigType.TemplateMatrix;
				}
				return (ESpawnConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029015 RID: 167957 RVA: 0x0059A06C File Offset: 0x0059826C
		public static Offset<ISpawnConfigType> CreateISpawnConfigType(FlatBufferBuilder builder, ESpawnConfigType Type = ESpawnConfigType.TemplateMatrix)
		{
			builder.StartTable(1);
			ISpawnConfigType.AddType(builder, Type);
			return ISpawnConfigType.EndISpawnConfigType(builder);
		}

		// Token: 0x06029016 RID: 167958 RVA: 0x0059A082 File Offset: 0x00598282
		public static void StartISpawnConfigType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029017 RID: 167959 RVA: 0x0059A08B File Offset: 0x0059828B
		public static void AddType(FlatBufferBuilder builder, ESpawnConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029018 RID: 167960 RVA: 0x0059A096 File Offset: 0x00598296
		public static Offset<ISpawnConfigType> EndISpawnConfigType(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnConfigType>(builder.EndTable());
		}

		// Token: 0x06029019 RID: 167961 RVA: 0x0059A0A4 File Offset: 0x005982A4
		public ISpawnConfigTypeT UnPack()
		{
			ISpawnConfigTypeT spawnConfigTypeT = new ISpawnConfigTypeT();
			this.UnPackTo(spawnConfigTypeT);
			return spawnConfigTypeT;
		}

		// Token: 0x0602901A RID: 167962 RVA: 0x0059A0BF File Offset: 0x005982BF
		public void UnPackTo(ISpawnConfigTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602901B RID: 167963 RVA: 0x0059A0D0 File Offset: 0x005982D0
		public static Offset<ISpawnConfigType> Pack(FlatBufferBuilder builder, ISpawnConfigTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnConfigType>);
			}
			return ISpawnConfigType.CreateISpawnConfigType(builder, _o.Type);
		}

		// Token: 0x0400FC08 RID: 64520
		private Table __p;
	}
}
