using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F08 RID: 28424
	public struct IFunction : IFlatbufferObject
	{
		// Token: 0x1700D071 RID: 53361
		// (get) Token: 0x060312F7 RID: 201463 RVA: 0x006AA71E File Offset: 0x006A891E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060312F8 RID: 201464 RVA: 0x006AA72B File Offset: 0x006A892B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060312F9 RID: 201465 RVA: 0x006AA734 File Offset: 0x006A8934
		public static IFunction GetRootAsIFunction(ByteBuffer _bb)
		{
			return IFunction.GetRootAsIFunction(_bb, default(IFunction));
		}

		// Token: 0x060312FA RID: 201466 RVA: 0x006AA750 File Offset: 0x006A8950
		public static IFunction GetRootAsIFunction(ByteBuffer _bb, IFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060312FB RID: 201467 RVA: 0x006AA76D File Offset: 0x006A896D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060312FC RID: 201468 RVA: 0x006AA77C File Offset: 0x006A897C
		public IFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D072 RID: 53362
		// (get) Token: 0x060312FD RID: 201469 RVA: 0x006AA78C File Offset: 0x006A898C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060312FE RID: 201470 RVA: 0x006AA7C3 File Offset: 0x006A89C3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060312FF RID: 201471 RVA: 0x006AA7D2 File Offset: 0x006A89D2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06031300 RID: 201472 RVA: 0x006AA7E0 File Offset: 0x006A89E0
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D073 RID: 53363
		// (get) Token: 0x06031301 RID: 201473 RVA: 0x006AA840 File Offset: 0x006A8A40
		public int ActionsLength
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

		// Token: 0x06031302 RID: 201474 RVA: 0x006AA86B File Offset: 0x006A8A6B
		public static Offset<IFunction> CreateIFunction(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFunction.AddActions(builder, ActionsOffset);
			IFunction.AddName(builder, NameOffset);
			return IFunction.EndIFunction(builder);
		}

		// Token: 0x06031303 RID: 201475 RVA: 0x006AA888 File Offset: 0x006A8A88
		public static void StartIFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031304 RID: 201476 RVA: 0x006AA891 File Offset: 0x006A8A91
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x06031305 RID: 201477 RVA: 0x006AA8A1 File Offset: 0x006A8AA1
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06031306 RID: 201478 RVA: 0x006AA8B4 File Offset: 0x006A8AB4
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031307 RID: 201479 RVA: 0x006AA8F4 File Offset: 0x006A8AF4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031308 RID: 201480 RVA: 0x006AA90E File Offset: 0x006A8B0E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031309 RID: 201481 RVA: 0x006AA92C File Offset: 0x006A8B2C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603130A RID: 201482 RVA: 0x006AA945 File Offset: 0x006A8B45
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603130B RID: 201483 RVA: 0x006AA950 File Offset: 0x006A8B50
		public static Offset<IFunction> EndIFunction(FlatBufferBuilder builder)
		{
			return new Offset<IFunction>(builder.EndTable());
		}

		// Token: 0x0603130C RID: 201484 RVA: 0x006AA960 File Offset: 0x006A8B60
		public IFunctionT UnPack()
		{
			IFunctionT functionT = new IFunctionT();
			this.UnPackTo(functionT);
			return functionT;
		}

		// Token: 0x0603130D RID: 201485 RVA: 0x006AA97C File Offset: 0x006A8B7C
		public void UnPackTo(IFunctionT _o)
		{
			_o.Name = this.Name;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0603130E RID: 201486 RVA: 0x006AA9E8 File Offset: 0x006A8BE8
		public static Offset<IFunction> Pack(FlatBufferBuilder builder, IFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFunction>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IFunction.CreateActionsVector(builder, array);
			}
			return IFunction.CreateIFunction(builder, nameOffset, actionsOffset);
		}

		// Token: 0x04011E0E RID: 73230
		private Table __p;
	}
}
