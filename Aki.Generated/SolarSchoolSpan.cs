using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001207 RID: 4615
	public struct SolarSchoolSpan : IFlatbufferObject
	{
		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x0600E41E RID: 58398 RVA: 0x00347130 File Offset: 0x00345330
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E41F RID: 58399 RVA: 0x0034713D File Offset: 0x0034533D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E420 RID: 58400 RVA: 0x00347144 File Offset: 0x00345344
		public static SolarSchoolSpan GetRootAsSolarSchoolSpan(ByteBuffer _bb)
		{
			return SolarSchoolSpan.GetRootAsSolarSchoolSpan(_bb, default(SolarSchoolSpan));
		}

		// Token: 0x0600E421 RID: 58401 RVA: 0x00347160 File Offset: 0x00345360
		public static SolarSchoolSpan GetRootAsSolarSchoolSpan(ByteBuffer _bb, SolarSchoolSpan obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E422 RID: 58402 RVA: 0x0034717D File Offset: 0x0034537D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E423 RID: 58403 RVA: 0x0034718C File Offset: 0x0034538C
		public SolarSchoolSpan __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x0600E424 RID: 58404 RVA: 0x0034719C File Offset: 0x0034539C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x0600E425 RID: 58405 RVA: 0x003471D8 File Offset: 0x003453D8
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x0600E426 RID: 58406 RVA: 0x00347214 File Offset: 0x00345414
		public int StartDayIndex
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

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x0600E427 RID: 58407 RVA: 0x00347250 File Offset: 0x00345450
		public int EndDayIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x0600E428 RID: 58408 RVA: 0x00347290 File Offset: 0x00345490
		public string ModifierType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E429 RID: 58409 RVA: 0x003472C8 File Offset: 0x003454C8
		public Span<byte> GetModifierTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E42A RID: 58410 RVA: 0x003472D8 File Offset: 0x003454D8
		public byte[] GetModifierTypeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E42B RID: 58411 RVA: 0x003472F0 File Offset: 0x003454F0
		public DicStringString? ModifierParams(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x0600E42C RID: 58412 RVA: 0x00347354 File Offset: 0x00345554
		public int ModifierParamsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x0600E42D RID: 58413 RVA: 0x00347380 File Offset: 0x00345580
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E42E RID: 58414 RVA: 0x003473C0 File Offset: 0x003455C0
		[NullableContext(1)]
		public Dictionary<string, string> ModifierParams()
		{
			return this.ModifierParamsIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600E42F RID: 58415 RVA: 0x00347416 File Offset: 0x00345616
		[NullableContext(1)]
		public IEnumerable<DicStringString> ModifierParamsIter()
		{
			SolarSchoolSpan.<ModifierParamsIter>d__26 <ModifierParamsIter>d__ = new SolarSchoolSpan.<ModifierParamsIter>d__26(-2);
			<ModifierParamsIter>d__.<>3__<>4__this = this;
			return <ModifierParamsIter>d__;
		}

		// Token: 0x0600E430 RID: 58416 RVA: 0x0034742C File Offset: 0x0034562C
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetModifierParams(string key)
		{
			this.EnsureModifierParamsCacheIfNeeded();
			string result;
			if (!this.ModifierParamsCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600E431 RID: 58417 RVA: 0x00347454 File Offset: 0x00345654
		private void EnsureModifierParamsCacheIfNeeded()
		{
			if (this.ModifierParamsCache != null)
			{
				return;
			}
			this.ModifierParamsCache = this.ModifierParamsIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600E432 RID: 58418 RVA: 0x003474BA File Offset: 0x003456BA
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetModifierParamsFrozenDict()
		{
			this.EnsureModifierParamsCacheIfNeeded();
			return this.ModifierParamsCache;
		}

		// Token: 0x04005846 RID: 22598
		private Table __p;

		// Token: 0x04005847 RID: 22599
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> ModifierParamsCache;
	}
}
