using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119B RID: 4507
	public struct WeaponSceneInteract : IFlatbufferObject
	{
		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x0600E837 RID: 59447 RVA: 0x003435F5 File Offset: 0x003417F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E838 RID: 59448 RVA: 0x00343602 File Offset: 0x00341802
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E839 RID: 59449 RVA: 0x0034360C File Offset: 0x0034180C
		public static WeaponSceneInteract GetRootAsWeaponSceneInteract(ByteBuffer _bb)
		{
			return WeaponSceneInteract.GetRootAsWeaponSceneInteract(_bb, default(WeaponSceneInteract));
		}

		// Token: 0x0600E83A RID: 59450 RVA: 0x00343628 File Offset: 0x00341828
		public static WeaponSceneInteract GetRootAsWeaponSceneInteract(ByteBuffer _bb, WeaponSceneInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E83B RID: 59451 RVA: 0x00343645 File Offset: 0x00341845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E83C RID: 59452 RVA: 0x00343654 File Offset: 0x00341854
		public WeaponSceneInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x0600E83D RID: 59453 RVA: 0x00343664 File Offset: 0x00341864
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

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x0600E83E RID: 59454 RVA: 0x003436A0 File Offset: 0x003418A0
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

		// Token: 0x0600E83F RID: 59455 RVA: 0x003436D7 File Offset: 0x003418D7
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E840 RID: 59456 RVA: 0x003436E6 File Offset: 0x003418E6
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040052E6 RID: 21222
		private Table __p;
	}
}
