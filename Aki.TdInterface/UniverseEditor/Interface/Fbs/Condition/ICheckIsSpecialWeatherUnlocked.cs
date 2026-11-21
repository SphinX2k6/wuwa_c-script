using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F68 RID: 20328
	public struct ICheckIsSpecialWeatherUnlocked : IFlatbufferObject
	{
		// Token: 0x1700914A RID: 37194
		// (get) Token: 0x0601FA33 RID: 129587 RVA: 0x0046649D File Offset: 0x0046469D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FA34 RID: 129588 RVA: 0x004664AA File Offset: 0x004646AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FA35 RID: 129589 RVA: 0x004664B4 File Offset: 0x004646B4
		public static ICheckIsSpecialWeatherUnlocked GetRootAsICheckIsSpecialWeatherUnlocked(ByteBuffer _bb)
		{
			return ICheckIsSpecialWeatherUnlocked.GetRootAsICheckIsSpecialWeatherUnlocked(_bb, default(ICheckIsSpecialWeatherUnlocked));
		}

		// Token: 0x0601FA36 RID: 129590 RVA: 0x004664D0 File Offset: 0x004646D0
		public static ICheckIsSpecialWeatherUnlocked GetRootAsICheckIsSpecialWeatherUnlocked(ByteBuffer _bb, ICheckIsSpecialWeatherUnlocked obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FA37 RID: 129591 RVA: 0x004664ED File Offset: 0x004646ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FA38 RID: 129592 RVA: 0x004664FC File Offset: 0x004646FC
		public ICheckIsSpecialWeatherUnlocked __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700914B RID: 37195
		// (get) Token: 0x0601FA39 RID: 129593 RVA: 0x0046650C File Offset: 0x0046470C
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

		// Token: 0x1700914C RID: 37196
		// (get) Token: 0x0601FA3A RID: 129594 RVA: 0x00466548 File Offset: 0x00464748
		public bool IsUnlocked
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700914D RID: 37197
		// (get) Token: 0x0601FA3B RID: 129595 RVA: 0x00466588 File Offset: 0x00464788
		public int SpecialWeather
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FA3C RID: 129596 RVA: 0x004665C4 File Offset: 0x004647C4
		public static Offset<ICheckIsSpecialWeatherUnlocked> CreateICheckIsSpecialWeatherUnlocked(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsUnlocked = false, int SpecialWeather = 0)
		{
			builder.StartTable(3);
			ICheckIsSpecialWeatherUnlocked.AddSpecialWeather(builder, SpecialWeather);
			ICheckIsSpecialWeatherUnlocked.AddIsUnlocked(builder, IsUnlocked);
			ICheckIsSpecialWeatherUnlocked.AddType(builder, Type);
			return ICheckIsSpecialWeatherUnlocked.EndICheckIsSpecialWeatherUnlocked(builder);
		}

		// Token: 0x0601FA3D RID: 129597 RVA: 0x004665E8 File Offset: 0x004647E8
		public static void StartICheckIsSpecialWeatherUnlocked(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FA3E RID: 129598 RVA: 0x004665F1 File Offset: 0x004647F1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FA3F RID: 129599 RVA: 0x004665FC File Offset: 0x004647FC
		public static void AddIsUnlocked(FlatBufferBuilder builder, bool isUnlocked)
		{
			builder.AddBool(1, isUnlocked, false);
		}

		// Token: 0x0601FA40 RID: 129600 RVA: 0x00466607 File Offset: 0x00464807
		public static void AddSpecialWeather(FlatBufferBuilder builder, int specialWeather)
		{
			builder.AddInt(2, specialWeather, 0);
		}

		// Token: 0x0601FA41 RID: 129601 RVA: 0x00466612 File Offset: 0x00464812
		public static Offset<ICheckIsSpecialWeatherUnlocked> EndICheckIsSpecialWeatherUnlocked(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsSpecialWeatherUnlocked>(builder.EndTable());
		}

		// Token: 0x0601FA42 RID: 129602 RVA: 0x00466620 File Offset: 0x00464820
		public ICheckIsSpecialWeatherUnlockedT UnPack()
		{
			ICheckIsSpecialWeatherUnlockedT checkIsSpecialWeatherUnlockedT = new ICheckIsSpecialWeatherUnlockedT();
			this.UnPackTo(checkIsSpecialWeatherUnlockedT);
			return checkIsSpecialWeatherUnlockedT;
		}

		// Token: 0x0601FA43 RID: 129603 RVA: 0x0046663B File Offset: 0x0046483B
		public void UnPackTo(ICheckIsSpecialWeatherUnlockedT _o)
		{
			_o.Type = this.Type;
			_o.IsUnlocked = this.IsUnlocked;
			_o.SpecialWeather = this.SpecialWeather;
		}

		// Token: 0x0601FA44 RID: 129604 RVA: 0x00466664 File Offset: 0x00464864
		public static Offset<ICheckIsSpecialWeatherUnlocked> Pack(FlatBufferBuilder builder, ICheckIsSpecialWeatherUnlockedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsSpecialWeatherUnlocked>);
			}
			return ICheckIsSpecialWeatherUnlocked.CreateICheckIsSpecialWeatherUnlocked(builder, _o.Type, _o.IsUnlocked, _o.SpecialWeather);
		}

		// Token: 0x0400DDF0 RID: 56816
		private Table __p;
	}
}
