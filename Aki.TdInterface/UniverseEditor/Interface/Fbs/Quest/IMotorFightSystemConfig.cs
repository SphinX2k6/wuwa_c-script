using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F44 RID: 16196
	public struct IMotorFightSystemConfig : IFlatbufferObject
	{
		// Token: 0x170070A1 RID: 28833
		// (get) Token: 0x06017051 RID: 94289 RVA: 0x00351CFE File Offset: 0x0034FEFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017052 RID: 94290 RVA: 0x00351D0B File Offset: 0x0034FF0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017053 RID: 94291 RVA: 0x00351D14 File Offset: 0x0034FF14
		public static IMotorFightSystemConfig GetRootAsIMotorFightSystemConfig(ByteBuffer _bb)
		{
			return IMotorFightSystemConfig.GetRootAsIMotorFightSystemConfig(_bb, default(IMotorFightSystemConfig));
		}

		// Token: 0x06017054 RID: 94292 RVA: 0x00351D30 File Offset: 0x0034FF30
		public static IMotorFightSystemConfig GetRootAsIMotorFightSystemConfig(ByteBuffer _bb, IMotorFightSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017055 RID: 94293 RVA: 0x00351D4D File Offset: 0x0034FF4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017056 RID: 94294 RVA: 0x00351D5C File Offset: 0x0034FF5C
		public IMotorFightSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070A2 RID: 28834
		// (get) Token: 0x06017057 RID: 94295 RVA: 0x00351D6C File Offset: 0x0034FF6C
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

		// Token: 0x06017058 RID: 94296 RVA: 0x00351DA8 File Offset: 0x0034FFA8
		public IMotorFightSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IMotorFightSystemVar?(default(IMotorFightSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170070A3 RID: 28835
		// (get) Token: 0x06017059 RID: 94297 RVA: 0x00351E08 File Offset: 0x00350008
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

		// Token: 0x0601705A RID: 94298 RVA: 0x00351E33 File Offset: 0x00350033
		public static Offset<IMotorFightSystemConfig> CreateIMotorFightSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMotorFightSystemConfig.AddVars(builder, VarsOffset);
			IMotorFightSystemConfig.AddType(builder, Type);
			return IMotorFightSystemConfig.EndIMotorFightSystemConfig(builder);
		}

		// Token: 0x0601705B RID: 94299 RVA: 0x00351E50 File Offset: 0x00350050
		public static void StartIMotorFightSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601705C RID: 94300 RVA: 0x00351E59 File Offset: 0x00350059
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601705D RID: 94301 RVA: 0x00351E64 File Offset: 0x00350064
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x0601705E RID: 94302 RVA: 0x00351E74 File Offset: 0x00350074
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IMotorFightSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601705F RID: 94303 RVA: 0x00351EB4 File Offset: 0x003500B4
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IMotorFightSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMotorFightSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017060 RID: 94304 RVA: 0x00351ECE File Offset: 0x003500CE
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMotorFightSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMotorFightSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017061 RID: 94305 RVA: 0x00351EEC File Offset: 0x003500EC
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMotorFightSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017062 RID: 94306 RVA: 0x00351F05 File Offset: 0x00350105
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017063 RID: 94307 RVA: 0x00351F10 File Offset: 0x00350110
		public static Offset<IMotorFightSystemConfig> EndIMotorFightSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorFightSystemConfig>(builder.EndTable());
		}

		// Token: 0x06017064 RID: 94308 RVA: 0x00351F20 File Offset: 0x00350120
		public IMotorFightSystemConfigT UnPack()
		{
			IMotorFightSystemConfigT motorFightSystemConfigT = new IMotorFightSystemConfigT();
			this.UnPackTo(motorFightSystemConfigT);
			return motorFightSystemConfigT;
		}

		// Token: 0x06017065 RID: 94309 RVA: 0x00351F3C File Offset: 0x0035013C
		public void UnPackTo(IMotorFightSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IMotorFightSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06017066 RID: 94310 RVA: 0x00351FA8 File Offset: 0x003501A8
		public static Offset<IMotorFightSystemConfig> Pack(FlatBufferBuilder builder, IMotorFightSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorFightSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IMotorFightSystemVar>[] array = new Offset<IMotorFightSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMotorFightSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IMotorFightSystemConfig.CreateVarsVector(builder, array);
			}
			return IMotorFightSystemConfig.CreateIMotorFightSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400B954 RID: 47444
		private Table __p;
	}
}
