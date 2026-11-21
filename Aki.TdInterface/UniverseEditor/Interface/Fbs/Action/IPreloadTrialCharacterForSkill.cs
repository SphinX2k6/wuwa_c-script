using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751C RID: 29980
	public struct IPreloadTrialCharacterForSkill : IFlatbufferObject
	{
		// Token: 0x1700DC9D RID: 56477
		// (get) Token: 0x0603493B RID: 215355 RVA: 0x007137F5 File Offset: 0x007119F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603493C RID: 215356 RVA: 0x00713802 File Offset: 0x00711A02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603493D RID: 215357 RVA: 0x0071380C File Offset: 0x00711A0C
		public static IPreloadTrialCharacterForSkill GetRootAsIPreloadTrialCharacterForSkill(ByteBuffer _bb)
		{
			return IPreloadTrialCharacterForSkill.GetRootAsIPreloadTrialCharacterForSkill(_bb, default(IPreloadTrialCharacterForSkill));
		}

		// Token: 0x0603493E RID: 215358 RVA: 0x00713828 File Offset: 0x00711A28
		public static IPreloadTrialCharacterForSkill GetRootAsIPreloadTrialCharacterForSkill(ByteBuffer _bb, IPreloadTrialCharacterForSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603493F RID: 215359 RVA: 0x00713845 File Offset: 0x00711A45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034940 RID: 215360 RVA: 0x00713854 File Offset: 0x00711A54
		public IPreloadTrialCharacterForSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC9E RID: 56478
		// (get) Token: 0x06034941 RID: 215361 RVA: 0x00713864 File Offset: 0x00711A64
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

		// Token: 0x06034942 RID: 215362 RVA: 0x007138A0 File Offset: 0x00711AA0
		public ICharacterGroupNew? CharacterGroupNew(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICharacterGroupNew?(default(ICharacterGroupNew).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC9F RID: 56479
		// (get) Token: 0x06034943 RID: 215363 RVA: 0x00713900 File Offset: 0x00711B00
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

		// Token: 0x06034944 RID: 215364 RVA: 0x0071392B File Offset: 0x00711B2B
		public static Offset<IPreloadTrialCharacterForSkill> CreateIPreloadTrialCharacterForSkill(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill, VectorOffset CharacterGroupNewOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPreloadTrialCharacterForSkill.AddCharacterGroupNew(builder, CharacterGroupNewOffset);
			IPreloadTrialCharacterForSkill.AddType(builder, Type);
			return IPreloadTrialCharacterForSkill.EndIPreloadTrialCharacterForSkill(builder);
		}

		// Token: 0x06034945 RID: 215365 RVA: 0x00713948 File Offset: 0x00711B48
		public static void StartIPreloadTrialCharacterForSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034946 RID: 215366 RVA: 0x00713951 File Offset: 0x00711B51
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034947 RID: 215367 RVA: 0x0071395C File Offset: 0x00711B5C
		public static void AddCharacterGroupNew(FlatBufferBuilder builder, VectorOffset characterGroupNewOffset)
		{
			builder.AddOffset(1, characterGroupNewOffset.Value, 0);
		}

		// Token: 0x06034948 RID: 215368 RVA: 0x0071396C File Offset: 0x00711B6C
		public static VectorOffset CreateCharacterGroupNewVector(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034949 RID: 215369 RVA: 0x007139AC File Offset: 0x00711BAC
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, Offset<ICharacterGroupNew>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603494A RID: 215370 RVA: 0x007139C6 File Offset: 0x00711BC6
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICharacterGroupNew>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICharacterGroupNew>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603494B RID: 215371 RVA: 0x007139E4 File Offset: 0x00711BE4
		public static VectorOffset CreateCharacterGroupNewVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICharacterGroupNew>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603494C RID: 215372 RVA: 0x007139FD File Offset: 0x00711BFD
		public static void StartCharacterGroupNewVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603494D RID: 215373 RVA: 0x00713A08 File Offset: 0x00711C08
		public static Offset<IPreloadTrialCharacterForSkill> EndIPreloadTrialCharacterForSkill(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadTrialCharacterForSkill>(builder.EndTable());
		}

		// Token: 0x0603494E RID: 215374 RVA: 0x00713A18 File Offset: 0x00711C18
		public IPreloadTrialCharacterForSkillT UnPack()
		{
			IPreloadTrialCharacterForSkillT preloadTrialCharacterForSkillT = new IPreloadTrialCharacterForSkillT();
			this.UnPackTo(preloadTrialCharacterForSkillT);
			return preloadTrialCharacterForSkillT;
		}

		// Token: 0x0603494F RID: 215375 RVA: 0x00713A34 File Offset: 0x00711C34
		public void UnPackTo(IPreloadTrialCharacterForSkillT _o)
		{
			_o.Type = this.Type;
			_o.CharacterGroupNew = new List<ICharacterGroupNewT>();
			for (int i = 0; i < this.CharacterGroupNewLength; i++)
			{
				_o.CharacterGroupNew.Add((this.CharacterGroupNew(i) != null) ? this.CharacterGroupNew(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06034950 RID: 215376 RVA: 0x00713AA0 File Offset: 0x00711CA0
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

		// Token: 0x040126F0 RID: 75504
		private Table __p;
	}
}
