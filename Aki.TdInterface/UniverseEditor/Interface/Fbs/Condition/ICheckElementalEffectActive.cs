using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049E2 RID: 18914
	public struct ICheckElementalEffectActive : IFlatbufferObject
	{
		// Token: 0x170088C9 RID: 35017
		// (get) Token: 0x0601D8BA RID: 121018 RVA: 0x00428DC4 File Offset: 0x00426FC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D8BB RID: 121019 RVA: 0x00428DD1 File Offset: 0x00426FD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D8BC RID: 121020 RVA: 0x00428DD8 File Offset: 0x00426FD8
		public static ICheckElementalEffectActive GetRootAsICheckElementalEffectActive(ByteBuffer _bb)
		{
			return ICheckElementalEffectActive.GetRootAsICheckElementalEffectActive(_bb, default(ICheckElementalEffectActive));
		}

		// Token: 0x0601D8BD RID: 121021 RVA: 0x00428DF4 File Offset: 0x00426FF4
		public static ICheckElementalEffectActive GetRootAsICheckElementalEffectActive(ByteBuffer _bb, ICheckElementalEffectActive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D8BE RID: 121022 RVA: 0x00428E11 File Offset: 0x00427011
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D8BF RID: 121023 RVA: 0x00428E20 File Offset: 0x00427020
		public ICheckElementalEffectActive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088CA RID: 35018
		// (get) Token: 0x0601D8C0 RID: 121024 RVA: 0x00428E30 File Offset: 0x00427030
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170088CB RID: 35019
		// (get) Token: 0x0601D8C1 RID: 121025 RVA: 0x00428E6C File Offset: 0x0042706C
		public bool IsActive
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D8C2 RID: 121026 RVA: 0x00428EAB File Offset: 0x004270AB
		public static Offset<ICheckElementalEffectActive> CreateICheckElementalEffectActive(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsActive = false)
		{
			builder.StartTable(2);
			ICheckElementalEffectActive.AddIsActive(builder, IsActive);
			ICheckElementalEffectActive.AddType(builder, Type);
			return ICheckElementalEffectActive.EndICheckElementalEffectActive(builder);
		}

		// Token: 0x0601D8C3 RID: 121027 RVA: 0x00428EC8 File Offset: 0x004270C8
		public static void StartICheckElementalEffectActive(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D8C4 RID: 121028 RVA: 0x00428ED1 File Offset: 0x004270D1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D8C5 RID: 121029 RVA: 0x00428EDC File Offset: 0x004270DC
		public static void AddIsActive(FlatBufferBuilder builder, bool isActive)
		{
			builder.AddBool(1, isActive, false);
		}

		// Token: 0x0601D8C6 RID: 121030 RVA: 0x00428EE7 File Offset: 0x004270E7
		public static Offset<ICheckElementalEffectActive> EndICheckElementalEffectActive(FlatBufferBuilder builder)
		{
			return new Offset<ICheckElementalEffectActive>(builder.EndTable());
		}

		// Token: 0x0601D8C7 RID: 121031 RVA: 0x00428EF4 File Offset: 0x004270F4
		public ICheckElementalEffectActiveT UnPack()
		{
			ICheckElementalEffectActiveT checkElementalEffectActiveT = new ICheckElementalEffectActiveT();
			this.UnPackTo(checkElementalEffectActiveT);
			return checkElementalEffectActiveT;
		}

		// Token: 0x0601D8C8 RID: 121032 RVA: 0x00428F0F File Offset: 0x0042710F
		public void UnPackTo(ICheckElementalEffectActiveT _o)
		{
			_o.Type = this.Type;
			_o.IsActive = this.IsActive;
		}

		// Token: 0x0601D8C9 RID: 121033 RVA: 0x00428F2C File Offset: 0x0042712C
		public static Offset<ICheckElementalEffectActive> Pack(FlatBufferBuilder builder, ICheckElementalEffectActiveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckElementalEffectActive>);
			}
			return ICheckElementalEffectActive.CreateICheckElementalEffectActive(builder, _o.Type, _o.IsActive);
		}

		// Token: 0x0400D212 RID: 53778
		private Table __p;
	}
}
