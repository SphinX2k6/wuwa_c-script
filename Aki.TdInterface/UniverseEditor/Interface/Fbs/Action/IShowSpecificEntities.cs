using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078B4 RID: 30900
	public struct IShowSpecificEntities : IFlatbufferObject
	{
		// Token: 0x1700E2AC RID: 58028
		// (get) Token: 0x060365FD RID: 222717 RVA: 0x00747900 File Offset: 0x00745B00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060365FE RID: 222718 RVA: 0x0074790D File Offset: 0x00745B0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060365FF RID: 222719 RVA: 0x00747914 File Offset: 0x00745B14
		public static IShowSpecificEntities GetRootAsIShowSpecificEntities(ByteBuffer _bb)
		{
			return IShowSpecificEntities.GetRootAsIShowSpecificEntities(_bb, default(IShowSpecificEntities));
		}

		// Token: 0x06036600 RID: 222720 RVA: 0x00747930 File Offset: 0x00745B30
		public static IShowSpecificEntities GetRootAsIShowSpecificEntities(ByteBuffer _bb, IShowSpecificEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036601 RID: 222721 RVA: 0x0074794D File Offset: 0x00745B4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036602 RID: 222722 RVA: 0x0074795C File Offset: 0x00745B5C
		public IShowSpecificEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06036603 RID: 222723 RVA: 0x0074796C File Offset: 0x00745B6C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E2AD RID: 58029
		// (get) Token: 0x06036604 RID: 222724 RVA: 0x007479AC File Offset: 0x00745BAC
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

		// Token: 0x06036605 RID: 222725 RVA: 0x007479D7 File Offset: 0x00745BD7
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06036606 RID: 222726 RVA: 0x007479E6 File Offset: 0x00745BE6
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700E2AE RID: 58030
		// (get) Token: 0x06036607 RID: 222727 RVA: 0x007479F4 File Offset: 0x00745BF4
		public bool DelayShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06036608 RID: 222728 RVA: 0x00747A33 File Offset: 0x00745C33
		public static Offset<IShowSpecificEntities> CreateIShowSpecificEntities(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool DelayShow = false)
		{
			builder.StartTable(2);
			IShowSpecificEntities.AddEntityIds(builder, EntityIdsOffset);
			IShowSpecificEntities.AddDelayShow(builder, DelayShow);
			return IShowSpecificEntities.EndIShowSpecificEntities(builder);
		}

		// Token: 0x06036609 RID: 222729 RVA: 0x00747A50 File Offset: 0x00745C50
		public static void StartIShowSpecificEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603660A RID: 222730 RVA: 0x00747A59 File Offset: 0x00745C59
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0603660B RID: 222731 RVA: 0x00747A6C File Offset: 0x00745C6C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603660C RID: 222732 RVA: 0x00747AA3 File Offset: 0x00745CA3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603660D RID: 222733 RVA: 0x00747ABD File Offset: 0x00745CBD
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603660E RID: 222734 RVA: 0x00747ADB File Offset: 0x00745CDB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603660F RID: 222735 RVA: 0x00747AF4 File Offset: 0x00745CF4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036610 RID: 222736 RVA: 0x00747AFF File Offset: 0x00745CFF
		public static void AddDelayShow(FlatBufferBuilder builder, bool delayShow)
		{
			builder.AddBool(1, delayShow, false);
		}

		// Token: 0x06036611 RID: 222737 RVA: 0x00747B0A File Offset: 0x00745D0A
		public static Offset<IShowSpecificEntities> EndIShowSpecificEntities(FlatBufferBuilder builder)
		{
			return new Offset<IShowSpecificEntities>(builder.EndTable());
		}

		// Token: 0x06036612 RID: 222738 RVA: 0x00747B18 File Offset: 0x00745D18
		public IShowSpecificEntitiesT UnPack()
		{
			IShowSpecificEntitiesT showSpecificEntitiesT = new IShowSpecificEntitiesT();
			this.UnPackTo(showSpecificEntitiesT);
			return showSpecificEntitiesT;
		}

		// Token: 0x06036613 RID: 222739 RVA: 0x00747B34 File Offset: 0x00745D34
		public void UnPackTo(IShowSpecificEntitiesT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.DelayShow = this.DelayShow;
		}

		// Token: 0x06036614 RID: 222740 RVA: 0x00747B7C File Offset: 0x00745D7C
		public static Offset<IShowSpecificEntities> Pack(FlatBufferBuilder builder, IShowSpecificEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowSpecificEntities>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IShowSpecificEntities.CreateEntityIdsVector(builder, data);
			}
			return IShowSpecificEntities.CreateIShowSpecificEntities(builder, entityIdsOffset, _o.DelayShow);
		}

		// Token: 0x04012B52 RID: 76626
		private Table __p;
	}
}
