using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200446C RID: 17516
	public struct IQuestScheduleMultiBtTreeVar : IFlatbufferObject
	{
		// Token: 0x17007994 RID: 31124
		// (get) Token: 0x060192A9 RID: 103081 RVA: 0x003972CD File Offset: 0x003954CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060192AA RID: 103082 RVA: 0x003972DA File Offset: 0x003954DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060192AB RID: 103083 RVA: 0x003972E4 File Offset: 0x003954E4
		public static IQuestScheduleMultiBtTreeVar GetRootAsIQuestScheduleMultiBtTreeVar(ByteBuffer _bb)
		{
			return IQuestScheduleMultiBtTreeVar.GetRootAsIQuestScheduleMultiBtTreeVar(_bb, default(IQuestScheduleMultiBtTreeVar));
		}

		// Token: 0x060192AC RID: 103084 RVA: 0x00397300 File Offset: 0x00395500
		public static IQuestScheduleMultiBtTreeVar GetRootAsIQuestScheduleMultiBtTreeVar(ByteBuffer _bb, IQuestScheduleMultiBtTreeVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060192AD RID: 103085 RVA: 0x0039731D File Offset: 0x0039551D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060192AE RID: 103086 RVA: 0x0039732C File Offset: 0x0039552C
		public IQuestScheduleMultiBtTreeVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007995 RID: 31125
		// (get) Token: 0x060192AF RID: 103087 RVA: 0x0039733C File Offset: 0x0039553C
		public EQuestScheduleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestScheduleType.None;
				}
				return (EQuestScheduleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060192B0 RID: 103088 RVA: 0x00397378 File Offset: 0x00395578
		public TVarRef VarsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TVarRef.NONE;
			}
			return (TVarRef)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007996 RID: 31126
		// (get) Token: 0x060192B1 RID: 103089 RVA: 0x003973B8 File Offset: 0x003955B8
		public int VarsTypeLength
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

		// Token: 0x060192B2 RID: 103090 RVA: 0x003973E3 File Offset: 0x003955E3
		public Span<TVarRef> GetVarsTypeBytes()
		{
			return this.__p.__vector_as_span<TVarRef>(6, 1);
		}

		// Token: 0x060192B3 RID: 103091 RVA: 0x003973F4 File Offset: 0x003955F4
		public TVarRef[] GetVarsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TVarRef[] array = new TVarRef[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TVarRef)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060192B4 RID: 103092 RVA: 0x00397460 File Offset: 0x00395660
		public TTable? Vars<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007997 RID: 31127
		// (get) Token: 0x060192B5 RID: 103093 RVA: 0x003974A8 File Offset: 0x003956A8
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

		// Token: 0x17007998 RID: 31128
		// (get) Token: 0x060192B6 RID: 103094 RVA: 0x003974D4 File Offset: 0x003956D4
		public IWordArtConfig? ShowAsWordArt
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IWordArtConfig?(default(IWordArtConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060192B7 RID: 103095 RVA: 0x00397532 File Offset: 0x00395732
		public static Offset<IQuestScheduleMultiBtTreeVar> CreateIQuestScheduleMultiBtTreeVar(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, VectorOffset Vars_typeOffset = default(VectorOffset), VectorOffset VarsOffset = default(VectorOffset), Offset<IWordArtConfig> ShowAsWordArtOffset = default(Offset<IWordArtConfig>))
		{
			builder.StartTable(4);
			IQuestScheduleMultiBtTreeVar.AddShowAsWordArt(builder, ShowAsWordArtOffset);
			IQuestScheduleMultiBtTreeVar.AddVars(builder, VarsOffset);
			IQuestScheduleMultiBtTreeVar.AddVarsType(builder, Vars_typeOffset);
			IQuestScheduleMultiBtTreeVar.AddType(builder, Type);
			return IQuestScheduleMultiBtTreeVar.EndIQuestScheduleMultiBtTreeVar(builder);
		}

		// Token: 0x060192B8 RID: 103096 RVA: 0x0039755E File Offset: 0x0039575E
		public static void StartIQuestScheduleMultiBtTreeVar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060192B9 RID: 103097 RVA: 0x00397567 File Offset: 0x00395767
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060192BA RID: 103098 RVA: 0x00397572 File Offset: 0x00395772
		public static void AddVarsType(FlatBufferBuilder builder, VectorOffset varsTypeOffset)
		{
			builder.AddOffset(1, varsTypeOffset.Value, 0);
		}

		// Token: 0x060192BB RID: 103099 RVA: 0x00397584 File Offset: 0x00395784
		public static VectorOffset CreateVarsTypeVector(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060192BC RID: 103100 RVA: 0x003975BB File Offset: 0x003957BB
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x060192BD RID: 103101 RVA: 0x003975D5 File Offset: 0x003957D5
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVarRef> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x060192BE RID: 103102 RVA: 0x003975F3 File Offset: 0x003957F3
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVarRef>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060192BF RID: 103103 RVA: 0x0039760C File Offset: 0x0039580C
		public static void StartVarsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060192C0 RID: 103104 RVA: 0x00397617 File Offset: 0x00395817
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x060192C1 RID: 103105 RVA: 0x00397628 File Offset: 0x00395828
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060192C2 RID: 103106 RVA: 0x0039765F File Offset: 0x0039585F
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060192C3 RID: 103107 RVA: 0x00397679 File Offset: 0x00395879
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060192C4 RID: 103108 RVA: 0x00397697 File Offset: 0x00395897
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060192C5 RID: 103109 RVA: 0x003976B0 File Offset: 0x003958B0
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060192C6 RID: 103110 RVA: 0x003976BB File Offset: 0x003958BB
		public static void AddShowAsWordArt(FlatBufferBuilder builder, Offset<IWordArtConfig> showAsWordArtOffset)
		{
			builder.AddOffset(3, showAsWordArtOffset.Value, 0);
		}

		// Token: 0x060192C7 RID: 103111 RVA: 0x003976CB File Offset: 0x003958CB
		public static Offset<IQuestScheduleMultiBtTreeVar> EndIQuestScheduleMultiBtTreeVar(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleMultiBtTreeVar>(builder.EndTable());
		}

		// Token: 0x060192C8 RID: 103112 RVA: 0x003976D8 File Offset: 0x003958D8
		public IQuestScheduleMultiBtTreeVarT UnPack()
		{
			IQuestScheduleMultiBtTreeVarT questScheduleMultiBtTreeVarT = new IQuestScheduleMultiBtTreeVarT();
			this.UnPackTo(questScheduleMultiBtTreeVarT);
			return questScheduleMultiBtTreeVarT;
		}

		// Token: 0x060192C9 RID: 103113 RVA: 0x003976F4 File Offset: 0x003958F4
		public void UnPackTo(IQuestScheduleMultiBtTreeVarT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<TVarRefUnion>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				TVarRefUnion tvarRefUnion = new TVarRefUnion();
				tvarRefUnion.Type = this.VarsType(i);
				switch (this.VarsType(i))
				{
				case TVarRef.IConstVarRef:
					tvarRefUnion.Value = ((this.Vars<IConstVarRef>(i) != null) ? this.Vars<IConstVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.IGlobalVarRef:
					tvarRefUnion.Value = ((this.Vars<IGlobalVarRef>(i) != null) ? this.Vars<IGlobalVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.IOtherVarRef:
					tvarRefUnion.Value = ((this.Vars<IOtherVarRef>(i) != null) ? this.Vars<IOtherVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.ISelfVarRef:
					tvarRefUnion.Value = ((this.Vars<ISelfVarRef>(i) != null) ? this.Vars<ISelfVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.ISystemVarRef:
					tvarRefUnion.Value = ((this.Vars<ISystemVarRef>(i) != null) ? this.Vars<ISystemVarRef>(i).Value.UnPack() : null);
					break;
				}
				_o.Vars.Add(tvarRefUnion);
			}
			_o.ShowAsWordArt = ((this.ShowAsWordArt != null) ? this.ShowAsWordArt.Value.UnPack() : null);
		}

		// Token: 0x060192CA RID: 103114 RVA: 0x003978BC File Offset: 0x00395ABC
		public static Offset<IQuestScheduleMultiBtTreeVar> Pack(FlatBufferBuilder builder, IQuestScheduleMultiBtTreeVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleMultiBtTreeVar>);
			}
			VectorOffset vars_typeOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				TVarRef[] array = new TVarRef[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Vars[i].Type;
				}
				vars_typeOffset = IQuestScheduleMultiBtTreeVar.CreateVarsTypeVector(builder, array);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				int[] array2 = new int[_o.Vars.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TVarRefUnion.Pack(builder, _o.Vars[j]);
				}
				varsOffset = IQuestScheduleMultiBtTreeVar.CreateVarsVector(builder, array2);
			}
			Offset<IWordArtConfig> showAsWordArtOffset = (_o.ShowAsWordArt == null) ? default(Offset<IWordArtConfig>) : IWordArtConfig.Pack(builder, _o.ShowAsWordArt);
			return IQuestScheduleMultiBtTreeVar.CreateIQuestScheduleMultiBtTreeVar(builder, _o.Type, vars_typeOffset, varsOffset, showAsWordArtOffset);
		}

		// Token: 0x0400C540 RID: 50496
		private Table __p;
	}
}
