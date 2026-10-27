using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069AE RID: 27054
	public struct IInterludeActions : IFlatbufferObject
	{
		// Token: 0x1700C8AA RID: 51370
		// (get) Token: 0x0602F439 RID: 193593 RVA: 0x0067004C File Offset: 0x0066E24C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F43A RID: 193594 RVA: 0x00670059 File Offset: 0x0066E259
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F43B RID: 193595 RVA: 0x00670060 File Offset: 0x0066E260
		public static IInterludeActions GetRootAsIInterludeActions(ByteBuffer _bb)
		{
			return IInterludeActions.GetRootAsIInterludeActions(_bb, default(IInterludeActions));
		}

		// Token: 0x0602F43C RID: 193596 RVA: 0x0067007C File Offset: 0x0066E27C
		public static IInterludeActions GetRootAsIInterludeActions(ByteBuffer _bb, IInterludeActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F43D RID: 193597 RVA: 0x00670099 File Offset: 0x0066E299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F43E RID: 193598 RVA: 0x006700A8 File Offset: 0x0066E2A8
		public IInterludeActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F43F RID: 193599 RVA: 0x006700B8 File Offset: 0x0066E2B8
		public IActionInfo? InterludeActionList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C8AB RID: 51371
		// (get) Token: 0x0602F440 RID: 193600 RVA: 0x00670118 File Offset: 0x0066E318
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

		// Token: 0x0602F441 RID: 193601 RVA: 0x00670144 File Offset: 0x0066E344
		public int DestroyEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C8AC RID: 51372
		// (get) Token: 0x0602F442 RID: 193602 RVA: 0x00670184 File Offset: 0x0066E384
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

		// Token: 0x0602F443 RID: 193603 RVA: 0x006701AF File Offset: 0x0066E3AF
		public Span<int> GetDestroyEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602F444 RID: 193604 RVA: 0x006701BE File Offset: 0x0066E3BE
		public int[] GetDestroyEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700C8AD RID: 51373
		// (get) Token: 0x0602F445 RID: 193605 RVA: 0x006701CC File Offset: 0x0066E3CC
		public bool IsFadeIn
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C8AE RID: 51374
		// (get) Token: 0x0602F446 RID: 193606 RVA: 0x0067020C File Offset: 0x0066E40C
		public bool IsFadeOut
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C8AF RID: 51375
		// (get) Token: 0x0602F447 RID: 193607 RVA: 0x0067024C File Offset: 0x0066E44C
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

		// Token: 0x0602F448 RID: 193608 RVA: 0x00670289 File Offset: 0x0066E489
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

		// Token: 0x0602F449 RID: 193609 RVA: 0x006702BD File Offset: 0x0066E4BD
		public static void StartIInterludeActions(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602F44A RID: 193610 RVA: 0x006702C6 File Offset: 0x0066E4C6
		public static void AddInterludeActionList(FlatBufferBuilder builder, VectorOffset interludeActionListOffset)
		{
			builder.AddOffset(0, interludeActionListOffset.Value, 0);
		}

		// Token: 0x0602F44B RID: 193611 RVA: 0x006702D8 File Offset: 0x0066E4D8
		public static VectorOffset CreateInterludeActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F44C RID: 193612 RVA: 0x00670318 File Offset: 0x0066E518
		public static VectorOffset CreateInterludeActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F44D RID: 193613 RVA: 0x00670332 File Offset: 0x0066E532
		public static VectorOffset CreateInterludeActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F44E RID: 193614 RVA: 0x00670350 File Offset: 0x0066E550
		public static VectorOffset CreateInterludeActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F44F RID: 193615 RVA: 0x00670369 File Offset: 0x0066E569
		public static void StartInterludeActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F450 RID: 193616 RVA: 0x00670374 File Offset: 0x0066E574
		public static void AddDestroyEntityIds(FlatBufferBuilder builder, VectorOffset destroyEntityIdsOffset)
		{
			builder.AddOffset(1, destroyEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602F451 RID: 193617 RVA: 0x00670384 File Offset: 0x0066E584
		public static VectorOffset CreateDestroyEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F452 RID: 193618 RVA: 0x006703BB File Offset: 0x0066E5BB
		public static VectorOffset CreateDestroyEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F453 RID: 193619 RVA: 0x006703D5 File Offset: 0x0066E5D5
		public static VectorOffset CreateDestroyEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F454 RID: 193620 RVA: 0x006703F3 File Offset: 0x0066E5F3
		public static VectorOffset CreateDestroyEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F455 RID: 193621 RVA: 0x0067040C File Offset: 0x0066E60C
		public static void StartDestroyEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F456 RID: 193622 RVA: 0x00670417 File Offset: 0x0066E617
		public static void AddIsFadeIn(FlatBufferBuilder builder, bool isFadeIn)
		{
			builder.AddBool(2, isFadeIn, false);
		}

		// Token: 0x0602F457 RID: 193623 RVA: 0x00670422 File Offset: 0x0066E622
		public static void AddIsFadeOut(FlatBufferBuilder builder, bool isFadeOut)
		{
			builder.AddBool(3, isFadeOut, false);
		}

		// Token: 0x0602F458 RID: 193624 RVA: 0x0067042D File Offset: 0x0066E62D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602F459 RID: 193625 RVA: 0x00670438 File Offset: 0x0066E638
		public static Offset<IInterludeActions> EndIInterludeActions(FlatBufferBuilder builder)
		{
			return new Offset<IInterludeActions>(builder.EndTable());
		}

		// Token: 0x0602F45A RID: 193626 RVA: 0x00670448 File Offset: 0x0066E648
		public IInterludeActionsT UnPack()
		{
			IInterludeActionsT interludeActionsT = new IInterludeActionsT();
			this.UnPackTo(interludeActionsT);
			return interludeActionsT;
		}

		// Token: 0x0602F45B RID: 193627 RVA: 0x00670464 File Offset: 0x0066E664
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

		// Token: 0x0602F45C RID: 193628 RVA: 0x00670518 File Offset: 0x0066E718
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

		// Token: 0x04011159 RID: 69977
		private Table __p;
	}
}
