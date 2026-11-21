using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001031 RID: 4145
	public struct PlotGuest : IFlatbufferObject
	{
		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x0600B86A RID: 47210 RVA: 0x002E5BF4 File Offset: 0x002E3DF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B86B RID: 47211 RVA: 0x002E5C01 File Offset: 0x002E3E01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B86C RID: 47212 RVA: 0x002E5C08 File Offset: 0x002E3E08
		public static PlotGuest GetRootAsPlotGuest(ByteBuffer _bb)
		{
			return PlotGuest.GetRootAsPlotGuest(_bb, default(PlotGuest));
		}

		// Token: 0x0600B86D RID: 47213 RVA: 0x002E5C24 File Offset: 0x002E3E24
		public static PlotGuest GetRootAsPlotGuest(ByteBuffer _bb, PlotGuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B86E RID: 47214 RVA: 0x002E5C41 File Offset: 0x002E3E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B86F RID: 47215 RVA: 0x002E5C50 File Offset: 0x002E3E50
		public PlotGuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x0600B870 RID: 47216 RVA: 0x002E5C60 File Offset: 0x002E3E60
		public int GuestID
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

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x0600B871 RID: 47217 RVA: 0x002E5C9C File Offset: 0x002E3E9C
		public string HeadIconPath
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

		// Token: 0x0600B872 RID: 47218 RVA: 0x002E5CD3 File Offset: 0x002E3ED3
		public Span<byte> GetHeadIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B873 RID: 47219 RVA: 0x002E5CE2 File Offset: 0x002E3EE2
		public byte[] GetHeadIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x0600B874 RID: 47220 RVA: 0x002E5CFC File Offset: 0x002E3EFC
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

		// Token: 0x0600B875 RID: 47221 RVA: 0x002E5D33 File Offset: 0x002E3F33
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B876 RID: 47222 RVA: 0x002E5D42 File Offset: 0x002E3F42
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x002E5D5C File Offset: 0x002E3F5C
		public int SpeakerID(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x0600B878 RID: 47224 RVA: 0x002E5D9C File Offset: 0x002E3F9C
		public int SpeakerIDLength
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

		// Token: 0x0600B879 RID: 47225 RVA: 0x002E5DC8 File Offset: 0x002E3FC8
		public Span<int> GetSpeakerIDBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x002E5DD8 File Offset: 0x002E3FD8
		public int[] GetSpeakerIDArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x0600B87B RID: 47227 RVA: 0x002E5DF0 File Offset: 0x002E3FF0
		public string FxColor
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

		// Token: 0x0600B87C RID: 47228 RVA: 0x002E5E28 File Offset: 0x002E4028
		public Span<byte> GetFxColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x002E5E38 File Offset: 0x002E4038
		public byte[] GetFxColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x002E5E50 File Offset: 0x002E4050
		[NullableContext(1)]
		public int[] SpeakerID()
		{
			return this.GetSpeakerIDArray();
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x002E5E58 File Offset: 0x002E4058
		[NullableContext(1)]
		public IEnumerable<int> SpeakerIDIter()
		{
			PlotGuest.<SpeakerIDIter>d__28 <SpeakerIDIter>d__ = new PlotGuest.<SpeakerIDIter>d__28(-2);
			<SpeakerIDIter>d__.<>3__<>4__this = this;
			return <SpeakerIDIter>d__;
		}

		// Token: 0x040055FE RID: 22014
		private Table __p;
	}
}
