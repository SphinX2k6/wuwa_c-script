using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B85 RID: 23429
	public struct INavMeshComponent : IFlatbufferObject
	{
		// Token: 0x1700AB43 RID: 43843
		// (get) Token: 0x060269C6 RID: 158150 RVA: 0x0054991E File Offset: 0x00547B1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060269C7 RID: 158151 RVA: 0x0054992B File Offset: 0x00547B2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060269C8 RID: 158152 RVA: 0x00549934 File Offset: 0x00547B34
		public static INavMeshComponent GetRootAsINavMeshComponent(ByteBuffer _bb)
		{
			return INavMeshComponent.GetRootAsINavMeshComponent(_bb, default(INavMeshComponent));
		}

		// Token: 0x060269C9 RID: 158153 RVA: 0x00549950 File Offset: 0x00547B50
		public static INavMeshComponent GetRootAsINavMeshComponent(ByteBuffer _bb, INavMeshComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060269CA RID: 158154 RVA: 0x0054996D File Offset: 0x00547B6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060269CB RID: 158155 RVA: 0x0054997C File Offset: 0x00547B7C
		public INavMeshComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB44 RID: 43844
		// (get) Token: 0x060269CC RID: 158156 RVA: 0x0054998C File Offset: 0x00547B8C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB45 RID: 43845
		// (get) Token: 0x060269CD RID: 158157 RVA: 0x005499CC File Offset: 0x00547BCC
		public INavMeshAkiEntitySource? Source
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new INavMeshAkiEntitySource?(default(INavMeshAkiEntitySource).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AB46 RID: 43846
		// (get) Token: 0x060269CE RID: 158158 RVA: 0x00549A2C File Offset: 0x00547C2C
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

		// Token: 0x060269CF RID: 158159 RVA: 0x00549A68 File Offset: 0x00547C68
		public static Offset<INavMeshComponent> CreateINavMeshComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<INavMeshAkiEntitySource> SourceOffset = default(Offset<INavMeshAkiEntitySource>), byte NullMask = 0)
		{
			builder.StartTable(3);
			INavMeshComponent.AddSource(builder, SourceOffset);
			INavMeshComponent.AddNullMask(builder, NullMask);
			INavMeshComponent.AddDisabled(builder, Disabled);
			return INavMeshComponent.EndINavMeshComponent(builder);
		}

		// Token: 0x060269D0 RID: 158160 RVA: 0x00549A8C File Offset: 0x00547C8C
		public static void StartINavMeshComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060269D1 RID: 158161 RVA: 0x00549A95 File Offset: 0x00547C95
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060269D2 RID: 158162 RVA: 0x00549AA0 File Offset: 0x00547CA0
		public static void AddSource(FlatBufferBuilder builder, Offset<INavMeshAkiEntitySource> sourceOffset)
		{
			builder.AddOffset(1, sourceOffset.Value, 0);
		}

		// Token: 0x060269D3 RID: 158163 RVA: 0x00549AB0 File Offset: 0x00547CB0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060269D4 RID: 158164 RVA: 0x00549ABB File Offset: 0x00547CBB
		public static Offset<INavMeshComponent> EndINavMeshComponent(FlatBufferBuilder builder)
		{
			return new Offset<INavMeshComponent>(builder.EndTable());
		}

		// Token: 0x060269D5 RID: 158165 RVA: 0x00549AC8 File Offset: 0x00547CC8
		public INavMeshComponentT UnPack()
		{
			INavMeshComponentT navMeshComponentT = new INavMeshComponentT();
			this.UnPackTo(navMeshComponentT);
			return navMeshComponentT;
		}

		// Token: 0x060269D6 RID: 158166 RVA: 0x00549AE4 File Offset: 0x00547CE4
		public void UnPackTo(INavMeshComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Source = ((this.Source != null) ? this.Source.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060269D7 RID: 158167 RVA: 0x00549B38 File Offset: 0x00547D38
		public static Offset<INavMeshComponent> Pack(FlatBufferBuilder builder, INavMeshComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<INavMeshComponent>);
			}
			Offset<INavMeshAkiEntitySource> sourceOffset = (_o.Source == null) ? default(Offset<INavMeshAkiEntitySource>) : INavMeshAkiEntitySource.Pack(builder, _o.Source);
			return INavMeshComponent.CreateINavMeshComponent(builder, _o.Disabled, sourceOffset, _o.NullMask);
		}

		// Token: 0x0400F5B3 RID: 62899
		private Table __p;
	}
}
