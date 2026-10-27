using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A09 RID: 18953
	public struct ICheckEntityIsVisibility : IFlatbufferObject
	{
		// Token: 0x1700892B RID: 35115
		// (get) Token: 0x0601DA42 RID: 121410 RVA: 0x0042BE6A File Offset: 0x0042A06A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DA43 RID: 121411 RVA: 0x0042BE77 File Offset: 0x0042A077
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DA44 RID: 121412 RVA: 0x0042BE80 File Offset: 0x0042A080
		public static ICheckEntityIsVisibility GetRootAsICheckEntityIsVisibility(ByteBuffer _bb)
		{
			return ICheckEntityIsVisibility.GetRootAsICheckEntityIsVisibility(_bb, default(ICheckEntityIsVisibility));
		}

		// Token: 0x0601DA45 RID: 121413 RVA: 0x0042BE9C File Offset: 0x0042A09C
		public static ICheckEntityIsVisibility GetRootAsICheckEntityIsVisibility(ByteBuffer _bb, ICheckEntityIsVisibility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DA46 RID: 121414 RVA: 0x0042BEB9 File Offset: 0x0042A0B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DA47 RID: 121415 RVA: 0x0042BEC8 File Offset: 0x0042A0C8
		public ICheckEntityIsVisibility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700892C RID: 35116
		// (get) Token: 0x0601DA48 RID: 121416 RVA: 0x0042BED8 File Offset: 0x0042A0D8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700892D RID: 35117
		// (get) Token: 0x0601DA49 RID: 121417 RVA: 0x0042BF14 File Offset: 0x0042A114
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700892E RID: 35118
		// (get) Token: 0x0601DA4A RID: 121418 RVA: 0x0042BF50 File Offset: 0x0042A150
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DA4B RID: 121419 RVA: 0x0042BF8F File Offset: 0x0042A18F
		public static Offset<ICheckEntityIsVisibility> CreateICheckEntityIsVisibility(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, bool IsVisible = false)
		{
			builder.StartTable(3);
			ICheckEntityIsVisibility.AddEntityId(builder, EntityId);
			ICheckEntityIsVisibility.AddIsVisible(builder, IsVisible);
			ICheckEntityIsVisibility.AddType(builder, Type);
			return ICheckEntityIsVisibility.EndICheckEntityIsVisibility(builder);
		}

		// Token: 0x0601DA4C RID: 121420 RVA: 0x0042BFB3 File Offset: 0x0042A1B3
		public static void StartICheckEntityIsVisibility(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DA4D RID: 121421 RVA: 0x0042BFBC File Offset: 0x0042A1BC
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DA4E RID: 121422 RVA: 0x0042BFC7 File Offset: 0x0042A1C7
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601DA4F RID: 121423 RVA: 0x0042BFD2 File Offset: 0x0042A1D2
		public static void AddIsVisible(FlatBufferBuilder builder, bool isVisible)
		{
			builder.AddBool(2, isVisible, false);
		}

		// Token: 0x0601DA50 RID: 121424 RVA: 0x0042BFDD File Offset: 0x0042A1DD
		public static Offset<ICheckEntityIsVisibility> EndICheckEntityIsVisibility(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityIsVisibility>(builder.EndTable());
		}

		// Token: 0x0601DA51 RID: 121425 RVA: 0x0042BFEC File Offset: 0x0042A1EC
		public ICheckEntityIsVisibilityT UnPack()
		{
			ICheckEntityIsVisibilityT checkEntityIsVisibilityT = new ICheckEntityIsVisibilityT();
			this.UnPackTo(checkEntityIsVisibilityT);
			return checkEntityIsVisibilityT;
		}

		// Token: 0x0601DA52 RID: 121426 RVA: 0x0042C007 File Offset: 0x0042A207
		public void UnPackTo(ICheckEntityIsVisibilityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.IsVisible = this.IsVisible;
		}

		// Token: 0x0601DA53 RID: 121427 RVA: 0x0042C030 File Offset: 0x0042A230
		public static Offset<ICheckEntityIsVisibility> Pack(FlatBufferBuilder builder, ICheckEntityIsVisibilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityIsVisibility>);
			}
			return ICheckEntityIsVisibility.CreateICheckEntityIsVisibility(builder, _o.Type, _o.EntityId, _o.IsVisible);
		}

		// Token: 0x0400D24F RID: 53839
		private Table __p;
	}
}
