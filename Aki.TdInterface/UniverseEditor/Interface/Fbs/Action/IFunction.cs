using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006867 RID: 26727
	public struct IFunction : IFlatbufferObject
	{
		// Token: 0x1700C68B RID: 50827
		// (get) Token: 0x0602E9BD RID: 190909 RVA: 0x0065B6A0 File Offset: 0x006598A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E9BE RID: 190910 RVA: 0x0065B6AD File Offset: 0x006598AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E9BF RID: 190911 RVA: 0x0065B6B4 File Offset: 0x006598B4
		public static IFunction GetRootAsIFunction(ByteBuffer _bb)
		{
			return IFunction.GetRootAsIFunction(_bb, default(IFunction));
		}

		// Token: 0x0602E9C0 RID: 190912 RVA: 0x0065B6D0 File Offset: 0x006598D0
		public static IFunction GetRootAsIFunction(ByteBuffer _bb, IFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E9C1 RID: 190913 RVA: 0x0065B6ED File Offset: 0x006598ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E9C2 RID: 190914 RVA: 0x0065B6FC File Offset: 0x006598FC
		public IFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C68C RID: 50828
		// (get) Token: 0x0602E9C3 RID: 190915 RVA: 0x0065B70C File Offset: 0x0065990C
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

		// Token: 0x0602E9C4 RID: 190916 RVA: 0x0065B743 File Offset: 0x00659943
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E9C5 RID: 190917 RVA: 0x0065B752 File Offset: 0x00659952
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602E9C6 RID: 190918 RVA: 0x0065B760 File Offset: 0x00659960
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C68D RID: 50829
		// (get) Token: 0x0602E9C7 RID: 190919 RVA: 0x0065B7C0 File Offset: 0x006599C0
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

		// Token: 0x0602E9C8 RID: 190920 RVA: 0x0065B7EB File Offset: 0x006599EB
		public static Offset<IFunction> CreateIFunction(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFunction.AddActions(builder, ActionsOffset);
			IFunction.AddName(builder, NameOffset);
			return IFunction.EndIFunction(builder);
		}

		// Token: 0x0602E9C9 RID: 190921 RVA: 0x0065B808 File Offset: 0x00659A08
		public static void StartIFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E9CA RID: 190922 RVA: 0x0065B811 File Offset: 0x00659A11
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x0602E9CB RID: 190923 RVA: 0x0065B821 File Offset: 0x00659A21
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x0602E9CC RID: 190924 RVA: 0x0065B834 File Offset: 0x00659A34
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E9CD RID: 190925 RVA: 0x0065B874 File Offset: 0x00659A74
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E9CE RID: 190926 RVA: 0x0065B88E File Offset: 0x00659A8E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E9CF RID: 190927 RVA: 0x0065B8AC File Offset: 0x00659AAC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E9D0 RID: 190928 RVA: 0x0065B8C5 File Offset: 0x00659AC5
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E9D1 RID: 190929 RVA: 0x0065B8D0 File Offset: 0x00659AD0
		public static Offset<IFunction> EndIFunction(FlatBufferBuilder builder)
		{
			return new Offset<IFunction>(builder.EndTable());
		}

		// Token: 0x0602E9D2 RID: 190930 RVA: 0x0065B8E0 File Offset: 0x00659AE0
		public IFunctionT UnPack()
		{
			IFunctionT functionT = new IFunctionT();
			this.UnPackTo(functionT);
			return functionT;
		}

		// Token: 0x0602E9D3 RID: 190931 RVA: 0x0065B8FC File Offset: 0x00659AFC
		public void UnPackTo(IFunctionT _o)
		{
			_o.Name = this.Name;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602E9D4 RID: 190932 RVA: 0x0065B968 File Offset: 0x00659B68
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

		// Token: 0x04010FB9 RID: 69561
		private Table __p;
	}
}
