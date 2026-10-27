using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005941 RID: 22849
	public struct ISpawnConfigType : IFlatbufferObject
	{
		// Token: 0x1700AB83 RID: 43907
		// (get) Token: 0x06026AA4 RID: 158372 RVA: 0x00553356 File Offset: 0x00551556
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026AA5 RID: 158373 RVA: 0x00553363 File Offset: 0x00551563
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026AA6 RID: 158374 RVA: 0x0055336C File Offset: 0x0055156C
		public static ISpawnConfigType GetRootAsISpawnConfigType(ByteBuffer _bb)
		{
			return ISpawnConfigType.GetRootAsISpawnConfigType(_bb, default(ISpawnConfigType));
		}

		// Token: 0x06026AA7 RID: 158375 RVA: 0x00553388 File Offset: 0x00551588
		public static ISpawnConfigType GetRootAsISpawnConfigType(ByteBuffer _bb, ISpawnConfigType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026AA8 RID: 158376 RVA: 0x005533A5 File Offset: 0x005515A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026AA9 RID: 158377 RVA: 0x005533B4 File Offset: 0x005515B4
		public ISpawnConfigType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB84 RID: 43908
		// (get) Token: 0x06026AAA RID: 158378 RVA: 0x005533C4 File Offset: 0x005515C4
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

		// Token: 0x06026AAB RID: 158379 RVA: 0x00553400 File Offset: 0x00551600
		public static Offset<ISpawnConfigType> CreateISpawnConfigType(FlatBufferBuilder builder, ESpawnConfigType Type = ESpawnConfigType.TemplateMatrix)
		{
			builder.StartTable(1);
			ISpawnConfigType.AddType(builder, Type);
			return ISpawnConfigType.EndISpawnConfigType(builder);
		}

		// Token: 0x06026AAC RID: 158380 RVA: 0x00553416 File Offset: 0x00551616
		public static void StartISpawnConfigType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026AAD RID: 158381 RVA: 0x0055341F File Offset: 0x0055161F
		public static void AddType(FlatBufferBuilder builder, ESpawnConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026AAE RID: 158382 RVA: 0x0055342A File Offset: 0x0055162A
		public static Offset<ISpawnConfigType> EndISpawnConfigType(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnConfigType>(builder.EndTable());
		}

		// Token: 0x06026AAF RID: 158383 RVA: 0x00553438 File Offset: 0x00551638
		public ISpawnConfigTypeT UnPack()
		{
			ISpawnConfigTypeT spawnConfigTypeT = new ISpawnConfigTypeT();
			this.UnPackTo(spawnConfigTypeT);
			return spawnConfigTypeT;
		}

		// Token: 0x06026AB0 RID: 158384 RVA: 0x00553453 File Offset: 0x00551653
		public void UnPackTo(ISpawnConfigTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026AB1 RID: 158385 RVA: 0x00553464 File Offset: 0x00551664
		public static Offset<ISpawnConfigType> Pack(FlatBufferBuilder builder, ISpawnConfigTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnConfigType>);
			}
			return ISpawnConfigType.CreateISpawnConfigType(builder, _o.Type);
		}

		// Token: 0x0400EF13 RID: 61203
		private Table __p;
	}
}
