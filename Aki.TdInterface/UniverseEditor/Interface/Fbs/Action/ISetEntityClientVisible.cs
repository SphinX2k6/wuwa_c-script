using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FDD RID: 28637
	public struct ISetEntityClientVisible : IFlatbufferObject
	{
		// Token: 0x1700D49C RID: 54428
		// (get) Token: 0x060329F8 RID: 207352 RVA: 0x006D4884 File Offset: 0x006D2A84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060329F9 RID: 207353 RVA: 0x006D4891 File Offset: 0x006D2A91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060329FA RID: 207354 RVA: 0x006D4898 File Offset: 0x006D2A98
		public static ISetEntityClientVisible GetRootAsISetEntityClientVisible(ByteBuffer _bb)
		{
			return ISetEntityClientVisible.GetRootAsISetEntityClientVisible(_bb, default(ISetEntityClientVisible));
		}

		// Token: 0x060329FB RID: 207355 RVA: 0x006D48B4 File Offset: 0x006D2AB4
		public static ISetEntityClientVisible GetRootAsISetEntityClientVisible(ByteBuffer _bb, ISetEntityClientVisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060329FC RID: 207356 RVA: 0x006D48D1 File Offset: 0x006D2AD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060329FD RID: 207357 RVA: 0x006D48E0 File Offset: 0x006D2AE0
		public ISetEntityClientVisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060329FE RID: 207358 RVA: 0x006D48F0 File Offset: 0x006D2AF0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D49D RID: 54429
		// (get) Token: 0x060329FF RID: 207359 RVA: 0x006D4930 File Offset: 0x006D2B30
		public int EntityIdsLength
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

		// Token: 0x06032A00 RID: 207360 RVA: 0x006D495B File Offset: 0x006D2B5B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06032A01 RID: 207361 RVA: 0x006D496A File Offset: 0x006D2B6A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700D49E RID: 54430
		// (get) Token: 0x06032A02 RID: 207362 RVA: 0x006D4978 File Offset: 0x006D2B78
		public bool Visible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06032A03 RID: 207363 RVA: 0x006D49B7 File Offset: 0x006D2BB7
		public static Offset<ISetEntityClientVisible> CreateISetEntityClientVisible(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool Visible = false)
		{
			builder.StartTable(2);
			ISetEntityClientVisible.AddEntityIds(builder, EntityIdsOffset);
			ISetEntityClientVisible.AddVisible(builder, Visible);
			return ISetEntityClientVisible.EndISetEntityClientVisible(builder);
		}

		// Token: 0x06032A04 RID: 207364 RVA: 0x006D49D4 File Offset: 0x006D2BD4
		public static void StartISetEntityClientVisible(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032A05 RID: 207365 RVA: 0x006D49DD File Offset: 0x006D2BDD
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06032A06 RID: 207366 RVA: 0x006D49F0 File Offset: 0x006D2BF0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032A07 RID: 207367 RVA: 0x006D4A27 File Offset: 0x006D2C27
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032A08 RID: 207368 RVA: 0x006D4A41 File Offset: 0x006D2C41
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032A09 RID: 207369 RVA: 0x006D4A5F File Offset: 0x006D2C5F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032A0A RID: 207370 RVA: 0x006D4A78 File Offset: 0x006D2C78
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032A0B RID: 207371 RVA: 0x006D4A83 File Offset: 0x006D2C83
		public static void AddVisible(FlatBufferBuilder builder, bool visible)
		{
			builder.AddBool(1, visible, false);
		}

		// Token: 0x06032A0C RID: 207372 RVA: 0x006D4A8E File Offset: 0x006D2C8E
		public static Offset<ISetEntityClientVisible> EndISetEntityClientVisible(FlatBufferBuilder builder)
		{
			return new Offset<ISetEntityClientVisible>(builder.EndTable());
		}

		// Token: 0x06032A0D RID: 207373 RVA: 0x006D4A9C File Offset: 0x006D2C9C
		public ISetEntityClientVisibleT UnPack()
		{
			ISetEntityClientVisibleT setEntityClientVisibleT = new ISetEntityClientVisibleT();
			this.UnPackTo(setEntityClientVisibleT);
			return setEntityClientVisibleT;
		}

		// Token: 0x06032A0E RID: 207374 RVA: 0x006D4AB8 File Offset: 0x006D2CB8
		public void UnPackTo(ISetEntityClientVisibleT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.Visible = this.Visible;
		}

		// Token: 0x06032A0F RID: 207375 RVA: 0x006D4B00 File Offset: 0x006D2D00
		public static Offset<ISetEntityClientVisible> Pack(FlatBufferBuilder builder, ISetEntityClientVisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetEntityClientVisible>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ISetEntityClientVisible.CreateEntityIdsVector(builder, data);
			}
			return ISetEntityClientVisible.CreateISetEntityClientVisible(builder, entityIdsOffset, _o.Visible);
		}

		// Token: 0x040119EB RID: 72171
		private Table __p;
	}
}
