using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C3 RID: 21699
	public struct IChessmanComponent : IFlatbufferObject
	{
		// Token: 0x17009ADC RID: 39644
		// (get) Token: 0x0602235F RID: 140127 RVA: 0x004B7278 File Offset: 0x004B5478
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022360 RID: 140128 RVA: 0x004B7285 File Offset: 0x004B5485
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022361 RID: 140129 RVA: 0x004B728C File Offset: 0x004B548C
		public static IChessmanComponent GetRootAsIChessmanComponent(ByteBuffer _bb)
		{
			return IChessmanComponent.GetRootAsIChessmanComponent(_bb, default(IChessmanComponent));
		}

		// Token: 0x06022362 RID: 140130 RVA: 0x004B72A8 File Offset: 0x004B54A8
		public static IChessmanComponent GetRootAsIChessmanComponent(ByteBuffer _bb, IChessmanComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022363 RID: 140131 RVA: 0x004B72C5 File Offset: 0x004B54C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022364 RID: 140132 RVA: 0x004B72D4 File Offset: 0x004B54D4
		public IChessmanComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009ADD RID: 39645
		// (get) Token: 0x06022365 RID: 140133 RVA: 0x004B72E4 File Offset: 0x004B54E4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022366 RID: 140134 RVA: 0x004B7324 File Offset: 0x004B5524
		public IActionInfo? StartMovingActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009ADE RID: 39646
		// (get) Token: 0x06022367 RID: 140135 RVA: 0x004B7384 File Offset: 0x004B5584
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

		// Token: 0x06022368 RID: 140136 RVA: 0x004B73B0 File Offset: 0x004B55B0
		public IActionInfo? EndMovingActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009ADF RID: 39647
		// (get) Token: 0x06022369 RID: 140137 RVA: 0x004B7410 File Offset: 0x004B5610
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

		// Token: 0x17009AE0 RID: 39648
		// (get) Token: 0x0602236A RID: 140138 RVA: 0x004B743C File Offset: 0x004B563C
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

		// Token: 0x0602236B RID: 140139 RVA: 0x004B7479 File Offset: 0x004B5679
		public static Offset<IChessmanComponent> CreateIChessmanComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset StartMovingActionsOffset = default(VectorOffset), VectorOffset EndMovingActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IChessmanComponent.AddEndMovingActions(builder, EndMovingActionsOffset);
			IChessmanComponent.AddStartMovingActions(builder, StartMovingActionsOffset);
			IChessmanComponent.AddNullMask(builder, NullMask);
			IChessmanComponent.AddDisabled(builder, Disabled);
			return IChessmanComponent.EndIChessmanComponent(builder);
		}

		// Token: 0x0602236C RID: 140140 RVA: 0x004B74A5 File Offset: 0x004B56A5
		public static void StartIChessmanComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602236D RID: 140141 RVA: 0x004B74AE File Offset: 0x004B56AE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602236E RID: 140142 RVA: 0x004B74B9 File Offset: 0x004B56B9
		public static void AddStartMovingActions(FlatBufferBuilder builder, VectorOffset startMovingActionsOffset)
		{
			builder.AddOffset(1, startMovingActionsOffset.Value, 0);
		}

		// Token: 0x0602236F RID: 140143 RVA: 0x004B74CC File Offset: 0x004B56CC
		public static VectorOffset CreateStartMovingActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022370 RID: 140144 RVA: 0x004B750C File Offset: 0x004B570C
		public static VectorOffset CreateStartMovingActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022371 RID: 140145 RVA: 0x004B7526 File Offset: 0x004B5726
		public static VectorOffset CreateStartMovingActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022372 RID: 140146 RVA: 0x004B7544 File Offset: 0x004B5744
		public static VectorOffset CreateStartMovingActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022373 RID: 140147 RVA: 0x004B755D File Offset: 0x004B575D
		public static void StartStartMovingActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022374 RID: 140148 RVA: 0x004B7568 File Offset: 0x004B5768
		public static void AddEndMovingActions(FlatBufferBuilder builder, VectorOffset endMovingActionsOffset)
		{
			builder.AddOffset(2, endMovingActionsOffset.Value, 0);
		}

		// Token: 0x06022375 RID: 140149 RVA: 0x004B7578 File Offset: 0x004B5778
		public static VectorOffset CreateEndMovingActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022376 RID: 140150 RVA: 0x004B75B8 File Offset: 0x004B57B8
		public static VectorOffset CreateEndMovingActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022377 RID: 140151 RVA: 0x004B75D2 File Offset: 0x004B57D2
		public static VectorOffset CreateEndMovingActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022378 RID: 140152 RVA: 0x004B75F0 File Offset: 0x004B57F0
		public static VectorOffset CreateEndMovingActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022379 RID: 140153 RVA: 0x004B7609 File Offset: 0x004B5809
		public static void StartEndMovingActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602237A RID: 140154 RVA: 0x004B7614 File Offset: 0x004B5814
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602237B RID: 140155 RVA: 0x004B761F File Offset: 0x004B581F
		public static Offset<IChessmanComponent> EndIChessmanComponent(FlatBufferBuilder builder)
		{
			return new Offset<IChessmanComponent>(builder.EndTable());
		}

		// Token: 0x0602237C RID: 140156 RVA: 0x004B762C File Offset: 0x004B582C
		public IChessmanComponentT UnPack()
		{
			IChessmanComponentT chessmanComponentT = new IChessmanComponentT();
			this.UnPackTo(chessmanComponentT);
			return chessmanComponentT;
		}

		// Token: 0x0602237D RID: 140157 RVA: 0x004B7648 File Offset: 0x004B5848
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

		// Token: 0x0602237E RID: 140158 RVA: 0x004B7714 File Offset: 0x004B5914
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

		// Token: 0x0400EA00 RID: 59904
		private Table __p;
	}
}
