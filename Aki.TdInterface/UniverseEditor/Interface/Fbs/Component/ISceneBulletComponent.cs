using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A3 RID: 22691
	public struct ISceneBulletComponent : IFlatbufferObject
	{
		// Token: 0x1700A9DF RID: 43487
		// (get) Token: 0x06026466 RID: 156774 RVA: 0x00546B78 File Offset: 0x00544D78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026467 RID: 156775 RVA: 0x00546B85 File Offset: 0x00544D85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026468 RID: 156776 RVA: 0x00546B8C File Offset: 0x00544D8C
		public static ISceneBulletComponent GetRootAsISceneBulletComponent(ByteBuffer _bb)
		{
			return ISceneBulletComponent.GetRootAsISceneBulletComponent(_bb, default(ISceneBulletComponent));
		}

		// Token: 0x06026469 RID: 156777 RVA: 0x00546BA8 File Offset: 0x00544DA8
		public static ISceneBulletComponent GetRootAsISceneBulletComponent(ByteBuffer _bb, ISceneBulletComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602646A RID: 156778 RVA: 0x00546BC5 File Offset: 0x00544DC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602646B RID: 156779 RVA: 0x00546BD4 File Offset: 0x00544DD4
		public ISceneBulletComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9E0 RID: 43488
		// (get) Token: 0x0602646C RID: 156780 RVA: 0x00546BE4 File Offset: 0x00544DE4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A9E1 RID: 43489
		// (get) Token: 0x0602646D RID: 156781 RVA: 0x00546C24 File Offset: 0x00544E24
		public bool DisableGenerateByRange
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602646E RID: 156782 RVA: 0x00546C64 File Offset: 0x00544E64
		public ISceneBulletGroup? BulletGroups(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ISceneBulletGroup?(default(ISceneBulletGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9E2 RID: 43490
		// (get) Token: 0x0602646F RID: 156783 RVA: 0x00546CC4 File Offset: 0x00544EC4
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

		// Token: 0x1700A9E3 RID: 43491
		// (get) Token: 0x06026470 RID: 156784 RVA: 0x00546CF0 File Offset: 0x00544EF0
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

		// Token: 0x06026471 RID: 156785 RVA: 0x00546D2D File Offset: 0x00544F2D
		public static Offset<ISceneBulletComponent> CreateISceneBulletComponent(FlatBufferBuilder builder, bool Disabled = false, bool DisableGenerateByRange = false, VectorOffset BulletGroupsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISceneBulletComponent.AddBulletGroups(builder, BulletGroupsOffset);
			ISceneBulletComponent.AddNullMask(builder, NullMask);
			ISceneBulletComponent.AddDisableGenerateByRange(builder, DisableGenerateByRange);
			ISceneBulletComponent.AddDisabled(builder, Disabled);
			return ISceneBulletComponent.EndISceneBulletComponent(builder);
		}

		// Token: 0x06026472 RID: 156786 RVA: 0x00546D59 File Offset: 0x00544F59
		public static void StartISceneBulletComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026473 RID: 156787 RVA: 0x00546D62 File Offset: 0x00544F62
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026474 RID: 156788 RVA: 0x00546D6D File Offset: 0x00544F6D
		public static void AddDisableGenerateByRange(FlatBufferBuilder builder, bool disableGenerateByRange)
		{
			builder.AddBool(1, disableGenerateByRange, false);
		}

		// Token: 0x06026475 RID: 156789 RVA: 0x00546D78 File Offset: 0x00544F78
		public static void AddBulletGroups(FlatBufferBuilder builder, VectorOffset bulletGroupsOffset)
		{
			builder.AddOffset(2, bulletGroupsOffset.Value, 0);
		}

		// Token: 0x06026476 RID: 156790 RVA: 0x00546D88 File Offset: 0x00544F88
		public static VectorOffset CreateBulletGroupsVector(FlatBufferBuilder builder, Offset<ISceneBulletGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026477 RID: 156791 RVA: 0x00546DC8 File Offset: 0x00544FC8
		public static VectorOffset CreateBulletGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISceneBulletGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneBulletGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026478 RID: 156792 RVA: 0x00546DE2 File Offset: 0x00544FE2
		public static VectorOffset CreateBulletGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneBulletGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneBulletGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026479 RID: 156793 RVA: 0x00546E00 File Offset: 0x00545000
		public static VectorOffset CreateBulletGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneBulletGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602647A RID: 156794 RVA: 0x00546E19 File Offset: 0x00545019
		public static void StartBulletGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602647B RID: 156795 RVA: 0x00546E24 File Offset: 0x00545024
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602647C RID: 156796 RVA: 0x00546E2F File Offset: 0x0054502F
		public static Offset<ISceneBulletComponent> EndISceneBulletComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneBulletComponent>(builder.EndTable());
		}

		// Token: 0x0602647D RID: 156797 RVA: 0x00546E3C File Offset: 0x0054503C
		public ISceneBulletComponentT UnPack()
		{
			ISceneBulletComponentT sceneBulletComponentT = new ISceneBulletComponentT();
			this.UnPackTo(sceneBulletComponentT);
			return sceneBulletComponentT;
		}

		// Token: 0x0602647E RID: 156798 RVA: 0x00546E58 File Offset: 0x00545058
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

		// Token: 0x0602647F RID: 156799 RVA: 0x00546EDC File Offset: 0x005450DC
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

		// Token: 0x0400EE09 RID: 60937
		private Table __p;
	}
}
