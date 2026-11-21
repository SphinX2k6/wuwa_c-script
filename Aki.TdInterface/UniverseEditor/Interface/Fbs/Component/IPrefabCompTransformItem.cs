using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D7F RID: 23935
	public struct IPrefabCompTransformItem : IFlatbufferObject
	{
		// Token: 0x1700B02B RID: 45099
		// (get) Token: 0x06027DAD RID: 163245 RVA: 0x00573C0C File Offset: 0x00571E0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027DAE RID: 163246 RVA: 0x00573C19 File Offset: 0x00571E19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027DAF RID: 163247 RVA: 0x00573C20 File Offset: 0x00571E20
		public static IPrefabCompTransformItem GetRootAsIPrefabCompTransformItem(ByteBuffer _bb)
		{
			return IPrefabCompTransformItem.GetRootAsIPrefabCompTransformItem(_bb, default(IPrefabCompTransformItem));
		}

		// Token: 0x06027DB0 RID: 163248 RVA: 0x00573C3C File Offset: 0x00571E3C
		public static IPrefabCompTransformItem GetRootAsIPrefabCompTransformItem(ByteBuffer _bb, IPrefabCompTransformItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027DB1 RID: 163249 RVA: 0x00573C59 File Offset: 0x00571E59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027DB2 RID: 163250 RVA: 0x00573C68 File Offset: 0x00571E68
		public IPrefabCompTransformItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B02C RID: 45100
		// (get) Token: 0x06027DB3 RID: 163251 RVA: 0x00573C78 File Offset: 0x00571E78
		public bool IsAbsolute
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B02D RID: 45101
		// (get) Token: 0x06027DB4 RID: 163252 RVA: 0x00573CB8 File Offset: 0x00571EB8
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

		// Token: 0x06027DB5 RID: 163253 RVA: 0x00573D15 File Offset: 0x00571F15
		public static Offset<IPrefabCompTransformItem> CreateIPrefabCompTransformItem(FlatBufferBuilder builder, bool IsAbsolute = false, Offset<IVectorInfo> ValueOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPrefabCompTransformItem.AddValue(builder, ValueOffset);
			IPrefabCompTransformItem.AddIsAbsolute(builder, IsAbsolute);
			return IPrefabCompTransformItem.EndIPrefabCompTransformItem(builder);
		}

		// Token: 0x06027DB6 RID: 163254 RVA: 0x00573D32 File Offset: 0x00571F32
		public static void StartIPrefabCompTransformItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027DB7 RID: 163255 RVA: 0x00573D3B File Offset: 0x00571F3B
		public static void AddIsAbsolute(FlatBufferBuilder builder, bool isAbsolute)
		{
			builder.AddBool(0, isAbsolute, false);
		}

		// Token: 0x06027DB8 RID: 163256 RVA: 0x00573D46 File Offset: 0x00571F46
		public static void AddValue(FlatBufferBuilder builder, Offset<IVectorInfo> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x06027DB9 RID: 163257 RVA: 0x00573D56 File Offset: 0x00571F56
		public static Offset<IPrefabCompTransformItem> EndIPrefabCompTransformItem(FlatBufferBuilder builder)
		{
			return new Offset<IPrefabCompTransformItem>(builder.EndTable());
		}

		// Token: 0x06027DBA RID: 163258 RVA: 0x00573D64 File Offset: 0x00571F64
		public IPrefabCompTransformItemT UnPack()
		{
			IPrefabCompTransformItemT prefabCompTransformItemT = new IPrefabCompTransformItemT();
			this.UnPackTo(prefabCompTransformItemT);
			return prefabCompTransformItemT;
		}

		// Token: 0x06027DBB RID: 163259 RVA: 0x00573D80 File Offset: 0x00571F80
		public void UnPackTo(IPrefabCompTransformItemT _o)
		{
			_o.IsAbsolute = this.IsAbsolute;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x06027DBC RID: 163260 RVA: 0x00573DC8 File Offset: 0x00571FC8
		public static Offset<IPrefabCompTransformItem> Pack(FlatBufferBuilder builder, IPrefabCompTransformItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrefabCompTransformItem>);
			}
			Offset<IVectorInfo> valueOffset = (_o.Value == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Value);
			return IPrefabCompTransformItem.CreateIPrefabCompTransformItem(builder, _o.IsAbsolute, valueOffset);
		}

		// Token: 0x0400F910 RID: 63760
		private Table __p;
	}
}
