using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539E RID: 21406
	public struct IHitLogicChangeTargetState : IFlatbufferObject
	{
		// Token: 0x17009D46 RID: 40262
		// (get) Token: 0x060230E4 RID: 143588 RVA: 0x004DA759 File Offset: 0x004D8959
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060230E5 RID: 143589 RVA: 0x004DA766 File Offset: 0x004D8966
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060230E6 RID: 143590 RVA: 0x004DA770 File Offset: 0x004D8970
		public static IHitLogicChangeTargetState GetRootAsIHitLogicChangeTargetState(ByteBuffer _bb)
		{
			return IHitLogicChangeTargetState.GetRootAsIHitLogicChangeTargetState(_bb, default(IHitLogicChangeTargetState));
		}

		// Token: 0x060230E7 RID: 143591 RVA: 0x004DA78C File Offset: 0x004D898C
		public static IHitLogicChangeTargetState GetRootAsIHitLogicChangeTargetState(ByteBuffer _bb, IHitLogicChangeTargetState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060230E8 RID: 143592 RVA: 0x004DA7A9 File Offset: 0x004D89A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060230E9 RID: 143593 RVA: 0x004DA7B8 File Offset: 0x004D89B8
		public IHitLogicChangeTargetState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D47 RID: 40263
		// (get) Token: 0x060230EA RID: 143594 RVA: 0x004DA7C8 File Offset: 0x004D89C8
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060230EB RID: 143595 RVA: 0x004DA804 File Offset: 0x004D8A04
		public IConditionHitConfigWithBullet? TargetBulletHitConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConditionHitConfigWithBullet?(default(IConditionHitConfigWithBullet).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D48 RID: 40264
		// (get) Token: 0x060230EC RID: 143596 RVA: 0x004DA864 File Offset: 0x004D8A64
		public int TargetBulletHitConfigsLength
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

		// Token: 0x060230ED RID: 143597 RVA: 0x004DA890 File Offset: 0x004D8A90
		public IConditionHitConfig? OtherBulletsHitConfig(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IConditionHitConfig?(default(IConditionHitConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D49 RID: 40265
		// (get) Token: 0x060230EE RID: 143598 RVA: 0x004DA8F0 File Offset: 0x004D8AF0
		public int OtherBulletsHitConfigLength
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

		// Token: 0x060230EF RID: 143599 RVA: 0x004DA91B File Offset: 0x004D8B1B
		public static Offset<IHitLogicChangeTargetState> CreateIHitLogicChangeTargetState(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState, VectorOffset TargetBulletHitConfigsOffset = default(VectorOffset), VectorOffset OtherBulletsHitConfigOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IHitLogicChangeTargetState.AddOtherBulletsHitConfig(builder, OtherBulletsHitConfigOffset);
			IHitLogicChangeTargetState.AddTargetBulletHitConfigs(builder, TargetBulletHitConfigsOffset);
			IHitLogicChangeTargetState.AddType(builder, Type);
			return IHitLogicChangeTargetState.EndIHitLogicChangeTargetState(builder);
		}

		// Token: 0x060230F0 RID: 143600 RVA: 0x004DA93F File Offset: 0x004D8B3F
		public static void StartIHitLogicChangeTargetState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060230F1 RID: 143601 RVA: 0x004DA948 File Offset: 0x004D8B48
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060230F2 RID: 143602 RVA: 0x004DA953 File Offset: 0x004D8B53
		public static void AddTargetBulletHitConfigs(FlatBufferBuilder builder, VectorOffset targetBulletHitConfigsOffset)
		{
			builder.AddOffset(1, targetBulletHitConfigsOffset.Value, 0);
		}

		// Token: 0x060230F3 RID: 143603 RVA: 0x004DA964 File Offset: 0x004D8B64
		public static VectorOffset CreateTargetBulletHitConfigsVector(FlatBufferBuilder builder, Offset<IConditionHitConfigWithBullet>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060230F4 RID: 143604 RVA: 0x004DA9A4 File Offset: 0x004D8BA4
		public static VectorOffset CreateTargetBulletHitConfigsVectorBlock(FlatBufferBuilder builder, Offset<IConditionHitConfigWithBullet>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionHitConfigWithBullet>>(data);
			return builder.EndVector();
		}

		// Token: 0x060230F5 RID: 143605 RVA: 0x004DA9BE File Offset: 0x004D8BBE
		public static VectorOffset CreateTargetBulletHitConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionHitConfigWithBullet>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionHitConfigWithBullet>>(data);
			return builder.EndVector();
		}

		// Token: 0x060230F6 RID: 143606 RVA: 0x004DA9DC File Offset: 0x004D8BDC
		public static VectorOffset CreateTargetBulletHitConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionHitConfigWithBullet>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060230F7 RID: 143607 RVA: 0x004DA9F5 File Offset: 0x004D8BF5
		public static void StartTargetBulletHitConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060230F8 RID: 143608 RVA: 0x004DAA00 File Offset: 0x004D8C00
		public static void AddOtherBulletsHitConfig(FlatBufferBuilder builder, VectorOffset otherBulletsHitConfigOffset)
		{
			builder.AddOffset(2, otherBulletsHitConfigOffset.Value, 0);
		}

		// Token: 0x060230F9 RID: 143609 RVA: 0x004DAA10 File Offset: 0x004D8C10
		public static VectorOffset CreateOtherBulletsHitConfigVector(FlatBufferBuilder builder, Offset<IConditionHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060230FA RID: 143610 RVA: 0x004DAA50 File Offset: 0x004D8C50
		public static VectorOffset CreateOtherBulletsHitConfigVectorBlock(FlatBufferBuilder builder, Offset<IConditionHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060230FB RID: 143611 RVA: 0x004DAA6A File Offset: 0x004D8C6A
		public static VectorOffset CreateOtherBulletsHitConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionHitConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060230FC RID: 143612 RVA: 0x004DAA88 File Offset: 0x004D8C88
		public static VectorOffset CreateOtherBulletsHitConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionHitConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060230FD RID: 143613 RVA: 0x004DAAA1 File Offset: 0x004D8CA1
		public static void StartOtherBulletsHitConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060230FE RID: 143614 RVA: 0x004DAAAC File Offset: 0x004D8CAC
		public static Offset<IHitLogicChangeTargetState> EndIHitLogicChangeTargetState(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeTargetState>(builder.EndTable());
		}

		// Token: 0x060230FF RID: 143615 RVA: 0x004DAABC File Offset: 0x004D8CBC
		public IHitLogicChangeTargetStateT UnPack()
		{
			IHitLogicChangeTargetStateT hitLogicChangeTargetStateT = new IHitLogicChangeTargetStateT();
			this.UnPackTo(hitLogicChangeTargetStateT);
			return hitLogicChangeTargetStateT;
		}

		// Token: 0x06023100 RID: 143616 RVA: 0x004DAAD8 File Offset: 0x004D8CD8
		public void UnPackTo(IHitLogicChangeTargetStateT _o)
		{
			_o.Type = this.Type;
			_o.TargetBulletHitConfigs = new List<IConditionHitConfigWithBulletT>();
			for (int i = 0; i < this.TargetBulletHitConfigsLength; i++)
			{
				_o.TargetBulletHitConfigs.Add((this.TargetBulletHitConfigs(i) != null) ? this.TargetBulletHitConfigs(i).Value.UnPack() : null);
			}
			_o.OtherBulletsHitConfig = new List<IConditionHitConfigT>();
			for (int j = 0; j < this.OtherBulletsHitConfigLength; j++)
			{
				_o.OtherBulletsHitConfig.Add((this.OtherBulletsHitConfig(j) != null) ? this.OtherBulletsHitConfig(j).Value.UnPack() : null);
			}
		}

		// Token: 0x06023101 RID: 143617 RVA: 0x004DAB98 File Offset: 0x004D8D98
		public static Offset<IHitLogicChangeTargetState> Pack(FlatBufferBuilder builder, IHitLogicChangeTargetStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeTargetState>);
			}
			VectorOffset targetBulletHitConfigsOffset = default(VectorOffset);
			if (_o.TargetBulletHitConfigs != null)
			{
				Offset<IConditionHitConfigWithBullet>[] array = new Offset<IConditionHitConfigWithBullet>[_o.TargetBulletHitConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionHitConfigWithBullet.Pack(builder, _o.TargetBulletHitConfigs[i]);
				}
				targetBulletHitConfigsOffset = IHitLogicChangeTargetState.CreateTargetBulletHitConfigsVector(builder, array);
			}
			VectorOffset otherBulletsHitConfigOffset = default(VectorOffset);
			if (_o.OtherBulletsHitConfig != null)
			{
				Offset<IConditionHitConfig>[] array2 = new Offset<IConditionHitConfig>[_o.OtherBulletsHitConfig.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IConditionHitConfig.Pack(builder, _o.OtherBulletsHitConfig[j]);
				}
				otherBulletsHitConfigOffset = IHitLogicChangeTargetState.CreateOtherBulletsHitConfigVector(builder, array2);
			}
			return IHitLogicChangeTargetState.CreateIHitLogicChangeTargetState(builder, _o.Type, targetBulletHitConfigsOffset, otherBulletsHitConfigOffset);
		}

		// Token: 0x0400E587 RID: 58759
		private Table __p;
	}
}
