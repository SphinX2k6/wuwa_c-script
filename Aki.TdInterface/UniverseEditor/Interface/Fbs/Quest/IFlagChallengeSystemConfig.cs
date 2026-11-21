using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004292 RID: 17042
	public struct IFlagChallengeSystemConfig : IFlatbufferObject
	{
		// Token: 0x1700748F RID: 29839
		// (get) Token: 0x06017D88 RID: 97672 RVA: 0x003680AD File Offset: 0x003662AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017D89 RID: 97673 RVA: 0x003680BA File Offset: 0x003662BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017D8A RID: 97674 RVA: 0x003680C4 File Offset: 0x003662C4
		public static IFlagChallengeSystemConfig GetRootAsIFlagChallengeSystemConfig(ByteBuffer _bb)
		{
			return IFlagChallengeSystemConfig.GetRootAsIFlagChallengeSystemConfig(_bb, default(IFlagChallengeSystemConfig));
		}

		// Token: 0x06017D8B RID: 97675 RVA: 0x003680E0 File Offset: 0x003662E0
		public static IFlagChallengeSystemConfig GetRootAsIFlagChallengeSystemConfig(ByteBuffer _bb, IFlagChallengeSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017D8C RID: 97676 RVA: 0x003680FD File Offset: 0x003662FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017D8D RID: 97677 RVA: 0x0036810C File Offset: 0x0036630C
		public IFlagChallengeSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007490 RID: 29840
		// (get) Token: 0x06017D8E RID: 97678 RVA: 0x0036811C File Offset: 0x0036631C
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

		// Token: 0x06017D8F RID: 97679 RVA: 0x00368158 File Offset: 0x00366358
		public IFlagChallengeSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFlagChallengeSystemVar?(default(IFlagChallengeSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007491 RID: 29841
		// (get) Token: 0x06017D90 RID: 97680 RVA: 0x003681B8 File Offset: 0x003663B8
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

		// Token: 0x06017D91 RID: 97681 RVA: 0x003681E3 File Offset: 0x003663E3
		public static Offset<IFlagChallengeSystemConfig> CreateIFlagChallengeSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFlagChallengeSystemConfig.AddVars(builder, VarsOffset);
			IFlagChallengeSystemConfig.AddType(builder, Type);
			return IFlagChallengeSystemConfig.EndIFlagChallengeSystemConfig(builder);
		}

		// Token: 0x06017D92 RID: 97682 RVA: 0x00368200 File Offset: 0x00366400
		public static void StartIFlagChallengeSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017D93 RID: 97683 RVA: 0x00368209 File Offset: 0x00366409
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017D94 RID: 97684 RVA: 0x00368214 File Offset: 0x00366414
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x06017D95 RID: 97685 RVA: 0x00368224 File Offset: 0x00366424
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IFlagChallengeSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017D96 RID: 97686 RVA: 0x00368264 File Offset: 0x00366464
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IFlagChallengeSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlagChallengeSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017D97 RID: 97687 RVA: 0x0036827E File Offset: 0x0036647E
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlagChallengeSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlagChallengeSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017D98 RID: 97688 RVA: 0x0036829C File Offset: 0x0036649C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlagChallengeSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017D99 RID: 97689 RVA: 0x003682B5 File Offset: 0x003664B5
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017D9A RID: 97690 RVA: 0x003682C0 File Offset: 0x003664C0
		public static Offset<IFlagChallengeSystemConfig> EndIFlagChallengeSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlagChallengeSystemConfig>(builder.EndTable());
		}

		// Token: 0x06017D9B RID: 97691 RVA: 0x003682D0 File Offset: 0x003664D0
		public IFlagChallengeSystemConfigT UnPack()
		{
			IFlagChallengeSystemConfigT flagChallengeSystemConfigT = new IFlagChallengeSystemConfigT();
			this.UnPackTo(flagChallengeSystemConfigT);
			return flagChallengeSystemConfigT;
		}

		// Token: 0x06017D9C RID: 97692 RVA: 0x003682EC File Offset: 0x003664EC
		public void UnPackTo(IFlagChallengeSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IFlagChallengeSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06017D9D RID: 97693 RVA: 0x00368358 File Offset: 0x00366558
		public static Offset<IFlagChallengeSystemConfig> Pack(FlatBufferBuilder builder, IFlagChallengeSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlagChallengeSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IFlagChallengeSystemVar>[] array = new Offset<IFlagChallengeSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFlagChallengeSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IFlagChallengeSystemConfig.CreateVarsVector(builder, array);
			}
			return IFlagChallengeSystemConfig.CreateIFlagChallengeSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400C1DE RID: 49630
		private Table __p;
	}
}
