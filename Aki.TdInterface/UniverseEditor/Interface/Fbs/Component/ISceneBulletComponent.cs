using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EB0 RID: 24240
	public struct ISceneBulletComponent : IFlatbufferObject
	{
		// Token: 0x1700B30F RID: 45839
		// (get) Token: 0x060289C8 RID: 166344 RVA: 0x0058D6C4 File Offset: 0x0058B8C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060289C9 RID: 166345 RVA: 0x0058D6D1 File Offset: 0x0058B8D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060289CA RID: 166346 RVA: 0x0058D6D8 File Offset: 0x0058B8D8
		public static ISceneBulletComponent GetRootAsISceneBulletComponent(ByteBuffer _bb)
		{
			return ISceneBulletComponent.GetRootAsISceneBulletComponent(_bb, default(ISceneBulletComponent));
		}

		// Token: 0x060289CB RID: 166347 RVA: 0x0058D6F4 File Offset: 0x0058B8F4
		public static ISceneBulletComponent GetRootAsISceneBulletComponent(ByteBuffer _bb, ISceneBulletComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060289CC RID: 166348 RVA: 0x0058D711 File Offset: 0x0058B911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060289CD RID: 166349 RVA: 0x0058D720 File Offset: 0x0058B920
		public ISceneBulletComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B310 RID: 45840
		// (get) Token: 0x060289CE RID: 166350 RVA: 0x0058D730 File Offset: 0x0058B930
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B311 RID: 45841
		// (get) Token: 0x060289CF RID: 166351 RVA: 0x0058D770 File Offset: 0x0058B970
		public bool DisableGenerateByRange
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060289D0 RID: 166352 RVA: 0x0058D7B0 File Offset: 0x0058B9B0
		public ISceneBulletGroup? BulletGroups(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ISceneBulletGroup?(default(ISceneBulletGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B312 RID: 45842
		// (get) Token: 0x060289D1 RID: 166353 RVA: 0x0058D810 File Offset: 0x0058BA10
		public int BulletGroupsLength
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

		// Token: 0x1700B313 RID: 45843
		// (get) Token: 0x060289D2 RID: 166354 RVA: 0x0058D83C File Offset: 0x0058BA3C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060289D3 RID: 166355 RVA: 0x0058D879 File Offset: 0x0058BA79
		public static Offset<ISceneBulletComponent> CreateISceneBulletComponent(FlatBufferBuilder builder, bool Disabled = false, bool DisableGenerateByRange = false, VectorOffset BulletGroupsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISceneBulletComponent.AddBulletGroups(builder, BulletGroupsOffset);
			ISceneBulletComponent.AddNullMask(builder, NullMask);
			ISceneBulletComponent.AddDisableGenerateByRange(builder, DisableGenerateByRange);
			ISceneBulletComponent.AddDisabled(builder, Disabled);
			return ISceneBulletComponent.EndISceneBulletComponent(builder);
		}

		// Token: 0x060289D4 RID: 166356 RVA: 0x0058D8A5 File Offset: 0x0058BAA5
		public static void StartISceneBulletComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060289D5 RID: 166357 RVA: 0x0058D8AE File Offset: 0x0058BAAE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060289D6 RID: 166358 RVA: 0x0058D8B9 File Offset: 0x0058BAB9
		public static void AddDisableGenerateByRange(FlatBufferBuilder builder, bool disableGenerateByRange)
		{
			builder.AddBool(1, disableGenerateByRange, false);
		}

		// Token: 0x060289D7 RID: 166359 RVA: 0x0058D8C4 File Offset: 0x0058BAC4
		public static void AddBulletGroups(FlatBufferBuilder builder, VectorOffset bulletGroupsOffset)
		{
			builder.AddOffset(2, bulletGroupsOffset.Value, 0);
		}

		// Token: 0x060289D8 RID: 166360 RVA: 0x0058D8D4 File Offset: 0x0058BAD4
		public static VectorOffset CreateBulletGroupsVector(FlatBufferBuilder builder, Offset<ISceneBulletGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060289D9 RID: 166361 RVA: 0x0058D914 File Offset: 0x0058BB14
		public static VectorOffset CreateBulletGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISceneBulletGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneBulletGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060289DA RID: 166362 RVA: 0x0058D92E File Offset: 0x0058BB2E
		public static VectorOffset CreateBulletGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneBulletGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneBulletGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060289DB RID: 166363 RVA: 0x0058D94C File Offset: 0x0058BB4C
		public static VectorOffset CreateBulletGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneBulletGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060289DC RID: 166364 RVA: 0x0058D965 File Offset: 0x0058BB65
		public static void StartBulletGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060289DD RID: 166365 RVA: 0x0058D970 File Offset: 0x0058BB70
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060289DE RID: 166366 RVA: 0x0058D97B File Offset: 0x0058BB7B
		public static Offset<ISceneBulletComponent> EndISceneBulletComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneBulletComponent>(builder.EndTable());
		}

		// Token: 0x060289DF RID: 166367 RVA: 0x0058D988 File Offset: 0x0058BB88
		public ISceneBulletComponentT UnPack()
		{
			ISceneBulletComponentT sceneBulletComponentT = new ISceneBulletComponentT();
			this.UnPackTo(sceneBulletComponentT);
			return sceneBulletComponentT;
		}

		// Token: 0x060289E0 RID: 166368 RVA: 0x0058D9A4 File Offset: 0x0058BBA4
		public void UnPackTo(ISceneBulletComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DisableGenerateByRange = this.DisableGenerateByRange;
			_o.BulletGroups = new List<ISceneBulletGroupT>();
			for (int i = 0; i < this.BulletGroupsLength; i++)
			{
				_o.BulletGroups.Add((this.BulletGroups(i) != null) ? this.BulletGroups(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060289E1 RID: 166369 RVA: 0x0058DA28 File Offset: 0x0058BC28
		public static Offset<ISceneBulletComponent> Pack(FlatBufferBuilder builder, ISceneBulletComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneBulletComponent>);
			}
			VectorOffset bulletGroupsOffset = default(VectorOffset);
			if (_o.BulletGroups != null)
			{
				Offset<ISceneBulletGroup>[] array = new Offset<ISceneBulletGroup>[_o.BulletGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISceneBulletGroup.Pack(builder, _o.BulletGroups[i]);
				}
				bulletGroupsOffset = ISceneBulletComponent.CreateBulletGroupsVector(builder, array);
			}
			return ISceneBulletComponent.CreateISceneBulletComponent(builder, _o.Disabled, _o.DisableGenerateByRange, bulletGroupsOffset, _o.NullMask);
		}

		// Token: 0x0400FAFC RID: 64252
		private Table __p;
	}
}
