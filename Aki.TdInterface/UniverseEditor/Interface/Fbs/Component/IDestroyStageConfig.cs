using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005084 RID: 20612
	public struct IDestroyStageConfig : IFlatbufferObject
	{
		// Token: 0x1700958E RID: 38286
		// (get) Token: 0x060210D1 RID: 135377 RVA: 0x00497491 File Offset: 0x00495691
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060210D2 RID: 135378 RVA: 0x0049749E File Offset: 0x0049569E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060210D3 RID: 135379 RVA: 0x004974A8 File Offset: 0x004956A8
		public static IDestroyStageConfig GetRootAsIDestroyStageConfig(ByteBuffer _bb)
		{
			return IDestroyStageConfig.GetRootAsIDestroyStageConfig(_bb, default(IDestroyStageConfig));
		}

		// Token: 0x060210D4 RID: 135380 RVA: 0x004974C4 File Offset: 0x004956C4
		public static IDestroyStageConfig GetRootAsIDestroyStageConfig(ByteBuffer _bb, IDestroyStageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060210D5 RID: 135381 RVA: 0x004974E1 File Offset: 0x004956E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060210D6 RID: 135382 RVA: 0x004974F0 File Offset: 0x004956F0
		public IDestroyStageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700958F RID: 38287
		// (get) Token: 0x060210D7 RID: 135383 RVA: 0x00497500 File Offset: 0x00495700
		public float PerformDuration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009590 RID: 38288
		// (get) Token: 0x060210D8 RID: 135384 RVA: 0x00497540 File Offset: 0x00495740
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060210D9 RID: 135385 RVA: 0x00497580 File Offset: 0x00495780
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009591 RID: 38289
		// (get) Token: 0x060210DA RID: 135386 RVA: 0x004975E0 File Offset: 0x004957E0
		public int ActionsLength
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

		// Token: 0x17009592 RID: 38290
		// (get) Token: 0x060210DB RID: 135387 RVA: 0x0049760C File Offset: 0x0049580C
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

		// Token: 0x060210DC RID: 135388 RVA: 0x00497649 File Offset: 0x00495849
		public static Offset<IDestroyStageConfig> CreateIDestroyStageConfig(FlatBufferBuilder builder, float PerformDuration = 0f, long BulletId = 0L, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IDestroyStageConfig.AddBulletId(builder, BulletId);
			IDestroyStageConfig.AddActions(builder, ActionsOffset);
			IDestroyStageConfig.AddPerformDuration(builder, PerformDuration);
			IDestroyStageConfig.AddNullMask(builder, NullMask);
			return IDestroyStageConfig.EndIDestroyStageConfig(builder);
		}

		// Token: 0x060210DD RID: 135389 RVA: 0x00497675 File Offset: 0x00495875
		public static void StartIDestroyStageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060210DE RID: 135390 RVA: 0x0049767E File Offset: 0x0049587E
		public static void AddPerformDuration(FlatBufferBuilder builder, float performDuration)
		{
			builder.AddFloat(0, performDuration, 0.0);
		}

		// Token: 0x060210DF RID: 135391 RVA: 0x00497691 File Offset: 0x00495891
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x060210E0 RID: 135392 RVA: 0x0049769D File Offset: 0x0049589D
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x060210E1 RID: 135393 RVA: 0x004976B0 File Offset: 0x004958B0
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060210E2 RID: 135394 RVA: 0x004976F0 File Offset: 0x004958F0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060210E3 RID: 135395 RVA: 0x0049770A File Offset: 0x0049590A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060210E4 RID: 135396 RVA: 0x00497728 File Offset: 0x00495928
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060210E5 RID: 135397 RVA: 0x00497741 File Offset: 0x00495941
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060210E6 RID: 135398 RVA: 0x0049774C File Offset: 0x0049594C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060210E7 RID: 135399 RVA: 0x00497757 File Offset: 0x00495957
		public static Offset<IDestroyStageConfig> EndIDestroyStageConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyStageConfig>(builder.EndTable());
		}

		// Token: 0x060210E8 RID: 135400 RVA: 0x00497764 File Offset: 0x00495964
		public IDestroyStageConfigT UnPack()
		{
			IDestroyStageConfigT destroyStageConfigT = new IDestroyStageConfigT();
			this.UnPackTo(destroyStageConfigT);
			return destroyStageConfigT;
		}

		// Token: 0x060210E9 RID: 135401 RVA: 0x00497780 File Offset: 0x00495980
		public void UnPackTo(IDestroyStageConfigT _o)
		{
			_o.PerformDuration = this.PerformDuration;
			_o.BulletId = this.BulletId;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060210EA RID: 135402 RVA: 0x00497804 File Offset: 0x00495A04
		public static Offset<IDestroyStageConfig> Pack(FlatBufferBuilder builder, IDestroyStageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyStageConfig>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IDestroyStageConfig.CreateActionsVector(builder, array);
			}
			return IDestroyStageConfig.CreateIDestroyStageConfig(builder, _o.PerformDuration, _o.BulletId, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400E08A RID: 57482
		private Table __p;
	}
}
