using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200685E RID: 26718
	public struct IFoxPushBox : IFlatbufferObject
	{
		// Token: 0x1700C672 RID: 50802
		// (get) Token: 0x0602E963 RID: 190819 RVA: 0x0065AD5C File Offset: 0x00658F5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E964 RID: 190820 RVA: 0x0065AD69 File Offset: 0x00658F69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E965 RID: 190821 RVA: 0x0065AD70 File Offset: 0x00658F70
		public static IFoxPushBox GetRootAsIFoxPushBox(ByteBuffer _bb)
		{
			return IFoxPushBox.GetRootAsIFoxPushBox(_bb, default(IFoxPushBox));
		}

		// Token: 0x0602E966 RID: 190822 RVA: 0x0065AD8C File Offset: 0x00658F8C
		public static IFoxPushBox GetRootAsIFoxPushBox(ByteBuffer _bb, IFoxPushBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E967 RID: 190823 RVA: 0x0065ADA9 File Offset: 0x00658FA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E968 RID: 190824 RVA: 0x0065ADB8 File Offset: 0x00658FB8
		public IFoxPushBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C673 RID: 50803
		// (get) Token: 0x0602E969 RID: 190825 RVA: 0x0065ADC8 File Offset: 0x00658FC8
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C674 RID: 50804
		// (get) Token: 0x0602E96A RID: 190826 RVA: 0x0065AE04 File Offset: 0x00659004
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

		// Token: 0x1700C675 RID: 50805
		// (get) Token: 0x0602E96B RID: 190827 RVA: 0x0065AE40 File Offset: 0x00659040
		public int CollisionRadius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C676 RID: 50806
		// (get) Token: 0x0602E96C RID: 190828 RVA: 0x0065AE7C File Offset: 0x0065907C
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C677 RID: 50807
		// (get) Token: 0x0602E96D RID: 190829 RVA: 0x0065AEBC File Offset: 0x006590BC
		public string SendEntityEventOnSplineFinish
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E96E RID: 190830 RVA: 0x0065AEF4 File Offset: 0x006590F4
		public Span<byte> GetSendEntityEventOnSplineFinishBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602E96F RID: 190831 RVA: 0x0065AF04 File Offset: 0x00659104
		public byte[] GetSendEntityEventOnSplineFinishArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0602E970 RID: 190832 RVA: 0x0065AF13 File Offset: 0x00659113
		public static Offset<IFoxPushBox> CreateIFoxPushBox(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int EntityId = 0, int CollisionRadius = 0, int SplineEntityId = 0, StringOffset SendEntityEventOnSplineFinishOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IFoxPushBox.AddSendEntityEventOnSplineFinish(builder, SendEntityEventOnSplineFinishOffset);
			IFoxPushBox.AddSplineEntityId(builder, SplineEntityId);
			IFoxPushBox.AddCollisionRadius(builder, CollisionRadius);
			IFoxPushBox.AddEntityId(builder, EntityId);
			IFoxPushBox.AddType(builder, Type);
			return IFoxPushBox.EndIFoxPushBox(builder);
		}

		// Token: 0x0602E971 RID: 190833 RVA: 0x0065AF47 File Offset: 0x00659147
		public static void StartIFoxPushBox(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602E972 RID: 190834 RVA: 0x0065AF50 File Offset: 0x00659150
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E973 RID: 190835 RVA: 0x0065AF5B File Offset: 0x0065915B
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602E974 RID: 190836 RVA: 0x0065AF66 File Offset: 0x00659166
		public static void AddCollisionRadius(FlatBufferBuilder builder, int collisionRadius)
		{
			builder.AddInt(2, collisionRadius, 0);
		}

		// Token: 0x0602E975 RID: 190837 RVA: 0x0065AF71 File Offset: 0x00659171
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x0602E976 RID: 190838 RVA: 0x0065AF7C File Offset: 0x0065917C
		public static void AddSendEntityEventOnSplineFinish(FlatBufferBuilder builder, StringOffset sendEntityEventOnSplineFinishOffset)
		{
			builder.AddOffset(4, sendEntityEventOnSplineFinishOffset.Value, 0);
		}

		// Token: 0x0602E977 RID: 190839 RVA: 0x0065AF8C File Offset: 0x0065918C
		public static Offset<IFoxPushBox> EndIFoxPushBox(FlatBufferBuilder builder)
		{
			return new Offset<IFoxPushBox>(builder.EndTable());
		}

		// Token: 0x0602E978 RID: 190840 RVA: 0x0065AF9C File Offset: 0x0065919C
		public IFoxPushBoxT UnPack()
		{
			IFoxPushBoxT foxPushBoxT = new IFoxPushBoxT();
			this.UnPackTo(foxPushBoxT);
			return foxPushBoxT;
		}

		// Token: 0x0602E979 RID: 190841 RVA: 0x0065AFB7 File Offset: 0x006591B7
		public void UnPackTo(IFoxPushBoxT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.CollisionRadius = this.CollisionRadius;
			_o.SplineEntityId = this.SplineEntityId;
			_o.SendEntityEventOnSplineFinish = this.SendEntityEventOnSplineFinish;
		}

		// Token: 0x0602E97A RID: 190842 RVA: 0x0065AFF8 File Offset: 0x006591F8
		public static Offset<IFoxPushBox> Pack(FlatBufferBuilder builder, IFoxPushBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxPushBox>);
			}
			StringOffset sendEntityEventOnSplineFinishOffset = (_o.SendEntityEventOnSplineFinish == null) ? default(StringOffset) : builder.CreateString(_o.SendEntityEventOnSplineFinish);
			return IFoxPushBox.CreateIFoxPushBox(builder, _o.Type, _o.EntityId, _o.CollisionRadius, _o.SplineEntityId, sendEntityEventOnSplineFinishOffset);
		}

		// Token: 0x04010FAB RID: 69547
		private Table __p;
	}
}
