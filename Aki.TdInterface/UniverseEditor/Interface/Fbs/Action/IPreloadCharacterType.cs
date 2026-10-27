using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D8C RID: 28044
	public struct IPreloadCharacterType : IFlatbufferObject
	{
		// Token: 0x1700D137 RID: 53559
		// (get) Token: 0x0603189F RID: 202911 RVA: 0x006B7079 File Offset: 0x006B5279
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060318A0 RID: 202912 RVA: 0x006B7086 File Offset: 0x006B5286
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060318A1 RID: 202913 RVA: 0x006B7090 File Offset: 0x006B5290
		public static IPreloadCharacterType GetRootAsIPreloadCharacterType(ByteBuffer _bb)
		{
			return IPreloadCharacterType.GetRootAsIPreloadCharacterType(_bb, default(IPreloadCharacterType));
		}

		// Token: 0x060318A2 RID: 202914 RVA: 0x006B70AC File Offset: 0x006B52AC
		public static IPreloadCharacterType GetRootAsIPreloadCharacterType(ByteBuffer _bb, IPreloadCharacterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060318A3 RID: 202915 RVA: 0x006B70C9 File Offset: 0x006B52C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060318A4 RID: 202916 RVA: 0x006B70D8 File Offset: 0x006B52D8
		public IPreloadCharacterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D138 RID: 53560
		// (get) Token: 0x060318A5 RID: 202917 RVA: 0x006B70E8 File Offset: 0x006B52E8
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

		// Token: 0x060318A6 RID: 202918 RVA: 0x006B7124 File Offset: 0x006B5324
		public static Offset<IPreloadCharacterType> CreateIPreloadCharacterType(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill)
		{
			builder.StartTable(1);
			IPreloadCharacterType.AddType(builder, Type);
			return IPreloadCharacterType.EndIPreloadCharacterType(builder);
		}

		// Token: 0x060318A7 RID: 202919 RVA: 0x006B713A File Offset: 0x006B533A
		public static void StartIPreloadCharacterType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060318A8 RID: 202920 RVA: 0x006B7143 File Offset: 0x006B5343
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060318A9 RID: 202921 RVA: 0x006B714E File Offset: 0x006B534E
		public static Offset<IPreloadCharacterType> EndIPreloadCharacterType(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadCharacterType>(builder.EndTable());
		}

		// Token: 0x060318AA RID: 202922 RVA: 0x006B715C File Offset: 0x006B535C
		public IPreloadCharacterTypeT UnPack()
		{
			IPreloadCharacterTypeT preloadCharacterTypeT = new IPreloadCharacterTypeT();
			this.UnPackTo(preloadCharacterTypeT);
			return preloadCharacterTypeT;
		}

		// Token: 0x060318AB RID: 202923 RVA: 0x006B7177 File Offset: 0x006B5377
		public void UnPackTo(IPreloadCharacterTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060318AC RID: 202924 RVA: 0x006B7188 File Offset: 0x006B5388
		public static Offset<IPreloadCharacterType> Pack(FlatBufferBuilder builder, IPreloadCharacterTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadCharacterType>);
			}
			return IPreloadCharacterType.CreateIPreloadCharacterType(builder, _o.Type);
		}

		// Token: 0x04011759 RID: 71513
		private Table __p;
	}
}
