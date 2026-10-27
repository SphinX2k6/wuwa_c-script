using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBE RID: 23486
	public struct IWuWaGoInteractStateAction : IFlatbufferObject
	{
		// Token: 0x1700B170 RID: 45424
		// (get) Token: 0x0602837F RID: 164735 RVA: 0x00586A5C File Offset: 0x00584C5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028380 RID: 164736 RVA: 0x00586A69 File Offset: 0x00584C69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028381 RID: 164737 RVA: 0x00586A70 File Offset: 0x00584C70
		public static IWuWaGoInteractStateAction GetRootAsIWuWaGoInteractStateAction(ByteBuffer _bb)
		{
			return IWuWaGoInteractStateAction.GetRootAsIWuWaGoInteractStateAction(_bb, default(IWuWaGoInteractStateAction));
		}

		// Token: 0x06028382 RID: 164738 RVA: 0x00586A8C File Offset: 0x00584C8C
		public static IWuWaGoInteractStateAction GetRootAsIWuWaGoInteractStateAction(ByteBuffer _bb, IWuWaGoInteractStateAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028383 RID: 164739 RVA: 0x00586AA9 File Offset: 0x00584CA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028384 RID: 164740 RVA: 0x00586AB8 File Offset: 0x00584CB8
		public IWuWaGoInteractStateAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B171 RID: 45425
		// (get) Token: 0x06028385 RID: 164741 RVA: 0x00586AC8 File Offset: 0x00584CC8
		public string EntityState
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

		// Token: 0x06028386 RID: 164742 RVA: 0x00586AFF File Offset: 0x00584CFF
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028387 RID: 164743 RVA: 0x00586B0E File Offset: 0x00584D0E
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06028388 RID: 164744 RVA: 0x00586B1C File Offset: 0x00584D1C
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B172 RID: 45426
		// (get) Token: 0x06028389 RID: 164745 RVA: 0x00586B7C File Offset: 0x00584D7C
		public int ActionListLength
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

		// Token: 0x0602838A RID: 164746 RVA: 0x00586BA7 File Offset: 0x00584DA7
		public static Offset<IWuWaGoInteractStateAction> CreateIWuWaGoInteractStateAction(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), VectorOffset ActionListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IWuWaGoInteractStateAction.AddActionList(builder, ActionListOffset);
			IWuWaGoInteractStateAction.AddEntityState(builder, EntityStateOffset);
			return IWuWaGoInteractStateAction.EndIWuWaGoInteractStateAction(builder);
		}

		// Token: 0x0602838B RID: 164747 RVA: 0x00586BC4 File Offset: 0x00584DC4
		public static void StartIWuWaGoInteractStateAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602838C RID: 164748 RVA: 0x00586BCD File Offset: 0x00584DCD
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x0602838D RID: 164749 RVA: 0x00586BDD File Offset: 0x00584DDD
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(1, actionListOffset.Value, 0);
		}

		// Token: 0x0602838E RID: 164750 RVA: 0x00586BF0 File Offset: 0x00584DF0
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602838F RID: 164751 RVA: 0x00586C30 File Offset: 0x00584E30
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028390 RID: 164752 RVA: 0x00586C4A File Offset: 0x00584E4A
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028391 RID: 164753 RVA: 0x00586C68 File Offset: 0x00584E68
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028392 RID: 164754 RVA: 0x00586C81 File Offset: 0x00584E81
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028393 RID: 164755 RVA: 0x00586C8C File Offset: 0x00584E8C
		public static Offset<IWuWaGoInteractStateAction> EndIWuWaGoInteractStateAction(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoInteractStateAction>(builder.EndTable());
		}

		// Token: 0x06028394 RID: 164756 RVA: 0x00586C9C File Offset: 0x00584E9C
		public IWuWaGoInteractStateActionT UnPack()
		{
			IWuWaGoInteractStateActionT wuWaGoInteractStateActionT = new IWuWaGoInteractStateActionT();
			this.UnPackTo(wuWaGoInteractStateActionT);
			return wuWaGoInteractStateActionT;
		}

		// Token: 0x06028395 RID: 164757 RVA: 0x00586CB8 File Offset: 0x00584EB8
		public void UnPackTo(IWuWaGoInteractStateActionT _o)
		{
			_o.EntityState = this.EntityState;
			_o.ActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionListLength; i++)
			{
				_o.ActionList.Add((this.ActionList(i) != null) ? this.ActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028396 RID: 164758 RVA: 0x00586D24 File Offset: 0x00584F24
		public static Offset<IWuWaGoInteractStateAction> Pack(FlatBufferBuilder builder, IWuWaGoInteractStateActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoInteractStateAction>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			VectorOffset actionListOffset = default(VectorOffset);
			if (_o.ActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActionList[i]);
				}
				actionListOffset = IWuWaGoInteractStateAction.CreateActionListVector(builder, array);
			}
			return IWuWaGoInteractStateAction.CreateIWuWaGoInteractStateAction(builder, entityStateOffset, actionListOffset);
		}

		// Token: 0x0400F336 RID: 62262
		private Table __p;
	}
}
