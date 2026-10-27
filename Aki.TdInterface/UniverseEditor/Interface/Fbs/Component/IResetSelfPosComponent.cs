using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005861 RID: 22625
	public struct IResetSelfPosComponent : IFlatbufferObject
	{
		// Token: 0x1700A921 RID: 43297
		// (get) Token: 0x06026194 RID: 156052 RVA: 0x00540B8A File Offset: 0x0053ED8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026195 RID: 156053 RVA: 0x00540B97 File Offset: 0x0053ED97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026196 RID: 156054 RVA: 0x00540BA0 File Offset: 0x0053EDA0
		public static IResetSelfPosComponent GetRootAsIResetSelfPosComponent(ByteBuffer _bb)
		{
			return IResetSelfPosComponent.GetRootAsIResetSelfPosComponent(_bb, default(IResetSelfPosComponent));
		}

		// Token: 0x06026197 RID: 156055 RVA: 0x00540BBC File Offset: 0x0053EDBC
		public static IResetSelfPosComponent GetRootAsIResetSelfPosComponent(ByteBuffer _bb, IResetSelfPosComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026198 RID: 156056 RVA: 0x00540BD9 File Offset: 0x0053EDD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026199 RID: 156057 RVA: 0x00540BE8 File Offset: 0x0053EDE8
		public IResetSelfPosComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A922 RID: 43298
		// (get) Token: 0x0602619A RID: 156058 RVA: 0x00540BF8 File Offset: 0x0053EDF8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A923 RID: 43299
		// (get) Token: 0x0602619B RID: 156059 RVA: 0x00540C38 File Offset: 0x0053EE38
		public float ResetRadius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A924 RID: 43300
		// (get) Token: 0x0602619C RID: 156060 RVA: 0x00540C78 File Offset: 0x0053EE78
		public bool IsDisableResetPosAfterThrow
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A925 RID: 43301
		// (get) Token: 0x0602619D RID: 156061 RVA: 0x00540CB8 File Offset: 0x0053EEB8
		public bool IsResetPosAfterThrow
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A926 RID: 43302
		// (get) Token: 0x0602619E RID: 156062 RVA: 0x00540CF8 File Offset: 0x0053EEF8
		public float ResetPosDelayTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A927 RID: 43303
		// (get) Token: 0x0602619F RID: 156063 RVA: 0x00540D3C File Offset: 0x0053EF3C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060261A0 RID: 156064 RVA: 0x00540D79 File Offset: 0x0053EF79
		public static Offset<IResetSelfPosComponent> CreateIResetSelfPosComponent(FlatBufferBuilder builder, bool Disabled = false, float ResetRadius = 0f, bool IsDisableResetPosAfterThrow = false, bool IsResetPosAfterThrow = false, float ResetPosDelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IResetSelfPosComponent.AddResetPosDelayTime(builder, ResetPosDelayTime);
			IResetSelfPosComponent.AddResetRadius(builder, ResetRadius);
			IResetSelfPosComponent.AddNullMask(builder, NullMask);
			IResetSelfPosComponent.AddIsResetPosAfterThrow(builder, IsResetPosAfterThrow);
			IResetSelfPosComponent.AddIsDisableResetPosAfterThrow(builder, IsDisableResetPosAfterThrow);
			IResetSelfPosComponent.AddDisabled(builder, Disabled);
			return IResetSelfPosComponent.EndIResetSelfPosComponent(builder);
		}

		// Token: 0x060261A1 RID: 156065 RVA: 0x00540DB5 File Offset: 0x0053EFB5
		public static void StartIResetSelfPosComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060261A2 RID: 156066 RVA: 0x00540DBE File Offset: 0x0053EFBE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060261A3 RID: 156067 RVA: 0x00540DC9 File Offset: 0x0053EFC9
		public static void AddResetRadius(FlatBufferBuilder builder, float resetRadius)
		{
			builder.AddFloat(1, resetRadius, 0.0);
		}

		// Token: 0x060261A4 RID: 156068 RVA: 0x00540DDC File Offset: 0x0053EFDC
		public static void AddIsDisableResetPosAfterThrow(FlatBufferBuilder builder, bool isDisableResetPosAfterThrow)
		{
			builder.AddBool(2, isDisableResetPosAfterThrow, false);
		}

		// Token: 0x060261A5 RID: 156069 RVA: 0x00540DE7 File Offset: 0x0053EFE7
		public static void AddIsResetPosAfterThrow(FlatBufferBuilder builder, bool isResetPosAfterThrow)
		{
			builder.AddBool(3, isResetPosAfterThrow, false);
		}

		// Token: 0x060261A6 RID: 156070 RVA: 0x00540DF2 File Offset: 0x0053EFF2
		public static void AddResetPosDelayTime(FlatBufferBuilder builder, float resetPosDelayTime)
		{
			builder.AddFloat(4, resetPosDelayTime, 0.0);
		}

		// Token: 0x060261A7 RID: 156071 RVA: 0x00540E05 File Offset: 0x0053F005
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060261A8 RID: 156072 RVA: 0x00540E10 File Offset: 0x0053F010
		public static Offset<IResetSelfPosComponent> EndIResetSelfPosComponent(FlatBufferBuilder builder)
		{
			return new Offset<IResetSelfPosComponent>(builder.EndTable());
		}

		// Token: 0x060261A9 RID: 156073 RVA: 0x00540E20 File Offset: 0x0053F020
		public IResetSelfPosComponentT UnPack()
		{
			IResetSelfPosComponentT resetSelfPosComponentT = new IResetSelfPosComponentT();
			this.UnPackTo(resetSelfPosComponentT);
			return resetSelfPosComponentT;
		}

		// Token: 0x060261AA RID: 156074 RVA: 0x00540E3C File Offset: 0x0053F03C
		public void UnPackTo(IResetSelfPosComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ResetRadius = this.ResetRadius;
			_o.IsDisableResetPosAfterThrow = this.IsDisableResetPosAfterThrow;
			_o.IsResetPosAfterThrow = this.IsResetPosAfterThrow;
			_o.ResetPosDelayTime = this.ResetPosDelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060261AB RID: 156075 RVA: 0x00540E94 File Offset: 0x0053F094
		public static Offset<IResetSelfPosComponent> Pack(FlatBufferBuilder builder, IResetSelfPosComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetSelfPosComponent>);
			}
			return IResetSelfPosComponent.CreateIResetSelfPosComponent(builder, _o.Disabled, _o.ResetRadius, _o.IsDisableResetPosAfterThrow, _o.IsResetPosAfterThrow, _o.ResetPosDelayTime, _o.NullMask);
		}

		// Token: 0x0400ED96 RID: 60822
		private Table __p;
	}
}
