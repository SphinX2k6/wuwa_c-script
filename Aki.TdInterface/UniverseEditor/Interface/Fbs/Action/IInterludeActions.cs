using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007061 RID: 28769
	public struct IInterludeActions : IFlatbufferObject
	{
		// Token: 0x1700D2AF RID: 53935
		// (get) Token: 0x06031E15 RID: 204309 RVA: 0x006C0750 File Offset: 0x006BE950
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E16 RID: 204310 RVA: 0x006C075D File Offset: 0x006BE95D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E17 RID: 204311 RVA: 0x006C0764 File Offset: 0x006BE964
		public static IInterludeActions GetRootAsIInterludeActions(ByteBuffer _bb)
		{
			return IInterludeActions.GetRootAsIInterludeActions(_bb, default(IInterludeActions));
		}

		// Token: 0x06031E18 RID: 204312 RVA: 0x006C0780 File Offset: 0x006BE980
		public static IInterludeActions GetRootAsIInterludeActions(ByteBuffer _bb, IInterludeActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E19 RID: 204313 RVA: 0x006C079D File Offset: 0x006BE99D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E1A RID: 204314 RVA: 0x006C07AC File Offset: 0x006BE9AC
		public IInterludeActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06031E1B RID: 204315 RVA: 0x006C07BC File Offset: 0x006BE9BC
		public IActionInfo? InterludeActionList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D2B0 RID: 53936
		// (get) Token: 0x06031E1C RID: 204316 RVA: 0x006C081C File Offset: 0x006BEA1C
		public int InterludeActionListLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06031E1D RID: 204317 RVA: 0x006C0848 File Offset: 0x006BEA48
		public int DestroyEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D2B1 RID: 53937
		// (get) Token: 0x06031E1E RID: 204318 RVA: 0x006C0888 File Offset: 0x006BEA88
		public int DestroyEntityIdsLength
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

		// Token: 0x06031E1F RID: 204319 RVA: 0x006C08B3 File Offset: 0x006BEAB3
		public Span<int> GetDestroyEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031E20 RID: 204320 RVA: 0x006C08C2 File Offset: 0x006BEAC2
		public int[] GetDestroyEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D2B2 RID: 53938
		// (get) Token: 0x06031E21 RID: 204321 RVA: 0x006C08D0 File Offset: 0x006BEAD0
		public bool IsFadeIn
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D2B3 RID: 53939
		// (get) Token: 0x06031E22 RID: 204322 RVA: 0x006C0910 File Offset: 0x006BEB10
		public bool IsFadeOut
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D2B4 RID: 53940
		// (get) Token: 0x06031E23 RID: 204323 RVA: 0x006C0950 File Offset: 0x006BEB50
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

		// Token: 0x06031E24 RID: 204324 RVA: 0x006C098D File Offset: 0x006BEB8D
		public static Offset<IInterludeActions> CreateIInterludeActions(FlatBufferBuilder builder, VectorOffset InterludeActionListOffset = default(VectorOffset), VectorOffset DestroyEntityIdsOffset = default(VectorOffset), bool IsFadeIn = false, bool IsFadeOut = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IInterludeActions.AddDestroyEntityIds(builder, DestroyEntityIdsOffset);
			IInterludeActions.AddInterludeActionList(builder, InterludeActionListOffset);
			IInterludeActions.AddNullMask(builder, NullMask);
			IInterludeActions.AddIsFadeOut(builder, IsFadeOut);
			IInterludeActions.AddIsFadeIn(builder, IsFadeIn);
			return IInterludeActions.EndIInterludeActions(builder);
		}

		// Token: 0x06031E25 RID: 204325 RVA: 0x006C09C1 File Offset: 0x006BEBC1
		public static void StartIInterludeActions(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06031E26 RID: 204326 RVA: 0x006C09CA File Offset: 0x006BEBCA
		public static void AddInterludeActionList(FlatBufferBuilder builder, VectorOffset interludeActionListOffset)
		{
			builder.AddOffset(0, interludeActionListOffset.Value, 0);
		}

		// Token: 0x06031E27 RID: 204327 RVA: 0x006C09DC File Offset: 0x006BEBDC
		public static VectorOffset CreateInterludeActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031E28 RID: 204328 RVA: 0x006C0A1C File Offset: 0x006BEC1C
		public static VectorOffset CreateInterludeActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031E29 RID: 204329 RVA: 0x006C0A36 File Offset: 0x006BEC36
		public static VectorOffset CreateInterludeActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031E2A RID: 204330 RVA: 0x006C0A54 File Offset: 0x006BEC54
		public static VectorOffset CreateInterludeActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031E2B RID: 204331 RVA: 0x006C0A6D File Offset: 0x006BEC6D
		public static void StartInterludeActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031E2C RID: 204332 RVA: 0x006C0A78 File Offset: 0x006BEC78
		public static void AddDestroyEntityIds(FlatBufferBuilder builder, VectorOffset destroyEntityIdsOffset)
		{
			builder.AddOffset(1, destroyEntityIdsOffset.Value, 0);
		}

		// Token: 0x06031E2D RID: 204333 RVA: 0x006C0A88 File Offset: 0x006BEC88
		public static VectorOffset CreateDestroyEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031E2E RID: 204334 RVA: 0x006C0ABF File Offset: 0x006BECBF
		public static VectorOffset CreateDestroyEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031E2F RID: 204335 RVA: 0x006C0AD9 File Offset: 0x006BECD9
		public static VectorOffset CreateDestroyEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031E30 RID: 204336 RVA: 0x006C0AF7 File Offset: 0x006BECF7
		public static VectorOffset CreateDestroyEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031E31 RID: 204337 RVA: 0x006C0B10 File Offset: 0x006BED10
		public static void StartDestroyEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031E32 RID: 204338 RVA: 0x006C0B1B File Offset: 0x006BED1B
		public static void AddIsFadeIn(FlatBufferBuilder builder, bool isFadeIn)
		{
			builder.AddBool(2, isFadeIn, false);
		}

		// Token: 0x06031E33 RID: 204339 RVA: 0x006C0B26 File Offset: 0x006BED26
		public static void AddIsFadeOut(FlatBufferBuilder builder, bool isFadeOut)
		{
			builder.AddBool(3, isFadeOut, false);
		}

		// Token: 0x06031E34 RID: 204340 RVA: 0x006C0B31 File Offset: 0x006BED31
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06031E35 RID: 204341 RVA: 0x006C0B3C File Offset: 0x006BED3C
		public static Offset<IInterludeActions> EndIInterludeActions(FlatBufferBuilder builder)
		{
			return new Offset<IInterludeActions>(builder.EndTable());
		}

		// Token: 0x06031E36 RID: 204342 RVA: 0x006C0B4C File Offset: 0x006BED4C
		public IInterludeActionsT UnPack()
		{
			IInterludeActionsT interludeActionsT = new IInterludeActionsT();
			this.UnPackTo(interludeActionsT);
			return interludeActionsT;
		}

		// Token: 0x06031E37 RID: 204343 RVA: 0x006C0B68 File Offset: 0x006BED68
		public void UnPackTo(IInterludeActionsT _o)
		{
			_o.InterludeActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.InterludeActionListLength; i++)
			{
				_o.InterludeActionList.Add((this.InterludeActionList(i) != null) ? this.InterludeActionList(i).Value.UnPack() : null);
			}
			_o.DestroyEntityIds = new List<int>();
			for (int j = 0; j < this.DestroyEntityIdsLength; j++)
			{
				_o.DestroyEntityIds.Add(this.DestroyEntityIds(j));
			}
			_o.IsFadeIn = this.IsFadeIn;
			_o.IsFadeOut = this.IsFadeOut;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031E38 RID: 204344 RVA: 0x006C0C1C File Offset: 0x006BEE1C
		public static Offset<IInterludeActions> Pack(FlatBufferBuilder builder, IInterludeActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInterludeActions>);
			}
			VectorOffset interludeActionListOffset = default(VectorOffset);
			if (_o.InterludeActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.InterludeActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.InterludeActionList[i]);
				}
				interludeActionListOffset = IInterludeActions.CreateInterludeActionListVector(builder, array);
			}
			VectorOffset destroyEntityIdsOffset = default(VectorOffset);
			if (_o.DestroyEntityIds != null)
			{
				int[] data = _o.DestroyEntityIds.ToArray();
				destroyEntityIdsOffset = IInterludeActions.CreateDestroyEntityIdsVector(builder, data);
			}
			return IInterludeActions.CreateIInterludeActions(builder, interludeActionListOffset, destroyEntityIdsOffset, _o.IsFadeIn, _o.IsFadeOut, _o.NullMask);
		}

		// Token: 0x04011FC6 RID: 73670
		private Table __p;
	}
}
