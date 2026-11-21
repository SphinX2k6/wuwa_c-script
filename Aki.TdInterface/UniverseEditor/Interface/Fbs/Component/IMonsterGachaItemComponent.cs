using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B19 RID: 23321
	public struct IMonsterGachaItemComponent : IFlatbufferObject
	{
		// Token: 0x1700AA40 RID: 43584
		// (get) Token: 0x06026594 RID: 157076 RVA: 0x00540FF3 File Offset: 0x0053F1F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026595 RID: 157077 RVA: 0x00541000 File Offset: 0x0053F200
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026596 RID: 157078 RVA: 0x00541008 File Offset: 0x0053F208
		public static IMonsterGachaItemComponent GetRootAsIMonsterGachaItemComponent(ByteBuffer _bb)
		{
			return IMonsterGachaItemComponent.GetRootAsIMonsterGachaItemComponent(_bb, default(IMonsterGachaItemComponent));
		}

		// Token: 0x06026597 RID: 157079 RVA: 0x00541024 File Offset: 0x0053F224
		public static IMonsterGachaItemComponent GetRootAsIMonsterGachaItemComponent(ByteBuffer _bb, IMonsterGachaItemComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026598 RID: 157080 RVA: 0x00541041 File Offset: 0x0053F241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026599 RID: 157081 RVA: 0x00541050 File Offset: 0x0053F250
		public IMonsterGachaItemComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA41 RID: 43585
		// (get) Token: 0x0602659A RID: 157082 RVA: 0x00541060 File Offset: 0x0053F260
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AA42 RID: 43586
		// (get) Token: 0x0602659B RID: 157083 RVA: 0x005410A0 File Offset: 0x0053F2A0
		public string MaterialDataPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602659C RID: 157084 RVA: 0x005410D7 File Offset: 0x0053F2D7
		public Span<byte> GetMaterialDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602659D RID: 157085 RVA: 0x005410E6 File Offset: 0x0053F2E6
		public byte[] GetMaterialDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AA43 RID: 43587
		// (get) Token: 0x0602659E RID: 157086 RVA: 0x005410F4 File Offset: 0x0053F2F4
		public EMonsterMatchType MonsterType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EMonsterMatchType.Normal;
				}
				return (EMonsterMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602659F RID: 157087 RVA: 0x00541130 File Offset: 0x0053F330
		public int MonsterEntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AA44 RID: 43588
		// (get) Token: 0x060265A0 RID: 157088 RVA: 0x00541170 File Offset: 0x0053F370
		public int MonsterEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060265A1 RID: 157089 RVA: 0x0054119C File Offset: 0x0053F39C
		public Span<int> GetMonsterEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060265A2 RID: 157090 RVA: 0x005411AC File Offset: 0x0053F3AC
		public int[] GetMonsterEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700AA45 RID: 43589
		// (get) Token: 0x060265A3 RID: 157091 RVA: 0x005411BC File Offset: 0x0053F3BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060265A4 RID: 157092 RVA: 0x005411F9 File Offset: 0x0053F3F9
		public static Offset<IMonsterGachaItemComponent> CreateIMonsterGachaItemComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset MaterialDataPathOffset = default(StringOffset), EMonsterMatchType MonsterType = EMonsterMatchType.Normal, VectorOffset MonsterEntityIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IMonsterGachaItemComponent.AddMonsterEntityIds(builder, MonsterEntityIdsOffset);
			IMonsterGachaItemComponent.AddMaterialDataPath(builder, MaterialDataPathOffset);
			IMonsterGachaItemComponent.AddNullMask(builder, NullMask);
			IMonsterGachaItemComponent.AddMonsterType(builder, MonsterType);
			IMonsterGachaItemComponent.AddDisabled(builder, Disabled);
			return IMonsterGachaItemComponent.EndIMonsterGachaItemComponent(builder);
		}

		// Token: 0x060265A5 RID: 157093 RVA: 0x0054122D File Offset: 0x0053F42D
		public static void StartIMonsterGachaItemComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060265A6 RID: 157094 RVA: 0x00541236 File Offset: 0x0053F436
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060265A7 RID: 157095 RVA: 0x00541241 File Offset: 0x0053F441
		public static void AddMaterialDataPath(FlatBufferBuilder builder, StringOffset materialDataPathOffset)
		{
			builder.AddOffset(1, materialDataPathOffset.Value, 0);
		}

		// Token: 0x060265A8 RID: 157096 RVA: 0x00541251 File Offset: 0x0053F451
		public static void AddMonsterType(FlatBufferBuilder builder, EMonsterMatchType monsterType)
		{
			builder.AddByte(2, (byte)monsterType, 0);
		}

		// Token: 0x060265A9 RID: 157097 RVA: 0x0054125C File Offset: 0x0053F45C
		public static void AddMonsterEntityIds(FlatBufferBuilder builder, VectorOffset monsterEntityIdsOffset)
		{
			builder.AddOffset(3, monsterEntityIdsOffset.Value, 0);
		}

		// Token: 0x060265AA RID: 157098 RVA: 0x0054126C File Offset: 0x0053F46C
		public static VectorOffset CreateMonsterEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060265AB RID: 157099 RVA: 0x005412A3 File Offset: 0x0053F4A3
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060265AC RID: 157100 RVA: 0x005412BD File Offset: 0x0053F4BD
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060265AD RID: 157101 RVA: 0x005412DB File Offset: 0x0053F4DB
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060265AE RID: 157102 RVA: 0x005412F4 File Offset: 0x0053F4F4
		public static void StartMonsterEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060265AF RID: 157103 RVA: 0x005412FF File Offset: 0x0053F4FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060265B0 RID: 157104 RVA: 0x0054130A File Offset: 0x0053F50A
		public static Offset<IMonsterGachaItemComponent> EndIMonsterGachaItemComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterGachaItemComponent>(builder.EndTable());
		}

		// Token: 0x060265B1 RID: 157105 RVA: 0x00541318 File Offset: 0x0053F518
		public IMonsterGachaItemComponentT UnPack()
		{
			IMonsterGachaItemComponentT monsterGachaItemComponentT = new IMonsterGachaItemComponentT();
			this.UnPackTo(monsterGachaItemComponentT);
			return monsterGachaItemComponentT;
		}

		// Token: 0x060265B2 RID: 157106 RVA: 0x00541334 File Offset: 0x0053F534
		public void UnPackTo(IMonsterGachaItemComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MaterialDataPath = this.MaterialDataPath;
			_o.MonsterType = this.MonsterType;
			_o.MonsterEntityIds = new List<int>();
			for (int i = 0; i < this.MonsterEntityIdsLength; i++)
			{
				_o.MonsterEntityIds.Add(this.MonsterEntityIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060265B3 RID: 157107 RVA: 0x005413A0 File Offset: 0x0053F5A0
		public static Offset<IMonsterGachaItemComponent> Pack(FlatBufferBuilder builder, IMonsterGachaItemComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterGachaItemComponent>);
			}
			StringOffset materialDataPathOffset = (_o.MaterialDataPath == null) ? default(StringOffset) : builder.CreateString(_o.MaterialDataPath);
			VectorOffset monsterEntityIdsOffset = default(VectorOffset);
			if (_o.MonsterEntityIds != null)
			{
				int[] data = _o.MonsterEntityIds.ToArray();
				monsterEntityIdsOffset = IMonsterGachaItemComponent.CreateMonsterEntityIdsVector(builder, data);
			}
			return IMonsterGachaItemComponent.CreateIMonsterGachaItemComponent(builder, _o.Disabled, materialDataPathOffset, _o.MonsterType, monsterEntityIdsOffset, _o.NullMask);
		}

		// Token: 0x0400F50A RID: 62730
		private Table __p;
	}
}
