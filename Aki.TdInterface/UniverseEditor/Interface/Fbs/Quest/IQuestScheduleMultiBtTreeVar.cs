using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200402B RID: 16427
	public struct IQuestScheduleMultiBtTreeVar : IFlatbufferObject
	{
		// Token: 0x17007392 RID: 29586
		// (get) Token: 0x06017C10 RID: 97296 RVA: 0x0036D4D9 File Offset: 0x0036B6D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017C11 RID: 97297 RVA: 0x0036D4E6 File Offset: 0x0036B6E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017C12 RID: 97298 RVA: 0x0036D4F0 File Offset: 0x0036B6F0
		public static IQuestScheduleMultiBtTreeVar GetRootAsIQuestScheduleMultiBtTreeVar(ByteBuffer _bb)
		{
			return IQuestScheduleMultiBtTreeVar.GetRootAsIQuestScheduleMultiBtTreeVar(_bb, default(IQuestScheduleMultiBtTreeVar));
		}

		// Token: 0x06017C13 RID: 97299 RVA: 0x0036D50C File Offset: 0x0036B70C
		public static IQuestScheduleMultiBtTreeVar GetRootAsIQuestScheduleMultiBtTreeVar(ByteBuffer _bb, IQuestScheduleMultiBtTreeVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017C14 RID: 97300 RVA: 0x0036D529 File Offset: 0x0036B729
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017C15 RID: 97301 RVA: 0x0036D538 File Offset: 0x0036B738
		public IQuestScheduleMultiBtTreeVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007393 RID: 29587
		// (get) Token: 0x06017C16 RID: 97302 RVA: 0x0036D548 File Offset: 0x0036B748
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

		// Token: 0x06017C17 RID: 97303 RVA: 0x0036D584 File Offset: 0x0036B784
		public TVarRef VarsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TVarRef.NONE;
			}
			return (TVarRef)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007394 RID: 29588
		// (get) Token: 0x06017C18 RID: 97304 RVA: 0x0036D5C4 File Offset: 0x0036B7C4
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

		// Token: 0x06017C19 RID: 97305 RVA: 0x0036D5EF File Offset: 0x0036B7EF
		public Span<TVarRef> GetVarsTypeBytes()
		{
			return this.__p.__vector_as_span<TVarRef>(6, 1);
		}

		// Token: 0x06017C1A RID: 97306 RVA: 0x0036D600 File Offset: 0x0036B800
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

		// Token: 0x06017C1B RID: 97307 RVA: 0x0036D66C File Offset: 0x0036B86C
		public TTable? Vars<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007395 RID: 29589
		// (get) Token: 0x06017C1C RID: 97308 RVA: 0x0036D6B4 File Offset: 0x0036B8B4
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

		// Token: 0x17007396 RID: 29590
		// (get) Token: 0x06017C1D RID: 97309 RVA: 0x0036D6E0 File Offset: 0x0036B8E0
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

		// Token: 0x06017C1E RID: 97310 RVA: 0x0036D73E File Offset: 0x0036B93E
		public static Offset<IQuestScheduleMultiBtTreeVar> CreateIQuestScheduleMultiBtTreeVar(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, VectorOffset Vars_typeOffset = default(VectorOffset), VectorOffset VarsOffset = default(VectorOffset), Offset<IWordArtConfig> ShowAsWordArtOffset = default(Offset<IWordArtConfig>))
		{
			builder.StartTable(4);
			IQuestScheduleMultiBtTreeVar.AddShowAsWordArt(builder, ShowAsWordArtOffset);
			IQuestScheduleMultiBtTreeVar.AddVars(builder, VarsOffset);
			IQuestScheduleMultiBtTreeVar.AddVarsType(builder, Vars_typeOffset);
			IQuestScheduleMultiBtTreeVar.AddType(builder, Type);
			return IQuestScheduleMultiBtTreeVar.EndIQuestScheduleMultiBtTreeVar(builder);
		}

		// Token: 0x06017C1F RID: 97311 RVA: 0x0036D76A File Offset: 0x0036B96A
		public static void StartIQuestScheduleMultiBtTreeVar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017C20 RID: 97312 RVA: 0x0036D773 File Offset: 0x0036B973
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017C21 RID: 97313 RVA: 0x0036D77E File Offset: 0x0036B97E
		public static void AddVarsType(FlatBufferBuilder builder, VectorOffset varsTypeOffset)
		{
			builder.AddOffset(1, varsTypeOffset.Value, 0);
		}

		// Token: 0x06017C22 RID: 97314 RVA: 0x0036D790 File Offset: 0x0036B990
		public static VectorOffset CreateVarsTypeVector(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017C23 RID: 97315 RVA: 0x0036D7C7 File Offset: 0x0036B9C7
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C24 RID: 97316 RVA: 0x0036D7E1 File Offset: 0x0036B9E1
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVarRef> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C25 RID: 97317 RVA: 0x0036D7FF File Offset: 0x0036B9FF
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVarRef>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017C26 RID: 97318 RVA: 0x0036D818 File Offset: 0x0036BA18
		public static void StartVarsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06017C27 RID: 97319 RVA: 0x0036D823 File Offset: 0x0036BA23
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x06017C28 RID: 97320 RVA: 0x0036D834 File Offset: 0x0036BA34
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017C29 RID: 97321 RVA: 0x0036D86B File Offset: 0x0036BA6B
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C2A RID: 97322 RVA: 0x0036D885 File Offset: 0x0036BA85
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C2B RID: 97323 RVA: 0x0036D8A3 File Offset: 0x0036BAA3
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017C2C RID: 97324 RVA: 0x0036D8BC File Offset: 0x0036BABC
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017C2D RID: 97325 RVA: 0x0036D8C7 File Offset: 0x0036BAC7
		public static void AddShowAsWordArt(FlatBufferBuilder builder, Offset<IWordArtConfig> showAsWordArtOffset)
		{
			builder.AddOffset(3, showAsWordArtOffset.Value, 0);
		}

		// Token: 0x06017C2E RID: 97326 RVA: 0x0036D8D7 File Offset: 0x0036BAD7
		public static Offset<IQuestScheduleMultiBtTreeVar> EndIQuestScheduleMultiBtTreeVar(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleMultiBtTreeVar>(builder.EndTable());
		}

		// Token: 0x06017C2F RID: 97327 RVA: 0x0036D8E4 File Offset: 0x0036BAE4
		public IQuestScheduleMultiBtTreeVarT UnPack()
		{
			IQuestScheduleMultiBtTreeVarT questScheduleMultiBtTreeVarT = new IQuestScheduleMultiBtTreeVarT();
			this.UnPackTo(questScheduleMultiBtTreeVarT);
			return questScheduleMultiBtTreeVarT;
		}

		// Token: 0x06017C30 RID: 97328 RVA: 0x0036D900 File Offset: 0x0036BB00
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

		// Token: 0x06017C31 RID: 97329 RVA: 0x0036DAC8 File Offset: 0x0036BCC8
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

		// Token: 0x0400BB59 RID: 47961
		private Table __p;
	}
}
