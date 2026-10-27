using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200598F RID: 22927
	public struct ISpringComponent : IFlatbufferObject
	{
		// Token: 0x1700AC0C RID: 44044
		// (get) Token: 0x06026D3A RID: 159034 RVA: 0x00558198 File Offset: 0x00556398
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D3B RID: 159035 RVA: 0x005581A5 File Offset: 0x005563A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D3C RID: 159036 RVA: 0x005581AC File Offset: 0x005563AC
		public static ISpringComponent GetRootAsISpringComponent(ByteBuffer _bb)
		{
			return ISpringComponent.GetRootAsISpringComponent(_bb, default(ISpringComponent));
		}

		// Token: 0x06026D3D RID: 159037 RVA: 0x005581C8 File Offset: 0x005563C8
		public static ISpringComponent GetRootAsISpringComponent(ByteBuffer _bb, ISpringComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D3E RID: 159038 RVA: 0x005581E5 File Offset: 0x005563E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D3F RID: 159039 RVA: 0x005581F4 File Offset: 0x005563F4
		public ISpringComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC0D RID: 44045
		// (get) Token: 0x06026D40 RID: 159040 RVA: 0x00558204 File Offset: 0x00556404
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AC0E RID: 44046
		// (get) Token: 0x06026D41 RID: 159041 RVA: 0x00558244 File Offset: 0x00556444
		public bool IsNormalSpring
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AC0F RID: 44047
		// (get) Token: 0x06026D42 RID: 159042 RVA: 0x00558284 File Offset: 0x00556484
		public bool IsHitNormalSpring
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AC10 RID: 44048
		// (get) Token: 0x06026D43 RID: 159043 RVA: 0x005582C4 File Offset: 0x005564C4
		public ISettingSpringDir? SettingDir
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISettingSpringDir?(default(ISettingSpringDir).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC11 RID: 44049
		// (get) Token: 0x06026D44 RID: 159044 RVA: 0x00558324 File Offset: 0x00556524
		public int SpringPow
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC12 RID: 44050
		// (get) Token: 0x06026D45 RID: 159045 RVA: 0x00558364 File Offset: 0x00556564
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

		// Token: 0x06026D46 RID: 159046 RVA: 0x005583A1 File Offset: 0x005565A1
		public static Offset<ISpringComponent> CreateISpringComponent(FlatBufferBuilder builder, bool Disabled = false, bool IsNormalSpring = false, bool IsHitNormalSpring = false, Offset<ISettingSpringDir> SettingDirOffset = default(Offset<ISettingSpringDir>), int SpringPow = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			ISpringComponent.AddSpringPow(builder, SpringPow);
			ISpringComponent.AddSettingDir(builder, SettingDirOffset);
			ISpringComponent.AddNullMask(builder, NullMask);
			ISpringComponent.AddIsHitNormalSpring(builder, IsHitNormalSpring);
			ISpringComponent.AddIsNormalSpring(builder, IsNormalSpring);
			ISpringComponent.AddDisabled(builder, Disabled);
			return ISpringComponent.EndISpringComponent(builder);
		}

		// Token: 0x06026D47 RID: 159047 RVA: 0x005583DD File Offset: 0x005565DD
		public static void StartISpringComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06026D48 RID: 159048 RVA: 0x005583E6 File Offset: 0x005565E6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026D49 RID: 159049 RVA: 0x005583F1 File Offset: 0x005565F1
		public static void AddIsNormalSpring(FlatBufferBuilder builder, bool isNormalSpring)
		{
			builder.AddBool(1, isNormalSpring, false);
		}

		// Token: 0x06026D4A RID: 159050 RVA: 0x005583FC File Offset: 0x005565FC
		public static void AddIsHitNormalSpring(FlatBufferBuilder builder, bool isHitNormalSpring)
		{
			builder.AddBool(2, isHitNormalSpring, false);
		}

		// Token: 0x06026D4B RID: 159051 RVA: 0x00558407 File Offset: 0x00556607
		public static void AddSettingDir(FlatBufferBuilder builder, Offset<ISettingSpringDir> settingDirOffset)
		{
			builder.AddOffset(3, settingDirOffset.Value, 0);
		}

		// Token: 0x06026D4C RID: 159052 RVA: 0x00558417 File Offset: 0x00556617
		public static void AddSpringPow(FlatBufferBuilder builder, int springPow)
		{
			builder.AddInt(4, springPow, 0);
		}

		// Token: 0x06026D4D RID: 159053 RVA: 0x00558422 File Offset: 0x00556622
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06026D4E RID: 159054 RVA: 0x0055842D File Offset: 0x0055662D
		public static Offset<ISpringComponent> EndISpringComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISpringComponent>(builder.EndTable());
		}

		// Token: 0x06026D4F RID: 159055 RVA: 0x0055843C File Offset: 0x0055663C
		public ISpringComponentT UnPack()
		{
			ISpringComponentT springComponentT = new ISpringComponentT();
			this.UnPackTo(springComponentT);
			return springComponentT;
		}

		// Token: 0x06026D50 RID: 159056 RVA: 0x00558458 File Offset: 0x00556658
		public void UnPackTo(ISpringComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.IsNormalSpring = this.IsNormalSpring;
			_o.IsHitNormalSpring = this.IsHitNormalSpring;
			_o.SettingDir = ((this.SettingDir != null) ? this.SettingDir.Value.UnPack() : null);
			_o.SpringPow = this.SpringPow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026D51 RID: 159057 RVA: 0x005584D0 File Offset: 0x005566D0
		public static Offset<ISpringComponent> Pack(FlatBufferBuilder builder, ISpringComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpringComponent>);
			}
			Offset<ISettingSpringDir> settingDirOffset = (_o.SettingDir == null) ? default(Offset<ISettingSpringDir>) : ISettingSpringDir.Pack(builder, _o.SettingDir);
			return ISpringComponent.CreateISpringComponent(builder, _o.Disabled, _o.IsNormalSpring, _o.IsHitNormalSpring, settingDirOffset, _o.SpringPow, _o.NullMask);
		}

		// Token: 0x0400EF93 RID: 61331
		private Table __p;
	}
}
