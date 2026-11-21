using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012D1 RID: 4817
	public struct WeaponSceneInteract : IFlatbufferObject
	{
		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x0600F5A5 RID: 62885 RVA: 0x0036E316 File Offset: 0x0036C516
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F5A6 RID: 62886 RVA: 0x0036E323 File Offset: 0x0036C523
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F5A7 RID: 62887 RVA: 0x0036E32C File Offset: 0x0036C52C
		public static WeaponSceneInteract GetRootAsWeaponSceneInteract(ByteBuffer _bb)
		{
			return WeaponSceneInteract.GetRootAsWeaponSceneInteract(_bb, default(WeaponSceneInteract));
		}

		// Token: 0x0600F5A8 RID: 62888 RVA: 0x0036E348 File Offset: 0x0036C548
		public static WeaponSceneInteract GetRootAsWeaponSceneInteract(ByteBuffer _bb, WeaponSceneInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F5A9 RID: 62889 RVA: 0x0036E365 File Offset: 0x0036C565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F5AA RID: 62890 RVA: 0x0036E374 File Offset: 0x0036C574
		public WeaponSceneInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004177 RID: 16759
		// (get) Token: 0x0600F5AB RID: 62891 RVA: 0x0036E384 File Offset: 0x0036C584
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

		// Token: 0x17004178 RID: 16760
		// (get) Token: 0x0600F5AC RID: 62892 RVA: 0x0036E3C0 File Offset: 0x0036C5C0
		public string Path
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

		// Token: 0x0600F5AD RID: 62893 RVA: 0x0036E3F7 File Offset: 0x0036C5F7
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F5AE RID: 62894 RVA: 0x0036E406 File Offset: 0x0036C606
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005929 RID: 22825
		private Table __p;
	}
}
