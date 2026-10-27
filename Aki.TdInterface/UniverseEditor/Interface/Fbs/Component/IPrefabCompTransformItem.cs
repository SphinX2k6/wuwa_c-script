using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005778 RID: 22392
	public struct IPrefabCompTransformItem : IFlatbufferObject
	{
		// Token: 0x1700A707 RID: 42759
		// (get) Token: 0x0602588D RID: 153741 RVA: 0x0052DA80 File Offset: 0x0052BC80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602588E RID: 153742 RVA: 0x0052DA8D File Offset: 0x0052BC8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602588F RID: 153743 RVA: 0x0052DA94 File Offset: 0x0052BC94
		public static IPrefabCompTransformItem GetRootAsIPrefabCompTransformItem(ByteBuffer _bb)
		{
			return IPrefabCompTransformItem.GetRootAsIPrefabCompTransformItem(_bb, default(IPrefabCompTransformItem));
		}

		// Token: 0x06025890 RID: 153744 RVA: 0x0052DAB0 File Offset: 0x0052BCB0
		public static IPrefabCompTransformItem GetRootAsIPrefabCompTransformItem(ByteBuffer _bb, IPrefabCompTransformItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025891 RID: 153745 RVA: 0x0052DACD File Offset: 0x0052BCCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025892 RID: 153746 RVA: 0x0052DADC File Offset: 0x0052BCDC
		public IPrefabCompTransformItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A708 RID: 42760
		// (get) Token: 0x06025893 RID: 153747 RVA: 0x0052DAEC File Offset: 0x0052BCEC
		public bool IsAbsolute
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A709 RID: 42761
		// (get) Token: 0x06025894 RID: 153748 RVA: 0x0052DB2C File Offset: 0x0052BD2C
		public IVectorInfo? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025895 RID: 153749 RVA: 0x0052DB89 File Offset: 0x0052BD89
		public static Offset<IPrefabCompTransformItem> CreateIPrefabCompTransformItem(FlatBufferBuilder builder, bool IsAbsolute = false, Offset<IVectorInfo> ValueOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPrefabCompTransformItem.AddValue(builder, ValueOffset);
			IPrefabCompTransformItem.AddIsAbsolute(builder, IsAbsolute);
			return IPrefabCompTransformItem.EndIPrefabCompTransformItem(builder);
		}

		// Token: 0x06025896 RID: 153750 RVA: 0x0052DBA6 File Offset: 0x0052BDA6
		public static void StartIPrefabCompTransformItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025897 RID: 153751 RVA: 0x0052DBAF File Offset: 0x0052BDAF
		public static void AddIsAbsolute(FlatBufferBuilder builder, bool isAbsolute)
		{
			builder.AddBool(0, isAbsolute, false);
		}

		// Token: 0x06025898 RID: 153752 RVA: 0x0052DBBA File Offset: 0x0052BDBA
		public static void AddValue(FlatBufferBuilder builder, Offset<IVectorInfo> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x06025899 RID: 153753 RVA: 0x0052DBCA File Offset: 0x0052BDCA
		public static Offset<IPrefabCompTransformItem> EndIPrefabCompTransformItem(FlatBufferBuilder builder)
		{
			return new Offset<IPrefabCompTransformItem>(builder.EndTable());
		}

		// Token: 0x0602589A RID: 153754 RVA: 0x0052DBD8 File Offset: 0x0052BDD8
		public IPrefabCompTransformItemT UnPack()
		{
			IPrefabCompTransformItemT prefabCompTransformItemT = new IPrefabCompTransformItemT();
			this.UnPackTo(prefabCompTransformItemT);
			return prefabCompTransformItemT;
		}

		// Token: 0x0602589B RID: 153755 RVA: 0x0052DBF4 File Offset: 0x0052BDF4
		public void UnPackTo(IPrefabCompTransformItemT _o)
		{
			_o.IsAbsolute = this.IsAbsolute;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0602589C RID: 153756 RVA: 0x0052DC3C File Offset: 0x0052BE3C
		public static Offset<IPrefabCompTransformItem> Pack(FlatBufferBuilder builder, IPrefabCompTransformItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrefabCompTransformItem>);
			}
			Offset<IVectorInfo> valueOffset = (_o.Value == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Value);
			return IPrefabCompTransformItem.CreateIPrefabCompTransformItem(builder, _o.IsAbsolute, valueOffset);
		}

		// Token: 0x0400EC25 RID: 60453
		private Table __p;
	}
}
