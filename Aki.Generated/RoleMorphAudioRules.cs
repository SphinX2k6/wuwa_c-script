using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113D RID: 4413
	public struct RoleMorphAudioRules : IFlatbufferObject
	{
		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600CFF8 RID: 53240 RVA: 0x00318D7C File Offset: 0x00316F7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFF9 RID: 53241 RVA: 0x00318D89 File Offset: 0x00316F89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFFA RID: 53242 RVA: 0x00318D90 File Offset: 0x00316F90
		public static RoleMorphAudioRules GetRootAsRoleMorphAudioRules(ByteBuffer _bb)
		{
			return RoleMorphAudioRules.GetRootAsRoleMorphAudioRules(_bb, default(RoleMorphAudioRules));
		}

		// Token: 0x0600CFFB RID: 53243 RVA: 0x00318DAC File Offset: 0x00316FAC
		public static RoleMorphAudioRules GetRootAsRoleMorphAudioRules(ByteBuffer _bb, RoleMorphAudioRules obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFFC RID: 53244 RVA: 0x00318DC9 File Offset: 0x00316FC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFFD RID: 53245 RVA: 0x00318DD8 File Offset: 0x00316FD8
		public RoleMorphAudioRules __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600CFFE RID: 53246 RVA: 0x00318DE8 File Offset: 0x00316FE8
		public int MorphId
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

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600CFFF RID: 53247 RVA: 0x00318E24 File Offset: 0x00317024
		public string EnterMorphSwitch
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D000 RID: 53248 RVA: 0x00318E5B File Offset: 0x0031705B
		public Span<byte> GetEnterMorphSwitchBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D001 RID: 53249 RVA: 0x00318E6A File Offset: 0x0031706A
		public byte[] GetEnterMorphSwitchArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600D002 RID: 53250 RVA: 0x00318E84 File Offset: 0x00317084
		public string ExitMorphEvent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D003 RID: 53251 RVA: 0x00318EBB File Offset: 0x003170BB
		public Span<byte> GetExitMorphEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D004 RID: 53252 RVA: 0x00318ECA File Offset: 0x003170CA
		public byte[] GetExitMorphEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D005 RID: 53253 RVA: 0x00318EE4 File Offset: 0x003170E4
		public int IgnoredTypeList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600D006 RID: 53254 RVA: 0x00318F24 File Offset: 0x00317124
		public int IgnoredTypeListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D007 RID: 53255 RVA: 0x00318F50 File Offset: 0x00317150
		public Span<int> GetIgnoredTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600D008 RID: 53256 RVA: 0x00318F60 File Offset: 0x00317160
		public int[] GetIgnoredTypeListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600D009 RID: 53257 RVA: 0x00318F78 File Offset: 0x00317178
		public string IgnoredEventList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600D00A RID: 53258 RVA: 0x00318FB4 File Offset: 0x003171B4
		public int IgnoredEventListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D00B RID: 53259 RVA: 0x00318FE0 File Offset: 0x003171E0
		[NullableContext(1)]
		public string[] IgnoredEventList()
		{
			return this.IgnoredEventListIter().ToArray<string>();
		}

		// Token: 0x0600D00C RID: 53260 RVA: 0x00318FED File Offset: 0x003171ED
		[NullableContext(1)]
		public IEnumerable<string> IgnoredEventListIter()
		{
			RoleMorphAudioRules.<IgnoredEventListIter>d__27 <IgnoredEventListIter>d__ = new RoleMorphAudioRules.<IgnoredEventListIter>d__27(-2);
			<IgnoredEventListIter>d__.<>3__<>4__this = this;
			return <IgnoredEventListIter>d__;
		}

		// Token: 0x0600D00D RID: 53261 RVA: 0x00319002 File Offset: 0x00317202
		[NullableContext(1)]
		public int[] IgnoredTypeList()
		{
			return this.GetIgnoredTypeListArray();
		}

		// Token: 0x0600D00E RID: 53262 RVA: 0x0031900A File Offset: 0x0031720A
		[NullableContext(1)]
		public IEnumerable<int> IgnoredTypeListIter()
		{
			RoleMorphAudioRules.<IgnoredTypeListIter>d__29 <IgnoredTypeListIter>d__ = new RoleMorphAudioRules.<IgnoredTypeListIter>d__29(-2);
			<IgnoredTypeListIter>d__.<>3__<>4__this = this;
			return <IgnoredTypeListIter>d__;
		}

		// Token: 0x0400573E RID: 22334
		private Table __p;
	}
}
