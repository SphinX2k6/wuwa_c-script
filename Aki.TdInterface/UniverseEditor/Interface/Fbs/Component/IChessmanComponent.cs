using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F94 RID: 20372
	public struct IChessmanComponent : IFlatbufferObject
	{
		// Token: 0x17009363 RID: 37731
		// (get) Token: 0x0602060D RID: 132621 RVA: 0x00481288 File Offset: 0x0047F488
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602060E RID: 132622 RVA: 0x00481295 File Offset: 0x0047F495
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602060F RID: 132623 RVA: 0x0048129C File Offset: 0x0047F49C
		public static IChessmanComponent GetRootAsIChessmanComponent(ByteBuffer _bb)
		{
			return IChessmanComponent.GetRootAsIChessmanComponent(_bb, default(IChessmanComponent));
		}

		// Token: 0x06020610 RID: 132624 RVA: 0x004812B8 File Offset: 0x0047F4B8
		public static IChessmanComponent GetRootAsIChessmanComponent(ByteBuffer _bb, IChessmanComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020611 RID: 132625 RVA: 0x004812D5 File Offset: 0x0047F4D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020612 RID: 132626 RVA: 0x004812E4 File Offset: 0x0047F4E4
		public IChessmanComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009364 RID: 37732
		// (get) Token: 0x06020613 RID: 132627 RVA: 0x004812F4 File Offset: 0x0047F4F4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06020614 RID: 132628 RVA: 0x00481334 File Offset: 0x0047F534
		public IActionInfo? StartMovingActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009365 RID: 37733
		// (get) Token: 0x06020615 RID: 132629 RVA: 0x00481394 File Offset: 0x0047F594
		public int StartMovingActionsLength
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

		// Token: 0x06020616 RID: 132630 RVA: 0x004813C0 File Offset: 0x0047F5C0
		public IActionInfo? EndMovingActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009366 RID: 37734
		// (get) Token: 0x06020617 RID: 132631 RVA: 0x00481420 File Offset: 0x0047F620
		public int EndMovingActionsLength
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

		// Token: 0x17009367 RID: 37735
		// (get) Token: 0x06020618 RID: 132632 RVA: 0x0048144C File Offset: 0x0047F64C
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

		// Token: 0x06020619 RID: 132633 RVA: 0x00481489 File Offset: 0x0047F689
		public static Offset<IChessmanComponent> CreateIChessmanComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset StartMovingActionsOffset = default(VectorOffset), VectorOffset EndMovingActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IChessmanComponent.AddEndMovingActions(builder, EndMovingActionsOffset);
			IChessmanComponent.AddStartMovingActions(builder, StartMovingActionsOffset);
			IChessmanComponent.AddNullMask(builder, NullMask);
			IChessmanComponent.AddDisabled(builder, Disabled);
			return IChessmanComponent.EndIChessmanComponent(builder);
		}

		// Token: 0x0602061A RID: 132634 RVA: 0x004814B5 File Offset: 0x0047F6B5
		public static void StartIChessmanComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602061B RID: 132635 RVA: 0x004814BE File Offset: 0x0047F6BE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602061C RID: 132636 RVA: 0x004814C9 File Offset: 0x0047F6C9
		public static void AddStartMovingActions(FlatBufferBuilder builder, VectorOffset startMovingActionsOffset)
		{
			builder.AddOffset(1, startMovingActionsOffset.Value, 0);
		}

		// Token: 0x0602061D RID: 132637 RVA: 0x004814DC File Offset: 0x0047F6DC
		public static VectorOffset CreateStartMovingActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602061E RID: 132638 RVA: 0x0048151C File Offset: 0x0047F71C
		public static VectorOffset CreateStartMovingActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602061F RID: 132639 RVA: 0x00481536 File Offset: 0x0047F736
		public static VectorOffset CreateStartMovingActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020620 RID: 132640 RVA: 0x00481554 File Offset: 0x0047F754
		public static VectorOffset CreateStartMovingActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020621 RID: 132641 RVA: 0x0048156D File Offset: 0x0047F76D
		public static void StartStartMovingActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020622 RID: 132642 RVA: 0x00481578 File Offset: 0x0047F778
		public static void AddEndMovingActions(FlatBufferBuilder builder, VectorOffset endMovingActionsOffset)
		{
			builder.AddOffset(2, endMovingActionsOffset.Value, 0);
		}

		// Token: 0x06020623 RID: 132643 RVA: 0x00481588 File Offset: 0x0047F788
		public static VectorOffset CreateEndMovingActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020624 RID: 132644 RVA: 0x004815C8 File Offset: 0x0047F7C8
		public static VectorOffset CreateEndMovingActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020625 RID: 132645 RVA: 0x004815E2 File Offset: 0x0047F7E2
		public static VectorOffset CreateEndMovingActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020626 RID: 132646 RVA: 0x00481600 File Offset: 0x0047F800
		public static VectorOffset CreateEndMovingActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020627 RID: 132647 RVA: 0x00481619 File Offset: 0x0047F819
		public static void StartEndMovingActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020628 RID: 132648 RVA: 0x00481624 File Offset: 0x0047F824
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06020629 RID: 132649 RVA: 0x0048162F File Offset: 0x0047F82F
		public static Offset<IChessmanComponent> EndIChessmanComponent(FlatBufferBuilder builder)
		{
			return new Offset<IChessmanComponent>(builder.EndTable());
		}

		// Token: 0x0602062A RID: 132650 RVA: 0x0048163C File Offset: 0x0047F83C
		public IChessmanComponentT UnPack()
		{
			IChessmanComponentT chessmanComponentT = new IChessmanComponentT();
			this.UnPackTo(chessmanComponentT);
			return chessmanComponentT;
		}

		// Token: 0x0602062B RID: 132651 RVA: 0x00481658 File Offset: 0x0047F858
		public void UnPackTo(IChessmanComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.StartMovingActions = new List<IActionInfoT>();
			for (int i = 0; i < this.StartMovingActionsLength; i++)
			{
				_o.StartMovingActions.Add((this.StartMovingActions(i) != null) ? this.StartMovingActions(i).Value.UnPack() : null);
			}
			_o.EndMovingActions = new List<IActionInfoT>();
			for (int j = 0; j < this.EndMovingActionsLength; j++)
			{
				_o.EndMovingActions.Add((this.EndMovingActions(j) != null) ? this.EndMovingActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602062C RID: 132652 RVA: 0x00481724 File Offset: 0x0047F924
		public static Offset<IChessmanComponent> Pack(FlatBufferBuilder builder, IChessmanComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChessmanComponent>);
			}
			VectorOffset startMovingActionsOffset = default(VectorOffset);
			if (_o.StartMovingActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.StartMovingActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.StartMovingActions[i]);
				}
				startMovingActionsOffset = IChessmanComponent.CreateStartMovingActionsVector(builder, array);
			}
			VectorOffset endMovingActionsOffset = default(VectorOffset);
			if (_o.EndMovingActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.EndMovingActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.EndMovingActions[j]);
				}
				endMovingActionsOffset = IChessmanComponent.CreateEndMovingActionsVector(builder, array2);
			}
			return IChessmanComponent.CreateIChessmanComponent(builder, _o.Disabled, startMovingActionsOffset, endMovingActionsOffset, _o.NullMask);
		}

		// Token: 0x0400DE56 RID: 56918
		private Table __p;
	}
}
