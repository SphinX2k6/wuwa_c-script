using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E60 RID: 20064
	public struct ICheckCollectiblesDetectionAllowed : IFlatbufferObject
	{
		// Token: 0x17008F0E RID: 36622
		// (get) Token: 0x0601F103 RID: 127235 RVA: 0x00455F44 File Offset: 0x00454144
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F104 RID: 127236 RVA: 0x00455F51 File Offset: 0x00454151
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F105 RID: 127237 RVA: 0x00455F58 File Offset: 0x00454158
		public static ICheckCollectiblesDetectionAllowed GetRootAsICheckCollectiblesDetectionAllowed(ByteBuffer _bb)
		{
			return ICheckCollectiblesDetectionAllowed.GetRootAsICheckCollectiblesDetectionAllowed(_bb, default(ICheckCollectiblesDetectionAllowed));
		}

		// Token: 0x0601F106 RID: 127238 RVA: 0x00455F74 File Offset: 0x00454174
		public static ICheckCollectiblesDetectionAllowed GetRootAsICheckCollectiblesDetectionAllowed(ByteBuffer _bb, ICheckCollectiblesDetectionAllowed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F107 RID: 127239 RVA: 0x00455F91 File Offset: 0x00454191
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F108 RID: 127240 RVA: 0x00455FA0 File Offset: 0x004541A0
		public ICheckCollectiblesDetectionAllowed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F0F RID: 36623
		// (get) Token: 0x0601F109 RID: 127241 RVA: 0x00455FB0 File Offset: 0x004541B0
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008F10 RID: 36624
		// (get) Token: 0x0601F10A RID: 127242 RVA: 0x00455FEC File Offset: 0x004541EC
		public int CollectiblesDetectionId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008F11 RID: 36625
		// (get) Token: 0x0601F10B RID: 127243 RVA: 0x00456028 File Offset: 0x00454228
		public bool IsDetectable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F10C RID: 127244 RVA: 0x00456067 File Offset: 0x00454267
		public static Offset<ICheckCollectiblesDetectionAllowed> CreateICheckCollectiblesDetectionAllowed(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int CollectiblesDetectionId = 0, bool IsDetectable = false)
		{
			builder.StartTable(3);
			ICheckCollectiblesDetectionAllowed.AddCollectiblesDetectionId(builder, CollectiblesDetectionId);
			ICheckCollectiblesDetectionAllowed.AddIsDetectable(builder, IsDetectable);
			ICheckCollectiblesDetectionAllowed.AddType(builder, Type);
			return ICheckCollectiblesDetectionAllowed.EndICheckCollectiblesDetectionAllowed(builder);
		}

		// Token: 0x0601F10D RID: 127245 RVA: 0x0045608B File Offset: 0x0045428B
		public static void StartICheckCollectiblesDetectionAllowed(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F10E RID: 127246 RVA: 0x00456094 File Offset: 0x00454294
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F10F RID: 127247 RVA: 0x0045609F File Offset: 0x0045429F
		public static void AddCollectiblesDetectionId(FlatBufferBuilder builder, int collectiblesDetectionId)
		{
			builder.AddInt(1, collectiblesDetectionId, 0);
		}

		// Token: 0x0601F110 RID: 127248 RVA: 0x004560AA File Offset: 0x004542AA
		public static void AddIsDetectable(FlatBufferBuilder builder, bool isDetectable)
		{
			builder.AddBool(2, isDetectable, false);
		}

		// Token: 0x0601F111 RID: 127249 RVA: 0x004560B5 File Offset: 0x004542B5
		public static Offset<ICheckCollectiblesDetectionAllowed> EndICheckCollectiblesDetectionAllowed(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCollectiblesDetectionAllowed>(builder.EndTable());
		}

		// Token: 0x0601F112 RID: 127250 RVA: 0x004560C4 File Offset: 0x004542C4
		public ICheckCollectiblesDetectionAllowedT UnPack()
		{
			ICheckCollectiblesDetectionAllowedT checkCollectiblesDetectionAllowedT = new ICheckCollectiblesDetectionAllowedT();
			this.UnPackTo(checkCollectiblesDetectionAllowedT);
			return checkCollectiblesDetectionAllowedT;
		}

		// Token: 0x0601F113 RID: 127251 RVA: 0x004560DF File Offset: 0x004542DF
		public void UnPackTo(ICheckCollectiblesDetectionAllowedT _o)
		{
			_o.Type = this.Type;
			_o.CollectiblesDetectionId = this.CollectiblesDetectionId;
			_o.IsDetectable = this.IsDetectable;
		}

		// Token: 0x0601F114 RID: 127252 RVA: 0x00456108 File Offset: 0x00454308
		public static Offset<ICheckCollectiblesDetectionAllowed> Pack(FlatBufferBuilder builder, ICheckCollectiblesDetectionAllowedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCollectiblesDetectionAllowed>);
			}
			return ICheckCollectiblesDetectionAllowed.CreateICheckCollectiblesDetectionAllowed(builder, _o.Type, _o.CollectiblesDetectionId, _o.IsDetectable);
		}

		// Token: 0x0400DC91 RID: 56465
		private Table __p;
	}
}
