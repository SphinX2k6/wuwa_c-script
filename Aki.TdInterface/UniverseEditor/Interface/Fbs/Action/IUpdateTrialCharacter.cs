using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CE0 RID: 31968
	public struct IUpdateTrialCharacter : IFlatbufferObject
	{
		// Token: 0x1700EF38 RID: 61240
		// (get) Token: 0x06039A9D RID: 236189 RVA: 0x007C7619 File Offset: 0x007C5819
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039A9E RID: 236190 RVA: 0x007C7626 File Offset: 0x007C5826
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039A9F RID: 236191 RVA: 0x007C7630 File Offset: 0x007C5830
		public static IUpdateTrialCharacter GetRootAsIUpdateTrialCharacter(ByteBuffer _bb)
		{
			return IUpdateTrialCharacter.GetRootAsIUpdateTrialCharacter(_bb, default(IUpdateTrialCharacter));
		}

		// Token: 0x06039AA0 RID: 236192 RVA: 0x007C764C File Offset: 0x007C584C
		public static IUpdateTrialCharacter GetRootAsIUpdateTrialCharacter(ByteBuffer _bb, IUpdateTrialCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039AA1 RID: 236193 RVA: 0x007C7669 File Offset: 0x007C5869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039AA2 RID: 236194 RVA: 0x007C7678 File Offset: 0x007C5878
		public IUpdateTrialCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06039AA3 RID: 236195 RVA: 0x007C7688 File Offset: 0x007C5888
		public ICharacterGroupNew? CharacterGroupNew(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ICharacterGroupNew?(default(ICharacterGroupNew).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EF39 RID: 61241
		// (get) Token: 0x06039AA4 RID: 236196 RVA: 0x007C76E8 File Offset: 0x007C58E8
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

		// Token: 0x1700EF3A RID: 61242
		// (get) Token: 0x06039AA5 RID: 236197 RVA: 0x007C7714 File Offset: 0x007C5914
		public bool AutoChange
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EF3B RID: 61243
		// (get) Token: 0x06039AA6 RID: 236198 RVA: 0x007C7754 File Offset: 0x007C5954
		public bool CreateTempTeam
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EF3C RID: 61244
		// (get) Token: 0x06039AA7 RID: 236199 RVA: 0x007C7794 File Offset: 0x007C5994
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

		// Token: 0x06039AA8 RID: 236200 RVA: 0x007C77F4 File Offset: 0x007C59F4
		public int EnterRangeEntities(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700EF3D RID: 61245
		// (get) Token: 0x06039AA9 RID: 236201 RVA: 0x007C7834 File Offset: 0x007C5A34
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

		// Token: 0x06039AAA RID: 236202 RVA: 0x007C7860 File Offset: 0x007C5A60
		public Span<int> GetEnterRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06039AAB RID: 236203 RVA: 0x007C7870 File Offset: 0x007C5A70
		public int[] GetEnterRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x1700EF3E RID: 61246
		// (get) Token: 0x06039AAC RID: 236204 RVA: 0x007C7880 File Offset: 0x007C5A80
		public bool EnableMapAndTeleport
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06039AAD RID: 236205 RVA: 0x007C78C0 File Offset: 0x007C5AC0
		public int DungeonList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700EF3F RID: 61247
		// (get) Token: 0x06039AAE RID: 236206 RVA: 0x007C7900 File Offset: 0x007C5B00
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

		// Token: 0x06039AAF RID: 236207 RVA: 0x007C792C File Offset: 0x007C5B2C
		public Span<int> GetDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06039AB0 RID: 236208 RVA: 0x007C793C File Offset: 0x007C5B3C
		public int[] GetDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x1700EF40 RID: 61248
		// (get) Token: 0x06039AB1 RID: 236209 RVA: 0x007C794C File Offset: 0x007C5B4C
		public bool IsRemoveTips
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EF41 RID: 61249
		// (get) Token: 0x06039AB2 RID: 236210 RVA: 0x007C798C File Offset: 0x007C5B8C
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

		// Token: 0x06039AB3 RID: 236211 RVA: 0x007C79CC File Offset: 0x007C5BCC
		public TTable? IsDisableRollBackRestoreCharacter<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039AB4 RID: 236212 RVA: 0x007C7A14 File Offset: 0x007C5C14
		public IConstVarRef IsDisableRollBackRestoreCharacterAsIConstVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IConstVarRef>().Value;
		}

		// Token: 0x06039AB5 RID: 236213 RVA: 0x007C7A30 File Offset: 0x007C5C30
		public IGlobalVarRef IsDisableRollBackRestoreCharacterAsIGlobalVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IGlobalVarRef>().Value;
		}

		// Token: 0x06039AB6 RID: 236214 RVA: 0x007C7A4C File Offset: 0x007C5C4C
		public IOtherVarRef IsDisableRollBackRestoreCharacterAsIOtherVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<IOtherVarRef>().Value;
		}

		// Token: 0x06039AB7 RID: 236215 RVA: 0x007C7A68 File Offset: 0x007C5C68
		public ISelfVarRef IsDisableRollBackRestoreCharacterAsISelfVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<ISelfVarRef>().Value;
		}

		// Token: 0x06039AB8 RID: 236216 RVA: 0x007C7A84 File Offset: 0x007C5C84
		public ISystemVarRef IsDisableRollBackRestoreCharacterAsISystemVarRef()
		{
			return this.IsDisableRollBackRestoreCharacter<ISystemVarRef>().Value;
		}

		// Token: 0x1700EF42 RID: 61250
		// (get) Token: 0x06039AB9 RID: 236217 RVA: 0x007C7AA0 File Offset: 0x007C5CA0
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

		// Token: 0x06039ABA RID: 236218 RVA: 0x007C7AE0 File Offset: 0x007C5CE0
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

		// Token: 0x06039ABB RID: 236219 RVA: 0x007C7B50 File Offset: 0x007C5D50
		public static void StartIUpdateTrialCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06039ABC RID: 236220 RVA: 0x007C7B5A File Offset: 0x007C5D5A
		public static void AddCharacterGroupNew(FlatBufferBuilder builder, VectorOffset characterGroupNewOffset)
		{
			builder.AddOffset(0, characterGroupNewOffset.Value, 0);
		}

		// Token: 0x06039ABD RID: 236221 RVA: 0x007C7B6C File Offset: 0x007C5D6C
		public static VectorOffset CreateCharacterGroupNewVector(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06039ABE RID: 236222 RVA: 0x007C7BAC File Offset: 0x007C5DAC
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x06039ABF RID: 236223 RVA: 0x007C7BC6 File Offset: 0x007C5DC6
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICharacterGroupNew>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x06039AC0 RID: 236224 RVA: 0x007C7BE4 File Offset: 0x007C5DE4
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICharacterGroupNew>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06039AC1 RID: 236225 RVA: 0x007C7BFD File Offset: 0x007C5DFD
		public static void StartCharacterGroupNewVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06039AC2 RID: 236226 RVA: 0x007C7C08 File Offset: 0x007C5E08
		public static void AddAutoChange(FlatBufferBuilder builder, bool autoChange)
		{
			builder.AddBool(1, autoChange, false);
		}

		// Token: 0x06039AC3 RID: 236227 RVA: 0x007C7C13 File Offset: 0x007C5E13
		public static void AddCreateTempTeam(FlatBufferBuilder builder, bool createTempTeam)
		{
			builder.AddBool(2, createTempTeam, false);
		}

		// Token: 0x06039AC4 RID: 236228 RVA: 0x007C7C1E File Offset: 0x007C5E1E
		public static void AddActiveRange(FlatBufferBuilder builder, Offset<IActiveRange> activeRangeOffset)
		{
			builder.AddOffset(3, activeRangeOffset.Value, 0);
		}

		// Token: 0x06039AC5 RID: 236229 RVA: 0x007C7C2E File Offset: 0x007C5E2E
		public static void AddEnterRangeEntities(FlatBufferBuilder builder, VectorOffset enterRangeEntitiesOffset)
		{
			builder.AddOffset(4, enterRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06039AC6 RID: 236230 RVA: 0x007C7C40 File Offset: 0x007C5E40
		public static VectorOffset CreateEnterRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06039AC7 RID: 236231 RVA: 0x007C7C77 File Offset: 0x007C5E77
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06039AC8 RID: 236232 RVA: 0x007C7C91 File Offset: 0x007C5E91
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06039AC9 RID: 236233 RVA: 0x007C7CAF File Offset: 0x007C5EAF
		public static VectorOffset CreateEnterRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06039ACA RID: 236234 RVA: 0x007C7CC8 File Offset: 0x007C5EC8
		public static void StartEnterRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06039ACB RID: 236235 RVA: 0x007C7CD3 File Offset: 0x007C5ED3
		public static void AddEnableMapAndTeleport(FlatBufferBuilder builder, bool enableMapAndTeleport)
		{
			builder.AddBool(5, enableMapAndTeleport, false);
		}

		// Token: 0x06039ACC RID: 236236 RVA: 0x007C7CDE File Offset: 0x007C5EDE
		public static void AddDungeonList(FlatBufferBuilder builder, VectorOffset dungeonListOffset)
		{
			builder.AddOffset(6, dungeonListOffset.Value, 0);
		}

		// Token: 0x06039ACD RID: 236237 RVA: 0x007C7CF0 File Offset: 0x007C5EF0
		public static VectorOffset CreateDungeonListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06039ACE RID: 236238 RVA: 0x007C7D27 File Offset: 0x007C5F27
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06039ACF RID: 236239 RVA: 0x007C7D41 File Offset: 0x007C5F41
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06039AD0 RID: 236240 RVA: 0x007C7D5F File Offset: 0x007C5F5F
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06039AD1 RID: 236241 RVA: 0x007C7D78 File Offset: 0x007C5F78
		public static void StartDungeonListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06039AD2 RID: 236242 RVA: 0x007C7D83 File Offset: 0x007C5F83
		public static void AddIsRemoveTips(FlatBufferBuilder builder, bool isRemoveTips)
		{
			builder.AddBool(7, isRemoveTips, false);
		}

		// Token: 0x06039AD3 RID: 236243 RVA: 0x007C7D8E File Offset: 0x007C5F8E
		public static void AddIsDisableRollBackRestoreCharacterType(FlatBufferBuilder builder, TVarRef isDisableRollBackRestoreCharacterType)
		{
			builder.AddByte(8, (byte)isDisableRollBackRestoreCharacterType, 0);
		}

		// Token: 0x06039AD4 RID: 236244 RVA: 0x007C7D99 File Offset: 0x007C5F99
		public static void AddIsDisableRollBackRestoreCharacter(FlatBufferBuilder builder, int isDisableRollBackRestoreCharacterOffset)
		{
			builder.AddOffset(9, isDisableRollBackRestoreCharacterOffset, 0);
		}

		// Token: 0x06039AD5 RID: 236245 RVA: 0x007C7DA5 File Offset: 0x007C5FA5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06039AD6 RID: 236246 RVA: 0x007C7DB1 File Offset: 0x007C5FB1
		public static Offset<IUpdateTrialCharacter> EndIUpdateTrialCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IUpdateTrialCharacter>(builder.EndTable());
		}

		// Token: 0x06039AD7 RID: 236247 RVA: 0x007C7DC0 File Offset: 0x007C5FC0
		public IUpdateTrialCharacterT UnPack()
		{
			IUpdateTrialCharacterT updateTrialCharacterT = new IUpdateTrialCharacterT();
			this.UnPackTo(updateTrialCharacterT);
			return updateTrialCharacterT;
		}

		// Token: 0x06039AD8 RID: 236248 RVA: 0x007C7DDC File Offset: 0x007C5FDC
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

		// Token: 0x06039AD9 RID: 236249 RVA: 0x007C8074 File Offset: 0x007C6274
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

		// Token: 0x040133E7 RID: 78823
		private Table __p;
	}
}
