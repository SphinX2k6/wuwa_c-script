using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A10 RID: 23056
	public struct ISwitcherComponent : IFlatbufferObject
	{
		// Token: 0x1700AD3D RID: 44349
		// (get) Token: 0x06027237 RID: 160311 RVA: 0x005623EE File Offset: 0x005605EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027238 RID: 160312 RVA: 0x005623FB File Offset: 0x005605FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027239 RID: 160313 RVA: 0x00562404 File Offset: 0x00560604
		public static ISwitcherComponent GetRootAsISwitcherComponent(ByteBuffer _bb)
		{
			return ISwitcherComponent.GetRootAsISwitcherComponent(_bb, default(ISwitcherComponent));
		}

		// Token: 0x0602723A RID: 160314 RVA: 0x00562420 File Offset: 0x00560620
		public static ISwitcherComponent GetRootAsISwitcherComponent(ByteBuffer _bb, ISwitcherComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602723B RID: 160315 RVA: 0x0056243D File Offset: 0x0056063D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602723C RID: 160316 RVA: 0x0056244C File Offset: 0x0056064C
		public ISwitcherComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD3E RID: 44350
		// (get) Token: 0x0602723D RID: 160317 RVA: 0x0056245C File Offset: 0x0056065C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AD3F RID: 44351
		// (get) Token: 0x0602723E RID: 160318 RVA: 0x0056249C File Offset: 0x0056069C
		public string Content
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

		// Token: 0x0602723F RID: 160319 RVA: 0x005624D3 File Offset: 0x005606D3
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027240 RID: 160320 RVA: 0x005624E2 File Offset: 0x005606E2
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AD40 RID: 44352
		// (get) Token: 0x06027241 RID: 160321 RVA: 0x005624F0 File Offset: 0x005606F0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027242 RID: 160322 RVA: 0x00562527 File Offset: 0x00560727
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06027243 RID: 160323 RVA: 0x00562536 File Offset: 0x00560736
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06027244 RID: 160324 RVA: 0x00562544 File Offset: 0x00560744
		public IActionInfo? OnActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD41 RID: 44353
		// (get) Token: 0x06027245 RID: 160325 RVA: 0x005625A8 File Offset: 0x005607A8
		public int OnActionsLength
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

		// Token: 0x06027246 RID: 160326 RVA: 0x005625D4 File Offset: 0x005607D4
		public IActionInfo? OffActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD42 RID: 44354
		// (get) Token: 0x06027247 RID: 160327 RVA: 0x00562638 File Offset: 0x00560838
		public int OffActionsLength
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

		// Token: 0x1700AD43 RID: 44355
		// (get) Token: 0x06027248 RID: 160328 RVA: 0x00562664 File Offset: 0x00560864
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027249 RID: 160329 RVA: 0x005626A1 File Offset: 0x005608A1
		public static Offset<ISwitcherComponent> CreateISwitcherComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ContentOffset = default(StringOffset), StringOffset IconOffset = default(StringOffset), VectorOffset OnActionsOffset = default(VectorOffset), VectorOffset OffActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			ISwitcherComponent.AddOffActions(builder, OffActionsOffset);
			ISwitcherComponent.AddOnActions(builder, OnActionsOffset);
			ISwitcherComponent.AddIcon(builder, IconOffset);
			ISwitcherComponent.AddContent(builder, ContentOffset);
			ISwitcherComponent.AddNullMask(builder, NullMask);
			ISwitcherComponent.AddDisabled(builder, Disabled);
			return ISwitcherComponent.EndISwitcherComponent(builder);
		}

		// Token: 0x0602724A RID: 160330 RVA: 0x005626DD File Offset: 0x005608DD
		public static void StartISwitcherComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602724B RID: 160331 RVA: 0x005626E6 File Offset: 0x005608E6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602724C RID: 160332 RVA: 0x005626F1 File Offset: 0x005608F1
		public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x0602724D RID: 160333 RVA: 0x00562701 File Offset: 0x00560901
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(2, iconOffset.Value, 0);
		}

		// Token: 0x0602724E RID: 160334 RVA: 0x00562711 File Offset: 0x00560911
		public static void AddOnActions(FlatBufferBuilder builder, VectorOffset onActionsOffset)
		{
			builder.AddOffset(3, onActionsOffset.Value, 0);
		}

		// Token: 0x0602724F RID: 160335 RVA: 0x00562724 File Offset: 0x00560924
		public static VectorOffset CreateOnActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027250 RID: 160336 RVA: 0x00562764 File Offset: 0x00560964
		public static VectorOffset CreateOnActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027251 RID: 160337 RVA: 0x0056277E File Offset: 0x0056097E
		public static VectorOffset CreateOnActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027252 RID: 160338 RVA: 0x0056279C File Offset: 0x0056099C
		public static VectorOffset CreateOnActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027253 RID: 160339 RVA: 0x005627B5 File Offset: 0x005609B5
		public static void StartOnActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027254 RID: 160340 RVA: 0x005627C0 File Offset: 0x005609C0
		public static void AddOffActions(FlatBufferBuilder builder, VectorOffset offActionsOffset)
		{
			builder.AddOffset(4, offActionsOffset.Value, 0);
		}

		// Token: 0x06027255 RID: 160341 RVA: 0x005627D0 File Offset: 0x005609D0
		public static VectorOffset CreateOffActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027256 RID: 160342 RVA: 0x00562810 File Offset: 0x00560A10
		public static VectorOffset CreateOffActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027257 RID: 160343 RVA: 0x0056282A File Offset: 0x00560A2A
		public static VectorOffset CreateOffActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027258 RID: 160344 RVA: 0x00562848 File Offset: 0x00560A48
		public static VectorOffset CreateOffActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027259 RID: 160345 RVA: 0x00562861 File Offset: 0x00560A61
		public static void StartOffActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602725A RID: 160346 RVA: 0x0056286C File Offset: 0x00560A6C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602725B RID: 160347 RVA: 0x00562877 File Offset: 0x00560A77
		public static Offset<ISwitcherComponent> EndISwitcherComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISwitcherComponent>(builder.EndTable());
		}

		// Token: 0x0602725C RID: 160348 RVA: 0x00562884 File Offset: 0x00560A84
		public ISwitcherComponentT UnPack()
		{
			ISwitcherComponentT switcherComponentT = new ISwitcherComponentT();
			this.UnPackTo(switcherComponentT);
			return switcherComponentT;
		}

		// Token: 0x0602725D RID: 160349 RVA: 0x005628A0 File Offset: 0x00560AA0
		public void UnPackTo(ISwitcherComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Content = this.Content;
			_o.Icon = this.Icon;
			_o.OnActions = new List<IActionInfoT>();
			for (int i = 0; i < this.OnActionsLength; i++)
			{
				_o.OnActions.Add((this.OnActions(i) != null) ? this.OnActions(i).Value.UnPack() : null);
			}
			_o.OffActions = new List<IActionInfoT>();
			for (int j = 0; j < this.OffActionsLength; j++)
			{
				_o.OffActions.Add((this.OffActions(j) != null) ? this.OffActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602725E RID: 160350 RVA: 0x00562984 File Offset: 0x00560B84
		public static Offset<ISwitcherComponent> Pack(FlatBufferBuilder builder, ISwitcherComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitcherComponent>);
			}
			StringOffset contentOffset = (_o.Content == null) ? default(StringOffset) : builder.CreateString(_o.Content);
			StringOffset iconOffset = (_o.Icon == null) ? default(StringOffset) : builder.CreateString(_o.Icon);
			VectorOffset onActionsOffset = default(VectorOffset);
			if (_o.OnActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.OnActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.OnActions[i]);
				}
				onActionsOffset = ISwitcherComponent.CreateOnActionsVector(builder, array);
			}
			VectorOffset offActionsOffset = default(VectorOffset);
			if (_o.OffActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.OffActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.OffActions[j]);
				}
				offActionsOffset = ISwitcherComponent.CreateOffActionsVector(builder, array2);
			}
			return ISwitcherComponent.CreateISwitcherComponent(builder, _o.Disabled, contentOffset, iconOffset, onActionsOffset, offActionsOffset, _o.NullMask);
		}

		// Token: 0x0400F057 RID: 61527
		private Table __p;
	}
}
