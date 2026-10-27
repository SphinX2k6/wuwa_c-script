using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200468D RID: 18061
	public struct ISetEquippedWeaponToGraduate : IFlatbufferObject
	{
		// Token: 0x17008036 RID: 32822
		// (get) Token: 0x0601B6B5 RID: 112309 RVA: 0x003E5405 File Offset: 0x003E3605
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B6B6 RID: 112310 RVA: 0x003E5412 File Offset: 0x003E3612
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B6B7 RID: 112311 RVA: 0x003E541C File Offset: 0x003E361C
		public static ISetEquippedWeaponToGraduate GetRootAsISetEquippedWeaponToGraduate(ByteBuffer _bb)
		{
			return ISetEquippedWeaponToGraduate.GetRootAsISetEquippedWeaponToGraduate(_bb, default(ISetEquippedWeaponToGraduate));
		}

		// Token: 0x0601B6B8 RID: 112312 RVA: 0x003E5438 File Offset: 0x003E3638
		public static ISetEquippedWeaponToGraduate GetRootAsISetEquippedWeaponToGraduate(ByteBuffer _bb, ISetEquippedWeaponToGraduate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B6B9 RID: 112313 RVA: 0x003E5455 File Offset: 0x003E3655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B6BA RID: 112314 RVA: 0x003E5464 File Offset: 0x003E3664
		public ISetEquippedWeaponToGraduate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008037 RID: 32823
		// (get) Token: 0x0601B6BB RID: 112315 RVA: 0x003E5474 File Offset: 0x003E3674
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B6BC RID: 112316 RVA: 0x003E54B0 File Offset: 0x003E36B0
		public static Offset<ISetEquippedWeaponToGraduate> CreateISetEquippedWeaponToGraduate(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			ISetEquippedWeaponToGraduate.AddType(builder, Type);
			return ISetEquippedWeaponToGraduate.EndISetEquippedWeaponToGraduate(builder);
		}

		// Token: 0x0601B6BD RID: 112317 RVA: 0x003E54C6 File Offset: 0x003E36C6
		public static void StartISetEquippedWeaponToGraduate(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B6BE RID: 112318 RVA: 0x003E54CF File Offset: 0x003E36CF
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B6BF RID: 112319 RVA: 0x003E54DA File Offset: 0x003E36DA
		public static Offset<ISetEquippedWeaponToGraduate> EndISetEquippedWeaponToGraduate(FlatBufferBuilder builder)
		{
			return new Offset<ISetEquippedWeaponToGraduate>(builder.EndTable());
		}

		// Token: 0x0601B6C0 RID: 112320 RVA: 0x003E54E8 File Offset: 0x003E36E8
		public ISetEquippedWeaponToGraduateT UnPack()
		{
			ISetEquippedWeaponToGraduateT setEquippedWeaponToGraduateT = new ISetEquippedWeaponToGraduateT();
			this.UnPackTo(setEquippedWeaponToGraduateT);
			return setEquippedWeaponToGraduateT;
		}

		// Token: 0x0601B6C1 RID: 112321 RVA: 0x003E5503 File Offset: 0x003E3703
		public void UnPackTo(ISetEquippedWeaponToGraduateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B6C2 RID: 112322 RVA: 0x003E5514 File Offset: 0x003E3714
		public static Offset<ISetEquippedWeaponToGraduate> Pack(FlatBufferBuilder builder, ISetEquippedWeaponToGraduateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetEquippedWeaponToGraduate>);
			}
			return ISetEquippedWeaponToGraduate.CreateISetEquippedWeaponToGraduate(builder, _o.Type);
		}

		// Token: 0x0400C84C RID: 51276
		private Table __p;
	}
}
