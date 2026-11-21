using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC7 RID: 3271
	public struct DebugEntranceConfig : IFlatbufferObject
	{
		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600671D RID: 26397 RVA: 0x00230BC4 File Offset: 0x0022EDC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x00230BD1 File Offset: 0x0022EDD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x00230BD8 File Offset: 0x0022EDD8
		public static DebugEntranceConfig GetRootAsDebugEntranceConfig(ByteBuffer _bb)
		{
			return DebugEntranceConfig.GetRootAsDebugEntranceConfig(_bb, default(DebugEntranceConfig));
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x00230BF4 File Offset: 0x0022EDF4
		public static DebugEntranceConfig GetRootAsDebugEntranceConfig(ByteBuffer _bb, DebugEntranceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x00230C11 File Offset: 0x0022EE11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x00230C20 File Offset: 0x0022EE20
		public DebugEntranceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06006723 RID: 26403 RVA: 0x00230C30 File Offset: 0x0022EE30
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

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06006724 RID: 26404 RVA: 0x00230C6C File Offset: 0x0022EE6C
		public int Type
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

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06006725 RID: 26405 RVA: 0x00230CA8 File Offset: 0x0022EEA8
		public string Name
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

		// Token: 0x06006726 RID: 26406 RVA: 0x00230CDF File Offset: 0x0022EEDF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006727 RID: 26407 RVA: 0x00230CEE File Offset: 0x0022EEEE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06006728 RID: 26408 RVA: 0x00230D08 File Offset: 0x0022EF08
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006729 RID: 26409 RVA: 0x00230D40 File Offset: 0x0022EF40
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600672A RID: 26410 RVA: 0x00230D50 File Offset: 0x0022EF50
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x0600672B RID: 26411 RVA: 0x00230D68 File Offset: 0x0022EF68
		public string Keywords
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

		// Token: 0x0600672C RID: 26412 RVA: 0x00230DA0 File Offset: 0x0022EFA0
		public Span<byte> GetKeywordsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600672D RID: 26413 RVA: 0x00230DB0 File Offset: 0x0022EFB0
		public byte[] GetKeywordsArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600672E RID: 26414 RVA: 0x00230DC8 File Offset: 0x0022EFC8
		public int Commands(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x0600672F RID: 26415 RVA: 0x00230E08 File Offset: 0x0022F008
		public int CommandsLength
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

		// Token: 0x06006730 RID: 26416 RVA: 0x00230E34 File Offset: 0x0022F034
		public Span<int> GetCommandsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x00230E44 File Offset: 0x0022F044
		public int[] GetCommandsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06006732 RID: 26418 RVA: 0x00230E5C File Offset: 0x0022F05C
		public bool UiEssential
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006733 RID: 26419 RVA: 0x00230E9C File Offset: 0x0022F09C
		[NullableContext(1)]
		public int[] Commands()
		{
			return this.GetCommandsArray();
		}

		// Token: 0x06006734 RID: 26420 RVA: 0x00230EA4 File Offset: 0x0022F0A4
		[NullableContext(1)]
		public IEnumerable<int> CommandsIter()
		{
			DebugEntranceConfig.<CommandsIter>d__32 <CommandsIter>d__ = new DebugEntranceConfig.<CommandsIter>d__32(-2);
			<CommandsIter>d__.<>3__<>4__this = this;
			return <CommandsIter>d__;
		}

		// Token: 0x040051F4 RID: 20980
		private Table __p;
	}
}
