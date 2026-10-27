using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074EA RID: 29930
	public struct IUpdateTrialCharacter : IFlatbufferObject
	{
		// Token: 0x1700E30E RID: 58126
		// (get) Token: 0x06036688 RID: 222856 RVA: 0x007643C9 File Offset: 0x007625C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036689 RID: 222857 RVA: 0x007643D6 File Offset: 0x007625D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603668A RID: 222858 RVA: 0x007643E0 File Offset: 0x007625E0
		public static IUpdateTrialCharacter GetRootAsIUpdateTrialCharacter(ByteBuffer _bb)
		{
			return IUpdateTrialCharacter.GetRootAsIUpdateTrialCharacter(_bb, default(IUpdateTrialCharacter));
		}

		// Token: 0x0603668B RID: 222859 RVA: 0x007643FC File Offset: 0x007625FC
		public static IUpdateTrialCharacter GetRootAsIUpdateTrialCharacter(ByteBuffer _bb, IUpdateTrialCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603668C RID: 222860 RVA: 0x00764419 File Offset: 0x00762619
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603668D RID: 222861 RVA: 0x00764428 File Offset: 0x00762628
		public IUpdateTrialCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603668E RID: 222862 RVA: 0x00764438 File Offset: 0x00762638
		public ICharacterGroupNew? CharacterGroupNew(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ICharacterGroupNew?(default(ICharacterGroupNew).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E30F RID: 58127
		// (get) Token: 0x0603668F RID: 222863 RVA: 0x00764498 File Offset: 0x00762698
		public int CharacterGroupNewLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700E310 RID: 58128
		// (get) Token: 0x06036690 RID: 222864 RVA: 0x007644C4 File Offset: 0x007626C4
		public bool AutoChange
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E311 RID: 58129
		// (get) Token: 0x06036691 RID: 222865 RVA: 0x00764504 File Offset: 0x00762704
		public bool CreateTempTeam
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E312 RID: 58130
		// (get) Token: 0x06036692 RID: 222866 RVA: 0x00764544 File Offset: 0x00762744
		public IActiveRange? ActiveRange
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IActiveRange?(default(IActiveRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06036693 RID: 222867 RVA: 0x007645A4 File Offset: 0x007627A4
		public int EnterRangeEntities(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E313 RID: 58131
		// (get) Token: 0x06036694 RID: 222868 RVA: 0x007645E4 File Offset: 0x007627E4
		public int EnterRangeEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06036695 RID: 222869 RVA: 0x00764610 File Offset: 0x00762810
		public Span<int> GetEnterRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06036696 RID: 222870 RVA: 0x00764620 File Offset: 0x00762820
		public int[] GetEnterRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x1700E314 RID: 58132
		// (get) Token: 0x06036697 RID: 222871 RVA: 0x00764630 File Offset: 0x00762830
		public bool EnableMapAndTeleport
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06036698 RID: 222872 RVA: 0x00764670 File Offset: 0x00762870
		public int DungeonList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E315 RID: 58133
		// (get) Token: 0x06036699 RID: 222873 RVA: 0x007646B0 File Offset: 0x007628B0
		public int DungeonListLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0603669A RID: 222874 RVA: 0x007646DC File Offset: 0x007628DC
		public Span<int> GetDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0603669B RID: 222875 RVA: 0x007646EC File Offset: 0x007628EC
		public int[] GetDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x1700E316 RID: 58134
		// (get) Token: 0x0603669C RID: 222876 RVA: 0x007646FC File Offset: 0x007628FC
		public bool IsRemoveTips
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E317 RID: 58135
		// (get) Token: 0x0603669D RID: 222877 RVA: 0x0076473C File Offset: 0x0076293C
		public TVarRef IsDisableRollBackRestoreCharacterType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603669E RID: 222878 RVA: 0x0076477C File Offset: 0x0076297C
		public TTable? IsDisableRollBackRestoreCharacter<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603669F RID: 222879 RVA: 0x007647C4 File Offset: 0x007629C4
		public IConstVarRef IsDisableRollBackRestoreCharacterAsIConstVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IConstVarRef>().Value;
		}

		// Token: 0x060366A0 RID: 222880 RVA: 0x007647E0 File Offset: 0x007629E0
		public IGlobalVarRef IsDisableRollBackRestoreCharacterAsIGlobalVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IGlobalVarRef>().Value;
		}

		// Token: 0x060366A1 RID: 222881 RVA: 0x007647FC File Offset: 0x007629FC
		public IOtherVarRef IsDisableRollBackRestoreCharacterAsIOtherVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IOtherVarRef>().Value;
		}

		// Token: 0x060366A2 RID: 222882 RVA: 0x00764818 File Offset: 0x00762A18
		public ISelfVarRef IsDisableRollBackRestoreCharacterAsISelfVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<ISelfVarRef>().Value;
		}

		// Token: 0x060366A3 RID: 222883 RVA: 0x00764834 File Offset: 0x00762A34
		public ISystemVarRef IsDisableRollBackRestoreCharacterAsISystemVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<ISystemVarRef>().Value;
		}

		// Token: 0x1700E318 RID: 58136
		// (get) Token: 0x060366A4 RID: 222884 RVA: 0x00764850 File Offset: 0x00762A50
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060366A5 RID: 222885 RVA: 0x00764890 File Offset: 0x00762A90
		public static Offset<IUpdateTrialCharacter> CreateIUpdateTrialCharacter(FlatBufferBuilder builder, VectorOffset CharacterGroupNewOffset = default(VectorOffset), bool AutoChange = false, bool CreateTempTeam = false, Offset<IActiveRange> ActiveRangeOffset = default(Offset<IActiveRange>), VectorOffset EnterRangeEntitiesOffset = default(VectorOffset), bool EnableMapAndTeleport = false, VectorOffset DungeonListOffset = default(VectorOffset), bool IsRemoveTips = false, TVarRef IsDisableRollBackRestoreCharacter_type = TVarRef.NONE, int IsDisableRollBackRestoreCharacterOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(11);
			IUpdateTrialCharacter.AddIsDisableRollBackRestoreCharacter(builder, IsDisableRollBackRestoreCharacterOffset);
			IUpdateTrialCharacter.AddDungeonList(builder, DungeonListOffset);
			IUpdateTrialCharacter.AddEnterRangeEntities(builder, EnterRangeEntitiesOffset);
			IUpdateTrialCharacter.AddActiveRange(builder, ActiveRangeOffset);
			IUpdateTrialCharacter.AddCharacterGroupNew(builder, CharacterGroupNewOffset);
			IUpdateTrialCharacter.AddNullMask(builder, NullMask);
			IUpdateTrialCharacter.AddIsDisableRollBackRestoreCharacterType(builder, IsDisableRollBackRestoreCharacter_type);
			IUpdateTrialCharacter.AddIsRemoveTips(builder, IsRemoveTips);
			IUpdateTrialCharacter.AddEnableMapAndTeleport(builder, EnableMapAndTeleport);
			IUpdateTrialCharacter.AddCreateTempTeam(builder, CreateTempTeam);
			IUpdateTrialCharacter.AddAutoChange(builder, AutoChange);
			return IUpdateTrialCharacter.EndIUpdateTrialCharacter(builder);
		}

		// Token: 0x060366A6 RID: 222886 RVA: 0x00764900 File Offset: 0x00762B00
		public static void StartIUpdateTrialCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x060366A7 RID: 222887 RVA: 0x0076490A File Offset: 0x00762B0A
		public static void AddCharacterGroupNew(FlatBufferBuilder builder, VectorOffset characterGroupNewOffset)
		{
			builder.AddOffset(0, characterGroupNewOffset.Value, 0);
		}

		// Token: 0x060366A8 RID: 222888 RVA: 0x0076491C File Offset: 0x00762B1C
		public static VectorOffset CreateCharacterGroupNewVector(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060366A9 RID: 222889 RVA: 0x0076495C File Offset: 0x00762B5C
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x060366AA RID: 222890 RVA: 0x00764976 File Offset: 0x00762B76
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICharacterGroupNew>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x060366AB RID: 222891 RVA: 0x00764994 File Offset: 0x00762B94
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICharacterGroupNew>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060366AC RID: 222892 RVA: 0x007649AD File Offset: 0x00762BAD
		public static void StartCharacterGroupNewVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060366AD RID: 222893 RVA: 0x007649B8 File Offset: 0x00762BB8
		public static void AddAutoChange(FlatBufferBuilder builder, bool autoChange)
		{
			builder.AddBool(1, autoChange, false);
		}

		// Token: 0x060366AE RID: 222894 RVA: 0x007649C3 File Offset: 0x00762BC3
		public static void AddCreateTempTeam(FlatBufferBuilder builder, bool createTempTeam)
		{
			builder.AddBool(2, createTempTeam, false);
		}

		// Token: 0x060366AF RID: 222895 RVA: 0x007649CE File Offset: 0x00762BCE
		public static void AddActiveRange(FlatBufferBuilder builder, Offset<IActiveRange> activeRangeOffset)
		{
			builder.AddOffset(3, activeRangeOffset.Value, 0);
		}

		// Token: 0x060366B0 RID: 222896 RVA: 0x007649DE File Offset: 0x00762BDE
		public static void AddEnterRangeEntities(FlatBufferBuilder builder, VectorOffset enterRangeEntitiesOffset)
		{
			builder.AddOffset(4, enterRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x060366B1 RID: 222897 RVA: 0x007649F0 File Offset: 0x00762BF0
		public static VectorOffset CreateEnterRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060366B2 RID: 222898 RVA: 0x00764A27 File Offset: 0x00762C27
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060366B3 RID: 222899 RVA: 0x00764A41 File Offset: 0x00762C41
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060366B4 RID: 222900 RVA: 0x00764A5F File Offset: 0x00762C5F
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060366B5 RID: 222901 RVA: 0x00764A78 File Offset: 0x00762C78
		public static void StartEnterRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060366B6 RID: 222902 RVA: 0x00764A83 File Offset: 0x00762C83
		public static void AddEnableMapAndTeleport(FlatBufferBuilder builder, bool enableMapAndTeleport)
		{
			builder.AddBool(5, enableMapAndTeleport, false);
		}

		// Token: 0x060366B7 RID: 222903 RVA: 0x00764A8E File Offset: 0x00762C8E
		public static void AddDungeonList(FlatBufferBuilder builder, VectorOffset dungeonListOffset)
		{
			builder.AddOffset(6, dungeonListOffset.Value, 0);
		}

		// Token: 0x060366B8 RID: 222904 RVA: 0x00764AA0 File Offset: 0x00762CA0
		public static VectorOffset CreateDungeonListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060366B9 RID: 222905 RVA: 0x00764AD7 File Offset: 0x00762CD7
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060366BA RID: 222906 RVA: 0x00764AF1 File Offset: 0x00762CF1
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060366BB RID: 222907 RVA: 0x00764B0F File Offset: 0x00762D0F
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060366BC RID: 222908 RVA: 0x00764B28 File Offset: 0x00762D28
		public static void StartDungeonListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060366BD RID: 222909 RVA: 0x00764B33 File Offset: 0x00762D33
		public static void AddIsRemoveTips(FlatBufferBuilder builder, bool isRemoveTips)
		{
			builder.AddBool(7, isRemoveTips, false);
		}

		// Token: 0x060366BE RID: 222910 RVA: 0x00764B3E File Offset: 0x00762D3E
		public static void AddIsDisableRollBackRestoreCharacterType(FlatBufferBuilder builder, TVarRef isDisableRollBackRestoreCharacterType)
		{
			builder.AddByte(8, (byte)isDisableRollBackRestoreCharacterType, 0);
		}

		// Token: 0x060366BF RID: 222911 RVA: 0x00764B49 File Offset: 0x00762D49
		public static void AddIsDisableRollBackRestoreCharacter(FlatBufferBuilder builder, int isDisableRollBackRestoreCharacterOffset)
		{
			builder.AddOffset(9, isDisableRollBackRestoreCharacterOffset, 0);
		}

		// Token: 0x060366C0 RID: 222912 RVA: 0x00764B55 File Offset: 0x00762D55
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x060366C1 RID: 222913 RVA: 0x00764B61 File Offset: 0x00762D61
		public static Offset<IUpdateTrialCharacter> EndIUpdateTrialCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IUpdateTrialCharacter>(builder.EndTable());
		}

		// Token: 0x060366C2 RID: 222914 RVA: 0x00764B70 File Offset: 0x00762D70
		public IUpdateTrialCharacterT UnPack()
		{
			IUpdateTrialCharacterT updateTrialCharacterT = new IUpdateTrialCharacterT();
			this.UnPackTo(updateTrialCharacterT);
			return updateTrialCharacterT;
		}

		// Token: 0x060366C3 RID: 222915 RVA: 0x00764B8C File Offset: 0x00762D8C
		public void UnPackTo(IUpdateTrialCharacterT _o)
		{
			_o.CharacterGroupNew = new List<ICharacterGroupNewT>();
			for (int i = 0; i < this.CharacterGroupNewLength; i++)
			{
				_o.CharacterGroupNew.Add((this.CharacterGroupNew(i) != null) ? this.CharacterGroupNew(i).Value.UnPack() : null);
			}
			_o.AutoChange = this.AutoChange;
			_o.CreateTempTeam = this.CreateTempTeam;
			_o.ActiveRange = ((this.ActiveRange != null) ? this.ActiveRange.Value.UnPack() : null);
			_o.EnterRangeEntities = new List<int>();
			for (int j = 0; j < this.EnterRangeEntitiesLength; j++)
			{
				_o.EnterRangeEntities.Add(this.EnterRangeEntities(j));
			}
			_o.EnableMapAndTeleport = this.EnableMapAndTeleport;
			_o.DungeonList = new List<int>();
			for (int k = 0; k < this.DungeonListLength; k++)
			{
				_o.DungeonList.Add(this.DungeonList(k));
			}
			_o.IsRemoveTips = this.IsRemoveTips;
			_o.IsDisableRollBackRestoreCharacter = new TVarRefUnion();
			_o.IsDisableRollBackRestoreCharacter.Type = this.IsDisableRollBackRestoreCharacterType;
			switch (this.IsDisableRollBackRestoreCharacterType)
			{
			case TVarRef.IConstVarRef:
				_o.IsDisableRollBackRestoreCharacter.Value = ((this.IsDisableRollBackRestoreCharacter<IConstVarRef>() != null) ? this.IsDisableRollBackRestoreCharacter<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.IsDisableRollBackRestoreCharacter.Value = ((this.IsDisableRollBackRestoreCharacter<IGlobalVarRef>() != null) ? this.IsDisableRollBackRestoreCharacter<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.IsDisableRollBackRestoreCharacter.Value = ((this.IsDisableRollBackRestoreCharacter<IOtherVarRef>() != null) ? this.IsDisableRollBackRestoreCharacter<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.IsDisableRollBackRestoreCharacter.Value = ((this.IsDisableRollBackRestoreCharacter<ISelfVarRef>() != null) ? this.IsDisableRollBackRestoreCharacter<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.IsDisableRollBackRestoreCharacter.Value = ((this.IsDisableRollBackRestoreCharacter<ISystemVarRef>() != null) ? this.IsDisableRollBackRestoreCharacter<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060366C4 RID: 222916 RVA: 0x00764E24 File Offset: 0x00763024
		public static Offset<IUpdateTrialCharacter> Pack(FlatBufferBuilder builder, IUpdateTrialCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUpdateTrialCharacter>);
			}
			VectorOffset characterGroupNewOffset = default(VectorOffset);
			if (_o.CharacterGroupNew != null)
			{
				Offset<ICharacterGroupNew>[] array = new Offset<ICharacterGroupNew>[_o.CharacterGroupNew.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICharacterGroupNew.Pack(builder, _o.CharacterGroupNew[i]);
				}
				characterGroupNewOffset = IUpdateTrialCharacter.CreateCharacterGroupNewVector(builder, array);
			}
			Offset<IActiveRange> activeRangeOffset = (_o.ActiveRange == null) ? default(Offset<IActiveRange>) : IActiveRange.Pack(builder, _o.ActiveRange);
			VectorOffset enterRangeEntitiesOffset = default(VectorOffset);
			if (_o.EnterRangeEntities != null)
			{
				int[] data = _o.EnterRangeEntities.ToArray();
				enterRangeEntitiesOffset = IUpdateTrialCharacter.CreateEnterRangeEntitiesVector(builder, data);
			}
			VectorOffset dungeonListOffset = default(VectorOffset);
			if (_o.DungeonList != null)
			{
				int[] data2 = _o.DungeonList.ToArray();
				dungeonListOffset = IUpdateTrialCharacter.CreateDungeonListVector(builder, data2);
			}
			TVarRef isDisableRollBackRestoreCharacter_type = (_o.IsDisableRollBackRestoreCharacter == null) ? TVarRef.NONE : _o.IsDisableRollBackRestoreCharacter.Type;
			int isDisableRollBackRestoreCharacterOffset = (_o.IsDisableRollBackRestoreCharacter == null) ? 0 : TVarRefUnion.Pack(builder, _o.IsDisableRollBackRestoreCharacter);
			return IUpdateTrialCharacter.CreateIUpdateTrialCharacter(builder, characterGroupNewOffset, _o.AutoChange, _o.CreateTempTeam, activeRangeOffset, enterRangeEntitiesOffset, _o.EnableMapAndTeleport, dungeonListOffset, _o.IsRemoveTips, isDisableRollBackRestoreCharacter_type, isDisableRollBackRestoreCharacterOffset, _o.NullMask);
		}

		// Token: 0x040123B6 RID: 74678
		private Table __p;
	}
}
