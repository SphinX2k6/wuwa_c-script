using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E7E RID: 15998
	public struct IGradingSystemConfig : IFlatbufferObject
	{
		// Token: 0x17006EF5 RID: 28405
		// (get) Token: 0x060168B5 RID: 92341 RVA: 0x00341F47 File Offset: 0x00340147
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060168B6 RID: 92342 RVA: 0x00341F54 File Offset: 0x00340154
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060168B7 RID: 92343 RVA: 0x00341F5C File Offset: 0x0034015C
		public static IGradingSystemConfig GetRootAsIGradingSystemConfig(ByteBuffer _bb)
		{
			return IGradingSystemConfig.GetRootAsIGradingSystemConfig(_bb, default(IGradingSystemConfig));
		}

		// Token: 0x060168B8 RID: 92344 RVA: 0x00341F78 File Offset: 0x00340178
		public static IGradingSystemConfig GetRootAsIGradingSystemConfig(ByteBuffer _bb, IGradingSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060168B9 RID: 92345 RVA: 0x00341F95 File Offset: 0x00340195
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060168BA RID: 92346 RVA: 0x00341FA4 File Offset: 0x003401A4
		public IGradingSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EF6 RID: 28406
		// (get) Token: 0x060168BB RID: 92347 RVA: 0x00341FB4 File Offset: 0x003401B4
		public EEnableSystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableSystemType.GradingSystem;
				}
				return (EEnableSystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006EF7 RID: 28407
		// (get) Token: 0x060168BC RID: 92348 RVA: 0x00341FF0 File Offset: 0x003401F0
		public int GradingSystemId
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

		// Token: 0x060168BD RID: 92349 RVA: 0x0034202C File Offset: 0x0034022C
		public IGradingSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IGradingSystemVar?(default(IGradingSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006EF8 RID: 28408
		// (get) Token: 0x060168BE RID: 92350 RVA: 0x0034208C File Offset: 0x0034028C
		public int VarsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17006EF9 RID: 28409
		// (get) Token: 0x060168BF RID: 92351 RVA: 0x003420B8 File Offset: 0x003402B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060168C0 RID: 92352 RVA: 0x003420F5 File Offset: 0x003402F5
		public static Offset<IGradingSystemConfig> CreateIGradingSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, int GradingSystemId = 0, VectorOffset VarsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IGradingSystemConfig.AddVars(builder, VarsOffset);
			IGradingSystemConfig.AddGradingSystemId(builder, GradingSystemId);
			IGradingSystemConfig.AddNullMask(builder, NullMask);
			IGradingSystemConfig.AddType(builder, Type);
			return IGradingSystemConfig.EndIGradingSystemConfig(builder);
		}

		// Token: 0x060168C1 RID: 92353 RVA: 0x00342121 File Offset: 0x00340321
		public static void StartIGradingSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060168C2 RID: 92354 RVA: 0x0034212A File Offset: 0x0034032A
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060168C3 RID: 92355 RVA: 0x00342135 File Offset: 0x00340335
		public static void AddGradingSystemId(FlatBufferBuilder builder, int gradingSystemId)
		{
			builder.AddInt(1, gradingSystemId, 0);
		}

		// Token: 0x060168C4 RID: 92356 RVA: 0x00342140 File Offset: 0x00340340
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x060168C5 RID: 92357 RVA: 0x00342150 File Offset: 0x00340350
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IGradingSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060168C6 RID: 92358 RVA: 0x00342190 File Offset: 0x00340390
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IGradingSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGradingSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060168C7 RID: 92359 RVA: 0x003421AA File Offset: 0x003403AA
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGradingSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGradingSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060168C8 RID: 92360 RVA: 0x003421C8 File Offset: 0x003403C8
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGradingSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060168C9 RID: 92361 RVA: 0x003421E1 File Offset: 0x003403E1
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060168CA RID: 92362 RVA: 0x003421EC File Offset: 0x003403EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060168CB RID: 92363 RVA: 0x003421F7 File Offset: 0x003403F7
		public static Offset<IGradingSystemConfig> EndIGradingSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGradingSystemConfig>(builder.EndTable());
		}

		// Token: 0x060168CC RID: 92364 RVA: 0x00342204 File Offset: 0x00340404
		public IGradingSystemConfigT UnPack()
		{
			IGradingSystemConfigT gradingSystemConfigT = new IGradingSystemConfigT();
			this.UnPackTo(gradingSystemConfigT);
			return gradingSystemConfigT;
		}

		// Token: 0x060168CD RID: 92365 RVA: 0x00342220 File Offset: 0x00340420
		public void UnPackTo(IGradingSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.GradingSystemId = this.GradingSystemId;
			_o.Vars = new List<IGradingSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060168CE RID: 92366 RVA: 0x003422A4 File Offset: 0x003404A4
		public static Offset<IGradingSystemConfig> Pack(FlatBufferBuilder builder, IGradingSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGradingSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IGradingSystemVar>[] array = new Offset<IGradingSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IGradingSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IGradingSystemConfig.CreateVarsVector(builder, array);
			}
			return IGradingSystemConfig.CreateIGradingSystemConfig(builder, _o.Type, _o.GradingSystemId, varsOffset, _o.NullMask);
		}

		// Token: 0x0400B837 RID: 47159
		private Table __p;
	}
}
