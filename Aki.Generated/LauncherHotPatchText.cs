using System;
using Google.FlatBuffers;

// Token: 0x02000002 RID: 2
public struct LauncherHotPatchText : IFlatbufferObject
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	public ByteBuffer ByteBuffer
	{
		get
		{
			return this.__p.bb;
		}
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000205D File Offset: 0x0000025D
	public static void ValidateVersion()
	{
		FlatBufferConstants.FLATBUFFERS_25_2_10();
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002064 File Offset: 0x00000264
	public static LauncherHotPatchText GetRootAsLauncherHotPatchText(ByteBuffer _bb)
	{
		return LauncherHotPatchText.GetRootAsLauncherHotPatchText(_bb, default(LauncherHotPatchText));
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
	public static LauncherHotPatchText GetRootAsLauncherHotPatchText(ByteBuffer _bb, LauncherHotPatchText obj)
	{
		return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000209D File Offset: 0x0000029D
	public void __init(int _i, ByteBuffer _bb)
	{
		this.__p = new Table(_i, _bb);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000020AC File Offset: 0x000002AC
	public LauncherHotPatchText __assign(int _i, ByteBuffer _bb)
	{
		this.__init(_i, _bb);
		return this;
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000007 RID: 7 RVA: 0x000020BC File Offset: 0x000002BC
	public string Id
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

	// Token: 0x06000008 RID: 8 RVA: 0x000020F3 File Offset: 0x000002F3
	public Span<byte> GetIdBytes()
	{
		return this.__p.__vector_as_span<byte>(4, 1);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002102 File Offset: 0x00000302
	public byte[] GetIdArray()
	{
		return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000A RID: 10 RVA: 0x0000211C File Offset: 0x0000031C
	public int Text
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

	// Token: 0x04000001 RID: 1
	private Table __p;
}
