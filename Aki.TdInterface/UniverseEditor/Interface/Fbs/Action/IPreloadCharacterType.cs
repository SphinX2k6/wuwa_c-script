using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007507 RID: 29959
	public struct IPreloadCharacterType : IFlatbufferObject
	{
		// Token: 0x1700DC7F RID: 56447
		// (get) Token: 0x0603489B RID: 215195 RVA: 0x00712761 File Offset: 0x00710961
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603489C RID: 215196 RVA: 0x0071276E File Offset: 0x0071096E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603489D RID: 215197 RVA: 0x00712778 File Offset: 0x00710978
		public static IPreloadCharacterType GetRootAsIPreloadCharacterType(ByteBuffer _bb)
		{
			return IPreloadCharacterType.GetRootAsIPreloadCharacterType(_bb, default(IPreloadCharacterType));
		}

		// Token: 0x0603489E RID: 215198 RVA: 0x00712794 File Offset: 0x00710994
		public static IPreloadCharacterType GetRootAsIPreloadCharacterType(ByteBuffer _bb, IPreloadCharacterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603489F RID: 215199 RVA: 0x007127B1 File Offset: 0x007109B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060348A0 RID: 215200 RVA: 0x007127C0 File Offset: 0x007109C0
		public IPreloadCharacterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC80 RID: 56448
		// (get) Token: 0x060348A1 RID: 215201 RVA: 0x007127D0 File Offset: 0x007109D0
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

		// Token: 0x060348A2 RID: 215202 RVA: 0x0071280C File Offset: 0x00710A0C
		public static Offset<IPreloadCharacterType> CreateIPreloadCharacterType(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill)
		{
			builder.StartTable(1);
			IPreloadCharacterType.AddType(builder, Type);
			return IPreloadCharacterType.EndIPreloadCharacterType(builder);
		}

		// Token: 0x060348A3 RID: 215203 RVA: 0x00712822 File Offset: 0x00710A22
		public static void StartIPreloadCharacterType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060348A4 RID: 215204 RVA: 0x0071282B File Offset: 0x00710A2B
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060348A5 RID: 215205 RVA: 0x00712836 File Offset: 0x00710A36
		public static Offset<IPreloadCharacterType> EndIPreloadCharacterType(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadCharacterType>(builder.EndTable());
		}

		// Token: 0x060348A6 RID: 215206 RVA: 0x00712844 File Offset: 0x00710A44
		public IPreloadCharacterTypeT UnPack()
		{
			IPreloadCharacterTypeT preloadCharacterTypeT = new IPreloadCharacterTypeT();
			this.UnPackTo(preloadCharacterTypeT);
			return preloadCharacterTypeT;
		}

		// Token: 0x060348A7 RID: 215207 RVA: 0x0071285F File Offset: 0x00710A5F
		public void UnPackTo(IPreloadCharacterTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060348A8 RID: 215208 RVA: 0x00712870 File Offset: 0x00710A70
		public static Offset<IPreloadCharacterType> Pack(FlatBufferBuilder builder, IPreloadCharacterTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadCharacterType>);
			}
			return IPreloadCharacterType.CreateIPreloadCharacterType(builder, _o.Type);
		}

		// Token: 0x040126D5 RID: 75477
		private Table __p;
	}
}
