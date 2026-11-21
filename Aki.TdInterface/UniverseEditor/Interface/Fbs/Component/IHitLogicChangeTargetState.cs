using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005924 RID: 22820
	public struct IHitLogicChangeTargetState : IFlatbufferObject
	{
		// Token: 0x1700A57E RID: 42366
		// (get) Token: 0x06025198 RID: 151960 RVA: 0x0051762D File Offset: 0x0051582D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025199 RID: 151961 RVA: 0x0051763A File Offset: 0x0051583A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602519A RID: 151962 RVA: 0x00517644 File Offset: 0x00515844
		public static IHitLogicChangeTargetState GetRootAsIHitLogicChangeTargetState(ByteBuffer _bb)
		{
			return IHitLogicChangeTargetState.GetRootAsIHitLogicChangeTargetState(_bb, default(IHitLogicChangeTargetState));
		}

		// Token: 0x0602519B RID: 151963 RVA: 0x00517660 File Offset: 0x00515860
		public static IHitLogicChangeTargetState GetRootAsIHitLogicChangeTargetState(ByteBuffer _bb, IHitLogicChangeTargetState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602519C RID: 151964 RVA: 0x0051767D File Offset: 0x0051587D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602519D RID: 151965 RVA: 0x0051768C File Offset: 0x0051588C
		public IHitLogicChangeTargetState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A57F RID: 42367
		// (get) Token: 0x0602519E RID: 151966 RVA: 0x0051769C File Offset: 0x0051589C
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

		// Token: 0x0602519F RID: 151967 RVA: 0x005176D8 File Offset: 0x005158D8
		public IConditionHitConfigWithBullet? TargetBulletHitConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConditionHitConfigWithBullet?(default(IConditionHitConfigWithBullet).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A580 RID: 42368
		// (get) Token: 0x060251A0 RID: 151968 RVA: 0x00517738 File Offset: 0x00515938
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

		// Token: 0x060251A1 RID: 151969 RVA: 0x00517764 File Offset: 0x00515964
		public IConditionHitConfig? OtherBulletsHitConfig(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IConditionHitConfig?(default(IConditionHitConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A581 RID: 42369
		// (get) Token: 0x060251A2 RID: 151970 RVA: 0x005177C4 File Offset: 0x005159C4
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

		// Token: 0x060251A3 RID: 151971 RVA: 0x005177EF File Offset: 0x005159EF
		public static Offset<IHitLogicChangeTargetState> CreateIHitLogicChangeTargetState(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState, VectorOffset TargetBulletHitConfigsOffset = default(VectorOffset), VectorOffset OtherBulletsHitConfigOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IHitLogicChangeTargetState.AddOtherBulletsHitConfig(builder, OtherBulletsHitConfigOffset);
			IHitLogicChangeTargetState.AddTargetBulletHitConfigs(builder, TargetBulletHitConfigsOffset);
			IHitLogicChangeTargetState.AddType(builder, Type);
			return IHitLogicChangeTargetState.EndIHitLogicChangeTargetState(builder);
		}

		// Token: 0x060251A4 RID: 151972 RVA: 0x00517813 File Offset: 0x00515A13
		public static void StartIHitLogicChangeTargetState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060251A5 RID: 151973 RVA: 0x0051781C File Offset: 0x00515A1C
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060251A6 RID: 151974 RVA: 0x00517827 File Offset: 0x00515A27
		public static void AddTargetBulletHitConfigs(FlatBufferBuilder builder, VectorOffset targetBulletHitConfigsOffset)
		{
			builder.AddOffset(1, targetBulletHitConfigsOffset.Value, 0);
		}

		// Token: 0x060251A7 RID: 151975 RVA: 0x00517838 File Offset: 0x00515A38
		public static VectorOffset CreateTargetBulletHitConfigsVector(FlatBufferBuilder builder, Offset<IConditionHitConfigWithBullet>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060251A8 RID: 151976 RVA: 0x00517878 File Offset: 0x00515A78
		public static VectorOffset CreateTargetBulletHitConfigsVectorBlock(FlatBufferBuilder builder, Offset<IConditionHitConfigWithBullet>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionHitConfigWithBullet>>(data);
			return builder.EndVector();
		}

		// Token: 0x060251A9 RID: 151977 RVA: 0x00517892 File Offset: 0x00515A92
		public static VectorOffset CreateTargetBulletHitConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionHitConfigWithBullet>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionHitConfigWithBullet>>(data);
			return builder.EndVector();
		}

		// Token: 0x060251AA RID: 151978 RVA: 0x005178B0 File Offset: 0x00515AB0
		public static VectorOffset CreateTargetBulletHitConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionHitConfigWithBullet>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060251AB RID: 151979 RVA: 0x005178C9 File Offset: 0x00515AC9
		public static void StartTargetBulletHitConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060251AC RID: 151980 RVA: 0x005178D4 File Offset: 0x00515AD4
		public static void AddOtherBulletsHitConfig(FlatBufferBuilder builder, VectorOffset otherBulletsHitConfigOffset)
		{
			builder.AddOffset(2, otherBulletsHitConfigOffset.Value, 0);
		}

		// Token: 0x060251AD RID: 151981 RVA: 0x005178E4 File Offset: 0x00515AE4
		public static VectorOffset CreateOtherBulletsHitConfigVector(FlatBufferBuilder builder, Offset<IConditionHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060251AE RID: 151982 RVA: 0x00517924 File Offset: 0x00515B24
		public static VectorOffset CreateOtherBulletsHitConfigVectorBlock(FlatBufferBuilder builder, Offset<IConditionHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060251AF RID: 151983 RVA: 0x0051793E File Offset: 0x00515B3E
		public static VectorOffset CreateOtherBulletsHitConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionHitConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060251B0 RID: 151984 RVA: 0x0051795C File Offset: 0x00515B5C
		public static VectorOffset CreateOtherBulletsHitConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionHitConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060251B1 RID: 151985 RVA: 0x00517975 File Offset: 0x00515B75
		public static void StartOtherBulletsHitConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060251B2 RID: 151986 RVA: 0x00517980 File Offset: 0x00515B80
		public static Offset<IHitLogicChangeTargetState> EndIHitLogicChangeTargetState(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeTargetState>(builder.EndTable());
		}

		// Token: 0x060251B3 RID: 151987 RVA: 0x00517990 File Offset: 0x00515B90
		public IHitLogicChangeTargetStateT UnPack()
		{
			IHitLogicChangeTargetStateT hitLogicChangeTargetStateT = new IHitLogicChangeTargetStateT();
			this.UnPackTo(hitLogicChangeTargetStateT);
			return hitLogicChangeTargetStateT;
		}

		// Token: 0x060251B4 RID: 151988 RVA: 0x005179AC File Offset: 0x00515BAC
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

		// Token: 0x060251B5 RID: 151989 RVA: 0x00517A6C File Offset: 0x00515C6C
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

		// Token: 0x0400F1B7 RID: 61879
		private Table __p;
	}
}
