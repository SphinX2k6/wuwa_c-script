using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416C RID: 16748
	public struct ISurvivorsRougeSystemConfig : IFlatbufferObject
	{
		// Token: 0x1700769E RID: 30366
		// (get) Token: 0x0601898E RID: 100750 RVA: 0x0038B055 File Offset: 0x00389255
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601898F RID: 100751 RVA: 0x0038B062 File Offset: 0x00389262
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018990 RID: 100752 RVA: 0x0038B06C File Offset: 0x0038926C
		public static ISurvivorsRougeSystemConfig GetRootAsISurvivorsRougeSystemConfig(ByteBuffer _bb)
		{
			return ISurvivorsRougeSystemConfig.GetRootAsISurvivorsRougeSystemConfig(_bb, default(ISurvivorsRougeSystemConfig));
		}

		// Token: 0x06018991 RID: 100753 RVA: 0x0038B088 File Offset: 0x00389288
		public static ISurvivorsRougeSystemConfig GetRootAsISurvivorsRougeSystemConfig(ByteBuffer _bb, ISurvivorsRougeSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018992 RID: 100754 RVA: 0x0038B0A5 File Offset: 0x003892A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018993 RID: 100755 RVA: 0x0038B0B4 File Offset: 0x003892B4
		public ISurvivorsRougeSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700769F RID: 30367
		// (get) Token: 0x06018994 RID: 100756 RVA: 0x0038B0C4 File Offset: 0x003892C4
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

		// Token: 0x06018995 RID: 100757 RVA: 0x0038B100 File Offset: 0x00389300
		public ISurvivorsRougeSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISurvivorsRougeSystemVar?(default(ISurvivorsRougeSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170076A0 RID: 30368
		// (get) Token: 0x06018996 RID: 100758 RVA: 0x0038B160 File Offset: 0x00389360
		public int VarsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018997 RID: 100759 RVA: 0x0038B18B File Offset: 0x0038938B
		public static Offset<ISurvivorsRougeSystemConfig> CreateISurvivorsRougeSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISurvivorsRougeSystemConfig.AddVars(builder, VarsOffset);
			ISurvivorsRougeSystemConfig.AddType(builder, Type);
			return ISurvivorsRougeSystemConfig.EndISurvivorsRougeSystemConfig(builder);
		}

		// Token: 0x06018998 RID: 100760 RVA: 0x0038B1A8 File Offset: 0x003893A8
		public static void StartISurvivorsRougeSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018999 RID: 100761 RVA: 0x0038B1B1 File Offset: 0x003893B1
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601899A RID: 100762 RVA: 0x0038B1BC File Offset: 0x003893BC
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x0601899B RID: 100763 RVA: 0x0038B1CC File Offset: 0x003893CC
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<ISurvivorsRougeSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601899C RID: 100764 RVA: 0x0038B20C File Offset: 0x0038940C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<ISurvivorsRougeSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISurvivorsRougeSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601899D RID: 100765 RVA: 0x0038B226 File Offset: 0x00389426
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISurvivorsRougeSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISurvivorsRougeSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601899E RID: 100766 RVA: 0x0038B244 File Offset: 0x00389444
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISurvivorsRougeSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601899F RID: 100767 RVA: 0x0038B25D File Offset: 0x0038945D
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060189A0 RID: 100768 RVA: 0x0038B268 File Offset: 0x00389468
		public static Offset<ISurvivorsRougeSystemConfig> EndISurvivorsRougeSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeSystemConfig>(builder.EndTable());
		}

		// Token: 0x060189A1 RID: 100769 RVA: 0x0038B278 File Offset: 0x00389478
		public ISurvivorsRougeSystemConfigT UnPack()
		{
			ISurvivorsRougeSystemConfigT survivorsRougeSystemConfigT = new ISurvivorsRougeSystemConfigT();
			this.UnPackTo(survivorsRougeSystemConfigT);
			return survivorsRougeSystemConfigT;
		}

		// Token: 0x060189A2 RID: 100770 RVA: 0x0038B294 File Offset: 0x00389494
		public void UnPackTo(ISurvivorsRougeSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<ISurvivorsRougeSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060189A3 RID: 100771 RVA: 0x0038B300 File Offset: 0x00389500
		public static Offset<ISurvivorsRougeSystemConfig> Pack(FlatBufferBuilder builder, ISurvivorsRougeSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<ISurvivorsRougeSystemVar>[] array = new Offset<ISurvivorsRougeSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISurvivorsRougeSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = ISurvivorsRougeSystemConfig.CreateVarsVector(builder, array);
			}
			return ISurvivorsRougeSystemConfig.CreateISurvivorsRougeSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400BD87 RID: 48519
		private Table __p;
	}
}
