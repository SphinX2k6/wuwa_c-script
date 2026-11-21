using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005751 RID: 22353
	public struct IExploreSkillInteractGroupComponent : IFlatbufferObject
	{
		// Token: 0x1700A196 RID: 41366
		// (get) Token: 0x0602405A RID: 147546 RVA: 0x004F48F5 File Offset: 0x004F2AF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602405B RID: 147547 RVA: 0x004F4902 File Offset: 0x004F2B02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602405C RID: 147548 RVA: 0x004F490C File Offset: 0x004F2B0C
		public static IExploreSkillInteractGroupComponent GetRootAsIExploreSkillInteractGroupComponent(ByteBuffer _bb)
		{
			return IExploreSkillInteractGroupComponent.GetRootAsIExploreSkillInteractGroupComponent(_bb, default(IExploreSkillInteractGroupComponent));
		}

		// Token: 0x0602405D RID: 147549 RVA: 0x004F4928 File Offset: 0x004F2B28
		public static IExploreSkillInteractGroupComponent GetRootAsIExploreSkillInteractGroupComponent(ByteBuffer _bb, IExploreSkillInteractGroupComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602405E RID: 147550 RVA: 0x004F4945 File Offset: 0x004F2B45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602405F RID: 147551 RVA: 0x004F4954 File Offset: 0x004F2B54
		public IExploreSkillInteractGroupComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A197 RID: 41367
		// (get) Token: 0x06024060 RID: 147552 RVA: 0x004F4964 File Offset: 0x004F2B64
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06024061 RID: 147553 RVA: 0x004F49A4 File Offset: 0x004F2BA4
		public IExploreSkillInteract? ExploreSkillInteractList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IExploreSkillInteract?(default(IExploreSkillInteract).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A198 RID: 41368
		// (get) Token: 0x06024062 RID: 147554 RVA: 0x004F4A04 File Offset: 0x004F2C04
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

		// Token: 0x1700A199 RID: 41369
		// (get) Token: 0x06024063 RID: 147555 RVA: 0x004F4A30 File Offset: 0x004F2C30
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

		// Token: 0x06024064 RID: 147556 RVA: 0x004F4A6C File Offset: 0x004F2C6C
		public static Offset<IExploreSkillInteractGroupComponent> CreateIExploreSkillInteractGroupComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ExploreSkillInteractListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IExploreSkillInteractGroupComponent.AddExploreSkillInteractList(builder, ExploreSkillInteractListOffset);
			IExploreSkillInteractGroupComponent.AddNullMask(builder, NullMask);
			IExploreSkillInteractGroupComponent.AddDisabled(builder, Disabled);
			return IExploreSkillInteractGroupComponent.EndIExploreSkillInteractGroupComponent(builder);
		}

		// Token: 0x06024065 RID: 147557 RVA: 0x004F4A90 File Offset: 0x004F2C90
		public static void StartIExploreSkillInteractGroupComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024066 RID: 147558 RVA: 0x004F4A99 File Offset: 0x004F2C99
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024067 RID: 147559 RVA: 0x004F4AA4 File Offset: 0x004F2CA4
		public static void AddExploreSkillInteractList(FlatBufferBuilder builder, VectorOffset exploreSkillInteractListOffset)
		{
			builder.AddOffset(1, exploreSkillInteractListOffset.Value, 0);
		}

		// Token: 0x06024068 RID: 147560 RVA: 0x004F4AB4 File Offset: 0x004F2CB4
		public static VectorOffset CreateExploreSkillInteractListVector(FlatBufferBuilder builder, Offset<IExploreSkillInteract>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024069 RID: 147561 RVA: 0x004F4AF4 File Offset: 0x004F2CF4
		public static VectorOffset CreateExploreSkillInteractListVectorBlock(FlatBufferBuilder builder, Offset<IExploreSkillInteract>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IExploreSkillInteract>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602406A RID: 147562 RVA: 0x004F4B0E File Offset: 0x004F2D0E
		public static VectorOffset CreateExploreSkillInteractListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IExploreSkillInteract>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IExploreSkillInteract>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602406B RID: 147563 RVA: 0x004F4B2C File Offset: 0x004F2D2C
		public static VectorOffset CreateExploreSkillInteractListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IExploreSkillInteract>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602406C RID: 147564 RVA: 0x004F4B45 File Offset: 0x004F2D45
		public static void StartExploreSkillInteractListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602406D RID: 147565 RVA: 0x004F4B50 File Offset: 0x004F2D50
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602406E RID: 147566 RVA: 0x004F4B5B File Offset: 0x004F2D5B
		public static Offset<IExploreSkillInteractGroupComponent> EndIExploreSkillInteractGroupComponent(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillInteractGroupComponent>(builder.EndTable());
		}

		// Token: 0x0602406F RID: 147567 RVA: 0x004F4B68 File Offset: 0x004F2D68
		public IExploreSkillInteractGroupComponentT UnPack()
		{
			IExploreSkillInteractGroupComponentT exploreSkillInteractGroupComponentT = new IExploreSkillInteractGroupComponentT();
			this.UnPackTo(exploreSkillInteractGroupComponentT);
			return exploreSkillInteractGroupComponentT;
		}

		// Token: 0x06024070 RID: 147568 RVA: 0x004F4B84 File Offset: 0x004F2D84
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

		// Token: 0x06024071 RID: 147569 RVA: 0x004F4BFC File Offset: 0x004F2DFC
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

		// Token: 0x0400EF0B RID: 61195
		private Table __p;
	}
}
