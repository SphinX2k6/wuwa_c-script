using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E9 RID: 21993
	public struct IDestroyStageConfig : IFlatbufferObject
	{
		// Token: 0x17009D7B RID: 40315
		// (get) Token: 0x06023025 RID: 143397 RVA: 0x004D13D5 File Offset: 0x004CF5D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023026 RID: 143398 RVA: 0x004D13E2 File Offset: 0x004CF5E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023027 RID: 143399 RVA: 0x004D13EC File Offset: 0x004CF5EC
		public static IDestroyStageConfig GetRootAsIDestroyStageConfig(ByteBuffer _bb)
		{
			return IDestroyStageConfig.GetRootAsIDestroyStageConfig(_bb, default(IDestroyStageConfig));
		}

		// Token: 0x06023028 RID: 143400 RVA: 0x004D1408 File Offset: 0x004CF608
		public static IDestroyStageConfig GetRootAsIDestroyStageConfig(ByteBuffer _bb, IDestroyStageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023029 RID: 143401 RVA: 0x004D1425 File Offset: 0x004CF625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602302A RID: 143402 RVA: 0x004D1434 File Offset: 0x004CF634
		public IDestroyStageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D7C RID: 40316
		// (get) Token: 0x0602302B RID: 143403 RVA: 0x004D1444 File Offset: 0x004CF644
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

		// Token: 0x17009D7D RID: 40317
		// (get) Token: 0x0602302C RID: 143404 RVA: 0x004D1484 File Offset: 0x004CF684
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

		// Token: 0x0602302D RID: 143405 RVA: 0x004D14C4 File Offset: 0x004CF6C4
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D7E RID: 40318
		// (get) Token: 0x0602302E RID: 143406 RVA: 0x004D1524 File Offset: 0x004CF724
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

		// Token: 0x17009D7F RID: 40319
		// (get) Token: 0x0602302F RID: 143407 RVA: 0x004D1550 File Offset: 0x004CF750
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

		// Token: 0x06023030 RID: 143408 RVA: 0x004D158D File Offset: 0x004CF78D
		public static Offset<IDestroyStageConfig> CreateIDestroyStageConfig(FlatBufferBuilder builder, float PerformDuration = 0f, long BulletId = 0L, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IDestroyStageConfig.AddBulletId(builder, BulletId);
			IDestroyStageConfig.AddActions(builder, ActionsOffset);
			IDestroyStageConfig.AddPerformDuration(builder, PerformDuration);
			IDestroyStageConfig.AddNullMask(builder, NullMask);
			return IDestroyStageConfig.EndIDestroyStageConfig(builder);
		}

		// Token: 0x06023031 RID: 143409 RVA: 0x004D15B9 File Offset: 0x004CF7B9
		public static void StartIDestroyStageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023032 RID: 143410 RVA: 0x004D15C2 File Offset: 0x004CF7C2
		public static void AddPerformDuration(FlatBufferBuilder builder, float performDuration)
		{
			builder.AddFloat(0, performDuration, 0.0);
		}

		// Token: 0x06023033 RID: 143411 RVA: 0x004D15D5 File Offset: 0x004CF7D5
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06023034 RID: 143412 RVA: 0x004D15E1 File Offset: 0x004CF7E1
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06023035 RID: 143413 RVA: 0x004D15F4 File Offset: 0x004CF7F4
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023036 RID: 143414 RVA: 0x004D1634 File Offset: 0x004CF834
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023037 RID: 143415 RVA: 0x004D164E File Offset: 0x004CF84E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023038 RID: 143416 RVA: 0x004D166C File Offset: 0x004CF86C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023039 RID: 143417 RVA: 0x004D1685 File Offset: 0x004CF885
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602303A RID: 143418 RVA: 0x004D1690 File Offset: 0x004CF890
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602303B RID: 143419 RVA: 0x004D169B File Offset: 0x004CF89B
		public static Offset<IDestroyStageConfig> EndIDestroyStageConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyStageConfig>(builder.EndTable());
		}

		// Token: 0x0602303C RID: 143420 RVA: 0x004D16A8 File Offset: 0x004CF8A8
		public IDestroyStageConfigT UnPack()
		{
			IDestroyStageConfigT destroyStageConfigT = new IDestroyStageConfigT();
			this.UnPackTo(destroyStageConfigT);
			return destroyStageConfigT;
		}

		// Token: 0x0602303D RID: 143421 RVA: 0x004D16C4 File Offset: 0x004CF8C4
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

		// Token: 0x0602303E RID: 143422 RVA: 0x004D1748 File Offset: 0x004CF948
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

		// Token: 0x0400EC87 RID: 60551
		private Table __p;
	}
}
