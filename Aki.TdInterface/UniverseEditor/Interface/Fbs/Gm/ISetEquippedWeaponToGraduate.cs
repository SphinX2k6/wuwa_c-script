using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AF5 RID: 19189
	public struct ISetEquippedWeaponToGraduate : IFlatbufferObject
	{
		// Token: 0x17008677 RID: 34423
		// (get) Token: 0x0601CE8A RID: 118410 RVA: 0x004116A1 File Offset: 0x0040F8A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE8B RID: 118411 RVA: 0x004116AE File Offset: 0x0040F8AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE8C RID: 118412 RVA: 0x004116B8 File Offset: 0x0040F8B8
		public static ISetEquippedWeaponToGraduate GetRootAsISetEquippedWeaponToGraduate(ByteBuffer _bb)
		{
			return ISetEquippedWeaponToGraduate.GetRootAsISetEquippedWeaponToGraduate(_bb, default(ISetEquippedWeaponToGraduate));
		}

		// Token: 0x0601CE8D RID: 118413 RVA: 0x004116D4 File Offset: 0x0040F8D4
		public static ISetEquippedWeaponToGraduate GetRootAsISetEquippedWeaponToGraduate(ByteBuffer _bb, ISetEquippedWeaponToGraduate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE8E RID: 118414 RVA: 0x004116F1 File Offset: 0x0040F8F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE8F RID: 118415 RVA: 0x00411700 File Offset: 0x0040F900
		public ISetEquippedWeaponToGraduate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008678 RID: 34424
		// (get) Token: 0x0601CE90 RID: 118416 RVA: 0x00411710 File Offset: 0x0040F910
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

		// Token: 0x0601CE91 RID: 118417 RVA: 0x0041174C File Offset: 0x0040F94C
		public static Offset<ISetEquippedWeaponToGraduate> CreateISetEquippedWeaponToGraduate(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			ISetEquippedWeaponToGraduate.AddType(builder, Type);
			return ISetEquippedWeaponToGraduate.EndISetEquippedWeaponToGraduate(builder);
		}

		// Token: 0x0601CE92 RID: 118418 RVA: 0x00411762 File Offset: 0x0040F962
		public static void StartISetEquippedWeaponToGraduate(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CE93 RID: 118419 RVA: 0x0041176B File Offset: 0x0040F96B
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CE94 RID: 118420 RVA: 0x00411776 File Offset: 0x0040F976
		public static Offset<ISetEquippedWeaponToGraduate> EndISetEquippedWeaponToGraduate(FlatBufferBuilder builder)
		{
			return new Offset<ISetEquippedWeaponToGraduate>(builder.EndTable());
		}

		// Token: 0x0601CE95 RID: 118421 RVA: 0x00411784 File Offset: 0x0040F984
		public ISetEquippedWeaponToGraduateT UnPack()
		{
			ISetEquippedWeaponToGraduateT setEquippedWeaponToGraduateT = new ISetEquippedWeaponToGraduateT();
			this.UnPackTo(setEquippedWeaponToGraduateT);
			return setEquippedWeaponToGraduateT;
		}

		// Token: 0x0601CE96 RID: 118422 RVA: 0x0041179F File Offset: 0x0040F99F
		public void UnPackTo(ISetEquippedWeaponToGraduateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CE97 RID: 118423 RVA: 0x004117B0 File Offset: 0x0040F9B0
		public static Offset<ISetEquippedWeaponToGraduate> Pack(FlatBufferBuilder builder, ISetEquippedWeaponToGraduateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetEquippedWeaponToGraduate>);
			}
			return ISetEquippedWeaponToGraduate.CreateISetEquippedWeaponToGraduate(builder, _o.Type);
		}

		// Token: 0x0400D27B RID: 53883
		private Table __p;
	}
}
