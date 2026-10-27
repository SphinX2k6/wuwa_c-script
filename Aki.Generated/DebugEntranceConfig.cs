using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE5 RID: 3045
	public struct DebugEntranceConfig : IFlatbufferObject
	{
		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06006144 RID: 24900 RVA: 0x0021157C File Offset: 0x0020F77C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x00211589 File Offset: 0x0020F789
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x00211590 File Offset: 0x0020F790
		public static DebugEntranceConfig GetRootAsDebugEntranceConfig(ByteBuffer _bb)
		{
			return DebugEntranceConfig.GetRootAsDebugEntranceConfig(_bb, default(DebugEntranceConfig));
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x002115AC File Offset: 0x0020F7AC
		public static DebugEntranceConfig GetRootAsDebugEntranceConfig(ByteBuffer _bb, DebugEntranceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x002115C9 File Offset: 0x0020F7C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x002115D8 File Offset: 0x0020F7D8
		public DebugEntranceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x0600614A RID: 24906 RVA: 0x002115E8 File Offset: 0x0020F7E8
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

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600614B RID: 24907 RVA: 0x00211624 File Offset: 0x0020F824
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

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600614C RID: 24908 RVA: 0x00211660 File Offset: 0x0020F860
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

		// Token: 0x0600614D RID: 24909 RVA: 0x00211697 File Offset: 0x0020F897
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x002116A6 File Offset: 0x0020F8A6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600614F RID: 24911 RVA: 0x002116C0 File Offset: 0x0020F8C0
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

		// Token: 0x06006150 RID: 24912 RVA: 0x002116F8 File Offset: 0x0020F8F8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x00211708 File Offset: 0x0020F908
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06006152 RID: 24914 RVA: 0x00211720 File Offset: 0x0020F920
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

		// Token: 0x06006153 RID: 24915 RVA: 0x00211758 File Offset: 0x0020F958
		public Span<byte> GetKeywordsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x00211768 File Offset: 0x0020F968
		public byte[] GetKeywordsArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x00211780 File Offset: 0x0020F980
		public int Commands(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06006156 RID: 24918 RVA: 0x002117C0 File Offset: 0x0020F9C0
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

		// Token: 0x06006157 RID: 24919 RVA: 0x002117EC File Offset: 0x0020F9EC
		public Span<int> GetCommandsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x002117FC File Offset: 0x0020F9FC
		public int[] GetCommandsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06006159 RID: 24921 RVA: 0x00211814 File Offset: 0x0020FA14
		public bool UiEssential
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x00211854 File Offset: 0x0020FA54
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CommandsIter()或GetCommandsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Commands()
		{
			DebugEntranceConfig debugEntranceConfig = this;
			return debugEntranceConfig.GetCommandsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x00211878 File Offset: 0x0020FA78
		[NullableContext(1)]
		public readonly IEnumerable<int> CommandsIter()
		{
			DebugEntranceConfig.<CommandsIter>d__32 <CommandsIter>d__ = new DebugEntranceConfig.<CommandsIter>d__32(-2);
			<CommandsIter>d__.<>3__<>4__this = this;
			return <CommandsIter>d__;
		}

		// Token: 0x04004C12 RID: 19474
		private Table __p;
	}
}
