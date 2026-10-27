using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5B RID: 3419
	public struct ImmersiveMouse : IFlatbufferObject
	{
		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x0600829B RID: 33435 RVA: 0x0025D244 File Offset: 0x0025B444
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600829C RID: 33436 RVA: 0x0025D251 File Offset: 0x0025B451
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600829D RID: 33437 RVA: 0x0025D258 File Offset: 0x0025B458
		public static ImmersiveMouse GetRootAsImmersiveMouse(ByteBuffer _bb)
		{
			return ImmersiveMouse.GetRootAsImmersiveMouse(_bb, default(ImmersiveMouse));
		}

		// Token: 0x0600829E RID: 33438 RVA: 0x0025D274 File Offset: 0x0025B474
		public static ImmersiveMouse GetRootAsImmersiveMouse(ByteBuffer _bb, ImmersiveMouse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600829F RID: 33439 RVA: 0x0025D291 File Offset: 0x0025B491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060082A0 RID: 33440 RVA: 0x0025D2A0 File Offset: 0x0025B4A0
		public ImmersiveMouse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x060082A1 RID: 33441 RVA: 0x0025D2B0 File Offset: 0x0025B4B0
		public string ViewName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060082A2 RID: 33442 RVA: 0x0025D2E7 File Offset: 0x0025B4E7
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x0025D2F6 File Offset: 0x0025B4F6
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x060082A4 RID: 33444 RVA: 0x0025D310 File Offset: 0x0025B510
		public int AutoHideTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 3000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x060082A5 RID: 33445 RVA: 0x0025D350 File Offset: 0x0025B550
		public float DeadZone
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0.1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004DDA RID: 19930
		private Table __p;
	}
}
