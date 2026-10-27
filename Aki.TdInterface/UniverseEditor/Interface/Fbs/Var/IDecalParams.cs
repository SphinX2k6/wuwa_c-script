using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A93 RID: 14995
	public struct IDecalParams : IFlatbufferObject
	{
		// Token: 0x170066B9 RID: 26297
		// (get) Token: 0x06014584 RID: 83332 RVA: 0x002F7EC8 File Offset: 0x002F60C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014585 RID: 83333 RVA: 0x002F7ED5 File Offset: 0x002F60D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014586 RID: 83334 RVA: 0x002F7EDC File Offset: 0x002F60DC
		public static IDecalParams GetRootAsIDecalParams(ByteBuffer _bb)
		{
			return IDecalParams.GetRootAsIDecalParams(_bb, default(IDecalParams));
		}

		// Token: 0x06014587 RID: 83335 RVA: 0x002F7EF8 File Offset: 0x002F60F8
		public static IDecalParams GetRootAsIDecalParams(ByteBuffer _bb, IDecalParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014588 RID: 83336 RVA: 0x002F7F15 File Offset: 0x002F6115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014589 RID: 83337 RVA: 0x002F7F24 File Offset: 0x002F6124
		public IDecalParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170066BA RID: 26298
		// (get) Token: 0x0601458A RID: 83338 RVA: 0x002F7F34 File Offset: 0x002F6134
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066BB RID: 26299
		// (get) Token: 0x0601458B RID: 83339 RVA: 0x002F7F70 File Offset: 0x002F6170
		public float SpreadRadius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066BC RID: 26300
		// (get) Token: 0x0601458C RID: 83340 RVA: 0x002F7FB0 File Offset: 0x002F61B0
		public float SpreadTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601458D RID: 83341 RVA: 0x002F7FF0 File Offset: 0x002F61F0
		public static Offset<IDecalParams> CreateIDecalParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, float SpreadRadius = 0f, float SpreadTime = 0f)
		{
			builder.StartTable(3);
			IDecalParams.AddSpreadTime(builder, SpreadTime);
			IDecalParams.AddSpreadRadius(builder, SpreadRadius);
			IDecalParams.AddType(builder, Type);
			return IDecalParams.EndIDecalParams(builder);
		}

		// Token: 0x0601458E RID: 83342 RVA: 0x002F8014 File Offset: 0x002F6214
		public static void StartIDecalParams(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601458F RID: 83343 RVA: 0x002F801D File Offset: 0x002F621D
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014590 RID: 83344 RVA: 0x002F8028 File Offset: 0x002F6228
		public static void AddSpreadRadius(FlatBufferBuilder builder, float spreadRadius)
		{
			builder.AddFloat(1, spreadRadius, 0.0);
		}

		// Token: 0x06014591 RID: 83345 RVA: 0x002F803B File Offset: 0x002F623B
		public static void AddSpreadTime(FlatBufferBuilder builder, float spreadTime)
		{
			builder.AddFloat(2, spreadTime, 0.0);
		}

		// Token: 0x06014592 RID: 83346 RVA: 0x002F804E File Offset: 0x002F624E
		public static Offset<IDecalParams> EndIDecalParams(FlatBufferBuilder builder)
		{
			return new Offset<IDecalParams>(builder.EndTable());
		}

		// Token: 0x06014593 RID: 83347 RVA: 0x002F805C File Offset: 0x002F625C
		public IDecalParamsT UnPack()
		{
			IDecalParamsT decalParamsT = new IDecalParamsT();
			this.UnPackTo(decalParamsT);
			return decalParamsT;
		}

		// Token: 0x06014594 RID: 83348 RVA: 0x002F8077 File Offset: 0x002F6277
		public void UnPackTo(IDecalParamsT _o)
		{
			_o.Type = this.Type;
			_o.SpreadRadius = this.SpreadRadius;
			_o.SpreadTime = this.SpreadTime;
		}

		// Token: 0x06014595 RID: 83349 RVA: 0x002F80A0 File Offset: 0x002F62A0
		public static Offset<IDecalParams> Pack(FlatBufferBuilder builder, IDecalParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDecalParams>);
			}
			return IDecalParams.CreateIDecalParams(builder, _o.Type, _o.SpreadRadius, _o.SpreadTime);
		}

		// Token: 0x0400AF12 RID: 44818
		private Table __p;
	}
}
