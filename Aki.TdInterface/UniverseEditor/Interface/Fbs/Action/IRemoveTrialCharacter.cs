using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F1 RID: 30193
	public struct IRemoveTrialCharacter : IFlatbufferObject
	{
		// Token: 0x1700DDE3 RID: 56803
		// (get) Token: 0x06034F86 RID: 216966 RVA: 0x0071DD2D File Offset: 0x0071BF2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034F87 RID: 216967 RVA: 0x0071DD3A File Offset: 0x0071BF3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034F88 RID: 216968 RVA: 0x0071DD44 File Offset: 0x0071BF44
		public static IRemoveTrialCharacter GetRootAsIRemoveTrialCharacter(ByteBuffer _bb)
		{
			return IRemoveTrialCharacter.GetRootAsIRemoveTrialCharacter(_bb, default(IRemoveTrialCharacter));
		}

		// Token: 0x06034F89 RID: 216969 RVA: 0x0071DD60 File Offset: 0x0071BF60
		public static IRemoveTrialCharacter GetRootAsIRemoveTrialCharacter(ByteBuffer _bb, IRemoveTrialCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034F8A RID: 216970 RVA: 0x0071DD7D File Offset: 0x0071BF7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034F8B RID: 216971 RVA: 0x0071DD8C File Offset: 0x0071BF8C
		public IRemoveTrialCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDE4 RID: 56804
		// (get) Token: 0x06034F8C RID: 216972 RVA: 0x0071DD9C File Offset: 0x0071BF9C
		public int CharacterId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034F8D RID: 216973 RVA: 0x0071DDD8 File Offset: 0x0071BFD8
		public int CharacterGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DDE5 RID: 56805
		// (get) Token: 0x06034F8E RID: 216974 RVA: 0x0071DE18 File Offset: 0x0071C018
		public int CharacterGroupLength
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

		// Token: 0x06034F8F RID: 216975 RVA: 0x0071DE43 File Offset: 0x0071C043
		public Span<int> GetCharacterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06034F90 RID: 216976 RVA: 0x0071DE52 File Offset: 0x0071C052
		public int[] GetCharacterGroupArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700DDE6 RID: 56806
		// (get) Token: 0x06034F91 RID: 216977 RVA: 0x0071DE60 File Offset: 0x0071C060
		public bool IsRemoveTips
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DDE7 RID: 56807
		// (get) Token: 0x06034F92 RID: 216978 RVA: 0x0071DEA0 File Offset: 0x0071C0A0
		public bool EnableSeamlessTeamSwitch
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DDE8 RID: 56808
		// (get) Token: 0x06034F93 RID: 216979 RVA: 0x0071DEE0 File Offset: 0x0071C0E0
		public bool OnlyLowMemoryDeviceExecute
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DDE9 RID: 56809
		// (get) Token: 0x06034F94 RID: 216980 RVA: 0x0071DF20 File Offset: 0x0071C120
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034F95 RID: 216981 RVA: 0x0071DF5D File Offset: 0x0071C15D
		public static Offset<IRemoveTrialCharacter> CreateIRemoveTrialCharacter(FlatBufferBuilder builder, int CharacterId = 0, VectorOffset CharacterGroupOffset = default(VectorOffset), bool IsRemoveTips = false, bool EnableSeamlessTeamSwitch = false, bool OnlyLowMemoryDeviceExecute = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IRemoveTrialCharacter.AddCharacterGroup(builder, CharacterGroupOffset);
			IRemoveTrialCharacter.AddCharacterId(builder, CharacterId);
			IRemoveTrialCharacter.AddNullMask(builder, NullMask);
			IRemoveTrialCharacter.AddOnlyLowMemoryDeviceExecute(builder, OnlyLowMemoryDeviceExecute);
			IRemoveTrialCharacter.AddEnableSeamlessTeamSwitch(builder, EnableSeamlessTeamSwitch);
			IRemoveTrialCharacter.AddIsRemoveTips(builder, IsRemoveTips);
			return IRemoveTrialCharacter.EndIRemoveTrialCharacter(builder);
		}

		// Token: 0x06034F96 RID: 216982 RVA: 0x0071DF99 File Offset: 0x0071C199
		public static void StartIRemoveTrialCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06034F97 RID: 216983 RVA: 0x0071DFA2 File Offset: 0x0071C1A2
		public static void AddCharacterId(FlatBufferBuilder builder, int characterId)
		{
			builder.AddInt(0, characterId, 0);
		}

		// Token: 0x06034F98 RID: 216984 RVA: 0x0071DFAD File Offset: 0x0071C1AD
		public static void AddCharacterGroup(FlatBufferBuilder builder, VectorOffset characterGroupOffset)
		{
			builder.AddOffset(1, characterGroupOffset.Value, 0);
		}

		// Token: 0x06034F99 RID: 216985 RVA: 0x0071DFC0 File Offset: 0x0071C1C0
		public static VectorOffset CreateCharacterGroupVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034F9A RID: 216986 RVA: 0x0071DFF7 File Offset: 0x0071C1F7
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034F9B RID: 216987 RVA: 0x0071E011 File Offset: 0x0071C211
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034F9C RID: 216988 RVA: 0x0071E02F File Offset: 0x0071C22F
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034F9D RID: 216989 RVA: 0x0071E048 File Offset: 0x0071C248
		public static void StartCharacterGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034F9E RID: 216990 RVA: 0x0071E053 File Offset: 0x0071C253
		public static void AddIsRemoveTips(FlatBufferBuilder builder, bool isRemoveTips)
		{
			builder.AddBool(2, isRemoveTips, false);
		}

		// Token: 0x06034F9F RID: 216991 RVA: 0x0071E05E File Offset: 0x0071C25E
		public static void AddEnableSeamlessTeamSwitch(FlatBufferBuilder builder, bool enableSeamlessTeamSwitch)
		{
			builder.AddBool(3, enableSeamlessTeamSwitch, false);
		}

		// Token: 0x06034FA0 RID: 216992 RVA: 0x0071E069 File Offset: 0x0071C269
		public static void AddOnlyLowMemoryDeviceExecute(FlatBufferBuilder builder, bool onlyLowMemoryDeviceExecute)
		{
			builder.AddBool(4, onlyLowMemoryDeviceExecute, false);
		}

		// Token: 0x06034FA1 RID: 216993 RVA: 0x0071E074 File Offset: 0x0071C274
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06034FA2 RID: 216994 RVA: 0x0071E07F File Offset: 0x0071C27F
		public static Offset<IRemoveTrialCharacter> EndIRemoveTrialCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveTrialCharacter>(builder.EndTable());
		}

		// Token: 0x06034FA3 RID: 216995 RVA: 0x0071E08C File Offset: 0x0071C28C
		public IRemoveTrialCharacterT UnPack()
		{
			IRemoveTrialCharacterT removeTrialCharacterT = new IRemoveTrialCharacterT();
			this.UnPackTo(removeTrialCharacterT);
			return removeTrialCharacterT;
		}

		// Token: 0x06034FA4 RID: 216996 RVA: 0x0071E0A8 File Offset: 0x0071C2A8
		public void UnPackTo(IRemoveTrialCharacterT _o)
		{
			_o.CharacterId = this.CharacterId;
			_o.CharacterGroup = new List<int>();
			for (int i = 0; i < this.CharacterGroupLength; i++)
			{
				_o.CharacterGroup.Add(this.CharacterGroup(i));
			}
			_o.IsRemoveTips = this.IsRemoveTips;
			_o.EnableSeamlessTeamSwitch = this.EnableSeamlessTeamSwitch;
			_o.OnlyLowMemoryDeviceExecute = this.OnlyLowMemoryDeviceExecute;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034FA5 RID: 216997 RVA: 0x0071E120 File Offset: 0x0071C320
		public static Offset<IRemoveTrialCharacter> Pack(FlatBufferBuilder builder, IRemoveTrialCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveTrialCharacter>);
			}
			VectorOffset characterGroupOffset = default(VectorOffset);
			if (_o.CharacterGroup != null)
			{
				int[] data = _o.CharacterGroup.ToArray();
				characterGroupOffset = IRemoveTrialCharacter.CreateCharacterGroupVector(builder, data);
			}
			return IRemoveTrialCharacter.CreateIRemoveTrialCharacter(builder, _o.CharacterId, characterGroupOffset, _o.IsRemoveTips, _o.EnableSeamlessTeamSwitch, _o.OnlyLowMemoryDeviceExecute, _o.NullMask);
		}

		// Token: 0x040127DC RID: 75740
		private Table __p;
	}
}
