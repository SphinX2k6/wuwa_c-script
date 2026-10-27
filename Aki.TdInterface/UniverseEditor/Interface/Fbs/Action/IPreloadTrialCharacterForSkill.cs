using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA1 RID: 28065
	public struct IPreloadTrialCharacterForSkill : IFlatbufferObject
	{
		// Token: 0x1700D155 RID: 53589
		// (get) Token: 0x0603193F RID: 203071 RVA: 0x006B810D File Offset: 0x006B630D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031940 RID: 203072 RVA: 0x006B811A File Offset: 0x006B631A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031941 RID: 203073 RVA: 0x006B8124 File Offset: 0x006B6324
		public static IPreloadTrialCharacterForSkill GetRootAsIPreloadTrialCharacterForSkill(ByteBuffer _bb)
		{
			return IPreloadTrialCharacterForSkill.GetRootAsIPreloadTrialCharacterForSkill(_bb, default(IPreloadTrialCharacterForSkill));
		}

		// Token: 0x06031942 RID: 203074 RVA: 0x006B8140 File Offset: 0x006B6340
		public static IPreloadTrialCharacterForSkill GetRootAsIPreloadTrialCharacterForSkill(ByteBuffer _bb, IPreloadTrialCharacterForSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031943 RID: 203075 RVA: 0x006B815D File Offset: 0x006B635D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031944 RID: 203076 RVA: 0x006B816C File Offset: 0x006B636C
		public IPreloadTrialCharacterForSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D156 RID: 53590
		// (get) Token: 0x06031945 RID: 203077 RVA: 0x006B817C File Offset: 0x006B637C
		public EPreloadObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return (EPreloadObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031946 RID: 203078 RVA: 0x006B81B8 File Offset: 0x006B63B8
		public ICharacterGroupNew? CharacterGroupNew(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICharacterGroupNew?(default(ICharacterGroupNew).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D157 RID: 53591
		// (get) Token: 0x06031947 RID: 203079 RVA: 0x006B8218 File Offset: 0x006B6418
		public int CharacterGroupNewLength
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

		// Token: 0x06031948 RID: 203080 RVA: 0x006B8243 File Offset: 0x006B6443
		public static Offset<IPreloadTrialCharacterForSkill> CreateIPreloadTrialCharacterForSkill(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill, VectorOffset CharacterGroupNewOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPreloadTrialCharacterForSkill.AddCharacterGroupNew(builder, CharacterGroupNewOffset);
			IPreloadTrialCharacterForSkill.AddType(builder, Type);
			return IPreloadTrialCharacterForSkill.EndIPreloadTrialCharacterForSkill(builder);
		}

		// Token: 0x06031949 RID: 203081 RVA: 0x006B8260 File Offset: 0x006B6460
		public static void StartIPreloadTrialCharacterForSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603194A RID: 203082 RVA: 0x006B8269 File Offset: 0x006B6469
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603194B RID: 203083 RVA: 0x006B8274 File Offset: 0x006B6474
		public static void AddCharacterGroupNew(FlatBufferBuilder builder, VectorOffset characterGroupNewOffset)
		{
			builder.AddOffset(1, characterGroupNewOffset.Value, 0);
		}

		// Token: 0x0603194C RID: 203084 RVA: 0x006B8284 File Offset: 0x006B6484
		public static VectorOffset CreateCharacterGroupNewVector(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603194D RID: 203085 RVA: 0x006B82C4 File Offset: 0x006B64C4
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603194E RID: 203086 RVA: 0x006B82DE File Offset: 0x006B64DE
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICharacterGroupNew>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603194F RID: 203087 RVA: 0x006B82FC File Offset: 0x006B64FC
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICharacterGroupNew>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031950 RID: 203088 RVA: 0x006B8315 File Offset: 0x006B6515
		public static void StartCharacterGroupNewVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031951 RID: 203089 RVA: 0x006B8320 File Offset: 0x006B6520
		public static Offset<IPreloadTrialCharacterForSkill> EndIPreloadTrialCharacterForSkill(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadTrialCharacterForSkill>(builder.EndTable());
		}

		// Token: 0x06031952 RID: 203090 RVA: 0x006B8330 File Offset: 0x006B6530
		public IPreloadTrialCharacterForSkillT UnPack()
		{
			IPreloadTrialCharacterForSkillT preloadTrialCharacterForSkillT = new IPreloadTrialCharacterForSkillT();
			this.UnPackTo(preloadTrialCharacterForSkillT);
			return preloadTrialCharacterForSkillT;
		}

		// Token: 0x06031953 RID: 203091 RVA: 0x006B834C File Offset: 0x006B654C
		public void UnPackTo(IPreloadTrialCharacterForSkillT _o)
		{
			_o.Type = this.Type;
			_o.CharacterGroupNew = new List<ICharacterGroupNewT>();
			for (int i = 0; i < this.CharacterGroupNewLength; i++)
			{
				_o.CharacterGroupNew.Add((this.CharacterGroupNew(i) != null) ? this.CharacterGroupNew(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06031954 RID: 203092 RVA: 0x006B83B8 File Offset: 0x006B65B8
		public static Offset<IPreloadTrialCharacterForSkill> Pack(FlatBufferBuilder builder, IPreloadTrialCharacterForSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadTrialCharacterForSkill>);
			}
			VectorOffset characterGroupNewOffset = default(VectorOffset);
			if (_o.CharacterGroupNew != null)
			{
				Offset<ICharacterGroupNew>[] array = new Offset<ICharacterGroupNew>[_o.CharacterGroupNew.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICharacterGroupNew.Pack(builder, _o.CharacterGroupNew[i]);
				}
				characterGroupNewOffset = IPreloadTrialCharacterForSkill.CreateCharacterGroupNewVector(builder, array);
			}
			return IPreloadTrialCharacterForSkill.CreateIPreloadTrialCharacterForSkill(builder, _o.Type, characterGroupNewOffset);
		}

		// Token: 0x04011774 RID: 71540
		private Table __p;
	}
}
