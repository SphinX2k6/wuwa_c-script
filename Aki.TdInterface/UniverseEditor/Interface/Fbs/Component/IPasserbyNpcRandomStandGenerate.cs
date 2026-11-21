using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CAB RID: 23723
	public struct IPasserbyNpcRandomStandGenerate : IFlatbufferObject
	{
		// Token: 0x1700AE44 RID: 44612
		// (get) Token: 0x060275BD RID: 161213 RVA: 0x00563437 File Offset: 0x00561637
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060275BE RID: 161214 RVA: 0x00563444 File Offset: 0x00561644
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060275BF RID: 161215 RVA: 0x0056344C File Offset: 0x0056164C
		public static IPasserbyNpcRandomStandGenerate GetRootAsIPasserbyNpcRandomStandGenerate(ByteBuffer _bb)
		{
			return IPasserbyNpcRandomStandGenerate.GetRootAsIPasserbyNpcRandomStandGenerate(_bb, default(IPasserbyNpcRandomStandGenerate));
		}

		// Token: 0x060275C0 RID: 161216 RVA: 0x00563468 File Offset: 0x00561668
		public static IPasserbyNpcRandomStandGenerate GetRootAsIPasserbyNpcRandomStandGenerate(ByteBuffer _bb, IPasserbyNpcRandomStandGenerate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060275C1 RID: 161217 RVA: 0x00563485 File Offset: 0x00561685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060275C2 RID: 161218 RVA: 0x00563494 File Offset: 0x00561694
		public IPasserbyNpcRandomStandGenerate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE45 RID: 44613
		// (get) Token: 0x060275C3 RID: 161219 RVA: 0x005634A4 File Offset: 0x005616A4
		public EPasserbyNpcGenerateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcGenerateType.RandomStand;
				}
				return (EPasserbyNpcGenerateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE46 RID: 44614
		// (get) Token: 0x060275C4 RID: 161220 RVA: 0x005634E0 File Offset: 0x005616E0
		public IPasserbyNpcSelfSpawnCenterPos? SpawnCenterPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcSelfSpawnCenterPos?(default(IPasserbyNpcSelfSpawnCenterPos).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060275C5 RID: 161221 RVA: 0x00563540 File Offset: 0x00561740
		public IPasserbyNpcRandomGroup? Groups(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IPasserbyNpcRandomGroup?(default(IPasserbyNpcRandomGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE47 RID: 44615
		// (get) Token: 0x060275C6 RID: 161222 RVA: 0x005635A0 File Offset: 0x005617A0
		public int GroupsLength
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

		// Token: 0x060275C7 RID: 161223 RVA: 0x005635CB File Offset: 0x005617CB
		public static Offset<IPasserbyNpcRandomStandGenerate> CreateIPasserbyNpcRandomStandGenerate(FlatBufferBuilder builder, EPasserbyNpcGenerateType Type = EPasserbyNpcGenerateType.RandomStand, Offset<IPasserbyNpcSelfSpawnCenterPos> SpawnCenterPosOffset = default(Offset<IPasserbyNpcSelfSpawnCenterPos>), VectorOffset GroupsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IPasserbyNpcRandomStandGenerate.AddGroups(builder, GroupsOffset);
			IPasserbyNpcRandomStandGenerate.AddSpawnCenterPos(builder, SpawnCenterPosOffset);
			IPasserbyNpcRandomStandGenerate.AddType(builder, Type);
			return IPasserbyNpcRandomStandGenerate.EndIPasserbyNpcRandomStandGenerate(builder);
		}

		// Token: 0x060275C8 RID: 161224 RVA: 0x005635EF File Offset: 0x005617EF
		public static void StartIPasserbyNpcRandomStandGenerate(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060275C9 RID: 161225 RVA: 0x005635F8 File Offset: 0x005617F8
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcGenerateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060275CA RID: 161226 RVA: 0x00563603 File Offset: 0x00561803
		public static void AddSpawnCenterPos(FlatBufferBuilder builder, Offset<IPasserbyNpcSelfSpawnCenterPos> spawnCenterPosOffset)
		{
			builder.AddOffset(1, spawnCenterPosOffset.Value, 0);
		}

		// Token: 0x060275CB RID: 161227 RVA: 0x00563613 File Offset: 0x00561813
		public static void AddGroups(FlatBufferBuilder builder, VectorOffset groupsOffset)
		{
			builder.AddOffset(2, groupsOffset.Value, 0);
		}

		// Token: 0x060275CC RID: 161228 RVA: 0x00563624 File Offset: 0x00561824
		public static VectorOffset CreateGroupsVector(FlatBufferBuilder builder, Offset<IPasserbyNpcRandomGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060275CD RID: 161229 RVA: 0x00563664 File Offset: 0x00561864
		public static VectorOffset CreateGroupsVectorBlock(FlatBufferBuilder builder, Offset<IPasserbyNpcRandomGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPasserbyNpcRandomGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060275CE RID: 161230 RVA: 0x0056367E File Offset: 0x0056187E
		public static VectorOffset CreateGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPasserbyNpcRandomGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPasserbyNpcRandomGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060275CF RID: 161231 RVA: 0x0056369C File Offset: 0x0056189C
		public static VectorOffset CreateGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPasserbyNpcRandomGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060275D0 RID: 161232 RVA: 0x005636B5 File Offset: 0x005618B5
		public static void StartGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060275D1 RID: 161233 RVA: 0x005636C0 File Offset: 0x005618C0
		public static Offset<IPasserbyNpcRandomStandGenerate> EndIPasserbyNpcRandomStandGenerate(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcRandomStandGenerate>(builder.EndTable());
		}

		// Token: 0x060275D2 RID: 161234 RVA: 0x005636D0 File Offset: 0x005618D0
		public IPasserbyNpcRandomStandGenerateT UnPack()
		{
			IPasserbyNpcRandomStandGenerateT passerbyNpcRandomStandGenerateT = new IPasserbyNpcRandomStandGenerateT();
			this.UnPackTo(passerbyNpcRandomStandGenerateT);
			return passerbyNpcRandomStandGenerateT;
		}

		// Token: 0x060275D3 RID: 161235 RVA: 0x005636EC File Offset: 0x005618EC
		public void UnPackTo(IPasserbyNpcRandomStandGenerateT _o)
		{
			_o.Type = this.Type;
			_o.SpawnCenterPos = ((this.SpawnCenterPos != null) ? this.SpawnCenterPos.Value.UnPack() : null);
			_o.Groups = new List<IPasserbyNpcRandomGroupT>();
			for (int i = 0; i < this.GroupsLength; i++)
			{
				_o.Groups.Add((this.Groups(i) != null) ? this.Groups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060275D4 RID: 161236 RVA: 0x00563788 File Offset: 0x00561988
		public static Offset<IPasserbyNpcRandomStandGenerate> Pack(FlatBufferBuilder builder, IPasserbyNpcRandomStandGenerateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcRandomStandGenerate>);
			}
			Offset<IPasserbyNpcSelfSpawnCenterPos> spawnCenterPosOffset = (_o.SpawnCenterPos == null) ? default(Offset<IPasserbyNpcSelfSpawnCenterPos>) : IPasserbyNpcSelfSpawnCenterPos.Pack(builder, _o.SpawnCenterPos);
			VectorOffset groupsOffset = default(VectorOffset);
			if (_o.Groups != null)
			{
				Offset<IPasserbyNpcRandomGroup>[] array = new Offset<IPasserbyNpcRandomGroup>[_o.Groups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPasserbyNpcRandomGroup.Pack(builder, _o.Groups[i]);
				}
				groupsOffset = IPasserbyNpcRandomStandGenerate.CreateGroupsVector(builder, array);
			}
			return IPasserbyNpcRandomStandGenerate.CreateIPasserbyNpcRandomStandGenerate(builder, _o.Type, spawnCenterPosOffset, groupsOffset);
		}

		// Token: 0x0400F7C0 RID: 63424
		private Table __p;
	}
}
