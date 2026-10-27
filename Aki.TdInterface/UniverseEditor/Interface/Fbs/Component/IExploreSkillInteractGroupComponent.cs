using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051E9 RID: 20969
	public struct IExploreSkillInteractGroupComponent : IFlatbufferObject
	{
		// Token: 0x1700999A RID: 39322
		// (get) Token: 0x060220C6 RID: 139462 RVA: 0x004B9E75 File Offset: 0x004B8075
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060220C7 RID: 139463 RVA: 0x004B9E82 File Offset: 0x004B8082
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060220C8 RID: 139464 RVA: 0x004B9E8C File Offset: 0x004B808C
		public static IExploreSkillInteractGroupComponent GetRootAsIExploreSkillInteractGroupComponent(ByteBuffer _bb)
		{
			return IExploreSkillInteractGroupComponent.GetRootAsIExploreSkillInteractGroupComponent(_bb, default(IExploreSkillInteractGroupComponent));
		}

		// Token: 0x060220C9 RID: 139465 RVA: 0x004B9EA8 File Offset: 0x004B80A8
		public static IExploreSkillInteractGroupComponent GetRootAsIExploreSkillInteractGroupComponent(ByteBuffer _bb, IExploreSkillInteractGroupComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060220CA RID: 139466 RVA: 0x004B9EC5 File Offset: 0x004B80C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060220CB RID: 139467 RVA: 0x004B9ED4 File Offset: 0x004B80D4
		public IExploreSkillInteractGroupComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700999B RID: 39323
		// (get) Token: 0x060220CC RID: 139468 RVA: 0x004B9EE4 File Offset: 0x004B80E4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060220CD RID: 139469 RVA: 0x004B9F24 File Offset: 0x004B8124
		public IExploreSkillInteract? ExploreSkillInteractList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IExploreSkillInteract?(default(IExploreSkillInteract).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700999C RID: 39324
		// (get) Token: 0x060220CE RID: 139470 RVA: 0x004B9F84 File Offset: 0x004B8184
		public int ExploreSkillInteractListLength
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

		// Token: 0x1700999D RID: 39325
		// (get) Token: 0x060220CF RID: 139471 RVA: 0x004B9FB0 File Offset: 0x004B81B0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060220D0 RID: 139472 RVA: 0x004B9FEC File Offset: 0x004B81EC
		public static Offset<IExploreSkillInteractGroupComponent> CreateIExploreSkillInteractGroupComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ExploreSkillInteractListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IExploreSkillInteractGroupComponent.AddExploreSkillInteractList(builder, ExploreSkillInteractListOffset);
			IExploreSkillInteractGroupComponent.AddNullMask(builder, NullMask);
			IExploreSkillInteractGroupComponent.AddDisabled(builder, Disabled);
			return IExploreSkillInteractGroupComponent.EndIExploreSkillInteractGroupComponent(builder);
		}

		// Token: 0x060220D1 RID: 139473 RVA: 0x004BA010 File Offset: 0x004B8210
		public static void StartIExploreSkillInteractGroupComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060220D2 RID: 139474 RVA: 0x004BA019 File Offset: 0x004B8219
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060220D3 RID: 139475 RVA: 0x004BA024 File Offset: 0x004B8224
		public static void AddExploreSkillInteractList(FlatBufferBuilder builder, VectorOffset exploreSkillInteractListOffset)
		{
			builder.AddOffset(1, exploreSkillInteractListOffset.Value, 0);
		}

		// Token: 0x060220D4 RID: 139476 RVA: 0x004BA034 File Offset: 0x004B8234
		public static VectorOffset CreateExploreSkillInteractListVector(FlatBufferBuilder builder, Offset<IExploreSkillInteract>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060220D5 RID: 139477 RVA: 0x004BA074 File Offset: 0x004B8274
		public static VectorOffset CreateExploreSkillInteractListVectorBlock(FlatBufferBuilder builder, Offset<IExploreSkillInteract>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IExploreSkillInteract>>(data);
			return builder.EndVector();
		}

		// Token: 0x060220D6 RID: 139478 RVA: 0x004BA08E File Offset: 0x004B828E
		public static VectorOffset CreateExploreSkillInteractListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IExploreSkillInteract>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IExploreSkillInteract>>(data);
			return builder.EndVector();
		}

		// Token: 0x060220D7 RID: 139479 RVA: 0x004BA0AC File Offset: 0x004B82AC
		public static VectorOffset CreateExploreSkillInteractListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IExploreSkillInteract>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060220D8 RID: 139480 RVA: 0x004BA0C5 File Offset: 0x004B82C5
		public static void StartExploreSkillInteractListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060220D9 RID: 139481 RVA: 0x004BA0D0 File Offset: 0x004B82D0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060220DA RID: 139482 RVA: 0x004BA0DB File Offset: 0x004B82DB
		public static Offset<IExploreSkillInteractGroupComponent> EndIExploreSkillInteractGroupComponent(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillInteractGroupComponent>(builder.EndTable());
		}

		// Token: 0x060220DB RID: 139483 RVA: 0x004BA0E8 File Offset: 0x004B82E8
		public IExploreSkillInteractGroupComponentT UnPack()
		{
			IExploreSkillInteractGroupComponentT exploreSkillInteractGroupComponentT = new IExploreSkillInteractGroupComponentT();
			this.UnPackTo(exploreSkillInteractGroupComponentT);
			return exploreSkillInteractGroupComponentT;
		}

		// Token: 0x060220DC RID: 139484 RVA: 0x004BA104 File Offset: 0x004B8304
		public void UnPackTo(IExploreSkillInteractGroupComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ExploreSkillInteractList = new List<IExploreSkillInteractT>();
			for (int i = 0; i < this.ExploreSkillInteractListLength; i++)
			{
				_o.ExploreSkillInteractList.Add((this.ExploreSkillInteractList(i) != null) ? this.ExploreSkillInteractList(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060220DD RID: 139485 RVA: 0x004BA17C File Offset: 0x004B837C
		public static Offset<IExploreSkillInteractGroupComponent> Pack(FlatBufferBuilder builder, IExploreSkillInteractGroupComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillInteractGroupComponent>);
			}
			VectorOffset exploreSkillInteractListOffset = default(VectorOffset);
			if (_o.ExploreSkillInteractList != null)
			{
				Offset<IExploreSkillInteract>[] array = new Offset<IExploreSkillInteract>[_o.ExploreSkillInteractList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IExploreSkillInteract.Pack(builder, _o.ExploreSkillInteractList[i]);
				}
				exploreSkillInteractListOffset = IExploreSkillInteractGroupComponent.CreateExploreSkillInteractListVector(builder, array);
			}
			return IExploreSkillInteractGroupComponent.CreateIExploreSkillInteractGroupComponent(builder, _o.Disabled, exploreSkillInteractListOffset, _o.NullMask);
		}

		// Token: 0x0400E306 RID: 58118
		private Table __p;
	}
}
